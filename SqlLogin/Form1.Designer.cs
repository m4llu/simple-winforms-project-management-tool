﻿namespace SqlLogin
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
            loginButton = new Button();
            loginLabel = new Label();
            loginUsernameLabel = new Label();
            loginUsernameBox = new TextBox();
            loginPasswordLabel = new Label();
            loginPasswordBox = new TextBox();
            splitContainer1 = new SplitContainer();
            createButton = new Label();
            panel1 = new Panel();
            closeButton = new Label();
            registerUsernameBox = new TextBox();
            registerLabel = new Label();
            registerPasswordBox = new TextBox();
            registerButton = new Button();
            emailLabel = new Label();
            registerUsernameLabel = new Label();
            emailBox = new TextBox();
            registerPasswordLabel = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(32, 39, 52);
            loginButton.FlatAppearance.BorderColor = Color.White;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.FromArgb(255, 192, 192);
            loginButton.Location = new Point(21, 224);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(251, 43);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginBtn_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Microsoft Sans Serif", 20.25F);
            loginLabel.ForeColor = SystemColors.ControlLightLight;
            loginLabel.Location = new Point(10, 27);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(110, 39);
            loginLabel.TabIndex = 24;
            loginLabel.Text = "Login.";
            loginLabel.Click += label4_Click;
            // 
            // loginUsernameLabel
            // 
            loginUsernameLabel.AutoSize = true;
            loginUsernameLabel.Font = new Font("Microsoft Sans Serif", 12F);
            loginUsernameLabel.ForeColor = SystemColors.ButtonHighlight;
            loginUsernameLabel.Location = new Point(21, 85);
            loginUsernameLabel.Name = "loginUsernameLabel";
            loginUsernameLabel.Size = new Size(102, 25);
            loginUsernameLabel.TabIndex = 16;
            loginUsernameLabel.Text = "Username";
            // 
            // loginUsernameBox
            // 
            loginUsernameBox.Font = new Font("Segoe UI", 12F);
            loginUsernameBox.Location = new Point(21, 109);
            loginUsernameBox.Margin = new Padding(3, 4, 3, 4);
            loginUsernameBox.Name = "loginUsernameBox";
            loginUsernameBox.Size = new Size(251, 34);
            loginUsernameBox.TabIndex = 17;
            // 
            // loginPasswordLabel
            // 
            loginPasswordLabel.AutoSize = true;
            loginPasswordLabel.Font = new Font("Microsoft Sans Serif", 12F);
            loginPasswordLabel.ForeColor = SystemColors.ButtonHighlight;
            loginPasswordLabel.Location = new Point(21, 147);
            loginPasswordLabel.Name = "loginPasswordLabel";
            loginPasswordLabel.Size = new Size(98, 25);
            loginPasswordLabel.TabIndex = 19;
            loginPasswordLabel.Text = "Password";
            // 
            // loginPasswordBox
            // 
            loginPasswordBox.Font = new Font("Segoe UI", 12F);
            loginPasswordBox.Location = new Point(21, 171);
            loginPasswordBox.Margin = new Padding(3, 4, 3, 4);
            loginPasswordBox.Name = "loginPasswordBox";
            loginPasswordBox.Size = new Size(251, 34);
            loginPasswordBox.TabIndex = 20;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(1, -3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(21, 21, 28);
            splitContainer1.Panel1.Controls.Add(createButton);
            splitContainer1.Panel1.Controls.Add(loginLabel);
            splitContainer1.Panel1.Controls.Add(loginPasswordLabel);
            splitContainer1.Panel1.Controls.Add(loginButton);
            splitContainer1.Panel1.Controls.Add(loginUsernameLabel);
            splitContainer1.Panel1.Controls.Add(loginPasswordBox);
            splitContainer1.Panel1.Controls.Add(loginUsernameBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(16, 17, 23);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(859, 528);
            splitContainer1.SplitterDistance = 285;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 25;
            // 
            // createButton
            // 
            createButton.AutoSize = true;
            createButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createButton.ForeColor = SystemColors.ButtonHighlight;
            createButton.Location = new Point(21, 283);
            createButton.Name = "createButton";
            createButton.Size = new Size(251, 20);
            createButton.TabIndex = 25;
            createButton.Text = "Don't have an account? Create one.";
            createButton.Click += label3_Click;
            createButton.MouseEnter += label3_MouseEnter;
            createButton.MouseLeave += label3_MouseLeave;
            // 
            // panel1
            // 
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(registerUsernameBox);
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(registerPasswordBox);
            panel1.Controls.Add(registerButton);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(registerUsernameLabel);
            panel1.Controls.Add(emailBox);
            panel1.Controls.Add(registerPasswordLabel);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(17, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 272);
            panel1.TabIndex = 17;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Font = new Font("Impact", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(342, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(37, 42);
            closeButton.TabIndex = 18;
            closeButton.Text = "<";
            closeButton.Click += label6_Click;
            closeButton.MouseEnter += label6_MouseEnter;
            closeButton.MouseLeave += label6_MouseLeave;
            // 
            // registerUsernameBox
            // 
            registerUsernameBox.Font = new Font("Segoe UI", 12F);
            registerUsernameBox.Location = new Point(13, 93);
            registerUsernameBox.Margin = new Padding(3, 4, 3, 4);
            registerUsernameBox.Name = "registerUsernameBox";
            registerUsernameBox.Size = new Size(159, 34);
            registerUsernameBox.TabIndex = 22;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Microsoft Sans Serif", 20.25F);
            registerLabel.ForeColor = SystemColors.ControlLightLight;
            registerLabel.Location = new Point(13, 13);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(303, 39);
            registerLabel.TabIndex = 15;
            registerLabel.Text = "Create an account.";
            registerLabel.Click += label5_Click;
            // 
            // registerPasswordBox
            // 
            registerPasswordBox.Font = new Font("Segoe UI", 12F);
            registerPasswordBox.Location = new Point(207, 93);
            registerPasswordBox.Margin = new Padding(3, 4, 3, 4);
            registerPasswordBox.Name = "registerPasswordBox";
            registerPasswordBox.Size = new Size(159, 34);
            registerPasswordBox.TabIndex = 24;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(32, 39, 52);
            registerButton.FlatAppearance.BorderColor = Color.White;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.ForeColor = Color.FromArgb(255, 192, 192);
            registerButton.Location = new Point(257, 209);
            registerButton.Margin = new Padding(3, 4, 3, 4);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(109, 43);
            registerButton.TabIndex = 8;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 12F);
            emailLabel.ForeColor = SystemColors.ButtonHighlight;
            emailLabel.Location = new Point(13, 132);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(60, 25);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email";
            // 
            // registerUsernameLabel
            // 
            registerUsernameLabel.AutoSize = true;
            registerUsernameLabel.Font = new Font("Microsoft Sans Serif", 12F);
            registerUsernameLabel.ForeColor = SystemColors.ButtonHighlight;
            registerUsernameLabel.Location = new Point(13, 69);
            registerUsernameLabel.Name = "registerUsernameLabel";
            registerUsernameLabel.Size = new Size(102, 25);
            registerUsernameLabel.TabIndex = 21;
            registerUsernameLabel.Text = "Username";
            // 
            // emailBox
            // 
            emailBox.Font = new Font("Segoe UI", 12F);
            emailBox.Location = new Point(13, 156);
            emailBox.Margin = new Padding(3, 4, 3, 4);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(353, 34);
            emailBox.TabIndex = 12;
            // 
            // registerPasswordLabel
            // 
            registerPasswordLabel.AutoSize = true;
            registerPasswordLabel.Font = new Font("Microsoft Sans Serif", 12F);
            registerPasswordLabel.ForeColor = SystemColors.ButtonHighlight;
            registerPasswordLabel.Location = new Point(207, 69);
            registerPasswordLabel.Name = "registerPasswordLabel";
            registerPasswordLabel.Size = new Size(98, 25);
            registerPasswordLabel.TabIndex = 23;
            registerPasswordLabel.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ControlLightLight;
            checkBox1.Location = new Point(13, 219);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(238, 24);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "I agree to sell my data to China";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 325);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button loginButton;
        private Label loginLabel;
        private Label loginUsernameLabel;
        private TextBox loginUsernameBox;
        private Label loginPasswordLabel;
        private TextBox loginPasswordBox;
        private SplitContainer splitContainer1;
        private Label createButton;
        private Panel panel1;
        private TextBox registerUsernameBox;
        private Label registerLabel;
        private TextBox registerPasswordBox;
        private Button registerButton;
        private Label emailLabel;
        private Label registerUsernameLabel;
        private TextBox emailBox;
        private Label registerPasswordLabel;
        private CheckBox checkBox1;
        private Label closeButton;
    }
}
