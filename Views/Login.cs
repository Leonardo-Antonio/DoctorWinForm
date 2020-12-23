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
        List<string> password = new List<string>();
        string pass = "";
        public Login()
        {
            InitializeComponent();
        }

        private void _btn_0_Click(object sender, EventArgs e)
        {
            this._addPass("0");
        }

        private void _btn_1_Click(object sender, EventArgs e)
        {
            this._addPass("1");
        }

        private void _btn_2_Click(object sender, EventArgs e)
        {
            this._addPass("2");
        }

        private void _btn_3_Click(object sender, EventArgs e)
        {
            this._addPass("3");
        }

        private void _btn_4_Click(object sender, EventArgs e)
        {
            this._addPass("4");
        }

        private void _btn_5_Click(object sender, EventArgs e)
        {
            this._addPass("5");
        }

        private void _btn_6_Click(object sender, EventArgs e)
        {
            this._addPass("6");
        }

        private void _btn_7_Click(object sender, EventArgs e)
        {
            this._addPass("7");
        }

        private void _btn_8_Click(object sender, EventArgs e)
        {
            this._addPass("8");
        }

        private void _btn_9_Click(object sender, EventArgs e)
        {
            this._addPass("9");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                this.password.RemoveAt(this.password.Count() - 1);
                this.pass = "";
                foreach (var value in this.password)
                    pass += value;
                txt_pass.Clear();
                txt_pass.Text = this.pass;
                LocalStorage.Doctor.Password = this.pass;
            }
            catch (ArgumentOutOfRangeException)
            {
                MetroFramework.MetroMessageBox.Show(
                    this, 
                    "Ya no hay mas carateres para eliminar", 
                    "INFORMACIÓN",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information
                    );
            }
        }

        private void _addPass(string num)
        {
            if (this.pass.Length > 8)
            {
                txt_pass.Enabled = false;
                return;
            }
            txt_pass.Enabled = true;
            this.pass = "";
            this.password.Add(num);
            foreach (var value in this.password)
                pass += value;
            txt_pass.Clear();
            txt_pass.Text = pass;
            LocalStorage.Doctor.DNI = txt_dni.Text;
            LocalStorage.Doctor.Password = txt_pass.Text;
            txt_pass.Enabled = false;
        }

        private void _btn_trash_Click(object sender, EventArgs e)
        {
            this.pass = "";
            this.password.Clear();
            txt_pass.Clear();
            txt_dni.Enabled = true;
            LocalStorage.Doctor.Password = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_pass.Enabled = false;
            _btn_0.Enabled = false;
            _btn_1.Enabled = false;
            _btn_2.Enabled = false;
            _btn_3.Enabled = false;
            _btn_4.Enabled = false;
            _btn_5.Enabled = false;
            _btn_6.Enabled = false;
            _btn_7.Enabled = false;
            _btn_8.Enabled = false;
            _btn_9.Enabled = false;
            _btn_trash.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_dni.Text.Length == 7)
            {
                _btn_0.Enabled = true;
                _btn_1.Enabled = true;
                _btn_2.Enabled = true;
                _btn_3.Enabled = true;
                _btn_4.Enabled = true;
                _btn_5.Enabled = true;
                _btn_6.Enabled = true;
                _btn_7.Enabled = true;
                _btn_8.Enabled = true;
                _btn_9.Enabled = true;
                _btn_trash.Enabled = true;
                btn_delete.Enabled = true;
                txt_dni.Enabled = false;
                return;
            }
            _btn_0.Enabled = false;
            _btn_1.Enabled = false;
            _btn_2.Enabled = false;
            _btn_3.Enabled = false;
            _btn_4.Enabled = false;
            _btn_5.Enabled = false;
            _btn_6.Enabled = false;
            _btn_7.Enabled = false;
            _btn_8.Enabled = false;
            _btn_9.Enabled = false;
            _btn_trash.Enabled = false;
            btn_delete.Enabled = false;
        }

        public void ClearData()
        {
            txt_dni.Clear();
            txt_pass.Clear();
        }
    }
}
