using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EKsemp.Views
{
    public partial class EncryptDecryptForm : Form
    {
        public EncryptDecryptForm()
        {
            InitializeComponent();
        }


        public void LoadF()
        {
            cmbSelect.Items.Add("MD5");
            cmbSelect.Items.Add("StringSapher");
            cmbSelect.Items.Add("RSA Encrytpion");
            cmbSelect.Items.Add("Tripple");
            
        }


        private void EncryptDecryptForm_Load(object sender, EventArgs e)
        {
            LoadF();
        }
    }
}
