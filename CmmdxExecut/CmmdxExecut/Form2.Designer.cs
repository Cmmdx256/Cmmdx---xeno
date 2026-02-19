namespace CmmdxExecut
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
            listBox1 = new ListBox();
            btnBack = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Black;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(317, 235);
            listBox1.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BadgeBackColor = Color.Red;
            btnBack.BadgeForeColor = Color.White;
            btnBack.BadgeRadius = 8;
            btnBack.BadgeRightMargin = 10;
            btnBack.BadgeValue = 0;
            btnBack.BorderColor = Color.FromArgb(150, 255, 255, 255);
            btnBack.BorderColorEnd = Color.Gray;
            btnBack.BorderColorStart = Color.White;
            btnBack.BorderRadiusBottomLeft = 30;
            btnBack.BorderRadiusBottomRight = 30;
            btnBack.BorderRadiusTopLeft = 30;
            btnBack.BorderRadiusTopRight = 30;
            btnBack.BorderThickness = 1;
            btnBack.ButtonColorEnd = Color.FromArgb(192, 0, 0);
            btnBack.ButtonColorStart = Color.Black;
            btnBack.ButtonImage = null;
            btnBack.CanBeep = false;
            btnBack.CanShake = false;
            btnBack.ClickSoundPath = null;
            btnBack.DisabledOverlayOpacity = 0.5F;
            btnBack.EnableBorderGradient = true;
            btnBack.EnableClickSound = false;
            btnBack.EnableFocusBorder = false;
            btnBack.EnableHoverSound = false;
            btnBack.EnablePressScale = true;
            btnBack.EnableTextShadow = true;
            btnBack.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnBack.FocusBorderThickness = 2;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBack.ForeColor = Color.White;
            btnBack.HoverColor = Color.FromArgb(20, 0, 0, 0);
            btnBack.HoverSoundPath = null;
            btnBack.HoverTransitionSpeed = 0.08F;
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.ImageLeftMargin = 5;
            btnBack.ImageRightMargin = 8;
            btnBack.ImageSize = 24;
            btnBack.IsReadOnly = false;
            btnBack.Location = new Point(105, 253);
            btnBack.MakeRadial = true;
            btnBack.Name = "btnBack";
            btnBack.PressAnimationSpeed = 0.2F;
            btnBack.PressDepth = 2;
            btnBack.RippleColor = Color.FromArgb(60, 255, 255, 255);
            btnBack.RippleExpandSpeedFactor = 0.05F;
            btnBack.RippleFadeSpeedFactor = 0.03F;
            btnBack.ShadowBlurFactor = 0.85F;
            btnBack.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnBack.ShadowOffsetX = 3;
            btnBack.ShadowOffsetY = 3;
            btnBack.Size = new Size(121, 54);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleCenter;
            btnBack.TextPaddingBottom = 0;
            btnBack.TextPaddingLeft = 0;
            btnBack.TextPaddingRight = 0;
            btnBack.TextPaddingTop = 0;
            btnBack.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnBack.TextShadowOffsetX = 1;
            btnBack.TextShadowOffsetY = 1;
            btnBack.Click += siticoneButtonAdvanced1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(341, 314);
            Controls.Add(btnBack);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pids Menu";
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnBack;
    }
}