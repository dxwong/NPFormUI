namespace ReaLTaiizor
{
    partial class BaseForm
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
            this.btnSysMin = new ReaLTaiizor.NButton();
            this.btnSysMax = new ReaLTaiizor.NButton();
            this.btnSysClose = new ReaLTaiizor.NButton();
            this.btnSysMenu = new ReaLTaiizor.NButton();
            this.SuspendLayout();
            // 
            // btnSysMin
            // 
            this.btnSysMin.BackColor = System.Drawing.Color.Transparent;
            this.btnSysMin.BackgroundImage = global::ReaLTaiizor.Properties.Resources.sysbtn_min_normal;
            this.btnSysMin.ForeColor = System.Drawing.Color.White;
            this.btnSysMin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(54)))), ((int)(((byte)(16)))));
            this.btnSysMin.IsShadow = false;
            this.btnSysMin.Location = new System.Drawing.Point(401, 3);
            this.btnSysMin.Name = "btnSysMin";
            this.btnSysMin.NormaColor = System.Drawing.Color.Transparent;
            this.btnSysMin.Size = new System.Drawing.Size(30, 28);
            this.btnSysMin.TabIndex = 3;
            // 
            // btnSysMax
            // 
            this.btnSysMax.BackColor = System.Drawing.Color.Transparent;
            this.btnSysMax.BackgroundImage = global::ReaLTaiizor.Properties.Resources.sysbtn_max_normal;
            this.btnSysMax.ForeColor = System.Drawing.Color.White;
            this.btnSysMax.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(54)))), ((int)(((byte)(16)))));
            this.btnSysMax.IsShadow = false;
            this.btnSysMax.Location = new System.Drawing.Point(433, 3);
            this.btnSysMax.Name = "btnSysMax";
            this.btnSysMax.NormaColor = System.Drawing.Color.Transparent;
            this.btnSysMax.Size = new System.Drawing.Size(30, 28);
            this.btnSysMax.TabIndex = 2;
            // 
            // btnSysClose
            // 
            this.btnSysClose.BackColor = System.Drawing.Color.Transparent;
            this.btnSysClose.BackgroundImage = global::ReaLTaiizor.Properties.Resources.sysbtn_close_normal;
            this.btnSysClose.ForeColor = System.Drawing.Color.White;
            this.btnSysClose.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(54)))), ((int)(((byte)(16)))));
            this.btnSysClose.IsShadow = false;
            this.btnSysClose.Location = new System.Drawing.Point(465, 3);
            this.btnSysClose.Name = "btnSysClose";
            this.btnSysClose.NormaColor = System.Drawing.Color.Transparent;
            this.btnSysClose.Size = new System.Drawing.Size(30, 28);
            this.btnSysClose.TabIndex = 0;
            // 
            // btnSysMenu
            // 
            this.btnSysMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnSysMenu.BackgroundImage = global::ReaLTaiizor.Properties.Resources.sysbtn_menu_normal;
            this.btnSysMenu.ForeColor = System.Drawing.Color.White;
            this.btnSysMenu.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(54)))), ((int)(((byte)(16)))));
            this.btnSysMenu.IsShadow = false;
            this.btnSysMenu.Location = new System.Drawing.Point(365, 3);
            this.btnSysMenu.Name = "btnSysMenu";
            this.btnSysMenu.NormaColor = System.Drawing.Color.Transparent;
            this.btnSysMenu.Size = new System.Drawing.Size(30, 28);
            this.btnSysMenu.TabIndex = 4;
            this.btnSysMenu.Visible = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 267);
            this.Controls.Add(this.btnSysMenu);
            this.Controls.Add(this.btnSysMin);
            this.Controls.Add(this.btnSysMax);
            this.Controls.Add(this.btnSysClose);
            this.Name = "BaseForm";
            this.ShowIcon = false;
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        public NButton btnSysClose;
        public NButton btnSysMax;
        public NButton btnSysMin;
        public NButton btnSysMenu;
    }
}