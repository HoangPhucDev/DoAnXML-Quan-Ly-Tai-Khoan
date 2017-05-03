namespace DXDoAnXML
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.bsiRecordsCount1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtnXuatTXT = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnGioiThieu = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnXuatExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnXuatTXT = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnMo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtNguon = new DevExpress.XtraEditors.TextEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnRadom = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 617);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(805, 31);
            // 
            // bsiRecordsCount1
            // 
            this.bsiRecordsCount1.Caption = "barStaticItem1";
            this.bsiRecordsCount1.Id = 23;
            this.bsiRecordsCount1.Name = "bsiRecordsCount1";
            this.bsiRecordsCount1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bsiRecordsCount1,
            this.bbtnXuatTXT,
            this.barbtnGioiThieu,
            this.barbtnThoat,
            this.barbtnXuatExcel,
            this.barbtnXuatTXT,
            this.barbtnMo});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 35;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(805, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbtnXuatTXT
            // 
            this.bbtnXuatTXT.Caption = "In";
            this.bbtnXuatTXT.Id = 24;
            this.bbtnXuatTXT.ImageOptions.ImageUri.Uri = "Print";
            this.bbtnXuatTXT.Name = "bbtnXuatTXT";
            this.bbtnXuatTXT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiPrintPreview_ItemClick_1);
            // 
            // barbtnGioiThieu
            // 
            this.barbtnGioiThieu.Caption = "Giới Thiệu";
            this.barbtnGioiThieu.Id = 25;
            this.barbtnGioiThieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnGioiThieu.ImageOptions.Image")));
            this.barbtnGioiThieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnGioiThieu.ImageOptions.LargeImage")));
            this.barbtnGioiThieu.Name = "barbtnGioiThieu";
            this.barbtnGioiThieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarbtnGioiThieu_ItemClick);
            // 
            // barbtnThoat
            // 
            this.barbtnThoat.Caption = "Thoát";
            this.barbtnThoat.Id = 26;
            this.barbtnThoat.ImageOptions.ImageUri.Uri = "Close";
            this.barbtnThoat.Name = "barbtnThoat";
            this.barbtnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarbtnThoat_ItemClick);
            // 
            // barbtnXuatExcel
            // 
            this.barbtnXuatExcel.Caption = "Xuất File Excel 2007";
            this.barbtnXuatExcel.Id = 27;
            this.barbtnXuatExcel.ImageOptions.ImageUri.Uri = "ExportToXLSX";
            this.barbtnXuatExcel.Name = "barbtnXuatExcel";
            this.barbtnXuatExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarbtnXuatExcel_ItemClick);
            // 
            // barbtnXuatTXT
            // 
            this.barbtnXuatTXT.Caption = "Xuất File Text";
            this.barbtnXuatTXT.Id = 28;
            this.barbtnXuatTXT.ImageOptions.ImageUri.Uri = "ExportToTXT";
            this.barbtnXuatTXT.Name = "barbtnXuatTXT";
            this.barbtnXuatTXT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarbtnXuatTXT_ItemClick);
            // 
            // barbtnMo
            // 
            this.barbtnMo.Caption = "Mở";
            this.barbtnMo.Id = 34;
            this.barbtnMo.ImageOptions.ImageUri.Uri = "Open";
            this.barbtnMo.Name = "barbtnMo";
            this.barbtnMo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarbtnMo_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtnThoat);
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtnMo);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hệ Thống";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "In Và Xuất File";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnXuatTXT);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "In";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Giới Thiệu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnGioiThieu);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Giới Thiệu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMatKhau);
            this.groupControl1.Controls.Add(this.txtTaiKhoan);
            this.groupControl1.Controls.Add(this.txtNguon);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnRadom);
            this.groupControl1.Controls.Add(this.btnReset);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 143);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(805, 143);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Thao Tác";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(72, 73);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.NullValuePrompt = "Nhập Nội Dung Để Thêm";
            this.txtMatKhau.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtMatKhau.Size = new System.Drawing.Size(728, 20);
            this.txtMatKhau.TabIndex = 8;
            this.txtMatKhau.Tag = "saf";
            this.txtMatKhau.EditValueChanged += new System.EventHandler(this.TxtMatKhau_EditValueChanged);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(72, 47);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Properties.NullValuePrompt = "Nhập Nội Dung Để Thêm";
            this.txtTaiKhoan.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(728, 20);
            this.txtTaiKhoan.TabIndex = 8;
            this.txtTaiKhoan.Tag = "saf";
            this.txtTaiKhoan.EditValueChanged += new System.EventHandler(this.TxtTaiKhoang_EditValueChanged);
            // 
            // txtNguon
            // 
            this.txtNguon.Location = new System.Drawing.Point(72, 23);
            this.txtNguon.MenuManager = this.ribbonControl;
            this.txtNguon.Name = "txtNguon";
            this.txtNguon.Properties.NullValuePrompt = "Nhập Nội Dung Để Thêm";
            this.txtNguon.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNguon.Size = new System.Drawing.Size(728, 20);
            this.txtNguon.TabIndex = 8;
            this.txtNguon.Tag = "";
            this.txtNguon.EditValueChanged += new System.EventHandler(this.TxtNguon_EditValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.ImageUri.Uri = "AddItem";
            this.btnThem.Location = new System.Drawing.Point(72, 101);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 37);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageUri.Uri = "Edit";
            this.btnSua.Location = new System.Drawing.Point(153, 101);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 37);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnReset
            // 
            this.btnReset.ImageUri.Uri = "Clear";
            this.btnReset.Location = new System.Drawing.Point(315, 101);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageUri.Uri = "Delete";
            this.btnXoa.Location = new System.Drawing.Point(234, 101);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nguồn";
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridControl.Location = new System.Drawing.Point(0, 292);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(805, 319);
            this.gridControl.TabIndex = 8;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.Click += new System.EventHandler(this.GridControl_Click_1);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupPanelText = "Kéo các cột cần nhóm vào đây";
            this.gridView.Name = "gridView";
            this.gridView.NewItemRowText = "Thêm Tài Khoảng Mới";
            this.gridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 30;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nguồn";
            this.gridColumn2.FieldName = "Nguon";
            this.gridColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn2.Image")));
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 252;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tài Khoản";
            this.gridColumn3.FieldName = "TaiKhoan";
            this.gridColumn3.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn3.Image")));
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 252;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mật Khẩu";
            this.gridColumn4.FieldName = "MatKhau";
            this.gridColumn4.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn4.Image")));
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 255;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barbtnXuatExcel);
            this.ribbonPageGroup4.ItemLinks.Add(this.barbtnXuatTXT);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Xuất File";
            // 
            // btnRadom
            // 
            this.btnRadom.ImageUri.Uri = "Replace";
            this.btnRadom.Location = new System.Drawing.Point(396, 101);
            this.btnRadom.Name = "btnRadom";
            this.btnRadom.Size = new System.Drawing.Size(156, 37);
            this.btnRadom.TabIndex = 7;
            this.btnRadom.Text = "Mật Khẩu Ngẫu Nhiên";
            this.btnRadom.Click += new System.EventHandler(this.btnRadom_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 648);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phần Mềm Quản Lý Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount1;
        private DevExpress.XtraBars.BarButtonItem bbtnXuatTXT;
        private DevExpress.XtraBars.BarButtonItem barbtnGioiThieu;
        private DevExpress.XtraBars.BarButtonItem barbtnThoat;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barbtnXuatExcel;
        private DevExpress.XtraBars.BarButtonItem barbtnXuatTXT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.TextEdit txtNguon;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem barbtnMo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.SimpleButton btnRadom;
    }
}