using ConsoleApp1;
using SimplePrograms;

///*int consumernumber = Convert.ToInt32(Console.ReadLine()); string? consumername = Console.ReadLine();
//int currentreading = Convert.ToInt32(Console.ReadLine()); int previousreading = Convert.ToInt32(Console.ReadLine()); string? consumertype = Console.ReadLine();*/

//ElectricReading electricReading = new ElectricReading(1234, "Varun", 2000, 1200, "Domestic");
//int billamt = electricReading.CalculateBill(); Console.WriteLine($"Bill : " + $"{electricReading.Consumernumber} { electricReading.Consumername} { billamt}");


Console.WriteLine("acc_name : ");
string acc_holder_name = Console.ReadLine();
Console.WriteLine("dep_amount ");
int Deposit_Amount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("withdraw amount :  ");
int withdraw_Amount = Convert.ToInt32(Console.ReadLine());


BankBook bankAccount = new BankBook(acc_holder_name);

bankAccount.Deposit(Deposit_Amount);
bankAccount.Withdraw(withdraw_Amount);
bankAccount.Display();
Console.ReadLine();

//using ConsoleApp1;
//TeachingStaff staff = new(101, "varun", "gfer", "ece", 13200, 49, 23, 13, 7);
//NonTeachingStaff staff1 = new(135, "sharan", "gdsgdsg", 1320, 42, 20, 10, 3);

//Console.WriteLine(staff.Name);
//Console.WriteLine(staff.Dept);
//Console.WriteLine(staff.Address);
//Console.WriteLine( staff.CalcualateSalary());


//Console.WriteLine(staff1.Name);
//Console.WriteLine(staff1.Address);
//Console.WriteLine( staff1.CalcualateSalary());

//using ConsoleApp1;
//using SimplePrograms;
//StudentGrade sg= new (123,"varun","fefw",43,54,24);
//Console.WriteLine(sg.Name);
//Console.WriteLine(sg.Addressl);
//Console.WriteLine(sg.Rno);
// Console.WriteLine("Grade "+sg.avg());

// See https://aka.ms/new-console-template for more information

//int num1, num2, res;
//num1 = Convert.ToInt16(Console.ReadLine());
//num2 = Convert.ToInt16(Console.ReadLine());
//res = num1 + num2;
//Console.WriteLine(res);


//double num1, num2, res;
//num1 = Convert.ToInt16(Console.ReadLine());
//num2 = Convert.ToInt16(Console.ReadLine());
//res = num1 + num2;
//Console.WriteLine(res);

//double num1, num2; int res;
//num1 = Convert.ToDouble(Console.ReadLine()); num2 = Convert.ToDouble(Console.ReadLine()); res = (int)(num1 + num2);
//Console.WriteLine(res);

//int num, sum = 0;
//num = Convert.ToInt32(Console.ReadLine());
//int temp = num;
//while (num > 0)
//{
//    int rem = num % 10;
//    sum += rem * rem * rem;
//    num /= 10;
//}
//if (temp == sum)
//{
//    Console.WriteLine("Armstrong number");
//}
//else
//    Console.WriteLine("Not an Armstrong number");

//int n, i, sum;


//Console.Write("Input the  number : ");
//n = Convert.ToInt32(Console.ReadLine());
//sum = 0;
//Console.Write("The positive divisor  : ");
//for (i = 1; i < n; i++)
//{
//    if (n % i == 0)
//    {
//        sum = sum + i;
//        Console.Write("{0}  ", i);
//    }
//}
//Console.Write("\nThe sum of the divisor is : {0}", sum);
//if (sum == n)
//    Console.Write("\nSo, the number is perfect.");
//else
//    Console.Write("\nSo, the number is not perfect.");

//int start_num = 0, end_num = 0, count = 0;

//start_num = Convert.ToInt32(Console.ReadLine()); end_num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Prime Numbers are");
//for (int i = start_num; i <= end_num; i++)
//{
//    for (int j = 1; j <= start_num / 2; j++)
//    {
//        if (i % j == 0)
//        {
//            count++;
//        }
//    }
//    if (count == 1)
//    {
//        Console.WriteLine(i);
//    }
//    count = 0;
//}


//Console.Write("Input the  number : ");
//int n, i, sum,k,b,flag=0;
//sum = 0;
//n = Convert.ToInt32(Console.ReadLine());
//k = Convert.ToInt32(Console.ReadLine());
//int m = n / 2;
//for (i = 2; i <= m; i++)
//{
//    if (n % i == 0 || k % i == 0)
//    {
//        flag = 1;
//        Console.WriteLine(" not prime");
//        break;
//    }
//}
//    if (flag==0)
//    {
//    Console.WriteLine("prime");
//    }

//using ConsoleApp1;
//using SimplePrograms;

/////*int consumernumber = Convert.ToInt32(Console.ReadLine()); string? consumername = Console.ReadLine();
////int currentreading = Convert.ToInt32(Console.ReadLine()); int previousreading = Convert.ToInt32(Console.ReadLine()); string? consumertype = Console.ReadLine();*/

////ElectricReading electricReading = new ElectricReading(1234, "Varun", 2000, 1200, "Domestic");
////int billamt = electricReading.CalculateBill(); Console.WriteLine($"Bill : " + $"{electricReading.Consumernumber} { electricReading.Consumername} { billamt}");


//Console.WriteLine("acc_name : ");
//string acc_holder_name = Console.ReadLine();
//Console.WriteLine("dep_amount ");
//int Deposit_Amount = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("withdraw amount :  ");
//int withdraw_Amount = Convert.ToInt32(Console.ReadLine());


//BankBook bankAccount = new BankBook(acc_holder_name);

//bankAccount.Deposit(Deposit_Amount);
//bankAccount.Withdraw(withdraw_Amount);
//bankAccount.Display();
//Console.ReadLine();