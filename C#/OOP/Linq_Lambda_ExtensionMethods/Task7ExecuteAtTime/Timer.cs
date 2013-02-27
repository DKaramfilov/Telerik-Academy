using System;
using System.Timers;

namespace Task7ExecuteAtTime
{
    public class MethodTimer 
    {        
        public delegate void MethodToExecute();

        public MethodToExecute currentMethods;
        private Timer aTimer;
       
        public MethodTimer()
        {
            aTimer = new Timer(10000);                      
        }
        public void Start(int miliseconds)
        {

            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = miliseconds;
            aTimer.Enabled = true;
        }
        public  void OnTimedEvent(object sourse, ElapsedEventArgs e)
        {
            currentMethods();
        }
    }
}
