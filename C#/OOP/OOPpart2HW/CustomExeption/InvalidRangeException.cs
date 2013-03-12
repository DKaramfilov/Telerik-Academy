using System;
using System.Linq;


namespace CustomExeption
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        private T start;
        private T end;
       

        public InvalidRangeException() { }
        public InvalidRangeException(string msg, T start, T end) : this(msg, start, end, DateTime.Now, "Unknown") { }
        public InvalidRangeException(string msg,T start,T end,DateTime timeStamp,string couseOfError) 
        {
            messageDetails = msg;
            this.start = start;
            this.end = end;
            ErrorTimeStamp = timeStamp;
            CauseOfError = couseOfError;
        }

   
        public override string Message
        {
            get
            {
                return string.Format("Invalid range error : {0}\nValue out of range[{1} .. {2}].", messageDetails,start ,end);
            }
        }
    }
}
