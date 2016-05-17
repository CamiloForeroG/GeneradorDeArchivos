using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorDeArchivos
{
    public partial class Comparaciones : Form
    {
        public Comparaciones(string rutaOriginal, string rutaGenerada, bool accion)
        {
            //accion = true es eliminacion, false es actualizacion
            InitializeComponent();
            if (File.Exists(rutaOriginal) && File.Exists(rutaGenerada))
            {
                var originalLines = File.ReadAllLines(rutaOriginal).ToList();
                var generatedLines = File.ReadAllLines(rutaGenerada).ToList();
                int maxCount = Math.Max(originalLines.Count(), generatedLines.Count());
                OriginalFile.SelectionStart = 0;
                OriginalFile.SelectionLength = 1;
                GeneratedFile.SelectionStart = 0;
                GeneratedFile.SelectionLength = 1;
                int pivote = 0;
                if (accion)
                {
                    for (int i = 0; i < maxCount; i++)
                    {
                        if (originalLines[i] == generatedLines[pivote])
                        {
                            OriginalFile.AppendText(i.ToString() + ")  " + originalLines[i]);
                            OriginalFile.AppendText(Environment.NewLine);

                            GeneratedFile.AppendText(i.ToString() + ")  " + generatedLines[pivote]);
                            GeneratedFile.AppendText(Environment.NewLine);
                        }
                        else
                        {
                            OriginalFile.AppendText(i.ToString() + ")  " + originalLines[i], Color.Red);
                            OriginalFile.AppendText(Environment.NewLine);

                            GeneratedFile.AppendText(i.ToString() + ")  " + "");
                            GeneratedFile.AppendText(Environment.NewLine);
                            pivote--;
                        }
                        pivote++;
                    }
                }
                else
                {
                    for (int i = 0; i < maxCount; i++)
                    {

                        if (originalLines[pivote] == generatedLines[i])
                        {
                            OriginalFile.AppendText(i.ToString() + ")  " + originalLines[pivote]);
                            OriginalFile.AppendText(Environment.NewLine);

                            GeneratedFile.AppendText(i.ToString() + ")  " + generatedLines[i]);
                            GeneratedFile.AppendText(Environment.NewLine);
                        }
                        else
                        {
                            OriginalFile.AppendText(i.ToString() + ")  " + "");
                            OriginalFile.AppendText(Environment.NewLine);

                            GeneratedFile.AppendText((i.ToString() + ")  " + generatedLines[pivote]), Color.Blue);
                            GeneratedFile.AppendText(Environment.NewLine);
                            pivote--;
                        }
                        pivote++;
                    }
                }
                GeneratedFile.ScrollToCaret();
                OriginalFile.ScrollToCaret();
            }
        }
    }
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this SyncTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.SelectionBackColor = Color.GreenYellow;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
