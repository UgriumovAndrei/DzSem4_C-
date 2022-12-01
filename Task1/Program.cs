//  цикл  , где мы вводим 2 числа , второе - степень первого.

int n1  = 1;
int n2  = 1;
while(n1 != 0 && n2 != 0)
{    
    Console.WriteLine("Введите число и степень; если хотите прервать программу введите оба числа нули");
    n1 = Convert.ToInt32(Console.ReadLine());
    n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{n1}^{n2}={Math.Pow(n1, n2)}");
}