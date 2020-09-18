using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestWebApi
{
    public partial class FrmPrincWebApi : Form
    {
        public FrmPrincWebApi()
        {
            InitializeComponent();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
