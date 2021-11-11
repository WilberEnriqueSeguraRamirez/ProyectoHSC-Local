
namespace CapaVistaActivosFijos
{
    partial class mantenimientoActivo
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
            this.cmbtipoact = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnomactivo = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dgvactivo = new System.Windows.Forms.DataGridView();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txttipoact = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvactivo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbtipoact
            // 
            this.cmbtipoact.FormattingEnabled = true;
            this.cmbtipoact.Location = new System.Drawing.Point(247, 291);
            this.cmbtipoact.Name = "cmbtipoact";
            this.cmbtipoact.Size = new System.Drawing.Size(120, 24);
            this.cmbtipoact.TabIndex = 2;
            this.cmbtipoact.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCuenta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Activo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tipo Activo";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1585, 107);
            this.navegador1.TabIndex = 9;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(247, 185);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(120, 22);
            this.txtid.TabIndex = 10;
            this.txtid.Tag = "idActivo";
            // 
            // txtnomactivo
            // 
            this.txtnomactivo.Location = new System.Drawing.Point(247, 240);
            this.txtnomactivo.Name = "txtnomactivo";
            this.txtnomactivo.Size = new System.Drawing.Size(120, 22);
            this.txtnomactivo.TabIndex = 11;
            this.txtnomactivo.Tag = "nombreActivo";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(247, 342);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(120, 22);
            this.txtmarca.TabIndex = 12;
            this.txtmarca.Tag = "marca";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(247, 395);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(120, 22);
            this.txtmodelo.TabIndex = 13;
            this.txtmodelo.Tag = "modelo";
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.BackColor = System.Drawing.Color.Transparent;
            this.rdbInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInactivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbInactivo.Location = new System.Drawing.Point(332, 566);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(100, 29);
            this.rdbInactivo.TabIndex = 17;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = false;
            this.rdbInactivo.CheckedChanged += new System.EventHandler(this.rdbInactivo_CheckedChanged);
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.BackColor = System.Drawing.Color.Transparent;
            this.rdbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbActivo.Location = new System.Drawing.Point(198, 566);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(87, 29);
            this.rdbActivo.TabIndex = 16;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = false;
            this.rdbActivo.CheckedChanged += new System.EventHandler(this.rdbActivo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(332, 619);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(24, 22);
            this.txtEstado.TabIndex = 18;
            this.txtEstado.Tag = "estado";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // dgvactivo
            // 
            this.dgvactivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvactivo.Location = new System.Drawing.Point(574, 185);
            this.dgvactivo.Name = "dgvactivo";
            this.dgvactivo.RowHeadersWidth = 51;
            this.dgvactivo.RowTemplate.Height = 24;
            this.dgvactivo.Size = new System.Drawing.Size(956, 437);
            this.dgvactivo.TabIndex = 19;
            this.dgvactivo.SelectionChanged += new System.EventHandler(this.dgvImpuesto_SelectionChanged);
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(247, 455);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(120, 22);
            this.txtdesc.TabIndex = 20;
            this.txtdesc.Tag = "descripcion";
            // 
            // txttipoact
            // 
            this.txttipoact.Location = new System.Drawing.Point(382, 291);
            this.txttipoact.Name = "txttipoact";
            this.txttipoact.Size = new System.Drawing.Size(120, 22);
            this.txttipoact.TabIndex = 21;
            this.txttipoact.Tag = "fkidTipoactivo";
            this.txttipoact.TextChanged += new System.EventHandler(this.txtTipoCuenta_TextChanged);
            // 
            // mantenimientoActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaActivosFijos.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1572, 680);
            this.Controls.Add(this.dgvactivo);
            this.Controls.Add(this.rdbInactivo);
            this.Controls.Add(this.rdbActivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbtipoact);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txttipoact);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtnomactivo);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.navegador1);
            this.Name = "mantenimientoActivo";
            this.Text = "7404 Mantenimiento Activos Fijos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvactivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbtipoact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnomactivo;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridView dgvactivo;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txttipoact;
    }
}