namespace Citas_Medicas
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.citaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCitaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCitasMedicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCitasProgramadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citaMedicaToolStripMenuItem,
            this.listaDeCitasMedicasToolStripMenuItem,
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem,
            this.registrarseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // citaMedicaToolStripMenuItem
            // 
            this.citaMedicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCitaMedicaToolStripMenuItem});
            this.citaMedicaToolStripMenuItem.Name = "citaMedicaToolStripMenuItem";
            this.citaMedicaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.citaMedicaToolStripMenuItem.Text = "Cita Medica";
            // 
            // crearCitaMedicaToolStripMenuItem
            // 
            this.crearCitaMedicaToolStripMenuItem.Name = "crearCitaMedicaToolStripMenuItem";
            this.crearCitaMedicaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.crearCitaMedicaToolStripMenuItem.Text = "Crear Cita Medica";
            this.crearCitaMedicaToolStripMenuItem.Click += new System.EventHandler(this.crearCitaMedicaToolStripMenuItem_Click);
            // 
            // listaDeCitasMedicasToolStripMenuItem
            // 
            this.listaDeCitasMedicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarCitasProgramadasToolStripMenuItem});
            this.listaDeCitasMedicasToolStripMenuItem.Name = "listaDeCitasMedicasToolStripMenuItem";
            this.listaDeCitasMedicasToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.listaDeCitasMedicasToolStripMenuItem.Text = "Lista de Citas Medicas";
            // 
            // buscarCitasProgramadasToolStripMenuItem
            // 
            this.buscarCitasProgramadasToolStripMenuItem.Name = "buscarCitasProgramadasToolStripMenuItem";
            this.buscarCitasProgramadasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.buscarCitasProgramadasToolStripMenuItem.Text = "Buscar Citas Programadas";
            this.buscarCitasProgramadasToolStripMenuItem.Click += new System.EventHandler(this.buscarCitasProgramadasToolStripMenuItem_Click);
            // 
            // listaDeDoctoresYEspecialidadesToolStripMenuItem
            // 
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem.Name = "listaDeDoctoresYEspecialidadesToolStripMenuItem";
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(197, 20);
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem.Text = "Lista de Doctores y Especialidades";
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.listaDeDoctoresYEspecialidadesToolStripMenuItem_Click);
            // 
            // registrarseToolStripMenuItem
            // 
            this.registrarseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            this.registrarseToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.registrarseToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 366);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormMenu";
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem citaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCitaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCitasMedicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCitasProgramadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeDoctoresYEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}