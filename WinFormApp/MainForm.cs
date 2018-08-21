/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
Copyright © 2018 chibayuki@foxmail.com

FormManager测试 (FormManagerTest)
Version 18.8.21.0000

This file is part of "FormManager测试" (FormManagerTest)

"FormManager测试" (FormManagerTest) is released under the GPLv3 license
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class MainForm : Form
    {
        #region 窗体构造

        private Com.WinForm.FormManager Me;

        public Com.WinForm.FormManager FormManager
        {
            get
            {
                return Me;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;

                CreateParams CP = base.CreateParams;

                if (Me != null && Me.FormStyle != Com.WinForm.FormStyle.Dialog)
                {
                    CP.Style = CP.Style | WS_MINIMIZEBOX;
                }

                return CP;
            }
        }

        private void _Ctor(Com.WinForm.FormManager owner)
        {
            InitializeComponent();

            //

            if (owner != null)
            {
                Me = new Com.WinForm.FormManager(this, owner);
            }
            else
            {
                Me = new Com.WinForm.FormManager(this);
            }

            //

            FormDefine();
        }

        public MainForm()
        {
            _Ctor(null);
        }

        public MainForm(Com.WinForm.FormManager owner)
        {
            _Ctor(owner);
        }

        private void FormDefine()
        {
            Me.ThemeColor = Com.ColorManipulation.GetRandomColorX();

            Me.Loaded += LoadedEvents;
            Me.FormStateChanged += FormStateChangedEvents;
            Me.ThemeChanged += ThemeChangedEvents;
            Me.ThemeColorChanged += ThemeChangedEvents;
        }

        #endregion

        #region 窗体事件

        private void LoadedEvents(object sender, EventArgs e)
        {
            Me.OnThemeChanged();

            //

            ComboBox_FormStyle.SelectedIndexChanged -= ComboBox_FormStyle_SelectedIndexChanged;
            ComboBox_FormStyle.SelectedIndex = (int)Me.FormStyle;
            ComboBox_FormStyle.SelectedIndexChanged += ComboBox_FormStyle_SelectedIndexChanged;

            CheckBox_EnableFullScreen.CheckedChanged -= CheckBox_EnableFullScreen_CheckedChanged;
            CheckBox_ShowIconOnCaptionBar.CheckedChanged -= CheckBox_ShowIconOnCaptionBar_CheckedChanged;
            CheckBox_TopMost.CheckedChanged -= CheckBox_TopMost_CheckedChanged;
            CheckBox_ShowInTaskbar.CheckedChanged -= CheckBox_ShowInTaskbar_CheckedChanged;
            CheckBox_EnableFullScreen.Checked = Me.EnableFullScreen;
            CheckBox_ShowIconOnCaptionBar.Checked = Me.ShowIconOnCaptionBar;
            CheckBox_TopMost.Checked = Me.TopMost;
            CheckBox_ShowInTaskbar.Checked = Me.ShowInTaskbar;
            CheckBox_EnableFullScreen.CheckedChanged += CheckBox_EnableFullScreen_CheckedChanged;
            CheckBox_ShowIconOnCaptionBar.CheckedChanged += CheckBox_ShowIconOnCaptionBar_CheckedChanged;
            CheckBox_TopMost.CheckedChanged += CheckBox_TopMost_CheckedChanged;
            CheckBox_ShowInTaskbar.CheckedChanged += CheckBox_ShowInTaskbar_CheckedChanged;

            //

            ComboBox_Theme.SelectedIndexChanged -= ComboBox_Theme_SelectedIndexChanged;
            ComboBox_Theme.SelectedIndex = (int)Me.Theme;
            ComboBox_Theme.SelectedIndexChanged += ComboBox_Theme_SelectedIndexChanged;

            Button_ThemeColor.Text = "ThemeColor: " + Com.ColorManipulation.GetColorName(Me.ThemeColor);

            Button_CaptionFont.Text = string.Concat("CaptionFont: ", Me.CaptionFont.Name, ", ", Me.CaptionFont.Size, "pt", (Me.CaptionFont.Bold ? ", Bold" : string.Empty), (Me.CaptionFont.Italic ? ", Italic" : string.Empty), (Me.CaptionFont.Strikeout ? ", Strikeout" : string.Empty), (Me.CaptionFont.Underline ? ", Underline" : string.Empty));

            ComboBox_CaptionAlign.SelectedIndexChanged -= ComboBox_CaptionAlign_SelectedIndexChanged;
            switch (Me.CaptionAlign)
            {
                case ContentAlignment.TopLeft: ComboBox_CaptionAlign.SelectedIndex = 0; break;
                case ContentAlignment.TopCenter: ComboBox_CaptionAlign.SelectedIndex = 1; break;
                case ContentAlignment.TopRight: ComboBox_CaptionAlign.SelectedIndex = 2; break;
                case ContentAlignment.MiddleLeft: ComboBox_CaptionAlign.SelectedIndex = 3; break;
                case ContentAlignment.MiddleCenter: ComboBox_CaptionAlign.SelectedIndex = 4; break;
                case ContentAlignment.MiddleRight: ComboBox_CaptionAlign.SelectedIndex = 5; break;
                case ContentAlignment.BottomLeft: ComboBox_CaptionAlign.SelectedIndex = 6; break;
                case ContentAlignment.BottomCenter: ComboBox_CaptionAlign.SelectedIndex = 7; break;
                case ContentAlignment.BottomRight: ComboBox_CaptionAlign.SelectedIndex = 8; break;
            }
            ComboBox_CaptionAlign.SelectedIndexChanged += ComboBox_CaptionAlign_SelectedIndexChanged;

            CheckBox_ShowCaptionBarColor.CheckedChanged -= CheckBox_ShowCaptionBarColor_CheckedChanged;
            CheckBox_EnableCaptionBarTransparent.CheckedChanged -= CheckBox_EnableCaptionBarTransparent_CheckedChanged;
            CheckBox_ShowCaptionBarColor.Checked = Me.ShowCaptionBarColor;
            CheckBox_EnableCaptionBarTransparent.Checked = Me.EnableCaptionBarTransparent;
            CheckBox_ShowCaptionBarColor.CheckedChanged += CheckBox_ShowCaptionBarColor_CheckedChanged;
            CheckBox_EnableCaptionBarTransparent.CheckedChanged += CheckBox_EnableCaptionBarTransparent_CheckedChanged;

            CheckBox_ShowShadowColor.CheckedChanged -= CheckBox_ShowShadowColor_CheckedChanged;
            CheckBox_ShowShadowColor.Checked = Me.ShowShadowColor;
            CheckBox_ShowShadowColor.CheckedChanged += CheckBox_ShowShadowColor_CheckedChanged;

            //

            ComboBox_FormState.SelectedIndexChanged -= ComboBox_FormState_SelectedIndexChanged;
            ComboBox_FormAction.SelectedIndexChanged -= ComboBox_FormAction_SelectedIndexChanged;
            ComboBox_FormState.SelectedIndex = (int)Me.FormState;
            ComboBox_FormAction.SelectedIndex = 0;
            ComboBox_FormState.SelectedIndexChanged += ComboBox_FormState_SelectedIndexChanged;
            ComboBox_FormAction.SelectedIndexChanged += ComboBox_FormAction_SelectedIndexChanged;
        }

        private void FormStateChangedEvents(object sender, EventArgs e)
        {
            ComboBox_FormState.SelectedIndexChanged -= ComboBox_FormState_SelectedIndexChanged;
            ComboBox_FormState.SelectedIndex = (int)Me.FormState;
            ComboBox_FormState.SelectedIndexChanged += ComboBox_FormState_SelectedIndexChanged;
        }

        private void ThemeChangedEvents(object sender, EventArgs e)
        {
            Label_FormStyle.ForeColor = Me.RecommendColors.Text_INC.ToColor();

            ComboBox_FormStyle.ForeColor = Me.RecommendColors.MenuItemText.ToColor();
            ComboBox_FormStyle.BackColor = Me.RecommendColors.MenuItemBackground.ToColor();

            CheckBox_EnableFullScreen.ForeColor = Me.RecommendColors.Text.ToColor();
            CheckBox_ShowIconOnCaptionBar.ForeColor = Me.RecommendColors.Text.ToColor();
            CheckBox_TopMost.ForeColor = Me.RecommendColors.Text.ToColor();
            CheckBox_ShowInTaskbar.ForeColor = Me.RecommendColors.Text.ToColor();

            //

            Label_FormAppearance.ForeColor = Me.RecommendColors.Text_INC.ToColor();

            ComboBox_Theme.ForeColor = Me.RecommendColors.MenuItemText.ToColor();
            ComboBox_Theme.BackColor = Me.RecommendColors.MenuItemBackground.ToColor();

            Button_ThemeColor.ForeColor = Me.RecommendColors.Text.ToColor();
            Button_ThemeColor.BackColor = Me.RecommendColors.Button.ToColor();
            Button_ThemeColor.FlatAppearance.BorderColor = Me.RecommendColors.Button.ToColor();
            Button_ThemeColor.FlatAppearance.MouseOverBackColor = Me.RecommendColors.Button_DEC.ToColor();
            Button_ThemeColor.FlatAppearance.MouseDownBackColor = Me.RecommendColors.Button_INC.ToColor();

            Button_CaptionFont.ForeColor = Me.RecommendColors.Text.ToColor();
            Button_CaptionFont.BackColor = Me.RecommendColors.Button.ToColor();
            Button_CaptionFont.FlatAppearance.BorderColor = Me.RecommendColors.Button.ToColor();
            Button_CaptionFont.FlatAppearance.MouseOverBackColor = Me.RecommendColors.Button_DEC.ToColor();
            Button_CaptionFont.FlatAppearance.MouseDownBackColor = Me.RecommendColors.Button_INC.ToColor();

            ComboBox_CaptionAlign.ForeColor = Me.RecommendColors.MenuItemText.ToColor();
            ComboBox_CaptionAlign.BackColor = Me.RecommendColors.MenuItemBackground.ToColor();

            CheckBox_ShowCaptionBarColor.ForeColor = Me.RecommendColors.Text.ToColor();
            CheckBox_EnableCaptionBarTransparent.ForeColor = Me.RecommendColors.Text.ToColor();

            CheckBox_ShowShadowColor.ForeColor = Me.RecommendColors.Text.ToColor();

            //

            Label_FormState.ForeColor = Me.RecommendColors.Text_INC.ToColor();

            ComboBox_FormState.ForeColor = Me.RecommendColors.MenuItemText.ToColor();
            ComboBox_FormState.BackColor = Me.RecommendColors.MenuItemBackground.ToColor();

            ComboBox_FormAction.ForeColor = Me.RecommendColors.MenuItemText.ToColor();
            ComboBox_FormAction.BackColor = Me.RecommendColors.MenuItemBackground.ToColor();
        }

        #endregion

        #region 回调函数

        private void ComboBox_FormStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Me.FormStyle = (Com.WinForm.FormStyle)((ComboBox)sender).SelectedIndex;
        }

        private void CheckBox_EnableFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            Me.EnableFullScreen = ((CheckBox)sender).Checked;
        }

        private void CheckBox_ShowIconOnCaptionBar_CheckedChanged(object sender, EventArgs e)
        {
            Me.ShowIconOnCaptionBar = ((CheckBox)sender).Checked;
        }

        private void CheckBox_TopMost_CheckedChanged(object sender, EventArgs e)
        {
            Me.TopMost = ((CheckBox)sender).Checked;
        }

        private void CheckBox_ShowInTaskbar_CheckedChanged(object sender, EventArgs e)
        {
            Me.ShowInTaskbar = ((CheckBox)sender).Checked;
        }

        private void ComboBox_Theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Me.Theme = (Com.WinForm.Theme)((ComboBox)sender).SelectedIndex;
        }

        private void Button_ThemeColor_Click(object sender, EventArgs e)
        {
            ColorDialog_ThemeColor.Color = Me.ThemeColor.ToColor();

            if (ColorDialog_ThemeColor.ShowDialog() == DialogResult.OK)
            {
                Me.ThemeColor = new Com.ColorX(ColorDialog_ThemeColor.Color);
                Button_ThemeColor.Text = "ThemeColor: " + Com.ColorManipulation.GetColorName(Me.ThemeColor);
            }
        }

        private void Button_CaptionFont_Click(object sender, EventArgs e)
        {
            FontDialog_CaptionFont.Font = Me.CaptionFont;

            if (FontDialog_CaptionFont.ShowDialog() == DialogResult.OK)
            {
                Me.CaptionFont = FontDialog_CaptionFont.Font;
                Button_CaptionFont.Text = string.Concat("CaptionFont: ", Me.CaptionFont.Name, ", ", Me.CaptionFont.Size, "pt", (Me.CaptionFont.Bold ? ", Bold" : string.Empty), (Me.CaptionFont.Italic ? ", Italic" : string.Empty), (Me.CaptionFont.Strikeout ? ", Strikeout" : string.Empty), (Me.CaptionFont.Underline ? ", Underline" : string.Empty));
            }
        }

        private void ComboBox_CaptionAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0: Me.CaptionAlign = ContentAlignment.TopLeft; break;
                case 1: Me.CaptionAlign = ContentAlignment.TopCenter; break;
                case 2: Me.CaptionAlign = ContentAlignment.TopRight; break;
                case 3: Me.CaptionAlign = ContentAlignment.MiddleLeft; break;
                case 4: Me.CaptionAlign = ContentAlignment.MiddleCenter; break;
                case 5: Me.CaptionAlign = ContentAlignment.MiddleRight; break;
                case 6: Me.CaptionAlign = ContentAlignment.BottomLeft; break;
                case 7: Me.CaptionAlign = ContentAlignment.BottomCenter; break;
                case 8: Me.CaptionAlign = ContentAlignment.BottomRight; break;
            }
        }

        private void CheckBox_ShowCaptionBarColor_CheckedChanged(object sender, EventArgs e)
        {
            Me.ShowCaptionBarColor = ((CheckBox)sender).Checked;
        }

        private void CheckBox_EnableCaptionBarTransparent_CheckedChanged(object sender, EventArgs e)
        {
            Me.EnableCaptionBarTransparent = ((CheckBox)sender).Checked;
        }

        private void CheckBox_ShowShadowColor_CheckedChanged(object sender, EventArgs e)
        {
            Me.ShowShadowColor = ((CheckBox)sender).Checked;
        }

        private void ComboBox_FormState_SelectedIndexChanged(object sender, EventArgs e)
        {
            Me.FormState = (Com.WinForm.FormState)((ComboBox)sender).SelectedIndex;
            ComboBox_FormState.SelectedIndex = (int)Me.FormState;
        }

        private void ComboBox_FormAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 1: Me.Return(); break;
                case 2: Me.Minimize(); break;
                case 3: Me.Maximize(); break;
                case 4: Me.EnterFullScreen(); break;
                case 5: Me.ExitFullScreen(); break;
                case 6: Me.LeftHalfScreen(); break;
                case 7: Me.RightHalfScreen(); break;
                case 8: Me.HighAsScreen(); break;
                case 9: Me.TopLeftQuarterScreen(); break;
                case 10: Me.TopRightQuarterScreen(); break;
                case 11: Me.BottomLeftQuarterScreen(); break;
                case 12: Me.BottomRightQuarterScreen(); break;
                case 13: Me.Close(); break;
            }

            ((ComboBox)sender).SelectedIndex = 0;
        }

        #endregion

        #region 背景绘图

        private void Panel_FormStyle_Paint(object sender, PaintEventArgs e)
        {
            using (Pen P = new Pen(Me.RecommendColors.Border_DEC.ToColor(), 1))
            {
                Control Cntr = sender as Control;
                Control Ctrl = Label_FormStyle;
                e.Graphics.DrawLine(P, new Point(Ctrl.Right, Ctrl.Top + Ctrl.Height / 2), new Point(Cntr.Width, Ctrl.Top + Ctrl.Height / 2));
            }
        }

        private void Panel_FormAppearance_Paint(object sender, PaintEventArgs e)
        {
            using (Pen P = new Pen(Me.RecommendColors.Border_DEC.ToColor(), 1))
            {
                Control Cntr = sender as Control;
                Control Ctrl = Label_FormAppearance;
                e.Graphics.DrawLine(P, new Point(Ctrl.Right, Ctrl.Top + Ctrl.Height / 2), new Point(Cntr.Width, Ctrl.Top + Ctrl.Height / 2));
            }
        }

        private void Panel_FormState_Paint(object sender, PaintEventArgs e)
        {
            using (Pen P = new Pen(Me.RecommendColors.Border_DEC.ToColor(), 1))
            {
                Control Cntr = sender as Control;
                Control Ctrl = Label_FormState;
                e.Graphics.DrawLine(P, new Point(Ctrl.Right, Ctrl.Top + Ctrl.Height / 2), new Point(Cntr.Width, Ctrl.Top + Ctrl.Height / 2));
            }
        }

        #endregion

    }
}