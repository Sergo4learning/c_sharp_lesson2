// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int input_num (string text)
{
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int second_num (int num)
{
    int res = 0;
    res = (num /10)%10;
    return res;
}
void output_num (int num, string text)
{
    Console.WriteLine(text + num);
}

int number = input_num ("Введите число:");
if (number>10)
{
    output_num (second_num(number), "Вторая цифра равна ");   
}
else 
{
    Console.WriteLine("Вторая цифра отсутствует");
};

