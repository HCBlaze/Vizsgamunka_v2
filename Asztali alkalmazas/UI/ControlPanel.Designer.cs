namespace Asztali_alkalmazas.UI
{
    partial class ControlPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.ordersBT = new System.Windows.Forms.Button();
            this.ExitBT = new System.Windows.Forms.Button();
            this.raktarBT = new System.Windows.Forms.Button();
            this.supplierBT = new System.Windows.Forms.Button();
            this.CustomerBT = new System.Windows.Forms.Button();
            this.mainBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maxBT = new System.Windows.Forms.Button();
            this.minBT = new System.Windows.Forms.Button();
            this.closeBT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSlide2 = new System.Windows.Forms.Panel();
            this.kijelentkezBT = new System.Windows.Forms.Button();
            this.userProfilBT = new System.Windows.Forms.Button();
            this.userProfilePic = new System.Windows.Forms.PictureBox();
            this.adminLL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adminBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customer_UC1 = new Asztali_alkalmazas.UI.UserControls.Customer_UC();
            this.adminControl_UC1 = new Asztali_alkalmazas.UI.UserControls.AdminControl_UC();
            this.userProfil_UC1 = new Asztali_alkalmazas.UI.UserControls.UserProfil_UC();
            this.supplier_UC1 = new Asztali_alkalmazas.UI.UserControls.Supplier_UC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.ordersBT);
            this.panel1.Controls.Add(this.ExitBT);
            this.panel1.Controls.Add(this.raktarBT);
            this.panel1.Controls.Add(this.supplierBT);
            this.panel1.Controls.Add(this.CustomerBT);
            this.panel1.Controls.Add(this.mainBT);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1044);
            this.panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.Orange;
            this.panelSlide.Location = new System.Drawing.Point(0, 282);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(15, 109);
            this.panelSlide.TabIndex = 3;
            // 
            // ordersBT
            // 
            this.ordersBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersBT.FlatAppearance.BorderSize = 0;
            this.ordersBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersBT.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_purchase_order_50px;
            this.ordersBT.Location = new System.Drawing.Point(0, 626);
            this.ordersBT.Name = "ordersBT";
            this.ordersBT.Size = new System.Drawing.Size(200, 109);
            this.ordersBT.TabIndex = 9;
            this.ordersBT.Text = "Rendelések";
            this.ordersBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ordersBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ordersBT.UseVisualStyleBackColor = true;
            this.ordersBT.Click += new System.EventHandler(this.ordersBT_Click);
            // 
            // ExitBT
            // 
            this.ExitBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitBT.FlatAppearance.BorderSize = 0;
            this.ExitBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBT.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_exit_sign_50px;
            this.ExitBT.Location = new System.Drawing.Point(13, 955);
            this.ExitBT.Name = "ExitBT";
            this.ExitBT.Size = new System.Drawing.Size(185, 86);
            this.ExitBT.TabIndex = 7;
            this.ExitBT.Text = "Kilépés";
            this.ExitBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitBT.UseVisualStyleBackColor = true;
            this.ExitBT.Click += new System.EventHandler(this.ExitBT_Click);
            // 
            // raktarBT
            // 
            this.raktarBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.raktarBT.FlatAppearance.BorderSize = 0;
            this.raktarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raktarBT.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_warehouse_50px;
            this.raktarBT.Location = new System.Drawing.Point(0, 517);
            this.raktarBT.Name = "raktarBT";
            this.raktarBT.Size = new System.Drawing.Size(200, 109);
            this.raktarBT.TabIndex = 6;
            this.raktarBT.Text = "Árukészlet";
            this.raktarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.raktarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.raktarBT.UseVisualStyleBackColor = true;
            this.raktarBT.Click += new System.EventHandler(this.raktarBT_Click);
            // 
            // supplierBT
            // 
            this.supplierBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplierBT.FlatAppearance.BorderSize = 0;
            this.supplierBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierBT.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_supplier_50px;
            this.supplierBT.Location = new System.Drawing.Point(0, 408);
            this.supplierBT.Name = "supplierBT";
            this.supplierBT.Size = new System.Drawing.Size(200, 109);
            this.supplierBT.TabIndex = 5;
            this.supplierBT.Text = "Beszállítók";
            this.supplierBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.supplierBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.supplierBT.UseVisualStyleBackColor = true;
            this.supplierBT.Click += new System.EventHandler(this.supplierBT_Click);
            // 
            // CustomerBT
            // 
            this.CustomerBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerBT.FlatAppearance.BorderSize = 0;
            this.CustomerBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBT.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_customer_50px_1;
            this.CustomerBT.Location = new System.Drawing.Point(0, 299);
            this.CustomerBT.Name = "CustomerBT";
            this.CustomerBT.Size = new System.Drawing.Size(200, 109);
            this.CustomerBT.TabIndex = 4;
            this.CustomerBT.Text = "Vásárlók";
            this.CustomerBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomerBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CustomerBT.UseVisualStyleBackColor = true;
            this.CustomerBT.Click += new System.EventHandler(this.CustomerBT_Click);
            // 
            // mainBT
            // 
            this.mainBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainBT.FlatAppearance.BorderSize = 0;
            this.mainBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainBT.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_home_page_50px;
            this.mainBT.Location = new System.Drawing.Point(0, 190);
            this.mainBT.Name = "mainBT";
            this.mainBT.Size = new System.Drawing.Size(200, 109);
            this.mainBT.TabIndex = 3;
            this.mainBT.Text = "Főoldal";
            this.mainBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mainBT.UseVisualStyleBackColor = true;
            this.mainBT.Click += new System.EventHandler(this.mainBT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 190);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "for small businesses";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ERP Solution";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Asztali_alkalmazas.Properties.Resources.project_23;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.maxBT);
            this.panel3.Controls.Add(this.minBT);
            this.panel3.Controls.Add(this.closeBT);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1470, 58);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // maxBT
            // 
            this.maxBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBT.FlatAppearance.BorderSize = 0;
            this.maxBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBT.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_toggle_full_screen_50px;
            this.maxBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maxBT.Location = new System.Drawing.Point(1338, 0);
            this.maxBT.Margin = new System.Windows.Forms.Padding(5);
            this.maxBT.Name = "maxBT";
            this.maxBT.Padding = new System.Windows.Forms.Padding(5);
            this.maxBT.Size = new System.Drawing.Size(66, 58);
            this.maxBT.TabIndex = 24;
            this.maxBT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.maxBT.UseVisualStyleBackColor = true;
            this.maxBT.Click += new System.EventHandler(this.maxBT_Click);
            this.maxBT.MouseEnter += new System.EventHandler(this.maxBT_MouseEnter);
            this.maxBT.MouseLeave += new System.EventHandler(this.maxBT_MouseLeave);
            // 
            // minBT
            // 
            this.minBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBT.FlatAppearance.BorderSize = 0;
            this.minBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBT.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_minimize_window_50px;
            this.minBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minBT.Location = new System.Drawing.Point(1272, 0);
            this.minBT.Margin = new System.Windows.Forms.Padding(5);
            this.minBT.Name = "minBT";
            this.minBT.Padding = new System.Windows.Forms.Padding(5);
            this.minBT.Size = new System.Drawing.Size(66, 58);
            this.minBT.TabIndex = 23;
            this.minBT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.minBT.UseVisualStyleBackColor = true;
            this.minBT.Click += new System.EventHandler(this.minBT_Click);
            this.minBT.MouseEnter += new System.EventHandler(this.minBT_MouseEnter);
            this.minBT.MouseLeave += new System.EventHandler(this.minBT_MouseLeave);
            // 
            // closeBT
            // 
            this.closeBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBT.FlatAppearance.BorderSize = 0;
            this.closeBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBT.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_shutdown_50px;
            this.closeBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBT.Location = new System.Drawing.Point(1404, 0);
            this.closeBT.Margin = new System.Windows.Forms.Padding(5);
            this.closeBT.Name = "closeBT";
            this.closeBT.Padding = new System.Windows.Forms.Padding(5);
            this.closeBT.Size = new System.Drawing.Size(66, 58);
            this.closeBT.TabIndex = 22;
            this.closeBT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.closeBT.UseVisualStyleBackColor = true;
            this.closeBT.Click += new System.EventHandler(this.closeBT_Click);
            this.closeBT.MouseEnter += new System.EventHandler(this.closeBT_MouseEnter);
            this.closeBT.MouseLeave += new System.EventHandler(this.closeBT_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Akashi_hun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(151, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Akashi_hun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(16, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dátum és idő:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelSlide2);
            this.panel4.Controls.Add(this.kijelentkezBT);
            this.panel4.Controls.Add(this.userProfilBT);
            this.panel4.Controls.Add(this.userProfilePic);
            this.panel4.Controls.Add(this.adminLL);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.adminBT);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1470, 132);
            this.panel4.TabIndex = 2;
            // 
            // panelSlide2
            // 
            this.panelSlide2.BackColor = System.Drawing.Color.Orange;
            this.panelSlide2.Location = new System.Drawing.Point(1138, 95);
            this.panelSlide2.Name = "panelSlide2";
            this.panelSlide2.Size = new System.Drawing.Size(46, 5);
            this.panelSlide2.TabIndex = 24;
            this.panelSlide2.Visible = false;
            // 
            // kijelentkezBT
            // 
            this.kijelentkezBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kijelentkezBT.FlatAppearance.BorderSize = 0;
            this.kijelentkezBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kijelentkezBT.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_Logout_50px;
            this.kijelentkezBT.Location = new System.Drawing.Point(1344, 0);
            this.kijelentkezBT.Name = "kijelentkezBT";
            this.kijelentkezBT.Size = new System.Drawing.Size(125, 132);
            this.kijelentkezBT.TabIndex = 23;
            this.kijelentkezBT.Text = "Kijelentkezés";
            this.kijelentkezBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kijelentkezBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.kijelentkezBT.UseVisualStyleBackColor = true;
            this.kijelentkezBT.Click += new System.EventHandler(this.kijelentkezBT_Click);
            // 
            // userProfilBT
            // 
            this.userProfilBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userProfilBT.FlatAppearance.BorderSize = 0;
            this.userProfilBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userProfilBT.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_profile_50px;
            this.userProfilBT.Location = new System.Drawing.Point(1271, 19);
            this.userProfilBT.Name = "userProfilBT";
            this.userProfilBT.Size = new System.Drawing.Size(60, 86);
            this.userProfilBT.TabIndex = 3;
            this.userProfilBT.Text = "Profil";
            this.userProfilBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userProfilBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.userProfilBT.UseVisualStyleBackColor = true;
            this.userProfilBT.Click += new System.EventHandler(this.userProfilBT_Click);
            // 
            // userProfilePic
            // 
            this.userProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userProfilePic.Dock = System.Windows.Forms.DockStyle.Left;
            this.userProfilePic.Image = global::Asztali_alkalmazas.Properties.Resources.profilpic;
            this.userProfilePic.Location = new System.Drawing.Point(0, 0);
            this.userProfilePic.Name = "userProfilePic";
            this.userProfilePic.Size = new System.Drawing.Size(111, 132);
            this.userProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userProfilePic.TabIndex = 22;
            this.userProfilePic.TabStop = false;
            // 
            // adminLL
            // 
            this.adminLL.AutoSize = true;
            this.adminLL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminLL.Location = new System.Drawing.Point(287, 76);
            this.adminLL.Name = "adminLL";
            this.adminLL.Size = new System.Drawing.Size(48, 16);
            this.adminLL.TabIndex = 21;
            this.adminLL.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label5.Location = new System.Drawing.Point(162, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Jogosultság: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(287, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(162, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Felhasználó:";
            // 
            // adminBT
            // 
            this.adminBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminBT.FlatAppearance.BorderSize = 0;
            this.adminBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBT.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_system_administrator_male_50px;
            this.adminBT.Location = new System.Drawing.Point(1124, 19);
            this.adminBT.Name = "adminBT";
            this.adminBT.Size = new System.Drawing.Size(134, 86);
            this.adminBT.TabIndex = 25;
            this.adminBT.Text = "Admin felület";
            this.adminBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adminBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.adminBT.UseVisualStyleBackColor = true;
            this.adminBT.Click += new System.EventHandler(this.adminBT_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customer_UC1
            // 
            this.customer_UC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.customer_UC1.Location = new System.Drawing.Point(859, 238);
            this.customer_UC1.Margin = new System.Windows.Forms.Padding(4);
            this.customer_UC1.Name = "customer_UC1";
            this.customer_UC1.Size = new System.Drawing.Size(1454, 848);
            this.customer_UC1.TabIndex = 5;
            this.customer_UC1.Visible = false;
            // 
            // adminControl_UC1
            // 
            this.adminControl_UC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.adminControl_UC1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminControl_UC1.Location = new System.Drawing.Point(388, 262);
            this.adminControl_UC1.Name = "adminControl_UC1";
            this.adminControl_UC1.Size = new System.Drawing.Size(1454, 848);
            this.adminControl_UC1.TabIndex = 4;
            this.adminControl_UC1.Visible = false;
            // 
            // userProfil_UC1
            // 
            this.userProfil_UC1.AutoScroll = true;
            this.userProfil_UC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.userProfil_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userProfil_UC1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userProfil_UC1.Location = new System.Drawing.Point(200, 190);
            this.userProfil_UC1.Name = "userProfil_UC1";
            this.userProfil_UC1.Size = new System.Drawing.Size(1470, 854);
            this.userProfil_UC1.TabIndex = 3;
            this.userProfil_UC1.Visible = false;
            // 
            // supplier_UC1
            // 
            this.supplier_UC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.supplier_UC1.Location = new System.Drawing.Point(1102, 450);
            this.supplier_UC1.Name = "supplier_UC1";
            this.supplier_UC1.Size = new System.Drawing.Size(1454, 848);
            this.supplier_UC1.TabIndex = 6;
            this.supplier_UC1.Visible = false;
            // 
            // ControlPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1670, 1044);
            this.Controls.Add(this.supplier_UC1);
            this.Controls.Add(this.customer_UC1);
            this.Controls.Add(this.adminControl_UC1);
            this.Controls.Add(this.userProfil_UC1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mainBT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button supplierBT;
        private System.Windows.Forms.Button CustomerBT;
        private System.Windows.Forms.Button raktarBT;
        private System.Windows.Forms.Panel panelSlide;
        public System.Windows.Forms.Label adminLL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeBT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox userProfilePic;
        private System.Windows.Forms.Button userProfilBT;
        private System.Windows.Forms.Button kijelentkezBT;
        private System.Windows.Forms.Button ExitBT;
        private System.Windows.Forms.Panel panelSlide2;
        private System.Windows.Forms.Button maxBT;
        private System.Windows.Forms.Button minBT;
        private UserControls.UserProfil_UC userProfil_UC1;
        private UserControls.AdminControl_UC adminControl_UC1;
        private System.Windows.Forms.Button adminBT;
        private System.Windows.Forms.Button ordersBT;
        private UserControls.Customer_UC customer_UC1;
        private UserControls.Supplier_UC supplier_UC1;
    }
}