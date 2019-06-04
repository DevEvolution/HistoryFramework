using DemoProject.ChildForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HistoryFramework;

namespace DemoProject
{
    /// <summary>
    ///  MDI parent form
    /// </summary>
    public partial class FormMdiMain : Form
    {
        public FormMdiMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// /Form load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMdiMain_Load(object sender, EventArgs e)
        {
            historyController.Open(new FormLogIn() { HistoryController = historyController });
        }
    }
}
