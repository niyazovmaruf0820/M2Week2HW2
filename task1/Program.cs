using task1;

Person person = new Person();
person.FirstName = "Maruf";
person.LastName = "Niyazov";
person.Age = 16;
person.Address = "Dushanbe";
System.Console.WriteLine(person.GetFullName());
System.Console.WriteLine(person.GetBirthYear());