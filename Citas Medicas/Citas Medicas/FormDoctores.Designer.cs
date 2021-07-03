namespace Citas_Medicas
{
    partial class FormDoctores
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label disponibilidadLabel;
            System.Windows.Forms.Label especialidadLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label precioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctores));
            this.listaDoctoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listaDoctoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaDoctoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.disponibilidadTextBox = new System.Windows.Forms.TextBox();
            this.especialidadTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            activoLabel = new System.Windows.Forms.Label();
            disponibilidadLabel = new System.Windows.Forms.Label();
            especialidadLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaDoctoresBindingNavigator)).BeginInit();
            this.listaDoctoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDoctoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(282, 273);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(56, 20);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            activoLabel.Click += new System.EventHandler(this.activoLabel_Click);
            // 
            // disponibilidadLabel
            // 
            disponibilidadLabel.AutoSize = true;
            disponibilidadLabel.Location = new System.Drawing.Point(281, 237);
            disponibilidadLabel.Name = "disponibilidadLabel";
            disponibilidadLabel.Size = new System.Drawing.Size(163, 20);
            disponibilidadLabel.TabIndex = 3;
            disponibilidadLabel.Text = "Disponibilidad por dia:";
            disponibilidadLabel.Click += new System.EventHandler(this.disponibilidadLabel_Click);
            // 
            // especialidadLabel
            // 
            especialidadLabel.AutoSize = true;
            especialidadLabel.Location = new System.Drawing.Point(282, 169);
            especialidadLabel.Name = "especialidadLabel";
            especialidadLabel.Size = new System.Drawing.Size(103, 20);
            especialidadLabel.TabIndex = 5;
            especialidadLabel.Text = "Especialidad:";
            especialidadLabel.Click += new System.EventHandler(this.especialidadLabel_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(282, 109);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(282, 144);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(69, 20);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            nombreLabel.Click += new System.EventHandler(this.nombreLabel_Click);
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(282, 204);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(113, 20);
            precioLabel.TabIndex = 11;
            precioLabel.Text = "Precio por cita:";
            precioLabel.Click += new System.EventHandler(this.precioLabel_Click);
            // 
            // listaDoctoresBindingNavigator
            // 
            this.listaDoctoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaDoctoresBindingNavigator.BindingSource = this.listaDoctoresBindingSource;
            this.listaDoctoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaDoctoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaDoctoresBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.listaDoctoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaDoctoresBindingNavigatorSaveItem});
            this.listaDoctoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaDoctoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaDoctoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaDoctoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaDoctoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaDoctoresBindingNavigator.Name = "listaDoctoresBindingNavigator";
            this.listaDoctoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaDoctoresBindingNavigator.Size = new System.Drawing.Size(1078, 31);
            this.listaDoctoresBindingNavigator.TabIndex = 0;
            this.listaDoctoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // listaDoctoresBindingSource
            // 
            this.listaDoctoresBindingSource.DataSource = typeof(BL.CitasMedicas.Doctor);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // listaDoctoresBindingNavigatorSaveItem
            // 
            this.listaDoctoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaDoctoresBindingNavigatorSaveItem.Enabled = false;
            this.listaDoctoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDoctoresBindingNavigatorSaveItem.Image")));
            this.listaDoctoresBindingNavigatorSaveItem.Name = "listaDoctoresBindingNavigatorSaveItem";
            this.listaDoctoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.listaDoctoresBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaDoctoresBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(455, 269);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(419, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            this.activoCheckBox.CheckedChanged += new System.EventHandler(this.activoCheckBox_CheckedChanged);
            // 
            // disponibilidadTextBox
            // 
            this.disponibilidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDoctoresBindingSource, "Disponibilidad", true));
            this.disponibilidadTextBox.Location = new System.Drawing.Point(454, 237);
            this.disponibilidadTextBox.Name = "disponibilidadTextBox";
            this.disponibilidadTextBox.Size = new System.Drawing.Size(419, 26);
            this.disponibilidadTextBox.TabIndex = 4;
            this.disponibilidadTextBox.TextChanged += new System.EventHandler(this.disponibilidadTextBox_TextChanged);
            // 
            // especialidadTextBox
            // 
            this.especialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDoctoresBindingSource, "Especialidad", true));
            this.especialidadTextBox.Location = new System.Drawing.Point(455, 169);
            this.especialidadTextBox.Name = "especialidadTextBox";
            this.especialidadTextBox.Size = new System.Drawing.Size(419, 26);
            this.especialidadTextBox.TabIndex = 6;
            this.especialidadTextBox.TextChanged += new System.EventHandler(this.especialidadTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDoctoresBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(454, 106);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(419, 26);
            this.idTextBox.TabIndex = 8;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDoctoresBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(454, 138);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(419, 26);
            this.nombreTextBox.TabIndex = 10;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDoctoresBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(454, 201);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(419, 26);
            this.precioTextBox.TabIndex = 12;
            this.precioTextBox.TextChanged += new System.EventHandler(this.precioTextBox_TextChanged);
            // 
            // FormDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 402);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(disponibilidadLabel);
            this.Controls.Add(this.disponibilidadTextBox);
            this.Controls.Add(especialidadLabel);
            this.Controls.Add(this.especialidadTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.listaDoctoresBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDoctores";
            this.Text = "Lista de Doctores y Especialidades";
            this.Load += new System.EventHandler(this.FormDoctores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDoctoresBindingNavigator)).EndInit();
            this.listaDoctoresBindingNavigator.ResumeLayout(false);
            this.listaDoctoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDoctoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaDoctoresBindingSource;
        private System.Windows.Forms.BindingNavigator listaDoctoresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaDoctoresBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox disponibilidadTextBox;
        private System.Windows.Forms.TextBox especialidadTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
    }
}