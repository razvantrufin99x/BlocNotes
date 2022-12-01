using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocNotes
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void FormSplashScreen_Shown(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 5)
            {
                Thread.Sleep(250);
                i++;
            }
            Close();
        }
    }
}
