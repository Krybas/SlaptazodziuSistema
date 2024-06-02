namespace SlaptazodziuSistema
{
    partial class Main
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
            btnSearch = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(175, 143, 111);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            btnSearch.Location = new Point(189, 56);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 95);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Paieska";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(175, 143, 111);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            btnUpdate.Location = new Point(189, 170);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 95);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Atnaujinti";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(175, 143, 111);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            btnDelete.Location = new Point(32, 170);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 95);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Istrinti";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(175, 143, 111);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            btnSave.Location = new Point(32, 56);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 95);
            btnSave.TabIndex = 12;
            btnSave.Text = "Issaugoti";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label1.ForeColor = Color.FromArgb(84, 51, 16);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 32);
            label1.TabIndex = 0;
            label1.Text = "Slaptazodziu valdymo sistema";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 244, 225);
            ClientSize = new Size(365, 279);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Label label1;
    }
}
