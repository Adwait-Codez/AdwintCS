//Copyright AdwaitCreationz
using System;

namespace AdwintCS.DataStru
{
    public class MLPLayer
    {
        int inlen;
        float[] Biases;
        float[,] Matrice;

        /// <summary>
        /// A singular Layer Of MLP Bot.
        /// </summary>
        public MLPLayer(int inputs,int length)
        {
            inlen = inputs;
            Biases = new float[length];
            Matrice = new float[inputs, length];
            Console.Write(Matrice.Length);
        }

        public float[] Compute()
        {
            return new float[7];
        }
    }
}
