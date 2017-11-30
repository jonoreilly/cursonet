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

namespace blockNotas
{
    public partial class FormEditor : Form
    {
        public FormEditor()
        {
            InitializeComponent();
        }

        private void tsMenuItemAbrir_Click(object sender, EventArgs e)
        {
            //Todo instanciar la clase OpenFileDialog
            //Mostrarlo llamando a su metodo ShowDialog()
            //Guardar los datos del fichero
            //Mostrar los datos del fichero en el textBox multilinea

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"C:\Users\usuario\Desktop";
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.FilterIndex = 2;
            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    Stream myStream = openFile.OpenFile();
                    if (myStream != null)
                    {
                        string fileName = openFile.FileName;
                        string filePath = Path.GetFullPath(fileName);
                        string fileText = File.ReadAllText(filePath);
                        tbEditorArea.Text = fileText;
                    }
                    else
                    {
                        MessageBox.Show("No has seleccionao na, patan");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Failed");
                }
            }

        }

        private void tsMenuItemGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = @"C:\Users\usuario\Desktop";


        }
    }
}
