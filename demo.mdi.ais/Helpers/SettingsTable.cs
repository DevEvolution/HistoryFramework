using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo.mdi.ais.Helpers.Enums;

namespace demo.mdi.ais.Helpers
{
    public partial class SettingsTable : UserControl
    {
        private SettingsTableDynamicList list = new SettingsTableDynamicList();
        public SettingsTableDynamicList DynamicList { get => list; set { list = value; UpdateList(); } }

        public Dictionary<Label, Control> controls = new Dictionary<Label, Control>();

        private void UpdateList()
        {
            tableLayout.RowCount = 0;
            foreach (SettingsTableRow row in DynamicList.rows)
            {
                tableLayout.RowCount += 1;
                Label lblText = new Label();
                lblText.Text = row.name;
                int position = tableLayout.RowCount - 1;
                tableLayout.SetCellPosition(lblText, new TableLayoutPanelCellPosition(0, position));
                string[] formatList = row.format.Split(',');
                switch (row.dataType)
                {
                    case SettingsTableDataType.Button:
                        Button btn = new Button();
                        btn.Text = row.defaultValue;
                        tableLayout.SetCellPosition(btn, new TableLayoutPanelCellPosition(1, position));
                        controls.Add(lblText, btn);
                        break;
                    case SettingsTableDataType.NumericUpDown:
                        NumericUpDown num = new NumericUpDown();
                        num.Minimum = -99999;
                        num.Maximum = 99999;
                        num.Value = int.Parse(row.defaultValue);

                        foreach (string format in formatList)
                        {
                            if (format.Contains('>'))
                                num.Minimum = int.Parse(format.Substring(format.IndexOf('>') + 1));
                            else if(format.Contains('<'))
                                num.Maximum = int.Parse(format.Substring(format.IndexOf('<') + 1));
                        }

                        tableLayout.SetCellPosition(num, new TableLayoutPanelCellPosition(1, position));
                        controls.Add(lblText, num);
                        break;
                    case SettingsTableDataType.TextBox:
                        TextBox tb = new TextBox();
                        tb.Text = row.defaultValue;
                        tableLayout.SetCellPosition(tb, new TableLayoutPanelCellPosition(1, position));
                        controls.Add(lblText, tb);
                        break;
                }
            }
        }

        public SettingsTable()
        {
            InitializeComponent();
        }
    }
}
