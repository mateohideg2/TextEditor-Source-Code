using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Text_Editor___Mateo_Hideg
{
    public partial class Form1 : Form
    {
        string archivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "Documentos de texto (*.txt)|*.txt|Todos los archivos|*.*";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                archivo = OpenFile.FileName;
                using (StreamReader sr = new StreamReader(archivo))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
                Form1.ActiveForm.Text = archivo + " | TextEditor - Mateo Hideg";
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Documentos de texto (*.txt)|*.txt|Todos los archivos|*.*";
            if (archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(richTextBox1.Text);
                }
                Form1.ActiveForm.Text = archivo + " | TextEditor - Mateo Hideg";
            }
            else
            {
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = SaveFile.FileName;
                    using (StreamWriter sw = new StreamWriter(SaveFile.FileName))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                    Form1.ActiveForm.Text = archivo + " | TextEditor - Mateo Hideg";
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Documentos de texto (*.txt)|*.txt|Todos los archivos|*.*";
            if (archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(richTextBox1.Text);
                }
                Form1.ActiveForm.Text = archivo + " | TextEditor - Mateo Hideg";
            }
            else
            {
                if (richTextBox1.Text != "")
                {
                    if (SaveFile.ShowDialog() == DialogResult.OK)
                    {
                        archivo = SaveFile.FileName;
                        using (StreamWriter sw = new StreamWriter(SaveFile.FileName))
                        {
                            sw.Write(richTextBox1.Text);
                        }
                        Form1.ActiveForm.Text = archivo + " | TextEditor - Mateo Hideg";
                    }
                }
            }
            richTextBox1.Clear();
            archivo = null;
            Form1.ActiveForm.Text = "TextEditor - Mateo Hideg";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Documentos de texto (*.txt)|*.txt|Todos los archivos|*.*";
            if (archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(richTextBox1.Text);
                }
                Form1.ActiveForm.Text = archivo + " | TextEditor - Mateo Hideg";
            }
            else
            {
                if (richTextBox1.Text != "")
                {
                    if (SaveFile.ShowDialog() == DialogResult.OK)
                    {
                        archivo = SaveFile.FileName;
                        using (StreamWriter sw = new StreamWriter(SaveFile.FileName))
                        {
                            sw.Write(richTextBox1.Text);
                        }
                        Form1.ActiveForm.Text = archivo + " | TextEditor - Mateo Hideg";
                    }
                }
            }
            this.Dispose();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Documentos de texto (*.txt)|*.txt|Todos los archivos|*.*";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                archivo = SaveFile.FileName;
                using (StreamWriter sw = new StreamWriter(SaveFile.FileName))
                {
                    sw.Write(richTextBox1.Text);
                }
                Form1.ActiveForm.Text = archivo + " | TextEditor - Mateo Hideg";
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void cortarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void seleccionarTodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Documentos de texto (*.txt)|*.txt|Todos los archivos|*.*";
            if (archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(richTextBox1.Text);
                }
                Form1.ActiveForm.Text = archivo + " | TextEditor - Mateo Hideg";
            }
            else
            {
                if (richTextBox1.Text != "")
                {
                    if (SaveFile.ShowDialog() == DialogResult.OK)
                    {
                        archivo = SaveFile.FileName;
                        using (StreamWriter sw = new StreamWriter(SaveFile.FileName))
                        {
                            sw.Write(richTextBox1.Text);
                        }
                        Form1.ActiveForm.Text = archivo + " | TextEditor - Mateo Hideg";
                    }
                }
            }
        }

        private void verLaAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://mateohideg.000webhostapp.com/texteditor/ayuda");
            }
            catch
            {
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abb = new AboutBox1();
            abb.ShowDialog();
        }

        private void ediciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == richTextBox1.Text)
            {
                seleccionarTodoToolStripMenuItem1.Enabled = false;
            }
            else
            {
                seleccionarTodoToolStripMenuItem1.Enabled = true;
            }

            if (richTextBox1.SelectedText == "")
            {
                eliminarToolStripMenuItem1.Enabled = false;
            }
            else
            {
                eliminarToolStripMenuItem1.Enabled = true;
            }

            if (richTextBox1.SelectedText == "")
            {
                cortarToolStripMenuItem1.Enabled = false;
            }
            else
            {
                cortarToolStripMenuItem1.Enabled = true;
            }

            if (richTextBox1.SelectedText == "")
            {
                copiarToolStripMenuItem1.Enabled = false;
            }
            else
            {
                copiarToolStripMenuItem1.Enabled = true;
            }

            if (Clipboard.ContainsText())
            {
                pegarToolStripMenuItem1.Enabled = true;
            }
            else
            {
                pegarToolStripMenuItem.Enabled = false;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (richTextBox1.SelectedText == richTextBox1.Text)
            {
                seleccionarTodoToolStripMenuItem.Enabled = false;
            }
            else
            {
                seleccionarTodoToolStripMenuItem.Enabled = true;
            }

            if (richTextBox1.SelectedText == "")
            {
                eliminarToolStripMenuItem.Enabled = false;
            }
            else
            {
                eliminarToolStripMenuItem.Enabled = true;
            }

            if (richTextBox1.SelectedText == "")
            {
                cortarToolStripMenuItem.Enabled = false;
            }
            else
            {
                cortarToolStripMenuItem.Enabled = true;
            }

            if (richTextBox1.SelectedText == "")
            {
                copiarToolStripMenuItem.Enabled = false;
            }
            else
            {
                copiarToolStripMenuItem.Enabled = true;
            }

            if (Clipboard.ContainsText())
            {
                pegarToolStripMenuItem.Enabled = true;
            }
            else
            {
                pegarToolStripMenuItem.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pegarToolStripMenuItem.Enabled = false;
            copiarToolStripMenuItem.Enabled = false;
            cortarToolStripMenuItem.Enabled = false;
            seleccionarTodoToolStripMenuItem.Enabled = false;
            pegarToolStripMenuItem1.Enabled = false;
            copiarToolStripMenuItem1.Enabled = false;
            cortarToolStripMenuItem1.Enabled = false;
            seleccionarTodoToolStripMenuItem1.Enabled = false;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            if (richTextBox1.SelectedText == "")
            {
                fontDialog1.Font = richTextBox1.Font;
                fontDialog1.Color = richTextBox1.ForeColor;
            }
            else
            {
                fontDialog1.Font = richTextBox1.SelectionFont;
                fontDialog1.Color = richTextBox1.SelectionColor;
            }

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                if (richTextBox1.SelectedText == "")
                {
                    richTextBox1.Font = fontDialog1.Font;
                    richTextBox1.ForeColor = fontDialog1.Color;
                }
                else
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                    richTextBox1.SelectionColor = fontDialog1.Color;
                }
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.V:
                        e.Handled = true;
                        break;
                    default:
                        break;
                }
            }

            if (e.Modifiers == Keys.Shift)
            {
                switch (e.KeyCode)
                {
                    case Keys.Insert:
                        e.Handled = true;
                        break;
                    default:
                        break;
                }
            }

            bool ctrlV = e.Modifiers == Keys.Control && e.KeyCode == Keys.V;
            bool shiftIns = e.Modifiers == Keys.Shift && e.KeyCode == Keys.Insert;

            if (ctrlV || shiftIns)
            {
                if (Clipboard.ContainsText())
                {
                    richTextBox1.Paste();
                }
                else
                {
                   
                }
            }
        }

        private void izquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void derechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontPrint = richTextBox1.SelectionFont;
            e.Graphics.DrawString(richTextBox1.Text, fontPrint, Brushes.Black, 100, 100);
        }
    }
}