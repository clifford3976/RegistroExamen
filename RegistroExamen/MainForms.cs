using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroExamen
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
        }

        private void registrosDeLosGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.registros r = new UI.Registros.registros();
            r.Show();
        }

        private void consultasDeLosGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.consulta c = new UI.Consultas.consulta();
            c.Show();
        }

        private void MainForms_Load(object sender, EventArgs e)
        {

        }
        
    }
}
