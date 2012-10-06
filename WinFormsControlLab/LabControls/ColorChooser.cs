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
        private bool converting;

        public ColorChooser()
        {
            InitializeComponent();

            nmBoxRed.CurrentNotation = nmBoxGreen.CurrentNotation = nmBoxBlue.CurrentNotation = Notation.Decimal;
            nmBoxRed.TextChanged += new EventHandler(nmBox_TextChanged);
            nmBoxGreen.TextChanged += new EventHandler(nmBox_TextChanged);
            nmBoxBlue.TextChanged += new EventHandler(nmBox_TextChanged);
            converting = false;
        }

        void nmBox_TextChanged(object sender, EventArgs e)
        {
            if (converting) return;

            Int32 red, green, blue;

            if (nmBoxRed.Text.Length == 0)
                nmBoxRed.Text = "0";
            if (nmBoxGreen.Text.Length == 0)
                nmBoxGreen.Text = "0";
            if (nmBoxBlue.Text.Length == 0)
                nmBoxBlue.Text = "0";

            switch (nmBoxRed.CurrentNotation)
            {
                case Notation.Decimal:
                    red = Convert.ToInt32(nmBoxRed.Text);
                    green = Convert.ToInt32(nmBoxGreen.Text);
                    blue = Convert.ToInt32(nmBoxBlue.Text);
                    break;
                case Notation.Heximal:
                    red = Convert.ToInt32(nmBoxRed.Text, 16);
                    green = Convert.ToInt32(nmBoxGreen.Text, 16);
                    blue = Convert.ToInt32(nmBoxBlue.Text, 16);
                    break;
                default:
                    throw new NotImplementedException();
            }

            red = Math.Min(255, Math.Max(0, red));
            green = Math.Min(255, Math.Max(0, green));
            blue = Math.Min(255, Math.Max(0, blue));

            switch (nmBoxRed.CurrentNotation)
            {
                case Notation.Decimal:
                    nmBoxRed.Text = String.Format("{0}", red);
                    nmBoxGreen.Text = String.Format("{0}", green);
                    nmBoxBlue.Text = String.Format("{0}", blue);
                    break;
                case Notation.Heximal:
                    nmBoxRed.Text = String.Format("{0:X}", red);
                    nmBoxGreen.Text = String.Format("{0:X}", green);
                    nmBoxBlue.Text = String.Format("{0:X}", blue);
                    break;
                default:
                    throw new NotImplementedException();
            }

            CurrentColor = Color.FromArgb(red, green, blue);
            lbOutputColor.BackColor = CurrentColor;
        }

        private void rBtnDec_CheckedChanged(object sender, EventArgs e)
        {
            converting = true;
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
            converting = false;
        }
    }
}
