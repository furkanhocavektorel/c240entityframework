

using System.Numerics;

namespace Generic
{
    internal class Islem<T,Y> 
        where T : struct,INumber<T>
        where Y : struct,INumber<Y>
    {
         
        public T toplama(T a, T b)
        {
            return a + b;
        }

        public T cikartma(T a, T b)
        {
            return a - b;
        }

        public T carpma(T a, T b)
        {
            return a * b;
        }

        public Y bolme(T a, T b)
        {
            return a / b;
        }


    }
}
