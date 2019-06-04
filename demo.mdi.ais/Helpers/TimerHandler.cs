using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject.Helpers
{
    /// <summary>
    /// Class containing all timer data
    /// </summary>
    public static class TimerHandler
    {
        /// <summary>
        /// List of all timers
        /// </summary>
        public static List<TimerModel> Timers { get; private set; } = new List<TimerModel>();

        /// <summary>
        /// Add new timer
        /// </summary>
        /// <param name="time">Expiration time</param>
        /// <param name="description">Timer description</param>
        /// <returns>Id of created timer</returns>
        public static int AddTimer(DateTime time, string description)
        {
            TimeSpan diff = time.Subtract(DateTime.Now);
            Timer timer = new Timer() { Enabled = true, Interval = Convert.ToInt32(Math.Floor(diff.TotalMilliseconds)) };
            timer.Tick += Timer_Tick;
            timer.Start();

            int id = GetFreeId();
            Timers.Add(new TimerModel() { id = id, state = TimerModel.TimerState.Working, timer = timer, description = description });
            return id;

            int GetFreeId()
            {
                int freeid = 0;
                foreach (TimerModel unit in Timers)
                {
                    if (unit.id != freeid)
                        return freeid;
                    freeid++;
                }
                return -1;
            }
        }

        /// <summary>
        /// Starts timer with specified
        /// <paramref name="id"/>
        /// </summary>
        /// <param name="id">Timer id</param>
        public static void StartTimer(int id)
        {
            TimerModel timer = Timers.First(x => x.id == id);
            timer.timer.Start();
            timer.state = TimerModel.TimerState.Working;
        }

        /// <summary>
        /// Stops timer with specified
        /// <paramref name="id"/>
        /// </summary>
        /// <param name="id">Timer id</param>
        public static void StopTimer(int id)
        {
            TimerModel timer = Timers.First(x => x.id == id);
            timer.timer.Stop();
            timer.state = TimerModel.TimerState.Paused;
        }

        /// <summary>
        /// Removes timer with specified
        /// <paramref name="id"/>
        /// </summary>
        /// <param name="id">Timer id</param>
        public static void RemoveTimer(int id)
        {
            TimerModel timer = Timers.First(x => x.id == id);
            timer.timer.Stop();
            timer.timer.Dispose();
            Timers.Remove(timer);
        }

        /// <summary>
        /// Execution method on timer expiration 
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private static void Timer_Tick(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stream = Properties.Resources.alarm_short;

            player.Play();
            ((Timer)sender).Stop();
            ((Timer)sender).Dispose();
        }
    }
}
