namespace Interface
{
    partial class empleado1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.codigo = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.cargo = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.cedula = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.botoneditar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.codigo);
            this.guna2Panel1.Controls.Add(this.estado);
            this.guna2Panel1.Controls.Add(this.cargo);
            this.guna2Panel1.Controls.Add(this.telefono);
            this.guna2Panel1.Controls.Add(this.cedula);
            this.guna2Panel1.Controls.Add(this.apellido);
            this.guna2Panel1.Controls.Add(this.nombre);
            this.guna2Panel1.Controls.Add(this.botoneditar);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(381, 219);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(178, 155);
            this.codigo.Margin = new System.Windows.Forms.Padding(0);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(175, 23);
            this.codigo.TabIndex = 8;
            this.codigo.Text = "WHNF4298RQ";
            this.codigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // estado
            // 
            this.estado.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(178, 132);
            this.estado.Margin = new System.Windows.Forms.Padding(0);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(175, 23);
            this.estado.TabIndex = 7;
            this.estado.Text = "ACTIVO";
            this.estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.estado.Click += new System.EventHandler(this.estado_Click);
            // 
            // cargo
            // 
            this.cargo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.Location = new System.Drawing.Point(178, 109);
            this.cargo.Margin = new System.Windows.Forms.Padding(0);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(203, 23);
            this.cargo.TabIndex = 6;
            this.cargo.Text = "GENTE";
            this.cargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargo.Click += new System.EventHandler(this.label5_Click);
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(178, 86);
            this.telefono.Margin = new System.Windows.Forms.Padding(0);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(175, 23);
            this.telefono.TabIndex = 5;
            this.telefono.Text = "829-708-1345";
            this.telefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.telefono.Click += new System.EventHandler(this.telefono_Click);
            // 
            // cedula
            // 
            this.cedula.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedula.Location = new System.Drawing.Point(178, 63);
            this.cedula.Margin = new System.Windows.Forms.Padding(0);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(175, 23);
            this.cedula.TabIndex = 4;
            this.cedula.Text = "402-3456396-9";
            this.cedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // apellido
            // 
            this.apellido.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(178, 40);
            this.apellido.Margin = new System.Windows.Forms.Padding(0);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(175, 23);
            this.apellido.TabIndex = 3;
            this.apellido.Text = "PEÑA SANCHEZ";
            this.apellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apellido.Click += new System.EventHandler(this.apellido_Click);
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(178, 17);
            this.nombre.Margin = new System.Windows.Forms.Padding(0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(175, 23);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "LUIS ANGEL";
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // botoneditar
            // 
            this.botoneditar.BorderRadius = 16;
            this.botoneditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.botoneditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.botoneditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.botoneditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.botoneditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.botoneditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botoneditar.ForeColor = System.Drawing.Color.White;
            this.botoneditar.Location = new System.Drawing.Point(17, 148);
            this.botoneditar.Name = "botoneditar";
            this.botoneditar.Size = new System.Drawing.Size(125, 48);
            this.botoneditar.TabIndex = 1;
            this.botoneditar.Text = "EDITAR";
            this.botoneditar.Click += new System.EventHandler(this.botoneditar_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Interface.Properties.Resources.Captura_de_pantalla_2025_12_26_180040;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(17, 17);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(125, 125);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // empleado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.MaximumSize = new System.Drawing.Size(381, 219);
            this.MinimumSize = new System.Drawing.Size(381, 219);
            this.Name = "empleado1";
            this.Size = new System.Drawing.Size(381, 219);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button botoneditar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label cargo;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label cedula;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label codigo;
    }
}
