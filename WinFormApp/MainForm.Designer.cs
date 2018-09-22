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
            this.ComboBox_FormStateEnum = new System.Windows.Forms.ComboBox();
            this.ComboBox_FormActionEnum = new System.Windows.Forms.ComboBox();
            this.ComboBox_FormStyleEnum = new System.Windows.Forms.ComboBox();
            this.CheckBox_EnableFullScreen = new System.Windows.Forms.CheckBox();
            this.CheckBox_ShowCaptionBarColor = new System.Windows.Forms.CheckBox();
            this.CheckBox_EnableCaptionBarTransparent = new System.Windows.Forms.CheckBox();
            this.ColorDialog_ThemeColor = new System.Windows.Forms.ColorDialog();
            this.ComboBox_ThemeEnum = new System.Windows.Forms.ComboBox();
            this.CheckBox_TopMost = new System.Windows.Forms.CheckBox();
            this.CheckBox_ShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.FontDialog_CaptionFont = new System.Windows.Forms.FontDialog();
            this.ComboBox_CaptionAlignEnum = new System.Windows.Forms.ComboBox();
            this.CheckBox_ShowIconOnCaptionBar = new System.Windows.Forms.CheckBox();
            this.CheckBox_ShowShadowColor = new System.Windows.Forms.CheckBox();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Panel_Client = new System.Windows.Forms.Panel();
            this.Panel_FormStyle = new System.Windows.Forms.Panel();
            this.Label_FormStyle = new System.Windows.Forms.Label();
            this.Label_FormStyleEnum = new System.Windows.Forms.Label();
            this.CheckBox_EnableMinimize = new System.Windows.Forms.CheckBox();
            this.CheckBox_EnableMaximize = new System.Windows.Forms.CheckBox();
            this.Panel_FormAppearance = new System.Windows.Forms.Panel();
            this.Label_FormAppearance = new System.Windows.Forms.Label();
            this.Label_ThemeEnum = new System.Windows.Forms.Label();
            this.Label_ThemeColor = new System.Windows.Forms.Label();
            this.Label_ThemeColor_Value = new System.Windows.Forms.Label();
            this.Label_Caption = new System.Windows.Forms.Label();
            this.TextBox_Caption = new System.Windows.Forms.TextBox();
            this.CheckBox_ShowCaption = new System.Windows.Forms.CheckBox();
            this.Label_CaptionFont = new System.Windows.Forms.Label();
            this.Label_CaptionFont_Value = new System.Windows.Forms.Label();
            this.Label_CaptionAlignEnum = new System.Windows.Forms.Label();
            this.Panel_FormState = new System.Windows.Forms.Panel();
            this.Label_FormState = new System.Windows.Forms.Label();
            this.Label_FormStateEnum = new System.Windows.Forms.Label();
            this.Label_FormActionEnum = new System.Windows.Forms.Label();
            this.Label_BoundsLocation = new System.Windows.Forms.Label();
            this.TextBox_BoundsX = new System.Windows.Forms.TextBox();
            this.Label_BoundsLocationSeparator = new System.Windows.Forms.Label();
            this.TextBox_BoundsY = new System.Windows.Forms.TextBox();
            this.Label_BoundsSize = new System.Windows.Forms.Label();
            this.TextBox_BoundsWidth = new System.Windows.Forms.TextBox();
            this.Label_BoundsSizeSeparator = new System.Windows.Forms.Label();
            this.TextBox_BoundsHeight = new System.Windows.Forms.TextBox();
            this.Panel_Other = new System.Windows.Forms.Panel();
            this.Label_Other = new System.Windows.Forms.Label();
            this.CheckBox_ImmersiveExperience = new System.Windows.Forms.CheckBox();
            this.Label_ImmersiveExperience = new System.Windows.Forms.Label();
            this.OpenFileDialog_ImmersiveExperience = new System.Windows.Forms.OpenFileDialog();
            this.Panel_Main.SuspendLayout();
            this.Panel_Client.SuspendLayout();
            this.Panel_FormStyle.SuspendLayout();
            this.Panel_FormAppearance.SuspendLayout();
            this.Panel_FormState.SuspendLayout();
            this.Panel_Other.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBox_FormStateEnum
            // 
            this.ComboBox_FormStateEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FormStateEnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_FormStateEnum.FormattingEnabled = true;
            this.ComboBox_FormStateEnum.Items.AddRange(new object[] {
            "Normal",
            "Minimized",
            "Maximized",
            "FullScreen",
            "HighAsScreen",
            "QuarterScreen"});
            this.ComboBox_FormStateEnum.Location = new System.Drawing.Point(115, 30);
            this.ComboBox_FormStateEnum.Name = "ComboBox_FormStateEnum";
            this.ComboBox_FormStateEnum.Size = new System.Drawing.Size(170, 25);
            this.ComboBox_FormStateEnum.TabIndex = 0;
            this.ComboBox_FormStateEnum.TabStop = false;
            this.ComboBox_FormStateEnum.SelectedIndexChanged += new System.EventHandler(this.ComboBox_FormStateEnum_SelectedIndexChanged);
            // 
            // ComboBox_FormActionEnum
            // 
            this.ComboBox_FormActionEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FormActionEnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_FormActionEnum.FormattingEnabled = true;
            this.ComboBox_FormActionEnum.Items.AddRange(new object[] {
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
            this.ComboBox_FormActionEnum.Location = new System.Drawing.Point(115, 60);
            this.ComboBox_FormActionEnum.Name = "ComboBox_FormActionEnum";
            this.ComboBox_FormActionEnum.Size = new System.Drawing.Size(170, 25);
            this.ComboBox_FormActionEnum.TabIndex = 0;
            this.ComboBox_FormActionEnum.TabStop = false;
            this.ComboBox_FormActionEnum.SelectedIndexChanged += new System.EventHandler(this.ComboBox_FormActionEnum_SelectedIndexChanged);
            // 
            // ComboBox_FormStyleEnum
            // 
            this.ComboBox_FormStyleEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FormStyleEnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_FormStyleEnum.FormattingEnabled = true;
            this.ComboBox_FormStyleEnum.Items.AddRange(new object[] {
            "Sizable",
            "Fixed"});
            this.ComboBox_FormStyleEnum.Location = new System.Drawing.Point(115, 30);
            this.ComboBox_FormStyleEnum.Name = "ComboBox_FormStyleEnum";
            this.ComboBox_FormStyleEnum.Size = new System.Drawing.Size(170, 25);
            this.ComboBox_FormStyleEnum.TabIndex = 0;
            this.ComboBox_FormStyleEnum.TabStop = false;
            this.ComboBox_FormStyleEnum.SelectedIndexChanged += new System.EventHandler(this.ComboBox_FormStyleEnum_SelectedIndexChanged);
            // 
            // CheckBox_EnableFullScreen
            // 
            this.CheckBox_EnableFullScreen.AutoSize = true;
            this.CheckBox_EnableFullScreen.Checked = true;
            this.CheckBox_EnableFullScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_EnableFullScreen.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_EnableFullScreen.ForeColor = System.Drawing.Color.White;
            this.CheckBox_EnableFullScreen.Location = new System.Drawing.Point(15, 110);
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
            this.CheckBox_ShowCaptionBarColor.ForeColor = System.Drawing.Color.White;
            this.CheckBox_ShowCaptionBarColor.Location = new System.Drawing.Point(15, 195);
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
            this.CheckBox_EnableCaptionBarTransparent.ForeColor = System.Drawing.Color.White;
            this.CheckBox_EnableCaptionBarTransparent.Location = new System.Drawing.Point(15, 220);
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
            // ComboBox_ThemeEnum
            // 
            this.ComboBox_ThemeEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_ThemeEnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_ThemeEnum.FormattingEnabled = true;
            this.ComboBox_ThemeEnum.Items.AddRange(new object[] {
            "Colorful",
            "White",
            "LightGray",
            "DarkGray",
            "Black"});
            this.ComboBox_ThemeEnum.Location = new System.Drawing.Point(115, 30);
            this.ComboBox_ThemeEnum.Name = "ComboBox_ThemeEnum";
            this.ComboBox_ThemeEnum.Size = new System.Drawing.Size(170, 25);
            this.ComboBox_ThemeEnum.TabIndex = 0;
            this.ComboBox_ThemeEnum.TabStop = false;
            this.ComboBox_ThemeEnum.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ThemeEnum_SelectedIndexChanged);
            // 
            // CheckBox_TopMost
            // 
            this.CheckBox_TopMost.AutoSize = true;
            this.CheckBox_TopMost.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_TopMost.ForeColor = System.Drawing.Color.White;
            this.CheckBox_TopMost.Location = new System.Drawing.Point(15, 185);
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
            this.CheckBox_ShowInTaskbar.ForeColor = System.Drawing.Color.White;
            this.CheckBox_ShowInTaskbar.Location = new System.Drawing.Point(15, 160);
            this.CheckBox_ShowInTaskbar.Name = "CheckBox_ShowInTaskbar";
            this.CheckBox_ShowInTaskbar.Size = new System.Drawing.Size(116, 21);
            this.CheckBox_ShowInTaskbar.TabIndex = 0;
            this.CheckBox_ShowInTaskbar.TabStop = false;
            this.CheckBox_ShowInTaskbar.Text = "ShowInTaskbar";
            this.CheckBox_ShowInTaskbar.UseVisualStyleBackColor = true;
            this.CheckBox_ShowInTaskbar.CheckedChanged += new System.EventHandler(this.CheckBox_ShowInTaskbar_CheckedChanged);
            // 
            // ComboBox_CaptionAlignEnum
            // 
            this.ComboBox_CaptionAlignEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CaptionAlignEnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_CaptionAlignEnum.FormattingEnabled = true;
            this.ComboBox_CaptionAlignEnum.Items.AddRange(new object[] {
            "TopLeft",
            "TopCenter",
            "TopRight",
            "MiddleLeft",
            "MiddleCenter",
            "MiddleRight",
            "BottomLeft",
            "BottomCenter",
            "BottomRight"});
            this.ComboBox_CaptionAlignEnum.Location = new System.Drawing.Point(115, 165);
            this.ComboBox_CaptionAlignEnum.Name = "ComboBox_CaptionAlignEnum";
            this.ComboBox_CaptionAlignEnum.Size = new System.Drawing.Size(170, 25);
            this.ComboBox_CaptionAlignEnum.TabIndex = 0;
            this.ComboBox_CaptionAlignEnum.TabStop = false;
            this.ComboBox_CaptionAlignEnum.SelectedIndexChanged += new System.EventHandler(this.ComboBox_CaptionAlignEnum_SelectedIndexChanged);
            // 
            // CheckBox_ShowIconOnCaptionBar
            // 
            this.CheckBox_ShowIconOnCaptionBar.AutoSize = true;
            this.CheckBox_ShowIconOnCaptionBar.Checked = true;
            this.CheckBox_ShowIconOnCaptionBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_ShowIconOnCaptionBar.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_ShowIconOnCaptionBar.ForeColor = System.Drawing.Color.White;
            this.CheckBox_ShowIconOnCaptionBar.Location = new System.Drawing.Point(15, 135);
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
            this.CheckBox_ShowShadowColor.ForeColor = System.Drawing.Color.White;
            this.CheckBox_ShowShadowColor.Location = new System.Drawing.Point(15, 245);
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
            this.Panel_Main.AutoScroll = true;
            this.Panel_Main.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Main.Controls.Add(this.Panel_Client);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(350, 750);
            this.Panel_Main.TabIndex = 0;
            this.Panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Main_Paint);
            // 
            // Panel_Client
            // 
            this.Panel_Client.Controls.Add(this.Panel_FormStyle);
            this.Panel_Client.Controls.Add(this.Panel_FormAppearance);
            this.Panel_Client.Controls.Add(this.Panel_FormState);
            this.Panel_Client.Controls.Add(this.Panel_Other);
            this.Panel_Client.Location = new System.Drawing.Point(0, 0);
            this.Panel_Client.Name = "Panel_Client";
            this.Panel_Client.Size = new System.Drawing.Size(350, 750);
            this.Panel_Client.TabIndex = 0;
            // 
            // Panel_FormStyle
            // 
            this.Panel_FormStyle.Controls.Add(this.Label_FormStyle);
            this.Panel_FormStyle.Controls.Add(this.Label_FormStyleEnum);
            this.Panel_FormStyle.Controls.Add(this.ComboBox_FormStyleEnum);
            this.Panel_FormStyle.Controls.Add(this.CheckBox_EnableMinimize);
            this.Panel_FormStyle.Controls.Add(this.CheckBox_EnableMaximize);
            this.Panel_FormStyle.Controls.Add(this.CheckBox_EnableFullScreen);
            this.Panel_FormStyle.Controls.Add(this.CheckBox_ShowIconOnCaptionBar);
            this.Panel_FormStyle.Controls.Add(this.CheckBox_ShowInTaskbar);
            this.Panel_FormStyle.Controls.Add(this.CheckBox_TopMost);
            this.Panel_FormStyle.Location = new System.Drawing.Point(25, 25);
            this.Panel_FormStyle.Name = "Panel_FormStyle";
            this.Panel_FormStyle.Size = new System.Drawing.Size(300, 215);
            this.Panel_FormStyle.TabIndex = 0;
            this.Panel_FormStyle.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_FormStyle_Paint);
            // 
            // Label_FormStyle
            // 
            this.Label_FormStyle.AutoSize = true;
            this.Label_FormStyle.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_FormStyle.ForeColor = System.Drawing.Color.White;
            this.Label_FormStyle.Location = new System.Drawing.Point(0, 0);
            this.Label_FormStyle.Name = "Label_FormStyle";
            this.Label_FormStyle.Size = new System.Drawing.Size(69, 20);
            this.Label_FormStyle.TabIndex = 0;
            this.Label_FormStyle.Text = "窗口样式";
            // 
            // Label_FormStyleEnum
            // 
            this.Label_FormStyleEnum.AutoSize = true;
            this.Label_FormStyleEnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_FormStyleEnum.ForeColor = System.Drawing.Color.White;
            this.Label_FormStyleEnum.Location = new System.Drawing.Point(15, 34);
            this.Label_FormStyleEnum.Name = "Label_FormStyleEnum";
            this.Label_FormStyleEnum.Size = new System.Drawing.Size(68, 17);
            this.Label_FormStyleEnum.TabIndex = 0;
            this.Label_FormStyleEnum.Text = "FormStyle:";
            // 
            // CheckBox_EnableMinimize
            // 
            this.CheckBox_EnableMinimize.AutoSize = true;
            this.CheckBox_EnableMinimize.Checked = true;
            this.CheckBox_EnableMinimize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_EnableMinimize.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_EnableMinimize.ForeColor = System.Drawing.Color.White;
            this.CheckBox_EnableMinimize.Location = new System.Drawing.Point(15, 60);
            this.CheckBox_EnableMinimize.Name = "CheckBox_EnableMinimize";
            this.CheckBox_EnableMinimize.Size = new System.Drawing.Size(118, 21);
            this.CheckBox_EnableMinimize.TabIndex = 0;
            this.CheckBox_EnableMinimize.TabStop = false;
            this.CheckBox_EnableMinimize.Text = "EnableMinimize";
            this.CheckBox_EnableMinimize.UseVisualStyleBackColor = true;
            this.CheckBox_EnableMinimize.CheckedChanged += new System.EventHandler(this.CheckBox_EnableMinimize_CheckedChanged);
            // 
            // CheckBox_EnableMaximize
            // 
            this.CheckBox_EnableMaximize.AutoSize = true;
            this.CheckBox_EnableMaximize.Checked = true;
            this.CheckBox_EnableMaximize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_EnableMaximize.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_EnableMaximize.ForeColor = System.Drawing.Color.White;
            this.CheckBox_EnableMaximize.Location = new System.Drawing.Point(15, 85);
            this.CheckBox_EnableMaximize.Name = "CheckBox_EnableMaximize";
            this.CheckBox_EnableMaximize.Size = new System.Drawing.Size(121, 21);
            this.CheckBox_EnableMaximize.TabIndex = 0;
            this.CheckBox_EnableMaximize.TabStop = false;
            this.CheckBox_EnableMaximize.Text = "EnableMaximize";
            this.CheckBox_EnableMaximize.UseVisualStyleBackColor = true;
            this.CheckBox_EnableMaximize.CheckedChanged += new System.EventHandler(this.CheckBox_EnableMaximize_CheckedChanged);
            // 
            // Panel_FormAppearance
            // 
            this.Panel_FormAppearance.Controls.Add(this.Label_FormAppearance);
            this.Panel_FormAppearance.Controls.Add(this.Label_ThemeEnum);
            this.Panel_FormAppearance.Controls.Add(this.ComboBox_ThemeEnum);
            this.Panel_FormAppearance.Controls.Add(this.Label_ThemeColor);
            this.Panel_FormAppearance.Controls.Add(this.Label_ThemeColor_Value);
            this.Panel_FormAppearance.Controls.Add(this.Label_Caption);
            this.Panel_FormAppearance.Controls.Add(this.TextBox_Caption);
            this.Panel_FormAppearance.Controls.Add(this.CheckBox_ShowCaption);
            this.Panel_FormAppearance.Controls.Add(this.Label_CaptionFont);
            this.Panel_FormAppearance.Controls.Add(this.Label_CaptionFont_Value);
            this.Panel_FormAppearance.Controls.Add(this.Label_CaptionAlignEnum);
            this.Panel_FormAppearance.Controls.Add(this.ComboBox_CaptionAlignEnum);
            this.Panel_FormAppearance.Controls.Add(this.CheckBox_ShowCaptionBarColor);
            this.Panel_FormAppearance.Controls.Add(this.CheckBox_EnableCaptionBarTransparent);
            this.Panel_FormAppearance.Controls.Add(this.CheckBox_ShowShadowColor);
            this.Panel_FormAppearance.Location = new System.Drawing.Point(25, 240);
            this.Panel_FormAppearance.Name = "Panel_FormAppearance";
            this.Panel_FormAppearance.Size = new System.Drawing.Size(300, 275);
            this.Panel_FormAppearance.TabIndex = 0;
            this.Panel_FormAppearance.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_FormAppearance_Paint);
            // 
            // Label_FormAppearance
            // 
            this.Label_FormAppearance.AutoSize = true;
            this.Label_FormAppearance.Font = new System.Drawing.Font("微软雅黑", 11.25F);
            this.Label_FormAppearance.ForeColor = System.Drawing.Color.White;
            this.Label_FormAppearance.Location = new System.Drawing.Point(0, 0);
            this.Label_FormAppearance.Name = "Label_FormAppearance";
            this.Label_FormAppearance.Size = new System.Drawing.Size(69, 20);
            this.Label_FormAppearance.TabIndex = 0;
            this.Label_FormAppearance.Text = "窗口外观";
            // 
            // Label_ThemeEnum
            // 
            this.Label_ThemeEnum.AutoSize = true;
            this.Label_ThemeEnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_ThemeEnum.ForeColor = System.Drawing.Color.White;
            this.Label_ThemeEnum.Location = new System.Drawing.Point(15, 34);
            this.Label_ThemeEnum.Name = "Label_ThemeEnum";
            this.Label_ThemeEnum.Size = new System.Drawing.Size(50, 17);
            this.Label_ThemeEnum.TabIndex = 0;
            this.Label_ThemeEnum.Text = "Theme:";
            // 
            // Label_ThemeColor
            // 
            this.Label_ThemeColor.AutoSize = true;
            this.Label_ThemeColor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_ThemeColor.ForeColor = System.Drawing.Color.White;
            this.Label_ThemeColor.Location = new System.Drawing.Point(15, 60);
            this.Label_ThemeColor.Name = "Label_ThemeColor";
            this.Label_ThemeColor.Size = new System.Drawing.Size(82, 17);
            this.Label_ThemeColor.TabIndex = 0;
            this.Label_ThemeColor.Text = "ThemeColor:";
            // 
            // Label_ThemeColor_Value
            // 
            this.Label_ThemeColor_Value.AutoSize = true;
            this.Label_ThemeColor_Value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_ThemeColor_Value.ForeColor = System.Drawing.Color.White;
            this.Label_ThemeColor_Value.Location = new System.Drawing.Point(115, 60);
            this.Label_ThemeColor_Value.Name = "Label_ThemeColor_Value";
            this.Label_ThemeColor_Value.Size = new System.Drawing.Size(79, 17);
            this.Label_ThemeColor_Value.TabIndex = 0;
            this.Label_ThemeColor_Value.Text = "ThemeColor";
            // 
            // Label_Caption
            // 
            this.Label_Caption.AutoSize = true;
            this.Label_Caption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Caption.ForeColor = System.Drawing.Color.White;
            this.Label_Caption.Location = new System.Drawing.Point(15, 89);
            this.Label_Caption.Name = "Label_Caption";
            this.Label_Caption.Size = new System.Drawing.Size(56, 17);
            this.Label_Caption.TabIndex = 0;
            this.Label_Caption.Text = "Caption:";
            // 
            // TextBox_Caption
            // 
            this.TextBox_Caption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Caption.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.TextBox_Caption.Location = new System.Drawing.Point(115, 89);
            this.TextBox_Caption.Name = "TextBox_Caption";
            this.TextBox_Caption.Size = new System.Drawing.Size(170, 16);
            this.TextBox_Caption.TabIndex = 0;
            this.TextBox_Caption.TabStop = false;
            this.TextBox_Caption.TextChanged += new System.EventHandler(this.TextBox_Caption_TextChanged);
            // 
            // CheckBox_ShowCaption
            // 
            this.CheckBox_ShowCaption.AutoSize = true;
            this.CheckBox_ShowCaption.Checked = true;
            this.CheckBox_ShowCaption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_ShowCaption.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_ShowCaption.ForeColor = System.Drawing.Color.White;
            this.CheckBox_ShowCaption.Location = new System.Drawing.Point(15, 115);
            this.CheckBox_ShowCaption.Name = "CheckBox_ShowCaption";
            this.CheckBox_ShowCaption.Size = new System.Drawing.Size(103, 21);
            this.CheckBox_ShowCaption.TabIndex = 0;
            this.CheckBox_ShowCaption.TabStop = false;
            this.CheckBox_ShowCaption.Text = "ShowCaption";
            this.CheckBox_ShowCaption.UseVisualStyleBackColor = true;
            this.CheckBox_ShowCaption.CheckedChanged += new System.EventHandler(this.CheckBox_ShowCaption_CheckedChanged);
            // 
            // Label_CaptionFont
            // 
            this.Label_CaptionFont.AutoSize = true;
            this.Label_CaptionFont.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_CaptionFont.ForeColor = System.Drawing.Color.White;
            this.Label_CaptionFont.Location = new System.Drawing.Point(15, 140);
            this.Label_CaptionFont.Name = "Label_CaptionFont";
            this.Label_CaptionFont.Size = new System.Drawing.Size(81, 17);
            this.Label_CaptionFont.TabIndex = 0;
            this.Label_CaptionFont.Text = "CaptionFont:";
            // 
            // Label_CaptionFont_Value
            // 
            this.Label_CaptionFont_Value.AutoSize = true;
            this.Label_CaptionFont_Value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_CaptionFont_Value.ForeColor = System.Drawing.Color.White;
            this.Label_CaptionFont_Value.Location = new System.Drawing.Point(115, 140);
            this.Label_CaptionFont_Value.Name = "Label_CaptionFont_Value";
            this.Label_CaptionFont_Value.Size = new System.Drawing.Size(78, 17);
            this.Label_CaptionFont_Value.TabIndex = 0;
            this.Label_CaptionFont_Value.Text = "CaptionFont";
            // 
            // Label_CaptionAlignEnum
            // 
            this.Label_CaptionAlignEnum.AutoSize = true;
            this.Label_CaptionAlignEnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_CaptionAlignEnum.ForeColor = System.Drawing.Color.White;
            this.Label_CaptionAlignEnum.Location = new System.Drawing.Point(15, 169);
            this.Label_CaptionAlignEnum.Name = "Label_CaptionAlignEnum";
            this.Label_CaptionAlignEnum.Size = new System.Drawing.Size(85, 17);
            this.Label_CaptionAlignEnum.TabIndex = 0;
            this.Label_CaptionAlignEnum.Text = "CaptionAlign:";
            // 
            // Panel_FormState
            // 
            this.Panel_FormState.Controls.Add(this.Label_FormState);
            this.Panel_FormState.Controls.Add(this.Label_FormStateEnum);
            this.Panel_FormState.Controls.Add(this.ComboBox_FormStateEnum);
            this.Panel_FormState.Controls.Add(this.Label_FormActionEnum);
            this.Panel_FormState.Controls.Add(this.ComboBox_FormActionEnum);
            this.Panel_FormState.Controls.Add(this.Label_BoundsLocation);
            this.Panel_FormState.Controls.Add(this.TextBox_BoundsX);
            this.Panel_FormState.Controls.Add(this.Label_BoundsLocationSeparator);
            this.Panel_FormState.Controls.Add(this.TextBox_BoundsY);
            this.Panel_FormState.Controls.Add(this.Label_BoundsSize);
            this.Panel_FormState.Controls.Add(this.TextBox_BoundsWidth);
            this.Panel_FormState.Controls.Add(this.Label_BoundsSizeSeparator);
            this.Panel_FormState.Controls.Add(this.TextBox_BoundsHeight);
            this.Panel_FormState.Location = new System.Drawing.Point(25, 515);
            this.Panel_FormState.Name = "Panel_FormState";
            this.Panel_FormState.Size = new System.Drawing.Size(300, 150);
            this.Panel_FormState.TabIndex = 0;
            this.Panel_FormState.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_FormState_Paint);
            // 
            // Label_FormState
            // 
            this.Label_FormState.AutoSize = true;
            this.Label_FormState.Font = new System.Drawing.Font("微软雅黑", 11.25F);
            this.Label_FormState.ForeColor = System.Drawing.Color.White;
            this.Label_FormState.Location = new System.Drawing.Point(0, 0);
            this.Label_FormState.Name = "Label_FormState";
            this.Label_FormState.Size = new System.Drawing.Size(69, 20);
            this.Label_FormState.TabIndex = 0;
            this.Label_FormState.Text = "窗口状态";
            // 
            // Label_FormStateEnum
            // 
            this.Label_FormStateEnum.AutoSize = true;
            this.Label_FormStateEnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_FormStateEnum.ForeColor = System.Drawing.Color.White;
            this.Label_FormStateEnum.Location = new System.Drawing.Point(15, 34);
            this.Label_FormStateEnum.Name = "Label_FormStateEnum";
            this.Label_FormStateEnum.Size = new System.Drawing.Size(70, 17);
            this.Label_FormStateEnum.TabIndex = 0;
            this.Label_FormStateEnum.Text = "FormState:";
            // 
            // Label_FormActionEnum
            // 
            this.Label_FormActionEnum.AutoSize = true;
            this.Label_FormActionEnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_FormActionEnum.ForeColor = System.Drawing.Color.White;
            this.Label_FormActionEnum.Location = new System.Drawing.Point(15, 64);
            this.Label_FormActionEnum.Name = "Label_FormActionEnum";
            this.Label_FormActionEnum.Size = new System.Drawing.Size(77, 17);
            this.Label_FormActionEnum.TabIndex = 0;
            this.Label_FormActionEnum.Text = "FormAction:";
            // 
            // Label_BoundsLocation
            // 
            this.Label_BoundsLocation.AutoSize = true;
            this.Label_BoundsLocation.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_BoundsLocation.ForeColor = System.Drawing.Color.White;
            this.Label_BoundsLocation.Location = new System.Drawing.Point(15, 94);
            this.Label_BoundsLocation.Name = "Label_BoundsLocation";
            this.Label_BoundsLocation.Size = new System.Drawing.Size(60, 17);
            this.Label_BoundsLocation.TabIndex = 0;
            this.Label_BoundsLocation.Text = "Location:";
            // 
            // TextBox_BoundsX
            // 
            this.TextBox_BoundsX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_BoundsX.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.TextBox_BoundsX.Location = new System.Drawing.Point(115, 94);
            this.TextBox_BoundsX.MaxLength = 5;
            this.TextBox_BoundsX.Name = "TextBox_BoundsX";
            this.TextBox_BoundsX.Size = new System.Drawing.Size(75, 16);
            this.TextBox_BoundsX.TabIndex = 0;
            this.TextBox_BoundsX.TabStop = false;
            this.TextBox_BoundsX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_BoundsX.TextChanged += new System.EventHandler(this.TextBox_BoundsX_TextChanged);
            // 
            // Label_BoundsLocationSeparator
            // 
            this.Label_BoundsLocationSeparator.AutoSize = true;
            this.Label_BoundsLocationSeparator.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_BoundsLocationSeparator.ForeColor = System.Drawing.Color.White;
            this.Label_BoundsLocationSeparator.Location = new System.Drawing.Point(194, 94);
            this.Label_BoundsLocationSeparator.Name = "Label_BoundsLocationSeparator";
            this.Label_BoundsLocationSeparator.Size = new System.Drawing.Size(11, 17);
            this.Label_BoundsLocationSeparator.TabIndex = 0;
            this.Label_BoundsLocationSeparator.Text = ",";
            // 
            // TextBox_BoundsY
            // 
            this.TextBox_BoundsY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_BoundsY.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.TextBox_BoundsY.Location = new System.Drawing.Point(210, 94);
            this.TextBox_BoundsY.MaxLength = 5;
            this.TextBox_BoundsY.Name = "TextBox_BoundsY";
            this.TextBox_BoundsY.Size = new System.Drawing.Size(75, 16);
            this.TextBox_BoundsY.TabIndex = 0;
            this.TextBox_BoundsY.TabStop = false;
            this.TextBox_BoundsY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_BoundsY.TextChanged += new System.EventHandler(this.TextBox_BoundsY_TextChanged);
            // 
            // Label_BoundsSize
            // 
            this.Label_BoundsSize.AutoSize = true;
            this.Label_BoundsSize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_BoundsSize.ForeColor = System.Drawing.Color.White;
            this.Label_BoundsSize.Location = new System.Drawing.Point(15, 119);
            this.Label_BoundsSize.Name = "Label_BoundsSize";
            this.Label_BoundsSize.Size = new System.Drawing.Size(34, 17);
            this.Label_BoundsSize.TabIndex = 0;
            this.Label_BoundsSize.Text = "Size:";
            // 
            // TextBox_BoundsWidth
            // 
            this.TextBox_BoundsWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_BoundsWidth.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.TextBox_BoundsWidth.Location = new System.Drawing.Point(115, 119);
            this.TextBox_BoundsWidth.MaxLength = 5;
            this.TextBox_BoundsWidth.Name = "TextBox_BoundsWidth";
            this.TextBox_BoundsWidth.Size = new System.Drawing.Size(75, 16);
            this.TextBox_BoundsWidth.TabIndex = 0;
            this.TextBox_BoundsWidth.TabStop = false;
            this.TextBox_BoundsWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_BoundsWidth.TextChanged += new System.EventHandler(this.TextBox_BoundsWidth_TextChanged);
            // 
            // Label_BoundsSizeSeparator
            // 
            this.Label_BoundsSizeSeparator.AutoSize = true;
            this.Label_BoundsSizeSeparator.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_BoundsSizeSeparator.ForeColor = System.Drawing.Color.White;
            this.Label_BoundsSizeSeparator.Location = new System.Drawing.Point(193, 119);
            this.Label_BoundsSizeSeparator.Name = "Label_BoundsSizeSeparator";
            this.Label_BoundsSizeSeparator.Size = new System.Drawing.Size(14, 17);
            this.Label_BoundsSizeSeparator.TabIndex = 0;
            this.Label_BoundsSizeSeparator.Text = "x";
            // 
            // TextBox_BoundsHeight
            // 
            this.TextBox_BoundsHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_BoundsHeight.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.TextBox_BoundsHeight.Location = new System.Drawing.Point(210, 119);
            this.TextBox_BoundsHeight.MaxLength = 5;
            this.TextBox_BoundsHeight.Name = "TextBox_BoundsHeight";
            this.TextBox_BoundsHeight.Size = new System.Drawing.Size(75, 16);
            this.TextBox_BoundsHeight.TabIndex = 0;
            this.TextBox_BoundsHeight.TabStop = false;
            this.TextBox_BoundsHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_BoundsHeight.TextChanged += new System.EventHandler(this.TextBox_BoundsHeight_TextChanged);
            // 
            // Panel_Other
            // 
            this.Panel_Other.Controls.Add(this.Label_Other);
            this.Panel_Other.Controls.Add(this.CheckBox_ImmersiveExperience);
            this.Panel_Other.Controls.Add(this.Label_ImmersiveExperience);
            this.Panel_Other.Location = new System.Drawing.Point(25, 665);
            this.Panel_Other.Name = "Panel_Other";
            this.Panel_Other.Size = new System.Drawing.Size(300, 60);
            this.Panel_Other.TabIndex = 0;
            this.Panel_Other.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Other_Paint);
            // 
            // Label_Other
            // 
            this.Label_Other.AutoSize = true;
            this.Label_Other.Font = new System.Drawing.Font("微软雅黑", 11.25F);
            this.Label_Other.ForeColor = System.Drawing.Color.White;
            this.Label_Other.Location = new System.Drawing.Point(0, 0);
            this.Label_Other.Name = "Label_Other";
            this.Label_Other.Size = new System.Drawing.Size(39, 20);
            this.Label_Other.TabIndex = 0;
            this.Label_Other.Text = "其他";
            // 
            // CheckBox_ImmersiveExperience
            // 
            this.CheckBox_ImmersiveExperience.AutoSize = true;
            this.CheckBox_ImmersiveExperience.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CheckBox_ImmersiveExperience.ForeColor = System.Drawing.Color.White;
            this.CheckBox_ImmersiveExperience.Location = new System.Drawing.Point(15, 30);
            this.CheckBox_ImmersiveExperience.Name = "CheckBox_ImmersiveExperience";
            this.CheckBox_ImmersiveExperience.Size = new System.Drawing.Size(87, 21);
            this.CheckBox_ImmersiveExperience.TabIndex = 0;
            this.CheckBox_ImmersiveExperience.TabStop = false;
            this.CheckBox_ImmersiveExperience.Text = "沉浸式体验";
            this.CheckBox_ImmersiveExperience.UseVisualStyleBackColor = true;
            this.CheckBox_ImmersiveExperience.CheckedChanged += new System.EventHandler(this.CheckBox_ImmersiveExperience_CheckedChanged);
            // 
            // Label_ImmersiveExperience
            // 
            this.Label_ImmersiveExperience.AutoSize = true;
            this.Label_ImmersiveExperience.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_ImmersiveExperience.ForeColor = System.Drawing.Color.White;
            this.Label_ImmersiveExperience.Location = new System.Drawing.Point(115, 30);
            this.Label_ImmersiveExperience.Name = "Label_ImmersiveExperience";
            this.Label_ImmersiveExperience.Size = new System.Drawing.Size(80, 17);
            this.Label_ImmersiveExperience.TabIndex = 0;
            this.Label_ImmersiveExperience.Text = "更改背景图片";
            // 
            // OpenFileDialog_ImmersiveExperience
            // 
            this.OpenFileDialog_ImmersiveExperience.Filter = resources.GetString("OpenFileDialog_ImmersiveExperience.Filter");
            this.OpenFileDialog_ImmersiveExperience.Title = "选择背景图片";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(350, 750);
            this.Controls.Add(this.Panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "主窗体";
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Client.ResumeLayout(false);
            this.Panel_FormStyle.ResumeLayout(false);
            this.Panel_FormStyle.PerformLayout();
            this.Panel_FormAppearance.ResumeLayout(false);
            this.Panel_FormAppearance.PerformLayout();
            this.Panel_FormState.ResumeLayout(false);
            this.Panel_FormState.PerformLayout();
            this.Panel_Other.ResumeLayout(false);
            this.Panel_Other.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_FormStateEnum;
        private System.Windows.Forms.ComboBox ComboBox_FormActionEnum;
        private System.Windows.Forms.ComboBox ComboBox_FormStyleEnum;
        private System.Windows.Forms.CheckBox CheckBox_EnableFullScreen;
        private System.Windows.Forms.CheckBox CheckBox_ShowCaptionBarColor;
        private System.Windows.Forms.CheckBox CheckBox_EnableCaptionBarTransparent;
        private System.Windows.Forms.ColorDialog ColorDialog_ThemeColor;
        private System.Windows.Forms.ComboBox ComboBox_ThemeEnum;
        private System.Windows.Forms.CheckBox CheckBox_TopMost;
        private System.Windows.Forms.CheckBox CheckBox_ShowInTaskbar;
        private System.Windows.Forms.FontDialog FontDialog_CaptionFont;
        private System.Windows.Forms.ComboBox ComboBox_CaptionAlignEnum;
        private System.Windows.Forms.CheckBox CheckBox_ShowIconOnCaptionBar;
        private System.Windows.Forms.CheckBox CheckBox_ShowShadowColor;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Panel Panel_FormStyle;
        private System.Windows.Forms.Label Label_FormStyle;
        private System.Windows.Forms.Panel Panel_FormState;
        private System.Windows.Forms.Label Label_FormState;
        private System.Windows.Forms.Panel Panel_FormAppearance;
        private System.Windows.Forms.Label Label_FormAppearance;
        private System.Windows.Forms.Panel Panel_Client;
        private System.Windows.Forms.Label Label_FormStyleEnum;
        private System.Windows.Forms.Label Label_ThemeEnum;
        private System.Windows.Forms.Label Label_CaptionAlignEnum;
        private System.Windows.Forms.Label Label_FormActionEnum;
        private System.Windows.Forms.Label Label_FormStateEnum;
        private System.Windows.Forms.Label Label_ThemeColor_Value;
        private System.Windows.Forms.Label Label_ThemeColor;
        private System.Windows.Forms.Label Label_CaptionFont;
        private System.Windows.Forms.Label Label_CaptionFont_Value;
        private System.Windows.Forms.TextBox TextBox_BoundsX;
        private System.Windows.Forms.Label Label_BoundsLocation;
        private System.Windows.Forms.TextBox TextBox_BoundsHeight;
        private System.Windows.Forms.Label Label_BoundsSizeSeparator;
        private System.Windows.Forms.TextBox TextBox_BoundsWidth;
        private System.Windows.Forms.Label Label_BoundsLocationSeparator;
        private System.Windows.Forms.TextBox TextBox_BoundsY;
        private System.Windows.Forms.Label Label_BoundsSize;
        private System.Windows.Forms.CheckBox CheckBox_ShowCaption;
        private System.Windows.Forms.Label Label_Caption;
        private System.Windows.Forms.TextBox TextBox_Caption;
        private System.Windows.Forms.Panel Panel_Other;
        private System.Windows.Forms.Label Label_Other;
        private System.Windows.Forms.CheckBox CheckBox_ImmersiveExperience;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_ImmersiveExperience;
        private System.Windows.Forms.Label Label_ImmersiveExperience;
        private System.Windows.Forms.CheckBox CheckBox_EnableMaximize;
        private System.Windows.Forms.CheckBox CheckBox_EnableMinimize;
    }
}