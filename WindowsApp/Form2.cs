using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            decimal maxNota = Convert.ToDecimal(txtNota1.Text), suma = 0, promedio;
            int cont = 0;
            string result = "result";   

            List<decimal> nota = new List<decimal>();
            nota.Add(Convert.ToDecimal(txtNota1.Text));
            nota.Add(Convert.ToDecimal(txtNota2.Text));
            nota.Add(Convert.ToDecimal(txtNota3.Text));
            nota.Add(Convert.ToDecimal(txtNota4.Text));

            /* Podría guardarse cada variable de manera individual y en vez de un foreach o un for, escribir un if anidado para calcular el mayor valor,
            pero es menos eficiente
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal nota4 = Convert.ToDecimal(txtNota4.Text);*/

            foreach (decimal n in nota)
            {
                if(n > maxNota)
                    maxNota = n;
                cont++;
                suma += n;
            }
            promedio = suma/cont;

            // si las notas se tomaran con valor de enteros (int) podría realizarse un switch
            if (promedio >= 9)
                result = "Excelente";
            else if (promedio >= 7)
                result = "Muy bien";
            else if (promedio >= 4)
                result = "Regular";
            else
               result = "En proceso de aprendizaje";

            MessageBox.Show("Mayor nota: " + maxNota + "\nPromedio: " + promedio + "\n\n" + result,"Calificacion");
        }

            
    }
}
