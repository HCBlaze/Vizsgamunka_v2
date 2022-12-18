namespace Asztali_alkalmazas.UI.UserControls
{
    partial class Prodcut_UC
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.newProduct = new System.Windows.Forms.TabPage();
            this.productDetailsGB = new System.Windows.Forms.GroupBox();
            this.newProductBT = new System.Windows.Forms.Button();
            this.productSupplierIdLL = new System.Windows.Forms.Label();
            this.productStockTB = new System.Windows.Forms.TextBox();
            this.productUnitPriceTB = new System.Windows.Forms.TextBox();
            this.productPackageTB = new System.Windows.Forms.TextBox();
            this.productNameTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.suppliersCB = new System.Windows.Forms.ComboBox();
            this.updateProdcutOrDelete = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.productUpdateDGVReload = new System.Windows.Forms.Button();
            this.productDeleteBT = new System.Windows.Forms.Button();
            this.productUpdateBT = new System.Windows.Forms.Button();
            this.productUpdateGB = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.productUpdateStock = new System.Windows.Forms.TextBox();
            this.productUpdatePackage = new System.Windows.Forms.TextBox();
            this.productUpdatePrice = new System.Windows.Forms.TextBox();
            this.productUpdateName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.productUpdateNDeleteDGV = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.orderStock = new System.Windows.Forms.TabPage();
            this.selectProductSupplierId = new System.Windows.Forms.Label();
            this.suppliersDataCB = new System.Windows.Forms.GroupBox();
            this.supplierPhoneLL = new System.Windows.Forms.Label();
            this.supplierCityLL = new System.Windows.Forms.Label();
            this.supplierContactNameLL = new System.Windows.Forms.Label();
            this.supplierCompanyNameLL = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.selectedProdcutId = new System.Windows.Forms.Label();
            this.productSotckGB = new System.Windows.Forms.GroupBox();
            this.productAddOrRemoveBT = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.selectedProductStockUpdateBT = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectedProductPackage = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.selectedProductStock = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.productsCB = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.newProduct.SuspendLayout();
            this.productDetailsGB.SuspendLayout();
            this.updateProdcutOrDelete.SuspendLayout();
            this.productUpdateGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productUpdateNDeleteDGV)).BeginInit();
            this.orderStock.SuspendLayout();
            this.suppliersDataCB.SuspendLayout();
            this.productSotckGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.newProduct);
            this.tabControl1.Controls.Add(this.updateProdcutOrDelete);
            this.tabControl1.Controls.Add(this.orderStock);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1454, 848);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // newProduct
            // 
            this.newProduct.AutoScroll = true;
            this.newProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.newProduct.Controls.Add(this.productDetailsGB);
            this.newProduct.Controls.Add(this.label4);
            this.newProduct.Controls.Add(this.label2);
            this.newProduct.Controls.Add(this.label1);
            this.newProduct.Controls.Add(this.suppliersCB);
            this.newProduct.ForeColor = System.Drawing.Color.Black;
            this.newProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newProduct.Location = new System.Drawing.Point(4, 25);
            this.newProduct.Name = "newProduct";
            this.newProduct.Padding = new System.Windows.Forms.Padding(3);
            this.newProduct.Size = new System.Drawing.Size(1446, 819);
            this.newProduct.TabIndex = 0;
            this.newProduct.Text = "Új árucikk felvétele";
            // 
            // productDetailsGB
            // 
            this.productDetailsGB.Controls.Add(this.newProductBT);
            this.productDetailsGB.Controls.Add(this.productSupplierIdLL);
            this.productDetailsGB.Controls.Add(this.productStockTB);
            this.productDetailsGB.Controls.Add(this.productUnitPriceTB);
            this.productDetailsGB.Controls.Add(this.productPackageTB);
            this.productDetailsGB.Controls.Add(this.productNameTB);
            this.productDetailsGB.Controls.Add(this.label8);
            this.productDetailsGB.Controls.Add(this.label7);
            this.productDetailsGB.Controls.Add(this.label6);
            this.productDetailsGB.Controls.Add(this.label5);
            this.productDetailsGB.Controls.Add(this.label3);
            this.productDetailsGB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productDetailsGB.ForeColor = System.Drawing.Color.Orange;
            this.productDetailsGB.Location = new System.Drawing.Point(60, 253);
            this.productDetailsGB.Name = "productDetailsGB";
            this.productDetailsGB.Size = new System.Drawing.Size(1049, 411);
            this.productDetailsGB.TabIndex = 5;
            this.productDetailsGB.TabStop = false;
            this.productDetailsGB.Text = "Termék adatai:";
            this.productDetailsGB.Visible = false;
            // 
            // newProductBT
            // 
            this.newProductBT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newProductBT.FlatAppearance.BorderSize = 0;
            this.newProductBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.newProductBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProductBT.Font = new System.Drawing.Font("Akashi_hun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductBT.ForeColor = System.Drawing.Color.Orange;
            this.newProductBT.Location = new System.Drawing.Point(3, 346);
            this.newProductBT.Name = "newProductBT";
            this.newProductBT.Size = new System.Drawing.Size(1043, 62);
            this.newProductBT.TabIndex = 10;
            this.newProductBT.Text = "Termék felvétele";
            this.newProductBT.UseVisualStyleBackColor = true;
            this.newProductBT.Click += new System.EventHandler(this.newProductBT_Click);
            // 
            // productSupplierIdLL
            // 
            this.productSupplierIdLL.AutoSize = true;
            this.productSupplierIdLL.Location = new System.Drawing.Point(964, 40);
            this.productSupplierIdLL.Name = "productSupplierIdLL";
            this.productSupplierIdLL.Size = new System.Drawing.Size(62, 25);
            this.productSupplierIdLL.TabIndex = 9;
            this.productSupplierIdLL.Text = "azon";
            // 
            // productStockTB
            // 
            this.productStockTB.Location = new System.Drawing.Point(731, 262);
            this.productStockTB.Name = "productStockTB";
            this.productStockTB.Size = new System.Drawing.Size(240, 33);
            this.productStockTB.TabIndex = 8;
            this.productStockTB.Leave += new System.EventHandler(this.productStockTB_Leave);
            // 
            // productUnitPriceTB
            // 
            this.productUnitPriceTB.Location = new System.Drawing.Point(42, 262);
            this.productUnitPriceTB.Name = "productUnitPriceTB";
            this.productUnitPriceTB.Size = new System.Drawing.Size(240, 33);
            this.productUnitPriceTB.TabIndex = 7;
            this.productUnitPriceTB.Leave += new System.EventHandler(this.productUnitPriceTB_Leave);
            // 
            // productPackageTB
            // 
            this.productPackageTB.Location = new System.Drawing.Point(385, 262);
            this.productPackageTB.Name = "productPackageTB";
            this.productPackageTB.Size = new System.Drawing.Size(240, 33);
            this.productPackageTB.TabIndex = 6;
            this.productPackageTB.Leave += new System.EventHandler(this.productPackageTB_Leave);
            // 
            // productNameTB
            // 
            this.productNameTB.Location = new System.Drawing.Point(184, 97);
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.Size = new System.Drawing.Size(240, 33);
            this.productNameTB.TabIndex = 5;
            this.productNameTB.Leave += new System.EventHandler(this.productNameTB_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(802, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mennyiség:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(452, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Csomagolás:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(106, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Egység ár:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(690, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Termék beszállítójának azonosítója:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Termék megnevezése:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(580, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Új árucikk részletei:";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Válassz beszállítót:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Új árucikk felvétele:";
            // 
            // suppliersCB
            // 
            this.suppliersCB.FormattingEnabled = true;
            this.suppliersCB.Location = new System.Drawing.Point(220, 118);
            this.suppliersCB.Name = "suppliersCB";
            this.suppliersCB.Size = new System.Drawing.Size(261, 24);
            this.suppliersCB.TabIndex = 0;
            this.suppliersCB.SelectedIndexChanged += new System.EventHandler(this.suppliersCB_SelectedIndexChanged);
            // 
            // updateProdcutOrDelete
            // 
            this.updateProdcutOrDelete.AutoScroll = true;
            this.updateProdcutOrDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.updateProdcutOrDelete.Controls.Add(this.label18);
            this.updateProdcutOrDelete.Controls.Add(this.productUpdateDGVReload);
            this.updateProdcutOrDelete.Controls.Add(this.productDeleteBT);
            this.updateProdcutOrDelete.Controls.Add(this.productUpdateBT);
            this.updateProdcutOrDelete.Controls.Add(this.productUpdateGB);
            this.updateProdcutOrDelete.Controls.Add(this.label10);
            this.updateProdcutOrDelete.Controls.Add(this.productUpdateNDeleteDGV);
            this.updateProdcutOrDelete.Controls.Add(this.label9);
            this.updateProdcutOrDelete.Location = new System.Drawing.Point(4, 25);
            this.updateProdcutOrDelete.Name = "updateProdcutOrDelete";
            this.updateProdcutOrDelete.Padding = new System.Windows.Forms.Padding(3);
            this.updateProdcutOrDelete.Size = new System.Drawing.Size(1446, 819);
            this.updateProdcutOrDelete.TabIndex = 1;
            this.updateProdcutOrDelete.Text = "Árucikk adatainak szerkesztése vagy árucikk törlése";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(1251, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(149, 16);
            this.label18.TabIndex = 34;
            this.label18.Text = "Adatbázis újratöltése:";
            // 
            // productUpdateDGVReload
            // 
            this.productUpdateDGVReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productUpdateDGVReload.BackgroundImage = global::Asztali_alkalmazas.Properties.Resources.icons8_reset_50px_1;
            this.productUpdateDGVReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.productUpdateDGVReload.FlatAppearance.BorderSize = 0;
            this.productUpdateDGVReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productUpdateDGVReload.Location = new System.Drawing.Point(1405, 62);
            this.productUpdateDGVReload.Name = "productUpdateDGVReload";
            this.productUpdateDGVReload.Size = new System.Drawing.Size(33, 28);
            this.productUpdateDGVReload.TabIndex = 33;
            this.productUpdateDGVReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.productUpdateDGVReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.productUpdateDGVReload.UseVisualStyleBackColor = true;
            this.productUpdateDGVReload.Click += new System.EventHandler(this.productUpdateDGVReload_Click);
            // 
            // productDeleteBT
            // 
            this.productDeleteBT.FlatAppearance.BorderSize = 0;
            this.productDeleteBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.productDeleteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productDeleteBT.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productDeleteBT.ForeColor = System.Drawing.Color.Orange;
            this.productDeleteBT.Location = new System.Drawing.Point(39, 745);
            this.productDeleteBT.Name = "productDeleteBT";
            this.productDeleteBT.Size = new System.Drawing.Size(539, 54);
            this.productDeleteBT.TabIndex = 6;
            this.productDeleteBT.Text = "Termék törlése";
            this.productDeleteBT.UseVisualStyleBackColor = true;
            this.productDeleteBT.Visible = false;
            this.productDeleteBT.Click += new System.EventHandler(this.productDeleteBT_Click);
            // 
            // productUpdateBT
            // 
            this.productUpdateBT.FlatAppearance.BorderSize = 0;
            this.productUpdateBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.productUpdateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productUpdateBT.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productUpdateBT.ForeColor = System.Drawing.Color.Orange;
            this.productUpdateBT.Location = new System.Drawing.Point(39, 683);
            this.productUpdateBT.Name = "productUpdateBT";
            this.productUpdateBT.Size = new System.Drawing.Size(539, 54);
            this.productUpdateBT.TabIndex = 5;
            this.productUpdateBT.Text = "Termék szerkeztése";
            this.productUpdateBT.UseVisualStyleBackColor = true;
            this.productUpdateBT.Visible = false;
            this.productUpdateBT.Click += new System.EventHandler(this.productUpdateBT_Click);
            // 
            // productUpdateGB
            // 
            this.productUpdateGB.Controls.Add(this.label17);
            this.productUpdateGB.Controls.Add(this.label16);
            this.productUpdateGB.Controls.Add(this.label15);
            this.productUpdateGB.Controls.Add(this.productUpdateStock);
            this.productUpdateGB.Controls.Add(this.productUpdatePackage);
            this.productUpdateGB.Controls.Add(this.productUpdatePrice);
            this.productUpdateGB.Controls.Add(this.productUpdateName);
            this.productUpdateGB.Controls.Add(this.label13);
            this.productUpdateGB.Controls.Add(this.label14);
            this.productUpdateGB.Controls.Add(this.label12);
            this.productUpdateGB.Controls.Add(this.label11);
            this.productUpdateGB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productUpdateGB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productUpdateGB.Location = new System.Drawing.Point(39, 70);
            this.productUpdateGB.Name = "productUpdateGB";
            this.productUpdateGB.Size = new System.Drawing.Size(539, 607);
            this.productUpdateGB.TabIndex = 5;
            this.productUpdateGB.TabStop = false;
            this.productUpdateGB.Text = "Termékek adatainak szerkeztése";
            this.productUpdateGB.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(144, 308);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(251, 16);
            this.label17.TabIndex = 14;
            this.label17.Text = "Új ár megadásánál nem kell veszzőt tenni.";
            this.label17.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(379, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 16);
            this.label16.TabIndex = 13;
            this.label16.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(276, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 23);
            this.label15.TabIndex = 12;
            this.label15.Text = "Beszállító:";
            // 
            // productUpdateStock
            // 
            this.productUpdateStock.Location = new System.Drawing.Point(126, 520);
            this.productUpdateStock.Name = "productUpdateStock";
            this.productUpdateStock.Size = new System.Drawing.Size(315, 31);
            this.productUpdateStock.TabIndex = 4;
            this.productUpdateStock.Leave += new System.EventHandler(this.productUpdateStock_Leave);
            // 
            // productUpdatePackage
            // 
            this.productUpdatePackage.Location = new System.Drawing.Point(126, 393);
            this.productUpdatePackage.Name = "productUpdatePackage";
            this.productUpdatePackage.Size = new System.Drawing.Size(315, 31);
            this.productUpdatePackage.TabIndex = 3;
            this.productUpdatePackage.Leave += new System.EventHandler(this.productUpdatePackage_Leave);
            // 
            // productUpdatePrice
            // 
            this.productUpdatePrice.Location = new System.Drawing.Point(126, 268);
            this.productUpdatePrice.Name = "productUpdatePrice";
            this.productUpdatePrice.Size = new System.Drawing.Size(315, 31);
            this.productUpdatePrice.TabIndex = 2;
            this.productUpdatePrice.Leave += new System.EventHandler(this.productUpdatePrice_Leave);
            // 
            // productUpdateName
            // 
            this.productUpdateName.Location = new System.Drawing.Point(126, 149);
            this.productUpdateName.Name = "productUpdateName";
            this.productUpdateName.Size = new System.Drawing.Size(315, 31);
            this.productUpdateName.TabIndex = 1;
            this.productUpdateName.Leave += new System.EventHandler(this.productUpdateName_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(39, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "Csomagolás:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(39, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 19);
            this.label14.TabIndex = 5;
            this.label14.Text = "Egység ár:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(39, 472);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 19);
            this.label12.TabIndex = 7;
            this.label12.Text = "Mennyiség:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(39, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Termék megnevezése:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(1021, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 38);
            this.label10.TabIndex = 4;
            this.label10.Text = "Adatbázis:";
            // 
            // productUpdateNDeleteDGV
            // 
            this.productUpdateNDeleteDGV.AllowUserToAddRows = false;
            this.productUpdateNDeleteDGV.AllowUserToDeleteRows = false;
            this.productUpdateNDeleteDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productUpdateNDeleteDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productUpdateNDeleteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productUpdateNDeleteDGV.Location = new System.Drawing.Point(716, 94);
            this.productUpdateNDeleteDGV.Name = "productUpdateNDeleteDGV";
            this.productUpdateNDeleteDGV.ReadOnly = true;
            this.productUpdateNDeleteDGV.RowTemplate.Height = 24;
            this.productUpdateNDeleteDGV.Size = new System.Drawing.Size(723, 346);
            this.productUpdateNDeleteDGV.TabIndex = 3;
            this.productUpdateNDeleteDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productUpdateNDeleteDGV_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(18, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(626, 41);
            this.label9.TabIndex = 2;
            this.label9.Text = "Új árucikk szerkesztése vagy törlése:";
            // 
            // orderStock
            // 
            this.orderStock.AutoScroll = true;
            this.orderStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.orderStock.Controls.Add(this.selectProductSupplierId);
            this.orderStock.Controls.Add(this.suppliersDataCB);
            this.orderStock.Controls.Add(this.selectedProdcutId);
            this.orderStock.Controls.Add(this.productSotckGB);
            this.orderStock.Controls.Add(this.label19);
            this.orderStock.Controls.Add(this.label20);
            this.orderStock.Controls.Add(this.productsCB);
            this.orderStock.Location = new System.Drawing.Point(4, 25);
            this.orderStock.Name = "orderStock";
            this.orderStock.Size = new System.Drawing.Size(1446, 819);
            this.orderStock.TabIndex = 3;
            this.orderStock.Text = "Raktárkészlet kezelése";
            // 
            // selectProductSupplierId
            // 
            this.selectProductSupplierId.AutoSize = true;
            this.selectProductSupplierId.Location = new System.Drawing.Point(532, 159);
            this.selectProductSupplierId.Name = "selectProductSupplierId";
            this.selectProductSupplierId.Size = new System.Drawing.Size(55, 16);
            this.selectProductSupplierId.TabIndex = 11;
            this.selectProductSupplierId.Text = "label24";
            this.selectProductSupplierId.Visible = false;
            // 
            // suppliersDataCB
            // 
            this.suppliersDataCB.Controls.Add(this.supplierPhoneLL);
            this.suppliersDataCB.Controls.Add(this.supplierCityLL);
            this.suppliersDataCB.Controls.Add(this.supplierContactNameLL);
            this.suppliersDataCB.Controls.Add(this.supplierCompanyNameLL);
            this.suppliersDataCB.Controls.Add(this.label28);
            this.suppliersDataCB.Controls.Add(this.label27);
            this.suppliersDataCB.Controls.Add(this.label26);
            this.suppliersDataCB.Controls.Add(this.label25);
            this.suppliersDataCB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.suppliersDataCB.Location = new System.Drawing.Point(805, 32);
            this.suppliersDataCB.Name = "suppliersDataCB";
            this.suppliersDataCB.Size = new System.Drawing.Size(503, 240);
            this.suppliersDataCB.TabIndex = 10;
            this.suppliersDataCB.TabStop = false;
            this.suppliersDataCB.Text = "Beszállító adatai:";
            this.suppliersDataCB.Visible = false;
            // 
            // supplierPhoneLL
            // 
            this.supplierPhoneLL.AutoSize = true;
            this.supplierPhoneLL.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.supplierPhoneLL.Location = new System.Drawing.Point(193, 204);
            this.supplierPhoneLL.Name = "supplierPhoneLL";
            this.supplierPhoneLL.Size = new System.Drawing.Size(53, 16);
            this.supplierPhoneLL.TabIndex = 16;
            this.supplierPhoneLL.Text = "label31";
            // 
            // supplierCityLL
            // 
            this.supplierCityLL.AutoSize = true;
            this.supplierCityLL.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.supplierCityLL.Location = new System.Drawing.Point(193, 154);
            this.supplierCityLL.Name = "supplierCityLL";
            this.supplierCityLL.Size = new System.Drawing.Size(53, 16);
            this.supplierCityLL.TabIndex = 15;
            this.supplierCityLL.Text = "label30";
            // 
            // supplierContactNameLL
            // 
            this.supplierContactNameLL.AutoSize = true;
            this.supplierContactNameLL.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.supplierContactNameLL.Location = new System.Drawing.Point(193, 101);
            this.supplierContactNameLL.Name = "supplierContactNameLL";
            this.supplierContactNameLL.Size = new System.Drawing.Size(53, 16);
            this.supplierContactNameLL.TabIndex = 14;
            this.supplierContactNameLL.Text = "label29";
            // 
            // supplierCompanyNameLL
            // 
            this.supplierCompanyNameLL.AutoSize = true;
            this.supplierCompanyNameLL.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.supplierCompanyNameLL.Location = new System.Drawing.Point(193, 49);
            this.supplierCompanyNameLL.Name = "supplierCompanyNameLL";
            this.supplierCompanyNameLL.Size = new System.Drawing.Size(53, 16);
            this.supplierCompanyNameLL.TabIndex = 13;
            this.supplierCompanyNameLL.Text = "label24";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label28.Location = new System.Drawing.Point(23, 204);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 16);
            this.label28.TabIndex = 12;
            this.label28.Text = "Mobil:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(23, 154);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 16);
            this.label27.TabIndex = 11;
            this.label27.Text = "Város:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(22, 101);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(143, 16);
            this.label26.TabIndex = 10;
            this.label26.Text = "Kapcsolattartó neve:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(22, 49);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 16);
            this.label25.TabIndex = 9;
            this.label25.Text = "Cégnév:";
            // 
            // selectedProdcutId
            // 
            this.selectedProdcutId.AutoSize = true;
            this.selectedProdcutId.Location = new System.Drawing.Point(529, 113);
            this.selectedProdcutId.Name = "selectedProdcutId";
            this.selectedProdcutId.Size = new System.Drawing.Size(55, 16);
            this.selectedProdcutId.TabIndex = 7;
            this.selectedProdcutId.Text = "label21";
            this.selectedProdcutId.Visible = false;
            // 
            // productSotckGB
            // 
            this.productSotckGB.Controls.Add(this.productAddOrRemoveBT);
            this.productSotckGB.Controls.Add(this.label23);
            this.productSotckGB.Controls.Add(this.selectedProductStockUpdateBT);
            this.productSotckGB.Controls.Add(this.label22);
            this.productSotckGB.Controls.Add(this.textBox1);
            this.productSotckGB.Controls.Add(this.selectedProductPackage);
            this.productSotckGB.Controls.Add(this.label21);
            this.productSotckGB.Controls.Add(this.selectedProductStock);
            this.productSotckGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productSotckGB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productSotckGB.Location = new System.Drawing.Point(72, 293);
            this.productSotckGB.Name = "productSotckGB";
            this.productSotckGB.Size = new System.Drawing.Size(898, 410);
            this.productSotckGB.TabIndex = 6;
            this.productSotckGB.TabStop = false;
            this.productSotckGB.Text = "groupBox1";
            this.productSotckGB.Visible = false;
            // 
            // productAddOrRemoveBT
            // 
            this.productAddOrRemoveBT.ForeColor = System.Drawing.Color.Black;
            this.productAddOrRemoveBT.Location = new System.Drawing.Point(594, 26);
            this.productAddOrRemoveBT.Name = "productAddOrRemoveBT";
            this.productAddOrRemoveBT.Size = new System.Drawing.Size(268, 58);
            this.productAddOrRemoveBT.TabIndex = 2;
            this.productAddOrRemoveBT.Text = "Készletek feltöltése";
            this.productAddOrRemoveBT.UseVisualStyleBackColor = true;
            this.productAddOrRemoveBT.Click += new System.EventHandler(this.productAddOrRemoveBT_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(187, 101);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 19);
            this.label23.TabIndex = 7;
            this.label23.Text = "Csomagolás:";
            // 
            // selectedProductStockUpdateBT
            // 
            this.selectedProductStockUpdateBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectedProductStockUpdateBT.Enabled = false;
            this.selectedProductStockUpdateBT.FlatAppearance.BorderSize = 0;
            this.selectedProductStockUpdateBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.selectedProductStockUpdateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedProductStockUpdateBT.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedProductStockUpdateBT.ForeColor = System.Drawing.Color.Orange;
            this.selectedProductStockUpdateBT.Location = new System.Drawing.Point(150, 336);
            this.selectedProductStockUpdateBT.Name = "selectedProductStockUpdateBT";
            this.selectedProductStockUpdateBT.Size = new System.Drawing.Size(588, 54);
            this.selectedProductStockUpdateBT.TabIndex = 4;
            this.selectedProductStockUpdateBT.Text = "Készlet hozzáadása";
            this.selectedProductStockUpdateBT.UseVisualStyleBackColor = true;
            this.selectedProductStockUpdateBT.Click += new System.EventHandler(this.selectedProductStockUpdateBT_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(21, 204);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 19);
            this.label22.TabIndex = 4;
            this.label22.Text = "Mennyiség:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // selectedProductPackage
            // 
            this.selectedProductPackage.AutoSize = true;
            this.selectedProductPackage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedProductPackage.Location = new System.Drawing.Point(303, 101);
            this.selectedProductPackage.Name = "selectedProductPackage";
            this.selectedProductPackage.Size = new System.Drawing.Size(67, 19);
            this.selectedProductPackage.TabIndex = 2;
            this.selectedProductPackage.Text = "label22";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(48, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(249, 19);
            this.label21.TabIndex = 1;
            this.label21.Text = "Adatbázisban lévő mennyiség:";
            // 
            // selectedProductStock
            // 
            this.selectedProductStock.AutoSize = true;
            this.selectedProductStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedProductStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectedProductStock.Location = new System.Drawing.Point(303, 61);
            this.selectedProductStock.Name = "selectedProductStock";
            this.selectedProductStock.Size = new System.Drawing.Size(67, 19);
            this.selectedProductStock.TabIndex = 0;
            this.selectedProductStock.Text = "label21";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(18, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(172, 23);
            this.label19.TabIndex = 5;
            this.label19.Text = "Válassz terméket:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.ForeColor = System.Drawing.Color.Orange;
            this.label20.Location = new System.Drawing.Point(15, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(280, 41);
            this.label20.TabIndex = 4;
            this.label20.Text = "Készlet feltöltés:";
            // 
            // productsCB
            // 
            this.productsCB.FormattingEnabled = true;
            this.productsCB.Location = new System.Drawing.Point(222, 109);
            this.productsCB.Name = "productsCB";
            this.productsCB.Size = new System.Drawing.Size(261, 24);
            this.productsCB.TabIndex = 1;
            this.productsCB.SelectedIndexChanged += new System.EventHandler(this.productsCB_SelectedIndexChanged);
            // 
            // Prodcut_UC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.AutoScrollMinSize = new System.Drawing.Size(500, 350);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.tabControl1);
            this.Name = "Prodcut_UC";
            this.Size = new System.Drawing.Size(1454, 848);
            this.Load += new System.EventHandler(this.Prodcut_UC_Load);
            this.tabControl1.ResumeLayout(false);
            this.newProduct.ResumeLayout(false);
            this.newProduct.PerformLayout();
            this.productDetailsGB.ResumeLayout(false);
            this.productDetailsGB.PerformLayout();
            this.updateProdcutOrDelete.ResumeLayout(false);
            this.updateProdcutOrDelete.PerformLayout();
            this.productUpdateGB.ResumeLayout(false);
            this.productUpdateGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productUpdateNDeleteDGV)).EndInit();
            this.orderStock.ResumeLayout(false);
            this.orderStock.PerformLayout();
            this.suppliersDataCB.ResumeLayout(false);
            this.suppliersDataCB.PerformLayout();
            this.productSotckGB.ResumeLayout(false);
            this.productSotckGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage newProduct;
        private System.Windows.Forms.TabPage updateProdcutOrDelete;
        private System.Windows.Forms.TabPage orderStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox suppliersCB;
        private System.Windows.Forms.GroupBox productDetailsGB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label productSupplierIdLL;
        private System.Windows.Forms.TextBox productStockTB;
        private System.Windows.Forms.TextBox productUnitPriceTB;
        private System.Windows.Forms.TextBox productPackageTB;
        private System.Windows.Forms.TextBox productNameTB;
        private System.Windows.Forms.Button newProductBT;
        private System.Windows.Forms.DataGridView productUpdateNDeleteDGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox productUpdateGB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button productDeleteBT;
        private System.Windows.Forms.Button productUpdateBT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox productUpdateStock;
        private System.Windows.Forms.TextBox productUpdatePackage;
        private System.Windows.Forms.TextBox productUpdatePrice;
        private System.Windows.Forms.TextBox productUpdateName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button productUpdateDGVReload;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox productsCB;
        private System.Windows.Forms.GroupBox productSotckGB;
        private System.Windows.Forms.Label selectedProdcutId;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label selectedProductPackage;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label selectedProductStock;
        private System.Windows.Forms.Button selectedProductStockUpdateBT;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button productAddOrRemoveBT;
        private System.Windows.Forms.GroupBox suppliersDataCB;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label supplierPhoneLL;
        private System.Windows.Forms.Label supplierCityLL;
        private System.Windows.Forms.Label supplierContactNameLL;
        private System.Windows.Forms.Label supplierCompanyNameLL;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label selectProductSupplierId;
    }
}
