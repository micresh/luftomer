using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.IO.Ports;

namespace ROTCHAK_Luft
{
    class sensors
    {
        public static string indata;
        private static bool ConnOpen(string ports) 
        {
            
                SerialPort port = new SerialPort(ports, 115200, Parity.None,8,StopBits.One);
                port.ReadTimeout = 500;
                port.WriteTimeout = 500;
                try
                {
                    port.Open();
                }
                catch
                {
                    return false;
                }
                    
            return true;
        }
        public static string[] PortList() // Здесь мы получаем все подключенные СОМ-порты
        {
            string[] portnames = SerialPort.GetPortNames();

            return portnames;
        }

        public static string ReadString(string ports)
        {
            SerialPort port = new SerialPort(ports, 115200, Parity.None, 8, StopBits.One);
            port.ReadTimeout = 1000;
            port.WriteTimeout = 1500;
            string s1="";
            if (port.IsOpen)
            {

                s1 = port.ReadLine();
            }
            else
            {
                port.Open();
                try
                {
                    s1 = port.ReadLine();
                }
                catch (TimeoutException)
                { }
            }
            return s1;
        }
        public static byte[] ReadData(SerialPort port,int start, int values)
        {
            byte[] buffer = new byte[values];
            //SerialPort port = new SerialPort(ports, 115200, Parity.None, 8, StopBits.One);
            
            port.ReadTimeout = 1500;
            port.WriteTimeout = 1500;
            if (port.IsOpen)
            {

                port.Read(buffer, 0, start);
                port.Close();
            }
            else
            {
                port.Open();
                try
                {
                    port.Read(buffer, 0, start);
                    port.Close();
                }
                catch (TimeoutException)
                {
                    buffer = null;
                    port.Close();
                }
            }
            return buffer;
        }
        public static bool WriteData(byte[] buff,SerialPort port)
        {
          //  SerialPort port = new SerialPort(ports, 115200, Parity.None, 8, StopBits.One);
          //  port.ReadTimeout = 1500;
          //  port.WriteTimeout = 1500;
            if (port.IsOpen)
            {
                try
                {
                    port.Write(buff, 0, 8);
                    port.Close();
                    return true;
                }
                catch
                {
                    port.Close();
                    return false;
                }
            }
            else
            {
                try
                {
                    port.Open();
                    port.Write(buff, 0, 8);
                    port.Close();
                }
                catch
                {
                    buff = null;
                    return false;
                }
                return true;
            }
         }
        
    }
}
