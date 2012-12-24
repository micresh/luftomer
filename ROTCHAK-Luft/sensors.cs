using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace ROTCHAK_Luft
{
    class sensors
    {
        public static bool ConnOpen(int port)
        {

            return true;
        }
        public static string[] PortList()
        {
            string[] portnames = SerialPort.GetPortNames();

            return portnames;
        }
    }
}
