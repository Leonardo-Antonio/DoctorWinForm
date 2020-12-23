
namespace Doctor.Views
{
    partial class Diagnosis
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._tab_container = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this._btn_delete = new MetroFramework.Controls.MetroButton();
            this.lbl_id = new MetroFramework.Controls.MetroLabel();
            this._btn_update = new MetroFramework.Controls.MetroButton();
            this._btn_add = new MetroFramework.Controls.MetroButton();
            this.txt_num_hc = new MetroFramework.Controls.MetroTextBox();
            this.txt_hp = new MetroFramework.Controls.MetroTextBox();
            this.txt_enfermedad = new MetroFramework.Controls.MetroTextBox();
            this.txt_motivo_consulta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dgv_diagnosis = new MetroFramework.Controls.MetroGrid();
            this._tab_container.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // _tab_container
            // 
            this._tab_container.Controls.Add(this.metroTabPage1);
            this._tab_container.Controls.Add(this.metroTabPage2);
            this._tab_container.Location = new System.Drawing.Point(1, 3);
            this._tab_container.Name = "_tab_container";
            this._tab_container.SelectedIndex = 0;
            this._tab_container.Size = new System.Drawing.Size(479, 300);
            this._tab_container.TabIndex = 1;
            this._tab_container.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this._btn_delete);
            this.metroTabPage1.Controls.Add(this.lbl_id);
            this.metroTabPage1.Controls.Add(this._btn_update);
            this.metroTabPage1.Controls.Add(this._btn_add);
            this.metroTabPage1.Controls.Add(this.txt_num_hc);
            this.metroTabPage1.Controls.Add(this.txt_hp);
            this.metroTabPage1.Controls.Add(this.txt_enfermedad);
            this.metroTabPage1.Controls.Add(this.txt_motivo_consulta);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(471, 258);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Diagnosis";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // _btn_delete
            // 
            this._btn_delete.Location = new System.Drawing.Point(312, 202);
            this._btn_delete.Name = "_btn_delete";
            this._btn_delete.Size = new System.Drawing.Size(143, 38);
            this._btn_delete.TabIndex = 15;
            this._btn_delete.Text = "Eliminar";
            this._btn_delete.UseSelectable = true;
            this._btn_delete.Click += new System.EventHandler(this._btn_delete_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(372, 31);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 0);
            this.lbl_id.TabIndex = 14;
            // 
            // _btn_update
            // 
            this._btn_update.Location = new System.Drawing.Point(163, 202);
            this._btn_update.Name = "_btn_update";
            this._btn_update.Size = new System.Drawing.Size(143, 38);
            this._btn_update.TabIndex = 13;
            this._btn_update.Text = "Actualizar";
            this._btn_update.UseSelectable = true;
            this._btn_update.Click += new System.EventHandler(this._btn_update_Click);
            // 
            // _btn_add
            // 
            this._btn_add.Location = new System.Drawing.Point(14, 202);
            this._btn_add.Name = "_btn_add";
            this._btn_add.Size = new System.Drawing.Size(143, 38);
            this._btn_add.TabIndex = 12;
            this._btn_add.Text = "Agregar";
            this._btn_add.UseSelectable = true;
            this._btn_add.Click += new System.EventHandler(this._btn_add_Click);
            // 
            // txt_num_hc
            // 
            // 
            // 
            // 
            this.txt_num_hc.CustomButton.Image = null;
            this.txt_num_hc.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txt_num_hc.CustomButton.Name = "";
            this.txt_num_hc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_num_hc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_num_hc.CustomButton.TabIndex = 1;
            this.txt_num_hc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_num_hc.CustomButton.UseSelectable = true;
            this.txt_num_hc.CustomButton.Visible = false;
            this.txt_num_hc.Lines = new string[0];
            this.txt_num_hc.Location = new System.Drawing.Point(141, 150);
            this.txt_num_hc.MaxLength = 32767;
            this.txt_num_hc.Name = "txt_num_hc";
            this.txt_num_hc.PasswordChar = '\0';
            this.txt_num_hc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_num_hc.SelectedText = "";
            this.txt_num_hc.SelectionLength = 0;
            this.txt_num_hc.SelectionStart = 0;
            this.txt_num_hc.ShortcutsEnabled = true;
            this.txt_num_hc.Size = new System.Drawing.Size(209, 23);
            this.txt_num_hc.TabIndex = 11;
            this.txt_num_hc.UseSelectable = true;
            this.txt_num_hc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_num_hc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_hp
            // 
            // 
            // 
            // 
            this.txt_hp.CustomButton.Image = null;
            this.txt_hp.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txt_hp.CustomButton.Name = "";
            this.txt_hp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_hp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_hp.CustomButton.TabIndex = 1;
            this.txt_hp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_hp.CustomButton.UseSelectable = true;
            this.txt_hp.CustomButton.Visible = false;
            this.txt_hp.Lines = new string[0];
            this.txt_hp.Location = new System.Drawing.Point(141, 109);
            this.txt_hp.MaxLength = 32767;
            this.txt_hp.Name = "txt_hp";
            this.txt_hp.PasswordChar = '\0';
            this.txt_hp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_hp.SelectedText = "";
            this.txt_hp.SelectionLength = 0;
            this.txt_hp.SelectionStart = 0;
            this.txt_hp.ShortcutsEnabled = true;
            this.txt_hp.Size = new System.Drawing.Size(209, 23);
            this.txt_hp.TabIndex = 10;
            this.txt_hp.UseSelectable = true;
            this.txt_hp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_hp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_enfermedad
            // 
            // 
            // 
            // 
            this.txt_enfermedad.CustomButton.Image = null;
            this.txt_enfermedad.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txt_enfermedad.CustomButton.Name = "";
            this.txt_enfermedad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_enfermedad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_enfermedad.CustomButton.TabIndex = 1;
            this.txt_enfermedad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_enfermedad.CustomButton.UseSelectable = true;
            this.txt_enfermedad.CustomButton.Visible = false;
            this.txt_enfermedad.Lines = new string[0];
            this.txt_enfermedad.Location = new System.Drawing.Point(141, 67);
            this.txt_enfermedad.MaxLength = 32767;
            this.txt_enfermedad.Name = "txt_enfermedad";
            this.txt_enfermedad.PasswordChar = '\0';
            this.txt_enfermedad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_enfermedad.SelectedText = "";
            this.txt_enfermedad.SelectionLength = 0;
            this.txt_enfermedad.SelectionStart = 0;
            this.txt_enfermedad.ShortcutsEnabled = true;
            this.txt_enfermedad.Size = new System.Drawing.Size(209, 23);
            this.txt_enfermedad.TabIndex = 9;
            this.txt_enfermedad.UseSelectable = true;
            this.txt_enfermedad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_enfermedad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_motivo_consulta
            // 
            // 
            // 
            // 
            this.txt_motivo_consulta.CustomButton.Image = null;
            this.txt_motivo_consulta.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txt_motivo_consulta.CustomButton.Name = "";
            this.txt_motivo_consulta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_motivo_consulta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_motivo_consulta.CustomButton.TabIndex = 1;
            this.txt_motivo_consulta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_motivo_consulta.CustomButton.UseSelectable = true;
            this.txt_motivo_consulta.CustomButton.Visible = false;
            this.txt_motivo_consulta.Lines = new string[0];
            this.txt_motivo_consulta.Location = new System.Drawing.Point(141, 27);
            this.txt_motivo_consulta.MaxLength = 32767;
            this.txt_motivo_consulta.Name = "txt_motivo_consulta";
            this.txt_motivo_consulta.PasswordChar = '\0';
            this.txt_motivo_consulta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_motivo_consulta.SelectedText = "";
            this.txt_motivo_consulta.SelectionLength = 0;
            this.txt_motivo_consulta.SelectionStart = 0;
            this.txt_motivo_consulta.ShortcutsEnabled = true;
            this.txt_motivo_consulta.Size = new System.Drawing.Size(209, 23);
            this.txt_motivo_consulta.TabIndex = 8;
            this.txt_motivo_consulta.UseSelectable = true;
            this.txt_motivo_consulta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_motivo_consulta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 152);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Num Historia";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 111);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(123, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Historial Parológico";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Enfermedad";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Motivo de consulta";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.dgv_diagnosis);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(471, 258);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Search";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // dgv_diagnosis
            // 
            this.dgv_diagnosis.AllowUserToAddRows = false;
            this.dgv_diagnosis.AllowUserToDeleteRows = false;
            this.dgv_diagnosis.AllowUserToResizeRows = false;
            this.dgv_diagnosis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_diagnosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_diagnosis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_diagnosis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_diagnosis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_diagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_diagnosis.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_diagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_diagnosis.EnableHeadersVisualStyles = false;
            this.dgv_diagnosis.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_diagnosis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_diagnosis.Location = new System.Drawing.Point(0, 0);
            this.dgv_diagnosis.Name = "dgv_diagnosis";
            this.dgv_diagnosis.ReadOnly = true;
            this.dgv_diagnosis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_diagnosis.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_diagnosis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_diagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_diagnosis.Size = new System.Drawing.Size(471, 258);
            this.dgv_diagnosis.TabIndex = 3;
            this.dgv_diagnosis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_diagnosis_CellClick_1);
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._tab_container);
            this.Name = "Diagnosis";
            this.Size = new System.Drawing.Size(480, 300);
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            this._tab_container.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diagnosis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl _tab_container;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_hp;
        private MetroFramework.Controls.MetroTextBox txt_enfermedad;
        private MetroFramework.Controls.MetroTextBox txt_motivo_consulta;
        private MetroFramework.Controls.MetroTextBox txt_num_hc;
        private MetroFramework.Controls.MetroButton _btn_update;
        private MetroFramework.Controls.MetroButton _btn_add;
        private MetroFramework.Controls.MetroLabel lbl_id;
        private MetroFramework.Controls.MetroButton _btn_delete;
        private MetroFramework.Controls.MetroGrid dgv_diagnosis;
    }
}
