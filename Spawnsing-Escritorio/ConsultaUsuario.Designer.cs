
namespace Spawnsing_Escritorio
{
    partial class ConsultaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaUsuario));
            this.btnSalirConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProviderDNI = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirConsulta
            // 
            this.btnSalirConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(18)))), ((int)(((byte)(15)))));
            this.btnSalirConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirConsulta.Location = new System.Drawing.Point(1480, 669);
            this.btnSalirConsulta.Name = "btnSalirConsulta";
            this.btnSalirConsulta.Size = new System.Drawing.Size(183, 81);
            this.btnSalirConsulta.TabIndex = 0;
            this.btnSalirConsulta.Text = "Salir";
            this.btnSalirConsulta.UseVisualStyleBackColor = false;
            this.btnSalirConsulta.Click += new System.EventHandler(this.btnSalirConsulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(504, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta sobre Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(159, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI de usuario :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(758, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(885, 411);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Identificador";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DNI";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "HoraEntrada";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "HoraSalida";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 140;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsuario.Location = new System.Drawing.Point(117, 494);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(324, 30);
            this.txtBoxUsuario.TabIndex = 4;
            this.txtBoxUsuario.TextChanged += new System.EventHandler(this.txtBoxUsuario_TextChanged);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnUsuario.Location = new System.Drawing.Point(164, 570);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(227, 99);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "Consultar Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnTodos.Location = new System.Drawing.Point(164, 235);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(227, 99);
            this.btnTodos.TabIndex = 8;
            this.btnTodos.Text = "Consultar todos los usuario";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mostrar todos los usuarios :";
            // 
            // errorProviderDNI
            // 
            this.errorProviderDNI.ContainerControl = this;
            // 
            // ConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spawnsing_Escritorio.Properties.Resources.backgroundbeta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1675, 762);
            this.ControlBox = false;
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaUsuario";
            this.Load += new System.EventHandler(this.ConsultaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ErrorProvider errorProviderDNI;
    }
}