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

        private Models.tb_doctor doctor;
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
            try
            {
                this.doctor = (from doc in LocalStorage.DBUtil.db.tb_doctor
                               where doc.dni == LocalStorage.Doctor.DNI &&
                               doc.password == LocalStorage.Doctor.Password
                               select doc).First();

                if (this.doctor.id != 0)
                {
                    _btn_contrarefencia.Show();
                    _btn_diagnosis.Show();
                    _btn_out.Show();

                    LocalStorage.Doctor.ID = this.doctor.id;
                    lbl_doctor.Text = $"{this.doctor.name} {this.doctor.a_p} {this.doctor.a_m}";
                    _btn_login.Enabled = false;
                    _btn_diagnosis.Enabled = true;
                    _btn_contrarefencia.Enabled = true;
                    if (_pnl_main.Contains(_diagnosis) == false)
                    {
                        _pnl_main.Controls.Add(_diagnosis);
                        _pnl_main.Controls.Remove(_login);
                        _pnl_main.Controls.Remove(_contrareferencia);
                        _diagnosis.Dock = DockStyle.Fill;
                        _diagnosis.BringToFront();
                    }
                    else
                        _diagnosis.BringToFront();
                }
            } catch (InvalidOperationException)
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "El usuario no existe",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } catch (ArgumentOutOfRangeException)
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "El usuario no existe", 
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this._signIn(false);
        }

        private void _btn_out_Click(object sender, EventArgs e)
        {
            this._signIn(true);
        }

        private void _signIn(bool signin)
        {
            if (signin) _btn_login.Enabled = true;

            _login.ClearData();

            LocalStorage.Doctor.DNI = "";
            LocalStorage.Doctor.ID = 0;
            LocalStorage.Doctor.Password = "";
            lbl_doctor.Text = "";

            _btn_contrarefencia.Hide();
            _btn_diagnosis.Hide();
            _btn_out.Hide();

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
