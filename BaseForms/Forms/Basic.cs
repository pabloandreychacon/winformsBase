using BaseHelpers.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForms.Forms
{
    public partial class Basic : Form
    {
        [Category("Control Data")]
        [Description("Control: Información formulario actual")]
        [DefaultValue("Pablo Andrey Chacon Luna")]
        public string CreadoPor { get; set; }

        [Category("Control Data")]
        [Description("Control: Información formulario actual")]
        [DefaultValue("")]
        public DateTime CreadoEn { get; set; }

        [Category("Control Data")]
        [Description("Control: Mensaje a mostrar al usuario")]
        [DefaultValue("")]
        public string DisplayMessage { get; set; }

        public enum ValidationTypes
        {
            Text, Numeric, Bool, PositiveNumeric, Email
        }

        public Basic()
        {
            InitializeComponent();
            CreadoPor = "Pablo Andrey Chacon Luna";
            CreadoEn = DateTime.Now;
        }

        private void Base_Load(object sender, EventArgs e)
        {
            LogLoad();
        }

        private void LogLoad()
        {
            //if (UserCredentials.UserId != 0)
            //    GeneralDataAccess.SaveBitacora(Text.Trim(),
            //            false, UserCredentials.UserId, UserCredentials.ModuloId);
        }

        private void Base_DoubleClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CreadoPor)) 
                CreadoPor = "Sin descripción";
            var message = @"Form name: " + Name.Trim() + "\n" + @"Creado por: " +
                CreadoPor.Trim() + "\n" + @"Creado en: " + CreadoEn.ToShortDateString();
            MessageBox.Show(message, "FormInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region validation
        public bool Validator(System.Windows.Forms.Control controlToValidate, ValidationTypes controlType, string userMessage)
        {
            errorContainer1.Message = "";
            var validated = false;
            switch (controlType)
            {
                case ValidationTypes.Text:
                    if (String.IsNullOrWhiteSpace(controlToValidate.Text))
                    {
                        errorContainer1.Control = controlToValidate;
                        if (userMessage != null) errorContainer1.Message = userMessage;
                        controlToValidate.Focus();
                    }
                    else
                    {
                        validated = true;
                    }
                    break;
                case ValidationTypes.Numeric:
                    if (String.IsNullOrEmpty(controlToValidate.Text) || (!Tools.NumericValidators.IsNumeric(controlToValidate.Text)))
                    {
                        //if (Convert.ToInt32(controlToValidate.Text) <= 0)
                        errorContainer1.Control = controlToValidate;
                        if (userMessage != null) errorContainer1.Message = userMessage;
                        controlToValidate.Focus();
                    }
                    else
                    {
                        validated = true;
                    }
                    break;
                case ValidationTypes.PositiveNumeric:
                    if (String.IsNullOrEmpty(controlToValidate.Text) || (!Tools.NumericValidators.IsPositiveNumeric((controlToValidate.Text))))
                    {
                        //if (Convert.ToInt32(controlToValidate.Text) <= 0)
                        errorContainer1.Control = controlToValidate;
                        if (userMessage != null) errorContainer1.Message = userMessage;
                        controlToValidate.Focus();
                    }
                    else
                    {
                        validated = true;
                    }
                    break;
                case ValidationTypes.Bool:
                    if (controlToValidate is CheckBox)
                    {
                        var currentCheck = (CheckBox)controlToValidate;
                        if (!currentCheck.Checked)
                        {
                            errorContainer1.Control = controlToValidate;
                            if (userMessage != null) errorContainer1.Message = userMessage;
                            controlToValidate.Focus();
                        }
                        else
                        {
                            validated = true;
                        }
                    }
                    break;
				case ValidationTypes.Email:
                    if (String.IsNullOrWhiteSpace(controlToValidate.Text))
                    {
                        errorContainer1.Control = controlToValidate;
                        if (userMessage != null) errorContainer1.Message = userMessage;
                        controlToValidate.Focus();
                    }
                    else
                    {
						validated = Regex.IsMatch(controlToValidate.Text, @"^([\w-\.+]+)@(([[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(]?)$");
						if (!validated) { 
							errorContainer1.Control = controlToValidate;
							if (userMessage != null) errorContainer1.Message = userMessage;
							controlToValidate.Focus();
						}
                    }
                    break;
                default:
                    if (String.IsNullOrWhiteSpace(controlToValidate.Text))
                    {
                        errorContainer1.Control = controlToValidate;
                        if (userMessage != null) errorContainer1.Message = userMessage;
                        controlToValidate.Focus();
                    }
                    else
                    {
                        validated = true;
                    }
                    break;
            }
            return validated;
        }
        #endregion
    }
}
