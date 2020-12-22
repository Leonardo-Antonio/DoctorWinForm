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
    public partial class Contrareferencia : UserControl
    {
        public Contrareferencia()
        {
            InitializeComponent();
        }

        private void Contrareferencia_Load(object sender, EventArgs e)
        {
            lbl_id.Hide();
            this._listContraReferencia();
        }
        private void _listContraReferencia()
        {
            var list = (from cr in LocalStorage.DBUtil.db.tb_contrareferencia
                        join patient in LocalStorage.DBUtil.db.tb_patient
                        on cr.id_patient equals patient.id
                        into pt
                        from data in pt
                        where cr.deleted_at == null
                        select new
                        {
                            ID = cr.id,
                            EstRefNom = cr.est_ref_name,
                            EstRefDir = cr.est_ref_dir,
                            EstCRefNom = cr.est_contref_name,
                            EstCRefDir = cr.est_contref_dir,
                            EstCRefDiag = cr.est_contref_diagnosis,
                            Tratamiento = cr.treatment,
                            APS = cr.ind_aps,
                            Fecha = cr.date_contref,
                            DNI = cr.id_patient,
                        }).ToList();
            dgv_contrareferencia.DataSource = list;
        }

        private void _btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var dni = (from patient in LocalStorage.DBUtil.db.tb_patient
                           where patient.id == txt_dni.Text
                           select new { ID = patient.id }).First();
            }
            catch (InvalidOperationException)
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "El DNI del paciente no esta registrado en la base de datos, no podra hacer ninguna operación",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }
            if (string.IsNullOrEmpty(txt_EstRefNom.Text) || string.IsNullOrEmpty(txt_EstRefDir.Text) ||
                string.IsNullOrEmpty(txt_EstCRefNom.Text) || string.IsNullOrEmpty(txt_EstCRefDir.Text) ||
                string.IsNullOrEmpty(txt_EstCRefDiag.Text))
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "Los unicos campos que pueden estar vacion son tratamieto y aps, los otros campos son obligatorios",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
            var model = new Models.tb_contrareferencia()
            {
                est_ref_name = txt_EstRefNom.Text,
                est_ref_dir = txt_EstRefDir.Text,
                est_contref_name = txt_EstCRefNom.Text,
                est_contref_dir = txt_EstCRefDir.Text,
                est_contref_diagnosis = txt_EstCRefDiag.Text,
                treatment = (string.IsNullOrEmpty(txt_tratamiento.Text)) ? null : txt_tratamiento.Text,
                ind_aps = (string.IsNullOrEmpty(txt_aps.Text)) ? null : txt_aps.Text,
                date_contref = DateTime.Now,
                id_patient = txt_dni.Text,
                id_doctor = LocalStorage.Doctor.ID,
            };

            LocalStorage.DBUtil.db.tb_contrareferencia.Add(model);
            var response = LocalStorage.DBUtil.db.SaveChanges();
            var ok = LocalStorage.MessageResponse.Show(response, this, "creado");
            if (ok) this._listContraReferencia();
        }

        private void _btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl_id.Text))
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "Seleccion una contra referencia que esta en la pestaña search",
                    "Seleccion una contra referencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }
            var ID = int.Parse(lbl_id.Text);
            var model = LocalStorage.DBUtil.db.tb_contrareferencia.Find(ID);
            model.deleted_at = DateTime.Now;
            var response = LocalStorage.DBUtil.db.SaveChanges();
            var ok = LocalStorage.MessageResponse.Show(response, this, "eliminado");
            if (ok) this._listContraReferencia();
        }

        private void dgv_contrareferencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_contrareferencia.Rows[e.RowIndex].Cells["Tratamiento"].Value == null)
                    txt_tratamiento.Text = "";
                else
                    txt_tratamiento.Text = dgv_contrareferencia.Rows[e.RowIndex].Cells["Tratamiento"].Value.ToString();

                if (dgv_contrareferencia.Rows[e.RowIndex].Cells["APS"].Value == null)
                    txt_aps.Text = "";
                else
                    txt_aps.Text = dgv_contrareferencia.Rows[e.RowIndex].Cells["APS"].Value.ToString();

                lbl_id.Text = dgv_contrareferencia.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txt_EstRefNom.Text = dgv_contrareferencia.Rows[e.RowIndex].Cells["EstRefNom"].Value.ToString();
                txt_EstRefDir.Text = dgv_contrareferencia.Rows[e.RowIndex].Cells["EstRefDir"].Value.ToString();
                txt_EstCRefNom.Text = dgv_contrareferencia.Rows[e.RowIndex].Cells["EstCRefNom"].Value.ToString();
                txt_EstRefDir.Text = dgv_contrareferencia.Rows[e.RowIndex].Cells["EstCRefDir"].Value.ToString();
                txt_EstCRefDiag.Text = dgv_contrareferencia.Rows[e.RowIndex].Cells["EstCRefDiag"].Value.ToString();
                txt_dni.Text = dgv_contrareferencia.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void _btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                var dni = (from patient in LocalStorage.DBUtil.db.tb_patient
                           where patient.id == txt_dni.Text
                           select new { ID = patient.id }).First();
            }
            catch (InvalidOperationException)
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "El DNI del paciente no esta registrado en la base de datos, no podra hacer ninguna operación",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }
            if (string.IsNullOrEmpty(txt_EstRefNom.Text) || string.IsNullOrEmpty(txt_EstRefDir.Text) ||
                string.IsNullOrEmpty(txt_EstCRefNom.Text) || string.IsNullOrEmpty(txt_EstCRefDir.Text) ||
                string.IsNullOrEmpty(txt_EstCRefDiag.Text))
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "Los unicos campos que pueden estar vacion son tratamieto y aps, los otros campos son obligatorios",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            if (string.IsNullOrEmpty(lbl_id.Text))
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "Seleccion una contra referencia que esta en la pestaña search",
                    "Seleccion una contra referencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            var ID = int.Parse(lbl_id.Text);
            var model = LocalStorage.DBUtil.db.tb_contrareferencia.Find(ID);

            model.updated_at = DateTime.Now;
            model.est_ref_name = txt_EstRefNom.Text;
            model.est_ref_dir = txt_EstRefDir.Text;
            model.est_contref_name = txt_EstCRefNom.Text;
            model.est_contref_dir = txt_EstCRefDir.Text;
            model.est_contref_diagnosis = txt_EstCRefDiag.Text;
            model.treatment = (string.IsNullOrEmpty(txt_tratamiento.Text)) ? null : txt_tratamiento.Text;
            model.ind_aps = (string.IsNullOrEmpty(txt_aps.Text)) ? null : txt_aps.Text;
            model.id_patient = txt_dni.Text;
            model.id_doctor = LocalStorage.Doctor.ID;
            
            var response = LocalStorage.DBUtil.db.SaveChanges();
            var ok = LocalStorage.MessageResponse.Show(response, this, "actualizado");
            if (ok) this._listContraReferencia();
        }
    }
}
