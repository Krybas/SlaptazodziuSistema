namespace SlaptazodziuSistema
{
    partial class SaveForm
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
            label1 = new Label();
            txtComment = new TextBox();
            txtURL = new TextBox();
            txtPassword = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSave = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label1.ForeColor = Color.FromArgb(84, 51, 16);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 0;
            label1.Text = "Issaugoti slaptazodi faile:";
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            txtComment.ForeColor = Color.FromArgb(84, 51, 16);
            txtComment.Location = new Point(8, 296);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(149, 29);
            txtComment.TabIndex = 16;
            // 
            // txtURL
            // 
            txtURL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            txtURL.ForeColor = Color.FromArgb(84, 51, 16);
            txtURL.Location = new Point(12, 223);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(149, 29);
            txtURL.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            txtPassword.ForeColor = Color.FromArgb(84, 51, 16);
            txtPassword.Location = new Point(12, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(149, 29);
            txtPassword.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            txtName.ForeColor = Color.FromArgb(84, 51, 16);
            txtName.Location = new Point(12, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 29);
            txtName.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(84, 51, 16);
            label5.Location = new Point(8, 268);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 12;
            label5.Text = "Komentaras:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(84, 51, 16);
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 11;
            label4.Text = "URL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(84, 51, 16);
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 10;
            label3.Text = "Slaptazodis:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(84, 51, 16);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 9;
            label2.Text = "Pavadinimas:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(175, 143, 111);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            btnSave.Location = new Point(12, 343);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(253, 54);
            btnSave.TabIndex = 17;
            btnSave.Text = "Issaugoti";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(175, 143, 111);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            button1.Location = new Point(182, 403);
            button1.Name = "button1";
            button1.Size = new Size(84, 40);
            button1.TabIndex = 18;
            button1.Text = "Gristi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SaveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 244, 225);
            ClientSize = new Size(278, 454);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(txtComment);
            Controls.Add(txtURL);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SaveForm";
            Text = "SaveForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtComment;
        private TextBox txtURL;
        private TextBox txtPassword;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSave;
        private Button button1;
    }
}