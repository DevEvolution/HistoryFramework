using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject.Helpers
{
    /// <summary>
    /// Model of timer entity
    /// </summary>
    public class TimerModel
    {
        /// <summary>
        /// Id of timer
        /// </summary>
        public int id;

        /// <summary>
        /// <see cref="Timer"/>
        /// of unit
        /// </summary>
        public Timer timer;

        /// <summary>
        /// Description of timer
        /// </summary>
        public string description;

        /// <summary>
        /// State of timer entity
        /// </summary>
        public TimerState state;

        /// <summary>
        ///  State of timer entity
        /// </summary>
        public enum TimerState
        {
            Working,
            Paused
        }
    }
}
