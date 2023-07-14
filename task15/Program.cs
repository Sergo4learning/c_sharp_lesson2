// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int input_num (string text)
{
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}
string weekend (int num)
{
    string res = "Нет";
    if (num>5)
    {
        res = "Да";
    };    
    return res;
}

int number = input_num ("Введите номер дня недели:");
if (number>0 & number<8)
{
    Console.WriteLine(weekend(number));   
}
else 
{
    Console.WriteLine("Введённое число не соответствует ни одному дню недели.");
};
