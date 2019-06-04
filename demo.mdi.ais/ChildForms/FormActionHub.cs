using HistoryFramework;
using System;
using System.Windows.Forms;

namespace DemoProject.ChildForms
{
    /// <summary>
    /// Action selection form
    /// </summary>
    public partial class FormActionHub : Form
    {
        /// <summary>
        /// History controller reference
        /// </summary>
        public HistoryController HistoryController { get; set; }

        public FormActionHub()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Timer management button click event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTimerManagement_Click(object sender, EventArgs e)
        {
            HistoryController.Open(new FormTimerManagement() { HistoryController = HistoryController });
        }

        /// <summary>
        /// Credits button click event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCredits_Click(object sender, EventArgs e)
        {
            HistoryController.Open(new FormThirdParty() { HistoryController = HistoryController });
        }

        /// <summary>
        /// Settings button click event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            HistoryController.Open(new FormSettings() { HistoryController = HistoryController });
        }
    }
}
