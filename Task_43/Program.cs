// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
System.Console.Clear();
string to_input_var(string input_text)
{
    Console.Write($"Введите переменную {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}

string[] str_arr = new string[4] { "k1", "b1", "k2", "b2", };
string input_text;
double[] arr = new double[4];
double x,y;

for (int i = 0; i < 4; i++)
{
    input_text = str_arr[i];
    arr[i] = double.Parse(to_input_var(input_text));
}

x=(arr[3]-arr[1])/(arr[0]-arr[2]);
y=arr[0]*x+arr[1];
Console.WriteLine($"Точкой пересечения прямых является ({x};{y}) ");