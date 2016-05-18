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
            this.ChkAntes = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnAddSearchItem = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GridOriginales = new System.Windows.Forms.DataGridView();
            this.LblOriginal = new System.Windows.Forms.Label();
            this.GridGenerados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.RutaEjemplo1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChkASP1 = new System.Windows.Forms.CheckBox();
            this.ChkMarco1 = new System.Windows.Forms.CheckBox();
            this.ChkNET1 = new System.Windows.Forms.CheckBox();
            this.ListChkModulos1 = new System.Windows.Forms.CheckedListBox();
            this.LblModulos1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblParamsAdd1 = new System.Windows.Forms.Label();
            this.TxtParamsAdd1 = new System.Windows.Forms.TextBox();
            this.LblArchivo1 = new System.Windows.Forms.Label();
            this.TxtArchivo1 = new System.Windows.Forms.TextBox();
            this.LblSeparador1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.LblRuta1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridOriginales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridGenerados)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSeleccionarCarpeta
            // 
            this.BtnSeleccionarCarpeta.Location = new System.Drawing.Point(16, 11);
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
            this.LblRutaCarpeta.Location = new System.Drawing.Point(150, 16);
            this.LblRutaCarpeta.Name = "LblRutaCarpeta";
            this.LblRutaCarpeta.Size = new System.Drawing.Size(0, 13);
            this.LblRutaCarpeta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta:";
            // 
            // ChkASP
            // 
            this.ChkASP.AutoSize = true;
            this.ChkASP.Location = new System.Drawing.Point(58, 104);
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
            this.ChkNET.Location = new System.Drawing.Point(58, 127);
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
            this.ListChkModulos.Location = new System.Drawing.Point(165, 127);
            this.ListChkModulos.Name = "ListChkModulos";
            this.ListChkModulos.Size = new System.Drawing.Size(120, 94);
            this.ListChkModulos.TabIndex = 6;
            this.ListChkModulos.Visible = false;
            this.ListChkModulos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListChkModulos_ItemCheck);
            // 
            // LblModulos
            // 
            this.LblModulos.AutoSize = true;
            this.LblModulos.Location = new System.Drawing.Point(109, 127);
            this.LblModulos.Name = "LblModulos";
            this.LblModulos.Size = new System.Drawing.Size(50, 13);
            this.LblModulos.TabIndex = 7;
            this.LblModulos.Text = "Modulos:";
            this.LblModulos.Visible = false;
            // 
            // LblParamsAdd
            // 
            this.LblParamsAdd.AutoSize = true;
            this.LblParamsAdd.Location = new System.Drawing.Point(322, 127);
            this.LblParamsAdd.Name = "LblParamsAdd";
            this.LblParamsAdd.Size = new System.Drawing.Size(120, 13);
            this.LblParamsAdd.TabIndex = 8;
            this.LblParamsAdd.Text = "Parametros Adicionales:";
            // 
            // TxtParamsAdd
            // 
            this.TxtParamsAdd.Location = new System.Drawing.Point(328, 143);
            this.TxtParamsAdd.Name = "TxtParamsAdd";
            this.TxtParamsAdd.Size = new System.Drawing.Size(190, 20);
            this.TxtParamsAdd.TabIndex = 9;
            // 
            // LblArchivo
            // 
            this.LblArchivo.AutoSize = true;
            this.LblArchivo.Location = new System.Drawing.Point(543, 127);
            this.LblArchivo.Name = "LblArchivo";
            this.LblArchivo.Size = new System.Drawing.Size(46, 13);
            this.LblArchivo.TabIndex = 10;
            this.LblArchivo.Text = "Archivo:";
            // 
            // TxtArchivo
            // 
            this.TxtArchivo.Location = new System.Drawing.Point(542, 144);
            this.TxtArchivo.Name = "TxtArchivo";
            this.TxtArchivo.Size = new System.Drawing.Size(188, 20);
            this.TxtArchivo.TabIndex = 11;
            this.TxtArchivo.Leave += new System.EventHandler(this.TxtArchivo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Accion:";
            // 
            // ChkEliminar
            // 
            this.ChkEliminar.AutoSize = true;
            this.ChkEliminar.Location = new System.Drawing.Point(63, 243);
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
            this.ChkActualizar.Location = new System.Drawing.Point(63, 267);
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
            this.LblAncla.Location = new System.Drawing.Point(150, 268);
            this.LblAncla.Name = "LblAncla";
            this.LblAncla.Size = new System.Drawing.Size(37, 13);
            this.LblAncla.TabIndex = 15;
            this.LblAncla.Text = "Ancla:";
            // 
            // TxtAncla
            // 
            this.TxtAncla.Location = new System.Drawing.Point(193, 265);
            this.TxtAncla.Name = "TxtAncla";
            this.TxtAncla.Size = new System.Drawing.Size(163, 20);
            this.TxtAncla.TabIndex = 16;
            this.TxtAncla.Leave += new System.EventHandler(this.TxtAncla_Leave);
            // 
            // LblSeparador
            // 
            this.LblSeparador.AutoSize = true;
            this.LblSeparador.Location = new System.Drawing.Point(524, 147);
            this.LblSeparador.Name = "LblSeparador";
            this.LblSeparador.Size = new System.Drawing.Size(12, 13);
            this.LblSeparador.TabIndex = 17;
            this.LblSeparador.Text = "\\";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(193, 241);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(163, 20);
            this.TxtBuscar.TabIndex = 18;
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
            this.TxtBuscar.Leave += new System.EventHandler(this.TxtBuscar_Leave);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(150, 244);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(40, 13);
            this.LblBuscar.TabIndex = 19;
            this.LblBuscar.Text = "Buscar";
            // 
            // TxtValorInsertar
            // 
            this.TxtValorInsertar.Location = new System.Drawing.Point(430, 265);
            this.TxtValorInsertar.Multiline = true;
            this.TxtValorInsertar.Name = "TxtValorInsertar";
            this.TxtValorInsertar.Size = new System.Drawing.Size(302, 86);
            this.TxtValorInsertar.TabIndex = 20;
            this.TxtValorInsertar.Leave += new System.EventHandler(this.TxtValorInsertar_Leave);
            // 
            // LblInsertar
            // 
            this.LblInsertar.AutoSize = true;
            this.LblInsertar.Location = new System.Drawing.Point(382, 270);
            this.LblInsertar.Name = "LblInsertar";
            this.LblInsertar.Size = new System.Drawing.Size(42, 13);
            this.LblInsertar.TabIndex = 21;
            this.LblInsertar.Text = "Insertar";
            // 
            // RutaEjemplo
            // 
            this.RutaEjemplo.AutoSize = true;
            this.RutaEjemplo.Location = new System.Drawing.Point(325, 191);
            this.RutaEjemplo.Name = "RutaEjemplo";
            this.RutaEjemplo.Size = new System.Drawing.Size(73, 13);
            this.RutaEjemplo.TabIndex = 23;
            this.RutaEjemplo.Text = "Ruta Ejemplo:";
            this.RutaEjemplo.Visible = false;
            // 
            // BtnGenFiles
            // 
            this.BtnGenFiles.Enabled = false;
            this.BtnGenFiles.Location = new System.Drawing.Point(575, 373);
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
            this.LblRuta.Location = new System.Drawing.Point(325, 207);
            this.LblRuta.Name = "LblRuta";
            this.LblRuta.Size = new System.Drawing.Size(0, 13);
            this.LblRuta.TabIndex = 22;
            // 
            // ChkMarco
            // 
            this.ChkMarco.AutoSize = true;
            this.ChkMarco.Location = new System.Drawing.Point(58, 151);
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
            this.LblSearchValues.Location = new System.Drawing.Point(413, 243);
            this.LblSearchValues.Name = "LblSearchValues";
            this.LblSearchValues.Size = new System.Drawing.Size(0, 13);
            this.LblSearchValues.TabIndex = 26;
            // 
            // ChkAntes
            // 
            this.ChkAntes.AutoSize = true;
            this.ChkAntes.Location = new System.Drawing.Point(193, 291);
            this.ChkAntes.Name = "ChkAntes";
            this.ChkAntes.Size = new System.Drawing.Size(53, 17);
            this.ChkAntes.TabIndex = 28;
            this.ChkAntes.Text = "Antes";
            this.ChkAntes.UseVisualStyleBackColor = true;
            this.ChkAntes.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 429);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.BtnSeleccionarCarpeta);
            this.tabPage1.Controls.Add(this.LblRutaCarpeta);
            this.tabPage1.Controls.Add(this.BtnGenFiles);
            this.tabPage1.Controls.Add(this.ChkAntes);
            this.tabPage1.Controls.Add(this.RutaEjemplo);
            this.tabPage1.Controls.Add(this.BtnAddSearchItem);
            this.tabPage1.Controls.Add(this.LblSearchValues);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ChkASP);
            this.tabPage1.Controls.Add(this.LblInsertar);
            this.tabPage1.Controls.Add(this.ChkMarco);
            this.tabPage1.Controls.Add(this.TxtValorInsertar);
            this.tabPage1.Controls.Add(this.ChkNET);
            this.tabPage1.Controls.Add(this.LblBuscar);
            this.tabPage1.Controls.Add(this.ListChkModulos);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.LblModulos);
            this.tabPage1.Controls.Add(this.TxtAncla);
            this.tabPage1.Controls.Add(this.LblRuta);
            this.tabPage1.Controls.Add(this.LblAncla);
            this.tabPage1.Controls.Add(this.LblParamsAdd);
            this.tabPage1.Controls.Add(this.ChkActualizar);
            this.tabPage1.Controls.Add(this.TxtParamsAdd);
            this.tabPage1.Controls.Add(this.ChkEliminar);
            this.tabPage1.Controls.Add(this.LblArchivo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.TxtArchivo);
            this.tabPage1.Controls.Add(this.LblSeparador);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnAddSearchItem
            // 
            this.BtnAddSearchItem.Image = global::GeneradorDeArchivos.Properties.Resources.right_arrow;
            this.BtnAddSearchItem.Location = new System.Drawing.Point(362, 234);
            this.BtnAddSearchItem.Name = "BtnAddSearchItem";
            this.BtnAddSearchItem.Size = new System.Drawing.Size(34, 30);
            this.BtnAddSearchItem.TabIndex = 27;
            this.BtnAddSearchItem.UseVisualStyleBackColor = true;
            this.BtnAddSearchItem.Click += new System.EventHandler(this.BtnAddSearchItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comparar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GridOriginales);
            this.splitContainer1.Panel1.Controls.Add(this.LblOriginal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridGenerados);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(744, 397);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.TabIndex = 0;
            // 
            // GridOriginales
            // 
            this.GridOriginales.AllowUserToAddRows = false;
            this.GridOriginales.AllowUserToDeleteRows = false;
            this.GridOriginales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOriginales.Location = new System.Drawing.Point(13, 48);
            this.GridOriginales.Name = "GridOriginales";
            this.GridOriginales.ReadOnly = true;
            this.GridOriginales.Size = new System.Drawing.Size(350, 332);
            this.GridOriginales.TabIndex = 1;
            this.GridOriginales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grids_CellDoubleClick);
            // 
            // LblOriginal
            // 
            this.LblOriginal.AutoSize = true;
            this.LblOriginal.Location = new System.Drawing.Point(10, 18);
            this.LblOriginal.Name = "LblOriginal";
            this.LblOriginal.Size = new System.Drawing.Size(42, 13);
            this.LblOriginal.TabIndex = 0;
            this.LblOriginal.Text = "Original";
            // 
            // GridGenerados
            // 
            this.GridGenerados.AllowUserToAddRows = false;
            this.GridGenerados.AllowUserToDeleteRows = false;
            this.GridGenerados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGenerados.Location = new System.Drawing.Point(11, 48);
            this.GridGenerados.Name = "GridGenerados";
            this.GridGenerados.ReadOnly = true;
            this.GridGenerados.Size = new System.Drawing.Size(360, 332);
            this.GridGenerados.TabIndex = 1;
            this.GridGenerados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grids_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generado";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LblRuta1);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.RutaEjemplo1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.ChkASP1);
            this.tabPage3.Controls.Add(this.ChkMarco1);
            this.tabPage3.Controls.Add(this.ChkNET1);
            this.tabPage3.Controls.Add(this.ListChkModulos1);
            this.tabPage3.Controls.Add(this.LblModulos1);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.LblParamsAdd1);
            this.tabPage3.Controls.Add(this.TxtParamsAdd1);
            this.tabPage3.Controls.Add(this.LblArchivo1);
            this.tabPage3.Controls.Add(this.TxtArchivo1);
            this.tabPage3.Controls.Add(this.LblSeparador1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(750, 403);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Comparar Binarios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Archivo Original:";
            // 
            // RutaEjemplo1
            // 
            this.RutaEjemplo1.AutoSize = true;
            this.RutaEjemplo1.Location = new System.Drawing.Point(318, 192);
            this.RutaEjemplo1.Name = "RutaEjemplo1";
            this.RutaEjemplo1.Size = new System.Drawing.Size(73, 13);
            this.RutaEjemplo1.TabIndex = 37;
            this.RutaEjemplo1.Text = "Ruta Ejemplo:";
            this.RutaEjemplo1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ruta:";
            // 
            // ChkASP1
            // 
            this.ChkASP1.AutoSize = true;
            this.ChkASP1.Location = new System.Drawing.Point(56, 100);
            this.ChkASP1.Name = "ChkASP1";
            this.ChkASP1.Size = new System.Drawing.Size(47, 17);
            this.ChkASP1.TabIndex = 27;
            this.ChkASP1.Text = "ASP";
            this.ChkASP1.UseVisualStyleBackColor = true;
            this.ChkASP1.CheckedChanged += new System.EventHandler(this.ChkASP_CheckedChange);
            // 
            // ChkMarco1
            // 
            this.ChkMarco1.AutoSize = true;
            this.ChkMarco1.Location = new System.Drawing.Point(56, 147);
            this.ChkMarco1.Name = "ChkMarco1";
            this.ChkMarco1.Size = new System.Drawing.Size(56, 17);
            this.ChkMarco1.TabIndex = 38;
            this.ChkMarco1.Text = "Marco";
            this.ChkMarco1.UseVisualStyleBackColor = true;
            this.ChkMarco1.CheckedChanged += new System.EventHandler(this.ChkMarco_CheckedChanged);
            // 
            // ChkNET1
            // 
            this.ChkNET1.AutoSize = true;
            this.ChkNET1.Location = new System.Drawing.Point(56, 123);
            this.ChkNET1.Name = "ChkNET1";
            this.ChkNET1.Size = new System.Drawing.Size(51, 17);
            this.ChkNET1.TabIndex = 28;
            this.ChkNET1.Text = ".NET";
            this.ChkNET1.UseVisualStyleBackColor = true;
            this.ChkNET1.CheckedChanged += new System.EventHandler(this.ChkNET_CheckedChange);
            // 
            // ListChkModulos1
            // 
            this.ListChkModulos1.FormattingEnabled = true;
            this.ListChkModulos1.Location = new System.Drawing.Point(170, 123);
            this.ListChkModulos1.Name = "ListChkModulos1";
            this.ListChkModulos1.Size = new System.Drawing.Size(139, 94);
            this.ListChkModulos1.TabIndex = 29;
            this.ListChkModulos1.Visible = false;
            // 
            // LblModulos1
            // 
            this.LblModulos1.AutoSize = true;
            this.LblModulos1.Location = new System.Drawing.Point(114, 123);
            this.LblModulos1.Name = "LblModulos1";
            this.LblModulos1.Size = new System.Drawing.Size(50, 13);
            this.LblModulos1.TabIndex = 30;
            this.LblModulos1.Text = "Modulos:";
            this.LblModulos1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 36;
            // 
            // LblParamsAdd1
            // 
            this.LblParamsAdd1.AutoSize = true;
            this.LblParamsAdd1.Location = new System.Drawing.Point(315, 128);
            this.LblParamsAdd1.Name = "LblParamsAdd1";
            this.LblParamsAdd1.Size = new System.Drawing.Size(120, 13);
            this.LblParamsAdd1.TabIndex = 31;
            this.LblParamsAdd1.Text = "Parametros Adicionales:";
            // 
            // TxtParamsAdd1
            // 
            this.TxtParamsAdd1.Location = new System.Drawing.Point(321, 144);
            this.TxtParamsAdd1.Name = "TxtParamsAdd1";
            this.TxtParamsAdd1.Size = new System.Drawing.Size(190, 20);
            this.TxtParamsAdd1.TabIndex = 32;
            // 
            // LblArchivo1
            // 
            this.LblArchivo1.AutoSize = true;
            this.LblArchivo1.Location = new System.Drawing.Point(536, 128);
            this.LblArchivo1.Name = "LblArchivo1";
            this.LblArchivo1.Size = new System.Drawing.Size(46, 13);
            this.LblArchivo1.TabIndex = 33;
            this.LblArchivo1.Text = "Archivo:";
            // 
            // TxtArchivo1
            // 
            this.TxtArchivo1.Location = new System.Drawing.Point(535, 145);
            this.TxtArchivo1.Name = "TxtArchivo1";
            this.TxtArchivo1.Size = new System.Drawing.Size(188, 20);
            this.TxtArchivo1.TabIndex = 34;
            // 
            // LblSeparador1
            // 
            this.LblSeparador1.AutoSize = true;
            this.LblSeparador1.Location = new System.Drawing.Point(517, 147);
            this.LblSeparador1.Name = "LblSeparador1";
            this.LblSeparador1.Size = new System.Drawing.Size(12, 13);
            this.LblSeparador1.TabIndex = 35;
            this.LblSeparador1.Text = "\\";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(348, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 52;
            this.radioButton1.Text = "Kilauea";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(285, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 51;
            this.radioButton2.Text = "K2V";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(230, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(38, 17);
            this.radioButton3.TabIndex = 50;
            this.radioButton3.Text = "K2";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(158, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 49;
            this.radioButton4.Text = "Makalu";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(82, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(60, 17);
            this.radioButton5.TabIndex = 48;
            this.radioButton5.Text = "Cumbal";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(61, 17);
            this.radioButton6.TabIndex = 47;
            this.radioButton6.Text = "Everest";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(16, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 47);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servidores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton10);
            this.groupBox2.Controls.Add(this.radioButton11);
            this.groupBox2.Controls.Add(this.radioButton12);
            this.groupBox2.Location = new System.Drawing.Point(22, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 47);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servidores";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(348, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(60, 17);
            this.radioButton7.TabIndex = 52;
            this.radioButton7.Text = "Kilauea";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 19);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(61, 17);
            this.radioButton8.TabIndex = 47;
            this.radioButton8.Text = "Everest";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(285, 19);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(45, 17);
            this.radioButton9.TabIndex = 51;
            this.radioButton9.Text = "K2V";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(82, 19);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(60, 17);
            this.radioButton10.TabIndex = 48;
            this.radioButton10.Text = "Cumbal";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(230, 19);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(38, 17);
            this.radioButton11.TabIndex = 50;
            this.radioButton11.Text = "K2";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(158, 19);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(60, 17);
            this.radioButton12.TabIndex = 49;
            this.radioButton12.Text = "Makalu";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // LblRuta1
            // 
            this.LblRuta1.AutoSize = true;
            this.LblRuta1.Location = new System.Drawing.Point(318, 218);
            this.LblRuta1.Name = "LblRuta1";
            this.LblRuta1.Size = new System.Drawing.Size(0, 13);
            this.LblRuta1.TabIndex = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridOriginales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridGenerados)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label LblOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridOriginales;
        private System.Windows.Forms.DataGridView GridGenerados;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label RutaEjemplo1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChkASP1;
        private System.Windows.Forms.CheckBox ChkMarco1;
        private System.Windows.Forms.CheckBox ChkNET1;
        private System.Windows.Forms.CheckedListBox ListChkModulos1;
        private System.Windows.Forms.Label LblModulos1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblParamsAdd1;
        private System.Windows.Forms.TextBox TxtParamsAdd1;
        private System.Windows.Forms.Label LblArchivo1;
        private System.Windows.Forms.TextBox TxtArchivo1;
        private System.Windows.Forms.Label LblSeparador1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.Label LblRuta1;
    }
}

