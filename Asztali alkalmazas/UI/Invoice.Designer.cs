namespace Asztali_alkalmazas.UI
{
    partial class Invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.panelPrint = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.invoiceCreateDate = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.invoiceTotalAmount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.invoiceDGV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.invoiceOrderNumber = new System.Windows.Forms.Label();
            this.invoiceCustomerDetailsGB = new System.Windows.Forms.GroupBox();
            this.invoiceOrderDate = new System.Windows.Forms.Label();
            this.invoiceCustomerPhone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceCustomerName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelPrint.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.invoiceCustomerDetailsGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrint
            // 
            this.panelPrint.AutoScroll = true;
            this.panelPrint.Controls.Add(this.panel2);
            this.panelPrint.Controls.Add(this.invoiceCustomerDetailsGB);
            this.panelPrint.Controls.Add(this.groupBox2);
            this.panelPrint.Controls.Add(this.panel1);
            this.panelPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrint.Location = new System.Drawing.Point(0, 0);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(821, 1055);
            this.panelPrint.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.labelDiscount);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.invoiceCreateDate);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.invoiceTotalAmount);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.invoiceDGV);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 728);
            this.panel2.TabIndex = 8;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDiscount.Location = new System.Drawing.Point(210, 616);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(63, 23);
            this.labelDiscount.TabIndex = 16;
            this.labelDiscount.Text = "akció";
            this.labelDiscount.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(2, 616);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(252, 23);
            this.label15.TabIndex = 15;
            this.label15.Text = "Levonások összesen (HUF):";
            // 
            // invoiceCreateDate
            // 
            this.invoiceCreateDate.AutoSize = true;
            this.invoiceCreateDate.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.invoiceCreateDate.Location = new System.Drawing.Point(212, 705);
            this.invoiceCreateDate.Name = "invoiceCreateDate";
            this.invoiceCreateDate.Size = new System.Drawing.Size(175, 23);
            this.invoiceCreateDate.TabIndex = 14;
            this.invoiceCreateDate.Text = "számlagenerálás";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(2, 705);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(259, 23);
            this.label16.TabIndex = 13;
            this.label16.Text = "Számla kiállításának ideje:";
            // 
            // invoiceTotalAmount
            // 
            this.invoiceTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.invoiceTotalAmount.AutoSize = true;
            this.invoiceTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.invoiceTotalAmount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.invoiceTotalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.invoiceTotalAmount.Location = new System.Drawing.Point(489, 662);
            this.invoiceTotalAmount.Name = "invoiceTotalAmount";
            this.invoiceTotalAmount.Size = new System.Drawing.Size(171, 37);
            this.invoiceTotalAmount.TabIndex = 3;
            this.invoiceTotalAmount.Text = "végosszeg";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(155, 662);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(409, 37);
            this.label14.TabIndex = 2;
            this.label14.Text = "Fizetendő végösszeg (HUF):";
            // 
            // invoiceDGV
            // 
            this.invoiceDGV.AllowUserToAddRows = false;
            this.invoiceDGV.AllowUserToDeleteRows = false;
            this.invoiceDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.invoiceDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.invoiceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDGV.Location = new System.Drawing.Point(0, 48);
            this.invoiceDGV.Name = "invoiceDGV";
            this.invoiceDGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.invoiceDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.invoiceDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.invoiceDGV.Size = new System.Drawing.Size(821, 543);
            this.invoiceDGV.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.invoiceOrderNumber);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(821, 42);
            this.panel3.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(15, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(350, 33);
            this.label13.TabIndex = 1;
            this.label13.Text = "Megrendelés azonosítója:";
            // 
            // invoiceOrderNumber
            // 
            this.invoiceOrderNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.invoiceOrderNumber.AutoSize = true;
            this.invoiceOrderNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.invoiceOrderNumber.Location = new System.Drawing.Point(293, 12);
            this.invoiceOrderNumber.Name = "invoiceOrderNumber";
            this.invoiceOrderNumber.Size = new System.Drawing.Size(185, 23);
            this.invoiceOrderNumber.TabIndex = 0;
            this.invoiceOrderNumber.Text = "megrendelesazon";
            // 
            // invoiceCustomerDetailsGB
            // 
            this.invoiceCustomerDetailsGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceCustomerDetailsGB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.invoiceCustomerDetailsGB.Controls.Add(this.invoiceOrderDate);
            this.invoiceCustomerDetailsGB.Controls.Add(this.invoiceCustomerPhone);
            this.invoiceCustomerDetailsGB.Controls.Add(this.label2);
            this.invoiceCustomerDetailsGB.Controls.Add(this.invoiceCustomerName);
            this.invoiceCustomerDetailsGB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.invoiceCustomerDetailsGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.invoiceCustomerDetailsGB.Location = new System.Drawing.Point(497, 148);
            this.invoiceCustomerDetailsGB.Name = "invoiceCustomerDetailsGB";
            this.invoiceCustomerDetailsGB.Size = new System.Drawing.Size(286, 163);
            this.invoiceCustomerDetailsGB.TabIndex = 6;
            this.invoiceCustomerDetailsGB.TabStop = false;
            this.invoiceCustomerDetailsGB.Text = "Vevő:";
            // 
            // invoiceOrderDate
            // 
            this.invoiceOrderDate.AutoSize = true;
            this.invoiceOrderDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.invoiceOrderDate.Location = new System.Drawing.Point(24, 115);
            this.invoiceOrderDate.Name = "invoiceOrderDate";
            this.invoiceOrderDate.Size = new System.Drawing.Size(163, 23);
            this.invoiceOrderDate.TabIndex = 3;
            this.invoiceOrderDate.Text = "rendelesdatuma";
            // 
            // invoiceCustomerPhone
            // 
            this.invoiceCustomerPhone.AutoSize = true;
            this.invoiceCustomerPhone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.invoiceCustomerPhone.Location = new System.Drawing.Point(24, 79);
            this.invoiceCustomerPhone.Name = "invoiceCustomerPhone";
            this.invoiceCustomerPhone.Size = new System.Drawing.Size(167, 23);
            this.invoiceCustomerPhone.TabIndex = 2;
            this.invoiceCustomerPhone.Text = "vevotelefonszam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 1;
            // 
            // invoiceCustomerName
            // 
            this.invoiceCustomerName.AutoSize = true;
            this.invoiceCustomerName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.invoiceCustomerName.Location = new System.Drawing.Point(24, 41);
            this.invoiceCustomerName.Name = "invoiceCustomerName";
            this.invoiceCustomerName.Size = new System.Drawing.Size(90, 23);
            this.invoiceCustomerName.TabIndex = 0;
            this.invoiceCustomerName.Text = "vevonev";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(0, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 186);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eladó:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(72, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(338, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "HU81 1091 800x 0000 0xxx 11111111";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(112, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 22);
            this.label11.TabIndex = 11;
            this.label11.Text = "1091800x-00000xxx-11111111";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(15, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "IBAN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(15, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bankszámla:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(101, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "OTP Bank Zrt.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(16, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bank:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(101, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "10795374-x-xx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(16, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adószám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "9791 Torony, Kiss u. 99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Project23 KFT.";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 101);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Orange;
            this.pictureBox2.Image = global::Asztali_alkalmazas.Properties.Resources.project_23;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Asztali_alkalmazas.Properties.Resources.icons8_print_50px_1;
            this.pictureBox1.Location = new System.Drawing.Point(737, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Print");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(303, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Számla";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Invoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(821, 1055);
            this.Controls.Add(this.panelPrint);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.panelPrint.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.invoiceCustomerDetailsGB.ResumeLayout(false);
            this.invoiceCustomerDetailsGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label invoiceCreateDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label invoiceTotalAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView invoiceDGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label invoiceOrderNumber;
        private System.Windows.Forms.GroupBox invoiceCustomerDetailsGB;
        private System.Windows.Forms.Label invoiceOrderDate;
        private System.Windows.Forms.Label invoiceCustomerPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label invoiceCustomerName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelDiscount;
    }
}