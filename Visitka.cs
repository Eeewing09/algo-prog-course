const string FIO = "Науменко Семён";
string groupName = "ИСП-251";
int courseNumber = 2;
const string special = "09.02.07";
bool stepend = true;
int works = 3;
double sred_bal = 4.67;
double stp = 4.0;
int learn_week = 16;
Console.WriteLine("   ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА  ");
Console.WriteLine($"ФИО: {FIO}");
Console.WriteLine($"Группа: {groupName}");
Console.WriteLine($"Курс: {courseNumber}");
Console.WriteLine($"Специальность: {special}");

Console.WriteLine($"Средний балл за {works} работы: {sred_bal}");
Console.WriteLine($"Стипендия положена (>= {stp}): {stepend}");

Console.WriteLine($"Учебных недель осталось в семестре:{learn_week}");

/* const string FIO = "Науменко Семён"; - потому, что имя всегда постоянное
const string special = "09.02.07"; - специальность студента не меняется вплоть до выпуска/отчисления
*/
