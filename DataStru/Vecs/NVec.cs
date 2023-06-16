//Copyright AdwaitCreationz

using System;

namespace AdwintCS.DataStru.Math 
{ 
    public struct NVec {
        public int len {
            get { return ValVec.Length; }
        }
        public float[] ValVec;

        public NVec(int len)
        {
            this.ValVec = new float[len];
        }

        public NVec(float[] lol)
        {
            this.ValVec = lol;
        }

        public float this[int key]
        {
            get
            {
                return this.ValVec[key];
            }
            set
            {
                this.ValVec[key] = value;
            }
        }

        public static NVec mult(float a, NVec b)
        {
            NVec ret = new NVec(b.len);
            for (int i = 0; i < b.len; i++)
            {
                ret[i] = a * b[i];
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
                ret[i] = a[i] + b[i];
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

        public void zero()
        {
            for (int i = 0;i < len; i++)
            {
                ValVec[i] = 0;
            }
        }
    }
}