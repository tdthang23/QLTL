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

namespace QLTL
{
    public partial class frmBangLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangLuong()
        {
            InitializeComponent();
        }
        LUONG _bl;
        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            _bl = new LUONG();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXemBL_Click(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            if (cboThang.SelectedItem != null && cboNam.SelectedItem != null)
            {
                gcDanhSach.DataSource = _bl.getFullList(cboThang.SelectedItem.ToString() + "-" + cboNam.SelectedItem.ToString());
                gvDanhSach.OptionsBehavior.Editable = false;
            }
        }

        private void btnTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboThang.SelectedItem != null && cboNam.SelectedItem != null)
            {
                _bl.Delete(cboThang.SelectedItem.ToString() + "-" + cboNam.SelectedItem.ToString());
                _bl.TinhLuongNV(cboThang.SelectedItem.ToString() + "-" + cboNam.SelectedItem.ToString());
                loadData();
            }
        }
    }
}