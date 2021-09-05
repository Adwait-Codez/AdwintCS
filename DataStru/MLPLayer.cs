//Copyright AdwaitCreationz
using System;

namespace AdwintCS.DataStru
{
    public class MLPLayer
    {
        readonly int inlen;
        public float[] Biases;
        public float[,] Matrice;

        /// <summary>
        /// A singular Layer Of MLP Bot.
        /// </summary>
        public MLPLayer(int inputs,int length)
        {
            inlen = inputs;
            Biases = new float[length];
            Matrice = new float[inputs, length];
        }

        public float[] Compute(float[] input)
        {
            float[] outbuffer = new float[Biases.Length];
            for(int i = 0; i < inlen; i++)
            {
                float gg = 0f;
                for(int j = 0; j < Biases.Length; j++)
                {
                    gg += Matrice[i, j] * input[j];
                }
                gg += Biases[i];
                outbuffer[i] = gg;
            }
            return new outbuffer;
        }
    }
}
