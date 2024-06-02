namespace SlaptazodziuSistema
{
    partial class DeleteForm
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
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            txtName.ForeColor = Color.FromArgb(84, 51, 16);
            txtName.Location = new Point(12, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 29);
            txtName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 186);
            label2.ForeColor = Color.FromArgb(84, 51, 16);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 6;
            label2.Text = "Pavadinimas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label1.ForeColor = Color.FromArgb(84, 51, 16);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 30);
            label1.TabIndex = 18;
            label1.Text = "Istrinti slaptazodi is failo:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(175, 143, 111);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 15.75F);
            btnDelete.Location = new Point(12, 111);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(242, 54);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Istrinti";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(175, 143, 111);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15.75F);
            button1.Location = new Point(170, 171);
            button1.Name = "button1";
            button1.Size = new Size(84, 44);
            button1.TabIndex = 20;
            button1.Text = "Gristi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 244, 225);
            ClientSize = new Size(266, 225);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(label2);
            Name = "DeleteForm";
            Text = "DeleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Button button1;
    }
}