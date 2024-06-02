namespace SlaptazodziuSistema
{
    partial class UpdateForm
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
            button1 = new Button();
            btnUpdate = new Button();
            txtPassword = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(175, 143, 111);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15.75F);
            button1.Location = new Point(182, 245);
            button1.Name = "button1";
            button1.Size = new Size(84, 42);
            button1.TabIndex = 25;
            button1.Text = "Gristi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(175, 143, 111);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 15.75F);
            btnUpdate.Location = new Point(12, 185);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(254, 54);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Issaugoti";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            txtPassword.ForeColor = Color.FromArgb(84, 51, 16);
            txtPassword.Location = new Point(12, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(149, 29);
            txtPassword.TabIndex = 23;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            txtName.ForeColor = Color.FromArgb(84, 51, 16);
            txtName.Location = new Point(12, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 29);
            txtName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(84, 51, 16);
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 21;
            label3.Text = "Slaptazodis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(84, 51, 16);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 20;
            label2.Text = "Pavadinimas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label1.ForeColor = Color.FromArgb(84, 51, 16);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 30);
            label1.TabIndex = 19;
            label1.Text = "Atnaujinti slaptazodi faile:";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 244, 225);
            ClientSize = new Size(278, 298);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateForm";
            Text = "UpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnUpdate;
        private TextBox txtPassword;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}