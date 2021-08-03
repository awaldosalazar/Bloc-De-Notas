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

namespace Bloc_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reiniciarSinArchivo();
            textBoxCoincidiente.ReadOnly = true;
            textBoxPosicion.ReadOnly = true;
        }
        /*VARIIABLES GLOBALES*/
        //Metodo busqueda
        string text = new string(new char[1000]);
        string pat = new string(new char[1000]);
        /*-------------------*/
        string ruta = null;
        public void reiniciarSinArchivo()
        {
            richTextBoxTexto.Text = "";
            ruta = null;
            labelArchivoAbierto.Text = "En espera de archivo";
            pictureBoxEstado.BackColor = Color.Red;
            buttonGuardar.Enabled = false;
            buttonGuardarComo.Enabled = false;
            buttonCerrar.Enabled = false;
            buttonBusqueda.Enabled = false;
            buttonSiguiente.Enabled = false;
            checkBoxMayusculas.Enabled = false;
            checkBoxMayusculas.Enabled = false;
            richTextBoxTexto.ReadOnly = true;
            textBoxBusqueda.ReadOnly = true;
            textBoxBusqueda.Text = "Buscar en el texto";
        }//reinicia si no hay archivo

        public void archivoAbierto()
        {
            //Muestra que hay un archivo abierto al usuario
            labelArchivoAbierto.Text = "Archivo Abierto";
            pictureBoxEstado.BackColor = Color.Green;
            buttonGuardar.Enabled = true;
            buttonGuardarComo.Enabled = true;
            buttonCerrar.Enabled = true;
            buttonBusqueda.Enabled = true;
            checkBoxMayusculas.Enabled = true;
            richTextBoxTexto.ReadOnly = false; //prueba
            textBoxBusqueda.ReadOnly = false;
        }//Cambio al abrir un archivo

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            bool band = true;
            if (ruta != null)
            {
                DialogResult result = MessageBox.Show("Hay un archivo abierto, se perderan los cambios \n ¿Deseas Continuar?", this.Text, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    reiniciarSinArchivo();
                    band = true;
                }
                else
                {
                    band = false;
                }

            }

            if (band == true)
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Documento de texto|*.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        // Code to write the stream goes here.
                        myStream.Close();
                        ruta = saveFileDialog1.FileName;
                        richTextBoxTexto.Text = System.IO.File.ReadAllText(ruta);
                    }
                }

                archivoAbierto();
            }
        }//Boton nuevo
        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.ShowDialog();
            ruta = abrir.FileName;           
            richTextBoxTexto.Text = System.IO.File.ReadAllText(ruta);
            archivoAbierto();
        }//Boton Abrir

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ruta != null)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas guardar?", this.Text, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)

                {
                    System.IO.File.WriteAllText(ruta, richTextBoxTexto.Text);
                }
            }
        }//Boton Guardar

        private void buttonGuardarComo_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Documento de texto|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    ruta = saveFileDialog1.FileName;
                    System.IO.File.WriteAllText(ruta, richTextBoxTexto.Text);
                }
            }
        }//Boton Guardar Como

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            reiniciarSinArchivo();
        }//Boton Cerrar


        /*
         [*EXPLICACION*]
         SE CREA UNA TABLA CON LA CADENA A BUSCAR EN LA CUAL SE TOMARA UNA OCURRENCIA DE CADA CARACTER Y SE PONE EN LA TABLA DEJANDO UNA COLUMNA MAS PARA UN
         CARACTER X QUE ENCONTREMOS QUE NO ESTE EN LA TABLA, POR EJEMPLO SI BUSCASMO LA PALABARA [PARAR] LA TABLA QUEDARIA ASI:
         [D1|P|A|R|OTROS]
         [  |4|3|2|5    ] 
         EJEMPLO:
         CADENA DONDE SE BUSCARA: PEROCOMODEBOPARARESTO
         PERO[C] OMOD[E] BO[PARAR]ESTO
         PARA[R]
                 PARA[R]
                         PA[RAR  ]
                           [PARAR] Y Se encontro la solución correcta y el algoritmo devolvera la posicion 12 que es donde encontro la coincidencia
        el algoritmo se basa en bucar incoicidencias para crear la coincidencia.
             */
        public static int[] busquedaStringBayerMoore(string cadenaDondeSeBuscara, string palabraABuscar)
        {
            List<int> retVal = new List<int>();
            int m = palabraABuscar.Length;
            int n = cadenaDondeSeBuscara.Length;

            int[] tablaDeCaracteres = new int[256];


            tablaAComparar(palabraABuscar, m, ref tablaDeCaracteres);

            int s = 0;
            while (s <= (n - m))
            {
                int j = m - 1;

                while (j >= 0 && palabraABuscar[j] == cadenaDondeSeBuscara[s + j])
                    --j;
                //Se va alineado con la tabla y se procede recusivamente hasta encontrar una coincidencia y esto se hace hasta que la palabra a buscar junto con la cadena 
                //de algun numero negativo dando a entender que se paso y ya no hay mas posibilidades de busqueda
                if (j < 0)
                {
                    retVal.Add(s);
                    s += (s + m < n) ? m - tablaDeCaracteres[cadenaDondeSeBuscara[s + m]] : 1;
                }
                else
                {
                    s += Math.Max(1, j - tablaDeCaracteres[cadenaDondeSeBuscara[s + j]]);
                }
            }
            return retVal.ToArray();
        }//Algoritmo de busqueda de string

        private static void tablaAComparar(string str, int size, ref int[] badChar)
        {
            int i;
            for (i = 0; i < 256; i++)
                badChar[i] = -1;
            for (i = 0; i < size; i++)
                badChar[(int)str[i]] = i;
        }//Crea la tabla con la cual se espaciaran los caracteres

        int posicion = 0, cantidad = 0;
        int[] value;
        private void buttonBusqueda_Click(object sender, EventArgs e)
        {
            regresarBusqueda();

            if (checkBoxMayusculas.Checked == false)
            {
                value = busquedaStringBayerMoore(richTextBoxTexto.Text, textBoxBusqueda.Text);
                    labelCantidadPalabras.Text = "Palabras encontradas: " + value.Length.ToString();
                    cantidad = value.Length;
                    if (cantidad > 0)
                    {
                        labelPalabraActual.Text = "Palabra : " + (posicion + 1).ToString() + "de" + cantidad.ToString();
                        subrayadoTexto(value[0], textBoxBusqueda.Text.Length);

                        convertirTexto(value[0], textBoxBusqueda.Text.Length);
                        textBoxPosicion.Text = value[0].ToString();
                        if (cantidad > 1)
                        {
                            buttonSiguiente.Enabled = true;
                            posicion++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron coincidencias","[*ATENCION*]");
                    }
            }
            else //Si lee mayusculas iguala el texto para poder reconocerlo
            {
                value = busquedaStringBayerMoore(richTextBoxTexto.Text.ToLower(), textBoxBusqueda.Text);
                labelCantidadPalabras.Text = "Palabras encontradas: " + value.Length.ToString();
                cantidad = value.Length;
                if (cantidad > 0)
                {
                    convertirTexto(value[0], textBoxBusqueda.Text.Length);
                    textBoxPosicion.Text = value[0].ToString();
                    labelPalabraActual.Text = "Palabra : " + (posicion+1).ToString() + "de" + cantidad.ToString();
                    subrayadoTexto(value[0], textBoxBusqueda.Text.Length);
                    if (cantidad > 1)
                    {
                        buttonSiguiente.Enabled = true;
                        posicion++;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias", "[*ATENCION*]");
                }
            }
        }//Boton Buscar
        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (cantidad != posicion)
            {                
                convertirTexto(value[posicion], textBoxBusqueda.Text.Length);
                textBoxPosicion.Text = value[posicion].ToString();                
                posicion++;
                labelPalabraActual.Text = "Palabra : " + posicion.ToString() + "de" + cantidad.ToString();
                regresaSubrayadoTexto();
                subrayadoTexto(value[posicion-1],textBoxBusqueda.Text.Length);
            }
            else
            {
                MessageBox.Show("No hay mas coincidencia");
                regresarBusqueda();
            }
        }//Boton Buscar Siguiente

        public void convertirTexto(int inicio,int tamano)
        {
            textBoxCoincidiente.Text = richTextBoxTexto.Text.Substring(inicio, tamano);
        }
        private void textBoxBusqueda_Enter(object sender, EventArgs e)
        {

            textBoxBusqueda.Clear();
            regresarBusqueda();
        }
        
        public void regresarBusqueda()
        {
            if (cantidad != 0)
                ultimoSubrayadoTexto();
            textBoxCoincidiente.Text = "Palabras coincidientes";
            textBoxPosicion.Text = "Posicion";
            labelCantidadPalabras.Text = "Palabras encontradas: ";
            buttonSiguiente.Enabled = false;
            labelPalabraActual.Text = "Palabra : - de -";
            posicion = 0;
        }//Reinicia la busqueda si es que el usuario quiere hacer una nueva o ya termino con la actual

        public void subrayadoTexto(int inicio,int tamano)
        {
            this.richTextBoxTexto.Select(inicio, tamano);          
            this.richTextBoxTexto.SelectionColor = Color.Red;
            richTextBoxTexto.SelectionFont = new Font("Consolas", 20f);
            this.richTextBoxTexto.Refresh();
        }
        public void regresaSubrayadoTexto()
        {
            this.richTextBoxTexto.SelectionColor = Color.Blue;
            richTextBoxTexto.SelectionFont = new Font("Microsoft Sans Serif", 8f);
            this.richTextBoxTexto.Refresh();
        }

        public void ultimoSubrayadoTexto()
        {
            this.richTextBoxTexto.Select(0, richTextBoxTexto.Text.Length);
            this.richTextBoxTexto.SelectionColor = Color.Black;
            richTextBoxTexto.SelectionFont = new Font("Microsoft Sans Serif", 8f);
            this.richTextBoxTexto.Select(posicion, 0);
            this.richTextBoxTexto.Refresh();
        }
    }
}