using DemoProject.Helpers;
using HistoryFramework;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DemoProject.ChildForms
{
    /// <summary>
    /// History controller settings form
    /// </summary>
    public partial class FormSettings : Form
    {
        /// <summary>
        /// History controller object reference
        /// </summary>
        public HistoryController HistoryController { get; set; }

        public FormSettings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens static color picker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStaticColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = btnStaticColor.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                btnStaticColor.BackColor = dialog.Color;
            }
        }

        /// <summary>
        /// Opens highlight color picker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHighlightColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = btnHighlightColor.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                btnHighlightColor.BackColor = dialog.Color;
            }
        }

        /// <summary>
        /// Opens message color picker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMessageColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = btnMessageColor.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                btnMessageColor.BackColor = dialog.Color;
            }
        }

        /// <summary>
        /// Opens error message color picker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnErrorColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = btnErrorColor.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                btnErrorColor.BackColor = dialog.Color;
            }
        }

        /// <summary>
        /// Accept changes and exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            HistoryController.HistoryButtonList.StaticColor = btnStaticColor.BackColor;
            HistoryController.HistoryButtonList.HighlightedColor = btnHighlightColor.BackColor;
            HistoryController.HistoryStatusStrip.MessageColor = btnMessageColor.BackColor;
            HistoryController.HistoryStatusStrip.ErrorColor = btnErrorColor.BackColor;
            HistoryController.Message("Settings are updated");
            HistoryController.Close();
        }

        /// <summary>
        /// Exit without saving
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDecline_Click(object sender, EventArgs e)
        {
            HistoryController.Close();
        }
    }
}
