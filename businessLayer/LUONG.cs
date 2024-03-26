using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using businessLayer.DTO;
using dataLayer;
namespace businessLayer
{
    public class LUONG
    {
        QLTLEntities db = new QLTLEntities();

        public tb_LUONG getItem(int id)
        {
            return db.tb_LUONG.FirstOrDefault(x => x.MABL==id);
        }
        public List<tb_LUONG> getList(string MABCC)
        {
            return db.tb_LUONG.Where(x=> string.Compare(x.MABCC,MABCC,true)==0).ToList();
        }

        public List<LUONG_DTO> getFullList(string MABCC)
        {
            var listLUONG = db.tb_LUONG.Where(x => string.Compare(x.MABCC, MABCC, true) == 0).ToList();
            List<LUONG_DTO> listLUONG_DTO = new List<LUONG_DTO>();
            LUONG_DTO luongDTO;
            foreach (var item in listLUONG)
            {
                luongDTO = new LUONG_DTO();
                luongDTO.MABL = item.MABL;
                luongDTO.MABCC = item.MABCC;
                luongDTO.MANV = item.MANV;
                var bcc = db.tb_CHAMCONG.FirstOrDefault(x => (string.Compare(x.MABCC, item.MABCC, true) == 0 && string.Compare(x.MANV, item.MANV, true) == 0));
                var nv = db.tb_NHANVIEN.FirstOrDefault(x => (string.Compare(x.MANV, item.MANV, true) == 0));
                luongDTO.HOTEN = nv.HOTEN;
                luongDTO.SONC = bcc.SONC;
                luongDTO.TANGCA = bcc.TANGCA;
                luongDTO.MUON = bcc.MUON;
                luongDTO.BHXH = item.BHXH;
                luongDTO.BHYT = item.BHYT;
                luongDTO.THUETNCN = item.THUETNCN;
                luongDTO.THUCLANH = item.THUCLANH;
                listLUONG_DTO.Add(luongDTO);
            }
            return listLUONG_DTO;
        }

        public void TinhLuongNV(string MaBCC)
        {
            double luongNgay, luongNet, luongGross , bhyt, bhxh, ttncn=0;
            double phucap = 500000;
            var listNV = db.tb_NHANVIEN.ToList();
            foreach ( var item in listNV )
            {
                var cv = db.tb_CHUCVU.FirstOrDefault(x => string.Compare(x.MACV, item.MACV, true) == 0);
                var bcc = db.tb_CHAMCONG.FirstOrDefault(x=> (string.Compare(x.MABCC,MaBCC,true) == 0 && string.Compare(x.MANV, item.MANV, true) == 0));
                if (bcc != null)
                {
                    luongNgay = Convert.ToDouble((item.LUONGCB * cv.HSL) / 30);
                    luongGross = Convert.ToDouble(luongNgay * (bcc.SONC + 2 * bcc.TANGCA - 0.4 * bcc.MUON) + phucap);
                    bhyt = luongGross * (1.5 / 100);
                    bhxh = luongGross * (8.0 / 100);
                    if (luongGross > 11000000)
                    {
                        ttncn = (luongGross - 11000000) / 10;
                    }
                    luongNet = luongGross - bhyt - bhxh - ttncn;

                    tb_LUONG bl = new tb_LUONG();
                    bl.MABCC = bcc.MABCC;
                    bl.MANV = item.MANV;
                    bl.BHYT = Convert.ToDecimal(bhyt);
                    bl.BHXH = Convert.ToDecimal(bhxh);
                    bl.THUETNCN = Convert.ToDecimal(ttncn);
                    bl.THUCLANH = Convert.ToDecimal(luongNet);
                    Add(bl);
                }
            }
        }
        public tb_LUONG Add(tb_LUONG bl)
        {
            try
            {
                db.tb_LUONG.Add(bl);
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_LUONG Update(tb_LUONG bl)
        {
            try
            {
                var _bl = db.tb_LUONG.FirstOrDefault(x => x.MABL == bl.MABL);
                _bl.MABL = bl.MABL;
                _bl.MABCC = bl.MABCC;
                _bl.MANV = bl.MANV;
                _bl.BHXH = bl.BHXH;
                _bl.BHYT = bl.BHYT;

                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(string id)
        {
            try
            {
                var _bl = db.tb_LUONG.Where(x => string.Compare(x.MABCC, id, true) == 0).ToList();
                foreach (var item in _bl )
                {
                    db.tb_LUONG.Remove(item);
                    db.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
