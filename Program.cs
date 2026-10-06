// int totalExercises = 1;

// for (int number = 8; number >= totalExercises; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }

// Console.WriteLine("Домашнее задание готово");

// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }

// int totalWeeks = 3;
// string smile = "^_^";

// for (int week = 1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");

//     }
//     Console.WriteLine("^_^");
// }
// int count = 0;
// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)

//     {
//         count++;
//         continue;
//     }


//     Console.WriteLine($"Первый доступный билет: {ticket}, количество пропущенных билетов: {count}");
//     break;
// }


// int N = Convert.ToInt32(Console.ReadLine());

// for (int number = 1; number <= N;number++)
// {
//     if (number % 2 != 0)
//     {

//         Console.WriteLine($"{number}");
//     }
// }

// for (int num = 100; num >= 0; num += -10)
//  {
//      Console.WriteLine($"{num}");
//  }

Console.Write("Введите свою фамилию");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

 



