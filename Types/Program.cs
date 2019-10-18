﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool alive = true;

            //хранит целое число от 0 до 255 и занимает 1 байт. Представлен системным типом System.Byte
            byte bit1 = 1;

            //хранит целое число от -128 до 127 и занимает 1 байт. Представлен системным типом System.SByte
            sbyte bit2 = -101;

            //хранит целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16
            short n1 = 1;

            //хранит целое число от 0 до 65535 и занимает 2 байта. Представлен системным типом System.UInt16
            ushort n2 = 1;

            //хранит целое число от -2147483648 до 2147483647 и занимает 4 байта. Представлен системным типом System.Int32. 
            int a = 10;

            //хранит целое число от 0 до 4294967295 и занимает 4 байта. Представлен системным типом System.UInt32
            uint a1 = 10;

            //хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт. Представлен системным типом System.Int64
            long a2 = -10;

            //хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт. Представлен системным типом System.UInt64
            ulong c = 0xFF;

            //хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта. Представлен системным типом System.Single
            float f1 = 3.14F;

            //хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт.
            //Представлен системным типом System.Decimal
            decimal c2 = 1005.8M;

            //хранит одиночный символ в кодировке Unicode и занимает 2 байта. Представлен системным типом System.Char. 
            char a3 = 'A';

            //хранит набор символов Unicode. Представлен системным типом System.String. Этому типу соответствуют символьные литералы.
            string hello = "Hello";

            //может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе.
            //Представлен системным типом System.Object, который является базовым для всех других типов и классов .NET.
            object c1 = "hello code";

            //Для CLR тип dynamic идентичен типу object. Однако компилятор С# позволяет переменным типа dynamic участвовать в динамическом
            //разрешении типа с упрощенным синтаксисом.
            dynamic c3 = "hello code";

            Console.WriteLine(c.ToString());
            Thread.Sleep(50000);




        }
    }
}
