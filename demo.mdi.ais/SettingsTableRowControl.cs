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
using System.Text.RegularExpressions;
using demo.mdi.ais.Helpers;

namespace demo.mdi.ais
{
    //[Serializable]
    public partial class SettingsTableRowControl : UserControl
    {
        public SettingsTableRowControl()
        {
            InitializeComponent(); CreateInnerControl();
            ValueChanged += OnValueChanged;
        }

        private SettingsTableDataType _controlType = SettingsTableDataType.TextBox;
        public SettingsTableDataType ControlType
        {
            get => _controlType;
            set
            {
                RemoveInnerControl();
                _controlType = value;
                CreateInnerControl();
            }
        }
        public Control InnerControl { get; set; }

        public Action<string> ValueChanged;

        private SettingsTableRowFilter _filter = new SettingsTableRowFilter();
        public string Filter
        {
            get => $"<{_filter.Range.less},>{_filter.Range.more}" + (_filter.NotNull ? ",NN" : "");
            set
            {
                var filters = value.Split(',');
                foreach (var filter in filters)
                {
                    {
                        Regex regex = new Regex(@"^<\d+");
                        Match match = regex.Match(filter);
                        if (match.Success) _filter.Range.less = int.Parse(match.Value.Substring(1));
                    }
                    {
                        Regex regex = new Regex(@"^>\d+");
                        Match match = regex.Match(filter);
                        if (match.Success) _filter.Range.more = int.Parse(match.Value.Substring(1));
                    }
                    {
                        Regex regex = new Regex(@"nn", RegexOptions.IgnoreCase);
                        Match match = regex.Match(filter);
                        if (match.Success) _filter.NotNull = true;
                    }
                }

            }
        }
        public string Question { get => lblText.Text; set => lblText.Text = value; }
        private string _value;
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                //if (InnerControl == null) return;
                ValueChanged(value);
            }
        }

        private void OnValueChanged(string value)
        {
            if (AcceptFilter(value))
            {
                _value = value;
                switch (ControlType)
                {
                    case SettingsTableDataType.TextBox:
                        ((TextBox)InnerControl).Text = value;
                        break;
                    case SettingsTableDataType.NumericUpDown:
                        ((NumericUpDown)InnerControl).Value = Decimal.Parse(value);
                        break;
                    case SettingsTableDataType.Button:
                        ((Button)InnerControl).Text = value;
                        break;
                }
            }
            else
            {
                switch (ControlType)
                {
                    case SettingsTableDataType.TextBox:
                        ((TextBox)InnerControl).Text = _value;
                        break;
                    case SettingsTableDataType.NumericUpDown:
                        ((NumericUpDown)InnerControl).Value = Decimal.Parse(_value);
                        break;
                    case SettingsTableDataType.Button:
                        ((Button)InnerControl).Text = _value;
                        break;
                }
            }
        }

        private bool AcceptFilter(string value)
            => ControlType == SettingsTableDataType.TextBox &&
                value.Trim().Length >= _filter.Range.more &&
                value.Trim().Length <= _filter.Range.less ||
                ControlType == SettingsTableDataType.NumericUpDown && 
                int.Parse(value) >= _filter.Range.more &&
                int.Parse(value) <= _filter.Range.less;

        //private void SetValue(string text)
        //{
        //    switch (ControlType)
        //    {
        //        case SettingsTableRowControlType.TextBox:
        //            ((TextBox)InnerControl).Text = value;
        //            break;
        //        case SettingsTableRowControlType.NumericUpDown:
        //            ((NumericUpDown)InnerControl).Value = Decimal.Parse(value);
        //            break;
        //        case SettingsTableRowControlType.Button:
        //            ((Button)InnerControl).Text = value;
        //            break;
        //    }
        //}

        private void CreateInnerControl()
        {
            switch (ControlType)
            {
                case SettingsTableDataType.TextBox:
                    TextBox tb = new TextBox();
                    tb.Show();
                    tb.TextChanged += delegate (object sender, EventArgs e) { ValueChanged(tb.Text); };
                    InnerControl = tb;
                    tableLayout.Controls.Add(InnerControl, 1, 0);
                    break;
                case SettingsTableDataType.NumericUpDown:
                    NumericUpDown num = new NumericUpDown();
                    num.Show();
                    num.ValueChanged += delegate (object sender, EventArgs e) { ValueChanged(num.Value.ToString()); };
                    InnerControl = num;
                    tableLayout.Controls.Add(InnerControl, 1, 0);
                    break;
                case SettingsTableDataType.Button:
                    Button btn = new Button();
                    btn.Show();
                    InnerControl = btn;
                    tableLayout.Controls.Add(InnerControl, 1, 0);
                    break;
            }
        }

        private void RemoveInnerControl()
        {
            if (InnerControl != null)
            {
                tableLayout.Controls.Remove(InnerControl);
                InnerControl.Hide();
                InnerControl.Dispose();
            }
        }

        private void SettingsTableRowControl_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(300, 40);
            //CreateInnerControl();
        }
    }
}
