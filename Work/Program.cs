//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
//меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
//исключительно массивами.
//Примеры:
//["hello", ""2", "world", ":-)"] -> ["2", ":-)"]
//["1234", "1567", "-2", "computer science"] -> ["-2"]
//["Russia", "Denmark", "Kazan"] -> [[]]


//Метод для создания массива.

string[] CreatStringArray(int sizeArr)
{
string[] arr = new string[sizeArr];
for(int i =0;i<sizeArr;i++)
{
  Console.Write($"Веедите строку {i+1} ->")  ;
arr[i] = Console.ReadLine();
}
return arr;
}

//Метод для печати массива.

void PrintStringArray(string[] arr)
{
Console.Write("[ ");
for(int i =0;i<arr.Length;i++)
{
   if(i ==arr.Length-1)
   { 
   Console.Write(@$"""{arr[i]}""");
   }
   else
   {
    Console.Write(@$"""{arr[i]}"",");
   }
}
Console.Write(" ]");

}



//Метод для подсчета количества строк меньше или равное 3 символам в массиве.
int CountingCharArray(string[]arr)
{
int count =0;
for(int i =0;i<arr.Length;i++)
{
    if(arr[i].Length<=3) count++;
}
return  count;
}

//Метод для формирования из массива строк в массив строк, из строк чье количество символов больше или равно 3.
string[] CreatArrayShortString(String[]arr,int sizeResArr)
{
int count = 0;
string[] resArr = new string[sizeResArr];
for(int i = 0;i<arr.Length;i++)
{
if(arr[i].Length<=3)
{
    resArr[count]=arr[i];
    count++;
}
}
return resArr;
}
Console.Write("Введите какое количество строк вы хотите ввести  -> ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreatStringArray(size);
PrintStringArray(array);
int sizeResultArray = CountingCharArray(array);
string[]ResultArray=CreatArrayShortString(array,sizeResultArray);
Console.Write("->");
PrintStringArray(ResultArray);
