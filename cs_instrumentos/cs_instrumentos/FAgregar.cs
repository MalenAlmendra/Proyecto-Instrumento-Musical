using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs_instrumentos
{
    public partial class FAgregar : Form
    {
        public FAgregar()
        {
            InitializeComponent();
        }
        //Variables del formulario
        public int codigo;
        public string tipo;
        public string nombre;
        public string marca;
        public int unidades;
        public double precio;
        public bool afinado;
        public int nroCuerda;
        public string material;
        public bool actualizando;

        //Métodos principales del programa
        private void FAgregar_Load(object sender, EventArgs e) //Carga del Formulario Agregar
        {
            //ACTUALIZACIÓN DE OBJETO
            if (actualizando)
            {
                mtCodigo.Text = Convert.ToString(codigo);
                if (tipo == "viento")
                {
                    cbViento.Visible = true;
                    gbMaterial.Visible = true;
                    rbMadera.Visible = true;
                    rbMetal.Visible = true;
                    tipo = "viento";
                }
                else if (tipo == "cuerda")
                {
                    EnroCuerdas.Visible = true;
                    cbCuerda.Visible = true;
                    nudCuerdas.Visible = true;
                    nudCuerdas.Value = nroCuerda;
                    tipo = "cuerda";
                }
                else if (tipo == "percución")
                {
                    cbPercucion.Visible = true;
                    checkAfinado.Visible = true;
                    checkAfinado.Checked = afinado;
                    tipo = "percución";
                }
                tMarca.Text = marca;
                nudUnidades.Value = unidades;
                mtPrecio.Text = Convert.ToString(precio);
                actualizando = false;
            }
            //CREACIÓN DE OBJETO
            else
            {            
                mtCodigo.Text = GenerarCodigo(Convert.ToString(codigo));
                if (tipo == "viento")
                {
                    cbViento.Visible = true;
                    gbMaterial.Visible = true;
                    rbMadera.Visible = true;
                    rbMetal.Visible = true;
                    cbViento.Text = nombre;
                    if (material == "Metal") rbMetal.Checked = true;
                    else if (material == "Madera") rbMadera.Checked = true;
                }
                else if (tipo == "cuerda")
                {
                    EnroCuerdas.Visible = true;
                    cbCuerda.Visible = true;
                    cbCuerda.Text = nombre;
                    nudCuerdas.Visible = true;
                    nroCuerda = 4;
                    nudCuerdas.Value = nroCuerda;
                }
                else if (tipo == "percución")
                {
                    cbPercucion.Visible = true;
                    checkAfinado.Visible = true;
                    cbPercucion.Text = nombre;
                    if (afinado) checkAfinado.Checked = true;
                }
            }
                                      
        }

        #region BOTONES
        private void bAgregar_Click(object sender, EventArgs e) //Botón Agregar            
        {
            if (Verificacion())
            {
                codigo = Convert.ToInt32(mtCodigo.Text);

                if (cbCuerda.Visible == true)
                    nombre = cbCuerda.SelectedItem.ToString();
                else if (cbViento.Visible == true)
                    nombre = cbViento.SelectedItem.ToString();
                else
                    nombre = cbPercucion.SelectedItem.ToString();

                marca = tMarca.Text;

                unidades = Convert.ToInt32(nudUnidades.Value);

                String pre = String.Format("{0:c2}", mtPrecio.Text);
                precio = Convert.ToDouble(pre);

                if (checkAfinado.Visible == true)
                    if (checkAfinado.Checked == true)
                        afinado = true;
                    else
                        afinado = false;

                if (nudCuerdas.Visible == true)
                    nroCuerda = Convert.ToInt32(nudCuerdas.Value);

                if (rbMadera.Visible == true && rbMetal.Visible == true)
                    if (rbMadera.Checked)
                        material = "Madera";
                    else if (rbMetal.Checked)
                        material = "Metal";
                
           }
                MessageBox.Show("Los elementos enviados son " + nombre + " marca " + marca + " codigo " + codigo);//Banderita
                LimpiarCampos();
           
        }

        private void bCancelar_Click(object sender, EventArgs e) //Botón Cancelar
        {
            cbViento.Visible = false;
            gbMaterial.Visible = false;
            rbMadera.Visible = false;
            rbMetal.Visible = false;
            EnroCuerdas.Visible = false;
            cbCuerda.Visible = false;
            nudCuerdas.Visible = false;
            cbPercucion.Visible = false;
            checkAfinado.Visible = false;
            Close();
        }
        #endregion

        #region METODOS AUXILIARES
        private void LimpiarCampos() {
            cbCuerda.Text = "Seleccionar...";
            cbViento.Text = "Seleccionar...";
            cbPercucion.Text = "Seleccionar...";
            cbViento.Visible = false;
            cbCuerda.Visible = false;
            cbPercucion.Visible = false;
            checkAfinado.Visible = false;
            nudCuerdas.Visible = false;
            EnroCuerdas.Visible = false;
            gbMaterial.Visible = false;
            tMarca.Text = "";
            nudUnidades.Value = 0;
            mtPrecio.Text = "";
        }

        private string GenerarCodigo(string codigo)
        {
            int nroCambiado; string generado;
            nroCambiado = Convert.ToInt32(codigo);
            nroCambiado += 1;
            generado = String.Format("{0}", nroCambiado);
            return generado;
        }

        #endregion

        #region VERIFICACIONES
        //VERIFICACION DE CAMPOS
        private bool Verificacion()
        {
            bool todoOk=true;
            if (tipo == "viento")
            {
                if (cbViento.Text == " " || (rbMadera.Checked == false && rbMetal.Checked == false))
                {
                    MessageBox.Show("Falta seleccionar alguno de los campos");
                    cbViento.Focus();
                    todoOk = false;
                }
            }
            else if (tipo == "cuerda")
            {
                if (cbCuerda.Text == " " || nudCuerdas.Value == 0)
                {
                    MessageBox.Show("Falta seleccionar alguno de los campos");
                    cbCuerda.Focus();
                    todoOk = false;
                }
            }
            else if (tipo == "percución")
            {
                if (cbPercucion.Text == " ")
                {
                    MessageBox.Show("Falta seleccionar alguno de los campos");
                    cbPercucion.Focus();
                    todoOk = false;
                }
            }
            else if (tMarca.Text == " ")
            {

                MessageBox.Show("Falta completar el campo Marca");
                tMarca.Focus();
                todoOk = false;
            }

            else if (nudUnidades.Value == 0)
            {

                MessageBox.Show("Falta completar el campo Cantidad de Unidades");
                nudUnidades.Focus();
                todoOk = false;
            }
            else if (mtPrecio.Text == " ")
            {

                MessageBox.Show("Falta completar el campo Precio");
                mtPrecio.Focus();
                todoOk = false;
            } 
            
            return todoOk;
        }

        //ERROR PROVIDERS
        private void tMarca_Validating(object sender, CancelEventArgs e)
        {
            errorProviderMarca.Clear();
            if (tMarca.Text == " ") errorProviderMarca.SetError(tMarca, "Debe ingresar la marca del Instrumento");
        }
        #endregion
    }
}
