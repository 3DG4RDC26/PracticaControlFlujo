using Evaluacion1.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion1
{
    //Programa que almacena los nombres de 25 estudiantes e imprime los que tengan mas de 35 caracteres
    public partial class Form1 : Form
    {
        StudentsNames studentsNames = new StudentsNames();
        public Form1()
        {
            InitializeComponent();
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                studentsNames.AddName(tbName.Text);
                tbName.Clear();
                MessageBox.Show("Nombre agregado.");  //Enviamos un mensaje de ventana
                                                      //confirmandole al usuario que se agrego el nombre
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lstNames.Items.Clear();
            var longNames = studentsNames.GetLongNames();
            foreach (var name in longNames)
            {
                lstNames.Items.Add(name);
            }
        }
    }
}
