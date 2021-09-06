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
        /// Creates A Multilayer Percepetron with the given depth , height and inputs.
        /// Note: high Depth/Height Values may effect Performance.
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
        /// Returns The Bot's response to given Input as 
        /// </summary>
        public float[] Compute(float[] input)
        {
            return new float[7];
        }
    }
}
