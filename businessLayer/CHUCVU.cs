using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataLayer;

namespace businessLayer
{
    public class CHUCVU
    {
        QLTLEntities db = new QLTLEntities();

        public tb_CHUCVU getItem(string id)
        {
            return db.tb_CHUCVU.FirstOrDefault(x => string.Compare(x.MACV, id, true) == 0);
        }
        public List<tb_CHUCVU> getList()
        {
            return db.tb_CHUCVU.ToList();
        }

        public tb_CHUCVU Add(tb_CHUCVU cv)
        {
            try
            {
                db.tb_CHUCVU.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_CHUCVU Update(tb_CHUCVU cv)
        {
            try
            {
                var _cv = db.tb_CHUCVU.FirstOrDefault(x => string.Compare(x.MACV, cv.MACV, true) == 0);
                _cv.TENCV = cv.TENCV;
                _cv.HSL = cv.HSL;
                db.SaveChanges();
                return cv;
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
                var _cv = db.tb_CHUCVU.FirstOrDefault(x => x.MACV == id);
                db.tb_CHUCVU.Remove(_cv); db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}
