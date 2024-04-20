namespace Supermarket_mvp.View
{
    partial class ProductView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProduct = new DataGridView();
            BtnSearch = new Button();
            label1 = new Label();
            TxtSearch = new TextBox();
            tabPage3 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductName = new TextBox();
            TxtProductObservation = new TextBox();
            TxtProductId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 80);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 80);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(870, 415);
            tabControl1.TabIndex = 3;
            tabControl1.Tag = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnClose);
            tabPage2.Controls.Add(BtnDelete);
            tabPage2.Controls.Add(BtnEdit);
            tabPage2.Controls.Add(BtnNew);
            tabPage2.Controls.Add(DgProduct);
            tabPage2.Controls.Add(BtnSearch);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(TxtSearch);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(862, 377);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Product List";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar1;
            BtnClose.Location = new Point(433, 321);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(284, 56);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.save2;
            BtnDelete.Location = new Point(433, 259);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(284, 56);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += button3_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit1;
            BtnEdit.Location = new Point(433, 197);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(284, 56);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources.new2;
            BtnNew.Location = new Point(433, 130);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(284, 56);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(10, 130);
            DgProduct.Name = "DgProduct";
            DgProduct.RowHeadersWidth = 62;
            DgProduct.Size = new Size(360, 225);
            DgProduct.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Location = new Point(179, 91);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(112, 34);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 52);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 1;
            label1.Text = "Search Product";
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(23, 91);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(150, 31);
            TxtSearch.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(BtnCancel);
            tabPage3.Controls.Add(BtnSave);
            tabPage3.Controls.Add(TxtProductName);
            tabPage3.Controls.Add(TxtProductObservation);
            tabPage3.Controls.Add(TxtProductId);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(862, 377);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Product Detail";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 144);
            label4.Name = "label4";
            label4.Size = new Size(192, 25);
            label4.TabIndex = 7;
            label4.Text = "Products Observations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 70);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 6;
            label3.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 3);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 5;
            label2.Text = "Id";
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(216, 287);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(115, 69);
            BtnCancel.TabIndex = 4;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(25, 287);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(115, 69);
            BtnSave.TabIndex = 3;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(16, 98);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(279, 31);
            TxtProductName.TabIndex = 2;
            // 
            // TxtProductObservation
            // 
            TxtProductObservation.Location = new Point(16, 171);
            TxtProductObservation.Multiline = true;
            TxtProductObservation.Name = "TxtProductObservation";
            TxtProductObservation.Size = new Size(366, 78);
            TxtProductObservation.TabIndex = 1;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(16, 31);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(150, 31);
            TxtProductId.TabIndex = 0;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 495);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private DataGridView DgProduct;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtProductName;
        private TextBox TxtProductObservation;
        private TextBox TxtProductId;
        private Button BtnCancel;
        private Button BtnSave;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}