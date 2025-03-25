namespace QuanLyQuanCaPhe
{
    partial class fLogin
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
            panel1 = new Panel();
            btnLogin = new Button();
            btnExit = new Button();
            panel3 = new Panel();
            txtPassWord = new TextBox();
            lblPassWord = new Label();
            panel2 = new Panel();
            txtUserName = new TextBox();
            lblUserName = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 182);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(349, 127);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 41);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(474, 127);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 41);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPassWord);
            panel3.Controls.Add(lblPassWord);
            panel3.Location = new Point(3, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 53);
            panel3.TabIndex = 1;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(180, 10);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(389, 27);
            txtPassWord.TabIndex = 2;
            txtPassWord.Text = "1";
            txtPassWord.UseSystemPasswordChar = true;
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassWord.Location = new Point(15, 13);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(104, 24);
            lblPassWord.TabIndex = 0;
            lblPassWord.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(lblUserName);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 53);
            panel2.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(180, 10);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(389, 27);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "ad1";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(15, 13);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(159, 24);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Tên đăng nhập:";
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(610, 206);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtUserName;
        private Label lblUserName;
        private Panel panel3;
        private TextBox txtPassWord;
        private Label lblPassWord;
        private Button btnLogin;
        private Button btnExit;
    }
}
