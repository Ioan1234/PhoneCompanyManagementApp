using System;

namespace Project_Constantin_Ioan
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.ctrlLastName = new System.Windows.Forms.TextBox();
            this.ctrlFirstName = new System.Windows.Forms.TextBox();
            this.ctrlSsn = new System.Windows.Forms.TextBox();
            this.ctrlAddress = new System.Windows.Forms.TextBox();
            this.ctrlPhoneNumber = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(61, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(61, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "FirstName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(61, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ssn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(61, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(61, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(12, 367);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(99, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            this.cancel.MouseLeave += new System.EventHandler(this.cancel_MouseLeave);
            this.cancel.MouseHover += new System.EventHandler(this.cancel_MouseHover);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.Transparent;
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.ForeColor = System.Drawing.Color.Black;
            this.ok.Location = new System.Drawing.Point(677, 363);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(94, 30);
            this.ok.TabIndex = 9;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            this.ok.MouseLeave += new System.EventHandler(this.ok_MouseLeave);
            this.ok.MouseHover += new System.EventHandler(this.ok_MouseHover);
            // 
            // ctrlLastName
            // 
            this.ctrlLastName.Location = new System.Drawing.Point(190, 50);
            this.ctrlLastName.Name = "ctrlLastName";
            this.ctrlLastName.Size = new System.Drawing.Size(177, 22);
            this.ctrlLastName.TabIndex = 11;
            this.ctrlLastName.TextChanged += new System.EventHandler(this.ctrlLastName_TextChanged);
            this.ctrlLastName.MouseLeave += new System.EventHandler(this.ctrlLastName_MouseLeave);
            this.ctrlLastName.MouseHover += new System.EventHandler(this.ctrlLastName_MouseHover);
            // 
            // ctrlFirstName
            // 
            this.ctrlFirstName.Location = new System.Drawing.Point(190, 103);
            this.ctrlFirstName.Name = "ctrlFirstName";
            this.ctrlFirstName.Size = new System.Drawing.Size(227, 22);
            this.ctrlFirstName.TabIndex = 12;
            this.ctrlFirstName.MouseLeave += new System.EventHandler(this.ctrlFirstName_MouseLeave);
            this.ctrlFirstName.MouseHover += new System.EventHandler(this.ctrlFirstName_MouseHover);
            // 
            // ctrlSsn
            // 
            this.ctrlSsn.Location = new System.Drawing.Point(190, 160);
            this.ctrlSsn.Name = "ctrlSsn";
            this.ctrlSsn.Size = new System.Drawing.Size(191, 22);
            this.ctrlSsn.TabIndex = 13;
            this.ctrlSsn.TextChanged += new System.EventHandler(this.ctrlSsn_TextChanged);
            this.ctrlSsn.MouseLeave += new System.EventHandler(this.ctrlSsn_MouseLeave);
            this.ctrlSsn.MouseHover += new System.EventHandler(this.ctrlSsn_MouseHover);
            // 
            // ctrlAddress
            // 
            this.ctrlAddress.Location = new System.Drawing.Point(190, 214);
            this.ctrlAddress.Multiline = true;
            this.ctrlAddress.Name = "ctrlAddress";
            this.ctrlAddress.Size = new System.Drawing.Size(339, 46);
            this.ctrlAddress.TabIndex = 14;
            this.ctrlAddress.MouseLeave += new System.EventHandler(this.ctrlAddress_MouseLeave);
            this.ctrlAddress.MouseHover += new System.EventHandler(this.ctrlAddress_MouseHover);
            // 
            // ctrlPhoneNumber
            // 
            this.ctrlPhoneNumber.Location = new System.Drawing.Point(190, 293);
            this.ctrlPhoneNumber.Name = "ctrlPhoneNumber";
            this.ctrlPhoneNumber.Size = new System.Drawing.Size(227, 22);
            this.ctrlPhoneNumber.TabIndex = 15;
            this.ctrlPhoneNumber.MouseLeave += new System.EventHandler(this.ctrlPhoneNumber_MouseLeave);
            this.ctrlPhoneNumber.MouseHover += new System.EventHandler(this.ctrlPhoneNumber_MouseHover);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(25, 20);
            this.toolStripStatusLabel1.Text = "    ";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ctrlPhoneNumber);
            this.Controls.Add(this.ctrlAddress);
            this.Controls.Add(this.ctrlSsn);
            this.Controls.Add(this.ctrlFirstName);
            this.Controls.Add(this.ctrlLastName);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox ctrlLastName;
        private System.Windows.Forms.TextBox ctrlFirstName;
        private System.Windows.Forms.TextBox ctrlSsn;
        private System.Windows.Forms.TextBox ctrlAddress;
        private System.Windows.Forms.TextBox ctrlPhoneNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private EventHandler toolStripStatusLabel1_Click;
    }
}