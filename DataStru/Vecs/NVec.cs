//Copyright AdwaitCreationz

using System;

namespace AdwintCS.DataStru.Math 
{ 
    public struct NVec {
        public int len;
        public float[] ValVec;

        public NVec(int len)
        {
            this.len = len;
            this.ValVec = new float[len];
        }

        public static NVec mult(float a, NVec b)
        {
            NVec ret = new NVec(b.len);
            for (int i = 0; i < b.len; i++)
            {
                ret.ValVec[i] = a * b.ValVec[i];
            }
            return ret;
        }

        public static NVec operator *(float a, NVec b)
        {
            return mult(a, b);
        }

        public static NVec operator *(NVec a,float b)
        {
            return mult(b, a);
        }

        public static NVec operator +(NVec a, NVec b)
        {
            if(a.len != b.len)
            {
                throw new ArithmeticException("The Dimentions of the two Vectors must match!");
            }
            NVec ret = new NVec(a.len);
            for (int i = 0; i<a.len;i++)
            {
                ret.ValVec[i] = a.ValVec[i] + b.ValVec[i];
            }
            return ret;
        }

        public void Random()
        {
            Random rng = new Random();
            for (int i = 0;i< len;i++)
            {
                ValVec[i] = (float)rng.NextDouble();
            }
        }
    }
}