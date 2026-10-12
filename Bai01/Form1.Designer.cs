namespace Bai01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            lblHeaderSubtitle = new Label();
            grpThongTin = new GroupBox();
            tlpThongTin = new TableLayoutPanel();
            lblTenHang = new Label();
            txtTenHang = new TextBox();
            lblLoaiHang = new Label();
            cboLoaiHang = new ComboBox();
            lblDonVi = new Label();
            cboDonVi = new ComboBox();
            lblGiaBan = new Label();
            nudGiaBan = new NumericUpDown();
            lblSoLuongTon = new Label();
            nudSoLuongTon = new NumericUpDown();
            lblNgayNhap = new Label();
            dtpNgayNhap = new DateTimePicker();
            chkConKinhDoanh = new CheckBox();
            flpButtons = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            grpTimKiem = new GroupBox();
            flpTimKiem = new FlowLayoutPanel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            lblLocLoaiHang = new Label();
            cboLocLoaiHang = new ComboBox();
            chkChiConKinhDoanh = new CheckBox();
            lblTrangThai = new Label();
            grpBaoCao = new GroupBox();
            flpBaoCao = new FlowLayoutPanel();
            btnXemBangGia = new Button();
            btnXuatPdf = new Button();
            btnInTrucTiep = new Button();
            btnXuatExcelLuoi = new Button();
            btnXuatExcelTonKho = new Button();
            grpDanhSach = new GroupBox();
            dgvHangHoa = new DataGridView();
            colMaHang = new DataGridViewTextBoxColumn();
            colTenHang = new DataGridViewTextBoxColumn();
            colLoaiHang = new DataGridViewTextBoxColumn();
            colDonVi = new DataGridViewTextBoxColumn();
            colGiaBan = new DataGridViewTextBoxColumn();
            colSoLuongTon = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            colConKinhDoanh = new DataGridViewCheckBoxColumn();
            pnlHeader.SuspendLayout();
            grpThongTin.SuspendLayout();
            tlpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongTon).BeginInit();
            flpButtons.SuspendLayout();
            grpTimKiem.SuspendLayout();
            flpTimKiem.SuspendLayout();
            grpBaoCao.SuspendLayout();
            flpBaoCao.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(24, 76, 120);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Controls.Add(lblHeaderSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(16, 10, 16, 10);
            pnlHeader.Size = new Size(1084, 70);
            pnlHeader.TabIndex = 4;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(14, 10);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(596, 30);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "HỆ THỐNG QUẢN LÝ TIỆM TẠP HÓA - NHÀ TRƯỜNG UTC2";
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 9.75F);
            lblHeaderSubtitle.ForeColor = Color.FromArgb(220, 235, 252);
            lblHeaderSubtitle.Location = new Point(16, 42);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(442, 17);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Quản lý danh mục hàng hóa, in bảng giá FastReport và xuất báo cáo Excel";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(tlpThongTin);
            grpThongTin.Controls.Add(flpButtons);
            grpThongTin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpThongTin.Location = new Point(16, 80);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(1052, 165);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin hàng hóa";
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 6;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpThongTin.Controls.Add(lblTenHang, 0, 0);
            tlpThongTin.Controls.Add(txtTenHang, 1, 0);
            tlpThongTin.Controls.Add(lblLoaiHang, 2, 0);
            tlpThongTin.Controls.Add(cboLoaiHang, 3, 0);
            tlpThongTin.Controls.Add(lblDonVi, 4, 0);
            tlpThongTin.Controls.Add(cboDonVi, 5, 0);
            tlpThongTin.Controls.Add(lblGiaBan, 0, 1);
            tlpThongTin.Controls.Add(nudGiaBan, 1, 1);
            tlpThongTin.Controls.Add(lblSoLuongTon, 2, 1);
            tlpThongTin.Controls.Add(nudSoLuongTon, 3, 1);
            tlpThongTin.Controls.Add(lblNgayNhap, 4, 1);
            tlpThongTin.Controls.Add(dtpNgayNhap, 5, 1);
            tlpThongTin.Controls.Add(chkConKinhDoanh, 1, 2);
            tlpThongTin.Font = new Font("Segoe UI", 9.5F);
            tlpThongTin.Location = new Point(12, 24);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 3;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpThongTin.Size = new Size(1028, 94);
            tlpThongTin.TabIndex = 0;
            // 
            // lblTenHang
            // 
            lblTenHang.Anchor = AnchorStyles.Left;
            lblTenHang.AutoSize = true;
            lblTenHang.Location = new Point(3, 7);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(81, 17);
            lblTenHang.TabIndex = 0;
            lblTenHang.Text = "Tên hàng (*):";
            // 
            // txtTenHang
            // 
            txtTenHang.Dock = DockStyle.Fill;
            txtTenHang.Location = new Point(98, 3);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(287, 24);
            txtTenHang.TabIndex = 1;
            // 
            // lblLoaiHang
            // 
            lblLoaiHang.Anchor = AnchorStyles.Left;
            lblLoaiHang.AutoSize = true;
            lblLoaiHang.Location = new Point(391, 7);
            lblLoaiHang.Name = "lblLoaiHang";
            lblLoaiHang.Size = new Size(68, 17);
            lblLoaiHang.TabIndex = 2;
            lblLoaiHang.Text = "Loại hàng:";
            // 
            // cboLoaiHang
            // 
            cboLoaiHang.Dock = DockStyle.Fill;
            cboLoaiHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiHang.Location = new Point(486, 3);
            cboLoaiHang.Name = "cboLoaiHang";
            cboLoaiHang.Size = new Size(213, 25);
            cboLoaiHang.TabIndex = 3;
            // 
            // lblDonVi
            // 
            lblDonVi.Anchor = AnchorStyles.Left;
            lblDonVi.AutoSize = true;
            lblDonVi.Location = new Point(705, 7);
            lblDonVi.Name = "lblDonVi";
            lblDonVi.Size = new Size(73, 17);
            lblDonVi.TabIndex = 4;
            lblDonVi.Text = "Đơn vị tính:";
            // 
            // cboDonVi
            // 
            cboDonVi.Dock = DockStyle.Fill;
            cboDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDonVi.Location = new Point(810, 3);
            cboDonVi.Name = "cboDonVi";
            cboDonVi.Size = new Size(215, 25);
            cboDonVi.TabIndex = 5;
            // 
            // lblGiaBan
            // 
            lblGiaBan.Anchor = AnchorStyles.Left;
            lblGiaBan.AutoSize = true;
            lblGiaBan.Location = new Point(3, 39);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(76, 17);
            lblGiaBan.TabIndex = 6;
            lblGiaBan.Text = "Giá bán (đ):";
            // 
            // nudGiaBan
            // 
            nudGiaBan.Dock = DockStyle.Fill;
            nudGiaBan.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            nudGiaBan.Location = new Point(98, 35);
            nudGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudGiaBan.Name = "nudGiaBan";
            nudGiaBan.Size = new Size(287, 24);
            nudGiaBan.TabIndex = 7;
            nudGiaBan.ThousandsSeparator = true;
            // 
            // lblSoLuongTon
            // 
            lblSoLuongTon.Anchor = AnchorStyles.Left;
            lblSoLuongTon.AutoSize = true;
            lblSoLuongTon.Location = new Point(391, 39);
            lblSoLuongTon.Name = "lblSoLuongTon";
            lblSoLuongTon.Size = new Size(87, 17);
            lblSoLuongTon.TabIndex = 8;
            lblSoLuongTon.Text = "Số lượng tồn:";
            // 
            // nudSoLuongTon
            // 
            nudSoLuongTon.Dock = DockStyle.Fill;
            nudSoLuongTon.Location = new Point(486, 35);
            nudSoLuongTon.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSoLuongTon.Name = "nudSoLuongTon";
            nudSoLuongTon.Size = new Size(213, 24);
            nudSoLuongTon.TabIndex = 9;
            nudSoLuongTon.ThousandsSeparator = true;
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.Anchor = AnchorStyles.Left;
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Location = new Point(705, 39);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(75, 17);
            lblNgayNhap.TabIndex = 10;
            lblNgayNhap.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            dtpNgayNhap.Dock = DockStyle.Fill;
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(810, 35);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(215, 24);
            dtpNgayNhap.TabIndex = 11;
            // 
            // chkConKinhDoanh
            // 
            chkConKinhDoanh.Anchor = AnchorStyles.Left;
            chkConKinhDoanh.AutoSize = true;
            chkConKinhDoanh.Checked = true;
            chkConKinhDoanh.CheckState = CheckState.Checked;
            chkConKinhDoanh.Location = new Point(98, 68);
            chkConKinhDoanh.Name = "chkConKinhDoanh";
            chkConKinhDoanh.Size = new Size(118, 21);
            chkConKinhDoanh.TabIndex = 12;
            chkConKinhDoanh.Text = "Còn kinh doanh";
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnThem);
            flpButtons.Controls.Add(btnSua);
            flpButtons.Controls.Add(btnXoa);
            flpButtons.Controls.Add(btnLamMoi);
            flpButtons.Font = new Font("Segoe UI", 9.5F);
            flpButtons.Location = new Point(12, 122);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(1028, 38);
            flpButtons.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 30);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(114, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 30);
            btnSua.TabIndex = 1;
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(225, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 30);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(336, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 30);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // grpTimKiem
            // 
            grpTimKiem.Controls.Add(flpTimKiem);
            grpTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpTimKiem.Location = new Point(16, 250);
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.Size = new Size(1052, 65);
            grpTimKiem.TabIndex = 1;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "Tìm kiếm && Lọc danh sách";
            // 
            // flpTimKiem
            // 
            flpTimKiem.Controls.Add(lblTimKiem);
            flpTimKiem.Controls.Add(txtTimKiem);
            flpTimKiem.Controls.Add(lblLocLoaiHang);
            flpTimKiem.Controls.Add(cboLocLoaiHang);
            flpTimKiem.Controls.Add(chkChiConKinhDoanh);
            flpTimKiem.Controls.Add(lblTrangThai);
            flpTimKiem.Dock = DockStyle.Fill;
            flpTimKiem.Font = new Font("Segoe UI", 9.5F);
            flpTimKiem.Location = new Point(3, 21);
            flpTimKiem.Name = "flpTimKiem";
            flpTimKiem.Padding = new Padding(6, 4, 6, 4);
            flpTimKiem.Size = new Size(1046, 41);
            flpTimKiem.TabIndex = 0;
            // 
            // lblTimKiem
            // 
            lblTimKiem.Anchor = AnchorStyles.Left;
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(9, 11);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(84, 17);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm theo tên:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(99, 7);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập từ khóa tìm kiếm (vd: nước)...";
            txtTimKiem.Size = new Size(230, 24);
            txtTimKiem.TabIndex = 1;
            // 
            // lblLocLoaiHang
            // 
            lblLocLoaiHang.Anchor = AnchorStyles.Left;
            lblLocLoaiHang.AutoSize = true;
            lblLocLoaiHang.Location = new Point(335, 11);
            lblLocLoaiHang.Name = "lblLocLoaiHang";
            lblLocLoaiHang.Size = new Size(68, 17);
            lblLocLoaiHang.TabIndex = 2;
            lblLocLoaiHang.Text = "Loại hàng:";
            // 
            // cboLocLoaiHang
            // 
            cboLocLoaiHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLoaiHang.Location = new Point(409, 7);
            cboLocLoaiHang.Name = "cboLocLoaiHang";
            cboLocLoaiHang.Size = new Size(160, 25);
            cboLocLoaiHang.TabIndex = 3;
            // 
            // chkChiConKinhDoanh
            // 
            chkChiConKinhDoanh.Anchor = AnchorStyles.Left;
            chkChiConKinhDoanh.AutoSize = true;
            chkChiConKinhDoanh.Location = new Point(575, 9);
            chkChiConKinhDoanh.Name = "chkChiConKinhDoanh";
            chkChiConKinhDoanh.Size = new Size(199, 21);
            chkChiConKinhDoanh.TabIndex = 4;
            chkChiConKinhDoanh.Text = "Chỉ hiện hàng còn kinh doanh";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Anchor = AnchorStyles.Left;
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTrangThai.ForeColor = Color.FromArgb(24, 76, 120);
            lblTrangThai.Location = new Point(780, 11);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(137, 17);
            lblTrangThai.TabIndex = 5;
            lblTrangThai.Text = "Tìm thấy 6 mặt hàng";
            // 
            // grpBaoCao
            // 
            grpBaoCao.Controls.Add(flpBaoCao);
            grpBaoCao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpBaoCao.Location = new Point(16, 320);
            grpBaoCao.Name = "grpBaoCao";
            grpBaoCao.Size = new Size(1052, 65);
            grpBaoCao.TabIndex = 2;
            grpBaoCao.TabStop = false;
            grpBaoCao.Text = "Báo cáo FastReport && Xuất Excel (ClosedXML)";
            // 
            // flpBaoCao
            // 
            flpBaoCao.Controls.Add(btnXemBangGia);
            flpBaoCao.Controls.Add(btnXuatPdf);
            flpBaoCao.Controls.Add(btnInTrucTiep);
            flpBaoCao.Controls.Add(btnXuatExcelLuoi);
            flpBaoCao.Controls.Add(btnXuatExcelTonKho);
            flpBaoCao.Dock = DockStyle.Fill;
            flpBaoCao.Font = new Font("Segoe UI", 9.5F);
            flpBaoCao.Location = new Point(3, 21);
            flpBaoCao.Name = "flpBaoCao";
            flpBaoCao.Padding = new Padding(6, 4, 6, 4);
            flpBaoCao.Size = new Size(1046, 41);
            flpBaoCao.TabIndex = 0;
            // 
            // btnXemBangGia
            // 
            btnXemBangGia.BackColor = Color.FromArgb(23, 162, 184);
            btnXemBangGia.Cursor = Cursors.Hand;
            btnXemBangGia.FlatStyle = FlatStyle.Flat;
            btnXemBangGia.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXemBangGia.ForeColor = Color.White;
            btnXemBangGia.Location = new Point(9, 7);
            btnXemBangGia.Name = "btnXemBangGia";
            btnXemBangGia.Size = new Size(185, 30);
            btnXemBangGia.TabIndex = 0;
            btnXemBangGia.Text = "📄 Xem bảng giá (FastReport)";
            btnXemBangGia.UseVisualStyleBackColor = false;
            // 
            // btnXuatPdf
            // 
            btnXuatPdf.BackColor = Color.FromArgb(111, 66, 193);
            btnXuatPdf.Cursor = Cursors.Hand;
            btnXuatPdf.FlatStyle = FlatStyle.Flat;
            btnXuatPdf.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXuatPdf.ForeColor = Color.White;
            btnXuatPdf.Location = new Point(200, 7);
            btnXuatPdf.Name = "btnXuatPdf";
            btnXuatPdf.Size = new Size(155, 30);
            btnXuatPdf.TabIndex = 1;
            btnXuatPdf.Text = "📑 Xuất bảng giá PDF";
            btnXuatPdf.UseVisualStyleBackColor = false;
            // 
            // btnInTrucTiep
            // 
            btnInTrucTiep.BackColor = Color.FromArgb(52, 58, 64);
            btnInTrucTiep.Cursor = Cursors.Hand;
            btnInTrucTiep.FlatStyle = FlatStyle.Flat;
            btnInTrucTiep.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnInTrucTiep.ForeColor = Color.White;
            btnInTrucTiep.Location = new Point(361, 7);
            btnInTrucTiep.Name = "btnInTrucTiep";
            btnInTrucTiep.Size = new Size(180, 30);
            btnInTrucTiep.TabIndex = 2;
            btnInTrucTiep.Text = "🖨️ In trực tiếp (Printer)";
            btnInTrucTiep.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcelLuoi
            // 
            btnXuatExcelLuoi.BackColor = Color.FromArgb(33, 115, 70);
            btnXuatExcelLuoi.Cursor = Cursors.Hand;
            btnXuatExcelLuoi.FlatStyle = FlatStyle.Flat;
            btnXuatExcelLuoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXuatExcelLuoi.ForeColor = Color.White;
            btnXuatExcelLuoi.Location = new Point(547, 7);
            btnXuatExcelLuoi.Name = "btnXuatExcelLuoi";
            btnXuatExcelLuoi.Size = new Size(175, 30);
            btnXuatExcelLuoi.TabIndex = 3;
            btnXuatExcelLuoi.Text = "📊 Xuất Excel (lưới)";
            btnXuatExcelLuoi.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcelTonKho
            // 
            btnXuatExcelTonKho.BackColor = Color.FromArgb(16, 124, 65);
            btnXuatExcelTonKho.Cursor = Cursors.Hand;
            btnXuatExcelTonKho.FlatStyle = FlatStyle.Flat;
            btnXuatExcelTonKho.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXuatExcelTonKho.ForeColor = Color.White;
            btnXuatExcelTonKho.Location = new Point(728, 7);
            btnXuatExcelTonKho.Name = "btnXuatExcelTonKho";
            btnXuatExcelTonKho.Size = new Size(185, 30);
            btnXuatExcelTonKho.TabIndex = 4;
            btnXuatExcelTonKho.Text = "📈 Xuất Excel tồn kho";
            btnXuatExcelTonKho.UseVisualStyleBackColor = false;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSach.Controls.Add(dgvHangHoa);
            grpDanhSach.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpDanhSach.Location = new Point(16, 390);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1052, 280);
            grpDanhSach.TabIndex = 3;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách hàng hóa";
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.AllowUserToDeleteRows = false;
            dgvHangHoa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 248, 252);
            dgvHangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangHoa.BackgroundColor = Color.White;
            dgvHangHoa.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(235, 240, 248);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHangHoa.ColumnHeadersHeight = 32;
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHangHoa.Columns.AddRange(new DataGridViewColumn[] { colMaHang, colTenHang, colLoaiHang, colDonVi, colGiaBan, colSoLuongTon, colNgayNhap, colConKinhDoanh });
            dgvHangHoa.Dock = DockStyle.Fill;
            dgvHangHoa.EnableHeadersVisualStyles = false;
            dgvHangHoa.Font = new Font("Segoe UI", 9.5F);
            dgvHangHoa.Location = new Point(3, 21);
            dgvHangHoa.MultiSelect = false;
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.ReadOnly = true;
            dgvHangHoa.RowHeadersVisible = false;
            dgvHangHoa.RowHeadersWidth = 30;
            dgvHangHoa.RowTemplate.Height = 28;
            dgvHangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHangHoa.Size = new Size(1046, 256);
            dgvHangHoa.TabIndex = 0;
            // 
            // colMaHang
            // 
            colMaHang.DataPropertyName = "MaHang";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaHang.DefaultCellStyle = dataGridViewCellStyle3;
            colMaHang.FillWeight = 50F;
            colMaHang.HeaderText = "Mã hàng";
            colMaHang.Name = "colMaHang";
            colMaHang.ReadOnly = true;
            // 
            // colTenHang
            // 
            colTenHang.DataPropertyName = "TenHang";
            colTenHang.FillWeight = 160F;
            colTenHang.HeaderText = "Tên hàng";
            colTenHang.Name = "colTenHang";
            colTenHang.ReadOnly = true;
            // 
            // colLoaiHang
            // 
            colLoaiHang.DataPropertyName = "LoaiHang";
            colLoaiHang.FillWeight = 85F;
            colLoaiHang.HeaderText = "Loại hàng";
            colLoaiHang.Name = "colLoaiHang";
            colLoaiHang.ReadOnly = true;
            // 
            // colDonVi
            // 
            colDonVi.DataPropertyName = "DonVi";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDonVi.DefaultCellStyle = dataGridViewCellStyle4;
            colDonVi.FillWeight = 55F;
            colDonVi.HeaderText = "Đơn vị";
            colDonVi.Name = "colDonVi";
            colDonVi.ReadOnly = true;
            // 
            // colGiaBan
            // 
            colGiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            colGiaBan.DefaultCellStyle = dataGridViewCellStyle5;
            colGiaBan.FillWeight = 75F;
            colGiaBan.HeaderText = "Giá bán (đ)";
            colGiaBan.Name = "colGiaBan";
            colGiaBan.ReadOnly = true;
            // 
            // colSoLuongTon
            // 
            colSoLuongTon.DataPropertyName = "SoLuongTon";
            colSoLuongTon.DefaultCellStyle = dataGridViewCellStyle5;
            colSoLuongTon.FillWeight = 65F;
            colSoLuongTon.HeaderText = "Số lượng tồn";
            colSoLuongTon.Name = "colSoLuongTon";
            colSoLuongTon.ReadOnly = true;
            // 
            // colNgayNhap
            // 
            colNgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            colNgayNhap.DefaultCellStyle = dataGridViewCellStyle6;
            colNgayNhap.FillWeight = 75F;
            colNgayNhap.HeaderText = "Ngày nhập";
            colNgayNhap.Name = "colNgayNhap";
            colNgayNhap.ReadOnly = true;
            // 
            // colConKinhDoanh
            // 
            colConKinhDoanh.DataPropertyName = "ConKinhDoanh";
            colConKinhDoanh.FillWeight = 65F;
            colConKinhDoanh.HeaderText = "Kinh doanh";
            colConKinhDoanh.Name = "colConKinhDoanh";
            colConKinhDoanh.ReadOnly = true;
            colConKinhDoanh.Resizable = DataGridViewTriState.True;
            colConKinhDoanh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1084, 680);
            Controls.Add(grpDanhSach);
            Controls.Add(grpBaoCao);
            Controls.Add(grpTimKiem);
            Controls.Add(grpThongTin);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(1000, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tiệm tạp hóa Nhà trường UTC2 - Bảng giá và Tồn kho";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpThongTin.ResumeLayout(false);
            tlpThongTin.ResumeLayout(false);
            tlpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongTon).EndInit();
            flpButtons.ResumeLayout(false);
            grpTimKiem.ResumeLayout(false);
            flpTimKiem.ResumeLayout(false);
            flpTimKiem.PerformLayout();
            grpBaoCao.ResumeLayout(false);
            flpBaoCao.ResumeLayout(false);
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TableLayoutPanel tlpThongTin;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.ComboBox cboDonVi;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.NumericUpDown nudGiaBan;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.NumericUpDown nudSoLuongTon;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.CheckBox chkConKinhDoanh;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.FlowLayoutPanel flpTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLocLoaiHang;
        private System.Windows.Forms.ComboBox cboLocLoaiHang;
        private System.Windows.Forms.CheckBox chkChiConKinhDoanh;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.GroupBox grpBaoCao;
        private System.Windows.Forms.FlowLayoutPanel flpBaoCao;
        private System.Windows.Forms.Button btnXemBangGia;
        private System.Windows.Forms.Button btnXuatPdf;
        private System.Windows.Forms.Button btnInTrucTiep;
        private System.Windows.Forms.Button btnXuatExcelLuoi;
        private System.Windows.Forms.Button btnXuatExcelTonKho;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colConKinhDoanh;
    }
}
