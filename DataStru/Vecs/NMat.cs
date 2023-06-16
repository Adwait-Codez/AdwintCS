//Copyright AdwaitCreationz

using System;

namespace AdwintCS.DataStru.Math
{
    public struct NMat
    {
        NVec[] Vecs;
        int Mlen; //length of Vecs array
        
        public NMat(int Vlen, int Mlen)
        {
            this.Mlen = Mlen;
            Vecs = new NVec[Mlen];
            for (int i = 0; i < Mlen; i++)
            {
                Vecs[i] = new NVec(Vlen);
            }
        }

        public NMat(int Usize)
        {
            this.Mlen = Usize;
            Vecs = new NVec[Usize];
            for (int i = 0; i < Usize; i++)
            {
                Vecs[i] = new NVec(Usize);
            }
        }

        public static NVec operator *(NVec lhs, NMat rhs)
        {
            if(lhs.len != rhs.Mlen)
            {
                throw new ArithmeticException("Dimentionalities do not match");
            }
            NVec ret = new NVec(lhs.len);
            for (int i = 0; i < lhs.len; i++)
            {
                ret += lhs.ValVec[i] * rhs.Vecs[i];
            }
            return ret;
        }

        public static NMat operator *(float lhs, NMat rhs)
        {
            NMat ret = rhs;
            for(int i = 0; i < rhs.Mlen; i++)
            {
                ret.Vecs[i] *= lhs;
            }
            return ret;
        }

        public void Random()
        {
            for(int i = 0;i < Mlen; i++)
            {
                Vecs[i].Random();
            }
        }
    }
}