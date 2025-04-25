namespace Spotifyy.UI
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
            Add = new Button();
            txtartist = new TextBox();
            Arist = new Label();
            label1 = new Label();
            txtalbum = new TextBox();
            cmbalbum = new ComboBox();
            txtmusic = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtbio = new TextBox();
            duration = new Label();
            txtduartion = new TextBox();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            button10 = new Button();
            chkmusic = new CheckBox();
            chkartist = new CheckBox();
            chkalbum = new CheckBox();
            label6 = new Label();
            cmbartist = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Add
            // 
            Add.Location = new Point(6, 175);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 0;
            Add.Text = "Add ";
            Add.UseVisualStyleBackColor = true;
            Add.Click += button1_Click;
            // 
            // txtartist
            // 
            txtartist.Location = new Point(116, 35);
            txtartist.Name = "txtartist";
            txtartist.Size = new Size(125, 27);
            txtartist.TabIndex = 1;
            txtartist.TextChanged += textBox1_TextChanged;
            // 
            // Arist
            // 
            Arist.AutoSize = true;
            Arist.Location = new Point(12, 44);
            Arist.Name = "Arist";
            Arist.Size = new Size(88, 20);
            Arist.TabIndex = 2;
            Arist.Text = "Artist Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 44);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 5;
            label1.Text = "Album";
            // 
            // txtalbum
            // 
            txtalbum.Location = new Point(357, 35);
            txtalbum.Name = "txtalbum";
            txtalbum.Size = new Size(125, 27);
            txtalbum.TabIndex = 4;
            // 
            // cmbalbum
            // 
            cmbalbum.FormattingEnabled = true;
            cmbalbum.Location = new Point(664, 26);
            cmbalbum.Name = "cmbalbum";
            cmbalbum.Size = new Size(151, 28);
            cmbalbum.TabIndex = 7;
            // 
            // txtmusic
            // 
            txtmusic.Location = new Point(664, 86);
            txtmusic.Name = "txtmusic";
            txtmusic.Size = new Size(150, 27);
            txtmusic.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 29);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 11;
            label2.Text = "Album";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(596, 86);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 12;
            label4.Text = "Music";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 88);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 13;
            label5.Text = "Bio";
            // 
            // txtbio
            // 
            txtbio.Location = new Point(116, 88);
            txtbio.Name = "txtbio";
            txtbio.Size = new Size(125, 27);
            txtbio.TabIndex = 14;
            // 
            // duration
            // 
            duration.AutoSize = true;
            duration.Location = new Point(582, 149);
            duration.Name = "duration";
            duration.Size = new Size(67, 20);
            duration.TabIndex = 15;
            duration.Text = "Duration";
            // 
            // txtduartion
            // 
            txtduartion.Location = new Point(665, 146);
            txtduartion.Name = "txtduartion";
            txtduartion.Size = new Size(150, 27);
            txtduartion.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(147, 175);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 17;
            button4.Text = "Update artist";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(276, 175);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 18;
            button5.Text = "Delete ";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(582, 313);
            dataGridView1.TabIndex = 23;
            // 
            // button10
            // 
            button10.Location = new Point(411, 175);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 24;
            button10.Text = "Get All";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // chkmusic
            // 
            chkmusic.AutoSize = true;
            chkmusic.Location = new Point(992, 26);
            chkmusic.Name = "chkmusic";
            chkmusic.Size = new Size(69, 24);
            chkmusic.TabIndex = 25;
            chkmusic.Text = "Music";
            chkmusic.UseVisualStyleBackColor = true;
            chkmusic.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkartist
            // 
            chkartist.AutoSize = true;
            chkartist.Location = new Point(992, 69);
            chkartist.Name = "chkartist";
            chkartist.Size = new Size(64, 24);
            chkartist.TabIndex = 26;
            chkartist.Text = "artist";
            chkartist.UseVisualStyleBackColor = true;
            // 
            // chkalbum
            // 
            chkalbum.AutoSize = true;
            chkalbum.Location = new Point(992, 109);
            chkalbum.Name = "chkalbum";
            chkalbum.Size = new Size(73, 24);
            chkalbum.TabIndex = 27;
            chkalbum.Text = "album";
            chkalbum.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 95);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 29;
            label6.Text = "Artist";
            // 
            // cmbartist
            // 
            cmbartist.FormattingEnabled = true;
            cmbartist.Location = new Point(357, 95);
            cmbartist.Name = "cmbartist";
            cmbartist.Size = new Size(125, 28);
            cmbartist.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 595);
            Controls.Add(cmbartist);
            Controls.Add(label6);
            Controls.Add(chkalbum);
            Controls.Add(chkartist);
            Controls.Add(chkmusic);
            Controls.Add(button10);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(txtduartion);
            Controls.Add(duration);
            Controls.Add(txtbio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtmusic);
            Controls.Add(cmbalbum);
            Controls.Add(label1);
            Controls.Add(txtalbum);
            Controls.Add(Arist);
            Controls.Add(txtartist);
            Controls.Add(Add);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add;
        private TextBox txtartist;
        private Label Arist;
        private Label label1;
        private TextBox txtalbum;
        private ComboBox cmbalbum;
        private TextBox txtmusic;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtbio;
        private Label duration;
        private TextBox txtduartion;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private Button button10;
        private CheckBox chkmusic;
        private CheckBox chkartist;
        private CheckBox chkalbum;
        private Label label6;
        private ComboBox cmbartist;
    }
}
