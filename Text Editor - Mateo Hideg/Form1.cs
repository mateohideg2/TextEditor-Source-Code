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

            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                pegarToolStripMenuItem1.Enabled = true;
            }
            else
            {
                pegarToolStripMenuItem1.Enabled = false;

                if (Clipboard.ContainsImage())
                {
                    pegarToolStripMenuItem1.Enabled = true;
                }
                else
                {
                    pegarToolStripMenuItem1.Enabled = false;
                }
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

            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                pegarToolStripMenuItem.Enabled = true;
            }
            else
            {
                pegarToolStripMenuItem.Enabled = false;

                if (Clipboard.ContainsImage())
                {
                    pegarToolStripMenuItem.Enabled = true;
                }
                else
                {
                    pegarToolStripMenuItem.Enabled = false;
                }
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
    }
}