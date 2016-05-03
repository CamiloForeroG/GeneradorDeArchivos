using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
        }

        private void BtnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                label1.Text = folderBrowserDialog1.SelectedPath;
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
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Sinco.dbo.ModulosMenu", sqlConn);
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
            RutaEjemplo.Visible = false;
        }
        private void ChkEliminar_Checked(object sender, EventArgs e)
        {
            ChkActualizar.Checked = !ChkEliminar.Checked;
            LblAncla.Visible = TxtAncla.Visible = LblInsertar.Visible = TxtValorInsertar.Visible = ChkActualizar.Checked;
            LblBuscar.Visible = TxtBuscar.Visible = !ChkActualizar.Checked;
        }

        private void ChkActualizar_CheckedChanged(object sender, EventArgs e)
        {
            ChkEliminar.Checked = !ChkActualizar.Checked;
        }

        private void ReOrganizeControls(bool aspChecked)
        {
            if (aspChecked)
            {
                LblModulos.Visible = ListChkModulos.Visible = false;

                LblParamsAdd.Location = new Point(LblParamsAdd.Location.X - 216, LblParamsAdd.Location.Y - 41);
                TxtParamsAdd.Location = new Point(TxtParamsAdd.Location.X - 216, TxtParamsAdd.Location.Y - 41);
                TxtParamsAdd.Width = TxtParamsAdd.Width + 50;

                LblArchivo.Location = new Point(LblArchivo.Location.X - 166, LblArchivo.Location.Y - 41);
                TxtArchivo.Location = new Point(TxtArchivo.Location.X - 166, TxtArchivo.Location.Y - 41);
                TxtArchivo.Width = TxtArchivo.Width + 50;

                LblSeparador.Location = new Point(LblSeparador.Location.X - 164, LblSeparador.Location.Y - 44);
            }

            else if (ChkNET.Checked)
            {
                LblParamsAdd.Location = new Point(LblParamsAdd.Location.X + 216, LblParamsAdd.Location.Y + 41);
                TxtParamsAdd.Location = new Point(TxtParamsAdd.Location.X + 216, TxtParamsAdd.Location.Y + 41);
                TxtParamsAdd.Width = TxtParamsAdd.Width - 50;

                LblArchivo.Location = new Point(LblArchivo.Location.X + 166, LblArchivo.Location.Y + 41);
                TxtArchivo.Location = new Point(TxtArchivo.Location.X + 166, TxtArchivo.Location.Y + 41);
                TxtArchivo.Width = TxtArchivo.Width - 50;

                LblSeparador.Location = new Point(LblSeparador.Location.X + 164, LblSeparador.Location.Y + 44);
            }
            else {
                LblParamsAdd.Location = new Point(LblParamsAdd.Location.X + 216, LblParamsAdd.Location.Y + 60);
                TxtParamsAdd.Location = new Point(TxtParamsAdd.Location.X + 216, TxtParamsAdd.Location.Y + 60);
                TxtParamsAdd.Width = TxtParamsAdd.Width - 50;

                LblArchivo.Location = new Point(LblArchivo.Location.X + 166, LblArchivo.Location.Y + 60);
                TxtArchivo.Location = new Point(TxtArchivo.Location.X + 166, TxtArchivo.Location.Y + 60);
                TxtArchivo.Width = TxtArchivo.Width - 50;

                LblSeparador.Location = new Point(LblSeparador.Location.X + 164, LblSeparador.Location.Y + 44);
            }
        }

        private void TxtArchivo_Leave(object sender, EventArgs e)
        {
            if (ChkNET.Checked)
            {
                strRuta += "ERPNET";
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
            DataTable dt = new DataTable();
            SqlConnection sqlConn = new SqlConnection(cadenaConex);
            var strSP = @"SELECT BdAspUbicacion, BdSservidor, BdNombre, BdNombreCliente FROM dbo.BaseDatos WHERE (BdCategoria = 22) AND BdAspUbicacion IS NOT NULL AND BdActivo = 1";
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
                ArmarRuta(dt.Rows[i][0].ToString(), dt.Rows[i]);
            }
        }


        private void ArmarRuta(string strBaseServer, DataRow dr)//DataTable dt, int i)
        {
            foreach (var mod in modulos)
            {
                strBaseServer = String.Format(strBaseServer + "\\{0}\\{1}{2}", strRuta, mod, baseFijo);
                RecorrerDocumento(strBaseServer, dr, mod);
            }
        }

        private void RecorrerDocumento(string strBaseServer, DataRow dr, string modulo)
        {
            if (File.Exists(strBaseServer))
            {
                using (StreamReader sr = File.OpenText(strBaseServer))
                {
                    string s = "";
                    var count = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (s.IndexOf("ASPState") != -1 || s.IndexOf("NombreAplicacion") != -1 || s.IndexOf("AmbientePublicacion") != -1)
                        {
                            DataTable dt0 = new DataTable();
                            SqlConnection sqlConn0 = new SqlConnection(cadenaGold);
                            var strSP0 = @"INSERT INTO CONFIG.Archivos SELECT '" + dr[1].ToString() + "', '" + dr[2].ToString() + "', '" + dr[3].ToString() + "', '" + modulo + "', 'Web.config" + "', '" + strBaseServer + "', '" + count + "'";
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
                            Console.WriteLine(s);
                        }
                        count++;
                    }
                }
            }
        }

        private void ListChkModulos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var modRepeat = from module in modulos
                      where module == ListChkModulos.GetItemText(ListChkModulos.Items[e.Index]).ToString()
                      select module.FirstOrDefault();
            if (modRepeat.ToArray().Length == 0)
                modulos.Add(ListChkModulos.GetItemText(ListChkModulos.Items[e.Index]));
            else
                modulos.Remove(ListChkModulos.GetItemText(ListChkModulos.Items[e.Index]));
        }

        private void validarGererar() {
            if (!string.IsNullOrEmpty(TxtArchivo.Text) && ((ChkEliminar.Checked && !string.IsNullOrEmpty(TxtBuscar.Text)) || (ChkActualizar.Checked && !string.IsNullOrEmpty(TxtAncla.Text) && !string.IsNullOrEmpty(TxtValorInsertar.Text))))
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

        
    }
}
