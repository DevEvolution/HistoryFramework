using DemoProject.Helpers;
using HistoryFramework;
using System;
using System.Windows.Forms;

namespace DemoProject.ChildForms
{
    /// <summary>
    /// Timer management form
    /// </summary>
    public partial class FormTimerManagement : Form
    {
        /// <summary>
        /// History controller object reference
        /// </summary>
        public HistoryController HistoryController { get; set; }

        public FormTimerManagement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cell on DataGridView was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvTimers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (DateTime.TryParse(dgvTimers[1, e.RowIndex].Value.ToString(), out DateTime time))
                {
                    StartTimer(e, time);
                }
                else
                {
                    HistoryController.Error($"Timer \"{dgvTimers[0, e.RowIndex].Value.ToString()}\" has incorrect format.");
                }
            }
            else if(e.ColumnIndex == 3)
            {
                RemoveTimer(e);
            }
        }

        /// <summary>
        /// Remove timer on corresponding row
        /// </summary>
        /// <param name="e"></param>
        private void RemoveTimer(DataGridViewCellEventArgs e)
        {
            if (dgvTimers[e.ColumnIndex, e.RowIndex].Tag != null)
            {
                int id = (int)dgvTimers[e.ColumnIndex, e.RowIndex].Tag;
                TimerHandler.RemoveTimer(id);
            }
            string description = dgvTimers[0, e.RowIndex].Value.ToString();
            dgvTimers.Rows.RemoveAt(e.RowIndex);
            HistoryController.Message($"Timer \"{description}\" was removed");
        }

        /// <summary>
        /// Create and start timer on corresponding row
        /// </summary>
        /// <param name="e"></param>
        private void StartTimer(DataGridViewCellEventArgs e, DateTime time)
        {
            if (dgvTimers[e.ColumnIndex, e.RowIndex].Tag != null)
            {
                int id = (int)dgvTimers[e.ColumnIndex, e.RowIndex].Tag;
                TimerModel timer = TimerHandler.Timers.Find(x => x.id == id);
                if (timer.state == TimerModel.TimerState.Paused)
                {
                    TimerHandler.StartTimer(id);
                    HistoryController.Message($"Timer \"{dgvTimers[0, e.RowIndex].Value.ToString()}\" started");
                    dgvTimers[2, e.RowIndex].Value = "Stop";
                }
                else
                {
                    TimerHandler.StopTimer(id);
                    HistoryController.Message($"Timer \"{dgvTimers[0, e.RowIndex].Value.ToString()}\" stopped");
                    dgvTimers[2, e.RowIndex].Value = "Start";
                }
            }
            else
            {
                int id = TimerHandler.AddTimer(time, dgvTimers[0, e.RowIndex].Value.ToString());
                dgvTimers[2, e.RowIndex].Tag = id;
                dgvTimers[3, e.RowIndex].Tag = id;
                HistoryController.Message($"Timer \"{dgvTimers[0, e.RowIndex].Value.ToString()}\" set to {time.ToString()}");
                dgvTimers[2, e.RowIndex].Value = "Stop";
            }
        }

        /// <summary>
        /// Close timer management window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFinal_Click(object sender, EventArgs e)
        {
            HistoryController.Close();
        }

        /// <summary>
        ///  Load all working timers to DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTimerManagement_Load(object sender, EventArgs e)
        {
            foreach (TimerModel unit in TimerHandler.Timers)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = unit.description });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = (DateTime.Now).Add(TimeSpan.FromMilliseconds(unit.timer.Interval)) });
                row.Cells.Add(new DataGridViewButtonCell() { Tag = unit.id, Value="Start" });
                row.Cells.Add(new DataGridViewButtonCell() { Tag = unit.id, Value="Remove" });
                dgvTimers.Rows.Add(row);
            }
        }
    }
}
