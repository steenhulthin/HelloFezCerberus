using Microsoft.SPOT;
using GT = Gadgeteer;

namespace HelloFezCerberus
{
    public partial class Program
    {
        //start with debug led off.
        private bool _isDebugLedOn = false;
        // This method is run when the mainboard is powered up or reset.   
        void ProgramStarted()
        {
            Debug.Print("Program Started");

            var timer = new GT.Timer(500);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(GT.Timer timer)
        {
            Mainboard.SetDebugLED(_isDebugLedOn);
            _isDebugLedOn = !_isDebugLedOn;
        }
    }
}
