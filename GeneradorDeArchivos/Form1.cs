using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorDeArchivos
{
    public partial class Form1 : Form
    {
        private string cadenaConex = "Data Source=CUMBAL;Initial Catalog=SincronizarSQL; Trusted_Connection=yes";
        private string cadenaGold = "Data Source=GOLDEN;Initial Catalog=Entornos; Trusted_Connection=yes";
        DataTable dtModulos = new DataTable();
        private string strRuta = "";
        List<string> modulos = new List<string>();
        String baseFijo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChkASP.Checked = true;
            ChkEliminar.Checked = true;
            ReOrganizeControls(true);

            GridOriginales.ColumnCount = 2;
            GridOriginales.ColumnHeadersVisible = true;
            GridOriginales.Columns[0].Name = "ID";
            GridOriginales.Columns[0].Width = 30;
            GridOriginales.Columns[1].Name = "Archivo";
            GridOriginales.Columns[1].Width = GridOriginales.Width - 75;

            GridGenerados.ColumnCount = 2;
            GridGenerados.ColumnHeadersVisible = true;
            GridGenerados.Columns[0].Name = "ID";
            GridGenerados.Columns[0].Width = 30;
            GridGenerados.Columns[1].Name = "Archivo";
            GridGenerados.Columns[1].Width = GridGenerados.Width - 75; 
        }

        private void BtnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                LblRutaCarpeta.Text = folderBrowserDialog1.SelectedPath;
        }

        private void ChkNET_CheckedChange(object sender, EventArgs e)
        {
            if (ChkNET.Checked)
            {
                ChkMarco.Checked = ChkASP.Checked = !ChkNET.Checked;
                ReOrganizeControls(false);
                LblRuta.Text = strRuta = TxtArchivo.Text = TxtParamsAdd.Text = "";
                RutaEjemplo.Visible = false;
                LblModulos.Visible = ListChkModulos.Visible = true;
                if (dtModulos.Rows.Count == 0)
                {
                    SqlConnection sqlConn = new SqlConnection(cadenaConex);
                    SqlDataAdapter da = new SqlDataAdapter("SELECT 'TODOS' DescModulo, -1 IdModulo UNION SELECT DescModulo, IdModulo FROM Sinco.dbo.ModulosMenu ORDER BY IdModulo", sqlConn);
                    try
                    {
                        sqlConn.Open();
                        da.Fill(dtModulos);
                        sqlConn.Close();
                    }
                    catch (SqlException exSQL)
                    {
                        Console.WriteLine(exSQL.ToString());
                        sqlConn.Close();
                    }

                    ((ListBox)ListChkModulos).DataSource = dtModulos;
                    ((ListBox)ListChkModulos).DisplayMember = "DescModulo";
                    ((ListBox)ListChkModulos).ValueMember = "IdModulo";
                }
            }
            else
            {
                ReOrganizeControls(true);
            }
        }

        private void ChkASP_CheckedChange(object sender, EventArgs e)
        {
            if (ChkASP.Checked) ChkNET.Checked = ChkMarco.Checked = !ChkASP.Checked;
            LblRuta.Text = strRuta = TxtArchivo.Text = TxtParamsAdd.Text = "";
            RutaEjemplo.Visible = false;
        }

        private void ChkMarco_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkMarco.Checked) ChkNET.Checked = ChkASP.Checked = !ChkMarco.Checked;
            LblRuta.Text = strRuta = TxtArchivo.Text = TxtParamsAdd.Text = "";
            ReOrganizeControls(true);
            RutaEjemplo.Visible = false;
        }

        private void ChkEliminar_Checked(object sender, EventArgs e)
        {
            ChkActualizar.Checked = !ChkEliminar.Checked;
            LblAncla.Visible = TxtAncla.Visible = ChkAntes.Visible = LblInsertar.Visible = TxtValorInsertar.Visible = ChkActualizar.Checked;
            LblBuscar.Visible = TxtBuscar.Visible = BtnAddSearchItem.Visible = !ChkActualizar.Checked;
            LblSearchValues.Text = "";
        }

        private void ChkActualizar_CheckedChanged(object sender, EventArgs e)
        {
            ChkEliminar.Checked = !ChkActualizar.Checked;
        }

        private void ReOrganizeControls(bool aspChecked)
        {
            modulos.Clear();
            foreach (int i in ListChkModulos.CheckedIndices)
            {
                ListChkModulos.SetItemChecked(i, false);
            }
            if (aspChecked)
            {
                LblModulos.Visible = ListChkModulos.Visible = false;

                if (ChkASP.Checked)
                {
                    LblParamsAdd.Location = new Point(130, 45);
                    TxtParamsAdd.Location = new Point(130, 63);
                    TxtParamsAdd.Width = 240;

                    LblArchivo.Location = new Point(385, 45);
                    TxtArchivo.Location = new Point(385, 63);
                    TxtArchivo.Width = 240;

                    LblSeparador.Location = new Point(372, 66);
                }

                else
                {
                    LblParamsAdd.Location = new Point(135, 95);
                    TxtParamsAdd.Location = new Point(135, 115);
                    TxtParamsAdd.Width = 240;

                    LblArchivo.Location = new Point(393, 95);
                    TxtArchivo.Location = new Point(393, 115);
                    TxtArchivo.Width = 240;

                    LblSeparador.Location = new Point(378, 117);
                }
            }

            else
            {
                LblParamsAdd.Location = new Point(338, 91);
                TxtParamsAdd.Location = new Point(344, 107);
                TxtParamsAdd.Width = 190;

                LblArchivo.Location = new Point(559, 91);
                TxtArchivo.Location = new Point(559, 108);
                TxtArchivo.Width = 190;

                LblSeparador.Location = new Point(540, 111);
            }

        }

        private void TxtArchivo_Leave(object sender, EventArgs e)
        {
            if (ChkNET.Checked)
            {
                strRuta += "\\ERPNET";
            }

            var modRepeat = from module in modulos
                            select module.ToList();

            baseFijo = String.Format("{0}\\{1}", "\\" + TxtParamsAdd.Text.Trim(), TxtArchivo.Text.Trim()).Replace("\\\\", "\\");
            RutaEjemplo.Visible = true;
            LblRuta.Text = strRuta + (modulos.Count > 0 ? ("\\" + modulos[0]) : "") + baseFijo;
            validarGererar();
        }

        private void BtnGenFiles_Click(object sender, EventArgs e)
        {
            BtnGenFiles.Enabled = false;
            DataTable dt = new DataTable();
            SqlConnection sqlConn = new SqlConnection(cadenaConex);
            var strSP = @"SELECT BdAspUbicacion, BdSservidor, BdNombre, BdNombreCliente FROM dbo.BaseDatos WHERE (BdCategoria = " + (ChkMarco.Checked ? "23" : "22") + ") AND BdAspUbicacion IS NOT NULL AND BdActivo = 1";
            SqlDataAdapter da = new SqlDataAdapter(strSP, sqlConn);
            try
            {
                sqlConn.Open();
                da.Fill(dt);
                sqlConn.Close();
            }
            catch (SqlException exSQL)
            {
                Console.WriteLine(exSQL.ToString());
                sqlConn.Close();
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ArmarRuta(dt.Rows[i]);
            }
            BtnGenFiles.Enabled = true;
            tabControl1.SelectedIndex = 1;
        }


        private void ArmarRuta(DataRow dr)
        {
            if (modulos.Count > 0)
            {
                foreach (var mod in modulos)
                {
                    //strBaseServer = String.Format(strBaseServer + "{0}\\{1}{2}", strRuta, mod, baseFijo);
                    var rutaCompleta = String.Format(dr[0].ToString() + "{0}\\{1}{2}", strRuta, mod, baseFijo);
                    if (File.Exists(rutaCompleta))
                    {
                        using (StreamReader sr = File.OpenText(rutaCompleta))
                        {
                            var cte = 0;
                            string s = "";
                            var searchWords = LblSearchValues.Text;
                            try
                            {
                                while ((s = sr.ReadLine()) != null && cte == 0)
                                {
                                    cte++;
                                    RecorrerDocumento(rutaCompleta, dr, mod);
                                }
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }
                    }
                }
            }
            else
            {
                var rutaCompleta = String.Format(dr[0].ToString() + "{0}{1}", strRuta, baseFijo);
                if (File.Exists(rutaCompleta))
                {
                    using (StreamReader sr = File.OpenText(rutaCompleta))
                    {
                        var cte = 0;
                        string s = "";
                        var searchWords = LblSearchValues.Text;
                        try
                        {
                            while ((s = sr.ReadLine()) != null && cte == 0)
                            {
                                cte++;
                                RecorrerDocumento(rutaCompleta, dr, null);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
            }
        }

        private void RecorrerDocumento(string rutaCompleta, DataRow dr, string modulo)
        {
            if (File.Exists(rutaCompleta))
            {
                var test = LblRutaCarpeta.Text;
                var tales = String.Format(dr[0].ToString().Replace("\\\\", "\\") + "{0}{1}{2}", strRuta, (string.IsNullOrEmpty(modulo) ? "" : "\\" + modulo), (TxtParamsAdd.Text == "" ? "" : "\\" + TxtParamsAdd.Text)).Split('\\');

                while (tales.Length > 0)
                {
                    if (tales[0] == "")
                    {
                        tales = tales.Skip(1).ToArray();
                    }
                    else
                    {
                        test += "\\" + tales[0];
                        tales = tales.Skip(1).ToArray();
                        if (!System.IO.Directory.Exists(test))
                            System.IO.Directory.CreateDirectory(test);
                    }
                }
                test += "\\" + TxtArchivo.Text;

                using (StreamWriter file =
                                new System.IO.StreamWriter(test))
                {
                    using (StreamReader sr = File.OpenText(rutaCompleta))
                    {
                        string s = "";
                        var count = 0;
                        var searchWords = LblSearchValues.Text;
                        try
                        {
                            while ((s = sr.ReadLine()) != null)
                            {
                                if (ChkEliminar.Checked)
                                {
                                    Regex rgx = new Regex(searchWords);
                                    var matches = rgx.Match(s);
                                    if (matches.Length == 0)
                                    {
                                        file.WriteLine(s);
                                    }
                                    count++;
                                }
                                else {
                                    if (s.IndexOf(TxtAncla.Text) != -1)
                                    {
                                        if (ChkAntes.Checked) file.WriteLine(TxtValorInsertar.Text);
                                        file.WriteLine(s);
                                        if (!ChkAntes.Checked) file.WriteLine(TxtValorInsertar.Text);
                                    }
                                    else
                                    {
                                        file.WriteLine(s);
                                    }
                                    count++;
                                }
                            }
                            var ident = GridOriginales.Rows.Count.ToString();
                            GridOriginales.Rows.Add(ident, rutaCompleta);
                            GridGenerados.Rows.Add(ident, test);
                        }
                        catch (Exception ex) {
                            throw ex;
                        }
                    }
                }

                DataTable dt0 = new DataTable();
                SqlConnection sqlConn0 = new SqlConnection(cadenaGold);
                var strSP0 = @"INSERT INTO CONFIG.Archivos (Servidor, Empresa, NombreBaseDatos, Modulo, Archivo, RutaCompleta) SELECT '" + dr[1].ToString() + "', '" + dr[2].ToString() + "', '" + dr[3].ToString() + "', '" + modulo + "', 'Web.config" + "', '" + rutaCompleta + "'";
                SqlDataAdapter da0 = new SqlDataAdapter(strSP0, sqlConn0);
                try
                {
                    sqlConn0.Open();
                    da0.Fill(dt0);
                    sqlConn0.Close();
                }
                catch (SqlException exSQL)
                {
                    Console.WriteLine(exSQL.ToString());
                    sqlConn0.Close();
                }
            }
            //using (StreamReader sr = File.OpenText(strBaseServer))
            //{
            //    string s = "";
            //    var count = 0;
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        if (s.IndexOf("ASPState") != -1 || s.IndexOf("NombreAplicacion") != -1 || s.IndexOf("AmbientePublicacion") != -1)
            //        {
            //            DataTable dt0 = new DataTable();
            //            SqlConnection sqlConn0 = new SqlConnection(cadenaGold);
            //            var strSP0 = @"INSERT INTO CONFIG.Archivos SELECT '" + dr[1].ToString() + "', '" + dr[2].ToString() + "', '" + dr[3].ToString() + "', '" + modulo + "', 'Web.config" + "', '" + strBaseServer + "', '" + count + "'";
            //            SqlDataAdapter da0 = new SqlDataAdapter(strSP0, sqlConn0);
            //            try
            //            {
            //                sqlConn0.Open();
            //                da0.Fill(dt0);
            //                sqlConn0.Close();
            //            }
            //            catch (SqlException exSQL)
            //            {
            //                Console.WriteLine(exSQL.ToString());
            //                sqlConn0.Close();
            //            }
            //            Console.WriteLine(s);
            //        }
            //        count++;
            //    }
            //}
        }
    

        private void ListChkModulos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (ListChkModulos.GetItemText(ListChkModulos.Items[e.Index]).ToString() == "TODOS")
            {
                if (modulos.Count > 0) modulos.Clear();
                else
                {
                    foreach (var i in ListChkModulos.Items)
                    {
                        if (ListChkModulos.GetItemText(i) != "TODOS")
                            modulos.Add(ListChkModulos.GetItemText(i));
                    }
                }
            }
            else
            {
                var modRepeat = from module in modulos
                                where module == ListChkModulos.GetItemText(ListChkModulos.Items[e.Index]).ToString()
                                select module.FirstOrDefault();
                if (modRepeat.ToArray().Length == 0)
                    modulos.Add(ListChkModulos.GetItemText(ListChkModulos.Items[e.Index]));
                else
                    modulos.Remove(ListChkModulos.GetItemText(ListChkModulos.Items[e.Index]));
            }
        }

        private void validarGererar()
        {
            if (!string.IsNullOrEmpty(TxtArchivo.Text) && ((ChkEliminar.Checked && !string.IsNullOrEmpty(TxtBuscar.Text)) || (ChkActualizar.Checked && !string.IsNullOrEmpty(TxtAncla.Text) && !string.IsNullOrEmpty(TxtValorInsertar.Text))) && !string.IsNullOrEmpty(LblRutaCarpeta.Text))
                BtnGenFiles.Enabled = true;
        }

        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            validarGererar();
        }

        private void TxtAncla_Leave(object sender, EventArgs e)
        {
            validarGererar();
        }

        private void TxtValorInsertar_Leave(object sender, EventArgs e)
        {
            validarGererar();
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                BtnAddSearchItem_Click(null, e);
            }
        }

        private void BtnAddSearchItem_Click(object sender, EventArgs e)
        {
            LblSearchValues.Text += LblSearchValues.Text == "" ? TxtBuscar.Text : "|" + TxtBuscar.Text;
            TxtBuscar.Text = "";
        }

        private void Grids_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var originalFileRoute = GridOriginales.Rows[e.RowIndex].Cells[1].Value;
            var generatedFileRoute = GridGenerados.Rows[e.RowIndex].Cells[1].Value;
            var ters = new Comparaciones(originalFileRoute.ToString(), generatedFileRoute.ToString(), ChkEliminar.Checked);
            ters.Show();
        }
    }
}
