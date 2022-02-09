namespace Generics
{
    public class Nullable<T> where T : struct
    {
        private readonly object _value;

        // value type doesnot have null value 
        // but we try to get the null value using this generic : struct concept

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }

}
