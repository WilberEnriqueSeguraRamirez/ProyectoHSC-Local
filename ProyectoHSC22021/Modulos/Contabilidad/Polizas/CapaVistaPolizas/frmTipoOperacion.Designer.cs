
namespace CapaVistaPolizas
{
    partial class frmTipoOperacion
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
            this.btnIngresarTipoOperacion = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTipoOperacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgOperacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOperacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarTipoOperacion
            // 
            this.btnIngresarTipoOperacion.Location = new System.Drawing.Point(104, 120);
            this.btnIngresarTipoOperacion.Name = "btnIngresarTipoOperacion";
            this.btnIngresarTipoOperacion.Size = new System.Drawing.Size(124, 34);
            this.btnIngresarTipoOperacion.TabIndex = 22;
            this.btnIngresarTipoOperacion.Text = "Ingresar";
            this.btnIngresarTipoOperacion.UseVisualStyleBackColor = true;
            this.btnIngresarTipoOperacion.Click += new System.EventHandler(this.btnIngresarTipoOperacion_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 21;
            // 
            // txtTipoOperacion
            // 
            this.txtTipoOperacion.Location = new System.Drawing.Point(90, 26);
            this.txtTipoOperacion.Name = "txtTipoOperacion";
            this.txtTipoOperacion.Size = new System.Drawing.Size(150, 20);
            this.txtTipoOperacion.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID:";
            // 
            // dvgOperacion
            // 
            this.dvgOperacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOperacion.Location = new System.Drawing.Point(290, 12);
            this.dvgOperacion.Name = "dvgOperacion";
            this.dvgOperacion.Size = new System.Drawing.Size(586, 170);
            this.dvgOperacion.TabIndex = 23;
            // 
            // frmTipoOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaPolizas.Properties.Resources._3df38d07_8b18_4ed4_a423_5c4f23c7f07a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 204);
            this.Controls.Add(this.dvgOperacion);
            this.Controls.Add(this.btnIngresarTipoOperacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTipoOperacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoOperacion";
            this.Text = "7105-TipoOperacion";
            ((System.ComponentModel.ISupportInitialize)(this.dvgOperacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarTipoOperacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTipoOperacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgOperacion;
    }
}