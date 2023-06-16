//Copyright AdwaitCreationz

using System;
using AdwintCS.DataStru.Math;

namespace AdwintCS.Bots
{
    public class RNN
    {
        int nuno;
        NVec activations;
        NVec bias;
        NMat Matrix;
        
        public RNN(int Nurons)
        {
            nuno = Nurons;
            activations = new NVec(Nurons);
            bias = new NVec(Nurons);
            Matrix = new NMat(Nurons);
        }

        public void Random()
        {
            bias.Random();
            Matrix.Random();
        }

        public void compute()
        {
            activations = activations * Matrix + bias;
        }

        public void Input(NVec Inputs)
        {
            for(int i = 0;i<Inputs.len;i++)
            {
                activations.ValVec[i] = Inputs.ValVec[i];
            }
        }
    }
}
