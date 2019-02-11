using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace BaseForms.Forms
{
    public partial class Email : BaseForms.Forms.Basic
    {
        private bool isAttachment;
        private int port;
        private int timeout;
        private string host;
        private string userName;
        private string password;
        private string from;
        private string displayName;
        public Email(int pPort = 587, int pTimeOut = 60000, string pHost = "smtp.gmail.com",
            string pUserName = "pabloandreychacon@gmail.com", string pPassword = "",
            string pFrom = "pabloandreychacon@gmail.com", string pDisplayName = "Pablo Andrey")
        {
            InitializeComponent();
            port = pPort;
            timeout = pTimeOut;
            host = pHost;
            userName = pUserName;
            password = pPassword;
            from = pFrom;
            displayName = pDisplayName;
        }

        private void Email_Load(object sender, EventArgs e)
        {
            this.isAttachment = false;
            this.lblEnviando.Visible = false;
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            this.lblEnviando.Visible = true;
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    this.SendEmail(this.txtPara.Text, this.txtAsunto.Text, this.txtMensaje.Text, this.ckbIsHtml.Checked);
                }
                else
                {
                    MessageBox.Show("No hay conexión a Internet, por favor verifique", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            this.lblEnviando.Visible = false;
        }

        public void SendEmail(string sPara, string sAsunto, string sMensaje, bool isHtml = false)
        {

            try
            {
                //Se envía el mail
                BaseHelpers.Helpers.EmailTools.SendEmail(sMensaje, this.port, this.timeout, this.host,
                this.userName, this.password, sAsunto,
                this.from, this.displayName, sPara, isHtml);
                MessageBox.Show("El email fue enviado");
            }
            catch (SmtpException ex)
            {
                //throw;
                //MessageBox.Show("error:" + ex.Message);
                MessageBox.Show(ex.Message, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void adjuntarBtn_Click(object sender, EventArgs e)
        {
            AdjuntarArchivo();
        }

        private void AdjuntarArchivo()
        {
            try
            {
                OpenFileDialog _file = new OpenFileDialog();
                _file.Title = "Seleccionar archivo";
                _file.InitialDirectory = @"C:\";
                _file.Filter = "All Files (*.*)|*.*";
                _file.FilterIndex = 1;
                _file.RestoreDirectory = true;
                _file.ShowDialog();
                this.txtArchivo.Text = _file.FileName;
                this.isAttachment = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo adjuntar el archivo! " + ex.Message, "Email adjunto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
