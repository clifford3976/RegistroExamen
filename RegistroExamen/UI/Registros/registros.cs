using RegistroExamen.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroExamen.UI.Registros
{
    public partial class registros : Form
    {
        public registros()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(DescripcionrichTextBox.Text))
            {
                errorProvider1.SetError(DescripcionrichTextBox, "llena el campo de descripcion");
                return false;
            }
            if (string.IsNullOrEmpty(CantidadnumericUpDown.ToString()))
            {
                errorProvider1.SetError(CantidadnumericUpDown, "llena el campo de cantidad");
                return false;
            }
            if (string.IsNullOrEmpty(GrupoIdnumericUpDown.ToString()))
            {
                errorProvider1.SetError(GrupoIdnumericUpDown, "llenar el campo de grupos");
                return false;
            }
            if(string.IsNullOrEmpty(gruposnumericUpDown.ToString()))
                {
                errorProvider1.SetError(gruposnumericUpDown, "llenar el campo de grupos");
                return false;
            }
        
            return true;
        }

        private Grupos LLenaClase()
        {
            Grupos Grupo = new Grupos();
            Grupo.GrupoId = Convert.ToInt32(GrupoIdnumericUpDown.Value);
            Grupo.Fecha = FechadateTimePicker.Value;
            Grupo.Descripcion = DescripcionrichTextBox.Text;
            Grupo.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            Grupo.grupos= Convert.ToInt32(gruposnumericUpDown.Value);
            Grupo.Integrantes = IntegrantestextBox.Text;

            return Grupo;
        }

        private void registros_Load(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            GrupoIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            DescripcionrichTextBox.Clear();
            CantidadnumericUpDown.Value = 0;
            gruposnumericUpDown.Value = 0;
            IntegrantestextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if(!Validar())
            {
                MessageBox.Show("llena", "trate de guardar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Grupos Grupo = LLenaClase();
                bool paso = false;

                if(GrupoIdnumericUpDown.Value == 0)
                {
                    paso = BLL.GruposBLL.Guardar(Grupo);
                }
                else
                {
                    paso = BLL.GruposBLL.Modificar(Grupo);
                }

                if(paso)
                {
                    MessageBox.Show("guardado", "acceptado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(GrupoIdnumericUpDown.Value);
            if (BLL.GruposBLL.Eliminar(id))
                MessageBox.Show("eliminado", "exitosamente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GrupoIdnumericUpDown.Value);
            Grupos Grupo = BLL.GruposBLL.Buscar(id);

           if(Grupo != null)
            {
                FechadateTimePicker.Value = Grupo.Fecha;
                DescripcionrichTextBox.Text = Grupo.Descripcion;
                CantidadnumericUpDown.Value = Grupo.Cantidad;
                gruposnumericUpDown.Value = Grupo.grupos;
                IntegrantestextBox.Text = Grupo.Integrantes;
            }
           else
            {
                MessageBox.Show("no encontro", "buscar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
