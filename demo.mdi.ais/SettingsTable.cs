using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo.mdi.ais.Helpers;

namespace demo.mdi.ais
{
    public partial class SettingsTable : UserControl
    {
        public List<SettingsTableRowControl> Rows { get; set; } = new List<SettingsTableRowControl>();

        public Action<string, int> RowValueChanged;

        public SettingsTableDynamicList DynamicList
        {
            get => new SettingsTableDynamicList();
            set
            {
                foreach (var row in value.rows)
                {
                    AddRow(new SettingsTableRowControl() { ControlType = row.dataType, Question = row.name, Value = row.defaultValue, Filter = row.format });
                }
            }
        }

        public string GetValue(string key)
        {
            return Rows.FirstOrDefault(x => x.Question == key)?.Value ?? String.Empty;
        }

        public SettingsTable()
        {
            InitializeComponent();
        }

        public void AddRow(SettingsTableRowControl row)
        {
            if (Rows == null) Rows = new List<SettingsTableRowControl>();
            //row.BorderStyle = BorderStyle.FixedSingle;
            row.Size = new Size(this.Width, 40);
            Panel panel = new Panel() { Size = new Size(this.Width, 40), MinimumSize = new Size(this.Width, 40) };
            row.MinimumSize = row.Size;
            Rows.Add(row);
            row.Dock = DockStyle.Fill;
            row.Show();
            panel.Controls.Add(row);
            flowLayout.Controls.Add(panel);
        }
    }
}
