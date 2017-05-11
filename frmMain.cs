using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace DXDoAnXML
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private BindingList<Accounts> ListAccount = new BindingList<Accounts>();
        public frmMain()
        {
            InitializeComponent();

            gridControl.DataSource = GetDataSource();
            bsiRecordsCount1.Caption = "Số Lượng Tài Khoản : " + ListAccount.Count;
            btnThem.Enabled = false;
            //đưa con trỏ chuột đã chọn về giá trị rỗng
            gridView.FocusInvalidRow();

        }

        private void GridControl_Click_1(object sender, EventArgs e)
        {
            txtNguon.Text = gridView.GetFocusedRowCellDisplayText("Nguon");
            txtTaiKhoan.Text = gridView.GetFocusedRowCellDisplayText("TaiKhoan");
            txtMatKhau.Text = gridView.GetFocusedRowCellDisplayText("MatKhau");
            btnThem.Enabled = false;
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            Them();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Sua();
        }



        private void BtnXoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void BbiPrintPreview_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void BarbtnGioiThieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Xây dựng bởi : Nguyễn Hoàng Phúc \n" +
                                "Lớp : Kỹ Thuật Phần Mềm K2 \n" +
                                "Giáo viên hướng dẫn: Nguyễn Bá Duy \n", "Gới Thiệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtMatKhau.ResetText();
            txtNguon.ResetText();
            txtTaiKhoan.ResetText();
            btnThem.Enabled = false;
            // gridView.FocusedRowHandle = 0;
            //đưa con trỏ chuột đã chọn về giá trị rỗng
            gridView.FocusInvalidRow();
        }

        private void BarbtnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Dispose();
        }

        private void BarbtnXuatExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            XuatExcel();
        }

        private void BarbtnXuatTXT_ItemClick(object sender, ItemClickEventArgs e)
        {
            XuatTXT();
        }

        private void TxtNguon_EditValueChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }

        private void TxtTaiKhoang_EditValueChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }

        private void TxtMatKhau_EditValueChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }

        private void BarbtnMo_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFile();
        }

        private void btnRadom_Click(object sender, EventArgs e)
        {
            RamdomPW();
        }

        #region Hàm Ramdom Password
        private void RamdomPW()
        {
            RadomPassWord radoompass = new RadomPassWord();
            txtMatKhau.Text = radoompass.GetPassword();
        }
        #endregion

        #region Hàm Mở file XML
        private void OpenFile()
        {
            OpenFileDialog OpenFile = new OpenFileDialog()
            {
                Filter = "XML Files|*.xml|All Files|*.*"
            };
            var resul = OpenFile.ShowDialog();
            if (resul == DialogResult.OK)
            {
                ListAccount.Clear();
                ListAccount = GetDataSource(@OpenFile.FileName);
            }
        }
        #endregion

        #region Hàm Load Dữ liệu vào bảng
        private BindingList<Accounts> GetDataSource()
        {
            Accounts account = new Accounts();

            foreach (var item in account.GetAll())
            {
                ListAccount.Add(item);
            }
            return ListAccount;
        }
        #endregion

        #region Hàm load dữ liệu vào bảng với tham số là đường dẫn file ( dùng để mởi file mới)
        public BindingList<Accounts> GetDataSource(string path)
        {
            Accounts account = new Accounts(path);

            foreach (var item in account.GetAll())
            {
                ListAccount.Add(item);
            }
            return ListAccount;
        }
        #endregion

        #region Hàm Thêm
        private void Them()
        {
            Accounts account = new Accounts();


            if (CheckTaiKhoang(txtTaiKhoan.Text, txtNguon.Text))
            {
                XtraMessageBox.Show("Tài Khoản Đã Tồn Tại");
                gridView.FindRow(new Accounts() { TaiKhoan = txtTaiKhoan.Text, Nguon = txtNguon.Text });
                
                //gridView.MoveBy();

            }
            else
            {
                try
                {
                    account.Insert(txtTaiKhoan.Text, txtMatKhau.Text, txtNguon.Text);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lổi\n" + ex.ToString());
                }
                ListAccount.Add(new Accounts
                {
                    Id = account.GetMaxId(),
                    Nguon = txtNguon.Text,
                    TaiKhoan = txtTaiKhoan.Text,
                    MatKhau = txtMatKhau.Text
                });
                gridView.MoveLast();
                btnThem.Enabled = false;
                bsiRecordsCount1.Caption = "Số Lượng Tài Khoản : " + ListAccount.Count;

            }


        }
        #endregion

        #region Hàm Sửa
        private void Sua()
        {
            Accounts account = new Accounts();

            int RowIndex = gridView.GetFocusedDataSourceRowIndex();

            string id = gridView.GetFocusedRowCellDisplayText("Id");
            string Nguon = txtNguon.Text;
            string TaiKhoang = txtTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text;
            try
            {
                account.Update(id, Nguon, TaiKhoang, MatKhau);

                ListAccount.RemoveAt(RowIndex);
                ListAccount.Insert(RowIndex, new Accounts
                {
                    Id = int.Parse(id),
                    Nguon = txtNguon.Text,
                    TaiKhoan = txtTaiKhoan.Text,
                    MatKhau = txtMatKhau.Text
                });

            }
            catch
            {
                XtraMessageBox.Show("Vui Lòng Chọn Đối Tượng Cần Sửa", "Lổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region   Hàm Xóa
        private void Xoa()
        {
            Accounts account = new Accounts();
            string id = gridView.GetFocusedRowCellDisplayText("Id");
            var resul = XtraMessageBox.Show("Bạn Chắc Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resul == DialogResult.Yes)
            {
                try
                {
                    account.Delete(id);
                    ListAccount.RemoveAt(gridView.GetFocusedDataSourceRowIndex());
                }
                catch
                {
                    XtraMessageBox.Show("Vui Lòng Chọn Đối Tượng Cần Xóa", "Lổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            bsiRecordsCount1.Caption = "Số Lượng Tài Khoản : " + ListAccount.Count;
        }
        #endregion

        #region Hàm Xuất file TXT
        private void XuatTXT()
        {
            SaveFileDialog file = new SaveFileDialog()
            {
                Filter = "Text Files|*.txt|All Files|*.*"
            };
            var resul = file.ShowDialog();
            if (resul == DialogResult.OK)
            {
#pragma warning disable CS0618 // Type or member is obsolete
                gridControl.ExportToText(file.FileName, "\t", true, System.Text.Encoding.UTF8);
#pragma warning restore CS0618 // Type or member is obsolete
            }
        }
        #endregion

        #region Hàm Xuất File Excel
        private void XuatExcel()
        {

            SaveFileDialog file = new SaveFileDialog()
            {
                Filter = "Excel 2007 Files|*.xlsx|All Files|*.*"
            };
            var resul = file.ShowDialog();
            if (resul == DialogResult.OK)
            { gridControl.ExportToXlsx(file.FileName); }
        }
        #endregion

        #region Hàm kiểm tra tài khoản
        private bool CheckTaiKhoang(string TaiKhoang, string Nguon)
        {
            bool rs = false;
            Accounts[] list = new Accounts[ListAccount.Count];
            ListAccount.CopyTo(list, 0);

            foreach (var item in list)
            {
                if (TaiKhoang == item.TaiKhoan && Nguon == item.Nguon)
                {
                    rs = true;
                    break;
                }
            }
            return rs;
        }
        #endregion
    }
}