using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.CustomControlsLib
{
    public class MyTextBox:TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);            
        }
    }
}
