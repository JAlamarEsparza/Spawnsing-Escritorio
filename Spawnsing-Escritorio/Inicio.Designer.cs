
namespace Spawnsing_Escritorio
{
    partial class Inicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultaUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnCerrarInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(676, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenid@";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Spawnsing_Escritorio.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(653, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(786, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "A";
            // 
            // btnConsultaUsuario
            // 
            this.btnConsultaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnConsultaUsuario.Location = new System.Drawing.Point(117, 553);
            this.btnConsultaUsuario.Name = "btnConsultaUsuario";
            this.btnConsultaUsuario.Size = new System.Drawing.Size(227, 99);
            this.btnConsultaUsuario.TabIndex = 3;
            this.btnConsultaUsuario.Text = "Consulta Usuario";
            this.btnConsultaUsuario.UseVisualStyleBackColor = true;
            this.btnConsultaUsuario.Click += new System.EventHandler(this.btnConsultaUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnAgregarUsuario.Location = new System.Drawing.Point(682, 553);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(228, 99);
            this.btnAgregarUsuario.TabIndex = 4;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(1250, 553);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(227, 99);
            this.btnEliminarUsuario.TabIndex = 5;
            this.btnEliminarUsuario.Text = "Eliminación Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnCerrarInicio
            // 
            this.btnCerrarInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(18)))), ((int)(((byte)(15)))));
            this.btnCerrarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarInicio.Location = new System.Drawing.Point(1619, 0);
            this.btnCerrarInicio.Name = "btnCerrarInicio";
            this.btnCerrarInicio.Size = new System.Drawing.Size(52, 40);
            this.btnCerrarInicio.TabIndex = 6;
            this.btnCerrarInicio.Text = "X";
            this.btnCerrarInicio.UseVisualStyleBackColor = false;
            this.btnCerrarInicio.Click += new System.EventHandler(this.btnCerrarInicio_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spawnsing_Escritorio.Properties.Resources.backgroundbeta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1671, 758);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrarInicio);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.btnConsultaUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spawnsign";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultaUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnCerrarInicio;
    }
}

