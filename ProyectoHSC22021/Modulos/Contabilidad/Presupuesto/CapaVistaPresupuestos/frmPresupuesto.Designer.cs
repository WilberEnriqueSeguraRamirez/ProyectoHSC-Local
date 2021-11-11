
namespace CapaVistaPresupuestos
{
    partial class frmPresupuesto
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
            this.txtmes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgastos = new System.Windows.Forms.TextBox();
            this.txtingresos = new System.Windows.Forms.TextBox();
            this.txtnompresupuesto = new System.Windows.Forms.TextBox();
            this.txtidpresupuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgPresupuesto = new System.Windows.Forms.DataGridView();
            this.navegador1 = new DLL.nav.navegador();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPresupuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(294, 252);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(153, 20);
            this.txtmes.TabIndex = 39;
            this.txtmes.Tag = "mesPresupuesto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Mes:";
            // 
            // txtanio
            // 
            this.txtanio.Location = new System.Drawing.Point(295, 206);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(153, 20);
            this.txtanio.TabIndex = 37;
            this.txtanio.Tag = "anioPresupuesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Año:";
            // 
            // txtgastos
            // 
            this.txtgastos.Location = new System.Drawing.Point(293, 349);
            this.txtgastos.Name = "txtgastos";
            this.txtgastos.Size = new System.Drawing.Size(153, 20);
            this.txtgastos.TabIndex = 35;
            this.txtgastos.Tag = "gastoPresupuesto";
            // 
            // txtingresos
            // 
            this.txtingresos.Location = new System.Drawing.Point(294, 300);
            this.txtingresos.Name = "txtingresos";
            this.txtingresos.Size = new System.Drawing.Size(153, 20);
            this.txtingresos.TabIndex = 34;
            this.txtingresos.Tag = "ingresoPresupuesto";
            // 
            // txtnompresupuesto
            // 
            this.txtnompresupuesto.Location = new System.Drawing.Point(295, 157);
            this.txtnompresupuesto.Name = "txtnompresupuesto";
            this.txtnompresupuesto.Size = new System.Drawing.Size(153, 20);
            this.txtnompresupuesto.TabIndex = 33;
            this.txtnompresupuesto.Tag = "nomPresupuesto";
            // 
            // txtidpresupuesto
            // 
            this.txtidpresupuesto.Location = new System.Drawing.Point(295, 110);
            this.txtidpresupuesto.Name = "txtidpresupuesto";
            this.txtidpresupuesto.Size = new System.Drawing.Size(153, 20);
            this.txtidpresupuesto.TabIndex = 32;
            this.txtidpresupuesto.Tag = "idPresupuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Gastos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ingresos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID Presupuesto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre del Presupuesto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 27;
            // 
            // dvgPresupuesto
            // 
            this.dvgPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPresupuesto.Location = new System.Drawing.Point(492, 110);
            this.dvgPresupuesto.Name = "dvgPresupuesto";
            this.dvgPresupuesto.Size = new System.Drawing.Size(672, 417);
            this.dvgPresupuesto.TabIndex = 26;
            this.dvgPresupuesto.SelectionChanged += new System.EventHandler(this.dgvImpuesto_SelectionChanged);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Estado:";
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.BackColor = System.Drawing.Color.Transparent;
            this.rdbActivo.Location = new System.Drawing.Point(145, 510);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(55, 17);
            this.rdbActivo.TabIndex = 42;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = false;
            this.rdbActivo.CheckedChanged += new System.EventHandler(this.rdbActivo_CheckedChanged);
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.BackColor = System.Drawing.Color.Transparent;
            this.rdbInactivo.Location = new System.Drawing.Point(267, 510);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rdbInactivo.TabIndex = 43;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = false;
            this.rdbInactivo.CheckedChanged += new System.EventHandler(this.rdbInactivo_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(369, 507);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(24, 20);
            this.txtEstado.TabIndex = 44;
            this.txtEstado.Tag = "estadoPresupuesto";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Total Presupuesto:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(293, 397);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(153, 20);
            this.txtTotal.TabIndex = 46;
            this.txtTotal.Tag = "totalPresupuesto";
            // 
            // frmPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaPresupuestos.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1187, 554);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rdbInactivo);
            this.Controls.Add(this.rdbActivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtgastos);
            this.Controls.Add(this.txtingresos);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.txtanio);
            this.Controls.Add(this.txtnompresupuesto);
            this.Controls.Add(this.txtidpresupuesto);
            this.Controls.Add(this.dvgPresupuesto);
            this.Controls.Add(this.navegador1);
            this.Name = "frmPresupuesto";
            this.Text = "7301 Mantenimiento Presupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPresupuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtanio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgastos;
        private System.Windows.Forms.TextBox txtingresos;
        private System.Windows.Forms.TextBox txtnompresupuesto;
        private System.Windows.Forms.TextBox txtidpresupuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgPresupuesto;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal;
    }
}