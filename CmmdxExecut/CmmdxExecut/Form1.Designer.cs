namespace CmmdxExecut
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Editor = new Microsoft.Web.WebView2.WinForms.WebView2();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panelTabBar = new FlowLayoutPanel();
            TAB = new SiticoneNetCoreUI.SiticoneButton();
            AddTab = new SiticoneNetCoreUI.SiticoneButton();
            panelMain = new Panel();
            siticoneButtonAdvanced1 = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            siticoneButtonAdvanced2 = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            siticoneButtonAdvanced3 = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            siticoneButtonAdvanced4 = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            ((System.ComponentModel.ISupportInitialize)Editor).BeginInit();
            panelTabBar.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // Editor
            // 
            Editor.AllowExternalDrop = true;
            Editor.CreationProperties = null;
            Editor.DefaultBackgroundColor = Color.White;
            Editor.ForeColor = SystemColors.ButtonHighlight;
            Editor.Location = new Point(3, 3);
            Editor.Name = "Editor";
            Editor.Size = new Size(815, 346);
            Editor.TabIndex = 2;
            Editor.ZoomFactor = 1D;
            Editor.Click += Editor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 1);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 4;
            label1.Text = "Cmmdx Injector";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // panelTabBar
            // 
            panelTabBar.Controls.Add(TAB);
            panelTabBar.Controls.Add(AddTab);
            panelTabBar.Location = new Point(0, 36);
            panelTabBar.Name = "panelTabBar";
            panelTabBar.Size = new Size(821, 25);
            panelTabBar.TabIndex = 12;
            // 
            // TAB
            // 
            TAB.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            TAB.AccessibleName = "TAB 1";
            TAB.AutoSizeBasedOnText = false;
            TAB.BackColor = Color.Transparent;
            TAB.BadgeBackColor = Color.Black;
            TAB.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            TAB.BadgeValue = 0;
            TAB.BadgeValueForeColor = Color.White;
            TAB.BorderColor = Color.FromArgb(15, 76, 117);
            TAB.BorderWidth = 2;
            TAB.ButtonBackColor = Color.FromArgb(23, 107, 135);
            TAB.ButtonImage = null;
            TAB.ButtonTextLeftPadding = 0;
            TAB.CanBeep = true;
            TAB.CanGlow = true;
            TAB.CanShake = true;
            TAB.ContextMenuStripEx = null;
            TAB.CornerRadiusBottomLeft = 4;
            TAB.CornerRadiusBottomRight = 4;
            TAB.CornerRadiusTopLeft = 4;
            TAB.CornerRadiusTopRight = 4;
            TAB.CustomCursor = Cursors.Default;
            TAB.DisabledTextColor = Color.FromArgb(150, 150, 150);
            TAB.EnableLongPress = false;
            TAB.EnableRippleEffect = true;
            TAB.EnableShadow = true;
            TAB.EnableTextWrapping = false;
            TAB.Font = new Font("Segoe UI Semibold", 10.2F);
            TAB.GlowColor = Color.FromArgb(50, 100, 200, 255);
            TAB.GlowIntensity = 100;
            TAB.GlowRadius = 20F;
            TAB.GradientBackground = true;
            TAB.GradientColor = Color.FromArgb(0, 227, 64);
            TAB.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            TAB.HintText = null;
            TAB.HoverBackColor = Color.FromArgb(27, 133, 184);
            TAB.HoverFontStyle = FontStyle.Regular;
            TAB.HoverTextColor = Color.White;
            TAB.HoverTransitionDuration = 250;
            TAB.ImageAlign = ContentAlignment.MiddleLeft;
            TAB.ImagePadding = 5;
            TAB.ImageSize = new Size(16, 16);
            TAB.IsRadial = false;
            TAB.IsReadOnly = false;
            TAB.IsToggleButton = false;
            TAB.IsToggled = false;
            TAB.Location = new Point(3, 3);
            TAB.LongPressDurationMS = 1000;
            TAB.Name = "TAB";
            TAB.NormalFontStyle = FontStyle.Regular;
            TAB.ParticleColor = Color.FromArgb(200, 200, 200);
            TAB.ParticleCount = 15;
            TAB.PressAnimationScale = 0.97F;
            TAB.PressedBackColor = Color.FromArgb(15, 76, 117);
            TAB.PressedFontStyle = FontStyle.Regular;
            TAB.PressTransitionDuration = 150;
            TAB.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            TAB.RippleColor = Color.FromArgb(128, 255, 255, 255);
            TAB.RippleRadiusMultiplier = 0.6F;
            TAB.ShadowBlur = 5;
            TAB.ShadowColor = Color.FromArgb(50, 0, 64, 128);
            TAB.ShadowOffset = new Point(0, 2);
            TAB.ShakeDuration = 500;
            TAB.ShakeIntensity = 5;
            TAB.Size = new Size(93, 24);
            TAB.TabIndex = 16;
            TAB.Text = "TAB 1";
            TAB.TextAlign = ContentAlignment.MiddleCenter;
            TAB.TextColor = Color.White;
            TAB.TooltipText = null;
            TAB.UseAdvancedRendering = true;
            TAB.UseParticles = false;
            // 
            // AddTab
            // 
            AddTab.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            AddTab.AccessibleName = "+";
            AddTab.AutoSizeBasedOnText = false;
            AddTab.BackColor = Color.Transparent;
            AddTab.BadgeBackColor = Color.Black;
            AddTab.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            AddTab.BadgeValue = 0;
            AddTab.BadgeValueForeColor = Color.White;
            AddTab.BorderColor = Color.FromArgb(15, 76, 117);
            AddTab.BorderWidth = 2;
            AddTab.ButtonBackColor = Color.FromArgb(23, 107, 135);
            AddTab.ButtonImage = null;
            AddTab.ButtonTextLeftPadding = 0;
            AddTab.CanBeep = true;
            AddTab.CanGlow = true;
            AddTab.CanShake = true;
            AddTab.ContextMenuStripEx = null;
            AddTab.CornerRadiusBottomLeft = 4;
            AddTab.CornerRadiusBottomRight = 4;
            AddTab.CornerRadiusTopLeft = 4;
            AddTab.CornerRadiusTopRight = 4;
            AddTab.CustomCursor = Cursors.Default;
            AddTab.DisabledTextColor = Color.FromArgb(150, 150, 150);
            AddTab.EnableLongPress = false;
            AddTab.EnableRippleEffect = true;
            AddTab.EnableShadow = true;
            AddTab.EnableTextWrapping = false;
            AddTab.Font = new Font("Segoe UI Semibold", 10.2F);
            AddTab.GlowColor = Color.FromArgb(50, 100, 200, 255);
            AddTab.GlowIntensity = 100;
            AddTab.GlowRadius = 20F;
            AddTab.GradientBackground = true;
            AddTab.GradientColor = Color.FromArgb(0, 227, 64);
            AddTab.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            AddTab.HintText = null;
            AddTab.HoverBackColor = Color.FromArgb(27, 133, 184);
            AddTab.HoverFontStyle = FontStyle.Regular;
            AddTab.HoverTextColor = Color.White;
            AddTab.HoverTransitionDuration = 250;
            AddTab.ImageAlign = ContentAlignment.MiddleLeft;
            AddTab.ImagePadding = 5;
            AddTab.ImageSize = new Size(16, 16);
            AddTab.IsRadial = false;
            AddTab.IsReadOnly = false;
            AddTab.IsToggleButton = false;
            AddTab.IsToggled = false;
            AddTab.Location = new Point(102, 3);
            AddTab.LongPressDurationMS = 1000;
            AddTab.Name = "AddTab";
            AddTab.NormalFontStyle = FontStyle.Regular;
            AddTab.ParticleColor = Color.FromArgb(200, 200, 200);
            AddTab.ParticleCount = 15;
            AddTab.PressAnimationScale = 0.97F;
            AddTab.PressedBackColor = Color.FromArgb(15, 76, 117);
            AddTab.PressedFontStyle = FontStyle.Regular;
            AddTab.PressTransitionDuration = 150;
            AddTab.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            AddTab.RippleColor = Color.FromArgb(128, 255, 255, 255);
            AddTab.RippleRadiusMultiplier = 0.6F;
            AddTab.ShadowBlur = 5;
            AddTab.ShadowColor = Color.FromArgb(50, 0, 64, 128);
            AddTab.ShadowOffset = new Point(0, 2);
            AddTab.ShakeDuration = 500;
            AddTab.ShakeIntensity = 5;
            AddTab.Size = new Size(22, 24);
            AddTab.TabIndex = 16;
            AddTab.Text = "+";
            AddTab.TextAlign = ContentAlignment.MiddleCenter;
            AddTab.TextColor = Color.White;
            AddTab.TooltipText = null;
            AddTab.UseAdvancedRendering = true;
            AddTab.UseParticles = false;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(Editor);
            panelMain.Location = new Point(0, 64);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(821, 352);
            panelMain.TabIndex = 13;
            // 
            // siticoneButtonAdvanced1
            // 
            siticoneButtonAdvanced1.BackColor = Color.Transparent;
            siticoneButtonAdvanced1.BadgeBackColor = Color.Red;
            siticoneButtonAdvanced1.BadgeForeColor = Color.White;
            siticoneButtonAdvanced1.BadgeRadius = 8;
            siticoneButtonAdvanced1.BadgeRightMargin = 10;
            siticoneButtonAdvanced1.BadgeValue = 0;
            siticoneButtonAdvanced1.BorderColor = Color.FromArgb(150, 255, 255, 255);
            siticoneButtonAdvanced1.BorderColorEnd = Color.Black;
            siticoneButtonAdvanced1.BorderColorStart = Color.Black;
            siticoneButtonAdvanced1.BorderRadiusBottomLeft = 30;
            siticoneButtonAdvanced1.BorderRadiusBottomRight = 30;
            siticoneButtonAdvanced1.BorderRadiusTopLeft = 30;
            siticoneButtonAdvanced1.BorderRadiusTopRight = 30;
            siticoneButtonAdvanced1.BorderThickness = 1;
            siticoneButtonAdvanced1.ButtonColorEnd = Color.Black;
            siticoneButtonAdvanced1.ButtonColorStart = Color.FromArgb(192, 0, 0);
            siticoneButtonAdvanced1.ButtonImage = null;
            siticoneButtonAdvanced1.CanBeep = false;
            siticoneButtonAdvanced1.CanShake = false;
            siticoneButtonAdvanced1.ClickSoundPath = null;
            siticoneButtonAdvanced1.DisabledOverlayOpacity = 0.5F;
            siticoneButtonAdvanced1.EnableBorderGradient = true;
            siticoneButtonAdvanced1.EnableClickSound = false;
            siticoneButtonAdvanced1.EnableFocusBorder = false;
            siticoneButtonAdvanced1.EnableHoverSound = false;
            siticoneButtonAdvanced1.EnablePressScale = true;
            siticoneButtonAdvanced1.EnableTextShadow = true;
            siticoneButtonAdvanced1.FocusBorderColor = Color.FromArgb(100, 150, 255);
            siticoneButtonAdvanced1.FocusBorderThickness = 2;
            siticoneButtonAdvanced1.Font = new Font("Segoe UI", 9F);
            siticoneButtonAdvanced1.ForeColor = Color.White;
            siticoneButtonAdvanced1.HoverColor = Color.FromArgb(20, 0, 0, 0);
            siticoneButtonAdvanced1.HoverSoundPath = null;
            siticoneButtonAdvanced1.HoverTransitionSpeed = 0.08F;
            siticoneButtonAdvanced1.ImageAlign = ContentAlignment.MiddleLeft;
            siticoneButtonAdvanced1.ImageLeftMargin = 5;
            siticoneButtonAdvanced1.ImageRightMargin = 8;
            siticoneButtonAdvanced1.ImageSize = 24;
            siticoneButtonAdvanced1.IsReadOnly = false;
            siticoneButtonAdvanced1.Location = new Point(6, 419);
            siticoneButtonAdvanced1.MakeRadial = true;
            siticoneButtonAdvanced1.Name = "siticoneButtonAdvanced1";
            siticoneButtonAdvanced1.PressAnimationSpeed = 0.2F;
            siticoneButtonAdvanced1.PressDepth = 2;
            siticoneButtonAdvanced1.RippleColor = Color.FromArgb(60, 255, 255, 255);
            siticoneButtonAdvanced1.RippleExpandSpeedFactor = 0.05F;
            siticoneButtonAdvanced1.RippleFadeSpeedFactor = 0.03F;
            siticoneButtonAdvanced1.ShadowBlurFactor = 0.85F;
            siticoneButtonAdvanced1.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            siticoneButtonAdvanced1.ShadowOffsetX = 3;
            siticoneButtonAdvanced1.ShadowOffsetY = 3;
            siticoneButtonAdvanced1.Size = new Size(116, 51);
            siticoneButtonAdvanced1.TabIndex = 14;
            siticoneButtonAdvanced1.Text = "Show Pids";
            siticoneButtonAdvanced1.TextAlign = ContentAlignment.MiddleCenter;
            siticoneButtonAdvanced1.TextPaddingBottom = 0;
            siticoneButtonAdvanced1.TextPaddingLeft = 0;
            siticoneButtonAdvanced1.TextPaddingRight = 0;
            siticoneButtonAdvanced1.TextPaddingTop = 0;
            siticoneButtonAdvanced1.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            siticoneButtonAdvanced1.TextShadowOffsetX = 1;
            siticoneButtonAdvanced1.TextShadowOffsetY = 1;
            siticoneButtonAdvanced1.Click += siticoneButtonAdvanced1_Click;
            // 
            // siticoneButtonAdvanced2
            // 
            siticoneButtonAdvanced2.BackColor = Color.Transparent;
            siticoneButtonAdvanced2.BadgeBackColor = Color.Red;
            siticoneButtonAdvanced2.BadgeForeColor = Color.White;
            siticoneButtonAdvanced2.BadgeRadius = 8;
            siticoneButtonAdvanced2.BadgeRightMargin = 10;
            siticoneButtonAdvanced2.BadgeValue = 0;
            siticoneButtonAdvanced2.BorderColor = Color.FromArgb(150, 255, 255, 255);
            siticoneButtonAdvanced2.BorderColorEnd = Color.Black;
            siticoneButtonAdvanced2.BorderColorStart = Color.Black;
            siticoneButtonAdvanced2.BorderRadiusBottomLeft = 30;
            siticoneButtonAdvanced2.BorderRadiusBottomRight = 30;
            siticoneButtonAdvanced2.BorderRadiusTopLeft = 30;
            siticoneButtonAdvanced2.BorderRadiusTopRight = 30;
            siticoneButtonAdvanced2.BorderThickness = 1;
            siticoneButtonAdvanced2.ButtonColorEnd = Color.Black;
            siticoneButtonAdvanced2.ButtonColorStart = Color.FromArgb(192, 0, 0);
            siticoneButtonAdvanced2.ButtonImage = null;
            siticoneButtonAdvanced2.CanBeep = false;
            siticoneButtonAdvanced2.CanShake = false;
            siticoneButtonAdvanced2.ClickSoundPath = null;
            siticoneButtonAdvanced2.DisabledOverlayOpacity = 0.5F;
            siticoneButtonAdvanced2.EnableBorderGradient = true;
            siticoneButtonAdvanced2.EnableClickSound = false;
            siticoneButtonAdvanced2.EnableFocusBorder = false;
            siticoneButtonAdvanced2.EnableHoverSound = false;
            siticoneButtonAdvanced2.EnablePressScale = true;
            siticoneButtonAdvanced2.EnableTextShadow = true;
            siticoneButtonAdvanced2.FocusBorderColor = Color.FromArgb(100, 150, 255);
            siticoneButtonAdvanced2.FocusBorderThickness = 2;
            siticoneButtonAdvanced2.Font = new Font("Segoe UI", 9F);
            siticoneButtonAdvanced2.ForeColor = Color.White;
            siticoneButtonAdvanced2.HoverColor = Color.FromArgb(20, 0, 0, 0);
            siticoneButtonAdvanced2.HoverSoundPath = null;
            siticoneButtonAdvanced2.HoverTransitionSpeed = 0.08F;
            siticoneButtonAdvanced2.ImageAlign = ContentAlignment.MiddleLeft;
            siticoneButtonAdvanced2.ImageLeftMargin = 5;
            siticoneButtonAdvanced2.ImageRightMargin = 8;
            siticoneButtonAdvanced2.ImageSize = 24;
            siticoneButtonAdvanced2.IsReadOnly = false;
            siticoneButtonAdvanced2.Location = new Point(705, 419);
            siticoneButtonAdvanced2.MakeRadial = true;
            siticoneButtonAdvanced2.Name = "siticoneButtonAdvanced2";
            siticoneButtonAdvanced2.PressAnimationSpeed = 0.2F;
            siticoneButtonAdvanced2.PressDepth = 2;
            siticoneButtonAdvanced2.RippleColor = Color.FromArgb(60, 255, 255, 255);
            siticoneButtonAdvanced2.RippleExpandSpeedFactor = 0.05F;
            siticoneButtonAdvanced2.RippleFadeSpeedFactor = 0.03F;
            siticoneButtonAdvanced2.ShadowBlurFactor = 0.85F;
            siticoneButtonAdvanced2.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            siticoneButtonAdvanced2.ShadowOffsetX = 3;
            siticoneButtonAdvanced2.ShadowOffsetY = 3;
            siticoneButtonAdvanced2.Size = new Size(116, 48);
            siticoneButtonAdvanced2.TabIndex = 15;
            siticoneButtonAdvanced2.Text = "Attach";
            siticoneButtonAdvanced2.TextAlign = ContentAlignment.MiddleCenter;
            siticoneButtonAdvanced2.TextPaddingBottom = 0;
            siticoneButtonAdvanced2.TextPaddingLeft = 0;
            siticoneButtonAdvanced2.TextPaddingRight = 0;
            siticoneButtonAdvanced2.TextPaddingTop = 0;
            siticoneButtonAdvanced2.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            siticoneButtonAdvanced2.TextShadowOffsetX = 1;
            siticoneButtonAdvanced2.TextShadowOffsetY = 1;
            siticoneButtonAdvanced2.Click += siticoneButtonAdvanced2_Click;
            // 
            // siticoneButtonAdvanced3
            // 
            siticoneButtonAdvanced3.BackColor = Color.Transparent;
            siticoneButtonAdvanced3.BadgeBackColor = Color.Red;
            siticoneButtonAdvanced3.BadgeForeColor = Color.White;
            siticoneButtonAdvanced3.BadgeRadius = 8;
            siticoneButtonAdvanced3.BadgeRightMargin = 10;
            siticoneButtonAdvanced3.BadgeValue = 0;
            siticoneButtonAdvanced3.BorderColor = Color.FromArgb(150, 255, 255, 255);
            siticoneButtonAdvanced3.BorderColorEnd = Color.Black;
            siticoneButtonAdvanced3.BorderColorStart = Color.Black;
            siticoneButtonAdvanced3.BorderRadiusBottomLeft = 30;
            siticoneButtonAdvanced3.BorderRadiusBottomRight = 30;
            siticoneButtonAdvanced3.BorderRadiusTopLeft = 30;
            siticoneButtonAdvanced3.BorderRadiusTopRight = 30;
            siticoneButtonAdvanced3.BorderThickness = 1;
            siticoneButtonAdvanced3.ButtonColorEnd = Color.Black;
            siticoneButtonAdvanced3.ButtonColorStart = Color.FromArgb(192, 0, 0);
            siticoneButtonAdvanced3.ButtonImage = null;
            siticoneButtonAdvanced3.CanBeep = false;
            siticoneButtonAdvanced3.CanShake = false;
            siticoneButtonAdvanced3.ClickSoundPath = null;
            siticoneButtonAdvanced3.DisabledOverlayOpacity = 0.5F;
            siticoneButtonAdvanced3.EnableBorderGradient = true;
            siticoneButtonAdvanced3.EnableClickSound = false;
            siticoneButtonAdvanced3.EnableFocusBorder = false;
            siticoneButtonAdvanced3.EnableHoverSound = false;
            siticoneButtonAdvanced3.EnablePressScale = true;
            siticoneButtonAdvanced3.EnableTextShadow = true;
            siticoneButtonAdvanced3.FocusBorderColor = Color.FromArgb(100, 150, 255);
            siticoneButtonAdvanced3.FocusBorderThickness = 2;
            siticoneButtonAdvanced3.Font = new Font("Segoe UI", 9F);
            siticoneButtonAdvanced3.ForeColor = Color.White;
            siticoneButtonAdvanced3.HoverColor = Color.FromArgb(20, 0, 0, 0);
            siticoneButtonAdvanced3.HoverSoundPath = null;
            siticoneButtonAdvanced3.HoverTransitionSpeed = 0.08F;
            siticoneButtonAdvanced3.ImageAlign = ContentAlignment.MiddleLeft;
            siticoneButtonAdvanced3.ImageLeftMargin = 5;
            siticoneButtonAdvanced3.ImageRightMargin = 8;
            siticoneButtonAdvanced3.ImageSize = 24;
            siticoneButtonAdvanced3.IsReadOnly = false;
            siticoneButtonAdvanced3.Location = new Point(583, 419);
            siticoneButtonAdvanced3.MakeRadial = true;
            siticoneButtonAdvanced3.Name = "siticoneButtonAdvanced3";
            siticoneButtonAdvanced3.PressAnimationSpeed = 0.2F;
            siticoneButtonAdvanced3.PressDepth = 2;
            siticoneButtonAdvanced3.RippleColor = Color.FromArgb(60, 255, 255, 255);
            siticoneButtonAdvanced3.RippleExpandSpeedFactor = 0.05F;
            siticoneButtonAdvanced3.RippleFadeSpeedFactor = 0.03F;
            siticoneButtonAdvanced3.ShadowBlurFactor = 0.85F;
            siticoneButtonAdvanced3.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            siticoneButtonAdvanced3.ShadowOffsetX = 3;
            siticoneButtonAdvanced3.ShadowOffsetY = 3;
            siticoneButtonAdvanced3.Size = new Size(116, 48);
            siticoneButtonAdvanced3.TabIndex = 15;
            siticoneButtonAdvanced3.Text = "Execute";
            siticoneButtonAdvanced3.TextAlign = ContentAlignment.MiddleCenter;
            siticoneButtonAdvanced3.TextPaddingBottom = 0;
            siticoneButtonAdvanced3.TextPaddingLeft = 0;
            siticoneButtonAdvanced3.TextPaddingRight = 0;
            siticoneButtonAdvanced3.TextPaddingTop = 0;
            siticoneButtonAdvanced3.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            siticoneButtonAdvanced3.TextShadowOffsetX = 1;
            siticoneButtonAdvanced3.TextShadowOffsetY = 1;
            siticoneButtonAdvanced3.Click += siticoneButtonAdvanced3_Click;
            // 
            // siticoneButtonAdvanced4
            // 
            siticoneButtonAdvanced4.BackColor = Color.Transparent;
            siticoneButtonAdvanced4.BadgeBackColor = Color.Red;
            siticoneButtonAdvanced4.BadgeForeColor = Color.White;
            siticoneButtonAdvanced4.BadgeRadius = 8;
            siticoneButtonAdvanced4.BadgeRightMargin = 10;
            siticoneButtonAdvanced4.BadgeValue = 0;
            siticoneButtonAdvanced4.BorderColor = Color.FromArgb(150, 255, 255, 255);
            siticoneButtonAdvanced4.BorderColorEnd = Color.Gray;
            siticoneButtonAdvanced4.BorderColorStart = Color.White;
            siticoneButtonAdvanced4.BorderRadiusBottomLeft = 30;
            siticoneButtonAdvanced4.BorderRadiusBottomRight = 30;
            siticoneButtonAdvanced4.BorderRadiusTopLeft = 30;
            siticoneButtonAdvanced4.BorderRadiusTopRight = 30;
            siticoneButtonAdvanced4.BorderThickness = 1;
            siticoneButtonAdvanced4.ButtonColorEnd = Color.Red;
            siticoneButtonAdvanced4.ButtonColorStart = Color.Maroon;
            siticoneButtonAdvanced4.ButtonImage = null;
            siticoneButtonAdvanced4.CanBeep = false;
            siticoneButtonAdvanced4.CanShake = false;
            siticoneButtonAdvanced4.ClickSoundPath = null;
            siticoneButtonAdvanced4.DisabledOverlayOpacity = 0.5F;
            siticoneButtonAdvanced4.EnableBorderGradient = true;
            siticoneButtonAdvanced4.EnableClickSound = false;
            siticoneButtonAdvanced4.EnableFocusBorder = false;
            siticoneButtonAdvanced4.EnableHoverSound = false;
            siticoneButtonAdvanced4.EnablePressScale = true;
            siticoneButtonAdvanced4.EnableTextShadow = true;
            siticoneButtonAdvanced4.FocusBorderColor = Color.FromArgb(100, 150, 255);
            siticoneButtonAdvanced4.FocusBorderThickness = 2;
            siticoneButtonAdvanced4.Font = new Font("Segoe UI", 9F);
            siticoneButtonAdvanced4.ForeColor = Color.White;
            siticoneButtonAdvanced4.HoverColor = Color.FromArgb(20, 0, 0, 0);
            siticoneButtonAdvanced4.HoverSoundPath = null;
            siticoneButtonAdvanced4.HoverTransitionSpeed = 0.08F;
            siticoneButtonAdvanced4.ImageAlign = ContentAlignment.MiddleLeft;
            siticoneButtonAdvanced4.ImageLeftMargin = 5;
            siticoneButtonAdvanced4.ImageRightMargin = 8;
            siticoneButtonAdvanced4.ImageSize = 24;
            siticoneButtonAdvanced4.IsReadOnly = false;
            siticoneButtonAdvanced4.Location = new Point(790, 1);
            siticoneButtonAdvanced4.MakeRadial = true;
            siticoneButtonAdvanced4.Name = "siticoneButtonAdvanced4";
            siticoneButtonAdvanced4.PressAnimationSpeed = 1F;
            siticoneButtonAdvanced4.PressDepth = 1;
            siticoneButtonAdvanced4.RippleColor = Color.FromArgb(60, 255, 255, 255);
            siticoneButtonAdvanced4.RippleExpandSpeedFactor = 0.05F;
            siticoneButtonAdvanced4.RippleFadeSpeedFactor = 0.03F;
            siticoneButtonAdvanced4.ShadowBlurFactor = 0.85F;
            siticoneButtonAdvanced4.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            siticoneButtonAdvanced4.ShadowOffsetX = 3;
            siticoneButtonAdvanced4.ShadowOffsetY = 3;
            siticoneButtonAdvanced4.Size = new Size(31, 29);
            siticoneButtonAdvanced4.TabIndex = 16;
            siticoneButtonAdvanced4.Text = "X";
            siticoneButtonAdvanced4.TextAlign = ContentAlignment.MiddleCenter;
            siticoneButtonAdvanced4.TextPaddingBottom = 0;
            siticoneButtonAdvanced4.TextPaddingLeft = 0;
            siticoneButtonAdvanced4.TextPaddingRight = 0;
            siticoneButtonAdvanced4.TextPaddingTop = 0;
            siticoneButtonAdvanced4.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            siticoneButtonAdvanced4.TextShadowOffsetX = 1;
            siticoneButtonAdvanced4.TextShadowOffsetY = 1;
            siticoneButtonAdvanced4.Click += siticoneButtonAdvanced4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Black;
            ClientSize = new Size(822, 472);
            Controls.Add(siticoneButtonAdvanced4);
            Controls.Add(siticoneButtonAdvanced3);
            Controls.Add(siticoneButtonAdvanced2);
            Controls.Add(siticoneButtonAdvanced1);
            Controls.Add(panelMain);
            Controls.Add(panelTabBar);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CmmdxExec with Xeno :D";
            MouseDown += Form1_MouseDown_1;
            ((System.ComponentModel.ISupportInitialize)Editor).EndInit();
            panelTabBar.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 Editor;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private FlowLayoutPanel panelTabBar;
        private Panel panelMain;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced siticoneButtonAdvanced1;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced siticoneButtonAdvanced2;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced siticoneButtonAdvanced3;
        private SiticoneNetCoreUI.SiticoneButton TAB;
        private SiticoneNetCoreUI.SiticoneButton AddTab;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced siticoneButtonAdvanced4;
    }
}
