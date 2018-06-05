using RegistroExamen.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace RegistroExamen.UI.Consultas
{
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Grupos, bool>> Filtro = x => true;

            int id;
            switch(FiltrocomboBox.SelectedIndex)
            {
                case 0: //id
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    Filtro = x => x.GrupoId == id;
                    break;

                case 1: //Fecha
                    Filtro = x => x.Fecha.Equals(CriteriotextBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;

                case 2: //Descripcion
                    Filtro = x => x.Descripcion.Equals(CriteriotextBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;

                case 3: //Cantidad
                    Filtro = x => x.Cantidad.Equals(CriteriotextBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;

                case 4: //Grupos
                    Filtro = x => x.grupos.Equals(CriteriotextBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;

                case 5: //Integrantes
                    Filtro = x => x.Integrantes.Equals(CriteriotextBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;

            }
            ConsultasdataGridView.DataSource = BLL.GruposBLL.GetList(Filtro);
         }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 1)
                CriteriotextBox.Enabled = false;
            else
                CriteriotextBox.Enabled = true;
        }
    }
}
