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
            this._listContraReferencia();
        }
        private void _listContraReferencia()
        {
            var list = (from cr in LocalStorage.DBUtil.db.tb_contrareferencia
                        join patient in LocalStorage.DBUtil.db.tb_patient
                        on cr.id_patient equals patient.id
                        into pt
                        from data in pt
                        where cr.state == true
                        select new
                        {
                            ID = cr.id,
                            EstRefencia = cr.est_ref_name,
                            EstRefenciaDir = cr.est_ref_dir,
                            EstContraReferencia = cr.est_contref_name,
                            EstContraReferenciaDir = cr.est_contref_dir,
                            EstContraRefDiagnostico = cr.est_contref_diagnosis,
                            Tratamiento = cr.treatment,
                            APS = cr.ind_aps,
                            Fecha = cr.date_contref,
                            DNI = cr.id_patient,
                        }).ToList();
            dgv_contrareferencia.DataSource = list;
        }
    }
}
