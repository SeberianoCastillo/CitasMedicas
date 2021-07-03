namespace Citas_Medicas
{
    partial class FormCrearCitaMedica
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label medicoLabel;
            System.Windows.Forms.Label motivoCitaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearCitaMedica));
            System.Windows.Forms.Label precioLabel;
            this.listaPacientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaPacientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.medicoTextBox = new System.Windows.Forms.TextBox();
            this.motivoCitaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.listaPacientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fechaLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            medicoLabel = new System.Windows.Forms.Label();
            motivoCitaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingNavigator)).BeginInit();
            this.listaPacientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(14, 116);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 1;
            fechaLabel.Text = "Fecha:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(121, 116);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 3;
            horaLabel.Text = "Hora:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(14, 38);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // medicoLabel
            // 
            medicoLabel.AutoSize = true;
            medicoLabel.Location = new System.Drawing.Point(451, 77);
            medicoLabel.Name = "medicoLabel";
            medicoLabel.Size = new System.Drawing.Size(45, 13);
            medicoLabel.TabIndex = 7;
            medicoLabel.Text = "Medico:";
            // 
            // motivoCitaLabel
            // 
            motivoCitaLabel.AutoSize = true;
            motivoCitaLabel.Location = new System.Drawing.Point(235, 77);
            motivoCitaLabel.Name = "motivoCitaLabel";
            motivoCitaLabel.Size = new System.Drawing.Size(63, 13);
            motivoCitaLabel.TabIndex = 9;
            motivoCitaLabel.Text = "Motivo Cita:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(14, 77);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 11;
            nombreLabel.Text = "Nombre:";
            // 
            // listaPacientesBindingNavigator
            // 
            this.listaPacientesBindingNavigator.AddNewItem = null;
            this.listaPacientesBindingNavigator.BindingSource = this.listaPacientesBindingSource;
            this.listaPacientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaPacientesBindingNavigator.DeleteItem = null;
            this.listaPacientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaPacientesBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaPacientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaPacientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaPacientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaPacientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaPacientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaPacientesBindingNavigator.Name = "listaPacientesBindingNavigator";
            this.listaPacientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaPacientesBindingNavigator.Size = new System.Drawing.Size(789, 25);
            this.listaPacientesBindingNavigator.TabIndex = 0;
            this.listaPacientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaPacientesBindingNavigatorSaveItem
            // 
            this.listaPacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaPacientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaPacientesBindingNavigatorSaveItem.Image")));
            this.listaPacientesBindingNavigatorSaveItem.Name = "listaPacientesBindingNavigatorSaveItem";
            this.listaPacientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaPacientesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaPacientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaPacientesBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // fechaTextBox
            // 
            this.fechaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Fecha", true));
            this.fechaTextBox.Location = new System.Drawing.Point(17, 132);
            this.fechaTextBox.Name = "fechaTextBox";
            this.fechaTextBox.Size = new System.Drawing.Size(100, 20);
            this.fechaTextBox.TabIndex = 4;
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(127, 132);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(79, 20);
            this.horaTextBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(17, 54);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // medicoTextBox
            // 
            this.medicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Medico", true));
            this.medicoTextBox.Location = new System.Drawing.Point(454, 93);
            this.medicoTextBox.Name = "medicoTextBox";
            this.medicoTextBox.Size = new System.Drawing.Size(210, 20);
            this.medicoTextBox.TabIndex = 3;
            // 
            // motivoCitaTextBox
            // 
            this.motivoCitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "MotivoCita", true));
            this.motivoCitaTextBox.Location = new System.Drawing.Point(238, 93);
            this.motivoCitaTextBox.Name = "motivoCitaTextBox";
            this.motivoCitaTextBox.Size = new System.Drawing.Size(210, 20);
            this.motivoCitaTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(17, 93);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(210, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(233, 116);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 14;
            precioLabel.Text = "Precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(236, 132);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(85, 20);
            this.precioTextBox.TabIndex = 6;
            // 
            // listaPacientesDataGridView
            // 
            this.listaPacientesDataGridView.AutoGenerateColumns = false;
            this.listaPacientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPacientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.listaPacientesDataGridView.DataSource = this.listaPacientesBindingSource;
            this.listaPacientesDataGridView.Location = new System.Drawing.Point(17, 158);
            this.listaPacientesDataGridView.Name = "listaPacientesDataGridView";
            this.listaPacientesDataGridView.Size = new System.Drawing.Size(764, 147);
            this.listaPacientesDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MotivoCita";
            this.dataGridViewTextBoxColumn3.HeaderText = "MotivoCita";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Medico";
            this.dataGridViewTextBoxColumn4.HeaderText = "Medico";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn6.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // listaPacientesBindingSource
            // 
            this.listaPacientesBindingSource.DataSource = typeof(BL.CitasMedicas.Paciente);
            // 
            // FormCrearCitaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 322);
            this.Controls.Add(this.listaPacientesDataGridView);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaTextBox);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(medicoLabel);
            this.Controls.Add(this.medicoTextBox);
            this.Controls.Add(motivoCitaLabel);
            this.Controls.Add(this.motivoCitaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.listaPacientesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCrearCitaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Cita Medica";
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingNavigator)).EndInit();
            this.listaPacientesBindingNavigator.ResumeLayout(false);
            this.listaPacientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaPacientesBindingSource;
        private System.Windows.Forms.BindingNavigator listaPacientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaPacientesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox medicoTextBox;
        private System.Windows.Forms.TextBox motivoCitaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.DataGridView listaPacientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}