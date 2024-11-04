using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBankIO;

    partial class Program 
    {
        static void UsarStreamDeEntrada()
        {
            using(var fluxoDeEntrada = Console.OpenStandardInput())
            {
                var buffer = new byte[1024];
                var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                Console.WriteLine($"Bytes Lidos na console: {bytesLidos}");
            }
        }
    }
    