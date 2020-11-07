namespace ProyectoFinal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Area1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lineaActual = new System.Windows.Forms.TextBox();
            this.Analisis = new System.Windows.Forms.Button();
            this.Copilar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fila = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.copilado = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Area1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // Area1
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.Area1, this.autocompleteMenu1);
            this.Area1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Area1.Location = new System.Drawing.Point(0, 24);
            this.Area1.Name = "Area1";
            this.Area1.Size = new System.Drawing.Size(800, 242);
            this.Area1.TabIndex = 1;
            this.Area1.Text = "";
            this.Area1.TextChanged += new System.EventHandler(this.Area1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearArchivoToolStripMenuItem,
            this.abrirArchivoToolStripMenuItem,
            this.editarArchivoToolStripMenuItem,
            this.eliminarArchivoToolStripMenuItem,
            this.cerrarArchivoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // crearArchivoToolStripMenuItem
            // 
            this.crearArchivoToolStripMenuItem.Name = "crearArchivoToolStripMenuItem";
            this.crearArchivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearArchivoToolStripMenuItem.Text = "Crear Archivo";
            this.crearArchivoToolStripMenuItem.Click += new System.EventHandler(this.crearArchivoToolStripMenuItem_Click);
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir Archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // editarArchivoToolStripMenuItem
            // 
            this.editarArchivoToolStripMenuItem.Name = "editarArchivoToolStripMenuItem";
            this.editarArchivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarArchivoToolStripMenuItem.Text = "Editar Archivo";
            // 
            // eliminarArchivoToolStripMenuItem
            // 
            this.eliminarArchivoToolStripMenuItem.Name = "eliminarArchivoToolStripMenuItem";
            this.eliminarArchivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarArchivoToolStripMenuItem.Text = "Eliminar Archivo";
            // 
            // cerrarArchivoToolStripMenuItem
            // 
            this.cerrarArchivoToolStripMenuItem.Name = "cerrarArchivoToolStripMenuItem";
            this.cerrarArchivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarArchivoToolStripMenuItem.Text = "Cerrar Archivo";
            this.cerrarArchivoToolStripMenuItem.Click += new System.EventHandler(this.cerrarArchivoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer2.Panel1.Controls.Add(this.lineaActual);
            this.splitContainer2.Panel1.Controls.Add(this.Analisis);
            this.splitContainer2.Panel1.Controls.Add(this.Copilar);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.fila);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer2.Panel2.Controls.Add(this.copilado);
            this.splitContainer2.Size = new System.Drawing.Size(800, 180);
            this.splitContainer2.SplitterDistance = 29;
            this.splitContainer2.TabIndex = 0;
            // 
            // lineaActual
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.lineaActual, null);
            this.lineaActual.Location = new System.Drawing.Point(326, 4);
            this.lineaActual.Name = "lineaActual";
            this.lineaActual.Size = new System.Drawing.Size(444, 20);
            this.lineaActual.TabIndex = 6;
            // 
            // Analisis
            // 
            this.Analisis.Location = new System.Drawing.Point(245, 4);
            this.Analisis.Name = "Analisis";
            this.Analisis.Size = new System.Drawing.Size(75, 23);
            this.Analisis.TabIndex = 5;
            this.Analisis.Text = "Analisis";
            this.Analisis.UseVisualStyleBackColor = true;
            this.Analisis.Click += new System.EventHandler(this.Analisis_Click);
            // 
            // Copilar
            // 
            this.Copilar.Location = new System.Drawing.Point(164, 4);
            this.Copilar.Name = "Copilar";
            this.Copilar.Size = new System.Drawing.Size(75, 23);
            this.Copilar.TabIndex = 4;
            this.Copilar.Text = "Copilar";
            this.Copilar.UseVisualStyleBackColor = true;
            this.Copilar.Click += new System.EventHandler(this.Copilar_Click);
            // 
            // textBox1
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.textBox1, null);
            this.textBox1.Location = new System.Drawing.Point(119, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(65, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columna";
            // 
            // fila
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.fila, null);
            this.fila.Location = new System.Drawing.Point(34, 4);
            this.fila.Name = "fila";
            this.fila.Size = new System.Drawing.Size(24, 20);
            this.fila.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fila";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // copilado
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.copilado, null);
            this.copilado.BackColor = System.Drawing.SystemColors.Desktop;
            this.copilado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copilado.ForeColor = System.Drawing.SystemColors.Info;
            this.copilado.Location = new System.Drawing.Point(0, 0);
            this.copilado.Name = "copilado";
            this.copilado.Size = new System.Drawing.Size(800, 147);
            this.copilado.TabIndex = 1;
            this.copilado.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[] {
        "SI",
        "SINO",
        "SINO_SI",
        "MIENTRAS",
        "ENTONCES",
        "DESDE",
        "HASTA",
        "verdadero",
        "falso",
        "imprimir",
        "leer",
        "entero",
        "cadena",
        "principal"};
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "IDE Bladimir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fila;
        private System.Windows.Forms.Button Copilar;
        private System.Windows.Forms.RichTextBox Area1;
        private System.Windows.Forms.RichTextBox copilado;
        private System.Windows.Forms.Button Analisis;
        private System.Windows.Forms.TextBox lineaActual;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
    }
}

