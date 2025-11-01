#region Imports

using System;
using System.Linq;
using System.Drawing;
using ReaLTaiizor.Utils;
using System.Diagnostics;
using ReaLTaiizor.Controls;
using System.Windows.Forms;
using System.Globalization;
using System.ComponentModel;
using static ReaLTaiizor.Helpers.MaterialDrawHelper;

#endregion

namespace ReaLTaiizor.Forms
{
    #region MaterialFlexibleForm

    public class MaterialFlexibleForm : MaterialForm, MaterialControlI
    {
        private readonly MaterialManager MaterialManager;

        public static Font FONT;

        public static double MAX_WIDTH_FACTOR = 0.7;

        public static double MAX_HEIGHT_FACTOR = 0.9;

        private MaterialRichTextBox richTextBoxMessage;

        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.leftButton = new ReaLTaiizor.Controls.MaterialButton();
            this.MaterialFlexibleFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageContainer = new System.Windows.Forms.Panel();
            this.pictureBoxForIcon = new System.Windows.Forms.PictureBox();
            this.richTextBoxMessage = new ReaLTaiizor.Controls.MaterialRichTextBox();
            this.middleButton = new ReaLTaiizor.Controls.MaterialButton();
            this.rightButton = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialFlexibleFormBindingSource)).BeginInit();
            this.messageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // leftButton
            // 
            this.leftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.leftButton.AutoSize = false;
            this.leftButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftButton.Depth = 0;
            this.leftButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.leftButton.DrawShadows = true;
            this.leftButton.HighEmphasis = false;
            this.leftButton.Icon = null;
            this.leftButton.Location = new System.Drawing.Point(260, 297);
            this.leftButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.leftButton.MinimumSize = new System.Drawing.Size(0, 24);
            this.leftButton.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(108, 36);
            this.leftButton.TabIndex = 2;
            this.leftButton.Text = "OK";
            this.leftButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.leftButton.UseAccentColor = false;
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Visible = false;
            // 
            // messageContainer
            // 
            this.messageContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageContainer.BackColor = System.Drawing.Color.White;
            this.messageContainer.Controls.Add(this.pictureBoxForIcon);
            this.messageContainer.Controls.Add(this.richTextBoxMessage);
            this.messageContainer.Location = new System.Drawing.Point(0, 65);
            this.messageContainer.Name = "messageContainer";
            this.messageContainer.Size = new System.Drawing.Size(604, 215);
            this.messageContainer.TabIndex = 1;
            // 
            // pictureBoxForIcon
            // 
            this.pictureBoxForIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForIcon.Location = new System.Drawing.Point(15, 19);
            this.pictureBoxForIcon.Name = "pictureBoxForIcon";
            this.pictureBoxForIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxForIcon.TabIndex = 8;
            this.pictureBoxForIcon.TabStop = false;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.richTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MaterialFlexibleFormBindingSource, "MessageText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.richTextBoxMessage.Depth = 0;
            this.richTextBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBoxMessage.Hint = "";
            this.richTextBoxMessage.Location = new System.Drawing.Point(47, 2);
            this.richTextBoxMessage.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBoxMessage.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxMessage.Size = new System.Drawing.Size(554, 212);
            this.richTextBoxMessage.TabIndex = 0;
            this.richTextBoxMessage.TabStop = false;
            this.richTextBoxMessage.Text = "<Message>";
            this.richTextBoxMessage.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxMessage_LinkClicked);
            // 
            // middleButton
            // 
            this.middleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.middleButton.AutoSize = false;
            this.middleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.middleButton.Depth = 0;
            this.middleButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.middleButton.DrawShadows = true;
            this.middleButton.HighEmphasis = true;
            this.middleButton.Icon = null;
            this.middleButton.Location = new System.Drawing.Point(376, 297);
            this.middleButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.middleButton.MinimumSize = new System.Drawing.Size(0, 24);
            this.middleButton.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.middleButton.Name = "middleButton";
            this.middleButton.Size = new System.Drawing.Size(102, 36);
            this.middleButton.TabIndex = 3;
            this.middleButton.Text = "OK";
            this.middleButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.middleButton.UseAccentColor = false;
            this.middleButton.UseVisualStyleBackColor = true;
            this.middleButton.Visible = false;
            // 
            // rightButton
            // 
            this.rightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rightButton.AutoSize = false;
            this.rightButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rightButton.Depth = 0;
            this.rightButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.rightButton.DrawShadows = true;
            this.rightButton.HighEmphasis = true;
            this.rightButton.Icon = null;
            this.rightButton.Location = new System.Drawing.Point(486, 297);
            this.rightButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rightButton.MinimumSize = new System.Drawing.Size(0, 24);
            this.rightButton.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(106, 36);
            this.rightButton.TabIndex = 0;
            this.rightButton.Text = "OK";
            this.rightButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.rightButton.UseAccentColor = false;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Visible = false;
            // 
            // MaterialFlexibleForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 342);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.middleButton);
            this.Controls.Add(this.messageContainer);
            this.Controls.Add(this.leftButton);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MaterialFlexibleFormBindingSource, "CaptionText", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(276, 140);
            this.Name = "MaterialFlexibleForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "<Caption>";
            this.Load += new System.EventHandler(this.MaterialFlexibleForm_Load);
            this.Shown += new System.EventHandler(this.MaterialFlexibleForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialFlexibleFormBindingSource)).EndInit();
            this.messageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForIcon)).EndInit();
            this.ResumeLayout(false);

        }

        private MaterialButton leftButton;

        private BindingSource MaterialFlexibleFormBindingSource;

        private System.Windows.Forms.Panel messageContainer;

        private PictureBox pictureBoxForIcon;

        private MaterialButton middleButton;
        private MaterialButton rightButton;

        //These separators are used for the "copy to clipboard" standard operation, triggered by Ctrl + C (behavior and clipboard format is like in a standard MessageBox)
        private static readonly String STANDARD_MESSAGEBOX_SEPARATOR_LINES = "---------------------------\n";

        private static readonly String STANDARD_MESSAGEBOX_SEPARATOR_SPACES = "   ";

        //These are the possible buttons (in a standard MessageBox)
        private enum ButtonID
        {
            OK = 0,
            CANCEL,
            YES,
            NO,
            ABORT,
            RETRY,
            IGNORE
        };

        //These are the buttons texts for different languages.
        //If you want to add a new language, add it here and in the GetButtonText-Function
        private enum TwoLetterISOLanguageID
        {
            en,
            de,
            es,
            it,
            tr,
            zh
        };

        private static readonly String[] BUTTON_TEXTS_ENGLISH_EN = { "Ok", "Cancel", "Yes", "No", "Abort", "Retry", "Ignore" };

        private static readonly String[] BUTTON_TEXTS_GERMAN_DE = { "Ok", "Abbrechen", "Ja", "Nein", "Abbrechen", "Wiederholen", "Ignorieren" };

        private static readonly String[] BUTTON_TEXTS_SPANISH_ES = { "Aceptar", "Cancelar", "Sí", "No", "Abortar", "Reintentar", "Ignorar" };

        private static readonly String[] BUTTON_TEXTS_ITALIAN_IT = { "Ok", "Annulla", "Sì", "No", "Interrompi", "Riprova", "Ignora" };

        private static readonly String[] BUTTON_TEXTS_TURKISH_TR = { "Tamam", "İptal", "Evet", "Hayır", "Sonlandır", "Yeniden Dene", "Yoksay" };

        private static readonly String[] BUTTON_TEXTS_CHINA_ZH = { "确定", "取消", "是", "否", "终止", "重试", "忽略" };

        private MessageBoxDefaultButton defaultButton;

        private int visibleButtonsCount;

        private TwoLetterISOLanguageID languageID = TwoLetterISOLanguageID.en;

        private MaterialFlexibleForm()
        {
            InitializeComponent();

            //Try to evaluate the language. If this fails, the fallback language English will be used
            Enum.TryParse<TwoLetterISOLanguageID>(CultureInfo.CurrentUICulture.TwoLetterISOLanguageName, out languageID);

            KeyPreview = true;
            KeyUp += MaterialFlexibleForm_KeyUp;

            MaterialManager = MaterialManager.Instance;
            MaterialManager.AddFormToManage(this);
            FONT = MaterialManager.getFontByType(MaterialManager.fontType.Body1);
        }

        private static string[] GetStringRows(string message)
        {
            if (string.IsNullOrEmpty(message))
                return null;

            var messageRows = message.Split(new char[] { '\n' }, StringSplitOptions.None);
            return messageRows;
        }

        private string GetButtonText(ButtonID buttonID)
        {
            var buttonTextArrayIndex = Convert.ToInt32(buttonID);

            switch (languageID)
            {
                case TwoLetterISOLanguageID.de: return BUTTON_TEXTS_GERMAN_DE[buttonTextArrayIndex];
                case TwoLetterISOLanguageID.es: return BUTTON_TEXTS_SPANISH_ES[buttonTextArrayIndex];
                case TwoLetterISOLanguageID.it: return BUTTON_TEXTS_ITALIAN_IT[buttonTextArrayIndex];
                case TwoLetterISOLanguageID.tr: return BUTTON_TEXTS_TURKISH_TR[buttonTextArrayIndex];
                case TwoLetterISOLanguageID.zh: return BUTTON_TEXTS_CHINA_ZH[buttonTextArrayIndex];

                default: return BUTTON_TEXTS_ENGLISH_EN[buttonTextArrayIndex];
            }
        }

        private static double GetCorrectedWorkingAreaFactor(double workingAreaFactor)
        {
            const double MIN_FACTOR = 0.2;
            const double MAX_FACTOR = 1.0;

            if (workingAreaFactor < MIN_FACTOR)
                return MIN_FACTOR;

            if (workingAreaFactor > MAX_FACTOR)
                return MAX_FACTOR;

            return workingAreaFactor;
        }

        private static void SetDialogStartPosition(MaterialFlexibleForm MaterialFlexibleForm, IWin32Window owner)
        {
            //If no owner given: Center on current screen
            if (owner == null)
            {
                var screen = Screen.FromPoint(Cursor.Position);
                MaterialFlexibleForm.StartPosition = FormStartPosition.Manual;
                MaterialFlexibleForm.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - MaterialFlexibleForm.Width / 2;
                MaterialFlexibleForm.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - MaterialFlexibleForm.Height / 2;
            }
        }

        private static void SetDialogSizes(MaterialFlexibleForm MaterialFlexibleForm, string text, string caption)
        {
            //First set the bounds for the maximum dialog size
            MaterialFlexibleForm.MaximumSize = new Size(Convert.ToInt32(SystemInformation.WorkingArea.Width * GetCorrectedWorkingAreaFactor(MAX_WIDTH_FACTOR)), Convert.ToInt32(SystemInformation.WorkingArea.Height * GetCorrectedWorkingAreaFactor(MAX_HEIGHT_FACTOR)));

            //Get rows. Exit if there are no rows to render...
            var stringRows = GetStringRows(text);
            if (stringRows == null)
                return;

            //Calculate whole text height
            var textHeight = Math.Min(TextRenderer.MeasureText(text, FONT).Height, 600);

            //Calculate width for longest text line
            const int SCROLLBAR_WIDTH_OFFSET = 15;
            var longestTextRowWidth = stringRows.Max(textForRow => TextRenderer.MeasureText(textForRow, FONT).Width);
            var captionWidth = TextRenderer.MeasureText(caption, SystemFonts.CaptionFont).Width;
            var textWidth = Math.Max(longestTextRowWidth + SCROLLBAR_WIDTH_OFFSET, captionWidth);

            //Calculate margins
            var marginWidth = MaterialFlexibleForm.Width - MaterialFlexibleForm.richTextBoxMessage.Width;
            var marginHeight = MaterialFlexibleForm.Height - MaterialFlexibleForm.richTextBoxMessage.Height;

            //Set calculated dialog size (if the calculated values exceed the maximums, they were cut by windows forms automatically)
            MaterialFlexibleForm.Size = new Size(textWidth + marginWidth, textHeight + marginHeight);
        }

        private static void SetDialogIcon(MaterialFlexibleForm MaterialFlexibleForm, MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Information:
                    MaterialFlexibleForm.pictureBoxForIcon.Image = SystemIcons.Information.ToBitmap();
                    break;
                case MessageBoxIcon.Warning:
                    MaterialFlexibleForm.pictureBoxForIcon.Image = SystemIcons.Warning.ToBitmap();
                    break;
                case MessageBoxIcon.Error:
                    MaterialFlexibleForm.pictureBoxForIcon.Image = SystemIcons.Error.ToBitmap();
                    break;
                case MessageBoxIcon.Question:
                    MaterialFlexibleForm.pictureBoxForIcon.Image = SystemIcons.Question.ToBitmap();
                    break;
                default:
                    //When no icon is used: Correct placement and width of rich text box.
                    MaterialFlexibleForm.pictureBoxForIcon.Visible = false;
                    MaterialFlexibleForm.richTextBoxMessage.Left -= MaterialFlexibleForm.pictureBoxForIcon.Width;
                    MaterialFlexibleForm.richTextBoxMessage.Width += MaterialFlexibleForm.pictureBoxForIcon.Width;
                    break;
            }
        }

        private static void SetDialogButtons(MaterialFlexibleForm MaterialFlexibleForm, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            //Set the buttons visibilities and texts
            switch (buttons)
            {
                case MessageBoxButtons.AbortRetryIgnore:
                    MaterialFlexibleForm.visibleButtonsCount = 3;

                    MaterialFlexibleForm.leftButton.Visible = true;
                    MaterialFlexibleForm.leftButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.ABORT);
                    MaterialFlexibleForm.leftButton.DialogResult = DialogResult.Abort;

                    MaterialFlexibleForm.middleButton.Visible = true;
                    MaterialFlexibleForm.middleButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.RETRY);
                    MaterialFlexibleForm.middleButton.DialogResult = DialogResult.Retry;

                    MaterialFlexibleForm.rightButton.Visible = true;
                    MaterialFlexibleForm.rightButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.IGNORE);
                    MaterialFlexibleForm.rightButton.DialogResult = DialogResult.Ignore;

                    MaterialFlexibleForm.ControlBox = false;
                    break;
                case MessageBoxButtons.OKCancel:
                    MaterialFlexibleForm.visibleButtonsCount = 2;

                    MaterialFlexibleForm.middleButton.Visible = true;
                    MaterialFlexibleForm.middleButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.CANCEL);
                    MaterialFlexibleForm.middleButton.DialogResult = DialogResult.Cancel;

                    MaterialFlexibleForm.rightButton.Visible = true;
                    MaterialFlexibleForm.rightButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.OK);
                    MaterialFlexibleForm.rightButton.DialogResult = DialogResult.OK;

                    MaterialFlexibleForm.CancelButton = MaterialFlexibleForm.middleButton;
                    break;
                case MessageBoxButtons.RetryCancel:
                    MaterialFlexibleForm.visibleButtonsCount = 2;

                    MaterialFlexibleForm.middleButton.Visible = true;
                    MaterialFlexibleForm.middleButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.CANCEL);
                    MaterialFlexibleForm.middleButton.DialogResult = DialogResult.Cancel;

                    MaterialFlexibleForm.rightButton.Visible = true;
                    MaterialFlexibleForm.rightButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.RETRY);
                    MaterialFlexibleForm.rightButton.DialogResult = DialogResult.Retry;

                    MaterialFlexibleForm.CancelButton = MaterialFlexibleForm.middleButton;
                    break;
                case MessageBoxButtons.YesNo:
                    MaterialFlexibleForm.visibleButtonsCount = 2;

                    MaterialFlexibleForm.middleButton.Visible = true;
                    MaterialFlexibleForm.middleButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.NO);
                    MaterialFlexibleForm.middleButton.DialogResult = DialogResult.No;

                    MaterialFlexibleForm.rightButton.Visible = true;
                    MaterialFlexibleForm.rightButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.YES);
                    MaterialFlexibleForm.rightButton.DialogResult = DialogResult.Yes;

                    MaterialFlexibleForm.ControlBox = false;
                    break;
                case MessageBoxButtons.YesNoCancel:
                    MaterialFlexibleForm.visibleButtonsCount = 3;

                    MaterialFlexibleForm.rightButton.Visible = true;
                    MaterialFlexibleForm.rightButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.YES);
                    MaterialFlexibleForm.rightButton.DialogResult = DialogResult.Yes;

                    MaterialFlexibleForm.middleButton.Visible = true;
                    MaterialFlexibleForm.middleButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.NO);
                    MaterialFlexibleForm.middleButton.DialogResult = DialogResult.No;

                    MaterialFlexibleForm.leftButton.Visible = true;
                    MaterialFlexibleForm.leftButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.CANCEL);
                    MaterialFlexibleForm.leftButton.DialogResult = DialogResult.Cancel;

                    MaterialFlexibleForm.CancelButton = MaterialFlexibleForm.leftButton;
                    break;
                case MessageBoxButtons.OK:
                default:
                    MaterialFlexibleForm.visibleButtonsCount = 1;
                    MaterialFlexibleForm.rightButton.Visible = true;
                    MaterialFlexibleForm.rightButton.Text = MaterialFlexibleForm.GetButtonText(ButtonID.OK);
                    MaterialFlexibleForm.rightButton.DialogResult = DialogResult.OK;

                    MaterialFlexibleForm.CancelButton = MaterialFlexibleForm.rightButton;
                    break;
            }

            //Set default button (used in MaterialFlexibleForm_Shown)
            MaterialFlexibleForm.defaultButton = defaultButton;
        }

        private void MaterialFlexibleForm_Shown(object sender, EventArgs e)
        {
            int buttonIndexToFocus = 1;
            System.Windows.Forms.Button buttonToFocus;

            //Set the default button...
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1:
                default:
                    buttonIndexToFocus = 1;
                    break;
                case MessageBoxDefaultButton.Button2:
                    buttonIndexToFocus = 2;
                    break;
                case MessageBoxDefaultButton.Button3:
                    buttonIndexToFocus = 3;
                    break;
            }

            if (buttonIndexToFocus > visibleButtonsCount)
                buttonIndexToFocus = visibleButtonsCount;

            if (buttonIndexToFocus == 3)
                buttonToFocus = rightButton;
            else if (buttonIndexToFocus == 2)
                buttonToFocus = middleButton;
            else
                buttonToFocus = leftButton;

            buttonToFocus.Focus();
        }

        private void richTextBoxMessage_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Process.Start(e.LinkText);
            }
            catch (Exception)
            {
                //Let the caller of MaterialFlexibleForm decide what to do with this exception...
                throw;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        internal void MaterialFlexibleForm_KeyUp(object sender, KeyEventArgs e)
        {
            //Handle standard key strikes for clipboard copy: "Ctrl + C" and "Ctrl + Insert"
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.Insert))
            {
                var buttonsTextLine = (leftButton.Visible ? leftButton.Text + STANDARD_MESSAGEBOX_SEPARATOR_SPACES : string.Empty)
                                    + (middleButton.Visible ? middleButton.Text + STANDARD_MESSAGEBOX_SEPARATOR_SPACES : string.Empty)
                                    + (rightButton.Visible ? rightButton.Text + STANDARD_MESSAGEBOX_SEPARATOR_SPACES : string.Empty);

                //Build same clipboard text like the standard .Net MessageBox
                var textForClipboard = STANDARD_MESSAGEBOX_SEPARATOR_LINES
                                     + Text + Environment.NewLine
                                     + STANDARD_MESSAGEBOX_SEPARATOR_LINES
                                     + richTextBoxMessage.Text + Environment.NewLine
                                     + STANDARD_MESSAGEBOX_SEPARATOR_LINES
                                     + buttonsTextLine.Replace("&", string.Empty) + Environment.NewLine
                                     + STANDARD_MESSAGEBOX_SEPARATOR_LINES;

                //Set text in clipboard
                Clipboard.SetText(textForClipboard);
            }
        }

        public string CaptionText { get; set; }

        public string MessageText { get; set; }

        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            //Create a new instance of the FlexibleMessageBox form
            var MaterialFlexibleForm = new MaterialFlexibleForm();
            MaterialFlexibleForm.ShowInTaskbar = false;

            //Bind the caption and the message text
            MaterialFlexibleForm.CaptionText = caption;
            MaterialFlexibleForm.MessageText = text;
            MaterialFlexibleForm.MaterialFlexibleFormBindingSource.DataSource = MaterialFlexibleForm;

            //Set the buttons visibilities and texts. Also set a default button.
            SetDialogButtons(MaterialFlexibleForm, buttons, defaultButton);

            //Set the dialogs icon. When no icon is used: Correct placement and width of rich text box.
            SetDialogIcon(MaterialFlexibleForm, icon);

            //Set the font for all controls
            MaterialFlexibleForm.Font = FONT;
            MaterialFlexibleForm.richTextBoxMessage.Font = FONT;

            //Calculate the dialogs start size (Try to auto-size width to show longest text row). Also set the maximum dialog size.
            SetDialogSizes(MaterialFlexibleForm, text, caption);

            //Set the dialogs start position when given. Otherwise center the dialog on the current screen.
            SetDialogStartPosition(MaterialFlexibleForm, owner);

            //Show the dialog
            return MaterialFlexibleForm.ShowDialog(owner);
        }

        private void MaterialFlexibleForm_Load(object sender, EventArgs e)
        {
        }
    }

    #endregion
}