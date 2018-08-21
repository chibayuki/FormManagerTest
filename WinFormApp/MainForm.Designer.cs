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
            this.ComboBox_FormState.Location = new System.Drawing.Point(20, 150);
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
            this.ComboBox_FormAction.Location = new System.Drawing.Point(20, 180);
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
            this.ComboBox_FormStyle.Location = new System.Drawing.Point(20, 20);
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
            this.CheckBox_EnableFullScreen.Location = new System.Drawing.Point(20, 50);
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
            this.CheckBox_ShowCaptionBarColor.Location = new System.Drawing.Point(20, 330);
            this.CheckBox_ShowCaptionBarColor.Name = "CheckBox_ShowCaptionBarColor";
            this.CheckBox_ShowCaptionBarColor.Size = new System.Drawing.Size(168, 21);
            this.CheckBox_ShowCaptionBarColor.TabIndex = 0;
            this.CheckBox_ShowCaptionBarColor.TabStop = false;
            this.CheckBox_ShowCaptionBarColor.Text = "ShowFormTitleBarColor ";
            this.CheckBox_ShowCaptionBarColor.UseVisualStyleBackColor = true;
            this.CheckBox_ShowCaptionBarColor.CheckedChanged += new System.EventHandler(this.CheckBox_ShowCaptionBarColor_CheckedChanged);
            // 
            // CheckBox_EnableCaptionBarTransparent
            // 
            this.CheckBox_EnableCaptionBarTransparent.AutoSize = true;
            this.CheckBox_EnableCaptionBarTransparent.Checked = true;
            this.CheckBox_EnableCaptionBarTransparent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_EnableCaptionBarTransparent.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_EnableCaptionBarTransparent.Location = new System.Drawing.Point(20, 355);
            this.CheckBox_EnableCaptionBarTransparent.Name = "CheckBox_EnableCaptionBarTransparent";
            this.CheckBox_EnableCaptionBarTransparent.Size = new System.Drawing.Size(214, 21);
            this.CheckBox_EnableCaptionBarTransparent.TabIndex = 0;
            this.CheckBox_EnableCaptionBarTransparent.TabStop = false;
            this.CheckBox_EnableCaptionBarTransparent.Text = "EnableFormTitleBarTransparent ";
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
            this.Button_ThemeColor.Location = new System.Drawing.Point(20, 240);
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
            this.ComboBox_Theme.Location = new System.Drawing.Point(20, 210);
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
            this.CheckBox_TopMost.Location = new System.Drawing.Point(20, 100);
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
            this.CheckBox_ShowInTaskbar.Location = new System.Drawing.Point(20, 125);
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
            this.Button_CaptionFont.Location = new System.Drawing.Point(20, 270);
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
            this.ComboBox_CaptionAlign.Location = new System.Drawing.Point(20, 300);
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
            this.CheckBox_ShowIconOnCaptionBar.Location = new System.Drawing.Point(20, 75);
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
            this.CheckBox_ShowShadowColor.Location = new System.Drawing.Point(20, 380);
            this.CheckBox_ShowShadowColor.Name = "CheckBox_ShowShadowColor";
            this.CheckBox_ShowShadowColor.Size = new System.Drawing.Size(136, 21);
            this.CheckBox_ShowShadowColor.TabIndex = 0;
            this.CheckBox_ShowShadowColor.TabStop = false;
            this.CheckBox_ShowShadowColor.Text = "ShowShadowColor";
            this.CheckBox_ShowShadowColor.UseVisualStyleBackColor = true;
            this.CheckBox_ShowShadowColor.CheckedChanged += new System.EventHandler(this.CheckBox_ShowShadowColor_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 420);
            this.Controls.Add(this.ComboBox_FormStyle);
            this.Controls.Add(this.CheckBox_EnableFullScreen);
            this.Controls.Add(this.CheckBox_ShowIconOnCaptionBar);
            this.Controls.Add(this.CheckBox_TopMost);
            this.Controls.Add(this.CheckBox_ShowInTaskbar);
            this.Controls.Add(this.ComboBox_FormState);
            this.Controls.Add(this.ComboBox_FormAction);
            this.Controls.Add(this.ComboBox_Theme);
            this.Controls.Add(this.Button_ThemeColor);
            this.Controls.Add(this.Button_CaptionFont);
            this.Controls.Add(this.ComboBox_CaptionAlign);
            this.Controls.Add(this.CheckBox_ShowCaptionBarColor);
            this.Controls.Add(this.CheckBox_EnableCaptionBarTransparent);
            this.Controls.Add(this.CheckBox_ShowShadowColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "主窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}