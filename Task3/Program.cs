// *Немного усложнил задачу 
// Создаем автозавполняемый рандомными числами массив, и потом второй который заполняется только макс и мин значениями
// из первого массива, при чем в рандомной последовательности.
 void FillArray(int[]massive)
 {
    int dlm = massive.Length;
    int i = 0;
    while (i<dlm)
    {
        massive[i] = new Random().Next(0,1000);
        i++;
    }
 }
void PrintArray(int[]massivchik)
{
    int dlina = massivchik.Length;
    int index = 0;
    while(index<dlina)
    {
        Console.WriteLine(massivchik[index]);
        index++;
    }
}

int[]array = new int[20];

FillArray(array);

int maxim = -1;
int minim = 1000;
int c = 0;
int len = array.Length;
while(c<len)
{
    if(array[c]<minim)
    {
        minim = array[c];
        c++;
    }
    else if(array[c]>maxim)
    {    maxim = array[c];
         c++;
    }     
    else
    {
        c++;
    }    
}

int[]array2 = new int[10];
int index = 0;
int result = new Random().Next(0,2);
while(index<10)
{
    //array2[index] = maxim || minim;
    if(result == 0)
        array2[index] = maxim;
    else
    {
        array2[index] = minim;
    }
    index++;
    result = new Random().Next(0,2);
}

Console.WriteLine(minim);
Console.WriteLine(maxim);

PrintArray(array2);
