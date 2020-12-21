
namespace Doctor.Views
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._pnl_dock = new MetroFramework.Controls.MetroPanel();
            this._pnl_main = new MetroFramework.Controls.MetroPanel();
            this._btn_contrarefencia = new MetroFramework.Controls.MetroButton();
            this._btn_diagnosis = new MetroFramework.Controls.MetroButton();
            this._btn_login = new MetroFramework.Controls.MetroButton();
            this._pnl_dock.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnl_dock
            // 
            this._pnl_dock.Controls.Add(this._btn_contrarefencia);
            this._pnl_dock.Controls.Add(this._btn_diagnosis);
            this._pnl_dock.Controls.Add(this._btn_login);
            this._pnl_dock.HorizontalScrollbarBarColor = true;
            this._pnl_dock.HorizontalScrollbarHighlightOnWheel = false;
            this._pnl_dock.HorizontalScrollbarSize = 10;
            this._pnl_dock.Location = new System.Drawing.Point(23, 63);
            this._pnl_dock.Name = "_pnl_dock";
            this._pnl_dock.Size = new System.Drawing.Size(69, 186);
            this._pnl_dock.TabIndex = 0;
            this._pnl_dock.VerticalScrollbarBarColor = true;
            this._pnl_dock.VerticalScrollbarHighlightOnWheel = false;
            this._pnl_dock.VerticalScrollbarSize = 10;
            // 
            // _pnl_main
            // 
            this._pnl_main.HorizontalScrollbarBarColor = true;
            this._pnl_main.HorizontalScrollbarHighlightOnWheel = false;
            this._pnl_main.HorizontalScrollbarSize = 10;
            this._pnl_main.Location = new System.Drawing.Point(98, 63);
            this._pnl_main.Name = "_pnl_main";
            this._pnl_main.Size = new System.Drawing.Size(479, 264);
            this._pnl_main.TabIndex = 1;
            this._pnl_main.VerticalScrollbarBarColor = true;
            this._pnl_main.VerticalScrollbarHighlightOnWheel = false;
            this._pnl_main.VerticalScrollbarSize = 10;
            // 
            // _btn_contrarefencia
            // 
            this._btn_contrarefencia.BackgroundImage = global::Doctor.Properties.Resources.cr;
            this._btn_contrarefencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._btn_contrarefencia.Location = new System.Drawing.Point(0, 126);
            this._btn_contrarefencia.Name = "_btn_contrarefencia";
            this._btn_contrarefencia.Size = new System.Drawing.Size(69, 57);
            this._btn_contrarefencia.TabIndex = 3;
            this._btn_contrarefencia.Text = "contro referencia";
            this._btn_contrarefencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btn_contrarefencia.UseSelectable = true;
            this._btn_contrarefencia.Click += new System.EventHandler(this._btn_contrarefencia_Click);
            // 
            // _btn_diagnosis
            // 
            this._btn_diagnosis.BackgroundImage = global::Doctor.Properties.Resources.diagnosis;
            this._btn_diagnosis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._btn_diagnosis.Location = new System.Drawing.Point(0, 63);
            this._btn_diagnosis.Name = "_btn_diagnosis";
            this._btn_diagnosis.Size = new System.Drawing.Size(69, 57);
            this._btn_diagnosis.TabIndex = 2;
            this._btn_diagnosis.Text = "Diagnosis";
            this._btn_diagnosis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btn_diagnosis.UseSelectable = true;
            this._btn_diagnosis.Click += new System.EventHandler(this._btn_diagnosis_Click);
            // 
            // _btn_login
            // 
            this._btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btn_login.BackgroundImage = global::Doctor.Properties.Resources.medical_doctor;
            this._btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._btn_login.Location = new System.Drawing.Point(0, 0);
            this._btn_login.Name = "_btn_login";
            this._btn_login.Size = new System.Drawing.Size(69, 57);
            this._btn_login.TabIndex = 1;
            this._btn_login.Text = "Login";
            this._btn_login.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btn_login.UseSelectable = true;
            this._btn_login.Click += new System.EventHandler(this._btn_login_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this._pnl_main);
            this.Controls.Add(this._pnl_dock);
            this.Name = "Main";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Main_Load);
            this._pnl_dock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel _pnl_dock;
        private MetroFramework.Controls.MetroButton _btn_login;
        private MetroFramework.Controls.MetroButton _btn_contrarefencia;
        private MetroFramework.Controls.MetroButton _btn_diagnosis;
        private MetroFramework.Controls.MetroPanel _pnl_main;
    }
}