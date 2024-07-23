// See https://aka.ms/new-console-template for more information

int num1;
int num2;
char cond;
int num3;


Console.WriteLine("Calculadora");
//num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Num1");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("num2");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("condição");
cond = Convert.ToChar(Console.ReadLine());

if(cond == '+')
{
    num3 = num1 + num2;
}else if (cond == '.')
{
    num3 = num1 - num2;
}else if (cond == '*')
{
    
}

