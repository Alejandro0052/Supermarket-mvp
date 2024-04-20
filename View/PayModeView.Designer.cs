namespace Supermarket_mvp.View
{
    partial class PayModeView
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
            tabPageModeList = new TabPage();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPagePayModeDetail = new TabPage();
            TxtModeObservation = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TxtPayModeName = new TextBox();
            TxtPayModeId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 150);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(33, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 56);
            label1.Name = "label1";
            label1.Size = new Size(186, 48);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 150);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(813, 391);
            tabControl1.TabIndex = 1;
            // 
            // tabPageModeList
            // 
            tabPageModeList.Controls.Add(BtnEdit);
            tabPageModeList.Controls.Add(BtnDelete);
            tabPageModeList.Controls.Add(BtnClose);
            tabPageModeList.Controls.Add(BtnNew);
            tabPageModeList.Controls.Add(DgPayMode);
            tabPageModeList.Controls.Add(BtnSearch);
            tabPageModeList.Controls.Add(TxtSearch);
            tabPageModeList.Controls.Add(label2);
            tabPageModeList.Location = new Point(4, 34);
            tabPageModeList.Name = "tabPageModeList";
            tabPageModeList.Padding = new Padding(3);
            tabPageModeList.Size = new Size(805, 353);
            tabPageModeList.TabIndex = 0;
            tabPageModeList.Text = "Pay Mode List";
            tabPageModeList.UseVisualStyleBackColor = true;
            tabPageModeList.Click += tabPage1_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(610, 96);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(158, 68);
            BtnEdit.TabIndex = 7;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(610, 181);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(158, 69);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(610, 266);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(158, 70);
            BtnClose.TabIndex = 5;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(610, 6);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(158, 74);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += button1_Click;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(0, 68);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 62;
            DgPayMode.Size = new Size(364, 285);
            DgPayMode.TabIndex = 3;
            DgPayMode.CellContentClick += DgPayMode_CellContentClick;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Location = new Point(146, 29);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(112, 34);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(0, 31);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(150, 31);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 3);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(TxtModeObservation);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(label5);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Location = new Point(4, 34);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(805, 353);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // TxtModeObservation
            // 
            TxtModeObservation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtModeObservation.ForeColor = SystemColors.ScrollBar;
            TxtModeObservation.Location = new Point(2, 204);
            TxtModeObservation.Multiline = true;
            TxtModeObservation.Name = "TxtModeObservation";
            TxtModeObservation.Size = new Size(257, 57);
            TxtModeObservation.TabIndex = 10;
            TxtModeObservation.Text = "Observation";
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save1;
            BtnSave.Location = new Point(8, 267);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(112, 77);
            BtnSave.TabIndex = 9;
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(147, 267);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(112, 77);
            BtnCancel.TabIndex = 8;
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(-4, 169);
            label5.Name = "label5";
            label5.Size = new Size(207, 25);
            label5.TabIndex = 6;
            label5.Text = "Pay Mode Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(-4, 88);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 5;
            label4.Text = "Pay Mode Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 16);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 4;
            label3.Text = "Pay Mode Id";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtPayModeName.ForeColor = SystemColors.ScrollBar;
            TxtPayModeName.Location = new Point(3, 116);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.Size = new Size(324, 31);
            TxtPayModeName.TabIndex = 2;
            TxtPayModeName.Text = "Pay Mode Name";
            TxtPayModeName.TextChanged += TxtPayModeName_TextChanged;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(6, 44);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.ReadOnly = true;
            TxtPayModeId.Size = new Size(150, 31);
            TxtPayModeId.TabIndex = 1;
            TxtPayModeId.Text = "0";
            TxtPayModeId.TextAlign = HorizontalAlignment.Right;
            TxtPayModeId.TextChanged += textBox1_TextChanged;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 541);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "PayModeView";
            Text = "Pay Mode Managment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageModeList.ResumeLayout(false);
            tabPageModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageModeList;
        private TabPage tabPagePayModeDetail;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnSearch;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClose;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeId;
        private Label label3;
        private Label label4;
        private Button BtnSave;
        private Button BtnCancel;
        private Label label5;
        private TextBox TxtModeObservation;
    }
}