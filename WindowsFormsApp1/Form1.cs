using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UWPInterop;
using Windows.Security.Credentials.UI;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {

            await UserConsentVerifierInterop.RequestVerificationForWindowAsync(this.Handle, "Enter PIN for me:");

        }
    }
}
