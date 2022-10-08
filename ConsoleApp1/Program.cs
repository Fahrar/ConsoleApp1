using System;

char character = 'A';
bool condition = false;
byte number4 = 255;
short number3 = 32767;
int number1 = 2147483647;
long number2 = 9223372036854775807;
double number5 = 4.5;
decimal number6 = 15.4m;

Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Karakteriniz {0}",(int)character);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
if (number4==255678)
{
    Console.WriteLine("İkiyüzellibeş");
}
else
{
    Console.WriteLine("Hata");
}
Console.ReadLine();