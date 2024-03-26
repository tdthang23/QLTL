using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using businessLayer.DTO;
using dataLayer;

namespace businessLayer
{
    public class IDCC
    {
        public string MaBCC;
        public string MaNV;
    }
    public class CHAMCONG
    {
        QLTLEntities db = new QLTLEntities();

        public tb_CHAMCONG getItem(IDCC id)
        {
            return db.tb_CHAMCONG.FirstOrDefault(x => (string.Compare(x.MABCC, id.MaBCC, true) == 0 && string.Compare(x.MANV, id.MaNV, true) == 0));
        }
        public List<tb_CHAMCONG> getList()
        {
            return db.tb_CHAMCONG.ToList();
        }

        public List<CHAMCONG_DTO> getFullList()
        {
            var listCC = db.tb_CHAMCONG.ToList();
            List<CHAMCONG_DTO> listCC_DTO = new List<CHAMCONG_DTO>();
            CHAMCONG_DTO ccDTO;
            foreach (var item in listCC)
            {
                ccDTO = new CHAMCONG_DTO();
                ccDTO.MABCC = item.MABCC;
                ccDTO.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(x => string.Compare(x.MANV, item.MANV, true) == 0);
                ccDTO.HOTEN = nv.HOTEN;
                ccDTO.SONC = item.SONC;
                ccDTO.TANGCA = item.TANGCA;
                ccDTO.MUON = item.MUON;
                listCC_DTO.Add(ccDTO);
            }
            return listCC_DTO;
        }

        public tb_CHAMCONG Add(tb_CHAMCONG bcc)
        {
            try
            {
                db.tb_CHAMCONG.Add(bcc);
                db.SaveChanges();
                return bcc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_CHAMCONG Update(tb_CHAMCONG bcc)
        {
            try
            {
                var _bcc = db.tb_CHAMCONG.FirstOrDefault(x => (string.Compare(x.MABCC, bcc.MABCC, true) == 0 && string.Compare(x.MANV, bcc.MANV, true) == 0));
                _bcc.SONC = bcc.SONC;
                _bcc.TANGCA = bcc.TANGCA;
                _bcc.MUON = bcc.MUON;
                db.SaveChanges();
                return bcc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(IDCC id)
        {
            try
            {
                var _bcc = db.tb_CHAMCONG.FirstOrDefault(x => (string.Compare(x.MABCC, id.MaBCC, true) == 0 && string.Compare(x.MANV, id.MaNV, true) == 0));
                db.tb_CHAMCONG.Remove(_bcc); db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
