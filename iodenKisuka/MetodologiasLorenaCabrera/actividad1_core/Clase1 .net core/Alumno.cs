﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Alumno : Persona
    {
        int legajo;
        int promedio;
        public int GetLegajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public int GetPromedio
        {
            get { return promedio; }
            set { promedio = value; }
        }

        public Alumno(string n, int d, int l, int p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }
        public Alumno() { }

        public override string ToString()
        {
            return base.ToString() + " legajo " + this.legajo;
        }

        /** public override bool SosMayor(IComparableP variable)
         {
             return this.legajo < ((Alumno)variable).legajo;
         }

         public override bool SosMenor(IComparableP variable)
         {
             return this.legajo < ((Alumno)variable).legajo;
         } **/

       public IEstrategia_Comparar_Alumno Estrategia_elegida{ get; set; }
        
        //delegar las acciones
        public void Comparar_Alumnos(string tipo_de_dato)
        {
            //return this.Estrategia_elegida.SosIgual(this, comparable);


        }


    }
}
