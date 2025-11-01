using System;
using System.Drawing;

namespace ReaLTaiizor.UI
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.nightForm1 = new ReaLTaiizor.Forms.NightForm();
            this.radioButton1 = new ReaLTaiizor.Controls.RadioButton();
            this.radioButton2 = new ReaLTaiizor.Controls.RadioButton();
            this.toggleButton4 = new ReaLTaiizor.Controls.ToggleButton();
            this.toggleButton3 = new ReaLTaiizor.Controls.ToggleButton();
            this.toggleButton2 = new ReaLTaiizor.Controls.ToggleButton();
            this.toggleButton1 = new ReaLTaiizor.Controls.ToggleButton();
            this.checkBox1 = new ReaLTaiizor.Controls.CheckBox();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.nightForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nightForm1
            // 
            this.nightForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.nightForm1.Controls.Add(this.radioButton1);
            this.nightForm1.Controls.Add(this.radioButton2);
            this.nightForm1.Controls.Add(this.toggleButton4);
            this.nightForm1.Controls.Add(this.toggleButton3);
            this.nightForm1.Controls.Add(this.toggleButton2);
            this.nightForm1.Controls.Add(this.toggleButton1);
            this.nightForm1.Controls.Add(this.checkBox1);
            this.nightForm1.Controls.Add(this.materialButton1);
            this.nightForm1.Controls.Add(this.nightControlBox1);
            this.nightForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightForm1.DrawIcon = true;
            this.nightForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightForm1.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.nightForm1.Location = new System.Drawing.Point(0, 0);
            this.nightForm1.MinimumSize = new System.Drawing.Size(100, 39);
            this.nightForm1.Name = "nightForm1";
            this.nightForm1.Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            this.nightForm1.Size = new System.Drawing.Size(827, 389);
            this.nightForm1.TabIndex = 0;
            this.nightForm1.Text = "Demo";
            this.nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.nightForm1.TitleBarTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.radioButton1.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.radioButton1.Location = new System.Drawing.Point(191, 127);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 17);
            this.radioButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.radioButton1.TabIndex = 53;
            this.radioButton1.Text = "radioButton1";
            // 
            // radioButton2
            // 
            this.radioButton2.Checked = false;
            this.radioButton2.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.radioButton2.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.radioButton2.Location = new System.Drawing.Point(292, 127);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 17);
            this.radioButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.radioButton2.TabIndex = 52;
            this.radioButton2.Text = "radioButton2";
            // 
            // toggleButton4
            // 
            this.toggleButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton4.Location = new System.Drawing.Point(191, 220);
            this.toggleButton4.Name = "toggleButton4";
            this.toggleButton4.Size = new System.Drawing.Size(76, 33);
            this.toggleButton4.TabIndex = 51;
            this.toggleButton4.Text = "toggleButton4";
            this.toggleButton4.Toggled = false;
            this.toggleButton4.Type = ReaLTaiizor.Controls.ToggleButton._Type.IO;
            // 
            // toggleButton3
            // 
            this.toggleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton3.Location = new System.Drawing.Point(279, 220);
            this.toggleButton3.Name = "toggleButton3";
            this.toggleButton3.Size = new System.Drawing.Size(76, 33);
            this.toggleButton3.TabIndex = 50;
            this.toggleButton3.Text = "toggleButton3";
            this.toggleButton3.Toggled = false;
            this.toggleButton3.Type = ReaLTaiizor.Controls.ToggleButton._Type.YesNo;
            // 
            // toggleButton2
            // 
            this.toggleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton2.Location = new System.Drawing.Point(277, 175);
            this.toggleButton2.Name = "toggleButton2";
            this.toggleButton2.Size = new System.Drawing.Size(76, 33);
            this.toggleButton2.TabIndex = 49;
            this.toggleButton2.Text = "toggleButton2";
            this.toggleButton2.Toggled = false;
            this.toggleButton2.Type = ReaLTaiizor.Controls.ToggleButton._Type.OnOff;
            // 
            // toggleButton1
            // 
            this.toggleButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.toggleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton1.Location = new System.Drawing.Point(195, 175);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(76, 33);
            this.toggleButton1.TabIndex = 48;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.Toggled = false;
            this.toggleButton1.Type = ReaLTaiizor.Controls.ToggleButton._Type.CheckMark;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.checkBox1.Checked = false;
            this.checkBox1.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.checkBox1.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.checkBox1.CheckedDisabledColor = System.Drawing.Color.Gray;
            this.checkBox1.CheckedEnabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Enable = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.checkBox1.Location = new System.Drawing.Point(191, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 16);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "checkBox1";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(464, 175);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(148, 36);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "点击修改窗体配色";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(688, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 389);
            this.Controls.Add(this.nightForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 709);
            this.Name = "Simple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nightForm1.ResumeLayout(false);
            this.nightForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Forms.NightForm nightForm1;
        private Controls.NightControlBox nightControlBox1;
        private Controls.MaterialButton materialButton1;
        private Controls.RadioButton radioButton1;
        private Controls.RadioButton radioButton2;
        private Controls.ToggleButton toggleButton4;
        private Controls.ToggleButton toggleButton3;
        private Controls.ToggleButton toggleButton2;
        private Controls.ToggleButton toggleButton1;
        private Controls.CheckBox checkBox1;
    }
}