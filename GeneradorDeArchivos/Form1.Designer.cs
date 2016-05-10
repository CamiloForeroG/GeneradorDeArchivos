namespace GeneradorDeArchivos
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnSeleccionarCarpeta = new System.Windows.Forms.Button();
            this.LblRutaCarpeta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkASP = new System.Windows.Forms.CheckBox();
            this.ChkNET = new System.Windows.Forms.CheckBox();
            this.ListChkModulos = new System.Windows.Forms.CheckedListBox();
            this.LblModulos = new System.Windows.Forms.Label();
            this.LblParamsAdd = new System.Windows.Forms.Label();
            this.TxtParamsAdd = new System.Windows.Forms.TextBox();
            this.LblArchivo = new System.Windows.Forms.Label();
            this.TxtArchivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChkEliminar = new System.Windows.Forms.CheckBox();
            this.ChkActualizar = new System.Windows.Forms.CheckBox();
            this.LblAncla = new System.Windows.Forms.Label();
            this.TxtAncla = new System.Windows.Forms.TextBox();
            this.LblSeparador = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.TxtValorInsertar = new System.Windows.Forms.TextBox();
            this.LblInsertar = new System.Windows.Forms.Label();
            this.RutaEjemplo = new System.Windows.Forms.Label();
            this.BtnGenFiles = new System.Windows.Forms.Button();
            this.LblRuta = new System.Windows.Forms.Label();
            this.ChkMarco = new System.Windows.Forms.CheckBox();
            this.LblSearchValues = new System.Windows.Forms.Label();
            this.BtnAddSearchItem = new System.Windows.Forms.Button();
            this.ChkAntes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnSeleccionarCarpeta
            // 
            this.BtnSeleccionarCarpeta.Location = new System.Drawing.Point(31, 12);
            this.BtnSeleccionarCarpeta.Name = "BtnSeleccionarCarpeta";
            this.BtnSeleccionarCarpeta.Size = new System.Drawing.Size(119, 23);
            this.BtnSeleccionarCarpeta.TabIndex = 1;
            this.BtnSeleccionarCarpeta.Text = "Seleccionar Carpeta";
            this.BtnSeleccionarCarpeta.UseVisualStyleBackColor = true;
            this.BtnSeleccionarCarpeta.Click += new System.EventHandler(this.BtnSeleccionarCarpeta_Click);
            // 
            // LblRutaCarpeta
            // 
            this.LblRutaCarpeta.AutoSize = true;
            this.LblRutaCarpeta.Location = new System.Drawing.Point(165, 17);
            this.LblRutaCarpeta.Name = "LblRutaCarpeta";
            this.LblRutaCarpeta.Size = new System.Drawing.Size(0, 13);
            this.LblRutaCarpeta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta:";
            // 
            // ChkASP
            // 
            this.ChkASP.AutoSize = true;
            this.ChkASP.Location = new System.Drawing.Point(67, 68);
            this.ChkASP.Name = "ChkASP";
            this.ChkASP.Size = new System.Drawing.Size(47, 17);
            this.ChkASP.TabIndex = 4;
            this.ChkASP.Text = "ASP";
            this.ChkASP.UseVisualStyleBackColor = true;
            this.ChkASP.CheckedChanged += new System.EventHandler(this.ChkASP_CheckedChange);
            // 
            // ChkNET
            // 
            this.ChkNET.AutoSize = true;
            this.ChkNET.Location = new System.Drawing.Point(67, 91);
            this.ChkNET.Name = "ChkNET";
            this.ChkNET.Size = new System.Drawing.Size(51, 17);
            this.ChkNET.TabIndex = 5;
            this.ChkNET.Text = ".NET";
            this.ChkNET.UseVisualStyleBackColor = true;
            this.ChkNET.CheckedChanged += new System.EventHandler(this.ChkNET_CheckedChange);
            // 
            // ListChkModulos
            // 
            this.ListChkModulos.FormattingEnabled = true;
            this.ListChkModulos.Location = new System.Drawing.Point(181, 91);
            this.ListChkModulos.Name = "ListChkModulos";
            this.ListChkModulos.Size = new System.Drawing.Size(120, 94);
            this.ListChkModulos.TabIndex = 6;
            this.ListChkModulos.Visible = false;
            this.ListChkModulos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListChkModulos_ItemCheck);
            // 
            // LblModulos
            // 
            this.LblModulos.AutoSize = true;
            this.LblModulos.Location = new System.Drawing.Point(125, 91);
            this.LblModulos.Name = "LblModulos";
            this.LblModulos.Size = new System.Drawing.Size(50, 13);
            this.LblModulos.TabIndex = 7;
            this.LblModulos.Text = "Modulos:";
            this.LblModulos.Visible = false;
            // 
            // LblParamsAdd
            // 
            this.LblParamsAdd.AutoSize = true;
            this.LblParamsAdd.Location = new System.Drawing.Point(338, 91);
            this.LblParamsAdd.Name = "LblParamsAdd";
            this.LblParamsAdd.Size = new System.Drawing.Size(120, 13);
            this.LblParamsAdd.TabIndex = 8;
            this.LblParamsAdd.Text = "Parametros Adicionales:";
            // 
            // TxtParamsAdd
            // 
            this.TxtParamsAdd.Location = new System.Drawing.Point(344, 107);
            this.TxtParamsAdd.Name = "TxtParamsAdd";
            this.TxtParamsAdd.Size = new System.Drawing.Size(190, 20);
            this.TxtParamsAdd.TabIndex = 9;
            // 
            // LblArchivo
            // 
            this.LblArchivo.AutoSize = true;
            this.LblArchivo.Location = new System.Drawing.Point(559, 91);
            this.LblArchivo.Name = "LblArchivo";
            this.LblArchivo.Size = new System.Drawing.Size(46, 13);
            this.LblArchivo.TabIndex = 10;
            this.LblArchivo.Text = "Archivo:";
            // 
            // TxtArchivo
            // 
            this.TxtArchivo.Location = new System.Drawing.Point(558, 108);
            this.TxtArchivo.Name = "TxtArchivo";
            this.TxtArchivo.Size = new System.Drawing.Size(188, 20);
            this.TxtArchivo.TabIndex = 11;
            this.TxtArchivo.Leave += new System.EventHandler(this.TxtArchivo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Accion:";
            // 
            // ChkEliminar
            // 
            this.ChkEliminar.AutoSize = true;
            this.ChkEliminar.Location = new System.Drawing.Point(78, 228);
            this.ChkEliminar.Name = "ChkEliminar";
            this.ChkEliminar.Size = new System.Drawing.Size(62, 17);
            this.ChkEliminar.TabIndex = 13;
            this.ChkEliminar.Text = "Eliminar";
            this.ChkEliminar.UseVisualStyleBackColor = true;
            this.ChkEliminar.CheckedChanged += new System.EventHandler(this.ChkEliminar_Checked);
            // 
            // ChkActualizar
            // 
            this.ChkActualizar.AutoSize = true;
            this.ChkActualizar.Location = new System.Drawing.Point(78, 252);
            this.ChkActualizar.Name = "ChkActualizar";
            this.ChkActualizar.Size = new System.Drawing.Size(72, 17);
            this.ChkActualizar.TabIndex = 14;
            this.ChkActualizar.Text = "Actualizar";
            this.ChkActualizar.UseVisualStyleBackColor = true;
            this.ChkActualizar.CheckedChanged += new System.EventHandler(this.ChkActualizar_CheckedChanged);
            // 
            // LblAncla
            // 
            this.LblAncla.AutoSize = true;
            this.LblAncla.Location = new System.Drawing.Point(165, 253);
            this.LblAncla.Name = "LblAncla";
            this.LblAncla.Size = new System.Drawing.Size(37, 13);
            this.LblAncla.TabIndex = 15;
            this.LblAncla.Text = "Ancla:";
            // 
            // TxtAncla
            // 
            this.TxtAncla.Location = new System.Drawing.Point(208, 250);
            this.TxtAncla.Name = "TxtAncla";
            this.TxtAncla.Size = new System.Drawing.Size(163, 20);
            this.TxtAncla.TabIndex = 16;
            this.TxtAncla.Leave += new System.EventHandler(this.TxtAncla_Leave);
            // 
            // LblSeparador
            // 
            this.LblSeparador.AutoSize = true;
            this.LblSeparador.Location = new System.Drawing.Point(540, 111);
            this.LblSeparador.Name = "LblSeparador";
            this.LblSeparador.Size = new System.Drawing.Size(12, 13);
            this.LblSeparador.TabIndex = 17;
            this.LblSeparador.Text = "\\";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(208, 226);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(163, 20);
            this.TxtBuscar.TabIndex = 18;
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
            this.TxtBuscar.Leave += new System.EventHandler(this.TxtBuscar_Leave);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(165, 229);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(40, 13);
            this.LblBuscar.TabIndex = 19;
            this.LblBuscar.Text = "Buscar";
            // 
            // TxtValorInsertar
            // 
            this.TxtValorInsertar.Location = new System.Drawing.Point(445, 250);
            this.TxtValorInsertar.Multiline = true;
            this.TxtValorInsertar.Name = "TxtValorInsertar";
            this.TxtValorInsertar.Size = new System.Drawing.Size(302, 86);
            this.TxtValorInsertar.TabIndex = 20;
            this.TxtValorInsertar.Leave += new System.EventHandler(this.TxtValorInsertar_Leave);
            // 
            // LblInsertar
            // 
            this.LblInsertar.AutoSize = true;
            this.LblInsertar.Location = new System.Drawing.Point(397, 255);
            this.LblInsertar.Name = "LblInsertar";
            this.LblInsertar.Size = new System.Drawing.Size(42, 13);
            this.LblInsertar.TabIndex = 21;
            this.LblInsertar.Text = "Insertar";
            // 
            // RutaEjemplo
            // 
            this.RutaEjemplo.AutoSize = true;
            this.RutaEjemplo.Location = new System.Drawing.Point(341, 155);
            this.RutaEjemplo.Name = "RutaEjemplo";
            this.RutaEjemplo.Size = new System.Drawing.Size(73, 13);
            this.RutaEjemplo.TabIndex = 23;
            this.RutaEjemplo.Text = "Ruta Ejemplo:";
            this.RutaEjemplo.Visible = false;
            // 
            // BtnGenFiles
            // 
            this.BtnGenFiles.Enabled = false;
            this.BtnGenFiles.Location = new System.Drawing.Point(590, 370);
            this.BtnGenFiles.Name = "BtnGenFiles";
            this.BtnGenFiles.Size = new System.Drawing.Size(157, 23);
            this.BtnGenFiles.TabIndex = 24;
            this.BtnGenFiles.Text = "Generar Archivos";
            this.BtnGenFiles.UseVisualStyleBackColor = true;
            this.BtnGenFiles.Click += new System.EventHandler(this.BtnGenFiles_Click);
            // 
            // LblRuta
            // 
            this.LblRuta.AutoSize = true;
            this.LblRuta.Location = new System.Drawing.Point(341, 171);
            this.LblRuta.Name = "LblRuta";
            this.LblRuta.Size = new System.Drawing.Size(0, 13);
            this.LblRuta.TabIndex = 22;
            // 
            // ChkMarco
            // 
            this.ChkMarco.AutoSize = true;
            this.ChkMarco.Location = new System.Drawing.Point(67, 115);
            this.ChkMarco.Name = "ChkMarco";
            this.ChkMarco.Size = new System.Drawing.Size(56, 17);
            this.ChkMarco.TabIndex = 25;
            this.ChkMarco.Text = "Marco";
            this.ChkMarco.UseVisualStyleBackColor = true;
            this.ChkMarco.CheckedChanged += new System.EventHandler(this.ChkMarco_CheckedChanged);
            // 
            // LblSearchValues
            // 
            this.LblSearchValues.AutoSize = true;
            this.LblSearchValues.Location = new System.Drawing.Point(428, 228);
            this.LblSearchValues.Name = "LblSearchValues";
            this.LblSearchValues.Size = new System.Drawing.Size(0, 13);
            this.LblSearchValues.TabIndex = 26;
            // 
            // BtnAddSearchItem
            // 
            this.BtnAddSearchItem.Image = global::GeneradorDeArchivos.Properties.Resources.right_arrow;
            this.BtnAddSearchItem.Location = new System.Drawing.Point(377, 219);
            this.BtnAddSearchItem.Name = "BtnAddSearchItem";
            this.BtnAddSearchItem.Size = new System.Drawing.Size(34, 30);
            this.BtnAddSearchItem.TabIndex = 27;
            this.BtnAddSearchItem.UseVisualStyleBackColor = true;
            this.BtnAddSearchItem.Click += new System.EventHandler(this.BtnAddSearchItem_Click);
            // 
            // ChkAntes
            // 
            this.ChkAntes.AutoSize = true;
            this.ChkAntes.Location = new System.Drawing.Point(208, 276);
            this.ChkAntes.Name = "ChkAntes";
            this.ChkAntes.Size = new System.Drawing.Size(53, 17);
            this.ChkAntes.TabIndex = 28;
            this.ChkAntes.Text = "Antes";
            this.ChkAntes.UseVisualStyleBackColor = true;
            this.ChkAntes.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 424);
            this.Controls.Add(this.ChkAntes);
            this.Controls.Add(this.BtnAddSearchItem);
            this.Controls.Add(this.LblSearchValues);
            this.Controls.Add(this.ChkMarco);
            this.Controls.Add(this.BtnGenFiles);
            this.Controls.Add(this.RutaEjemplo);
            this.Controls.Add(this.LblRuta);
            this.Controls.Add(this.LblInsertar);
            this.Controls.Add(this.TxtValorInsertar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblSeparador);
            this.Controls.Add(this.TxtAncla);
            this.Controls.Add(this.LblAncla);
            this.Controls.Add(this.ChkActualizar);
            this.Controls.Add(this.ChkEliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtArchivo);
            this.Controls.Add(this.LblArchivo);
            this.Controls.Add(this.TxtParamsAdd);
            this.Controls.Add(this.LblParamsAdd);
            this.Controls.Add(this.LblModulos);
            this.Controls.Add(this.ListChkModulos);
            this.Controls.Add(this.ChkNET);
            this.Controls.Add(this.ChkASP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRutaCarpeta);
            this.Controls.Add(this.BtnSeleccionarCarpeta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BtnSeleccionarCarpeta;
        private System.Windows.Forms.Label LblRutaCarpeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkASP;
        private System.Windows.Forms.CheckBox ChkNET;
        private System.Windows.Forms.CheckedListBox ListChkModulos;
        private System.Windows.Forms.Label LblModulos;
        private System.Windows.Forms.Label LblParamsAdd;
        private System.Windows.Forms.TextBox TxtParamsAdd;
        private System.Windows.Forms.Label LblArchivo;
        private System.Windows.Forms.TextBox TxtArchivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChkEliminar;
        private System.Windows.Forms.CheckBox ChkActualizar;
        private System.Windows.Forms.Label LblAncla;
        private System.Windows.Forms.TextBox TxtAncla;
        private System.Windows.Forms.Label LblSeparador;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.TextBox TxtValorInsertar;
        private System.Windows.Forms.Label LblInsertar;
        private System.Windows.Forms.Label RutaEjemplo;
        private System.Windows.Forms.Button BtnGenFiles;
        private System.Windows.Forms.Label LblRuta;
        private System.Windows.Forms.CheckBox ChkMarco;
        private System.Windows.Forms.Label LblSearchValues;
        private System.Windows.Forms.Button BtnAddSearchItem;
        private System.Windows.Forms.CheckBox ChkAntes;
    }
}

