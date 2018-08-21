namespace WinFormApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ComboBox_FormState = new System.Windows.Forms.ComboBox();
            this.ComboBox_FormAction = new System.Windows.Forms.ComboBox();
            this.ComboBox_FormStyle = new System.Windows.Forms.ComboBox();
            this.CheckBox_EnableFullScreen = new System.Windows.Forms.CheckBox();
            this.CheckBox_ShowCaptionBarColor = new System.Windows.Forms.CheckBox();
            this.CheckBox_EnableCaptionBarTransparent = new System.Windows.Forms.CheckBox();
            this.ColorDialog_ThemeColor = new System.Windows.Forms.ColorDialog();
            this.Button_ThemeColor = new System.Windows.Forms.Button();
            this.ComboBox_Theme = new System.Windows.Forms.ComboBox();
            this.CheckBox_TopMost = new System.Windows.Forms.CheckBox();
            this.CheckBox_ShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.FontDialog_CaptionFont = new System.Windows.Forms.FontDialog();
            this.Button_CaptionFont = new System.Windows.Forms.Button();
            this.ComboBox_CaptionAlign = new System.Windows.Forms.ComboBox();
            this.CheckBox_ShowIconOnCaptionBar = new System.Windows.Forms.CheckBox();
            this.CheckBox_ShowShadowColor = new System.Windows.Forms.CheckBox();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Panel_FormStyle = new System.Windows.Forms.Panel();
            this.Label_FormStyle = new System.Windows.Forms.Label();
            this.Panel_FormAppearance = new System.Windows.Forms.Panel();
            this.Label_FormAppearance = new System.Windows.Forms.Label();
            this.Panel_FormState = new System.Windows.Forms.Panel();
            this.Label_FormState = new System.Windows.Forms.Label();
            this.Panel_Main.SuspendLayout();
            this.Panel_FormStyle.SuspendLayout();
            this.Panel_FormAppearance.SuspendLayout();
            this.Panel_FormState.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBox_FormState
            // 
            this.ComboBox_FormState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FormState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_FormState.FormattingEnabled = true;
            this.ComboBox_FormState.Items.AddRange(new object[] {
            "Normal",
            "Minimized",
            "Maximized",
            "FullScreen",
            "HighAsScreen",
            "QuarterScreen"});
            this.ComboBox_FormState.Location = new System.Drawing.Point(15, 30);
            this.ComboBox_FormState.Name = "ComboBox_FormState";
            this.ComboBox_FormState.Size = new System.Drawing.Size(250, 25);
            this.ComboBox_FormState.TabIndex = 0;
            this.ComboBox_FormState.TabStop = false;
            this.ComboBox_FormState.SelectedIndexChanged += new System.EventHandler(this.ComboBox_FormState_SelectedIndexChanged);
            // 
            // ComboBox_FormAction
            // 
            this.ComboBox_FormAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FormAction.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_FormAction.FormattingEnabled = true;
            this.ComboBox_FormAction.Items.AddRange(new object[] {
            "None",
            "Return",
            "Minimize",
            "Maximize",
            "EnterFullScreen",
            "ExitFullScreen",
            "LeftHalfScreen",
            "RightHalfScreen",
            "HighAsScreen",
            "TopLeftQuarterScreen",
            "TopRightQuarterScreen",
            "BottomLeftQuarterScreen",
            "BottomRightQuarterScreen",
            "Close"});
            this.ComboBox_FormAction.Location = new System.Drawing.Point(15, 60);
            this.ComboBox_FormAction.Name = "ComboBox_FormAction";
            this.ComboBox_FormAction.Size = new System.Drawing.Size(250, 25);
            this.ComboBox_FormAction.TabIndex = 0;
            this.ComboBox_FormAction.TabStop = false;
            this.ComboBox_FormAction.SelectedIndexChanged += new System.EventHandler(this.ComboBox_FormAction_SelectedIndexChanged);
            // 
            // ComboBox_FormStyle
            // 
            this.ComboBox_FormStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FormStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_FormStyle.FormattingEnabled = true;
            this.ComboBox_FormStyle.Items.AddRange(new object[] {
            "Sizable",
            "Fixed",
            "Dialog"});
            this.ComboBox_FormStyle.Location = new System.Drawing.Point(15, 30);
            this.ComboBox_FormStyle.Name = "ComboBox_FormStyle";
            this.ComboBox_FormStyle.Size = new System.Drawing.Size(250, 25);
            this.ComboBox_FormStyle.TabIndex = 0;
            this.ComboBox_FormStyle.TabStop = false;
            this.ComboBox_FormStyle.SelectedIndexChanged += new System.EventHandler(this.ComboBox_FormStyle_SelectedIndexChanged);
            // 
            // CheckBox_EnableFullScreen
            // 
            this.CheckBox_EnableFullScreen.AutoSize = true;
            this.CheckBox_EnableFullScreen.Checked = true;
            this.CheckBox_EnableFullScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_EnableFullScreen.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_EnableFullScreen.Location = new System.Drawing.Point(15, 60);
            this.CheckBox_EnableFullScreen.Name = "CheckBox_EnableFullScreen";
            this.CheckBox_EnableFullScreen.Size = new System.Drawing.Size(128, 21);
            this.CheckBox_EnableFullScreen.TabIndex = 0;
            this.CheckBox_EnableFullScreen.TabStop = false;
            this.CheckBox_EnableFullScreen.Text = "EnableFullScreen ";
            this.CheckBox_EnableFullScreen.UseVisualStyleBackColor = true;
            this.CheckBox_EnableFullScreen.CheckedChanged += new System.EventHandler(this.CheckBox_EnableFullScreen_CheckedChanged);
            // 
            // CheckBox_ShowCaptionBarColor
            // 
            this.CheckBox_ShowCaptionBarColor.AutoSize = true;
            this.CheckBox_ShowCaptionBarColor.Checked = true;
            this.CheckBox_ShowCaptionBarColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_ShowCaptionBarColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_ShowCaptionBarColor.Location = new System.Drawing.Point(15, 150);
            this.CheckBox_ShowCaptionBarColor.Name = "CheckBox_ShowCaptionBarColor";
            this.CheckBox_ShowCaptionBarColor.Size = new System.Drawing.Size(155, 21);
            this.CheckBox_ShowCaptionBarColor.TabIndex = 0;
            this.CheckBox_ShowCaptionBarColor.TabStop = false;
            this.CheckBox_ShowCaptionBarColor.Text = "ShowCaptionBarColor";
            this.CheckBox_ShowCaptionBarColor.UseVisualStyleBackColor = true;
            this.CheckBox_ShowCaptionBarColor.CheckedChanged += new System.EventHandler(this.CheckBox_ShowCaptionBarColor_CheckedChanged);
            // 
            // CheckBox_EnableCaptionBarTransparent
            // 
            this.CheckBox_EnableCaptionBarTransparent.AutoSize = true;
            this.CheckBox_EnableCaptionBarTransparent.Checked = true;
            this.CheckBox_EnableCaptionBarTransparent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_EnableCaptionBarTransparent.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_EnableCaptionBarTransparent.Location = new System.Drawing.Point(15, 175);
            this.CheckBox_EnableCaptionBarTransparent.Name = "CheckBox_EnableCaptionBarTransparent";
            this.CheckBox_EnableCaptionBarTransparent.Size = new System.Drawing.Size(201, 21);
            this.CheckBox_EnableCaptionBarTransparent.TabIndex = 0;
            this.CheckBox_EnableCaptionBarTransparent.TabStop = false;
            this.CheckBox_EnableCaptionBarTransparent.Text = "EnableCaptionBarTransparent";
            this.CheckBox_EnableCaptionBarTransparent.UseVisualStyleBackColor = true;
            this.CheckBox_EnableCaptionBarTransparent.CheckedChanged += new System.EventHandler(this.CheckBox_EnableCaptionBarTransparent_CheckedChanged);
            // 
            // ColorDialog_ThemeColor
            // 
            this.ColorDialog_ThemeColor.FullOpen = true;
            // 
            // Button_ThemeColor
            // 
            this.Button_ThemeColor.AutoEllipsis = true;
            this.Button_ThemeColor.FlatAppearance.BorderSize = 0;
            this.Button_ThemeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ThemeColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Button_ThemeColor.Location = new System.Drawing.Point(15, 60);
            this.Button_ThemeColor.Name = "Button_ThemeColor";
            this.Button_ThemeColor.Size = new System.Drawing.Size(250, 25);
            this.Button_ThemeColor.TabIndex = 0;
            this.Button_ThemeColor.TabStop = false;
            this.Button_ThemeColor.Text = "ThemeColor";
            this.Button_ThemeColor.UseVisualStyleBackColor = true;
            this.Button_ThemeColor.Click += new System.EventHandler(this.Button_ThemeColor_Click);
            // 
            // ComboBox_Theme
            // 
            this.ComboBox_Theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Theme.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_Theme.FormattingEnabled = true;
            this.ComboBox_Theme.Items.AddRange(new object[] {
            "Colorful",
            "White",
            "LightGray",
            "DarkGray",
            "Black"});
            this.ComboBox_Theme.Location = new System.Drawing.Point(15, 30);
            this.ComboBox_Theme.Name = "ComboBox_Theme";
            this.ComboBox_Theme.Size = new System.Drawing.Size(250, 25);
            this.ComboBox_Theme.TabIndex = 0;
            this.ComboBox_Theme.TabStop = false;
            this.ComboBox_Theme.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Theme_SelectedIndexChanged);
            // 
            // CheckBox_TopMost
            // 
            this.CheckBox_TopMost.AutoSize = true;
            this.CheckBox_TopMost.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_TopMost.Location = new System.Drawing.Point(15, 110);
            this.CheckBox_TopMost.Name = "CheckBox_TopMost";
            this.CheckBox_TopMost.Size = new System.Drawing.Size(80, 21);
            this.CheckBox_TopMost.TabIndex = 0;
            this.CheckBox_TopMost.TabStop = false;
            this.CheckBox_TopMost.Text = "TopMost";
            this.CheckBox_TopMost.UseVisualStyleBackColor = true;
            this.CheckBox_TopMost.CheckedChanged += new System.EventHandler(this.CheckBox_TopMost_CheckedChanged);
            // 
            // CheckBox_ShowInTaskbar
            // 
            this.CheckBox_ShowInTaskbar.AutoSize = true;
            this.CheckBox_ShowInTaskbar.Checked = true;
            this.CheckBox_ShowInTaskbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_ShowInTaskbar.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_ShowInTaskbar.Location = new System.Drawing.Point(15, 135);
            this.CheckBox_ShowInTaskbar.Name = "CheckBox_ShowInTaskbar";
            this.CheckBox_ShowInTaskbar.Size = new System.Drawing.Size(116, 21);
            this.CheckBox_ShowInTaskbar.TabIndex = 0;
            this.CheckBox_ShowInTaskbar.TabStop = false;
            this.CheckBox_ShowInTaskbar.Text = "ShowInTaskbar";
            this.CheckBox_ShowInTaskbar.UseVisualStyleBackColor = true;
            this.CheckBox_ShowInTaskbar.CheckedChanged += new System.EventHandler(this.CheckBox_ShowInTaskbar_CheckedChanged);
            // 
            // Button_CaptionFont
            // 
            this.Button_CaptionFont.AutoEllipsis = true;
            this.Button_CaptionFont.FlatAppearance.BorderSize = 0;
            this.Button_CaptionFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CaptionFont.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Button_CaptionFont.Location = new System.Drawing.Point(15, 90);
            this.Button_CaptionFont.Name = "Button_CaptionFont";
            this.Button_CaptionFont.Size = new System.Drawing.Size(250, 25);
            this.Button_CaptionFont.TabIndex = 0;
            this.Button_CaptionFont.TabStop = false;
            this.Button_CaptionFont.Text = "CaptionFont";
            this.Button_CaptionFont.UseVisualStyleBackColor = true;
            this.Button_CaptionFont.Click += new System.EventHandler(this.Button_CaptionFont_Click);
            // 
            // ComboBox_CaptionAlign
            // 
            this.ComboBox_CaptionAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CaptionAlign.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_CaptionAlign.FormattingEnabled = true;
            this.ComboBox_CaptionAlign.Items.AddRange(new object[] {
            "TopLeft",
            "TopCenter",
            "TopRight",
            "MiddleLeft",
            "MiddleCenter",
            "MiddleRight",
            "BottomLeft",
            "BottomCenter",
            "BottomRight"});
            this.ComboBox_CaptionAlign.Location = new System.Drawing.Point(15, 120);
            this.ComboBox_CaptionAlign.Name = "ComboBox_CaptionAlign";
            this.ComboBox_CaptionAlign.Size = new System.Drawing.Size(250, 25);
            this.ComboBox_CaptionAlign.TabIndex = 0;
            this.ComboBox_CaptionAlign.TabStop = false;
            this.ComboBox_CaptionAlign.SelectedIndexChanged += new System.EventHandler(this.ComboBox_CaptionAlign_SelectedIndexChanged);
            // 
            // CheckBox_ShowIconOnCaptionBar
            // 
            this.CheckBox_ShowIconOnCaptionBar.AutoSize = true;
            this.CheckBox_ShowIconOnCaptionBar.Checked = true;
            this.CheckBox_ShowIconOnCaptionBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_ShowIconOnCaptionBar.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_ShowIconOnCaptionBar.Location = new System.Drawing.Point(15, 85);
            this.CheckBox_ShowIconOnCaptionBar.Name = "CheckBox_ShowIconOnCaptionBar";
            this.CheckBox_ShowIconOnCaptionBar.Size = new System.Drawing.Size(165, 21);
            this.CheckBox_ShowIconOnCaptionBar.TabIndex = 0;
            this.CheckBox_ShowIconOnCaptionBar.TabStop = false;
            this.CheckBox_ShowIconOnCaptionBar.Text = "ShowIconOnCaptionBar";
            this.CheckBox_ShowIconOnCaptionBar.UseVisualStyleBackColor = true;
            this.CheckBox_ShowIconOnCaptionBar.CheckedChanged += new System.EventHandler(this.CheckBox_ShowIconOnCaptionBar_CheckedChanged);
            // 
            // CheckBox_ShowShadowColor
            // 
            this.CheckBox_ShowShadowColor.AutoSize = true;
            this.CheckBox_ShowShadowColor.Checked = true;
            this.CheckBox_ShowShadowColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_ShowShadowColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_ShowShadowColor.Location = new System.Drawing.Point(15, 200);
            this.CheckBox_ShowShadowColor.Name = "CheckBox_ShowShadowColor";
            this.CheckBox_ShowShadowColor.Size = new System.Drawing.Size(136, 21);
            this.CheckBox_ShowShadowColor.TabIndex = 0;
            this.CheckBox_ShowShadowColor.TabStop = false;
            this.CheckBox_ShowShadowColor.Text = "ShowShadowColor";
            this.CheckBox_ShowShadowColor.UseVisualStyleBackColor = true;
            this.CheckBox_ShowShadowColor.CheckedChanged += new System.EventHandler(this.CheckBox_ShowShadowColor_CheckedChanged);
            // 
            // Panel_Main
            // 
            this.Panel_Main.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Main.Controls.Add(this.Panel_FormStyle);
            this.Panel_Main.Controls.Add(this.Panel_FormAppearance);
            this.Panel_Main.Controls.Add(this.Panel_FormState);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(330, 540);
            this.Panel_Main.TabIndex = 0;
            // 
            // Panel_FormStyle
            // 
            this.Panel_FormStyle.Controls.Add(this.Label_FormStyle);
            this.Panel_FormStyle.Controls.Add(this.ComboBox_FormStyle);
            this.Panel_FormStyle.Controls.Add(this.CheckBox_EnableFullScreen);
            this.Panel_FormStyle.Controls.Add(this.CheckBox_ShowIconOnCaptionBar);
            this.Panel_FormStyle.Controls.Add(this.CheckBox_TopMost);
            this.Panel_FormStyle.Controls.Add(this.CheckBox_ShowInTaskbar);
            this.Panel_FormStyle.Location = new System.Drawing.Point(25, 25);
            this.Panel_FormStyle.Name = "Panel_FormStyle";
            this.Panel_FormStyle.Size = new System.Drawing.Size(280, 165);
            this.Panel_FormStyle.TabIndex = 0;
            this.Panel_FormStyle.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_FormStyle_Paint);
            // 
            // Label_FormStyle
            // 
            this.Label_FormStyle.AutoSize = true;
            this.Label_FormStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_FormStyle.Location = new System.Drawing.Point(0, 0);
            this.Label_FormStyle.Name = "Label_FormStyle";
            this.Label_FormStyle.Size = new System.Drawing.Size(70, 17);
            this.Label_FormStyle.TabIndex = 0;
            this.Label_FormStyle.Text = "FormStyle";
            // 
            // Panel_FormAppearance
            // 
            this.Panel_FormAppearance.Controls.Add(this.Label_FormAppearance);
            this.Panel_FormAppearance.Controls.Add(this.ComboBox_Theme);
            this.Panel_FormAppearance.Controls.Add(this.Button_ThemeColor);
            this.Panel_FormAppearance.Controls.Add(this.Button_CaptionFont);
            this.Panel_FormAppearance.Controls.Add(this.ComboBox_CaptionAlign);
            this.Panel_FormAppearance.Controls.Add(this.CheckBox_ShowCaptionBarColor);
            this.Panel_FormAppearance.Controls.Add(this.CheckBox_EnableCaptionBarTransparent);
            this.Panel_FormAppearance.Controls.Add(this.CheckBox_ShowShadowColor);
            this.Panel_FormAppearance.Location = new System.Drawing.Point(25, 190);
            this.Panel_FormAppearance.Name = "Panel_FormAppearance";
            this.Panel_FormAppearance.Size = new System.Drawing.Size(280, 230);
            this.Panel_FormAppearance.TabIndex = 0;
            this.Panel_FormAppearance.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_FormAppearance_Paint);
            // 
            // Label_FormAppearance
            // 
            this.Label_FormAppearance.AutoSize = true;
            this.Label_FormAppearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_FormAppearance.Location = new System.Drawing.Point(0, 0);
            this.Label_FormAppearance.Name = "Label_FormAppearance";
            this.Label_FormAppearance.Size = new System.Drawing.Size(112, 17);
            this.Label_FormAppearance.TabIndex = 0;
            this.Label_FormAppearance.Text = "FormAppearance";
            // 
            // Panel_FormState
            // 
            this.Panel_FormState.Controls.Add(this.Label_FormState);
            this.Panel_FormState.Controls.Add(this.ComboBox_FormState);
            this.Panel_FormState.Controls.Add(this.ComboBox_FormAction);
            this.Panel_FormState.Location = new System.Drawing.Point(25, 420);
            this.Panel_FormState.Name = "Panel_FormState";
            this.Panel_FormState.Size = new System.Drawing.Size(280, 95);
            this.Panel_FormState.TabIndex = 0;
            this.Panel_FormState.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_FormState_Paint);
            // 
            // Label_FormState
            // 
            this.Label_FormState.AutoSize = true;
            this.Label_FormState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_FormState.Location = new System.Drawing.Point(0, 0);
            this.Label_FormState.Name = "Label_FormState";
            this.Label_FormState.Size = new System.Drawing.Size(71, 17);
            this.Label_FormState.TabIndex = 0;
            this.Label_FormState.Text = "FormState";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 540);
            this.Controls.Add(this.Panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "主窗体";
            this.Panel_Main.ResumeLayout(false);
            this.Panel_FormStyle.ResumeLayout(false);
            this.Panel_FormStyle.PerformLayout();
            this.Panel_FormAppearance.ResumeLayout(false);
            this.Panel_FormAppearance.PerformLayout();
            this.Panel_FormState.ResumeLayout(false);
            this.Panel_FormState.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_FormState;
        private System.Windows.Forms.ComboBox ComboBox_FormAction;
        private System.Windows.Forms.ComboBox ComboBox_FormStyle;
        private System.Windows.Forms.CheckBox CheckBox_EnableFullScreen;
        private System.Windows.Forms.CheckBox CheckBox_ShowCaptionBarColor;
        private System.Windows.Forms.CheckBox CheckBox_EnableCaptionBarTransparent;
        private System.Windows.Forms.ColorDialog ColorDialog_ThemeColor;
        private System.Windows.Forms.Button Button_ThemeColor;
        private System.Windows.Forms.ComboBox ComboBox_Theme;
        private System.Windows.Forms.CheckBox CheckBox_TopMost;
        private System.Windows.Forms.CheckBox CheckBox_ShowInTaskbar;
        private System.Windows.Forms.FontDialog FontDialog_CaptionFont;
        private System.Windows.Forms.Button Button_CaptionFont;
        private System.Windows.Forms.ComboBox ComboBox_CaptionAlign;
        private System.Windows.Forms.CheckBox CheckBox_ShowIconOnCaptionBar;
        private System.Windows.Forms.CheckBox CheckBox_ShowShadowColor;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Panel Panel_FormStyle;
        private System.Windows.Forms.Label Label_FormStyle;
        private System.Windows.Forms.Panel Panel_FormState;
        private System.Windows.Forms.Label Label_FormState;
        private System.Windows.Forms.Panel Panel_FormAppearance;
        private System.Windows.Forms.Label Label_FormAppearance;
    }
}