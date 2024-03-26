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
using businessLayer;

namespace QLTL
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NHANVIEN _nv;
        PHONGBAN _pb;
        CHUCVU _cv;
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
            textMaNV.Enabled = !kt;
            textTenNV.Enabled = !kt;
            dateNgaySinh.Enabled = !kt;
            cboGioiTinh.Enabled = !kt;
            textDiaChi.Enabled = !kt;
            textSDT.Enabled = !kt;
            textEmail.Enabled = !kt;
            dateNgayVaoLam.Enabled = !kt;
            cboPhongBan.Enabled = !kt;
            cboChucVu.Enabled = !kt;
            textLuongCB.Enabled = !kt;

        }

        void _reset()
        {
            textMaNV.Text = string.Empty;
            textTenNV.Text = string.Empty;
            dateNgaySinh.Value = DateTime.Now;
            cboGioiTinh.SelectedValue = string.Empty;
            textDiaChi.Text = string.Empty;
            textSDT.Text = string.Empty;
            textEmail.Text = string.Empty;
            dateNgayVaoLam.Value = DateTime.Now;
            cboPhongBan.SelectedValue = string.Empty;
            cboChucVu.SelectedValue = string.Empty;
            textLuongCB.Text = string.Empty;
        }
        void loadData()
        {
            _them = false;
            gcDanhSach.DataSource = _nv.getFullList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadCombo()
        {
            cboPhongBan.DataSource = _pb.getList();
            cboPhongBan.DisplayMember = "TENPB";
            cboPhongBan.ValueMember = "MAPB";
            cboChucVu.DataSource = _cv.getList();
            cboChucVu.DisplayMember = "TENCV";
            cboChucVu.ValueMember = "MACV";
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
        }
        
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            _showHide(true);
            _nv = new NHANVIEN();
            _pb = new PHONGBAN();
            _cv = new CHUCVU();
            loadData();
            loadCombo();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _reset();
            _them = true;
            splitContainer1 .Panel1Collapsed = false;
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
                _nv.Delete(_id);
                loadData();
            }

        }
        void SaveData()
        {
            if (_them)
            {
                tb_NHANVIEN nv = new tb_NHANVIEN();
                nv.MANV = textMaNV.Text;
                nv.HOTEN = textTenNV.Text;
                nv.NGAYSINH = dateNgaySinh.Value;
                nv.GT = cboGioiTinh.SelectedItem.ToString();
                nv.DIACHI = textDiaChi.Text;
                nv.SDT = textSDT.Text;
                nv.EMAIL = textEmail.Text;
                nv.NGAYVAOLAM = dateNgayVaoLam.Value;
                nv.MAPB = cboPhongBan.SelectedValue.ToString();
                nv.MACV = cboChucVu.SelectedValue.ToString();
                nv.LUONGCB = int.Parse(textLuongCB.Text);
                _nv.Add(nv);
            }
            else
            {
                var nv = _nv.getItem(_id);
                nv.MANV = textMaNV.Text;
                nv.HOTEN = textTenNV.Text;
                nv.NGAYSINH = dateNgaySinh.Value;
                nv.GT = cboGioiTinh.SelectedItem.ToString();
                nv.DIACHI = textDiaChi.Text;
                nv.SDT = textSDT.Text;
                nv.EMAIL = textEmail.Text;
                nv.NGAYVAOLAM = dateNgayVaoLam.Value;
                nv.MAPB = cboPhongBan.SelectedValue.ToString();
                nv.MACV = cboChucVu.SelectedValue.ToString();
                nv.LUONGCB = decimal.Parse(textLuongCB.Text.ToString());
                _nv.Update(nv);
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
            _id = gvDanhSach.GetFocusedRowCellValue("MANV").ToString();
            var nv = _nv.getItem(_id);
            textMaNV.Text = nv.MANV;
            textTenNV.Text = nv.HOTEN;
            dateNgaySinh.Value = nv.NGAYSINH.Value;
            cboGioiTinh.SelectedItem = nv.GT;
            textDiaChi.Text = nv.DIACHI;
            textSDT.Text = nv.SDT;
            textEmail.Text = nv.EMAIL;
            dateNgayVaoLam.Value = nv.NGAYVAOLAM.Value;
            cboPhongBan.SelectedValue = nv.MAPB;
            cboChucVu.SelectedValue = nv.MACV;
            textLuongCB.Text = nv.LUONGCB.ToString();

        }
    }
}