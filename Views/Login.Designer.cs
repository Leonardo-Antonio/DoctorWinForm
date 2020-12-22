
namespace Doctor.Views
{
    partial class Login
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
            this._btn_0 = new MetroFramework.Controls.MetroButton();
            this.txt_dni = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_pass = new MetroFramework.Controls.MetroTextBox();
            this._btn_1 = new MetroFramework.Controls.MetroButton();
            this._btn_2 = new MetroFramework.Controls.MetroButton();
            this._btn_3 = new MetroFramework.Controls.MetroButton();
            this._btn_4 = new MetroFramework.Controls.MetroButton();
            this._btn_5 = new MetroFramework.Controls.MetroButton();
            this._btn_6 = new MetroFramework.Controls.MetroButton();
            this._btn_7 = new MetroFramework.Controls.MetroButton();
            this._btn_8 = new MetroFramework.Controls.MetroButton();
            this._btn_9 = new MetroFramework.Controls.MetroButton();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this._btn_trash = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // _btn_0
            // 
            this._btn_0.Location = new System.Drawing.Point(128, 103);
            this._btn_0.Name = "_btn_0";
            this._btn_0.Size = new System.Drawing.Size(50, 50);
            this._btn_0.TabIndex = 0;
            this._btn_0.Text = "0";
            this._btn_0.UseSelectable = true;
            this._btn_0.Click += new System.EventHandler(this._btn_0_Click);
            // 
            // txt_dni
            // 
            // 
            // 
            // 
            this.txt_dni.CustomButton.Image = null;
            this.txt_dni.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txt_dni.CustomButton.Name = "";
            this.txt_dni.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_dni.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_dni.CustomButton.TabIndex = 1;
            this.txt_dni.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_dni.CustomButton.UseSelectable = true;
            this.txt_dni.CustomButton.Visible = false;
            this.txt_dni.Lines = new string[0];
            this.txt_dni.Location = new System.Drawing.Point(81, 35);
            this.txt_dni.MaxLength = 32767;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.PasswordChar = '\0';
            this.txt_dni.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dni.SelectedText = "";
            this.txt_dni.SelectionLength = 0;
            this.txt_dni.SelectionStart = 0;
            this.txt_dni.ShortcutsEnabled = true;
            this.txt_dni.Size = new System.Drawing.Size(128, 23);
            this.txt_dni.TabIndex = 1;
            this.txt_dni.UseSelectable = true;
            this.txt_dni.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dni.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "DNI :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(233, 37);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Password :";
            // 
            // txt_pass
            // 
            // 
            // 
            // 
            this.txt_pass.CustomButton.Image = null;
            this.txt_pass.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txt_pass.CustomButton.Name = "";
            this.txt_pass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pass.CustomButton.TabIndex = 1;
            this.txt_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pass.CustomButton.UseSelectable = true;
            this.txt_pass.CustomButton.Visible = false;
            this.txt_pass.Lines = new string[0];
            this.txt_pass.Location = new System.Drawing.Point(309, 35);
            this.txt_pass.MaxLength = 8;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pass.SelectedText = "";
            this.txt_pass.SelectionLength = 0;
            this.txt_pass.SelectionStart = 0;
            this.txt_pass.ShortcutsEnabled = true;
            this.txt_pass.Size = new System.Drawing.Size(128, 23);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.UseSelectable = true;
            this.txt_pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _btn_1
            // 
            this._btn_1.Location = new System.Drawing.Point(184, 103);
            this._btn_1.Name = "_btn_1";
            this._btn_1.Size = new System.Drawing.Size(50, 50);
            this._btn_1.TabIndex = 5;
            this._btn_1.Text = "1";
            this._btn_1.UseSelectable = true;
            this._btn_1.Click += new System.EventHandler(this._btn_1_Click);
            // 
            // _btn_2
            // 
            this._btn_2.Location = new System.Drawing.Point(240, 103);
            this._btn_2.Name = "_btn_2";
            this._btn_2.Size = new System.Drawing.Size(50, 50);
            this._btn_2.TabIndex = 6;
            this._btn_2.Text = "2";
            this._btn_2.UseSelectable = true;
            this._btn_2.Click += new System.EventHandler(this._btn_2_Click);
            // 
            // _btn_3
            // 
            this._btn_3.Location = new System.Drawing.Point(128, 159);
            this._btn_3.Name = "_btn_3";
            this._btn_3.Size = new System.Drawing.Size(50, 50);
            this._btn_3.TabIndex = 7;
            this._btn_3.Text = "3";
            this._btn_3.UseSelectable = true;
            this._btn_3.Click += new System.EventHandler(this._btn_3_Click);
            // 
            // _btn_4
            // 
            this._btn_4.Location = new System.Drawing.Point(184, 159);
            this._btn_4.Name = "_btn_4";
            this._btn_4.Size = new System.Drawing.Size(50, 50);
            this._btn_4.TabIndex = 8;
            this._btn_4.Text = "4";
            this._btn_4.UseSelectable = true;
            this._btn_4.Click += new System.EventHandler(this._btn_4_Click);
            // 
            // _btn_5
            // 
            this._btn_5.Location = new System.Drawing.Point(240, 159);
            this._btn_5.Name = "_btn_5";
            this._btn_5.Size = new System.Drawing.Size(50, 50);
            this._btn_5.TabIndex = 9;
            this._btn_5.Text = "5";
            this._btn_5.UseSelectable = true;
            this._btn_5.Click += new System.EventHandler(this._btn_5_Click);
            // 
            // _btn_6
            // 
            this._btn_6.Location = new System.Drawing.Point(128, 215);
            this._btn_6.Name = "_btn_6";
            this._btn_6.Size = new System.Drawing.Size(50, 50);
            this._btn_6.TabIndex = 10;
            this._btn_6.Text = "6";
            this._btn_6.UseSelectable = true;
            this._btn_6.Click += new System.EventHandler(this._btn_6_Click);
            // 
            // _btn_7
            // 
            this._btn_7.Location = new System.Drawing.Point(184, 215);
            this._btn_7.Name = "_btn_7";
            this._btn_7.Size = new System.Drawing.Size(50, 50);
            this._btn_7.TabIndex = 11;
            this._btn_7.Text = "7";
            this._btn_7.UseSelectable = true;
            this._btn_7.Click += new System.EventHandler(this._btn_7_Click);
            // 
            // _btn_8
            // 
            this._btn_8.Location = new System.Drawing.Point(240, 215);
            this._btn_8.Name = "_btn_8";
            this._btn_8.Size = new System.Drawing.Size(50, 50);
            this._btn_8.TabIndex = 12;
            this._btn_8.Text = "8";
            this._btn_8.UseSelectable = true;
            this._btn_8.Click += new System.EventHandler(this._btn_8_Click);
            // 
            // _btn_9
            // 
            this._btn_9.Location = new System.Drawing.Point(296, 215);
            this._btn_9.Name = "_btn_9";
            this._btn_9.Size = new System.Drawing.Size(50, 50);
            this._btn_9.TabIndex = 13;
            this._btn_9.Text = "9";
            this._btn_9.UseSelectable = true;
            this._btn_9.Click += new System.EventHandler(this._btn_9_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(296, 159);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(50, 50);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "<-";
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // _btn_trash
            // 
            this._btn_trash.BackgroundImage = global::Doctor.Properties.Resources.trash;
            this._btn_trash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._btn_trash.Location = new System.Drawing.Point(296, 103);
            this._btn_trash.Name = "_btn_trash";
            this._btn_trash.Size = new System.Drawing.Size(50, 50);
            this._btn_trash.TabIndex = 15;
            this._btn_trash.UseSelectable = true;
            this._btn_trash.Click += new System.EventHandler(this._btn_trash_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._btn_trash);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this._btn_9);
            this.Controls.Add(this._btn_8);
            this.Controls.Add(this._btn_7);
            this.Controls.Add(this._btn_6);
            this.Controls.Add(this._btn_5);
            this.Controls.Add(this._btn_4);
            this.Controls.Add(this._btn_3);
            this.Controls.Add(this._btn_2);
            this.Controls.Add(this._btn_1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this._btn_0);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(480, 300);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton _btn_0;
        private MetroFramework.Controls.MetroTextBox txt_dni;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_pass;
        private MetroFramework.Controls.MetroButton _btn_1;
        private MetroFramework.Controls.MetroButton _btn_2;
        private MetroFramework.Controls.MetroButton _btn_3;
        private MetroFramework.Controls.MetroButton _btn_4;
        private MetroFramework.Controls.MetroButton _btn_5;
        private MetroFramework.Controls.MetroButton _btn_6;
        private MetroFramework.Controls.MetroButton _btn_7;
        private MetroFramework.Controls.MetroButton _btn_8;
        private MetroFramework.Controls.MetroButton _btn_9;
        private MetroFramework.Controls.MetroButton btn_delete;
        private MetroFramework.Controls.MetroButton _btn_trash;
    }
}
