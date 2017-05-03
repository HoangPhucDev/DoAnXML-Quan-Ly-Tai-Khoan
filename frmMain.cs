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
        public BindingList<Accounts> GetDataSource()
        {
            Accounts account = new Accounts();

            foreach (var item in account.GetAll())
            {
                ListAccount.Add(item);
            }
            return ListAccount;
        }

        public BindingList<Accounts> GetDataSource(string path)
        {
            Accounts account = new Accounts(path);
            
            foreach (var item in account.GetAll())
            {
                ListAccount.Add(item);
            }
            return ListAccount;
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
            Accounts account = new Accounts();
            try
            {
                account.Insert(txtTaiKhoan.Text, txtMatKhau.Text, txtNguon.Text);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lổi\n" + ex.ToString());
            }

            ListAccount.Add(new Accounts { Id = account.GetMaxId(),
                                          Nguon = txtNguon.Text,
                                          TaiKhoan = txtTaiKhoan.Text,
                                          MatKhau = txtMatKhau.Text});
            gridView.MoveLast();
            btnThem.Enabled = false;
            bsiRecordsCount1.Caption = "Số Lượng Tài Khoản : " + ListAccount.Count;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Accounts account = new Accounts();

            int RowIndex = gridView.GetFocusedDataSourceRowIndex();

            string id = gridView.GetFocusedRowCellDisplayText("Id");
            string Nguon = txtNguon.Text;
            string TaiKhoang = txtTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text;
            try { 
                    account.Update(id, Nguon, TaiKhoang, MatKhau);

                    ListAccount.RemoveAt(RowIndex);
                    ListAccount.Insert(RowIndex, new Accounts
                    {
                        Id = int.Parse(id),
                        Nguon = txtNguon.Text,
                        TaiKhoan = txtTaiKhoan.Text,
                        MatKhau = txtMatKhau.Text
                    });

            }catch
            {
                XtraMessageBox.Show("Vui Lòng Chọn Đối Tượng Cần Sửa", "Lổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            Accounts account = new Accounts();
            string id = gridView.GetFocusedRowCellDisplayText("Id");
          var resul = XtraMessageBox.Show("Bạn Chắc Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(resul == DialogResult.Yes)
            {
                try {
                    account.Delete(id);
                    ListAccount.RemoveAt(gridView.GetFocusedDataSourceRowIndex());
                }catch
                {
                    XtraMessageBox.Show("Vui Lòng Chọn Đối Tượng Cần Xóa", "Lổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            bsiRecordsCount1.Caption = "Số Lượng Tài Khoản : " + ListAccount.Count;

        }


        private void BbiPrintPreview_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void BarbtnGioiThieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Xây dựng bởi : Nguyễn Hoàng Phúc \n" +
                                "Lớp : Kỹ Thuật Phần Mềm K2 \n" +
                                "Giáo viên hướng dẫn: Nguyễn Bá Duy \n", "Gới Thiệu",MessageBoxButtons.OK,MessageBoxIcon.Question);
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

            SaveFileDialog file = new SaveFileDialog()
            {
                Filter = "Excel 2007 Files|*.xlsx|All Files|*.*"
            };
            var resul = file.ShowDialog();
            if(resul==DialogResult.OK)
            { gridControl.ExportToXlsx(file.FileName); }
            
        }

        private void BarbtnXuatTXT_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog()
            {
                Filter = "Text Files|*.txt|All Files|*.*"
            };
            var resul = file.ShowDialog();
            if (resul == DialogResult.OK)
            {
            #pragma warning disable CS0618 // Type or member is obsolete
                gridControl.ExportToText(file.FileName,"\t",true,System.Text.Encoding.UTF8);
            #pragma warning restore CS0618 // Type or member is obsolete
            }
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

        private void btnRadom_Click(object sender, EventArgs e)
        {
           RadomPassWord radoompass = new RadomPassWord();
           txtMatKhau.Text = radoompass.GetPassword(); 
        }
    }
}