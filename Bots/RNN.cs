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
        NMat Mat;
        public RNN(int Nurons)
        {
            nuno = Nurons;
            activations = new NVec(Nurons);
            Mat = new NMat(Nurons);
        }

        public void compute()
        {
            activations = activations * Mat + bias;
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
