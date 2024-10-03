
namespace ProAndFunc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            MaTS = new ColumnHeader();
            NgonNgu = new ColumnHeader();
            Bia = new ColumnHeader();
            TrangThai = new ColumnHeader();
            TuaSach = new ColumnHeader();
            TacGia = new ColumnHeader();
            TomTat = new ColumnHeader();
            SLChuaMuon = new ColumnHeader();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { MaTS, NgonNgu, Bia, TrangThai, TuaSach, TacGia, TomTat, SLChuaMuon });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(57, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(814, 122);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // MaTS
            // 
            MaTS.Text = "Mã Tựa Sách";
            MaTS.Width = 100;
            // 
            // NgonNgu
            // 
            NgonNgu.Text = "Ngôn Ngữ";
            NgonNgu.Width = 100;
            // 
            // Bia
            // 
            Bia.Text = "Bìa";
            Bia.Width = 100;
            // 
            // TrangThai
            // 
            TrangThai.Text = "Trạng Thái";
            // 
            // TuaSach
            // 
            TuaSach.Text = "Tựa Sách";
            TuaSach.Width = 100;
            // 
            // TacGia
            // 
            TacGia.Text = "Tác Giả";
            TacGia.Width = 100;
            // 
            // TomTat
            // 
            TomTat.Text = "Tóm Tắt";
            TomTat.Width = 150;
            // 
            // SLChuaMuon
            // 
            SLChuaMuon.Text = "Số Lượng Chưa Mượn";
            SLChuaMuon.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(777, 165);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Chọn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(526, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 170);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 3;
            label1.Text = "Nhập ISBN - Mã Đầu Sách";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 365);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(526, 27);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(777, 364);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Chọn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 368);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 6;
            label2.Text = "Nhập Mã Tựa Sách";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(811, 122);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        #endregion

        private ListView listView1;
        
        private TextBox textBox1;
        
        private ColumnHeader MaTS;
        private ColumnHeader NgonNgu;
        private ColumnHeader Bia;
        private ColumnHeader TrangThai;
        private ColumnHeader TuaSach;
        private ColumnHeader TacGia;
        private ColumnHeader TomTat;
        private ColumnHeader SLChuaMuon;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private Button button2;
        private Label label2;
        private DataGridView dataGridView1;
    }
}
