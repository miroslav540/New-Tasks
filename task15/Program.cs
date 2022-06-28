Console.WriteLine("Введите день недели, чтобы узнать, выходной ли это.");
int num = Convert.ToInt32(Console.ReadLine());
string[] weekDays = new string[] { "Понедельник, нет", "Вторник, нет", "Среда, нет", "Четверг, нет", "Пятница, нет", "Суббота, да", "Воскресенье, да" };

Console.WriteLine(weekDays[num-1]);