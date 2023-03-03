/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам.*/ 

string[] ArrayUser;
Console.WriteLine("Введите массив строк через запятую");
string stroka = (Console.ReadLine()!);
ArrayUser = stroka.Split(',');


void PrintArray(string[] ArrayUser, string[] ArrayResul)
{
  int count = 0;
  int max = 3;
  for (int i = 0; i < ArrayUser.Length; i++)
    {
      if(ArrayUser[i].Length <= max)
        {
        ArrayResul[count] = ArrayUser[i];
        count++;
        }
    }
}
void NewArray(string[] array)
{
    for (int i = 3; i < array.Length; i++)
      {
        Console.Write($"{array[i]} ");
        
      }
}
string[] ArrayResult = new string[ArrayUser.Length];
PrintArray(ArrayUser, ArrayResult);
NewArray(ArrayResult);


