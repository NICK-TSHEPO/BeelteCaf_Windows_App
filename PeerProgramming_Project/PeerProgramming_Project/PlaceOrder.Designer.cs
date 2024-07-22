
namespace PeerProgramming_Project
{
    partial class PlaceOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbCheckPoint = new System.Windows.Forms.GroupBox();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCartList = new System.Windows.Forms.ListBox();
            this.lstItemList = new System.Windows.Forms.ListBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCustomerProceed = new System.Windows.Forms.Button();
            this.pictureBoxCoffee = new System.Windows.Forms.PictureBox();
            this.pictureBoxTea = new System.Windows.Forms.PictureBox();
            this.pictureBoxPastry = new System.Windows.Forms.PictureBox();
            this.pictureBoxSandwich = new System.Windows.Forms.PictureBox();
            this.pictureBoxOtherDrinks = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.dateTimeReceipt = new System.Windows.Forms.DateTimePicker();
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.grbCheckPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPastry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSandwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOtherDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.grbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity:";
            // 
            // grbCheckPoint
            // 
            this.grbCheckPoint.Controls.Add(this.lblSelectedItem);
            this.grbCheckPoint.Controls.Add(this.label6);
            this.grbCheckPoint.Controls.Add(this.lblPrice);
            this.grbCheckPoint.Controls.Add(this.cmbQuantity);
            this.grbCheckPoint.Controls.Add(this.btnAddToCart);
            this.grbCheckPoint.Controls.Add(this.lblTotal);
            this.grbCheckPoint.Controls.Add(this.label2);
            this.grbCheckPoint.Location = new System.Drawing.Point(414, 25);
            this.grbCheckPoint.Name = "grbCheckPoint";
            this.grbCheckPoint.Size = new System.Drawing.Size(374, 149);
            this.grbCheckPoint.TabIndex = 2;
            this.grbCheckPoint.TabStop = false;
            this.grbCheckPoint.Text = "Check Point";
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedItem.Location = new System.Drawing.Point(20, 43);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(89, 13);
            this.lblSelectedItem.TabIndex = 10;
            this.lblSelectedItem.Text = "ItemNameDisplay";
            this.lblSelectedItem.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Item name and price:";
            this.label6.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(280, 43);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 7;
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbQuantity.Location = new System.Drawing.Point(83, 72);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(121, 21);
            this.cmbQuantity.TabIndex = 6;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(23, 120);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(92, 23);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(280, 80);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 3;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(494, 327);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(94, 13);
            this.lblGrandTotal.TabIndex = 5;
            this.lblGrandTotal.Text = "GrandTotalDisplay";
            this.lblGrandTotal.Visible = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(77, 25);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 7;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grand Total:";
            // 
            // lstCartList
            // 
            this.lstCartList.FormattingEnabled = true;
            this.lstCartList.Location = new System.Drawing.Point(414, 180);
            this.lstCartList.Name = "lstCartList";
            this.lstCartList.Size = new System.Drawing.Size(374, 134);
            this.lstCartList.TabIndex = 9;
            this.lstCartList.SelectedIndexChanged += new System.EventHandler(this.lstCartList_SelectedIndexChanged);
            // 
            // lstItemList
            // 
            this.lstItemList.FormattingEnabled = true;
            this.lstItemList.Location = new System.Drawing.Point(16, 87);
            this.lstItemList.Name = "lstItemList";
            this.lstItemList.Size = new System.Drawing.Size(202, 251);
            this.lstItemList.TabIndex = 10;
            this.lstItemList.SelectedIndexChanged += new System.EventHandler(this.lstItemList_SelectedIndexChanged);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(414, 380);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem.TabIndex = 11;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Location = new System.Drawing.Point(77, 61);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(121, 20);
            this.txtItemSearch.TabIndex = 12;
            this.txtItemSearch.TextChanged += new System.EventHandler(this.txtItemSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search:";
            // 
            // btnCustomerProceed
            // 
            this.btnCustomerProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerProceed.Location = new System.Drawing.Point(500, 380);
            this.btnCustomerProceed.Name = "btnCustomerProceed";
            this.btnCustomerProceed.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerProceed.TabIndex = 14;
            this.btnCustomerProceed.Text = "Proceed";
            this.btnCustomerProceed.UseVisualStyleBackColor = true;
            this.btnCustomerProceed.Click += new System.EventHandler(this.btnCustomerProceed_Click);
            // 
            // pictureBoxCoffee
            // 
            this.pictureBoxCoffee.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoffee.Image")));
            this.pictureBoxCoffee.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxCoffee.Name = "pictureBoxCoffee";
            this.pictureBoxCoffee.Size = new System.Drawing.Size(57, 55);
            this.pictureBoxCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoffee.TabIndex = 15;
            this.pictureBoxCoffee.TabStop = false;
            // 
            // pictureBoxTea
            // 
            this.pictureBoxTea.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTea.Image")));
            this.pictureBoxTea.Location = new System.Drawing.Point(83, 19);
            this.pictureBoxTea.Name = "pictureBoxTea";
            this.pictureBoxTea.Size = new System.Drawing.Size(59, 55);
            this.pictureBoxTea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTea.TabIndex = 16;
            this.pictureBoxTea.TabStop = false;
            // 
            // pictureBoxPastry
            // 
            this.pictureBoxPastry.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPastry.Image")));
            this.pictureBoxPastry.Location = new System.Drawing.Point(162, 19);
            this.pictureBoxPastry.Name = "pictureBoxPastry";
            this.pictureBoxPastry.Size = new System.Drawing.Size(61, 55);
            this.pictureBoxPastry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPastry.TabIndex = 17;
            this.pictureBoxPastry.TabStop = false;
            // 
            // pictureBoxSandwich
            // 
            this.pictureBoxSandwich.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSandwich.Image")));
            this.pictureBoxSandwich.Location = new System.Drawing.Point(240, 19);
            this.pictureBoxSandwich.Name = "pictureBoxSandwich";
            this.pictureBoxSandwich.Size = new System.Drawing.Size(63, 55);
            this.pictureBoxSandwich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSandwich.TabIndex = 18;
            this.pictureBoxSandwich.TabStop = false;
            // 
            // pictureBoxOtherDrinks
            // 
            this.pictureBoxOtherDrinks.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOtherDrinks.Image")));
            this.pictureBoxOtherDrinks.Location = new System.Drawing.Point(323, 19);
            this.pictureBoxOtherDrinks.Name = "pictureBoxOtherDrinks";
            this.pictureBoxOtherDrinks.Size = new System.Drawing.Size(63, 55);
            this.pictureBoxOtherDrinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOtherDrinks.TabIndex = 19;
            this.pictureBoxOtherDrinks.TabStop = false;
            this.pictureBoxOtherDrinks.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Image = global::PeerProgramming_Project.Properties.Resources.CaptureBackground;
            this.pictureBoxBackground.Location = new System.Drawing.Point(226, 25);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(182, 313);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 20;
            this.pictureBoxBackground.TabStop = false;
            this.pictureBoxBackground.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dateTimeReceipt
            // 
            this.dateTimeReceipt.Location = new System.Drawing.Point(588, 285);
            this.dateTimeReceipt.Name = "dateTimeReceipt";
            this.dateTimeReceipt.Size = new System.Drawing.Size(200, 20);
            this.dateTimeReceipt.TabIndex = 21;
            this.dateTimeReceipt.Visible = false;
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.pictureBoxCoffee);
            this.grbMenu.Controls.Add(this.pictureBoxTea);
            this.grbMenu.Controls.Add(this.pictureBoxPastry);
            this.grbMenu.Controls.Add(this.pictureBoxOtherDrinks);
            this.grbMenu.Controls.Add(this.pictureBoxSandwich);
            this.grbMenu.Location = new System.Drawing.Point(16, 349);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(392, 89);
            this.grbMenu.TabIndex = 22;
            this.grbMenu.TabStop = false;
            this.grbMenu.Text = "Menu";
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbMenu);
            this.Controls.Add(this.dateTimeReceipt);
            this.Controls.Add(this.pictureBoxBackground);
            this.Controls.Add(this.btnCustomerProceed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItemSearch);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lstItemList);
            this.Controls.Add(this.lstCartList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.grbCheckPoint);
            this.Controls.Add(this.label1);
            this.Name = "PlaceOrder";
            this.Text = "PlaceOrder";
            this.Load += new System.EventHandler(this.PlaceOrder_Load);
            this.grbCheckPoint.ResumeLayout(false);
            this.grbCheckPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPastry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSandwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOtherDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.grbMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbCheckPoint;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCartList;
        private System.Windows.Forms.ListBox lstItemList;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCustomerProceed;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxCoffee;
        private System.Windows.Forms.PictureBox pictureBoxTea;
        private System.Windows.Forms.PictureBox pictureBoxPastry;
        private System.Windows.Forms.PictureBox pictureBoxSandwich;
        private System.Windows.Forms.PictureBox pictureBoxOtherDrinks;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.DateTimePicker dateTimeReceipt;
        private System.Windows.Forms.GroupBox grbMenu;
    }
}