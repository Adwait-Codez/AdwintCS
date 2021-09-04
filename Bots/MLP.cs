//Copyright AdwaitCreationz
using System;
using AdwintCS.DataStru;

namespace AdwintCS.Bots
{
    public class MLP
    {
        MLPLayer[] layers;
        int Height;
        
        /// <summary>
        /// Creates A Multilayer Percepetron with the given depth , height and inputs
        /// </summary>
        public MLP(int Depth,int height,int inputs)
        {
            layers = new MLPLayer[Depth];
            Height = height;
            for(int i = 0; i < Depth; i++)
            {
                if (i == 0)
                {
                    layers[i] = new MLPLayer(inputs, height);
                }
                else
                {
                    layers[i] = new MLPLayer(height, height);
                }
                
            }
        }

        /// <summary>
        /// Returns The Bot's response to given Input.
        /// </summary>
        public float[] Compute()
        {
            return new float[7];
        }
    }
}
