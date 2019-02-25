using System;

namespace PadawansTask10
{
    public static class NullableTypeExtensions
    {
        public static bool IsNull(this object variable)
        {
            if (variable==null)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
            throw new OutOfMemoryException();
            throw new Exception();
        }
    }
}
