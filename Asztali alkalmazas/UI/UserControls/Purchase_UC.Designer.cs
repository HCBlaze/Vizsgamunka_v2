namespace Asztali_alkalmazas.UI.UserControls
{
    partial class Purchase_UC
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCart = new System.Windows.Forms.GroupBox();
            this.gbCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mennyisegNum = new System.Windows.Forms.NumericUpDown();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnDeleteCartItem = new System.Windows.Forms.Button();
            this.btnPurchaseFinish = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblcurrentProdStock = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbCart.SuspendLayout();
            this.gbCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vásárlás:";
            // 
            // gbCart
            // 
            this.gbCart.Controls.Add(this.gbCustomerDetails);
            this.gbCart.Controls.Add(this.lblTotalAmount);
            this.gbCart.Controls.Add(this.label5);
            this.gbCart.Controls.Add(this.dgvOrderItems);
            this.gbCart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbCart.Location = new System.Drawing.Point(732, 19);
            this.gbCart.Name = "gbCart";
            this.gbCart.Size = new System.Drawing.Size(645, 826);
            this.gbCart.TabIndex = 9;
            this.gbCart.TabStop = false;
            this.gbCart.Text = "Kosár:";
            this.gbCart.Visible = false;
            // 
            // gbCustomerDetails
            // 
            this.gbCustomerDetails.Controls.Add(this.lblPhoneNumber);
            this.gbCustomerDetails.Controls.Add(this.label9);
            this.gbCustomerDetails.Controls.Add(this.lblFullName);
            this.gbCustomerDetails.Controls.Add(this.label6);
            this.gbCustomerDetails.Location = new System.Drawing.Point(31, 49);
            this.gbCustomerDetails.Name = "gbCustomerDetails";
            this.gbCustomerDetails.Size = new System.Drawing.Size(571, 188);
            this.gbCustomerDetails.TabIndex = 18;
            this.gbCustomerDetails.TabStop = false;
            this.gbCustomerDetails.Text = "Vásárló adatai:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(225, 110);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(54, 18);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "label7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(130, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mobilszám:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFullName.Location = new System.Drawing.Point(173, 58);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 18);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(130, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Név:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Silver;
            this.lblTotalAmount.Location = new System.Drawing.Point(220, 709);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 30);
            this.lblTotalAmount.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(89, 709);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Összesen:";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AllowUserToDeleteRows = false;
            this.dgvOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderItems.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvOrderItems.Location = new System.Drawing.Point(31, 292);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.ReadOnly = true;
            this.dgvOrderItems.RowHeadersWidth = 51;
            this.dgvOrderItems.RowTemplate.Height = 24;
            this.dgvOrderItems.Size = new System.Drawing.Size(571, 347);
            this.dgvOrderItems.TabIndex = 0;
            this.dgvOrderItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderItems_CellClick);
            // 
            // cbCustomers
            // 
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(31, 161);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(357, 35);
            this.cbCustomers.TabIndex = 1;
            this.cbCustomers.SelectedIndexChanged += new System.EventHandler(this.cbCustomers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vásárló választása:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(16, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Termék választása:";
            this.label3.Visible = false;
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(31, 349);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(357, 35);
            this.cbProducts.TabIndex = 2;
            this.cbProducts.Visible = false;
            this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.cbProducts_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(430, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mennyiség:";
            this.label4.Visible = false;
            // 
            // mennyisegNum
            // 
            this.mennyisegNum.Enabled = false;
            this.mennyisegNum.Location = new System.Drawing.Point(435, 349);
            this.mennyisegNum.Name = "mennyisegNum";
            this.mennyisegNum.Size = new System.Drawing.Size(120, 34);
            this.mennyisegNum.TabIndex = 3;
            this.toolTip1.SetToolTip(this.mennyisegNum, "Ha többet írsz be mint a max mennyiség autómatikusan az összes készleten lévő ter" +
        "méket megkapod");
            this.mennyisegNum.Visible = false;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnAddCart.Location = new System.Drawing.Point(123, 647);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(479, 66);
            this.btnAddCart.TabIndex = 4;
            this.btnAddCart.Text = "Kosárba";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Visible = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnDeleteCartItem
            // 
            this.btnDeleteCartItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteCartItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnDeleteCartItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCartItem.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteCartItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnDeleteCartItem.Location = new System.Drawing.Point(31, 713);
            this.btnDeleteCartItem.Name = "btnDeleteCartItem";
            this.btnDeleteCartItem.Size = new System.Drawing.Size(673, 66);
            this.btnDeleteCartItem.TabIndex = 5;
            this.btnDeleteCartItem.Text = "Törlés a kosárból";
            this.btnDeleteCartItem.UseVisualStyleBackColor = true;
            this.btnDeleteCartItem.Visible = false;
            this.btnDeleteCartItem.Click += new System.EventHandler(this.btnDeleteCartItem_Click);
            // 
            // btnPurchaseFinish
            // 
            this.btnPurchaseFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPurchaseFinish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnPurchaseFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseFinish.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPurchaseFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnPurchaseFinish.Location = new System.Drawing.Point(3, 779);
            this.btnPurchaseFinish.Name = "btnPurchaseFinish";
            this.btnPurchaseFinish.Size = new System.Drawing.Size(723, 66);
            this.btnPurchaseFinish.TabIndex = 6;
            this.btnPurchaseFinish.Text = "Rendelés leadása";
            this.btnPurchaseFinish.UseVisualStyleBackColor = true;
            this.btnPurchaseFinish.Visible = false;
            this.btnPurchaseFinish.Click += new System.EventHandler(this.btnPurchaseFinish_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(435, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 27);
            this.label7.TabIndex = 22;
            this.label7.Text = "Max:";
            this.label7.Visible = false;
            // 
            // lblcurrentProdStock
            // 
            this.lblcurrentProdStock.AutoSize = true;
            this.lblcurrentProdStock.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblcurrentProdStock.ForeColor = System.Drawing.Color.Silver;
            this.lblcurrentProdStock.Location = new System.Drawing.Point(494, 317);
            this.lblcurrentProdStock.Name = "lblcurrentProdStock";
            this.lblcurrentProdStock.Size = new System.Drawing.Size(59, 23);
            this.lblcurrentProdStock.TabIndex = 19;
            this.lblcurrentProdStock.Text = "stock";
            this.lblcurrentProdStock.Visible = false;
            // 
            // Purchase_UC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.lblcurrentProdStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPurchaseFinish);
            this.Controls.Add(this.btnDeleteCartItem);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.mennyisegNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCustomers);
            this.Controls.Add(this.gbCart);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Purchase_UC";
            this.Size = new System.Drawing.Size(1454, 858);
            this.Load += new System.EventHandler(this.Purchase_UC_Load);
            this.gbCart.ResumeLayout(false);
            this.gbCart.PerformLayout();
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCart;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.ComboBox cbCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown mennyisegNum;
        private System.Windows.Forms.GroupBox gbCustomerDetails;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnDeleteCartItem;
        private System.Windows.Forms.Button btnPurchaseFinish;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblcurrentProdStock;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
