namespace Project_Constantin_Ioan
{
    partial class SubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubForm));
            this.close = new System.Windows.Forms.Button();
            this.lvSub = new System.Windows.Forms.ListView();
            this.ClientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(28, 326);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(125, 36);
            this.close.TabIndex = 0;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // lvSub
            // 
            this.lvSub.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.ClientId,
            this.columnHeader1});
            this.lvSub.GridLines = true;
            this.lvSub.HideSelection = false;
            this.lvSub.Location = new System.Drawing.Point(50, 86);
            this.lvSub.Name = "lvSub";
            this.lvSub.Size = new System.Drawing.Size(653, 163);
            this.lvSub.TabIndex = 1;
            this.lvSub.UseCompatibleStateImageBehavior = false;
            this.lvSub.View = System.Windows.Forms.View.Details;
            // 
            // ClientId
            // 
            this.ClientId.DisplayIndex = 0;
            this.ClientId.Text = "Client Id";
            this.ClientId.Width = 190;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "ExtraOption Id";
            this.columnHeader1.Width = 269;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Subscription Id";
            this.columnHeader2.Width = 190;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(256, 29);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(223, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 374);
            this.Controls.Add(this.add);
            this.Controls.Add(this.lvSub);
            this.Controls.Add(this.close);
            this.Name = "SubForm";
            this.Text = "SubForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ListView lvSub;
        private System.Windows.Forms.ColumnHeader ClientId;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button add;
    }
}