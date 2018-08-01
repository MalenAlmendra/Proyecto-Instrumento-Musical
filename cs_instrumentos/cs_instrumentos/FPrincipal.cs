/*Author:
 programa:
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Libreria_instrumento;

namespace cs_instrumentos
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        #region Variables Globales

        public double precio_1;
        public double precio_2;

        public int icodigo;
        public string snombre;
        public string smarca;
        public string stipo;
        public int iunidades;
        public double dprecio;
        public bool bafinado;
        public int inroCuerdas;
        public string smaterial;

        //Crea una instancia de la clase coleccion de la librería
        Coleccion funcion = new Coleccion();

        //Crea una nueva instancia de formulario Agregar
        FAgregar agregar = new FAgregar();
        #endregion

        //Métodos del programa

        private void FPrincipal_Load(object sender, EventArgs e) //Carga del Formulario Principal
        {
            lInstrumento.Items.Clear();
            mtDesde.Text = "";
            mtHasta.Text = "";
            CargarListBox();
        }
        
        #region MENU

        private void vientoToolStripMenuItem_Click(object sender, EventArgs e) //Instrumento de Viento
        {

            Viento actual=new Viento();
            //Le pasa el parametro viento al formulario Agregar.
            agregar.tipo = "viento";
            agregar.actualizando = false;

            //Se piden los valores al formulario agregar
            if (agregar.ShowDialog() == DialogResult.OK)
            {
                
                icodigo = agregar.codigo;
                snombre = agregar.nombre;
                smarca = agregar.marca;
                iunidades = agregar.unidades;
                dprecio = agregar.precio;
                smaterial = agregar.material;
                stipo = "viento";
                actual = new Viento(icodigo, snombre, stipo, smarca, dprecio, iunidades, smaterial);
                
                //llamar a la funcion agregar de la librería
                funcion.Agregar(actual);

                //Limpia las variables
                icodigo = 0; 
                snombre = "";
                smarca = "";
                iunidades = 0;
                dprecio = 0;
                smaterial = "";
                stipo = "";
                //Recargue la lista Automáticamente
                lInstrumento.Items.Add(actual.ToString());

                //****Bandera****
                int contar = funcion.ContarElementos();
                MessageBox.Show("El objeto agregado es " + actual._nombre + " de la marca" + actual._marca +
                                "\nLa cantidad de elementos en la lista es de " + contar);
            }
           
            

        }

        private void cuerdaToolStripMenuItem_Click(object sender, EventArgs e) //Instrumento de Cuerda
        {

            Cuerda actual=new Cuerda();
            agregar.actualizando = false;
            agregar.tipo = "cuerda";

            agregar.nombre = "";
            agregar.marca = "";
            agregar.unidades = 0;
            agregar.precio = 0000.00;
            agregar.nroCuerda = 4;

            if (agregar.ShowDialog() == DialogResult.OK)
            {

                icodigo = agregar.codigo;
                snombre = agregar.nombre;
                smarca = agregar.marca;
                iunidades = agregar.unidades;
                dprecio = agregar.precio;
                inroCuerdas = agregar.nroCuerda;
                stipo = "cuerda";
                actual = new Cuerda(icodigo, snombre, stipo, smarca, dprecio,iunidades, inroCuerdas);

                //llamar a la funcion agregar de la librería
                funcion.Agregar(actual);
               
                //Limpia las variables
                icodigo = 0;
                snombre = "";
                smarca = "";
                iunidades = 0;
                dprecio = 0;
                inroCuerdas = 0;
                stipo = "";

                //Recargue la lista Automaticamente
                lInstrumento.Items.Add(actual.ToString());
            }
        }

        private void percuciónToolStripMenuItem_Click(object sender, EventArgs e) //Instrumento de Percución
        {
            Percucion actual;
            agregar.tipo = "percución";
            if (agregar.ShowDialog() == DialogResult.OK)
            {

                icodigo = agregar.codigo;
                snombre = agregar.nombre;
                smarca = agregar.marca;
                iunidades = agregar.unidades;
                dprecio = agregar.precio;
                bafinado = agregar.afinado;
                stipo = "percución";
                actual = new Percucion(icodigo, snombre, stipo, smarca, dprecio,iunidades, bafinado);

                //llamar a la funcion agregar de la librería
                funcion.Agregar(actual);

                //Limpia las variables
                icodigo = 0;
                snombre = "";
                smarca = "";
                iunidades = 0;
                dprecio = 0;
                bafinado = false;
                stipo = "";

                //Recargue la lista Automaticamente
                lInstrumento.Items.Add(actual.ToString());
            }
        }


        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Filtros

        //<-------------------------RADIOBUTTONS------------------------------->

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lInstrumento.Items.Clear();
            //Variable local
            int contar;

            Instrumento otro = new Instrumento();
            contar = funcion.ContarElementos();
            for (int i = 0; i < contar; i++)
            {
                otro = funcion.BuscarPorPosicion(i);
                lInstrumento.Items.Add(otro.ToString());
            }
        }

        private void rbViento_CheckedChanged(object sender, EventArgs e)
        {
            lInstrumento.Items.Clear();
            //Variable local
            int contar;
            Instrumento encontrado;
            Viento otro=new Viento(); 
            contar = funcion.ContarElementos();
            for (int i=0; i < contar; i++) {
                encontrado = funcion.BuscarPorPosicion(i);
                if (encontrado.GetType()==typeof(Viento))
                {
                    otro = (Viento) encontrado;
                    lInstrumento.Items.Add(otro.ToString());
                }              
            }
        }

        private void rbCuerda_CheckedChanged(object sender, EventArgs e)
        {
            lInstrumento.Items.Clear();
            //Variable local
            int contar;
            Instrumento encontrado;
            Cuerda otro = new Cuerda();
            contar = funcion.ContarElementos();
            for (int i = 0; i < contar; i++)
            {
                encontrado = funcion.BuscarPorPosicion(i);
                if (encontrado.GetType()==typeof(Cuerda))
                {
                    otro = (Cuerda)encontrado;
                    lInstrumento.Items.Add(otro.ToString());
                }
            }
        }

        private void rbPercucion_CheckedChanged(object sender, EventArgs e)
        {
            lInstrumento.Items.Clear();
            //Variable local
            int contar;
            Instrumento encontrado;
            Percucion otro = new Percucion();
            contar = funcion.ContarElementos();
            for (int i = 0; i < contar; i++)
            {
                encontrado = funcion.BuscarPorPosicion(i);
                if (encontrado.GetType() == typeof(Percucion))
                {
                    otro = (Percucion)encontrado;
                    lInstrumento.Items.Add(otro.ToString());
                }
            }
        }

        //<---------------------FILTRO POR PRECIO-------------------------->
        private void bFiltrar_Click(object sender, EventArgs e)
        {
            lInstrumento.Items.Clear();

            precio_1 = Convert.ToDouble(mtDesde.Text);
            precio_2 = Convert.ToDouble(mtHasta.Text);

            int contar;
            contar = funcion.ContarElementos();
            Instrumento obj2 = new Instrumento();
            for (int i = 0; i < contar; i++)
            {
                obj2 = funcion.BuscarPorPosicion(i);
                if(obj2._precio>=precio_1 && obj2._precio<=precio_2)
                    lInstrumento.Items.Add(obj2.ToString());
            }
        }

        private void bLimpiarFiltro_Click(object sender, EventArgs e)
        {
            lInstrumento.Items.Clear();
            mtDesde.Text = "";
            mtHasta.Text = "";

            //Vuelve a cargar todos los elementos al listbox
            lInstrumento.Items.Clear();
            CargarListBox();
        }

        #endregion

        #region Metodos Auxiliares y Verificaciones

        private void Limpiar()
        {
            lInstrumento.Items.Clear();
            mtDesde.Text = "";
            mtHasta.Text = "";
        }

        private int extraerCodigo(String palabra) 
        {
            bool encontrado = false;
            string codigo = "";
            int i = 0;
            int tamano = palabra.Length;
            while (i < tamano && !encontrado)
            {
                if (palabra[i] == ' ') encontrado = true;
                codigo = codigo + palabra[i];
                i++;
            }
            int numero = Convert.ToInt32(codigo);
            return numero;
        }
        public void CargarListBox()
        {
            for (int i=0; i<funcion.ContarElementos();i++)
            {
                lInstrumento.Items.Add(funcion.BuscarPorPosicion(i));
            }
        }

        #endregion

        #region BOTONES

        private void bModificarInstrumento_Click(object sender, EventArgs e)
        {
            if (lInstrumento.SelectedIndex == -1) MessageBox.Show("No se ha seleccionado ningun item de la lista.\nPor favor seleccione el instrumento a modificar.", "Se ha producido un error");
            else
            {
                //Se crea la instancia del formulario y la del instrumento
                FAgregar mostrar = new FAgregar();
                Instrumento encontrado;
                Viento encontradoViento =new Viento();
                Cuerda encontradoCuerda = new Cuerda();
                Percucion encontradoPercucion = new Percucion() ;

                //Asigno la variable
                string palabra = lInstrumento.SelectedItem.ToString();

                //Llamo al método que extrae el código para buscar el objeto
                int objCodigo = extraerCodigo(palabra);

                //Manda a buscar el Instrumento y se lo asigna a Encontrado
                encontrado = funcion.Buscar(objCodigo);
                if (encontrado.GetType() == typeof(Viento)) encontradoViento = (Viento)encontrado;
                else if (encontrado.GetType() == typeof(Cuerda)) encontradoCuerda = (Cuerda)encontrado;
                else if (encontrado.GetType() == typeof(Percucion)) encontradoPercucion = (Percucion)encontrado;

                //Llamo al formulario y le asigno las variables del objeto encontrado.
                mostrar.actualizando = true;
                mostrar.tipo = encontrado._tipo;
                mostrar.codigo = encontrado._codigo;
                mostrar.marca = encontrado._marca;
                mostrar.nombre = encontrado._nombre;
                mostrar.precio = encontrado._precio;
                mostrar.unidades = encontrado._unidades;


                if (encontrado.GetType()==typeof(Viento)) mostrar.material = encontradoViento._material;
                else if (encontrado.GetType() == typeof(Cuerda)) mostrar.nroCuerda = encontradoCuerda._nroCuerdas;
                else if (encontrado.GetType() == typeof(Percucion)) mostrar.afinado = encontradoPercucion._afinado;

                if (mostrar.ShowDialog() == DialogResult.OK)
                {
                    //CARGAR LO QUE VIENE DEL FORMULARIO "AGREGAR" EN LAS VARIABLES DE ESTE FORMULARIO (Globales)

                    icodigo = mostrar.codigo;
                    snombre = mostrar.nombre;
                    smarca = mostrar.marca;
                    iunidades = mostrar.unidades;
                    dprecio = mostrar.precio;
                    stipo = mostrar.tipo;

                    //LLAMAR A UN MÉTODO QUE MODIFIQUE AL INSTRUMENTO ENCONTRADO CON TODAS LAS VARIABLES ANTERIORES
                    if (stipo == "viento")
                    {
                        smaterial = mostrar.material;
                        encontradoViento = new Viento(icodigo, snombre, stipo, smarca, dprecio, iunidades, smaterial);
                        funcion.ModificarInstrumento(encontradoViento);
                    }
                    else if (stipo == "cuerda")
                    {
                        inroCuerdas = mostrar.nroCuerda;
                        encontradoCuerda = new Cuerda(icodigo, snombre, stipo, smarca, dprecio, iunidades, inroCuerdas);
                        funcion.ModificarInstrumento(encontradoCuerda);

                    }
                    else if (stipo == "percución")
                    {
                        bafinado = mostrar.afinado;
                        encontradoPercucion = new Percucion(icodigo,snombre,stipo,smarca,dprecio,iunidades,bafinado);
                        funcion.ModificarInstrumento(encontradoPercucion);
                    }

                    //LIMPIAR TODO
                    icodigo = 0;
                    snombre = " ";
                    smarca = " ";
                    iunidades = 0;
                    dprecio = 0f;
                    smaterial = " ";
                    inroCuerdas = 0;
                    bafinado = false;
                    stipo = " ";
                }
            }
        }

        private void bEliminarInstrumento_Click(object sender, EventArgs e)
        {
            if (lInstrumento.SelectedIndex == -1) MessageBox.Show("No se ha seleccionado ningún item de la lista. \nPor favor, seleccione el instrumento a eliminar.","Se ha producido un error");
            else
            {
                int tamanoPalabra = lInstrumento.SelectedItem.ToString().Length;
                string palabra = lInstrumento.SelectedItem.ToString();
                int objCodigo = extraerCodigo(palabra);
                funcion.Eliminar(objCodigo);
                lInstrumento.Items.Remove(lInstrumento.SelectedItem);
                MessageBox.Show(palabra);
                MessageBox.Show("Quedan " + funcion.ContarElementos() + " instrumentos en la lista"); //banderita
            }
            
        }
        #endregion

        #region VERIFICACIONES
        #endregion

    }
}
