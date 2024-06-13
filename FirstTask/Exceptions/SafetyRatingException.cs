using System.Runtime.Serialization;

namespace VehicleRentalSystem.Exceptions
{
    [Serializable]
    internal class SafetyRatingException : Exception
    {
        public SafetyRatingException()
        {
            
        }

        public SafetyRatingException(string? message) : base(message)
        {
            
        }

        public SafetyRatingException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SafetyRatingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}