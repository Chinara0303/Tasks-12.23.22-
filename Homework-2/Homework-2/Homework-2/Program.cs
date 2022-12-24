using Homework_2.Helpers.Constants;
using Homework_2.Helpers.Enum;
using Homework_2.Models;


Test test = new();
test.Age = 22;
//Console.WriteLine(test.Age);

Employee employee = new Employee("Chinara","Ibadova",22,"Goychay");

//Console.WriteLine(employee);
//Console.WriteLine(GetEmployee(employee));
static Employee GetEmployee(Employee employee)
{
    return employee;
}

string email = "chinaraei@code.edu.az";

//if (email!="chinarae@code.edu.az")
//{
//    Console.WriteLine(Errors.Error);
//}

//Console.WriteLine("Heftenin gununu daxil edin:");
//int weekDay = int.Parse(Console.ReadLine());
//GetWeekDays(weekDay);
//static void GetWeekDays(int weekDay)
//{

//	switch (weekDay)
//	{
//		case (int)WeekDays.Monday:
//			Console.WriteLine("Monday");
//			break;
//        case (int)WeekDays.Tuesday:
//			Console.WriteLine("Tuesday");
//			break;
//		case (int)(WeekDays.Wednesday):
//			Console.WriteLine("Wednesday");
//			break;
//		case (int)(WeekDays.Thursday):
//			Console.WriteLine("Thursday");
//			break;
//		case (int)(WeekDays.Friday):
//			Console.WriteLine("Friday");
//			break;
//		case (int)(WeekDays.Saturday):
//			Console.WriteLine("Saturday");
//			break;
//		case (int)(WeekDays.Sunday):
//			Console.WriteLine("Sunday");
//			break;
//		default:
//			Console.WriteLine("Duzgun reqem daxil edin");
//			break;
//	}
//}

string[] values = Enum.GetNames(typeof(WeekDays));
//int[] values = (int[])Enum.GetValues(typeof(WeekDays));
foreach (var item in values)
{
	Console.WriteLine(item);
}