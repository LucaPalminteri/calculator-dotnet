
namespace Projecto_001
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.Sup = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.usernameTxtCreate = new System.Windows.Forms.TextBox();
            this.passwordTxtCreate = new System.Windows.Forms.TextBox();
            this.passwordTxtCreateTwo = new System.Windows.Forms.TextBox();
            this.ageCreate = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.createAccountPanel = new System.Windows.Forms.Panel();
            this.messageSucces = new System.Windows.Forms.TextBox();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.passwordLabelCreateTwo = new System.Windows.Forms.Label();
            this.passwordLabelCreate = new System.Windows.Forms.Label();
            this.usernameLabelCreate = new System.Windows.Forms.Label();
            this.ageLabelCreate = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.createAccountTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageCreate)).BeginInit();
            this.createAccountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = " Log In UI";
            // 
            // usernameTxt
            // 
            this.usernameTxt.AccessibleName = "usernameTextBox";
            this.usernameTxt.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTxt.Location = new System.Drawing.Point(47, 113);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PlaceholderText = "Username";
            this.usernameTxt.Size = new System.Drawing.Size(223, 27);
            this.usernameTxt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.usernameTxt, "Type Username");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.AccessibleName = "passwordTextBox";
            this.passwordTxt.Location = new System.Drawing.Point(47, 195);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.Size = new System.Drawing.Size(223, 27);
            this.passwordTxt.TabIndex = 4;
            this.toolTip1.SetToolTip(this.passwordTxt, "Type Password");
            // 
            // button1
            // 
            this.button1.AccessibleName = "logInButton";
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(97, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createAccountPanel);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.Sup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 456);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(177, 3);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(71, 29);
            this.logOutBtn.TabIndex = 1;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // Sup
            // 
            this.Sup.AutoSize = true;
            this.Sup.Location = new System.Drawing.Point(70, 61);
            this.Sup.Name = "Sup";
            this.Sup.Size = new System.Drawing.Size(61, 20);
            this.Sup.TabIndex = 0;
            this.Sup.Text = "Sup Bro";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(14, 89);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PlaceholderText = "Name";
            this.nameTxt.Size = new System.Drawing.Size(125, 27);
            this.nameTxt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nameTxt, "Type Name");
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTxt.Location = new System.Drawing.Point(169, 86);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.PlaceholderText = "Last Name";
            this.lastNameTxt.Size = new System.Drawing.Size(125, 27);
            this.lastNameTxt.TabIndex = 2;
            this.toolTip1.SetToolTip(this.lastNameTxt, "Type Last Name");
            // 
            // usernameTxtCreate
            // 
            this.usernameTxtCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTxtCreate.Location = new System.Drawing.Point(169, 167);
            this.usernameTxtCreate.Name = "usernameTxtCreate";
            this.usernameTxtCreate.PlaceholderText = "Username";
            this.usernameTxtCreate.Size = new System.Drawing.Size(125, 27);
            this.usernameTxtCreate.TabIndex = 3;
            this.toolTip1.SetToolTip(this.usernameTxtCreate, "Type Username");
            // 
            // passwordTxtCreate
            // 
            this.passwordTxtCreate.Location = new System.Drawing.Point(14, 248);
            this.passwordTxtCreate.Name = "passwordTxtCreate";
            this.passwordTxtCreate.PasswordChar = '*';
            this.passwordTxtCreate.PlaceholderText = "Password";
            this.passwordTxtCreate.Size = new System.Drawing.Size(125, 27);
            this.passwordTxtCreate.TabIndex = 4;
            this.toolTip1.SetToolTip(this.passwordTxtCreate, "Type Password");
            // 
            // passwordTxtCreateTwo
            // 
            this.passwordTxtCreateTwo.Location = new System.Drawing.Point(169, 248);
            this.passwordTxtCreateTwo.Name = "passwordTxtCreateTwo";
            this.passwordTxtCreateTwo.PasswordChar = '*';
            this.passwordTxtCreateTwo.PlaceholderText = "Password";
            this.passwordTxtCreateTwo.Size = new System.Drawing.Size(125, 27);
            this.passwordTxtCreateTwo.TabIndex = 5;
            this.toolTip1.SetToolTip(this.passwordTxtCreateTwo, "Type Password");
            // 
            // ageCreate
            // 
            this.ageCreate.Location = new System.Drawing.Point(14, 165);
            this.ageCreate.Name = "ageCreate";
            this.ageCreate.Size = new System.Drawing.Size(125, 27);
            this.ageCreate.TabIndex = 6;
            this.toolTip1.SetToolTip(this.ageCreate, "Type Age");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // createAccountPanel
            // 
            this.createAccountPanel.Controls.Add(this.messageSucces);
            this.createAccountPanel.Controls.Add(this.createAccountBtn);
            this.createAccountPanel.Controls.Add(this.passwordLabelCreateTwo);
            this.createAccountPanel.Controls.Add(this.passwordLabelCreate);
            this.createAccountPanel.Controls.Add(this.usernameLabelCreate);
            this.createAccountPanel.Controls.Add(this.ageLabelCreate);
            this.createAccountPanel.Controls.Add(this.lastNameLabel);
            this.createAccountPanel.Controls.Add(this.firstNameLabel);
            this.createAccountPanel.Controls.Add(this.ageCreate);
            this.createAccountPanel.Controls.Add(this.passwordTxtCreateTwo);
            this.createAccountPanel.Controls.Add(this.passwordTxtCreate);
            this.createAccountPanel.Controls.Add(this.usernameTxtCreate);
            this.createAccountPanel.Controls.Add(this.lastNameTxt);
            this.createAccountPanel.Controls.Add(this.nameTxt);
            this.createAccountPanel.Controls.Add(this.createAccountTitle);
            this.createAccountPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createAccountPanel.Location = new System.Drawing.Point(0, 0);
            this.createAccountPanel.Name = "createAccountPanel";
            this.createAccountPanel.Size = new System.Drawing.Size(330, 456);
            this.createAccountPanel.TabIndex = 8;
            this.createAccountPanel.Visible = false;
            // 
            // messageSucces
            // 
            this.messageSucces.BackColor = System.Drawing.SystemColors.Highlight;
            this.messageSucces.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageSucces.Location = new System.Drawing.Point(6, 190);
            this.messageSucces.Name = "messageSucces";
            this.messageSucces.Size = new System.Drawing.Size(300, 39);
            this.messageSucces.TabIndex = 14;
            this.messageSucces.Text = "Account Created Succesfully";
            this.messageSucces.Visible = false;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccountBtn.Location = new System.Drawing.Point(36, 322);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(234, 70);
            this.createAccountBtn.TabIndex = 13;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // passwordLabelCreateTwo
            // 
            this.passwordLabelCreateTwo.AutoSize = true;
            this.passwordLabelCreateTwo.Location = new System.Drawing.Point(167, 222);
            this.passwordLabelCreateTwo.Name = "passwordLabelCreateTwo";
            this.passwordLabelCreateTwo.Size = new System.Drawing.Size(93, 20);
            this.passwordLabelCreateTwo.TabIndex = 12;
            this.passwordLabelCreateTwo.Text = "Re-Password";
            // 
            // passwordLabelCreate
            // 
            this.passwordLabelCreate.AutoSize = true;
            this.passwordLabelCreate.Location = new System.Drawing.Point(12, 222);
            this.passwordLabelCreate.Name = "passwordLabelCreate";
            this.passwordLabelCreate.Size = new System.Drawing.Size(70, 20);
            this.passwordLabelCreate.TabIndex = 11;
            this.passwordLabelCreate.Text = "Password";
            // 
            // usernameLabelCreate
            // 
            this.usernameLabelCreate.AutoSize = true;
            this.usernameLabelCreate.Location = new System.Drawing.Point(169, 142);
            this.usernameLabelCreate.Name = "usernameLabelCreate";
            this.usernameLabelCreate.Size = new System.Drawing.Size(75, 20);
            this.usernameLabelCreate.TabIndex = 10;
            this.usernameLabelCreate.Text = "Username";
            // 
            // ageLabelCreate
            // 
            this.ageLabelCreate.AutoSize = true;
            this.ageLabelCreate.Location = new System.Drawing.Point(12, 142);
            this.ageLabelCreate.Name = "ageLabelCreate";
            this.ageLabelCreate.Size = new System.Drawing.Size(36, 20);
            this.ageLabelCreate.TabIndex = 9;
            this.ageLabelCreate.Text = "Age";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(169, 61);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(79, 20);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 61);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 20);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First Name";
            // 
            // createAccountTitle
            // 
            this.createAccountTitle.AutoSize = true;
            this.createAccountTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccountTitle.Location = new System.Drawing.Point(14, 12);
            this.createAccountTitle.Name = "createAccountTitle";
            this.createAccountTitle.Size = new System.Drawing.Size(197, 37);
            this.createAccountTitle.TabIndex = 0;
            this.createAccountTitle.Text = "Create Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 456);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Log In";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageCreate)).EndInit();
            this.createAccountPanel.ResumeLayout(false);
            this.createAccountPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Sup;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel createAccountPanel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.NumericUpDown ageCreate;
        private System.Windows.Forms.TextBox passwordTxtCreateTwo;
        private System.Windows.Forms.TextBox passwordTxtCreate;
        private System.Windows.Forms.TextBox usernameTxtCreate;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label createAccountTitle;
        private System.Windows.Forms.Label ageLabelCreate;
        private System.Windows.Forms.Label passwordLabelCreate;
        private System.Windows.Forms.Label usernameLabelCreate;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.Label passwordLabelCreateTwo;
        private System.Windows.Forms.TextBox messageSucces;
    }
}

