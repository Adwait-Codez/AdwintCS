using System;

namespace AdwintCS.DataStru
{
    class MLPLayer
    {
        int inlen;
        float[] Biases;
        float[,] Matrice;
        MLPLayer(int inputs,int length)
        {
            inlen = inputs;
            Biases = new float[length];
            Matrice = new float[inputs, length];
            Console.Write(Matrice);
        }
    }
}
