using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloc_Notas
{
    public partial class Lupa : Form
    {
        public string palabra;
        public Lupa()
        {
            InitializeComponent();
        }

        private void textBoxLupa_TextChanged(object sender, EventArgs e)
        {

        }

        public void obtenerPlabraEncontrada()
        {
            textBoxLupa.Text = palabra;
            textBoxLupa.Refresh();
        }

        private void Lupa_Load(object sender, EventArgs e)
        {
            
        }
    }
}
