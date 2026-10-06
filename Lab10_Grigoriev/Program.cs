// int[] numbers = { 10, 20, 30 };
// Console.WriteLine(numbers[0]);
// Console.WriteLine(numbers[2]);
// Console.WriteLine(numbers.Length);

// foreach (int n in numbers)
// {
//     Console.WriteLine(n);
// }

// string word = "код";

// foreach (char letter in word)
// {
//     Console.WriteLine(letter);
// }

// int[] numbers = { 10, 20, 30 };

// foreach (int n in numbers)
// {
//     n = n * 2; error компиляции
// }

// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = numbers[i] * 2;
// }

// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }
// Console.WriteLine(subject.Length);

// int[] grades = { 4, 5, 3, 5, 4 };
// int total = 0;
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
//     total += grade;
// }
// Console.WriteLine($"Ср. балл: {total / grades.Length}");

// string[] students = { "Аня", "Ярослав", "Вика" };
// int num = 0;
// foreach (string student in students)
// {
//     num++;
//     Console.WriteLine($"{num}. {student}");

// }
// Console.WriteLine(num); //............................Здесь сделан шаг 3 и 5!!!!!!!

// int[] points = { 10, 20, 15 };
// int total = 0;
// foreach (int point in points)
// {
//     points[total] += 5;
//     Console.WriteLine(points[total]);
//     total++;
// }

// // A
// int[] num = { 1, 2, 3, 4, 5 };
// int total = 0;
// foreach (int n in num)
// {
//     Console.WriteLine(n);
//     total += n;
// }
// Console.WriteLine(total);

// //G
// int[] marks = { 2, 3, 4, 5, 3, 2};

// int max = 0;

// foreach (int mark in marks)
// {
//     if (mark > max) max = mark;
// }
// Console.WriteLine($"MAX mark {max}");

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // VAR 2
// string[] students = { "Аня", "Ярослав", "Вика" };
// int num = 0;
// foreach (string student in students)
// {
//     num++;
//     Console.WriteLine($"{num}. {student}");
// }

// //VAR 7
// int[] marks = { 2, 3, 4, 5, 3, 2, 5, 5, 5, 5 };
// int total = 0;
// foreach (int mark in marks)
// {
//     if (mark == 5) total++;
// }
// Console.WriteLine($"Кол-во '5': {total}");

//Dop variant

// int[] marks = { 2, 3, 4, 5, 3, 2, 3};
// string[] students = { "Аня", "Ярослав", "Вика", "Некич", "Ярчик", "Санчик", "Ванчик" };
// int max = 0;
// string nameMax = "";
// int total = 0;
// for (int i = 0; i < marks.Length; i++)
// {
//     if (marks[i] > max)
//     {
//         max = marks[i];
//         nameMax = students[i];
//     }
//     Console.WriteLine($"{students[i]} — {marks[i]}");
//     total += marks[i];
// }
// Console.WriteLine($"{nameMax} имеет оценку: {max}");
// Console.WriteLine($"Ср. Балл по классу: {Math.Round((double)total / students.Length, 2)}");