using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace ROTCHAK_Luft
{
    class sensors
    {
        private static bool ConnOpen(string ports) // в этой процедуре мы проверяем БПП это или не БПП
        {
            
                SerialPort port = new SerialPort(ports, 115200, Parity.None,8,StopBits.One);
                port.ReadTimeout = 500;
                port.WriteTimeout = 500;
                try
                {
                    port.Open();
                    byte[] comm = { 170, 1, 0, 0, 0, 1, 0, 4, 0 };
                    port.Write(comm, 0, comm.Length);
                    byte[] answ = new byte[9];
                    port.Read(answ, 0, answ.Length);
                    if ((answ[7] == 1) && (answ[7] == 1))
                    {
                        port.Close();
                        return true;
                    }
                }
                catch
                {
                    port.Close();
                    return false;
                }
            return false;
        }
        private static string[] PortList() // Здесь мы получаем все подключенные СОМ-порты
        {
            string[] portnames = SerialPort.GetPortNames();

            return portnames;
        }
        public static string GetBPPportname() // здесь мы берем имя порта, с которым мы будем работать (к которому подключено БПП)
        {
            string[] ports = PortList();
        for (int i = 0; i < ports.Length; i++)
            {                
                if (ConnOpen(ports[i]))
                {
                    return ports[i];
                }
                }
        return "nothing";
        }
    }
}
