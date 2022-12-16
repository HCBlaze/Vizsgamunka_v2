namespace Asztali_alkalmazas.UI.UserControls
{
    partial class Order_UC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.selectedDateOrdersDGV = new System.Windows.Forms.DataGridView();
            this.orderStartDate = new System.Windows.Forms.DateTimePicker();
            this.orderEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedOrderDetailsGB = new System.Windows.Forms.GroupBox();
            this.labelOrderStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelOrderCustomerName = new System.Windows.Forms.Label();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.selectedOrderProductsDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.generateInvoice = new System.Windows.Forms.Button();
            this.ordersStatusCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectedDateOrdersDGV)).BeginInit();
            this.selectedOrderDetailsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedOrderProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedDateOrdersDGV
            // 
            this.selectedDateOrdersDGV.AllowUserToAddRows = false;
            this.selectedDateOrdersDGV.AllowUserToDeleteRows = false;
            this.selectedDateOrdersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectedDateOrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedDateOrdersDGV.Location = new System.Drawing.Point(16, 361);
            this.selectedDateOrdersDGV.Name = "selectedDateOrdersDGV";
            this.selectedDateOrdersDGV.ReadOnly = true;
            this.selectedDateOrdersDGV.Size = new System.Drawing.Size(1416, 475);
            this.selectedDateOrdersDGV.TabIndex = 0;
            this.selectedDateOrdersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedDateOrdersDGV_CellClick);
            // 
            // orderStartDate
            // 
            this.orderStartDate.CustomFormat = "yyyy.MM.dd";
            this.orderStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderStartDate.Location = new System.Drawing.Point(643, 14);
            this.orderStartDate.Name = "orderStartDate";
            this.orderStartDate.Size = new System.Drawing.Size(108, 20);
            this.orderStartDate.TabIndex = 1;
            this.orderStartDate.ValueChanged += new System.EventHandler(this.orderStartDate_ValueChanged);
            // 
            // orderEndDate
            // 
            this.orderEndDate.CustomFormat = "yyyy.MM.dd";
            this.orderEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderEndDate.Location = new System.Drawing.Point(801, 14);
            this.orderEndDate.Name = "orderEndDate";
            this.orderEndDate.Size = new System.Drawing.Size(108, 20);
            this.orderEndDate.TabIndex = 2;
            this.orderEndDate.ValueChanged += new System.EventHandler(this.orderEndDate_ValueChanged);
            // 
            // labelStartDate
            // 
            this.labelStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStartDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStartDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelStartDate.Location = new System.Drawing.Point(643, 13);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(108, 26);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "2022.12.13";
            this.labelStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStartDate.Click += new System.EventHandler(this.labelStartDate_Click);
            // 
            // labelEndDate
            // 
            this.labelEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEndDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEndDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelEndDate.Location = new System.Drawing.Point(801, 13);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(108, 26);
            this.labelEndDate.TabIndex = 4;
            this.labelEndDate.Text = "2022.12.13";
            this.labelEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEndDate.Click += new System.EventHandler(this.labelEndDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(765, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rendelések:";
            // 
            // selectedOrderDetailsGB
            // 
            this.selectedOrderDetailsGB.Controls.Add(this.labelOrderStatus);
            this.selectedOrderDetailsGB.Controls.Add(this.label9);
            this.selectedOrderDetailsGB.Controls.Add(this.labelTotalAmount);
            this.selectedOrderDetailsGB.Controls.Add(this.labelOrderCustomerName);
            this.selectedOrderDetailsGB.Controls.Add(this.labelOrderNumber);
            this.selectedOrderDetailsGB.Controls.Add(this.labelOrderDate);
            this.selectedOrderDetailsGB.Controls.Add(this.selectedOrderProductsDGV);
            this.selectedOrderDetailsGB.Controls.Add(this.label6);
            this.selectedOrderDetailsGB.Controls.Add(this.label5);
            this.selectedOrderDetailsGB.Controls.Add(this.label4);
            this.selectedOrderDetailsGB.Controls.Add(this.label3);
            this.selectedOrderDetailsGB.Controls.Add(this.label22);
            this.selectedOrderDetailsGB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedOrderDetailsGB.ForeColor = System.Drawing.Color.Orange;
            this.selectedOrderDetailsGB.Location = new System.Drawing.Point(16, 71);
            this.selectedOrderDetailsGB.Name = "selectedOrderDetailsGB";
            this.selectedOrderDetailsGB.Size = new System.Drawing.Size(1416, 268);
            this.selectedOrderDetailsGB.TabIndex = 8;
            this.selectedOrderDetailsGB.TabStop = false;
            this.selectedOrderDetailsGB.Text = "Kiválasztott rendelés adatai:";
            this.selectedOrderDetailsGB.Visible = false;
            // 
            // labelOrderStatus
            // 
            this.labelOrderStatus.AutoSize = true;
            this.labelOrderStatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOrderStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelOrderStatus.Location = new System.Drawing.Point(808, 186);
            this.labelOrderStatus.Name = "labelOrderStatus";
            this.labelOrderStatus.Size = new System.Drawing.Size(69, 23);
            this.labelOrderStatus.TabIndex = 11;
            this.labelOrderStatus.Text = "label7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(783, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Rendelés státusza:";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTotalAmount.Location = new System.Drawing.Point(595, 214);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(69, 23);
            this.labelTotalAmount.TabIndex = 9;
            this.labelTotalAmount.Text = "label7";
            // 
            // labelOrderCustomerName
            // 
            this.labelOrderCustomerName.AutoSize = true;
            this.labelOrderCustomerName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOrderCustomerName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelOrderCustomerName.Location = new System.Drawing.Point(595, 114);
            this.labelOrderCustomerName.Name = "labelOrderCustomerName";
            this.labelOrderCustomerName.Size = new System.Drawing.Size(69, 23);
            this.labelOrderCustomerName.TabIndex = 8;
            this.labelOrderCustomerName.Text = "label7";
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOrderNumber.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelOrderNumber.Location = new System.Drawing.Point(127, 214);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(69, 23);
            this.labelOrderNumber.TabIndex = 7;
            this.labelOrderNumber.Text = "label7";
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOrderDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelOrderDate.Location = new System.Drawing.Point(121, 114);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(69, 23);
            this.labelOrderDate.TabIndex = 6;
            this.labelOrderDate.Text = "label7";
            // 
            // selectedOrderProductsDGV
            // 
            this.selectedOrderProductsDGV.AllowUserToAddRows = false;
            this.selectedOrderProductsDGV.AllowUserToDeleteRows = false;
            this.selectedOrderProductsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedOrderProductsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selectedOrderProductsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.selectedOrderProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedOrderProductsDGV.Location = new System.Drawing.Point(984, 77);
            this.selectedOrderProductsDGV.Name = "selectedOrderProductsDGV";
            this.selectedOrderProductsDGV.ReadOnly = true;
            this.selectedOrderProductsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedOrderProductsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.selectedOrderProductsDGV.Size = new System.Drawing.Size(412, 160);
            this.selectedOrderProductsDGV.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(1091, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Megvásárolt termékek:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(590, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Végösszeg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(590, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vásárló neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(93, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rendelés azonosító:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(93, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(123, 18);
            this.label22.TabIndex = 0;
            this.label22.Text = "Rendelés ideje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(240, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(383, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Add meg milyen intervallumban keresel rendelést:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Asztali_alkalmazas.Properties.Resources.icons8_Checkmark_50px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(928, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 31);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateInvoice
            // 
            this.generateInvoice.FlatAppearance.BorderSize = 0;
            this.generateInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.generateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateInvoice.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateInvoice.ForeColor = System.Drawing.Color.Orange;
            this.generateInvoice.Location = new System.Drawing.Point(1214, 14);
            this.generateInvoice.Name = "generateInvoice";
            this.generateInvoice.Size = new System.Drawing.Size(198, 32);
            this.generateInvoice.TabIndex = 11;
            this.generateInvoice.Text = "Számla készítése";
            this.generateInvoice.UseVisualStyleBackColor = true;
            this.generateInvoice.Click += new System.EventHandler(this.generateInvoice_Click);
            // 
            // ordersStatusCB
            // 
            this.ordersStatusCB.FormattingEnabled = true;
            this.ordersStatusCB.Items.AddRange(new object[] {
            "Új",
            "Folyamatban",
            "Kész"});
            this.ordersStatusCB.Location = new System.Drawing.Point(392, 50);
            this.ordersStatusCB.Name = "ordersStatusCB";
            this.ordersStatusCB.Size = new System.Drawing.Size(142, 21);
            this.ordersStatusCB.TabIndex = 12;
            this.ordersStatusCB.SelectedIndexChanged += new System.EventHandler(this.ordersStatusCB_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(240, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rendelés státusza:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Asztali_alkalmazas.Properties.Resources.icons8_Checkmark_50px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(540, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 31);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Orange;
            this.button3.Location = new System.Drawing.Point(1000, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "Összes rendelés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Order_UC
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ordersStatusCB);
            this.Controls.Add(this.generateInvoice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectedOrderDetailsGB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.orderEndDate);
            this.Controls.Add(this.orderStartDate);
            this.Controls.Add(this.selectedDateOrdersDGV);
            this.Name = "Order_UC";
            this.Size = new System.Drawing.Size(1454, 848);
            this.Load += new System.EventHandler(this.Order_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectedDateOrdersDGV)).EndInit();
            this.selectedOrderDetailsGB.ResumeLayout(false);
            this.selectedOrderDetailsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedOrderProductsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView selectedDateOrdersDGV;
        private System.Windows.Forms.DateTimePicker orderStartDate;
        private System.Windows.Forms.DateTimePicker orderEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox selectedOrderDetailsGB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.DataGridView selectedOrderProductsDGV;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelOrderCustomerName;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button generateInvoice;
        private System.Windows.Forms.Label labelOrderStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ordersStatusCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
