// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

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

int number = input_num ("Введите трёхзначное число:");
if (number>99 & number<1000)
{
    output_num (second_num(number), "Вторая цыфра равна ");   
}
else 
{
    Console.WriteLine("Вы ввели не трёхзначное число!");
};
