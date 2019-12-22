using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.CustomControlsLib
{
    public enum CalismaModu
    {
        Normal,
        Harf,
        Rakam
       
    }
    public class MyTextBox : TextBox
    {
        public CalismaModu Mod { get; set; }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (Mod)
            {
                case CalismaModu.Harf:
                    e.Handled = char.IsDigit(e.KeyChar);
                    break;
                case CalismaModu.Rakam:
                    e.Handled = char.IsLetter(e.KeyChar);
                    break;
                case CalismaModu.Normal:
                    base.OnKeyPress(e);
                    break;
                default:
                    break;
            }

        }
    }
}
