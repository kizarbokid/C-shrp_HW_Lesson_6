// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
System.Console.Clear();

System.Console.WriteLine("Введите число и нажмите Enter или введите 'Q' чтобы выйти: ");
string n = "0";
int count = 0;

while (n.ToLower() != "q") 
{
    n = System.Console.ReadLine();

    if (int.TryParse(n, out int result)) //ловим, число ли ввел пользователь?
    {
        if (int.Parse(n) > 0) //Да-->прирастить счетчик
        {
            count++;
        }
    }
}


System.Console.Write($"Количество введенных чисел больше нуля = {count}");