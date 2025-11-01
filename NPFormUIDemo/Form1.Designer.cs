namespace ReaLTaiizor_CR
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTextBox1 = new ReaLTaiizor.Controls.MaterialTextBox();
            this.materialTextBox2 = new ReaLTaiizor.Controls.MaterialTextBox();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialTextBox3 = new ReaLTaiizor.Controls.MaterialTextBox();
            this.materialSingleTextBox1 = new ReaLTaiizor.Controls.MaterialSingleTextBox();
            this.SuspendLayout();
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox1.Hint = "name";
            this.materialTextBox1.Location = new System.Drawing.Point(12, 78);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(291, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "jack";
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox2.Hint = "password";
            this.materialTextBox2.Location = new System.Drawing.Point(12, 130);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Password = true;
            this.materialTextBox2.Size = new System.Drawing.Size(291, 50);
            this.materialTextBox2.TabIndex = 1;
            this.materialTextBox2.Text = "pass";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(160, 226);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(117, 36);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "button test";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.MaterialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(328, 226);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(124, 36);
            this.materialButton2.TabIndex = 10;
            this.materialButton2.Text = "button demo";
            this.materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.materialTextBox3.Hint = "53X";
            this.materialTextBox3.Location = new System.Drawing.Point(328, 92);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(291, 36);
            this.materialTextBox3.TabIndex = 11;
            this.materialTextBox3.Text = "name";
            this.materialTextBox3.UseTallSize = false;
            // 
            // materialSingleTextBox1
            // 
            this.materialSingleTextBox1.Depth = 0;
            this.materialSingleTextBox1.Hint = "";
            this.materialSingleTextBox1.Location = new System.Drawing.Point(328, 155);
            this.materialSingleTextBox1.MaxLength = 32767;
            this.materialSingleTextBox1.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialSingleTextBox1.Name = "materialSingleTextBox1";
            this.materialSingleTextBox1.PasswordChar = '\0';
            this.materialSingleTextBox1.SelectedText = "";
            this.materialSingleTextBox1.SelectionLength = 0;
            this.materialSingleTextBox1.SelectionStart = 0;
            this.materialSingleTextBox1.Size = new System.Drawing.Size(291, 25);
            this.materialSingleTextBox1.TabIndex = 14;
            this.materialSingleTextBox1.TabStop = false;
            this.materialSingleTextBox1.Text = "TextBox1";
            this.materialSingleTextBox1.UseSystemPasswordChar = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 343);
            this.Controls.Add(this.materialSingleTextBox1);
            this.Controls.Add(this.materialTextBox3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBox materialTextBox1;
        private ReaLTaiizor.Controls.MaterialTextBox materialTextBox2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialTextBox materialTextBox3;
        private ReaLTaiizor.Controls.MaterialSingleTextBox materialSingleTextBox1;
    }
}