using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Búsquedas_binarias
{
    class Vector
    {
        private int[] vector;
        public int comparaciones { get; private set; }

        public Vector(int size)
        {
            vector = new int[size];
        }

        public void Fill(int limit)
        {
            Random random = new Random();
            for (int i = 0; i < vector.Length; i++)
                vector[i] = random.Next(0, limit);
             }

        public void Sort()
        {
            Array.Sort(vector);
        }

        public override string ToString()
        {
            string result = "";
            int i = 0;
            foreach (int dato in vector)
                result += "[" + i++.ToString() + "] = " + dato.ToString() + Environment.NewLine;
            return result;
        }

        public int Search(int dato)
        {
            comparaciones = 0;
            int lowerLimit = 0;
            int upperLimit = vector.Length - 1;
            int middle = (int)Math.Floor((double)upperLimit / 2);
            while (upperLimit - lowerLimit > 1)
            {
                if (dato < vector[middle])
                {
                    upperLimit = middle;
                    middle = (int)Math.Floor((double)(upperLimit - lowerLimit) / 2) + lowerLimit;
                    comparaciones++;
                }
                else if (dato > vector[middle])
                {
                    lowerLimit = middle;
                    middle = (int)Math.Floor((double)(upperLimit - lowerLimit) / 2) + lowerLimit;
                    comparaciones++;
                }
                else if (dato == vector[middle])
                {
                    comparaciones++;
                    return vector[middle];
                }
                else if (dato == vector[lowerLimit])
                {
                    comparaciones++;
                    return vector[lowerLimit];
                }
                else if (dato == vector[upperLimit])
                {
                    comparaciones++;
                    return vector[upperLimit];
                }
            }
            return -1;
        }

        public int GetComparaciones()
        {
            return comparaciones;
        }
    }
}