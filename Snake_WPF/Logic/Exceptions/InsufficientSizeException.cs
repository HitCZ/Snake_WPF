using System;

namespace Snake_WPF.Logic.Exceptions
{
    public class InsufficientSizeException : Exception
    {
        public InsufficientSizeException(string parameterName, double minimum) 
            : base ($"Size of {parameterName} is too low. The minimum is {minimum}")
        {
        }
    }
}
