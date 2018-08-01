using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria_instrumento
{
    public class Instrumento
    {
        //Atributos
        private int codigo;
        private string nombre;
        private string tipo;
        private string marca;
        private double precio;
        private int unidades;

        //Propiedades
        public int _codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string _nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string _tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string _marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public double _precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int _unidades
        {
            get { return unidades; }
            set { unidades = value; }
        }

        //Constructores
        public Instrumento()
        {
            codigo = 0;
            nombre = "";
            tipo = "";
            marca = "";
            precio = 0;
        }
        public Instrumento(int codigo, string nombre, string tipo, string marca, double precio, int unidades)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.tipo = tipo;
            this.marca = marca;
            this.precio = precio;
            this.unidades = unidades;
        }
        //Métodos
        //ToString
        public override string ToString()
        {
            return this._codigo + " - " + this._nombre + " " + this._marca + " - $" + this._precio;
        }
        //Equals
        public override bool Equals(Object obj)
        {
            if (obj == null) return this == null;
            else if (this.GetType() != obj.GetType()) return false;
            else {
                Instrumento I = (Instrumento)obj;
                return (_codigo == I._codigo);
            }
        }
    }

    public class Viento : Instrumento
       {
        //Atributos
        private string material;

        //Propiedades
        public string _material
        {
            get { return material; }
            set { material = value; }
        }
        //Constructores
        public Viento() : base()
        {
            material = "";
        }
        public Viento(int _codigo, string _nombre, string _tipo, string _marca, double _precio,int _unidades, string mat) : base(_codigo, _nombre, _tipo, _marca, _precio,_unidades)
        {
            material = mat;
        }
        //Métodos
        public override string ToString()
        {
            return base.ToString()+" - "+_material;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null) return this == null;
            else if (this.GetType() != obj.GetType()) return false;
            else
            {
                Viento I = (Viento)obj;
                return (_codigo == I._codigo);
            }
        }
    }

        public class Cuerda : Instrumento
        {
            //Atributos
            private int nroCuerdas;

            //Propiedades
            public int _nroCuerdas
            {
                get { return nroCuerdas; }
                set { nroCuerdas = value; }
            }
            //Constructores
            public Cuerda() : base()
            {
                nroCuerdas = 0;
            }
            public Cuerda(int _codigo, string _nombre, string _tipo, string _marca, double _precio,int _unidades, int nro) : base(_codigo, _nombre, _tipo, _marca, _precio,_unidades)
            {
                nroCuerdas = nro;
            }
            //Métodos
            public override string ToString()
            {
                return base.ToString() + " - " +_nroCuerdas+" cuerdas";
            }
            public override bool Equals(Object obj)
            {
                if (obj == null) return this == null;
                else if (this.GetType() != obj.GetType()) return false;
                else
                {
                    Cuerda I = (Cuerda)obj;
                    return (_codigo == I._codigo);
                }
        }
    }

        public class Percucion : Instrumento
        {
            //Atributos
            private bool afinado;

            //Propiedades
            public bool _afinado
            {
                get { return afinado; }
                set { afinado = value; }
            }

            //Constructores
            public Percucion() : base()
            {
                afinado = false;
            }

            public Percucion(int _codigo, string _nombre, string _tipo, string _marca, double _precio,int _unidades, bool af) : base(_codigo, _nombre, _tipo, _marca, _precio, _unidades)
            {
                afinado = af;
            }

        //Métodos
            public override string ToString()
            {
                if (_afinado == true) return base.ToString() + " - " + "Afinado";
                else return base.ToString() + " - " + "No Afinado";
                
            }

            public override bool Equals(Object obj)
            {
                if (obj == null) return this == null;
                else if (this.GetType() != obj.GetType()) return false;
                else
                {
                    Percucion I = (Percucion)obj;
                    return (_codigo == I._codigo);
                }
            }
        }

        public class Coleccion
        {
            private List<Instrumento> Lista = new List<Instrumento>();

            //Métodos

            public void Agregar(Instrumento obj)
            {
                Lista.Add(obj);
            }

            public int ContarElementos()
            {
                return (Lista.Count());
            }

            //Buscar con sobrecarga
            public Instrumento Buscar(string tipo)
            {
                Instrumento actual = new Instrumento();
                foreach (Instrumento inst in Lista)
                {
                    if (inst._tipo == tipo) { actual = inst; }
                    else actual = new Instrumento();
                }
                return actual;
            }

            public Instrumento Buscar(int cod)
            {
                Instrumento actual = new Instrumento();
                foreach (Instrumento inst in Lista)
                {
                    if (inst._codigo == cod) { actual = inst; }
                }
                return actual;
            }

            public Instrumento Buscar(int posicion, double precioDesde, double precioHasta)
            {
                Instrumento obj = new Instrumento();
                if ((Lista[posicion]._precio >= precioDesde) && (Lista[posicion]._precio <= precioHasta))
                    obj = Lista[posicion];
                return obj;
            }

            public Instrumento BuscarPorPosicion(int pos)
            {
                return (Lista[pos]);
            }

        /*Método Modificar*/

        public void ModificarInstrumento(Viento obj)
        {
            if (obj.GetType() == typeof(Viento))
                foreach (Viento vi in Lista)
                {
                    if (obj._codigo == vi._codigo)
                    {
                        vi._nombre = obj._nombre;
                        vi._marca = obj._marca;
                        vi._precio = obj._precio;
                        vi._tipo = obj._tipo;
                        vi._unidades = obj._unidades;
                        vi._material = obj._material;
                    }
                }         
        }

        public void ModificarInstrumento(Cuerda obj)
        {
            if (obj.GetType() == typeof(Cuerda))
                foreach (Cuerda vi in Lista)
                {
                    if (obj._codigo == vi._codigo)
                    {
                        vi._nombre = obj._nombre;
                        vi._marca = obj._marca;
                        vi._precio = obj._precio;
                        vi._tipo = obj._tipo;
                        vi._unidades = obj._unidades;
                        vi._nroCuerdas = obj._nroCuerdas;
                    }
                }
        }
        public void ModificarInstrumento(Percucion obj)
        {
            foreach (Percucion vi in Lista)
            {
                if (obj._codigo == vi._codigo)
                {
                    vi._nombre = obj._nombre;
                    vi._marca = obj._marca;
                    vi._precio = obj._precio;
                    vi._tipo = obj._tipo;
                    vi._unidades = obj._unidades;
                }
            }
        }

            public void Eliminar(Instrumento obj)
            {
                Lista.Remove(obj);
            }

          
            public void Eliminar(int codigo)
            {
                Lista.Remove(Buscar(codigo));        
            }
        }
    }
