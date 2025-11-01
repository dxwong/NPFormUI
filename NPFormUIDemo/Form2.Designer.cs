namespace ReaLTaiizor_CR
{
    partial class Form2
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
            this.SuspendLayout();
            // 
            // btnSysClose
            // 
            this.btnSysClose.Location = new System.Drawing.Point(684, 1);
            // 
            // btnSysMax
            // 
            this.btnSysMax.Location = new System.Drawing.Point(654, 1);
            // 
            // btnSysMin
            // 
            this.btnSysMin.Location = new System.Drawing.Point(624, 1);
            // 
            // btnSysMenu
            // 
            this.btnSysMenu.Location = new System.Drawing.Point(594, 1);
            this.btnSysMenu.Click += new System.EventHandler(this.btnSysMenu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(714, 347);
            //this.HeaderHeight2 = 100;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(111, 82);
            this.Name = "Form2";
            this.Text = "系统参数设置";
            this.ResumeLayout(false);

        }

        #endregion
    }
}