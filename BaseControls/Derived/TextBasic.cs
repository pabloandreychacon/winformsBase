using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BaseControls.Derived
{
    public partial class TextBasic : TextBox
    {
        // la prop no aparece aquui pero si aparece en el heredado
        // lo que hace es asignar/leeer otra propiedad del control
        [Category("Control Data")]
        [Description("Tipo de valor")]
        [DefaultValue(FormatTypes.None)]
        public FormatTypes TipoTexto { get; set; }

        [Category("Control Data")]
        [Description("Formato del campo")]
        [DefaultValue("")]
        public string FormatoTexto { get; set; }

        //[Category("Control Data")]
        //[Description("Rangos para los valores de entrada")]
        //[DefaultValue("1,100000000")]
        //public string RangoValores { get; set; }

        [Category("Control Data")]
        [Description("Rangos para los valores de entrada")]
        [DefaultValue(0)]
        public decimal RangoInferior { get; set; }

        [Category("Control Data")]
        [Description("Rangos para los valores de entrada")]
        [DefaultValue(100000000)]
        public decimal RangoSuperior { get; set; }

        public enum FormatTypes
        {
            None, Texto, Numerico, Entero, Currency, Fecha
        }

        public TextBasic()
        {
            InitializeComponent();
            RangoInferior = 0;
            RangoSuperior = 100000000;
        }

        private void TextBasic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)(Keys.Enter)) return;
            e.Handled = true;
            SendKeys.Send("{TAB}");
        }

        private void TextBasic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != (Keys.Down)) return;
            e.Handled = true;
            SendKeys.Send("{TAB}");
        }

        private void TextBasic_Leave(object sender, EventArgs e)
        {
            // elimina caracteres no válidos
            if (Text == null) return;
            var FinalValue = Text.Trim();
            Text = FinalValue.Replace('\'', ' ');
        }

        private void TextBasic_Validating(object sender, CancelEventArgs e)
        {
            decimal Db;
            bool isDecimal;
            switch (TipoTexto)
            {
                case FormatTypes.None:
                    break;
                case FormatTypes.Texto:
                    if (!string.IsNullOrWhiteSpace(Text))
                    {
                        if (Text != null) Text = Text.Trim();
                    }
                    else
                    {
                        MessageBox.Show(@"Debe digitar un texto válido", @"Texto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                    }
                    break;
                case FormatTypes.Numerico:
                case FormatTypes.Entero:
                    //var StopSeparators = new[] { "," };
                    //' Verificamos si el campo moneda es correcta y cumple con el
                    //' modelo de fecha especificado.                
                    isDecimal = Decimal.TryParse(Convert.ToString(Text), NumberStyles.Any,
                        NumberFormatInfo.InvariantInfo, out Db);
                    if (isDecimal)
                    {
                        //var Rangos = RangoValores.Split(StopSeparators, StringSplitOptions.RemoveEmptyEntries);
                        //double RangoInferior, RangoSuperior;
                        //double.TryParse(Rangos[0], out RangoInferior);
                        //double.TryParse(Rangos[1], out RangoSuperior);
                        if (Db >= RangoInferior && Db <= RangoSuperior)
                        {
                            var FinalNumber = Math.Round(Db, 2, MidpointRounding.ToEven).ToString(CultureInfo.InvariantCulture.NumberFormat);// String.Format("C", Db);
                            if (TipoTexto == FormatTypes.Entero)
                            {
                                int FinalInt;
                                FinalInt = (int)Db; //int i = Convert.ToInt32(d);                   
                                Text = FinalInt.ToString();
                            }
                            else
                            {
                                Text = FinalNumber;
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"Monto no se encuentra en el rango de valores especificado ", @"Numerico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Monto incorrecto. Utilice solo números: 999 ", @"Numerico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                    }
                    break;
                case FormatTypes.Currency:
                    isDecimal = Decimal.TryParse(Convert.ToString(Text), NumberStyles.Any,
                        NumberFormatInfo.InvariantInfo, out Db);
                    if (isDecimal)
                    {
                        if (Db >= RangoInferior && Db <= RangoSuperior)
                        {
                            Text = Db.ToString("C");// String.Format("C", Db);
                            //string.Format("{0:C}", value);
                        }
                        else
                        {
                            MessageBox.Show(@"Monto no se encuentra en el rango de valores especificado", @"Moneda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Monto incorrecto. Utilice solo números: 999.99 sin signos monetarios.", @"Moneda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                    }
                    break;
                case FormatTypes.Fecha:
                    var Ci = Thread.CurrentThread.CurrentCulture;
                    DateTime Dt1, Dt2;
                    //' Verificamos si la fecha es correcta y cumple con el
                    //' modelo de fecha especificado.
                    var isDate1 = DateTime.TryParseExact(Text, "d/M/yyyy", Ci, DateTimeStyles.AllowInnerWhite, out Dt1);
                    var isDate2 = DateTime.TryParseExact(Text, "d-M-yyyy", Ci, DateTimeStyles.AllowInnerWhite, out Dt2);
                    if (isDate1 || isDate2)
                    {
                        if (isDate2) Text = String.Format("{0:dd/MM/yyyy}", Dt2); //.ToString("dd/MM/yyyy");
                        if (isDate1) Text = String.Format("{0:dd/MM/yyyy}", Dt1); //.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        MessageBox.Show(@"Fecha incorrecta. Utilice el formato dd/MM/yyyy: " +
                            FormatoTexto, @"Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
