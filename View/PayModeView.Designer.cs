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
            tabPagePayModeDetail = new TabPage();
            label2 = new Label();
            textSearch = new TextBox();
            BtnSearch = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabPageModeList.Controls.Add(button4);
            tabPageModeList.Controls.Add(button3);
            tabPageModeList.Controls.Add(button2);
            tabPageModeList.Controls.Add(button1);
            tabPageModeList.Controls.Add(dataGridView1);
            tabPageModeList.Controls.Add(BtnSearch);
            tabPageModeList.Controls.Add(textSearch);
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
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Location = new Point(4, 34);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(792, 262);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
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
            // textSearch
            // 
            textSearch.Location = new Point(0, 31);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Data to Search";
            textSearch.Size = new Size(150, 31);
            textSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(146, 29);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(112, 34);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(364, 285);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(610, 6);
            button1.Name = "button1";
            button1.Size = new Size(158, 74);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(610, 266);
            button2.Name = "button2";
            button2.Size = new Size(158, 70);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(610, 181);
            button3.Name = "button3";
            button3.Size = new Size(158, 69);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(610, 96);
            button4.Name = "button4";
            button4.Size = new Size(158, 68);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 541);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Managment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageModeList.ResumeLayout(false);
            tabPageModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageModeList;
        private TabPage tabPagePayModeDetail;
        private TextBox textSearch;
        private Label label2;
        private Button BtnSearch;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}