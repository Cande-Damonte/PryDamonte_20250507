using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PryDamonte_20250507
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "nuevo_archivo.txt";

            try
            {

                string destreza = numDestreza.ToString();
                string fuerza = numFuerza.ToString();

                string contenido = $"{destreza} {fuerza}";

                File.WriteAllText(rutaArchivo, contenido);
 
                File.CreateText(rutaArchivo).Close(); 

                MessageBox.Show("El archivo ha sido creado.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al crear el archivo");
            }
        }
    }
}
