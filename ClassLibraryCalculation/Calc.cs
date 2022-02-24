namespace ClassLibraryCalculation
{
    public class Calc<T> where T : struct, IComparable
    {
        public T Add(T a, T b)
        {
            if (typeof(T) == typeof(int))
            {
                int num1 = (int)Convert.ChangeType(a, typeof(int));
                int num2 = (int)Convert.ChangeType(b, typeof(int));
                int c = num1 + num2;
                return (T)Convert.ChangeType(c, typeof(T));
            }else if (typeof(T) == typeof(double))
            {
                double num1 = (double)Convert.ChangeType(a, typeof(double));
                double num2 = (double)Convert.ChangeType(b, typeof(double));
                double c = num1 + num2;
                return (T)Convert.ChangeType(c, typeof(T));
            }
            return default;

        }

        public bool IsEqual(T a, T b)
        {
            if( a.CompareTo(b) == 0 )
            {
                return true;
            }else
            {
                return false;   
            }
        }

    }
/*
    public class Calc2<T>
    {
        public T add( T a, T b)
        {
            return a + b; 
        }
    }
*/
}