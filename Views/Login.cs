using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor.Views
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, EventArgs e)
        {
            var response = MetroFramework.MetroMessageBox.Show(
                this,"Yes/No", "Seguro de elimunar", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (DialogResult.Yes == response)
                MessageBox.Show("Hola");
        }
    }
}
