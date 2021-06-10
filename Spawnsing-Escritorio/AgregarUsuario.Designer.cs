
namespace Spawnsing_Escritorio
{
    partial class AgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            this.btnSalirAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxIdentificador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.txtBoxEntrada = new System.Windows.Forms.TextBox();
            this.txtBoxSalida = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.errorProviderIdentificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEntrada = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSalida = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnComprobar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdentificador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirAgregar
            // 
            this.btnSalirAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(18)))), ((int)(((byte)(15)))));
            this.btnSalirAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAgregar.Location = new System.Drawing.Point(1476, 665);
            this.btnSalirAgregar.Name = "btnSalirAgregar";
            this.btnSalirAgregar.Size = new System.Drawing.Size(183, 81);
            this.btnSalirAgregar.TabIndex = 1;
            this.btnSalirAgregar.Text = "Salir";
            this.btnSalirAgregar.UseVisualStyleBackColor = false;
            this.btnSalirAgregar.Click += new System.EventHandler(this.btnSalirAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(519, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregación de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(492, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identificador :";
            // 
            // txtBoxIdentificador
            // 
            this.txtBoxIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIdentificador.Location = new System.Drawing.Point(755, 241);
            this.txtBoxIdentificador.Name = "txtBoxIdentificador";
            this.txtBoxIdentificador.Size = new System.Drawing.Size(324, 26);
            this.txtBoxIdentificador.TabIndex = 5;
            this.txtBoxIdentificador.TextChanged += new System.EventHandler(this.txtBoxIdentificador_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(492, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora de Salida :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(492, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "DNI :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(492, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hora de Entrada :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(492, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(492, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Apellido :";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombre.Location = new System.Drawing.Point(755, 288);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(324, 26);
            this.txtBoxNombre.TabIndex = 11;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.txtBoxNombre_TextChanged);
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxApellido.Location = new System.Drawing.Point(755, 333);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(324, 26);
            this.txtBoxApellido.TabIndex = 12;
            this.txtBoxApellido.TextChanged += new System.EventHandler(this.txtBoxApellido_TextChanged);
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDNI.Location = new System.Drawing.Point(755, 376);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(324, 26);
            this.txtBoxDNI.TabIndex = 13;
            this.txtBoxDNI.TextChanged += new System.EventHandler(this.txtBoxDNI_TextChanged);
            // 
            // txtBoxEntrada
            // 
            this.txtBoxEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEntrada.Location = new System.Drawing.Point(755, 420);
            this.txtBoxEntrada.Name = "txtBoxEntrada";
            this.txtBoxEntrada.Size = new System.Drawing.Size(324, 26);
            this.txtBoxEntrada.TabIndex = 14;
            this.txtBoxEntrada.TextChanged += new System.EventHandler(this.txtBoxEntrada_TextChanged);
            // 
            // txtBoxSalida
            // 
            this.txtBoxSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSalida.Location = new System.Drawing.Point(755, 465);
            this.txtBoxSalida.Name = "txtBoxSalida";
            this.txtBoxSalida.Size = new System.Drawing.Size(324, 26);
            this.txtBoxSalida.TabIndex = 15;
            this.txtBoxSalida.TextChanged += new System.EventHandler(this.txtBoxSalida_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnAgregar.Location = new System.Drawing.Point(852, 559);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(227, 99);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar Usuario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // errorProviderIdentificador
            // 
            this.errorProviderIdentificador.ContainerControl = this;
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // errorProviderApellido
            // 
            this.errorProviderApellido.ContainerControl = this;
            // 
            // errorProviderDNI
            // 
            this.errorProviderDNI.ContainerControl = this;
            // 
            // errorProviderEntrada
            // 
            this.errorProviderEntrada.ContainerControl = this;
            // 
            // errorProviderSalida
            // 
            this.errorProviderSalida.ContainerControl = this;
            // 
            // btnComprobar
            // 
            this.btnComprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnComprobar.Location = new System.Drawing.Point(497, 559);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(227, 99);
            this.btnComprobar.TabIndex = 17;
            this.btnComprobar.Text = "Comprobación";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spawnsing_Escritorio.Properties.Resources.backgroundbeta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1671, 758);
            this.ControlBox = false;
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBoxSalida);
            this.Controls.Add(this.txtBoxEntrada);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxIdentificador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdentificador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxIdentificador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.TextBox txtBoxEntrada;
        private System.Windows.Forms.TextBox txtBoxSalida;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ErrorProvider errorProviderIdentificador;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderApellido;
        private System.Windows.Forms.ErrorProvider errorProviderDNI;
        private System.Windows.Forms.ErrorProvider errorProviderEntrada;
        private System.Windows.Forms.ErrorProvider errorProviderSalida;
        private System.Windows.Forms.Button btnComprobar;
    }
}