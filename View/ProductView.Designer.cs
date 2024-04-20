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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            DgProduct = new DataGridView();
            BtnSearch = new Button();
            label1 = new Label();
            TxtSearch = new TextBox();
            tabPage3 = new TabPage();
            TxtProductId = new TextBox();
            TxtProductObservation = new TextBox();
            TxtProductName = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
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
            // button4
            // 
            button4.Location = new Point(433, 321);
            button4.Name = "button4";
            button4.Size = new Size(284, 56);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(433, 259);
            button3.Name = "button3";
            button3.Size = new Size(284, 56);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(433, 197);
            button2.Name = "button2";
            button2.Size = new Size(284, 56);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(433, 130);
            button1.Name = "button1";
            button1.Size = new Size(284, 56);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(10, 130);
            DgProduct.Name = "DgProduct";
            DgProduct.RowHeadersWidth = 62;
            DgProduct.Size = new Size(360, 225);
            DgProduct.TabIndex = 3;
            // 
            // BtnSearch
            // 
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
            // TxtProductId
            // 
            TxtProductId.Location = new Point(16, 31);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(150, 31);
            TxtProductId.TabIndex = 0;
            // 
            // TxtProductObservation
            // 
            TxtProductObservation.Location = new Point(16, 171);
            TxtProductObservation.Multiline = true;
            TxtProductObservation.Name = "TxtProductObservation";
            TxtProductObservation.Size = new Size(366, 78);
            TxtProductObservation.TabIndex = 1;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(16, 98);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(279, 31);
            TxtProductName.TabIndex = 2;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(25, 287);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(115, 69);
            BtnSave.TabIndex = 3;
            BtnSave.Text = "button5";
            BtnSave.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 3);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 5;
            label2.Text = "Id";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 144);
            label4.Name = "label4";
            label4.Size = new Size(192, 25);
            label4.TabIndex = 7;
            label4.Text = "Products Observations";
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
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
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