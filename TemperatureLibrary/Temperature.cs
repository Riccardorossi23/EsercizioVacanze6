using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureLibrary
{
    public class Temperature
    {
        public static bool IsSottoZero(int n)
        {
            bool valore;
            if (n < 0)
            {
                valore = true;
            }
            else
            {
                valore = false;
            }
               
            return valore;
        }

        public static int ContaSottoZero(int[]array)
        {
            int valore = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    valore++;
                }
                   
            }
            return valore;
        }

        public static int[] Minime(int[]array)
        {
            List <int> negativi = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativi.Add(array[i]);
                }
                    
            }
            int[]valore = new int[negativi.Count];

            for (int i = 0; i < valore.Length; i++)
            {
                valore[i] = negativi[i];
            }
            return valore;
        }

    }
}
    