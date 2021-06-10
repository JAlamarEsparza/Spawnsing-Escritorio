
namespace Spawnsing_Escritorio
{
    partial class EliminarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarUsuario));
            this.btnSalirEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.errorProviderEliminar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirEliminar
            // 
            this.btnSalirEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(18)))), ((int)(((byte)(15)))));
            this.btnSalirEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirEliminar.Location = new System.Drawing.Point(1476, 665);
            this.btnSalirEliminar.Name = "btnSalirEliminar";
            this.btnSalirEliminar.Size = new System.Drawing.Size(183, 81);
            this.btnSalirEliminar.TabIndex = 1;
            this.btnSalirEliminar.Text = "Salir";
            this.btnSalirEliminar.UseVisualStyleBackColor = false;
            this.btnSalirEliminar.Click += new System.EventHandler(this.btnSalirEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(519, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eliminación de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(673, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "DNI del usuario :";
            // 
            // txtBoxEliminar
            // 
            this.txtBoxEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEliminar.Location = new System.Drawing.Point(635, 344);
            this.txtBoxEliminar.Name = "txtBoxEliminar";
            this.txtBoxEliminar.Size = new System.Drawing.Size(324, 30);
            this.txtBoxEliminar.TabIndex = 6;
            this.txtBoxEliminar.TextChanged += new System.EventHandler(this.txtBoxEliminar_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnEliminar.Location = new System.Drawing.Point(689, 451);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(227, 99);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar Usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // errorProviderEliminar
            // 
            this.errorProviderEliminar.ContainerControl = this;
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spawnsing_Escritorio.Properties.Resources.backgroundbeta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1671, 758);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBoxEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EliminarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarUsuario";
            this.Load += new System.EventHandler(this.EliminarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider errorProviderEliminar;
    }
}