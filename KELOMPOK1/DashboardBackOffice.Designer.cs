namespace KELOMPOK1
{
    partial class DashboardBackOffice
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardBackOffice));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonStudio = new System.Windows.Forms.Button();
            this.buttonFilm = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panelFilm = new System.Windows.Forms.Panel();
            this.panelStudio = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.labelShowJudul = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridStudio = new System.Windows.Forms.DataGridView();
            this.labelJumlahStudio = new System.Windows.Forms.Label();
            this.labelStudioJudul = new System.Windows.Forms.Label();
            this.labelFilmJudul = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelDashboardJudul = new System.Windows.Forms.Label();
            this.panelDashboardJudul = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelNamaPegawai = new System.Windows.Forms.Label();
            this.labelJabatan = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelFilm.SuspendLayout();
            this.panelStudio.SuspendLayout();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudio)).BeginInit();
            this.panelDashboardJudul.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Controls.Add(this.buttonShow);
            this.panelMenu.Controls.Add(this.buttonStudio);
            this.panelMenu.Controls.Add(this.buttonFilm);
            this.panelMenu.Controls.Add(this.buttonDashboard);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 472);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogout.Image = global::KELOMPOK1.Properties.Resources.Lock_Unlocked;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 432);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(200, 40);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = " Log Out";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseCompatibleTextRendering = true;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonShow.Image = global::KELOMPOK1.Properties.Resources.Wall_Clock;
            this.buttonShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShow.Location = new System.Drawing.Point(0, 123);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(200, 40);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = " Show";
            this.buttonShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonShow.UseCompatibleTextRendering = true;
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonStudio
            // 
            this.buttonStudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.buttonStudio.FlatAppearance.BorderSize = 0;
            this.buttonStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStudio.Image = global::KELOMPOK1.Properties.Resources.Door;
            this.buttonStudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudio.Location = new System.Drawing.Point(0, 82);
            this.buttonStudio.Name = "buttonStudio";
            this.buttonStudio.Size = new System.Drawing.Size(200, 40);
            this.buttonStudio.TabIndex = 2;
            this.buttonStudio.Text = " Studio";
            this.buttonStudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudio.UseCompatibleTextRendering = true;
            this.buttonStudio.UseVisualStyleBackColor = false;
            this.buttonStudio.Click += new System.EventHandler(this.buttonStudio_Click);
            // 
            // buttonFilm
            // 
            this.buttonFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.buttonFilm.FlatAppearance.BorderSize = 0;
            this.buttonFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFilm.Image = global::KELOMPOK1.Properties.Resources.Jewel_Case_Cover;
            this.buttonFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFilm.Location = new System.Drawing.Point(0, 41);
            this.buttonFilm.Name = "buttonFilm";
            this.buttonFilm.Size = new System.Drawing.Size(200, 40);
            this.buttonFilm.TabIndex = 1;
            this.buttonFilm.Text = " Film";
            this.buttonFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFilm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFilm.UseCompatibleTextRendering = true;
            this.buttonFilm.UseVisualStyleBackColor = false;
            this.buttonFilm.Click += new System.EventHandler(this.buttonFilm_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDashboard.Image = global::KELOMPOK1.Properties.Resources.House;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 0);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(200, 40);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = " Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseCompatibleTextRendering = true;
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.panelFilm);
            this.panelDashboard.Controls.Add(this.labelTanggal);
            this.panelDashboard.Controls.Add(this.labelDashboardJudul);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(200, 40);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(594, 432);
            this.panelDashboard.TabIndex = 1;
            // 
            // panelFilm
            // 
            this.panelFilm.Controls.Add(this.panelStudio);
            this.panelFilm.Controls.Add(this.labelFilmJudul);
            this.panelFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilm.Location = new System.Drawing.Point(0, 0);
            this.panelFilm.Name = "panelFilm";
            this.panelFilm.Size = new System.Drawing.Size(594, 432);
            this.panelFilm.TabIndex = 2;
            this.panelFilm.Visible = false;
            // 
            // panelStudio
            // 
            this.panelStudio.Controls.Add(this.panelShow);
            this.panelStudio.Controls.Add(this.button3);
            this.panelStudio.Controls.Add(this.button2);
            this.panelStudio.Controls.Add(this.button1);
            this.panelStudio.Controls.Add(this.dataGridStudio);
            this.panelStudio.Controls.Add(this.labelJumlahStudio);
            this.panelStudio.Controls.Add(this.labelStudioJudul);
            this.panelStudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudio.Location = new System.Drawing.Point(0, 0);
            this.panelStudio.Name = "panelStudio";
            this.panelStudio.Size = new System.Drawing.Size(594, 432);
            this.panelStudio.TabIndex = 2;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.labelShowJudul);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(594, 432);
            this.panelShow.TabIndex = 2;
            this.panelShow.Visible = false;
            // 
            // labelShowJudul
            // 
            this.labelShowJudul.AutoSize = true;
            this.labelShowJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowJudul.Location = new System.Drawing.Point(11, 11);
            this.labelShowJudul.Name = "labelShowJudul";
            this.labelShowJudul.Size = new System.Drawing.Size(82, 20);
            this.labelShowJudul.TabIndex = 0;
            this.labelShowJudul.Text = "Data Show";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(229, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(123, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Perbarui";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridStudio
            // 
            this.dataGridStudio.AllowUserToAddRows = false;
            this.dataGridStudio.AllowUserToDeleteRows = false;
            this.dataGridStudio.AllowUserToResizeColumns = false;
            this.dataGridStudio.AllowUserToResizeRows = false;
            this.dataGridStudio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStudio.BackgroundColor = System.Drawing.Color.White;
            this.dataGridStudio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStudio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridStudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStudio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridStudio.EnableHeadersVisualStyles = false;
            this.dataGridStudio.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridStudio.Location = new System.Drawing.Point(15, 42);
            this.dataGridStudio.MultiSelect = false;
            this.dataGridStudio.Name = "dataGridStudio";
            this.dataGridStudio.ReadOnly = true;
            this.dataGridStudio.RowHeadersVisible = false;
            this.dataGridStudio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStudio.Size = new System.Drawing.Size(567, 150);
            this.dataGridStudio.TabIndex = 4;
            // 
            // labelJumlahStudio
            // 
            this.labelJumlahStudio.AutoSize = true;
            this.labelJumlahStudio.BackColor = System.Drawing.Color.White;
            this.labelJumlahStudio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlahStudio.Location = new System.Drawing.Point(516, 11);
            this.labelJumlahStudio.Name = "labelJumlahStudio";
            this.labelJumlahStudio.Padding = new System.Windows.Forms.Padding(3);
            this.labelJumlahStudio.Size = new System.Drawing.Size(66, 21);
            this.labelJumlahStudio.TabIndex = 3;
            this.labelJumlahStudio.Text = "8 STUDIO";
            // 
            // labelStudioJudul
            // 
            this.labelStudioJudul.AutoSize = true;
            this.labelStudioJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudioJudul.Location = new System.Drawing.Point(11, 11);
            this.labelStudioJudul.Name = "labelStudioJudul";
            this.labelStudioJudul.Size = new System.Drawing.Size(89, 20);
            this.labelStudioJudul.TabIndex = 0;
            this.labelStudioJudul.Text = "Data Studio";
            // 
            // labelFilmJudul
            // 
            this.labelFilmJudul.AutoSize = true;
            this.labelFilmJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilmJudul.Location = new System.Drawing.Point(11, 11);
            this.labelFilmJudul.Name = "labelFilmJudul";
            this.labelFilmJudul.Size = new System.Drawing.Size(74, 20);
            this.labelFilmJudul.TabIndex = 0;
            this.labelFilmJudul.Text = "Data Film";
            // 
            // labelTanggal
            // 
            this.labelTanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(442, 11);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(125, 20);
            this.labelTanggal.TabIndex = 1;
            this.labelTanggal.Text = "00/00/0000 00:00";
            // 
            // labelDashboardJudul
            // 
            this.labelDashboardJudul.AutoSize = true;
            this.labelDashboardJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardJudul.Location = new System.Drawing.Point(11, 11);
            this.labelDashboardJudul.Name = "labelDashboardJudul";
            this.labelDashboardJudul.Size = new System.Drawing.Size(84, 20);
            this.labelDashboardJudul.TabIndex = 0;
            this.labelDashboardJudul.Text = "Dashboard";
            // 
            // panelDashboardJudul
            // 
            this.panelDashboardJudul.BackColor = System.Drawing.Color.White;
            this.panelDashboardJudul.Controls.Add(this.panelUser);
            this.panelDashboardJudul.Controls.Add(this.labelJudul);
            this.panelDashboardJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboardJudul.Location = new System.Drawing.Point(200, 0);
            this.panelDashboardJudul.Name = "panelDashboardJudul";
            this.panelDashboardJudul.Size = new System.Drawing.Size(594, 40);
            this.panelDashboardJudul.TabIndex = 0;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.White;
            this.panelUser.Controls.Add(this.labelNamaPegawai);
            this.panelUser.Controls.Add(this.labelJabatan);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUser.Location = new System.Drawing.Point(434, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Padding = new System.Windows.Forms.Padding(10, 6, 0, 6);
            this.panelUser.Size = new System.Drawing.Size(160, 40);
            this.panelUser.TabIndex = 3;
            // 
            // labelNamaPegawai
            // 
            this.labelNamaPegawai.AutoSize = true;
            this.labelNamaPegawai.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNamaPegawai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaPegawai.Location = new System.Drawing.Point(10, 6);
            this.labelNamaPegawai.Name = "labelNamaPegawai";
            this.labelNamaPegawai.Size = new System.Drawing.Size(39, 15);
            this.labelNamaPegawai.TabIndex = 1;
            this.labelNamaPegawai.Text = "Nama";
            this.labelNamaPegawai.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelJabatan
            // 
            this.labelJabatan.AutoSize = true;
            this.labelJabatan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelJabatan.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.labelJabatan.Location = new System.Drawing.Point(10, 22);
            this.labelJabatan.Name = "labelJabatan";
            this.labelJabatan.Size = new System.Drawing.Size(89, 12);
            this.labelJabatan.TabIndex = 2;
            this.labelJabatan.Text = "BACKEND OFFICER";
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(10, 3);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(107, 36);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "CINEMAX";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelJudul.UseCompatibleTextRendering = true;
            // 
            // DashboardBackOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(794, 472);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panelDashboardJudul);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardBackOffice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panelFilm.ResumeLayout(false);
            this.panelFilm.PerformLayout();
            this.panelStudio.ResumeLayout(false);
            this.panelStudio.PerformLayout();
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudio)).EndInit();
            this.panelDashboardJudul.ResumeLayout(false);
            this.panelDashboardJudul.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelDashboardJudul;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonStudio;
        private System.Windows.Forms.Button buttonFilm;
        private System.Windows.Forms.Label labelNamaPegawai;
        private System.Windows.Forms.Label labelJabatan;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelDashboardJudul;
        private System.Windows.Forms.Panel panelFilm;
        private System.Windows.Forms.Label labelFilmJudul;
        private System.Windows.Forms.Panel panelStudio;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Label labelShowJudul;
        private System.Windows.Forms.Label labelStudioJudul;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelJumlahStudio;
        private System.Windows.Forms.DataGridView dataGridStudio;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}