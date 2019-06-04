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
    /// Third party components reference form
    /// </summary>
    public partial class FormThirdParty : Form
    {
        /// <summary>
        /// History controller object reference
        /// </summary>
        public HistoryController HistoryController { get; set; }

        public FormThirdParty()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Link button "Gregor Cresnar" was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LnkCreator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/authors/gregor-cresnar");
        }

        /// <summary>
        /// Link button "www.flaticon.com" was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LnkFlaticon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/");
        }

        /// <summary>
        /// Link button "creativecommons license" was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LnkCC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://creativecommons.org/licenses/by/3.0/");
        }

        /// <summary>
        /// Opens the license pdf file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowLicense_Click(object sender, EventArgs e)
        {
            Process.Start("license.pdf");
        }
    }
}
