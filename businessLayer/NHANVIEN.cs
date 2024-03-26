using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using businessLayer.DTO;
using dataLayer;
namespace businessLayer
{
    public class NHANVIEN
    {
        QLTLEntities db = new QLTLEntities();

        public tb_NHANVIEN getItem(string id)
        {
            return db.tb_NHANVIEN.FirstOrDefault(x => string.Compare(x.MANV, id, true) == 0);
        }
        public List<tb_NHANVIEN> getList()
        {
            return db.tb_NHANVIEN.ToList();
        }

        public List<NHANVIEN_DTO> getFullList() 
        {
            var listNV = db.tb_NHANVIEN.ToList();
            List<NHANVIEN_DTO> listNV_DTO=new List<NHANVIEN_DTO>();
            NHANVIEN_DTO nvDTO;
            foreach(var item in listNV)
            {
                nvDTO = new NHANVIEN_DTO();
                nvDTO.MANV = item.MANV;
                nvDTO.HOTEN = item.HOTEN;
                nvDTO.NGAYSINH = item.NGAYSINH;
                nvDTO.GT = item.GT;
                nvDTO.DIACHI = item.DIACHI;
                nvDTO.SDT = item.SDT;
                nvDTO.EMAIL = item.EMAIL;
                nvDTO.NGAYVAOLAM = item.NGAYVAOLAM;
                nvDTO.MAPB = item.MAPB;
                var pb = db.tb_PHONGBAN.FirstOrDefault(x => string.Compare(x.MAPB, item.MAPB, true)==0);
                nvDTO.TENPB = pb.TENPB;
                nvDTO.MACV = item.MACV;
                var cv = db.tb_CHUCVU.FirstOrDefault(x => string.Compare(x.MACV, item.MACV, true)==0);
                nvDTO.TENCV = cv.TENCV;
                nvDTO.LUONGCB = item.LUONGCB;
                listNV_DTO.Add(nvDTO);
            }
            return listNV_DTO;
        }

        public tb_NHANVIEN Add(tb_NHANVIEN nv)
        {
            try
            {
                db.tb_NHANVIEN.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_NHANVIEN Update(tb_NHANVIEN nv)
        {
            try
            {
                var _nv = db.tb_NHANVIEN.FirstOrDefault(x => string.Compare(x.MANV, nv.MANV, true) == 0);
                _nv.HOTEN = nv.HOTEN;
                _nv.GT = nv.GT;
                _nv.NGAYSINH = nv.NGAYSINH;
                _nv.DIACHI = nv.DIACHI;
                _nv.SDT = nv.SDT;
                _nv.EMAIL = nv.EMAIL;
                _nv.NGAYVAOLAM = nv.NGAYVAOLAM;
                _nv.MAPB = nv.MAPB;
                _nv.MACV = nv.MACV;
                _nv.LUONGCB = nv.LUONGCB;  
                db.SaveChanges();
                return nv;
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
                var _nv = db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == id);
                db.tb_NHANVIEN.Remove(_nv); db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
