
namespace CapaVistaActivosFijos
{
    partial class mantenimientoTipoactivo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomta = new System.Windows.Forms.TextBox();
            this.dgvta = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpdd = new System.Windows.Forms.TextBox();
            this.navegador1 = new DLL.nav.navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvta)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del tipo de activo";
            // 
            // txtnomta
            // 
            this.txtnomta.Location = new System.Drawing.Point(347, 251);
            this.txtnomta.Name = "txtnomta";
            this.txtnomta.Size = new System.Drawing.Size(167, 22);
            this.txtnomta.TabIndex = 2;
            this.txtnomta.Tag = "nombreTipoactivo";
            // 
            // dgvta
            // 
            this.dgvta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvta.Location = new System.Drawing.Point(684, 145);
            this.dgvta.Name = "dgvta";
            this.dgvta.RowHeadersWidth = 51;
            this.dgvta.RowTemplate.Height = 24;
            this.dgvta.Size = new System.Drawing.Size(800, 384);
            this.dgvta.TabIndex = 4;
            this.dgvta.SelectionChanged += new System.EventHandler(this.dgvImpuesto_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porcentaje de depreciación";
            // 
            // txtpdd
            // 
            this.txtpdd.Location = new System.Drawing.Point(347, 298);
            this.txtpdd.Name = "txtpdd";
            this.txtpdd.Size = new System.Drawing.Size(167, 22);
            this.txtpdd.TabIndex = 6;
            this.txtpdd.Tag = "tasaDepreciacion";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1585, 107);
            this.navegador1.TabIndex = 7;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID tipo de activo";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(347, 200);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(167, 22);
            this.txtid.TabIndex = 9;
            this.txtid.Tag = "idTipoactivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado";
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.BackColor = System.Drawing.Color.Transparent;
            this.rdbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbActivo.Location = new System.Drawing.Point(186, 417);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(87, 29);
            this.rdbActivo.TabIndex = 11;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = false;
            this.rdbActivo.CheckedChanged += new System.EventHandler(this.rdbActivo_CheckedChanged);
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.BackColor = System.Drawing.Color.Transparent;
            this.rdbInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInactivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbInactivo.Location = new System.Drawing.Point(320, 417);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(100, 29);
            this.rdbInactivo.TabIndex = 12;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = false;
            this.rdbInactivo.CheckedChanged += new System.EventHandler(this.rdbInactivo_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(320, 470);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(24, 22);
            this.txtEstado.TabIndex = 13;
            this.txtEstado.Tag = "estado";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // mantenimientoTipoactivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaActivosFijos.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1587, 566);
            this.Controls.Add(this.rdbInactivo);
            this.Controls.Add(this.rdbActivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtpdd);
            this.Controls.Add(this.txtnomta);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dgvta);
            this.Controls.Add(this.navegador1);
            this.Name = "mantenimientoTipoactivo";
            this.Text = "7403 Mantenimiento Tipo Activo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomta;
        private System.Windows.Forms.DataGridView dgvta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpdd;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.TextBox txtEstado;
    }
}