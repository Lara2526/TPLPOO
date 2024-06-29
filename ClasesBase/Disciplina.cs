using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Disciplina
    {
        private int dis_ID;

        public int Dis_ID
        {
            get { return dis_ID; }
            set { dis_ID = value; }
        }
        private string dis_Nombre;

        public string Dis_Nombre
        {
            get { return dis_Nombre; }
            set { dis_Nombre = value; }
        }
        private string dis_Descripcion;

        public string Dis_Descripcion
        {
            get { return dis_Descripcion; }
            set { dis_Descripcion = value; }
        }
        public Disciplina(int id, string nombre, string descripcion)
        {
            this.dis_ID = id;
            this.dis_Nombre = nombre;
            this.dis_Descripcion = descripcion;
        }

        public Disciplina()
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
