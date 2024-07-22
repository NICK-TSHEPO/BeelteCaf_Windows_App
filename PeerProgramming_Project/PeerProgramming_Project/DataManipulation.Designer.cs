
namespace PeerProgramming_Project
{
    partial class DataManipulation
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
            this.lblOperations = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOperationsDone = new System.Windows.Forms.Button();
            this.btnOperationsCancel = new System.Windows.Forms.Button();
            this.btnHowToDelete = new System.Windows.Forms.Button();
            this.txtOpItemName = new System.Windows.Forms.TextBox();
            this.txtOpSearch = new System.Windows.Forms.TextBox();
            this.txtOpPrice = new System.Windows.Forms.TextBox();
            this.cmbOpCategory = new System.Windows.Forms.ComboBox();
            this.lblDeleteInstruction = new System.Windows.Forms.Label();
            this.dgvOperations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperations
            // 
            this.lblOperations.AutoSize = true;
            this.lblOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperations.Location = new System.Drawing.Point(232, 9);
            this.lblOperations.Name = "lblOperations";
            this.lblOperations.Size = new System.Drawing.Size(203, 31);
            this.lblOperations.TabIndex = 0;
            this.lblOperations.Text = "OPERATIONS";
            this.lblOperations.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // btnOperationsDone
            // 
            this.btnOperationsDone.Location = new System.Drawing.Point(192, 415);
            this.btnOperationsDone.Name = "btnOperationsDone";
            this.btnOperationsDone.Size = new System.Drawing.Size(75, 23);
            this.btnOperationsDone.TabIndex = 5;
            this.btnOperationsDone.Text = "Done";
            this.btnOperationsDone.UseVisualStyleBackColor = true;
            this.btnOperationsDone.Click += new System.EventHandler(this.btnOperationsDone_Click);
            // 
            // btnOperationsCancel
            // 
            this.btnOperationsCancel.Location = new System.Drawing.Point(284, 415);
            this.btnOperationsCancel.Name = "btnOperationsCancel";
            this.btnOperationsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnOperationsCancel.TabIndex = 6;
            this.btnOperationsCancel.Text = "Cancel";
            this.btnOperationsCancel.UseVisualStyleBackColor = true;
            this.btnOperationsCancel.Click += new System.EventHandler(this.btnOperationsCancel_Click);
            // 
            // btnHowToDelete
            // 
            this.btnHowToDelete.Location = new System.Drawing.Point(451, 415);
            this.btnHowToDelete.Name = "btnHowToDelete";
            this.btnHowToDelete.Size = new System.Drawing.Size(102, 23);
            this.btnHowToDelete.TabIndex = 7;
            this.btnHowToDelete.Text = "How to delete?";
            this.btnHowToDelete.UseVisualStyleBackColor = true;
            this.btnHowToDelete.Click += new System.EventHandler(this.btnHowToDelete_Click);
            // 
            // txtOpItemName
            // 
            this.txtOpItemName.Location = new System.Drawing.Point(178, 293);
            this.txtOpItemName.Name = "txtOpItemName";
            this.txtOpItemName.Size = new System.Drawing.Size(100, 20);
            this.txtOpItemName.TabIndex = 8;
            this.txtOpItemName.TextChanged += new System.EventHandler(this.txtOpItemName_TextChanged);
            // 
            // txtOpSearch
            // 
            this.txtOpSearch.Location = new System.Drawing.Point(178, 264);
            this.txtOpSearch.Name = "txtOpSearch";
            this.txtOpSearch.Size = new System.Drawing.Size(100, 20);
            this.txtOpSearch.TabIndex = 9;
            // 
            // txtOpPrice
            // 
            this.txtOpPrice.Location = new System.Drawing.Point(178, 367);
            this.txtOpPrice.Name = "txtOpPrice";
            this.txtOpPrice.Size = new System.Drawing.Size(100, 20);
            this.txtOpPrice.TabIndex = 10;
            this.txtOpPrice.TextChanged += new System.EventHandler(this.txtOpPrice_TextChanged);
            // 
            // cmbOpCategory
            // 
            this.cmbOpCategory.FormattingEnabled = true;
            this.cmbOpCategory.Location = new System.Drawing.Point(178, 327);
            this.cmbOpCategory.Name = "cmbOpCategory";
            this.cmbOpCategory.Size = new System.Drawing.Size(100, 21);
            this.cmbOpCategory.TabIndex = 11;
            // 
            // lblDeleteInstruction
            // 
            this.lblDeleteInstruction.AutoSize = true;
            this.lblDeleteInstruction.Location = new System.Drawing.Point(448, 399);
            this.lblDeleteInstruction.Name = "lblDeleteInstruction";
            this.lblDeleteInstruction.Size = new System.Drawing.Size(90, 13);
            this.lblDeleteInstruction.TabIndex = 12;
            this.lblDeleteInstruction.Text = "Delete Instruction";
            this.lblDeleteInstruction.Visible = false;
            // 
            // dgvOperations
            // 
            this.dgvOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperations.Location = new System.Drawing.Point(81, 45);
            this.dgvOperations.Name = "dgvOperations";
            this.dgvOperations.Size = new System.Drawing.Size(568, 208);
            this.dgvOperations.TabIndex = 13;
            // 
            // DataManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.dgvOperations);
            this.Controls.Add(this.lblDeleteInstruction);
            this.Controls.Add(this.cmbOpCategory);
            this.Controls.Add(this.txtOpPrice);
            this.Controls.Add(this.txtOpSearch);
            this.Controls.Add(this.txtOpItemName);
            this.Controls.Add(this.btnHowToDelete);
            this.Controls.Add(this.btnOperationsCancel);
            this.Controls.Add(this.btnOperationsDone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperations);
            this.Name = "DataManipulation";
            this.Text = "DataManipulation";
            this.Load += new System.EventHandler(this.DataManipulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnOperationsDone;
        public System.Windows.Forms.Button btnOperationsCancel;
        public System.Windows.Forms.Button btnHowToDelete;
        public System.Windows.Forms.TextBox txtOpItemName;
        public System.Windows.Forms.TextBox txtOpSearch;
        public System.Windows.Forms.TextBox txtOpPrice;
        public System.Windows.Forms.ComboBox cmbOpCategory;
        public System.Windows.Forms.Label lblDeleteInstruction;
        public System.Windows.Forms.Label lblOperations;
        public System.Windows.Forms.DataGridView dgvOperations;
    }
}