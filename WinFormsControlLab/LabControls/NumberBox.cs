using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace LabControls
{
    public enum Notation { Decimal, Heximal }

    public partial class NumberBox : TextBox
    {
        public Notation CurrentNotation { get; set; }
        public NumberBox()
        {
            InitializeComponent();
        }

        public NumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (CurrentNotation)
            {
                case Notation.Decimal:
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                        e.Handled = true;
                    break;
                case Notation.Heximal:
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)) && !(e.KeyChar >= 'A' && e.KeyChar <= 'F' || e.KeyChar >= 'a' && e.KeyChar <= 'f'))
                        e.Handled = true;
                    break;
                default:
                    throw new NotImplementedException();
            }
            base.OnKeyPress(e);
        }
    }
}
