﻿namespace QuanLyQuanCaPhe
{
    partial class fAccountInfo
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
            txbUserName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbDisplayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbNew_PassWord = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbReType_PassWord = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbUserName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 49);
            panel1.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(237, 11);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(408, 27);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(159, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbDisplayName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(648, 49);
            panel2.TabIndex = 1;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(237, 11);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(408, 27);
            txbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(648, 49);
            panel3.TabIndex = 2;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(237, 11);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(408, 27);
            txbPassWord.TabIndex = 1;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(104, 24);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNew_PassWord);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 177);
            panel4.Name = "panel4";
            panel4.Size = new Size(648, 49);
            panel4.TabIndex = 3;
            // 
            // txbNew_PassWord
            // 
            txbNew_PassWord.Location = new Point(237, 11);
            txbNew_PassWord.Name = "txbNew_PassWord";
            txbNew_PassWord.Size = new Size(408, 27);
            txbNew_PassWord.TabIndex = 1;
            txbNew_PassWord.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(146, 24);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReType_PassWord);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 232);
            panel5.Name = "panel5";
            panel5.Size = new Size(648, 49);
            panel5.TabIndex = 4;
            // 
            // txbReType_PassWord
            // 
            txbReType_PassWord.Location = new Point(237, 11);
            txbReType_PassWord.Name = "txbReType_PassWord";
            txbReType_PassWord.Size = new Size(408, 27);
            txbReType_PassWord.TabIndex = 1;
            txbReType_PassWord.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 11);
            label5.Name = "label5";
            label5.Size = new Size(228, 24);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại mật khẩu mới:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(379, 300);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 41);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(546, 300);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 41);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fAccountInfo
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(672, 355);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fAccountInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel2;
        private TextBox txbDisplayName;
        private Label label2;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label label3;
        private Panel panel4;
        private TextBox txbNew_PassWord;
        private Label label4;
        private Panel panel5;
        private TextBox txbReType_PassWord;
        private Label label5;
        private Button btnUpdate;
        private Button btnExit;
    }
}