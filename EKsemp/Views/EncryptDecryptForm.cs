

namespace EKsemp.Views
{
   
    #region Libraries (Librerias)
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Windows.Forms;
    using EDsemp.Classes;
    using EKsemp.Resources;
    #endregion



    public partial class EncryptDecryptForm : Form
    {
      

        #region Methods (metodos)
        public EncryptDecryptForm()
        {
            InitializeComponent();
        }


        public void LoadF()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");

            cmbSelect.Items.Add("MD5");
            cmbSelect.Items.Add("StringSapher");
            cmbSelect.Items.Add("RSA Encrytpion");
            cmbSelect.Items.Add("Tripple");

        }

        private void AplicarIdioma()
        {
          BtnClose.Text =  Resource.BtnClose;
          lblcombo.Text = Resource.lblcombo;
          lblencrypt.Text=  Resource.leyendToEncrypt;
          lbldecrypt.Text = Resource.leyendToDecrypt;
          Text = Resource.WindowTitle;
          swtSelect.OnText = Resource.swtConvertON;
          swtSelect.OffText = Resource.swtConvertOFF;
          lblselect.Text = Resource.lblselect;
          btnDo.Text = Resource.convert;
        }

        #endregion

        #region Events (eventos)
        //Load Enviroment
        private void EncryptDecryptForm_Load(object sender, EventArgs e)
        {
            LoadF();
            AplicarIdioma();

            this.Text = "Encryptador y Desencrytador";
        }

        //Close Appplication
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region MethodsEncryptdecrypt

        public string Result(string type, string leyend)
        {
            string result="";

            switch (type)
                {
                    case "MD5":
                        if (swtSelect.Value== true)//encryp
                        {



                          result= Encriptar_Desencriptar.EncryptKeyMD5(leyend);

                            return result;
                        }

                          result = Encriptar_Desencriptar.DecryptKeyMD5(leyend);

                          return result;
                        
                case "StringSapher":

                    if (swtSelect.Value == true)//encryp
                    {



                        result = Encriptar_Desencriptar.EncryptStringSapher(leyend);

                        return result;
                    }

                    result = Encriptar_Desencriptar.DecryptSapher(leyend);

                    return result;


                case "RSA Encrytpion":
                    if (swtSelect.Value == true)//encryp
                    {



                        result = Encriptar_Desencriptar.EncryptStringRSA(leyend);

                        return result;
                    }

                    result = Encriptar_Desencriptar.DecryptStringRSA(leyend);

                    return result;
                   
                case "Tripple":

                    if (swtSelect.Value == true)//encryp
                    {



                        result = Encriptar_Desencriptar.EncryptTripple(leyend,true);

                        return result;
                    }

                    result = Encriptar_Desencriptar.DecryptTripple(leyend,true);

                    return result;


                default:
                        return result;
                       

                }

         
        }



        #endregion

        #region MyRegion

        #endregion

        #region MyRegion

        #endregion

        private void btnDo_Click(object sender, EventArgs e)
        {
            try
            {
                string text="";
                if (swtSelect.Value == true)
                {
                    text = txtEncrypt.Text;
                }
                else
                {
                    text = txtDecrypt.Text;
                }
               txtResponse.Text= Result(cmbSelect.Text, text);

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
