using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    class ClsArreglos
    {
        private int [] Arreglotemporal;
        private int[] Datos;
        
        private int TamanoArreglo = 0;

        public int GetTamanoArreglo()
        {
            return Datos.Length;
        }

        

        public ClsArreglos(int[] ArregloParametro)
        {
            Datos = ArregloParametro;
            TamanoArreglo = Datos.Length;
        }

        public int[] MetodoBurbuja()
        {
            Arreglotemporal = Datos;
            for (i = 0; i < TamanoArreglo - 1; i++ )
            {
                for(j=i+1; j<TamanoArreglo; j++)
                {
                    if(Arreglotemporal[i]> Arreglotemporal[j])
                    {
                        Dato = Arreglotemporal[i];
                        Arreglotemporal[i] = Arreglotemporal[j];
                        Arreglotemporal[j] = Dato;
                    }
                }
            }
            return Arreglotemporal;
        }

   
        private string[] Arreglo1;
        private string[] Datos1;
        private string DatosTemporal;
        private int i, j, Dato;

        public ClsArreglos (string[] arreglos)
        {
            Datos1 = arreglos;
            TamanoArreglo = Datos1.Length; 
        }

        public string[] BurjubaOrden() 
        {
            Arreglo1 = Datos1;

            for (i = 0; i<TamanoArreglo -1; i++)
            {
                for (j = i +1; j < TamanoArreglo; j++ )
                {
                    if (Arreglo1[i].CompareTo(Arreglo1[j])>0) 
                    {

                        DatosTemporal = Arreglo1[i];
                        Arreglo1[i] = Arreglo1[j];
                        Arreglo1[j] = DatosTemporal;

                    }
                }
            }

            return Arreglo1; 
        }
    }
}