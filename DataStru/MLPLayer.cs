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

        /// <summary>
        /// Returns The Calculated response of this layer as a float array.
        /// </summary>
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
            return outbuffer;
        }

        /// <summary>
        /// Initialize Random Values for the biases.
        /// </summary>
        /// <param name="Min">Minimum Value for the biases to be set</param>
        /// <param name="Max">Maximum Value for the biases to be set</param>
        public void SetRandomBiases(float Min,float Max)
        {
            for(int i = 0; i < Biases.Length; i++)
            {
                var RNG = new Random();
                Biases[i] = Min + (float)(RNG.NextDouble() * (Max - Min));
            }
        }

        /// <summary>
        /// Initialize Random Values for the elements of the Matrix.
        /// </summary>
        /// <param name="Min">Minimum Value for the Matrix elements to be set</param>
        /// <param name="Max">Maximum Value for the Matrix elements to be set</param>
        public void SetRandomMatrix(float Min, float Max)
        {
            var RNG = new Random();
            for (int i = 0; i < inlen; i++)
            {
                for (int j = 0; j < Biases.Length; j++)
                {
                    Matrice[i, j] = Min + (float)(RNG.NextDouble() * (Max - Min));
                }
            }
        }

        /// <summary>
        /// Make Random Changes to the Layer Computations.
        /// </summary>
        /// <param name="delta">The Maximum Possible Change to any layer Parameter</param>
        public void ChangeRandom(float delta)
        {
            var RNG = new Random();
            for (int i = 0; i < Biases.Length; i++)
            {
                Biases[i] += (float)(RNG.NextDouble() * delta);
            }
            for (int i = 0; i < inlen; i++)
            {
                for (int j = 0; j < Biases.Length; j++)
                {
                    Matrice[i, j] += (float)(RNG.NextDouble() * delta);
                }
            }
        }
    }
}
