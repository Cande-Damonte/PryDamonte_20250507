using PryDamonte_20250507.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryDamonte_20250507
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CmbSuperHeroes.Items.Add("Superman");
            CmbSuperHeroes.Items.Add("Mujer Maravilla");
            CmbSuperHeroes.Items.Add("Spiderman");
        }

        private void CmbSuperHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbSuperHeroes.SelectedIndex == 0)
            {
                pctSuperheroe.Image = Resources.Superman;

            }else if(CmbSuperHeroes.SelectedIndex == 1)
            {
                pctSuperheroe.Image = Resources.mujer_maravilla;

            }else if(CmbSuperHeroes.SelectedIndex ==2)
            {
                pctSuperheroe.Image = Resources.spiderman;
            }

        }
    }
}
