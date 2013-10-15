using System;
using System.Collections;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Controls;
using Microsoft.SPOT.Presentation.Media;
using Microsoft.SPOT.Presentation.Shapes;
using Microsoft.SPOT.Touch;

using Gadgeteer.Networking;
using GT = Gadgeteer;
using GTM = Gadgeteer.Modules;
using Gadgeteer.Modules.GHIElectronics;

namespace HelloFezCerberus
{
    public partial class Program
    {
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
