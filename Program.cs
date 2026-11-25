//task1

//  Person person = new Person("Rasul", "Dushanbe");
// Student student = new Student("Manije", "Khujand", "Computer Science", 2, 1500.5);
// Staff staff = new Staff("Farhod", "Bokhtar", "Engineering", 3200);

//         Console.WriteLine(person);
//         Console.WriteLine(student);
//         Console.WriteLine(staff);

//         person.SetAddress("Vahdat");
//         Console.WriteLine($"{person.GetName()}  {person.GetAddress()}");

//         student.SetProgram("Mathematics");
//         student.SetYear(3);
//         student.SetFee(1800);
//         Console.WriteLine($"{student.GetProgram()}  {student.GetYear()}  {student.GetFee()}");
//         Console.WriteLine(student);

//         staff.SetSchool("Economics");
//         staff.SetPay(3500.75);
//         Console.WriteLine($"{staff.GetSchool()} {staff.GetPay()}");
//         Console.WriteLine(staff);
//        



//task2

//   Cat cat = new Cat("Tom");
//     Dog dog1 = new Dog("Rex");
//     Dog dog2 = new Dog("Max");
//     BigDog bigDog1 = new BigDog("JEry");
//  BigDog bigDog2 = new BigDog("Titan");

//     cat.Greets();                  
//     dog1.Greets();                 
//     dog1.Greets(dog2);            
//     bigDog1.Greets();             
//     bigDog1.Greets(dog1);          
//     bigDog1.Greets(bigDog2);  



//task3
  List<int> list = new List<int>()
        {
            3, 0, 7, -2, 7, 15, -60, 32,
            0, -2, 90, 32, 55, 8, -9
        };

     Console.WriteLine($" 1. Min {list.Min()}");


   System.Console.WriteLine();
    for (int i = 0; i < list.Count; i++)
        {
            if (list[i] < 0)
            {
                list[i] = 0;
            }
        }
Console.WriteLine($"4. {list}");


System.Console.WriteLine($"3. Sortirofka {list.Sort()}");


