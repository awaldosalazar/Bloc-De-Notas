namespace Bloc_Notas
{
    partial class Form1
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
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.labelArchivo = new System.Windows.Forms.Label();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonGuardarComo = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.labelBloc = new System.Windows.Forms.Label();
            this.labelBusqueda = new System.Windows.Forms.Label();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.checkBoxMayusculas = new System.Windows.Forms.CheckBox();
            this.buttonBusqueda = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.labelArchivoAbierto = new System.Windows.Forms.Label();
            this.pictureBoxEstado = new System.Windows.Forms.PictureBox();
            this.labelCantidadPalabras = new System.Windows.Forms.Label();
            this.textBoxCoincidiente = new System.Windows.Forms.TextBox();
            this.textBoxPosicion = new System.Windows.Forms.TextBox();
            this.labelPalabraEncontrada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPalabraActual = new System.Windows.Forms.Label();
            this.richTextBoxTexto = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Location = new System.Drawing.Point(26, 91);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(94, 23);
            this.buttonAbrir.TabIndex = 0;
            this.buttonAbrir.Text = "Abrir";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // labelArchivo
            // 
            this.labelArchivo.AutoSize = true;
            this.labelArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArchivo.Location = new System.Drawing.Point(26, 43);
            this.labelArchivo.Name = "labelArchivo";
            this.labelArchivo.Size = new System.Drawing.Size(100, 13);
            this.labelArchivo.TabIndex = 1;
            this.labelArchivo.Text = "Archivo de texto";
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(26, 62);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(94, 23);
            this.buttonNuevo.TabIndex = 2;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(26, 120);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(94, 23);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonGuardarComo
            // 
            this.buttonGuardarComo.Location = new System.Drawing.Point(26, 149);
            this.buttonGuardarComo.Name = "buttonGuardarComo";
            this.buttonGuardarComo.Size = new System.Drawing.Size(94, 23);
            this.buttonGuardarComo.TabIndex = 4;
            this.buttonGuardarComo.Text = "Guardar Como";
            this.buttonGuardarComo.UseVisualStyleBackColor = true;
            this.buttonGuardarComo.Click += new System.EventHandler(this.buttonGuardarComo_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(26, 178);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(94, 23);
            this.buttonCerrar.TabIndex = 5;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // labelBloc
            // 
            this.labelBloc.AutoSize = true;
            this.labelBloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloc.Location = new System.Drawing.Point(290, 2);
            this.labelBloc.Name = "labelBloc";
            this.labelBloc.Size = new System.Drawing.Size(371, 39);
            this.labelBloc.TabIndex = 7;
            this.labelBloc.Text = "ARCHIVO DE TEXTO";
            // 
            // labelBusqueda
            // 
            this.labelBusqueda.AutoSize = true;
            this.labelBusqueda.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusqueda.Location = new System.Drawing.Point(23, 263);
            this.labelBusqueda.Name = "labelBusqueda";
            this.labelBusqueda.Size = new System.Drawing.Size(71, 15);
            this.labelBusqueda.TabIndex = 8;
            this.labelBusqueda.Text = "Busqueda";
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxBusqueda.Location = new System.Drawing.Point(100, 261);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(152, 20);
            this.textBoxBusqueda.TabIndex = 9;
            this.textBoxBusqueda.Text = "Buscar en el texto";
            this.textBoxBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBusqueda.Enter += new System.EventHandler(this.textBoxBusqueda_Enter);
            // 
            // checkBoxMayusculas
            // 
            this.checkBoxMayusculas.AutoSize = true;
            this.checkBoxMayusculas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBoxMayusculas.Location = new System.Drawing.Point(100, 287);
            this.checkBoxMayusculas.Name = "checkBoxMayusculas";
            this.checkBoxMayusculas.Size = new System.Drawing.Size(82, 17);
            this.checkBoxMayusculas.TabIndex = 10;
            this.checkBoxMayusculas.Text = "Mayusculas";
            this.checkBoxMayusculas.UseVisualStyleBackColor = false;
            // 
            // buttonBusqueda
            // 
            this.buttonBusqueda.Location = new System.Drawing.Point(83, 310);
            this.buttonBusqueda.Name = "buttonBusqueda";
            this.buttonBusqueda.Size = new System.Drawing.Size(75, 23);
            this.buttonBusqueda.TabIndex = 11;
            this.buttonBusqueda.Text = "BUSCAR";
            this.buttonBusqueda.UseVisualStyleBackColor = true;
            this.buttonBusqueda.Click += new System.EventHandler(this.buttonBusqueda_Click);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(177, 310);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.buttonSiguiente.TabIndex = 12;
            this.buttonSiguiente.Text = "SIGUIENTE";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // labelArchivoAbierto
            // 
            this.labelArchivoAbierto.AutoSize = true;
            this.labelArchivoAbierto.Location = new System.Drawing.Point(337, 204);
            this.labelArchivoAbierto.Name = "labelArchivoAbierto";
            this.labelArchivoAbierto.Size = new System.Drawing.Size(108, 13);
            this.labelArchivoAbierto.TabIndex = 13;
            this.labelArchivoAbierto.Text = "En espera de archivo";
            // 
            // pictureBoxEstado
            // 
            this.pictureBoxEstado.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBoxEstado.Location = new System.Drawing.Point(451, 204);
            this.pictureBoxEstado.Name = "pictureBoxEstado";
            this.pictureBoxEstado.Size = new System.Drawing.Size(19, 22);
            this.pictureBoxEstado.TabIndex = 14;
            this.pictureBoxEstado.TabStop = false;
            // 
            // labelCantidadPalabras
            // 
            this.labelCantidadPalabras.AutoSize = true;
            this.labelCantidadPalabras.Location = new System.Drawing.Point(476, 261);
            this.labelCantidadPalabras.Name = "labelCantidadPalabras";
            this.labelCantidadPalabras.Size = new System.Drawing.Size(116, 13);
            this.labelCantidadPalabras.TabIndex = 15;
            this.labelCantidadPalabras.Text = "Palabras encontradas: ";
            // 
            // textBoxCoincidiente
            // 
            this.textBoxCoincidiente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCoincidiente.Location = new System.Drawing.Point(297, 258);
            this.textBoxCoincidiente.Name = "textBoxCoincidiente";
            this.textBoxCoincidiente.Size = new System.Drawing.Size(116, 20);
            this.textBoxCoincidiente.TabIndex = 16;
            this.textBoxCoincidiente.Text = "Palabras coincidientes";
            // 
            // textBoxPosicion
            // 
            this.textBoxPosicion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPosicion.Location = new System.Drawing.Point(419, 258);
            this.textBoxPosicion.Name = "textBoxPosicion";
            this.textBoxPosicion.Size = new System.Drawing.Size(51, 20);
            this.textBoxPosicion.TabIndex = 17;
            this.textBoxPosicion.Text = "Posicion";
            // 
            // labelPalabraEncontrada
            // 
            this.labelPalabraEncontrada.AutoSize = true;
            this.labelPalabraEncontrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalabraEncontrada.Location = new System.Drawing.Point(295, 242);
            this.labelPalabraEncontrada.Name = "labelPalabraEncontrada";
            this.labelPalabraEncontrada.Size = new System.Drawing.Size(119, 13);
            this.labelPalabraEncontrada.TabIndex = 18;
            this.labelPalabraEncontrada.Text = "Palabra Encontrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Posicion del comienzo de la palabra";
            // 
            // labelPalabraActual
            // 
            this.labelPalabraActual.AutoSize = true;
            this.labelPalabraActual.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalabraActual.Location = new System.Drawing.Point(294, 282);
            this.labelPalabraActual.Name = "labelPalabraActual";
            this.labelPalabraActual.Size = new System.Drawing.Size(169, 22);
            this.labelPalabraActual.TabIndex = 20;
            this.labelPalabraActual.Text = "Palabra : - de -";
            // 
            // richTextBoxTexto
            // 
            this.richTextBoxTexto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBoxTexto.Location = new System.Drawing.Point(172, 44);
            this.richTextBoxTexto.Name = "richTextBoxTexto";
            this.richTextBoxTexto.Size = new System.Drawing.Size(632, 157);
            this.richTextBoxTexto.TabIndex = 21;
            this.richTextBoxTexto.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(808, 339);
            this.Controls.Add(this.richTextBoxTexto);
            this.Controls.Add(this.labelPalabraActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPalabraEncontrada);
            this.Controls.Add(this.textBoxPosicion);
            this.Controls.Add(this.textBoxCoincidiente);
            this.Controls.Add(this.labelCantidadPalabras);
            this.Controls.Add(this.pictureBoxEstado);
            this.Controls.Add(this.labelArchivoAbierto);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.buttonBusqueda);
            this.Controls.Add(this.checkBoxMayusculas);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.labelBusqueda);
            this.Controls.Add(this.labelBloc);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardarComo);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.labelArchivo);
            this.Controls.Add(this.buttonAbrir);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.Label labelArchivo;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonGuardarComo;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label labelBloc;
        private System.Windows.Forms.Label labelBusqueda;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.CheckBox checkBoxMayusculas;
        private System.Windows.Forms.Button buttonBusqueda;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Label labelArchivoAbierto;
        private System.Windows.Forms.PictureBox pictureBoxEstado;
        private System.Windows.Forms.Label labelCantidadPalabras;
        private System.Windows.Forms.TextBox textBoxCoincidiente;
        private System.Windows.Forms.TextBox textBoxPosicion;
        private System.Windows.Forms.Label labelPalabraEncontrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPalabraActual;
        private System.Windows.Forms.RichTextBox richTextBoxTexto;
    }
}

