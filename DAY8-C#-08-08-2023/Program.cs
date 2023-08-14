// See https://aka.ms/new-console-template for more information
using DemoProgram;

//Console.WriteLine("Cno " + StaticDemo.Cno);
//Console.WriteLine("Pre " + StaticDemo.Pre);
//Console.WriteLine("curr " + StaticDemo.Curr);
//StaticDemo.Calc();
//Console.WriteLine("amount" + StaticDemo.Amt);

//StudentMark studentMarks = new StudentMark("Abc","add",80, 98, 78, 22, "D", "Cbe");
//Console.WriteLine(studentMarks.CalculateTotal());
//studentMarks.DisplayCollegeDetails();
//Console.WriteLine(studentMarks.CalculateAverage());
//StudentGrade studentgrade = new("Abc", "add", 80, 98, 78, 22, "D", "Cbe");
//Console.WriteLine(studentgrade.CalculateGrade());

//TeachingStaff techingStaff = new(101, "Suga", "Cbe", "CSE", 500000, 40, 25, 10, 5);
//NonTeachingStaff nonTeachingStaff= new(102, "V", "Cbe", 400000, 30, 20, 5, 3);
//Console.WriteLine(techingStaff.Name);
//Console.WriteLine(techingStaff.Dept);
//Console.WriteLine(techingStaff.Basicasalary);
//Console.WriteLine(techingStaff.CalculateSalary());
//Console.WriteLine(nonTeachingStaff.Name);
//Console.WriteLine(nonTeachingStaff.Basicasalary);
//Console.WriteLine(nonTeachingStaff.CalculateSalary());

//MyPets myPet1 = new(2, 2, 4, "Dog");
//MyPets myPet2 = new(2, 2, 4, "Cat");

//Animal.Eat();
//Animal.Sleep();

//myPet1.AboutMe();
//myPet1.Sound();
//myPet2.AboutMe();
//myPet2.Sound();

//IAnimal myPet1 = new MyPetswithInterface(2, 2, 4, "Dog");
//MyPetswithInterface myPet2 = new(2, 2, 4, "Cat");

//myPet1.Eat();
//myPet1.Sleep();

////myPet1.AboutMe(); 
//myPet2.AboutMe();

//myPet1.Sound();
//myPet2.Sound();

//BankDetails bankDetails = new(123456, 9876543219876, 10000, "Suga", "Inactive");
//Console.WriteLine("Enter 1. Cusid 2.Accno 3.Name 4.Exit");
//int ch = Convert.ToInt32(Console.ReadLine());
//Boolean cons=true;
//while (cons)
//{
//    switch (ch)
//    {
//        case 1:
//            int cusid = Convert.ToInt32(Console.ReadLine());
//            bankDetails.FetchAccountDetails(cusid);
//            break;
//        case 2:
//            long accno = Convert.ToInt64(Console.ReadLine());
//            bankDetails.FetchAccountDetails(accno);
//            break;
//        case 3:
//            string? name = Console.ReadLine();
//            bankDetails.FetchAccountDetails(name);
//            break;
//        case 4:
//            cons = false;
//            break;
//    }
//}

Book book1 = new(1, "Its Start with us", " Collen", true);
Book book2 = new(2, "Its End with us", "Collen", false);
Book book3 = new(1003, "Deep the ocean", "Collen", false);
Book book4 = new(1004, "Last Hope", "Collen", true);

Library.book.Add(book1);
Library.book.Add(book2);
Library.book.Add(book3);
Library.book.Add(book4);

Library library = new Library();
int choice = 0;
while (choice != 4)
{
    Console.WriteLine("Choose the option\n1.Borrow Book\n2.Return Book\n3.Display Books\n4.Exit");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("Enter the book name to borrow");
        string? title = Console.ReadLine();
        Console.WriteLine(title);
        library.BorrowBook(title);
    }
    else if (choice == 2)
    {
        Console.WriteLine("Enter the book name to return");
        string? title = Console.ReadLine();
        library.ReturnBook(title);
    }
    else if (choice == 3)
    {
        library.DisplayBookDetails();
    }
    else if (choice == 4)
    {
        break;
    }


}
