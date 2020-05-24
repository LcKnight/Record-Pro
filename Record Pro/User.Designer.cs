namespace Record_Pro
{
    partial class User
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
            this.GetList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetList
            // 
            this.GetList.Location = new System.Drawing.Point(78, 89);
            this.GetList.Name = "GetList";
            this.GetList.Size = new System.Drawing.Size(75, 23);
            this.GetList.TabIndex = 0;
            this.GetList.Text = "button1";
            this.GetList.UseVisualStyleBackColor = true;
            this.GetList.Click += new System.EventHandler(this.GetList_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetList);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetList;
    }
}