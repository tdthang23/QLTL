using businessLayer;
using dataLayer;
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

namespace QLTL
{
    public partial class frmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }
        PHONGBAN _pb;
        bool _them;
        string _id;
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            textMaPB.Enabled = !kt;
            textTenPB.Enabled = !kt;
        }

        void _reset()
        {
            textMaPB.Text = string.Empty;
            textTenPB.Text = string.Empty;
        }
        void loadData()
        {
            _them = false;
            gcDanhSach.DataSource = _pb.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            _showHide(true);
            _pb = new PHONGBAN();
            loadData();
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
            if(MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _pb.Delete(_id);
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
                tb_PHONGBAN pb = new tb_PHONGBAN();
                pb.MAPB = textMaPB.Text;
                pb.TENPB = textTenPB.Text;
                _pb.Add(pb);
            }
            else
            {
                var pb = _pb.getItem(_id);
                pb.TENPB = textTenPB.Text;
                _pb.Update(pb);
            }
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = gvDanhSach.GetFocusedRowCellValue("MAPB").ToString();
            textMaPB.Text = gvDanhSach.GetFocusedRowCellValue("MAPB").ToString();
            textTenPB.Text = gvDanhSach.GetFocusedRowCellValue("TENPB").ToString();
        }
    }
}