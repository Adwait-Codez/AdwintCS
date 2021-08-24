using System;

namespace AdwintCS.DataStru
{
    class MLPLayer
    {
        int inlen;
        float[] Biases;
        MLPLayer(int inputs,int length)
        {
            inlen = inputs;
            Biases = new float[length];
        }
    }
}
