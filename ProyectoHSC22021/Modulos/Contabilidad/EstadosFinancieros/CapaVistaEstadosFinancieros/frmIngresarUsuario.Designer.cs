
namespace CapaVistaEstadosFinancieros
{
    partial class frmIngresarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresarUsuario));
            this.boton2 = new System.Windows.Forms.Button();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.Credito = new System.Windows.Forms.TextBox();
            this.Actividad = new System.Windows.Forms.TextBox();
            this.IDActividad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BDActividades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Debito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BDActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(677, 190);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(286, 53);
            this.boton2.TabIndex = 32;
            this.boton2.Text = "Modificar";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(144, 190);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(286, 53);
            this.botonIngresar.TabIndex = 31;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // Credito
            // 
            this.Credito.Location = new System.Drawing.Point(551, 86);
            this.Credito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Credito.Name = "Credito";
            this.Credito.Size = new System.Drawing.Size(226, 22);
            this.Credito.TabIndex = 30;
            // 
            // Actividad
            // 
            this.Actividad.Location = new System.Drawing.Point(229, 83);
            this.Actividad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Actividad.Name = "Actividad";
            this.Actividad.Size = new System.Drawing.Size(226, 22);
            this.Actividad.TabIndex = 29;
            // 
            // IDActividad
            // 
            this.IDActividad.Location = new System.Drawing.Point(39, 80);
            this.IDActividad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDActividad.Name = "IDActividad";
            this.IDActividad.Size = new System.Drawing.Size(87, 22);
            this.IDActividad.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(482, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Crédito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(158, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Actividad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BDActividades
            // 
            this.BDActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BDActividades.Location = new System.Drawing.Point(125, 280);
            this.BDActividades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BDActividades.Name = "BDActividades";
            this.BDActividades.RowHeadersWidth = 51;
            this.BDActividades.RowTemplate.Height = 24;
            this.BDActividades.Size = new System.Drawing.Size(860, 288);
            this.BDActividades.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "Estados Financieros";
            // 
            // Debito
            // 
            this.Debito.Location = new System.Drawing.Point(868, 86);
            this.Debito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Debito.Name = "Debito";
            this.Debito.Size = new System.Drawing.Size(226, 22);
            this.Debito.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(799, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Débito";
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(436, 147);
            this.Fecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(226, 22);
            this.Fecha.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(365, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fecha";
            // 
            // frmIngresarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1134, 605);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Debito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.Credito);
            this.Controls.Add(this.Actividad);
            this.Controls.Add(this.IDActividad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BDActividades);
            this.Controls.Add(this.label1);
            this.Name = "frmIngresarUsuario";
            this.Text = "7501 - Ingresar Actividad";
            this.Load += new System.EventHandler(this.frmIngresarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BDActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.TextBox Credito;
        private System.Windows.Forms.TextBox Actividad;
        private System.Windows.Forms.TextBox IDActividad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView BDActividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Debito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.Label label6;
    }
}