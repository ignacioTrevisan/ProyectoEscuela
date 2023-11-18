namespace ProyectoEscuela
{
    partial class RegistrarNota
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
            this.btnConfirmarMateria = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarMateria
            // 
            this.btnConfirmarMateria.Location = new System.Drawing.Point(243, 49);
            this.btnConfirmarMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarMateria.Name = "btnConfirmarMateria";
            this.btnConfirmarMateria.Size = new System.Drawing.Size(56, 19);
            this.btnConfirmarMateria.TabIndex = 3;
            this.btnConfirmarMateria.Text = "Confirmar";
            this.btnConfirmarMateria.UseVisualStyleBackColor = true;
            this.btnConfirmarMateria.Click += new System.EventHandler(this.btnConfirmarMateria_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(665, 50);
            this.txtNota.Margin = new System.Windows.Forms.Padding(2);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(61, 20);
            this.txtNota.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingrese nueva nota";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(741, 54);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(56, 19);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materiaDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.calificacionDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 220);
            this.dataGridView1.TabIndex = 10;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(EntidadNota.Nota);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(342, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // materiaDataGridViewTextBoxColumn
            // 
            this.materiaDataGridViewTextBoxColumn.DataPropertyName = "Materia";
            this.materiaDataGridViewTextBoxColumn.HeaderText = "Materia";
            this.materiaDataGridViewTextBoxColumn.Name = "materiaDataGridViewTextBoxColumn";
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Division";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // calificacionDataGridViewTextBoxColumn
            // 
            this.calificacionDataGridViewTextBoxColumn.DataPropertyName = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn.HeaderText = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn.Name = "calificacionDataGridViewTextBoxColumn";
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            // 
            // RegistrarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 360);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConfirmarMateria);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrarNota";
            this.Text = "RegistrarNota";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmarMateria;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
    }
}