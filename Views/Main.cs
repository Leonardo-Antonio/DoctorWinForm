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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private Contrareferencia _contrareferencia = new Contrareferencia();
        private Diagnosis _diagnosis = new Diagnosis();
        private Login _login = new Login();
        public Main()
        {
            InitializeComponent();
        }

        private void _btn_diagnosis_Click(object sender, EventArgs e)
        {
            if (_pnl_main.Contains(_diagnosis) == false )
            {
                _pnl_main.Controls.Add(_diagnosis);
                _pnl_main.Controls.Remove(_contrareferencia);
                _pnl_main.Controls.Remove(_login);
                _diagnosis.Dock = DockStyle.Fill;
                _diagnosis.BringToFront();
            } else
                _diagnosis.BringToFront();
        }

        private void _btn_contrarefencia_Click(object sender, EventArgs e)
        {
            if (_pnl_main.Contains(_contrareferencia) == false)
            {
                _pnl_main.Controls.Add(_contrareferencia);
                _pnl_main.Controls.Remove(_diagnosis);
                _pnl_main.Controls.Remove(_login);
                _contrareferencia.Dock = DockStyle.Fill;
                _contrareferencia.BringToFront();
            }
            else
                _contrareferencia.BringToFront();
        }

        private void _btn_login_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (_pnl_main.Contains(_login) == false)
            {
                _pnl_main.Controls.Add(_login);
                _pnl_main.Controls.Remove(_diagnosis);
                _pnl_main.Controls.Remove(_contrareferencia);
                _login.Dock = DockStyle.Fill;
                _login.BringToFront();
            }
            else
                _login.BringToFront();
            _btn_contrarefencia.Enabled = false;
            _btn_diagnosis.Enabled = false;
        }
    }
}
