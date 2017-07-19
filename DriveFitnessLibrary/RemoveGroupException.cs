using System;

namespace DriveFitnessLibrary
{
    public class RemoveGroupException : Exception
    {
        public RemoveGroupException() : base() { }

        public RemoveGroupException(string text) : base(text) { }
        public RemoveGroupException(string text, Exception inner) : base(text, inner) { }
        protected RemoveGroupException(System.Runtime.Serialization.SerializationInfo si,
            System.Runtime.Serialization.StreamingContext sc) : base(si, sc) { }
        public override string ToString()
        {
            return Message;
        }
    }
}
