namespace Asztali_alkalmazas.UI.UserControls
{
    partial class Customer_UC
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
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersDGV = new System.Windows.Forms.DataGridView();
            this.customerPhone = new System.Windows.Forms.TextBox();
            this.customerFNTB = new System.Windows.Forms.TextBox();
            this.customerLNTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerUpdateBT = new System.Windows.Forms.Button();
            this.customerNewBT = new System.Windows.Forms.Button();
            this.customerDeleteBT = new System.Windows.Forms.Button();
            this.getCustomerOrderBT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerDGVReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akashi_hun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Vásárlók adatai:";
            // 
            // CustomersDGV
            // 
            this.CustomersDGV.AllowUserToAddRows = false;
            this.CustomersDGV.AllowUserToDeleteRows = false;
            this.CustomersDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDGV.Location = new System.Drawing.Point(0, 455);
            this.CustomersDGV.Name = "CustomersDGV";
            this.CustomersDGV.ReadOnly = true;
            this.CustomersDGV.Size = new System.Drawing.Size(1454, 393);
            this.CustomersDGV.TabIndex = 20;
            this.CustomersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersDGV_CellClick);
            // 
            // customerPhone
            // 
            this.customerPhone.Location = new System.Drawing.Point(1046, 145);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(194, 20);
            this.customerPhone.TabIndex = 3;
            this.customerPhone.Leave += new System.EventHandler(this.customerPhone_Leave);
            // 
            // customerFNTB
            // 
            this.customerFNTB.Location = new System.Drawing.Point(670, 145);
            this.customerFNTB.Name = "customerFNTB";
            this.customerFNTB.Size = new System.Drawing.Size(194, 20);
            this.customerFNTB.TabIndex = 2;
            this.customerFNTB.Leave += new System.EventHandler(this.customerFNTB_Leave);
            // 
            // customerLNTB
            // 
            this.customerLNTB.Location = new System.Drawing.Point(277, 145);
            this.customerLNTB.Name = "customerLNTB";
            this.customerLNTB.Size = new System.Drawing.Size(194, 20);
            this.customerLNTB.TabIndex = 1;
            this.customerLNTB.Leave += new System.EventHandler(this.customerLNTB_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(983, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mobilszám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(594, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Keresztnév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(202, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Vezetéknév:";
            // 
            // customerUpdateBT
            // 
            this.customerUpdateBT.Enabled = false;
            this.customerUpdateBT.Font = new System.Drawing.Font("Akashi_hun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerUpdateBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerUpdateBT.Location = new System.Drawing.Point(541, 314);
            this.customerUpdateBT.Name = "customerUpdateBT";
            this.customerUpdateBT.Size = new System.Drawing.Size(229, 38);
            this.customerUpdateBT.TabIndex = 5;
            this.customerUpdateBT.Text = "Szerkeztés";
            this.customerUpdateBT.UseVisualStyleBackColor = true;
            this.customerUpdateBT.Click += new System.EventHandler(this.customerUpdateBT_Click);
            // 
            // customerNewBT
            // 
            this.customerNewBT.Font = new System.Drawing.Font("Akashi_hun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNewBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerNewBT.Location = new System.Drawing.Point(73, 314);
            this.customerNewBT.Name = "customerNewBT";
            this.customerNewBT.Size = new System.Drawing.Size(229, 38);
            this.customerNewBT.TabIndex = 4;
            this.customerNewBT.Text = "Új";
            this.customerNewBT.UseVisualStyleBackColor = true;
            this.customerNewBT.Click += new System.EventHandler(this.customerNewBT_Click);
            // 
            // customerDeleteBT
            // 
            this.customerDeleteBT.Font = new System.Drawing.Font("Akashi_hun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDeleteBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerDeleteBT.Location = new System.Drawing.Point(1022, 314);
            this.customerDeleteBT.Name = "customerDeleteBT";
            this.customerDeleteBT.Size = new System.Drawing.Size(229, 38);
            this.customerDeleteBT.TabIndex = 6;
            this.customerDeleteBT.Text = "Törlés";
            this.customerDeleteBT.UseVisualStyleBackColor = true;
            this.customerDeleteBT.Click += new System.EventHandler(this.customerDeleteBT_Click);
            // 
            // getCustomerOrderBT
            // 
            this.getCustomerOrderBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getCustomerOrderBT.Enabled = false;
            this.getCustomerOrderBT.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCustomerOrderBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getCustomerOrderBT.Location = new System.Drawing.Point(942, 23);
            this.getCustomerOrderBT.Name = "getCustomerOrderBT";
            this.getCustomerOrderBT.Size = new System.Drawing.Size(499, 38);
            this.getCustomerOrderBT.TabIndex = 8;
            this.getCustomerOrderBT.Text = "Kijelölt vásárló vásárlási előzményének megjelenítése";
            this.getCustomerOrderBT.UseVisualStyleBackColor = true;
            this.getCustomerOrderBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1254, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Adatbázis újratöltése:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(1112, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Formátum:+36 xx xxx xxxx";
            // 
            // customerDGVReload
            // 
            this.customerDGVReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDGVReload.BackgroundImage = global::Asztali_alkalmazas.Properties.Resources.icons8_reset_50px_1;
            this.customerDGVReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customerDGVReload.FlatAppearance.BorderSize = 0;
            this.customerDGVReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerDGVReload.Location = new System.Drawing.Point(1408, 412);
            this.customerDGVReload.Name = "customerDGVReload";
            this.customerDGVReload.Size = new System.Drawing.Size(33, 28);
            this.customerDGVReload.TabIndex = 7;
            this.customerDGVReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customerDGVReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.customerDGVReload.UseVisualStyleBackColor = true;
            this.customerDGVReload.Click += new System.EventHandler(this.customerDGVReload_Click);
            // 
            // Customer_UC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerDGVReload);
            this.Controls.Add(this.getCustomerOrderBT);
            this.Controls.Add(this.customerDeleteBT);
            this.Controls.Add(this.customerNewBT);
            this.Controls.Add(this.customerUpdateBT);
            this.Controls.Add(this.customerPhone);
            this.Controls.Add(this.customerFNTB);
            this.Controls.Add(this.customerLNTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomersDGV);
            this.Controls.Add(this.label1);
            this.Name = "Customer_UC";
            this.Size = new System.Drawing.Size(1454, 848);
            this.Load += new System.EventHandler(this.Customer_UC_Load);
            this.Leave += new System.EventHandler(this.Customer_UC_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustomersDGV;
        private System.Windows.Forms.TextBox customerPhone;
        private System.Windows.Forms.TextBox customerFNTB;
        private System.Windows.Forms.TextBox customerLNTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button customerUpdateBT;
        private System.Windows.Forms.Button customerNewBT;
        private System.Windows.Forms.Button customerDeleteBT;
        private System.Windows.Forms.Button getCustomerOrderBT;
        private System.Windows.Forms.Button customerDGVReload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
