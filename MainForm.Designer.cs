
namespace BFM1_Task1
{
    partial class MainForm
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
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsModify = new System.Windows.Forms.Button();
            this.PartsAdd = new System.Windows.Forms.Button();
            this.DeleteProducts = new System.Windows.Forms.Button();
            this.ProductsModify = new System.Windows.Forms.Button();
            this.ProductsAdd = new System.Windows.Forms.Button();
            this.MainFormExit = new System.Windows.Forms.Button();
            this.PartsDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchParts = new System.Windows.Forms.Button();
            this.PartsSearchBox = new System.Windows.Forms.TextBox();
            this.SearchProducts = new System.Windows.Forms.Button();
            this.ProductsSearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvParts.Location = new System.Drawing.Point(25, 111);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(698, 387);
            this.dgvParts.TabIndex = 0;
            this.dgvParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            this.dgvParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.julianBindingComplete);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PartID";
            this.Column7.HeaderText = "PartID";
            this.Column7.Name = "Column7";
            this.Column7.Width = 109;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Name";
            this.Column8.HeaderText = "Name";
            this.Column8.Name = "Column8";
            this.Column8.Width = 109;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Inventory";
            this.Column9.HeaderText = "Inventory";
            this.Column9.Name = "Column9";
            this.Column9.Width = 109;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Price";
            this.Column10.HeaderText = "Price";
            this.Column10.Name = "Column10";
            this.Column10.Width = 109;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Min";
            this.Column11.HeaderText = "Min";
            this.Column11.Name = "Column11";
            this.Column11.Width = 109;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Max";
            this.Column12.HeaderText = "Max";
            this.Column12.Name = "Column12";
            this.Column12.Width = 109;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvProducts.Location = new System.Drawing.Point(785, 111);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(673, 387);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.julianProductsBindingComplete);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductId";
            this.Column1.HeaderText = "ProductID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 105;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 105;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "inventory";
            this.Column3.HeaderText = "Inventory";
            this.Column3.Name = "Column3";
            this.Column3.Width = 105;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "price";
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.Width = 105;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "min";
            this.Column5.HeaderText = "Min";
            this.Column5.Name = "Column5";
            this.Column5.Width = 105;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "max";
            this.Column6.HeaderText = "Max";
            this.Column6.Name = "Column6";
            this.Column6.Width = 105;
            // 
            // PartsModify
            // 
            this.PartsModify.Location = new System.Drawing.Point(475, 522);
            this.PartsModify.Name = "PartsModify";
            this.PartsModify.Size = new System.Drawing.Size(121, 40);
            this.PartsModify.TabIndex = 4;
            this.PartsModify.Text = "Modify";
            this.PartsModify.UseVisualStyleBackColor = true;
            this.PartsModify.Click += new System.EventHandler(this.PartsModify_Click);
            // 
            // PartsAdd
            // 
            this.PartsAdd.Location = new System.Drawing.Point(348, 522);
            this.PartsAdd.Name = "PartsAdd";
            this.PartsAdd.Size = new System.Drawing.Size(121, 40);
            this.PartsAdd.TabIndex = 5;
            this.PartsAdd.Text = "Add";
            this.PartsAdd.UseVisualStyleBackColor = true;
            this.PartsAdd.Click += new System.EventHandler(this.PartsAdd_Click);
            // 
            // DeleteProducts
            // 
            this.DeleteProducts.Location = new System.Drawing.Point(1337, 522);
            this.DeleteProducts.Name = "DeleteProducts";
            this.DeleteProducts.Size = new System.Drawing.Size(121, 40);
            this.DeleteProducts.TabIndex = 6;
            this.DeleteProducts.Text = "Delete";
            this.DeleteProducts.UseVisualStyleBackColor = true;
            this.DeleteProducts.Click += new System.EventHandler(this.DeleteProducts_Click);
            // 
            // ProductsModify
            // 
            this.ProductsModify.Location = new System.Drawing.Point(1210, 522);
            this.ProductsModify.Name = "ProductsModify";
            this.ProductsModify.Size = new System.Drawing.Size(121, 40);
            this.ProductsModify.TabIndex = 7;
            this.ProductsModify.Text = "Modify";
            this.ProductsModify.UseVisualStyleBackColor = true;
            this.ProductsModify.Click += new System.EventHandler(this.ProductsModify_Click);
            // 
            // ProductsAdd
            // 
            this.ProductsAdd.Location = new System.Drawing.Point(1083, 522);
            this.ProductsAdd.Name = "ProductsAdd";
            this.ProductsAdd.Size = new System.Drawing.Size(121, 40);
            this.ProductsAdd.TabIndex = 8;
            this.ProductsAdd.Text = "Add";
            this.ProductsAdd.UseVisualStyleBackColor = true;
            this.ProductsAdd.Click += new System.EventHandler(this.ProductsAdd_Click);
            // 
            // MainFormExit
            // 
            this.MainFormExit.Location = new System.Drawing.Point(1337, 580);
            this.MainFormExit.Name = "MainFormExit";
            this.MainFormExit.Size = new System.Drawing.Size(121, 40);
            this.MainFormExit.TabIndex = 9;
            this.MainFormExit.Text = "Exit";
            this.MainFormExit.UseVisualStyleBackColor = true;
            this.MainFormExit.Click += new System.EventHandler(this.MainFormExit_Click);
            // 
            // PartsDelete
            // 
            this.PartsDelete.Location = new System.Drawing.Point(602, 522);
            this.PartsDelete.Name = "PartsDelete";
            this.PartsDelete.Size = new System.Drawing.Size(121, 40);
            this.PartsDelete.TabIndex = 10;
            this.PartsDelete.Text = "Delete";
            this.PartsDelete.UseVisualStyleBackColor = true;
            this.PartsDelete.Click += new System.EventHandler(this.PartsDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(782, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Products";
            // 
            // SearchParts
            // 
            this.SearchParts.Location = new System.Drawing.Point(426, 79);
            this.SearchParts.Name = "SearchParts";
            this.SearchParts.Size = new System.Drawing.Size(76, 22);
            this.SearchParts.TabIndex = 14;
            this.SearchParts.Text = "Search";
            this.SearchParts.UseVisualStyleBackColor = true;
            this.SearchParts.Click += new System.EventHandler(this.SearchParts_Click);
            // 
            // PartsSearchBox
            // 
            this.PartsSearchBox.Location = new System.Drawing.Point(508, 81);
            this.PartsSearchBox.Name = "PartsSearchBox";
            this.PartsSearchBox.Size = new System.Drawing.Size(215, 20);
            this.PartsSearchBox.TabIndex = 16;
            // 
            // SearchProducts
            // 
            this.SearchProducts.Location = new System.Drawing.Point(1161, 79);
            this.SearchProducts.Name = "SearchProducts";
            this.SearchProducts.Size = new System.Drawing.Size(76, 22);
            this.SearchProducts.TabIndex = 17;
            this.SearchProducts.Text = "Search";
            this.SearchProducts.UseVisualStyleBackColor = true;
            this.SearchProducts.Click += new System.EventHandler(this.SearchProducts_Click);
            // 
            // ProductsSearchBox
            // 
            this.ProductsSearchBox.Location = new System.Drawing.Point(1243, 81);
            this.ProductsSearchBox.Name = "ProductsSearchBox";
            this.ProductsSearchBox.Size = new System.Drawing.Size(215, 20);
            this.ProductsSearchBox.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 645);
            this.Controls.Add(this.ProductsSearchBox);
            this.Controls.Add(this.SearchProducts);
            this.Controls.Add(this.PartsSearchBox);
            this.Controls.Add(this.SearchParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartsDelete);
            this.Controls.Add(this.MainFormExit);
            this.Controls.Add(this.ProductsAdd);
            this.Controls.Add(this.ProductsModify);
            this.Controls.Add(this.DeleteProducts);
            this.Controls.Add(this.PartsAdd);
            this.Controls.Add(this.PartsModify);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button PartsModify;
        private System.Windows.Forms.Button PartsAdd;
        private System.Windows.Forms.Button DeleteProducts;
        private System.Windows.Forms.Button ProductsModify;
        private System.Windows.Forms.Button ProductsAdd;
        private System.Windows.Forms.Button MainFormExit;
        internal System.Windows.Forms.Button PartsDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchParts;
        private System.Windows.Forms.TextBox PartsSearchBox;
        private System.Windows.Forms.Button SearchProducts;
        private System.Windows.Forms.TextBox ProductsSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}

