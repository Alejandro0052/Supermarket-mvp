
namespace Supermarket_mvp.View
{
    partial class ProvidersView
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            DgProviders = new DataGridView();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            label2 = new Label();
            tabPage2 = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            ProviderObservation = new Label();
            label3 = new Label();
            TxtProviderObservation = new TextBox();
            TxtProviderName = new TextBox();
            LblProviders = new Label();
            TxtProviders = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 150);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(5, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 42);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Providers";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 150);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(832, 342);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DgProviders);
            tabPage1.Controls.Add(BtnClose);
            tabPage1.Controls.Add(BtnDelete);
            tabPage1.Controls.Add(BtnEdit);
            tabPage1.Controls.Add(BtnNew);
            tabPage1.Controls.Add(TxtSearch);
            tabPage1.Controls.Add(BtnSearch);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(824, 304);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Providers List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(3, 90);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.RowHeadersWidth = 62;
            DgProviders.Size = new Size(589, 211);
            DgProviders.TabIndex = 7;
            DgProviders.CellContentClick += DgProviders_CellContentClick;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cancel;
            BtnClose.Location = new Point(636, 232);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(108, 66);
            BtnClose.TabIndex = 6;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(636, 160);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(108, 66);
            BtnDelete.TabIndex = 5;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(636, 88);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(108, 66);
            BtnEdit.TabIndex = 4;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(636, 6);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(108, 66);
            BtnNew.TabIndex = 3;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(13, 53);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(253, 31);
            TxtSearch.TabIndex = 2;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(152, 18);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(112, 34);
            BtnSearch.TabIndex = 1;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 18);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 0;
            label2.Text = "Search Provider";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnCancel);
            tabPage2.Controls.Add(BtnSave);
            tabPage2.Controls.Add(ProviderObservation);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(TxtProviderObservation);
            tabPage2.Controls.Add(TxtProviderName);
            tabPage2.Controls.Add(LblProviders);
            tabPage2.Controls.Add(TxtProviders);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(824, 304);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Providers Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel2;
            BtnCancel.Location = new Point(138, 244);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(115, 52);
            BtnCancel.TabIndex = 10;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save3;
            BtnSave.Location = new Point(3, 244);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(115, 52);
            BtnSave.TabIndex = 9;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // ProviderObservation
            // 
            ProviderObservation.AutoSize = true;
            ProviderObservation.Location = new Point(6, 172);
            ProviderObservation.Name = "ProviderObservation";
            ProviderObservation.Size = new Size(101, 25);
            ProviderObservation.TabIndex = 8;
            ProviderObservation.Text = "Provider ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 87);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 7;
            label3.Text = "Provider Name";
            // 
            // TxtProviderObservation
            // 
            TxtProviderObservation.Location = new Point(0, 200);
            TxtProviderObservation.Name = "TxtProviderObservation";
            TxtProviderObservation.Size = new Size(253, 31);
            TxtProviderObservation.TabIndex = 6;
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(0, 115);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.Size = new Size(209, 31);
            TxtProviderName.TabIndex = 5;
            // 
            // LblProviders
            // 
            LblProviders.AutoSize = true;
            LblProviders.Location = new Point(10, 11);
            LblProviders.Name = "LblProviders";
            LblProviders.Size = new Size(101, 25);
            LblProviders.TabIndex = 4;
            LblProviders.Text = "Provider ID";
            // 
            // TxtProviders
            // 
            TxtProviders.Location = new Point(3, 43);
            TxtProviders.Name = "TxtProviders";
            TxtProviders.Size = new Size(108, 31);
            TxtProviders.TabIndex = 3;
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 492);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "ProvidersView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProviders;
        private Label ProviderObservation;
        private Label label3;
        private TextBox TxtProviderObservation;
        private TextBox TxtProviderName;
        private Label LblProviders;
        private TextBox TxtProviders;
        private Button BtnCancel;
        private Button BtnSave;
    }
}