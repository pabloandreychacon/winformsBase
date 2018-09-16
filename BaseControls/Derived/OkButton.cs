using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseControls.Derived
{
    public partial class OkButton : Button
    {
        public OkButton()
        {
            InitializeComponent();
        }

        // para quitarle el texto al buton, porq es un bton con imagen
        // en realidad funciona pero no permite ponerle texto si se quisiera quitar la imagen
        // en en boton final
        //public override string Text
        //{
        //    get
        //    {
        //        return string.Empty;
        //    }
        //    set
        //    {
        //        value = string.Empty;
        //        base.Text = value;
        //    }
        //}
    }
}
