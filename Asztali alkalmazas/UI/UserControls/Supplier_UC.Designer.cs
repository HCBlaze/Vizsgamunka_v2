namespace Asztali_alkalmazas.UI.UserControls
{
    partial class Supplier_UC
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
            this.suppliersDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.supplierPhoneTB = new System.Windows.Forms.TextBox();
            this.supplierContactNameTB = new System.Windows.Forms.TextBox();
            this.supplierCompanyNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.supplierCityTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.supplierDeleteBT = new System.Windows.Forms.Button();
            this.supplierNewBT = new System.Windows.Forms.Button();
            this.supplierUpdateBT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.supplierDGVReload = new System.Windows.Forms.Button();
            this.getSupplierProductsBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akashi_hun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Beszállítók adatai:";
            // 
            // suppliersDGV
            // 
            this.suppliersDGV.AllowUserToAddRows = false;
            this.suppliersDGV.AllowUserToDeleteRows = false;
            this.suppliersDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suppliersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDGV.Location = new System.Drawing.Point(0, 455);
            this.suppliersDGV.Name = "suppliersDGV";
            this.suppliersDGV.ReadOnly = true;
            this.suppliersDGV.RowTemplate.Height = 24;
            this.suppliersDGV.Size = new System.Drawing.Size(1454, 393);
            this.suppliersDGV.TabIndex = 21;
            this.suppliersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersDGV_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(1179, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Formátum:+36 xx xxx xxxx";
            // 
            // supplierPhoneTB
            // 
            this.supplierPhoneTB.Location = new System.Drawing.Point(1113, 139);
            this.supplierPhoneTB.Name = "supplierPhoneTB";
            this.supplierPhoneTB.Size = new System.Drawing.Size(194, 20);
            this.supplierPhoneTB.TabIndex = 4;
            this.supplierPhoneTB.Leave += new System.EventHandler(this.supplierPhoneTB_Leave);
            // 
            // supplierContactNameTB
            // 
            this.supplierContactNameTB.Location = new System.Drawing.Point(420, 139);
            this.supplierContactNameTB.Name = "supplierContactNameTB";
            this.supplierContactNameTB.Size = new System.Drawing.Size(194, 20);
            this.supplierContactNameTB.TabIndex = 2;
            this.supplierContactNameTB.Leave += new System.EventHandler(this.supplierContactNameTB_Leave);
            // 
            // supplierCompanyNameTB
            // 
            this.supplierCompanyNameTB.Location = new System.Drawing.Point(93, 139);
            this.supplierCompanyNameTB.Name = "supplierCompanyNameTB";
            this.supplierCompanyNameTB.Size = new System.Drawing.Size(194, 20);
            this.supplierCompanyNameTB.TabIndex = 1;
            this.supplierCompanyNameTB.Leave += new System.EventHandler(this.supplierCompanyNameTB_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1050, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mobilszám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(344, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Kapcsolattartó neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cégnéve:";
            // 
            // supplierCityTB
            // 
            this.supplierCityTB.Location = new System.Drawing.Point(769, 139);
            this.supplierCityTB.Name = "supplierCityTB";
            this.supplierCityTB.Size = new System.Drawing.Size(194, 20);
            this.supplierCityTB.TabIndex = 3;
            this.supplierCityTB.Leave += new System.EventHandler(this.supplierCityTB_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(693, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Város:";
            // 
            // supplierDeleteBT
            // 
            this.supplierDeleteBT.Font = new System.Drawing.Font("Akashi_hun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierDeleteBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supplierDeleteBT.Location = new System.Drawing.Point(1063, 317);
            this.supplierDeleteBT.Name = "supplierDeleteBT";
            this.supplierDeleteBT.Size = new System.Drawing.Size(229, 38);
            this.supplierDeleteBT.TabIndex = 7;
            this.supplierDeleteBT.Text = "Törlés";
            this.supplierDeleteBT.UseVisualStyleBackColor = true;
            this.supplierDeleteBT.Click += new System.EventHandler(this.supplierDeleteBT_Click);
            // 
            // supplierNewBT
            // 
            this.supplierNewBT.Font = new System.Drawing.Font("Akashi_hun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierNewBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supplierNewBT.Location = new System.Drawing.Point(114, 317);
            this.supplierNewBT.Name = "supplierNewBT";
            this.supplierNewBT.Size = new System.Drawing.Size(229, 38);
            this.supplierNewBT.TabIndex = 5;
            this.supplierNewBT.Text = "Új";
            this.supplierNewBT.UseVisualStyleBackColor = true;
            this.supplierNewBT.Click += new System.EventHandler(this.supplierNewBT_Click);
            // 
            // supplierUpdateBT
            // 
            this.supplierUpdateBT.Enabled = false;
            this.supplierUpdateBT.Font = new System.Drawing.Font("Akashi_hun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierUpdateBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supplierUpdateBT.Location = new System.Drawing.Point(582, 317);
            this.supplierUpdateBT.Name = "supplierUpdateBT";
            this.supplierUpdateBT.Size = new System.Drawing.Size(229, 38);
            this.supplierUpdateBT.TabIndex = 6;
            this.supplierUpdateBT.Text = "Szerkeztés";
            this.supplierUpdateBT.UseVisualStyleBackColor = true;
            this.supplierUpdateBT.Click += new System.EventHandler(this.supplierUpdateBT_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1262, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Adatbázis újratöltése:";
            // 
            // supplierDGVReload
            // 
            this.supplierDGVReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierDGVReload.BackgroundImage = global::Asztali_alkalmazas.Properties.Resources.icons8_reset_50px_1;
            this.supplierDGVReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.supplierDGVReload.FlatAppearance.BorderSize = 0;
            this.supplierDGVReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierDGVReload.Location = new System.Drawing.Point(1416, 422);
            this.supplierDGVReload.Name = "supplierDGVReload";
            this.supplierDGVReload.Size = new System.Drawing.Size(33, 28);
            this.supplierDGVReload.TabIndex = 8;
            this.supplierDGVReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.supplierDGVReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.supplierDGVReload.UseVisualStyleBackColor = true;
            this.supplierDGVReload.Click += new System.EventHandler(this.supplierDGVReload_Click);
            // 
            // getSupplierProductsBT
            // 
            this.getSupplierProductsBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getSupplierProductsBT.Enabled = false;
            this.getSupplierProductsBT.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSupplierProductsBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getSupplierProductsBT.Location = new System.Drawing.Point(951, 5);
            this.getSupplierProductsBT.Name = "getSupplierProductsBT";
            this.getSupplierProductsBT.Size = new System.Drawing.Size(499, 38);
            this.getSupplierProductsBT.TabIndex = 9;
            this.getSupplierProductsBT.Text = "Kijelölt beszállító árucikkjének megjelenítése";
            this.getSupplierProductsBT.UseVisualStyleBackColor = true;
            this.getSupplierProductsBT.Click += new System.EventHandler(this.getSupplierProductsBT_Click);
            // 
            // Supplier_UC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.getSupplierProductsBT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.supplierDGVReload);
            this.Controls.Add(this.supplierDeleteBT);
            this.Controls.Add(this.supplierNewBT);
            this.Controls.Add(this.supplierUpdateBT);
            this.Controls.Add(this.supplierCityTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.supplierPhoneTB);
            this.Controls.Add(this.supplierContactNameTB);
            this.Controls.Add(this.supplierCompanyNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.suppliersDGV);
            this.Controls.Add(this.label1);
            this.Name = "Supplier_UC";
            this.Size = new System.Drawing.Size(1454, 848);
            this.Load += new System.EventHandler(this.Supplier_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView suppliersDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox supplierPhoneTB;
        private System.Windows.Forms.TextBox supplierContactNameTB;
        private System.Windows.Forms.TextBox supplierCompanyNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supplierCityTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button supplierDeleteBT;
        private System.Windows.Forms.Button supplierNewBT;
        private System.Windows.Forms.Button supplierUpdateBT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button supplierDGVReload;
        private System.Windows.Forms.Button getSupplierProductsBT;
    }
}
