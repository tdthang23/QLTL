using businessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataLayer;

namespace QLTL
{
    public partial class frmChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmChucVu()
        {
            InitializeComponent();
        }
        CHUCVU _cv;
        bool _them;
        string _id;
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            _showHide(true);
            _cv = new CHUCVU();
            loadData();
        }

        void loadData()
        {
            _them = false;
            gcDanhSach.DataSource=_cv.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void _reset()
        {
            textMaCV.Text = string.Empty;
            textTenCV.Text = string.Empty;
            textHSL.Text = string.Empty;
        }

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            textMaCV.Enabled = !kt;
            textTenCV.Enabled = !kt;
            textHSL.Enabled = !kt;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            _showHide(false);
            _reset();
            _them = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _cv.Delete(_id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _showHide(true);
            _them = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void SaveData()
        {
            if (_them)
            {
                tb_CHUCVU cv = new tb_CHUCVU();
                cv.MACV = textMaCV.Text;
                cv.TENCV = textTenCV.Text;
                cv.HSL = Decimal.Parse(textHSL.Text.ToString());
                _cv.Add(cv);
            }
            else
            {
                var cv = _cv.getItem(_id);
                cv.TENCV= textTenCV.Text;
                cv.HSL = Decimal.Parse(textHSL.Text.ToString());
                _cv.Update(cv);
            }
        }



        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id=gvDanhSach.GetFocusedRowCellValue("MACV").ToString();
            textMaCV.Text = gvDanhSach.GetFocusedRowCellValue("MACV").ToString();
            textTenCV.Text= gvDanhSach.GetFocusedRowCellValue("TENCV").ToString();
            textHSL.Text = gvDanhSach.GetFocusedRowCellValue("HSL").ToString();
        }
    }
}