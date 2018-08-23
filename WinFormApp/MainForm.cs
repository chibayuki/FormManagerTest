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

            ComboBox_FormStyleEnum.SelectedIndexChanged -= ComboBox_FormStyleEnum_SelectedIndexChanged;
            ComboBox_FormStyleEnum.SelectedIndex = (int)Me.FormStyle;
            ComboBox_FormStyleEnum.SelectedIndexChanged += ComboBox_FormStyleEnum_SelectedIndexChanged;

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

            ComboBox_ThemeEnum.SelectedIndexChanged -= ComboBox_ThemeEnum_SelectedIndexChanged;
            ComboBox_ThemeEnum.SelectedIndex = (int)Me.Theme;
            ComboBox_ThemeEnum.SelectedIndexChanged += ComboBox_ThemeEnum_SelectedIndexChanged;

            Label_ThemeColor_Value.Text = Com.ColorManipulation.GetColorName(Me.ThemeColor);

            Label_CaptionFont_Value.Text = string.Concat(Me.CaptionFont.Name, ", ", Me.CaptionFont.Size, "pt", (Me.CaptionFont.Style != FontStyle.Regular ? string.Concat(", ", (Me.CaptionFont.Bold ? "B" : string.Empty), (Me.CaptionFont.Italic ? "I" : string.Empty), (Me.CaptionFont.Strikeout ? "S" : string.Empty), (Me.CaptionFont.Underline ? "U" : string.Empty)) : string.Empty));

            ComboBox_CaptionAlignEnum.SelectedIndexChanged -= ComboBox_CaptionAlignEnum_SelectedIndexChanged;
            switch (Me.CaptionAlign)
            {
                case ContentAlignment.TopLeft: ComboBox_CaptionAlignEnum.SelectedIndex = 0; break;
                case ContentAlignment.TopCenter: ComboBox_CaptionAlignEnum.SelectedIndex = 1; break;
                case ContentAlignment.TopRight: ComboBox_CaptionAlignEnum.SelectedIndex = 2; break;
                case ContentAlignment.MiddleLeft: ComboBox_CaptionAlignEnum.SelectedIndex = 3; break;
                case ContentAlignment.MiddleCenter: ComboBox_CaptionAlignEnum.SelectedIndex = 4; break;
                case ContentAlignment.MiddleRight: ComboBox_CaptionAlignEnum.SelectedIndex = 5; break;
                case ContentAlignment.BottomLeft: ComboBox_CaptionAlignEnum.SelectedIndex = 6; break;
                case ContentAlignment.BottomCenter: ComboBox_CaptionAlignEnum.SelectedIndex = 7; break;
                case ContentAlignment.BottomRight: ComboBox_CaptionAlignEnum.SelectedIndex = 8; break;
            }
            ComboBox_CaptionAlignEnum.SelectedIndexChanged += ComboBox_CaptionAlignEnum_SelectedIndexChanged;

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

            ComboBox_FormStateEnum.SelectedIndexChanged -= ComboBox_FormStateEnum_SelectedIndexChanged;
            ComboBox_FormActionEnum.SelectedIndexChanged -= ComboBox_FormActionEnum_SelectedIndexChanged;
            ComboBox_FormStateEnum.SelectedIndex = (int)Me.FormState;
            ComboBox_FormActionEnum.SelectedIndex = 0;
            ComboBox_FormStateEnum.SelectedIndexChanged += ComboBox_FormStateEnum_SelectedIndexChanged;
            ComboBox_FormActionEnum.SelectedIndexChanged += ComboBox_FormActionEnum_SelectedIndexChanged;
        }

        private void FormStateChangedEvents(object sender, EventArgs e)
        {
            ComboBox_FormStateEnum.SelectedIndexChanged -= ComboBox_FormStateEnum_SelectedIndexChanged;
            ComboBox_FormStateEnum.SelectedIndex = (int)Me.FormState;
            ComboBox_FormStateEnum.SelectedIndexChanged += ComboBox_FormStateEnum_SelectedIndexChanged;
        }

        private void ThemeChangedEvents(object sender, EventArgs e)
        {
            Label_FormStyle.ForeColor = Me.RecommendColors.Text_INC.ToColor();

            Label_FormStyleEnum.ForeColor = Me.RecommendColors.Text.ToColor();
            ComboBox_FormStyleEnum.ForeColor = Me.RecommendColors.MenuItemText.ToColor();
            ComboBox_FormStyleEnum.BackColor = Me.RecommendColors.MenuItemBackground.ToColor();

            CheckBox_EnableFullScreen.ForeColor = Me.RecommendColors.Text.ToColor();
            CheckBox_ShowIconOnCaptionBar.ForeColor = Me.RecommendColors.Text.ToColor();
            CheckBox_TopMost.ForeColor = Me.RecommendColors.Text.ToColor();
            CheckBox_ShowInTaskbar.ForeColor = Me.RecommendColors.Text.ToColor();

            //

            Label_FormAppearance.ForeColor = Me.RecommendColors.Text_INC.ToColor();

            Label_ThemeEnum.ForeColor = Me.RecommendColors.Text.ToColor();
            ComboBox_ThemeEnum.ForeColor = Me.RecommendColors.MenuItemText.ToColor();
            ComboBox_ThemeEnum.BackColor = Me.RecommendColors.MenuItemBackground.ToColor();

            Label_ThemeColor.ForeColor = Label_ThemeColor_Value.ForeColor = Me.RecommendColors.Text.ToColor();

            Label_CaptionFont.ForeColor = Label_CaptionFont_Value.ForeColor = Me.RecommendColors.Text.ToColor();

            Label_CaptionAlignEnum.ForeColor = Me.RecommendColors.Text.ToColor();
            ComboBox_CaptionAlignEnum.ForeColor = Me.RecommendColors.MenuItemText.ToColor();
            ComboBox_CaptionAlignEnum.BackColor = Me.RecommendColors.MenuItemBackground.ToColor();

            CheckBox_ShowCaptionBarColor.ForeColor = Me.RecommendColors.Text.ToColor();
            CheckBox_EnableCaptionBarTransparent.ForeColor = Me.RecommendColors.Text.ToColor();

            CheckBox_ShowShadowColor.ForeColor = Me.RecommendColors.Text.ToColor();

            //

            Label_FormState.ForeColor = Me.RecommendColors.Text_INC.ToColor();

            Label_FormStateEnum.ForeColor = Me.RecommendColors.Text.ToColor();
            ComboBox_FormStateEnum.ForeColor = Me.RecommendColors.MenuItemText.ToColor();
            ComboBox_FormStateEnum.BackColor = Me.RecommendColors.MenuItemBackground.ToColor();

            Label_FormActionEnum.ForeColor = Me.RecommendColors.Text.ToColor();
            ComboBox_FormActionEnum.ForeColor = Me.RecommendColors.MenuItemText.ToColor();
            ComboBox_FormActionEnum.BackColor = Me.RecommendColors.MenuItemBackground.ToColor();

            //

            Com.WinForm.ControlSubstitution.LabelAsButton(Label_ThemeColor_Value, Label_ThemeColor_Value_Click, Color.Transparent, Me.RecommendColors.Button_DEC.ToColor(), Me.RecommendColors.Button_INC.ToColor(), new Font("微软雅黑", 9F, FontStyle.Underline, GraphicsUnit.Point, 134), new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134), new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134));
            Com.WinForm.ControlSubstitution.LabelAsButton(Label_CaptionFont_Value, Label_CaptionFont_Value_Click, Color.Transparent, Me.RecommendColors.Button_DEC.ToColor(), Me.RecommendColors.Button_INC.ToColor(), new Font("微软雅黑", 9F, FontStyle.Underline, GraphicsUnit.Point, 134), new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134), new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134));
        }

        #endregion

        #region 回调函数

        private void ComboBox_FormStyleEnum_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ComboBox_ThemeEnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Me.Theme = (Com.WinForm.Theme)((ComboBox)sender).SelectedIndex;
        }

        private void Label_ThemeColor_Value_Click(object sender, EventArgs e)
        {
            ColorDialog_ThemeColor.Color = Me.ThemeColor.ToColor();

            if (ColorDialog_ThemeColor.ShowDialog() == DialogResult.OK)
            {
                Me.ThemeColor = new Com.ColorX(ColorDialog_ThemeColor.Color);
                Label_ThemeColor_Value.Text = Com.ColorManipulation.GetColorName(Me.ThemeColor);
            }
        }

        private void Label_CaptionFont_Value_Click(object sender, EventArgs e)
        {
            FontDialog_CaptionFont.Font = Me.CaptionFont;

            if (FontDialog_CaptionFont.ShowDialog() == DialogResult.OK)
            {
                Me.CaptionFont = FontDialog_CaptionFont.Font;
                Label_CaptionFont_Value.Text = string.Concat(Me.CaptionFont.Name, ", ", Me.CaptionFont.Size, "pt", (Me.CaptionFont.Style != FontStyle.Regular ? string.Concat(", ", (Me.CaptionFont.Bold ? "B" : string.Empty), (Me.CaptionFont.Italic ? "I" : string.Empty), (Me.CaptionFont.Strikeout ? "S" : string.Empty), (Me.CaptionFont.Underline ? "U" : string.Empty)) : string.Empty));
            }
        }

        private void ComboBox_CaptionAlignEnum_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ComboBox_FormStateEnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Me.FormState = (Com.WinForm.FormState)((ComboBox)sender).SelectedIndex;
            ComboBox_FormStateEnum.SelectedIndex = (int)Me.FormState;
        }

        private void ComboBox_FormActionEnum_SelectedIndexChanged(object sender, EventArgs e)
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