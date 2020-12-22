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
    public partial class Diagnosis : UserControl
    {
        public Diagnosis()
        {
            InitializeComponent();
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            lbl_id.Hide();
            this._listDiagnosis();
        }

        private void _btn_add_Click(object sender, EventArgs e)
        {
            if (txt_motivo_consulta.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "No deje el campo vacio", "Advertencia", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                    );
                return;
            }
            try
            {
                var model = new Models.tb_diagnosis();
                model.reasons_for_consultation = txt_motivo_consulta.Text;
                if (string.IsNullOrEmpty(txt_hp.Text))
                    model.pathological_history = null;
                else
                    model.pathological_history = txt_hp.Text;

                if (string.IsNullOrEmpty(txt_enfermedad.Text))
                    model.current_illness = null;
                else
                    model.current_illness = txt_enfermedad.Text;
                model.id_clinic_history = int.Parse(txt_num_hc.Text);
                model.id_doctor = LocalStorage.Doctor.ID;

                LocalStorage.DBUtil.db.tb_diagnosis.Add(model);
                var response = LocalStorage.DBUtil.db.SaveChanges();
                if (response != 1)
                {
                    MetroFramework.MetroMessageBox.Show(
                        this, "No hubieron filas afectafas",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(
                        this, "Registro creado correctamente",
                        "Creado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                        );
                    this._listDiagnosis();
                }

                this._listDiagnosis();
            } catch (FormatException)
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "El num historia clinica debe ser un dato de tipo numerico", 
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "El num de historia clinica no existe", 
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void _listDiagnosis()
        {
            var list = from diagnosis in LocalStorage.DBUtil.db.tb_diagnosis
                       join patient in LocalStorage.DBUtil.db.tb_patient
                       on diagnosis.id_clinic_history equals patient.id_clinic_history
                       into dp
                       from data in dp
                       where diagnosis.deleted_at == null
                       select new
                       {
                           DNI = data.id,
                           Nombre_Apellidos = data.name + " " + data.a_p + " " + data.a_m,
                           Motivo_de_consulta = diagnosis.reasons_for_consultation,
                           Enfermedad = diagnosis.current_illness,
                           Historial_Patológico = diagnosis.pathological_history,
                           NunHistoria_Clinica = data.id_clinic_history,
                           IDDoc = diagnosis.id_doctor,
                           IDDiagnosis = diagnosis.id,
                           Deleted_at = diagnosis.deleted_at,
                           Updated_at = diagnosis.updated_at,
                       };

            dgv_diagnosis.DataSource = list.ToList();
        }

        private void dgv_diagnosis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_diagnosis.Rows[e.RowIndex].Cells["Historial_Patológico"].Value == null)
                txt_hp.Text = "";
            else
                txt_hp.Text = dgv_diagnosis.Rows[e.RowIndex].Cells["Historial_Patológico"].Value.ToString();

            if (dgv_diagnosis.Rows[e.RowIndex].Cells["Enfermedad"].Value == null)
                txt_enfermedad.Text = "";
            else
                txt_enfermedad.Text = dgv_diagnosis.Rows[e.RowIndex].Cells["Enfermedad"].Value.ToString();

            lbl_id.Text = dgv_diagnosis.Rows[e.RowIndex].Cells["IDDiagnosis"].Value.ToString();
            txt_motivo_consulta.Text = dgv_diagnosis.Rows[e.RowIndex].Cells["Motivo_de_consulta"].Value.ToString();
            txt_num_hc.Text = dgv_diagnosis.Rows[e.RowIndex].Cells["NunHistoria_Clinica"].Value.ToString();
        }

        private void _btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_motivo_consulta.Text))
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "No deje el campo motivo de consulta vacio",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }
            if (int.Parse(lbl_id.Text) == 0)
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "Seleccion un diagnostico que esta en la pestaña search", 
                    "Seleccion un diagnostico", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }
            try
            {
                var ID = int.Parse(lbl_id.Text);
                var model = LocalStorage.DBUtil.db.tb_diagnosis.Find(ID);
                model.updated_at = DateTime.Now;
                model.id_doctor = LocalStorage.Doctor.ID;
                model.reasons_for_consultation = txt_motivo_consulta.Text;
                if (string.IsNullOrEmpty(txt_hp.Text))
                    model.pathological_history = null;
                else
                    model.pathological_history = txt_hp.Text;

                if (string.IsNullOrEmpty(txt_enfermedad.Text))
                    model.current_illness = null;
                else
                    model.current_illness = txt_enfermedad.Text;
                model.id_clinic_history = int.Parse(txt_num_hc.Text);
                var response = LocalStorage.DBUtil.db.SaveChanges();
                if (response != 1)
                {
                    MetroFramework.MetroMessageBox.Show(
                        this, "No hubieron filas afectafas",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(
                        this, "Registro actualizado correctamente",
                        "Actualizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                        );
                    this._listDiagnosis();
                }
            } catch (FormatException)
            {
                MetroFramework.MetroMessageBox.Show(
                        this, "El numero de historia debe ser un dato numerico",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
            } catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "El num de historia clinica no existe",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void _btn_delete_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbl_id.Text) == 0)
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "Seleccion un diagnostico que esta en la pestaña search",
                    "Seleccion un diagnostico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }
            var ID = int.Parse(lbl_id.Text);
            var model = LocalStorage.DBUtil.db.tb_diagnosis.Find(ID);
            model.deleted_at = DateTime.Now;
            var response = LocalStorage.DBUtil.db.SaveChanges();
            if (response != 1)
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "No hubieron filas afectafas",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(
                    this, "Registro eliminado correctamente",
                    "Eliminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
                this._listDiagnosis();
            }
        }
    }
}
