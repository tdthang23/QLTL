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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLTL
{
    public partial class frmChamCong : DevExpress.XtraEditors.XtraForm
    {
        public frmChamCong()
        {
            InitializeComponent();
        }
        CHAMCONG _bcc;
        NHANVIEN _nv;
        bool _them;
        IDCC _id;

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            textMaBCC.Enabled = !kt;
            textMaNV.Enabled = !kt;
            textSoNC.Enabled = !kt;
            textTangCa.Enabled = !kt;
            textMuon.Enabled = !kt;
        }

        void _reset()
        {
            textMaBCC.Text = string.Empty;
            textMaNV.Text = string.Empty;
            textSoNC.Text = string.Empty;
            textTangCa.Text = string.Empty;
            textMuon.Text = string.Empty;
        }
        void loadData()
        {
            _them = false;
            gcDanhSach.DataSource = _bcc.getFullList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            _showHide(true);
            _bcc = new CHAMCONG();
            _nv = new NHANVIEN();
            loadData();
            splitContainer1.Panel1Collapsed = true;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _reset();
            _them = true;
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = false;
            splitContainer1.Panel1Collapsed = false;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _bcc.Delete(_id);
                loadData();
            }
        }

        void SaveData()
        {
            if (_them)
            {
                tb_CHAMCONG bcc = new tb_CHAMCONG();
                bcc.MABCC = textMaBCC.Text;
                bcc.MANV = textMaNV.Text;
                bcc.SONC = int.Parse(textSoNC.Text.ToString());
                bcc.TANGCA = int.Parse(textTangCa.Text.ToString());
                bcc.MUON = int.Parse(textMuon.Text.ToString());
                _bcc.Add(bcc);
            }
            else
            {
                var bcc = _bcc.getItem(_id);
                bcc.MABCC = textMaBCC.Text;
                bcc.MANV = textMaNV.Text;
                bcc.SONC = int.Parse(textSoNC.Text.ToString());
                bcc.TANGCA = int.Parse(textTangCa.Text.ToString());
                bcc.MUON = int.Parse(textMuon.Text.ToString());
                _bcc.Update(bcc);
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _showHide(true);
            _them = false;
            splitContainer1.Panel1Collapsed = true;

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
            splitContainer1.Panel1Collapsed = true;

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            _id = new IDCC();
            _id.MaBCC = gvDanhSach.GetFocusedRowCellValue("MABCC").ToString();
            _id.MaNV = gvDanhSach.GetFocusedRowCellValue("MANV").ToString();
            var bcc = _bcc.getItem(_id);
            textMaNV.Text = bcc.MANV;
            textMaBCC.Text = bcc.MABCC;
            textSoNC.Text = bcc.SONC.ToString();
            textTangCa.Text = bcc.TANGCA.ToString();
            textMuon.Text = bcc.MUON.ToString();
        }
    }
}