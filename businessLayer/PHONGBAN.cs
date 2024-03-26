using dataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer
{
    public class PHONGBAN
    {
        QLTLEntities db = new QLTLEntities();

        public tb_PHONGBAN getItem(string id)
        {
            return db.tb_PHONGBAN.FirstOrDefault(x => string.Compare(x.MAPB, id, true) == 0);
        }
        public List<tb_PHONGBAN> getList()
        {
            return db.tb_PHONGBAN.ToList();
        }

        public tb_PHONGBAN Add(tb_PHONGBAN pb)
        {
            try
            {
                db.tb_PHONGBAN.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: "+ex.Message);
            }
        }

        public tb_PHONGBAN Update(tb_PHONGBAN pb)
        {
            try
            {
                var _pb = db.tb_PHONGBAN.FirstOrDefault(x => string.Compare(x.MAPB, pb.MAPB, true) == 0);
                _pb.TENPB = pb.TENPB;
                db.SaveChanges();
                return pb;
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
                var _pb = db.tb_PHONGBAN.FirstOrDefault(x => x.MAPB == id);
                db.tb_PHONGBAN.Remove(_pb); db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}

