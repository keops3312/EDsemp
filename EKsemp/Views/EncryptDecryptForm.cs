

namespace EKsemp.Views
{

    #region Libraries (Librerias)  
    using System;
    using System.Drawing;
    using System.Globalization;
    using System.Threading;
    using System.Windows.Forms;
    using DevComponents.DotNetBar;
    using DevComponents.DotNetBar.Controls;
    using EDsemp.Classes;
    using EKsemp.Resources;
    #endregion



    public partial class EncryptDecryptForm : Form
    {
      
        
        #region Properties (Propiedades)
        private long _RunningAlertId = 0;
        #endregion


        #region Methods (metodos)
        public EncryptDecryptForm()
        {
            InitializeComponent();
        }


        public void LoadF()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");

            cmbSelect.Items.Add("MD5");
            cmbSelect.Items.Add("StringSapher");
         
        }

        private void AplicarIdioma()
        {
          
          lblcombo.Text = Resource.lblcombo;
          lblencrypt.Text=  Resource.leyendToEncrypt;
          lbldecrypt.Text = Resource.leyendToDecrypt;
          Text = Resource.WindowTitle;
          swtSelect.OnText = Resource.swtConvertON;
          swtSelect.OffText = Resource.swtConvertOFF;
          lblselect.Text = Resource.lblselect;
          txtEncrypt.WatermarkText = Resource.txtEncrytpWaterMark;
          txtDecrypt.WatermarkText = Resource.txtEncrytpWaterMark;
          txtResponse.WatermarkText = Resource.txtResponseWaterMark;
          btnlanguaje.Text = Resource.lblLanguaje;

        }



        public void Generate()
        {
            try
            {
                string text = "";

                string texto = "";




                if (swtSelect.Value == true && !String.IsNullOrEmpty(txtEncrypt.Text))
                {
                    text = txtEncrypt.Text;
                    txtResponse.Text = Result(cmbSelect.Text, text);

                    //Alert Message
                    texto = Resource.encrypText;

                    _RunningAlertId++;
                    eDesktopAlertColor color = eDesktopAlertColor.BlueGray;
                    eAlertPosition position = eAlertPosition.BottomRight;

                    DesktopAlert.Show(texto, "\uf005", eSymbolSet.Awesome,
                                     Color.Empty, color, position, 4,
                                     _RunningAlertId, AlertClicked);


                    return;
                }

                if (swtSelect.Value == false && !String.IsNullOrEmpty(txtDecrypt.Text))
                {
                    text = txtDecrypt.Text;
                    txtResponse.Text = Result(cmbSelect.Text, text);

                    //Alert Message
                    texto = Resource.decryptText;

                    _RunningAlertId++;
                    eDesktopAlertColor color = eDesktopAlertColor.BlueGray;
                    eAlertPosition position = eAlertPosition.BottomRight;

                    DesktopAlert.Show(texto, "\uf005", eSymbolSet.Awesome,
                                     Color.Empty, color, position, 4,
                                     _RunningAlertId, AlertClicked);

                    return;
                }

                MessageBox.Show(Resource.errorMessageComplete,
                     "EncryptDecrypt SEMP",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {

                MessageBox.Show(Resource.errorMessage + ex.Message,
                    "EncryptDecrypt SEMP",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events (eventos)
        //Select type  of Convertion
        private void swtSelect_ValueChanged(object sender, EventArgs e)
        {
            if (swtSelect.Value == true)
            {
                lblencrypt.Visible = true;
                txtEncrypt.Visible = true;
                txtEncrypt.Focus();
                lbldecrypt.Visible = false;
                txtDecrypt.Visible = false;
                txtDecrypt.Clear();
            }
            else
            {
                lbldecrypt.Visible = true;
                txtDecrypt.Visible = true;
                txtDecrypt.Focus();
                lblencrypt.Visible = false;
                txtEncrypt.Visible = false;
                txtEncrypt.Clear();

            }
        }
        //Change Image
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            AplicarIdioma();
        }
        //Change Image
        private void buttonItem2_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");
            AplicarIdioma();
        }


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

        //Convert!!
        private void btnDo_Click(object sender, EventArgs e)
        {

            Generate();
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


                case "RSA Encryption":
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



                        result = Encriptar_Desencriptar.EncryptTripple(leyend,false);

                        return result;
                    }

                    result = Encriptar_Desencriptar.DecryptTripple(leyend,false);

                    return result;


                default:
                        return result;
                       

                }

         
        }




        #endregion

        #region Desktop Alert
        void BeforeAlertDisplayed(object sender, EventArgs e)
        {
            DesktopAlertWindow win = (DesktopAlertWindow)sender;
            // This is how to set custom colors when needed or do anything else
            // win.BackColor=Color.Red;
             //win.ForeColor=Color.Yellow;
        }

        private void AlertClicked(long alertId)
        {
            alertId.ToString();
        }
        #endregion


    }
}
