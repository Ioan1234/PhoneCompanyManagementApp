namespace Project_Constantin_Ioan
{
    partial class LoginData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlPassword = new System.Windows.Forms.TextBox();
            this.ctrlUsername = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(37, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // ctrlPassword
            // 
            this.ctrlPassword.Location = new System.Drawing.Point(154, 154);
            this.ctrlPassword.Name = "ctrlPassword";
            this.ctrlPassword.Size = new System.Drawing.Size(164, 22);
            this.ctrlPassword.TabIndex = 15;
            this.ctrlPassword.TextChanged += new System.EventHandler(this.ctrlPassword_TextChanged);
            // 
            // ctrlUsername
            // 
            this.ctrlUsername.Location = new System.Drawing.Point(154, 71);
            this.ctrlUsername.Name = "ctrlUsername";
            this.ctrlUsername.Size = new System.Drawing.Size(164, 22);
            this.ctrlUsername.TabIndex = 16;
            this.ctrlUsername.TextChanged += new System.EventHandler(this.ctrlUsername_TextChanged_1);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.login.ForeColor = System.Drawing.Color.Black;
            this.login.Location = new System.Drawing.Point(188, 234);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(151, 31);
            this.login.TabIndex = 13;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // LoginData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ctrlUsername);
            this.Controls.Add(this.ctrlPassword);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginData";
            this.Size = new System.Drawing.Size(518, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctrlPassword;
        private System.Windows.Forms.TextBox ctrlUsername;
        private System.Windows.Forms.Button login;
    }
}
