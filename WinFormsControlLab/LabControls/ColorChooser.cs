using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabControls
{
    public partial class ColorChooser : UserControl
    {
        public Color CurrentColor { get; set; }
        private Int32 _red, _green, _blue;

        public ColorChooser()
        {
            InitializeComponent();

            nmBoxRed.CurrentNotation = nmBoxGreen.CurrentNotation = nmBoxBlue.CurrentNotation = Notation.Decimal;
            nmBoxRed.TextChanged += new EventHandler(nmBox_TextChanged);
            nmBoxGreen.TextChanged += new EventHandler(nmBox_TextChanged);
            nmBoxBlue.TextChanged += new EventHandler(nmBox_TextChanged);
            _red = _green = _blue = 0;
        }

        private Int32 GetValueFromNumberBox(NumberBox sender)
        {
            switch (sender.CurrentNotation)
            {
                case Notation.Decimal:
                    return Convert.ToInt32((sender as NumberBox).Text, 10);
                case Notation.Heximal:
                    return Convert.ToInt32((sender as NumberBox).Text, 16);
                default:
                    throw new NotImplementedException();
            }
        }

        private void SetValueToNumberBox(NumberBox sender, Int32 newValue)
        {
            switch (sender.CurrentNotation)
            {
                case Notation.Decimal:
                    sender.Text = String.Format("{0}", newValue);
                    break;
                case Notation.Heximal:
                    sender.Text = String.Format("{0:X}", newValue);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        void nmBox_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is NumberBox)) return;

            if ((sender as NumberBox).Text.Length == 0)
                (sender as NumberBox).Text = "0";

            switch ((sender as NumberBox).Name)
            {
                case "nmBoxRed":
                    _red = GetValueFromNumberBox(sender as NumberBox);
                    if (_red > 255 || _red < 0)
                    {
                        _red = Math.Min(255, Math.Max(0, _red));
                        SetValueToNumberBox(sender as NumberBox, _red);
                    }
                    break;
                case "nmBoxGreen":
                    _green = GetValueFromNumberBox(sender as NumberBox);
                    if (_green > 255 || _green < 0)
                    {
                        _green = Math.Min(255, Math.Max(0, _green));
                        SetValueToNumberBox(sender as NumberBox, _green);
                    }
                    break;
                case "nmBoxBlue":
                    _blue = GetValueFromNumberBox(sender as NumberBox);
                    if (_blue > 255 || _blue < 0)
                    {
                        _blue = Math.Min(255, Math.Max(0, _blue));
                        SetValueToNumberBox(sender as NumberBox, _blue);
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }
            CurrentColor = Color.FromArgb(_red, _green, _blue);
            lbOutputColor.BackColor = CurrentColor;
        }

        private void rBtnDec_CheckedChanged(object sender, EventArgs e)
        {
            switch (nmBoxRed.CurrentNotation)
            {
                case Notation.Decimal:
                    nmBoxRed.CurrentNotation = nmBoxGreen.CurrentNotation = nmBoxBlue.CurrentNotation = Notation.Heximal;
                    nmBoxRed.Text = String.Format("{0:X}", Convert.ToInt32(nmBoxRed.Text));
                    nmBoxGreen.Text = String.Format("{0:X}", Convert.ToInt32(nmBoxGreen.Text));
                    nmBoxBlue.Text = String.Format("{0:X}", Convert.ToInt32(nmBoxBlue.Text));
                    break;
                case Notation.Heximal:
                    nmBoxRed.CurrentNotation = nmBoxGreen.CurrentNotation = nmBoxBlue.CurrentNotation = Notation.Decimal;
                    nmBoxRed.Text = String.Format("{0}", Convert.ToInt32(nmBoxRed.Text, 16));
                    nmBoxGreen.Text = String.Format("{0}", Convert.ToInt32(nmBoxGreen.Text, 16));
                    nmBoxBlue.Text = String.Format("{0}", Convert.ToInt32(nmBoxBlue.Text, 16));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
