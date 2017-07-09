using System;

namespace DriveFitnessLibrary
{
    public class RemoveGroupException : Exception
    {
        public string MessageRemoveGroupException { get; private set; }

        public RemoveGroupException(string text)
        {
            MessageRemoveGroupException = text;
        }
    }
}
