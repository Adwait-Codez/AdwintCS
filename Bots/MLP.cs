﻿//Copyright AdwaitCreationz



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
            float[] Output = input;
            for(int i = 0; i < layers.Length; i++)
            {
                Output = layers[i].Compute(Output);
            }
            return Output;
        }

        /// <summary>
        /// Initialize Random Values for the elements of the Matricies of the layers.
        /// </summary>
        /// <param name="Min">Minimum Value for the Matrix elements to be set</param>
        /// <param name="Max">Maximum Value for the Matrix elements to be set</param>
        public void SetRandomMatrix(float Min, float Max)
        {
            for (int i = 0; i < layers.Length; i++)
            {
                layers[i].SetRandomMatrix(Min, Max);
            }
        }

        public void SetRandomBiases(float Min, float Max)
        {
            for (int i = 0; i < layers.Length; i++)
            {
                layers[i].SetRandomBiases(Min, Max);
            }
        }
    }
}
