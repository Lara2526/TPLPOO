using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Categoria
    {
        private int cat_ID;

        public int Cat_ID
        {
            get { return cat_ID; }
            set { cat_ID = value; }
        }
        private string cat_Nombre;

        public string Cat_Nombre
        {
            get { return cat_Nombre; }
            set { cat_Nombre = value; }
        }
        private string cat_Descripcion;

        public string Cat_Descripcion
        {
            get { return cat_Descripcion; }
            set { cat_Descripcion = value; }
        }
        public Categoria(int id, string nombre, string descripcion)
        {
            this.cat_ID = id;
            this.cat_Nombre = nombre;
            this.cat_Descripcion = descripcion;
        }

        public Categoria()
        {
            
        }

        public Competencia Competencia
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
