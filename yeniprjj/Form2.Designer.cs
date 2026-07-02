namespace yeniprjj
{
    partial class Form2
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
            lstSonuclar = new ListBox();
            label2 = new Label();
            txtTahmin = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstSonuclar
            // 
            lstSonuclar.BackColor = Color.White;
            lstSonuclar.FormattingEnabled = true;
            lstSonuclar.Location = new Point(245, 49);
            lstSonuclar.Name = "lstSonuclar";
            lstSonuclar.Size = new Size(244, 264);
            lstSonuclar.TabIndex = 9;
            lstSonuclar.SelectedIndexChanged += lstSonuclar_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Location = new Point(55, 250);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 8;
            label2.Text = "kalan tahmin hakkı";
            label2.Click += label2_Click;
            // 
            // txtTahmin
            // 
            txtTahmin.BackColor = Color.LavenderBlush;
            txtTahmin.Location = new Point(55, 67);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(120, 27);
            txtTahmin.TabIndex = 7;
            txtTahmin.TextChanged += txtTahmin_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(55, 118);
            button1.Name = "button1";
            button1.Size = new Size(120, 57);
            button1.TabIndex = 6;
            button1.Text = "try";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Location = new Point(104, 293);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 5;
            label1.Text = "10";
            label1.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 377);
            Controls.Add(lstSonuclar);
            Controls.Add(label2);
            Controls.Add(txtTahmin);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSonuclar;
        private Label label2;
        private TextBox txtTahmin;
        private Button button1;
        private Label label1;
    }
}