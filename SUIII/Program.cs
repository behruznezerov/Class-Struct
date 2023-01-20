class PersonCla
{
    public string Ad { get; set; }
    public int Yas { get; set; }
}

record PersonRec
{
    public String Ad { get; set; }
    public int Age { get; set; }

    public PersonRec(string AD) => Ad = AD; 
}

class Program
{
    static void Main(string[] args)
    {
        //classsss
        PersonCla person1 = new PersonCla { Ad = "Behruz", Yas = 16 };
        PersonCla person2 = person1;

        Console.WriteLine(person1 == person2); //true

        person2.Ad = "Azer";
        Console.WriteLine(person1.Ad);
        Console.WriteLine(person2.Ad);


        //record
        PersonRec recordPerson1 = new("Kenan") { Age = 18 };
        PersonRec recordPerson2 = recordPerson1;
        Console.WriteLine(recordPerson1 == recordPerson2);//true
        Console.WriteLine(recordPerson1.Ad);
        Console.WriteLine(recordPerson2.Ad);
      
    }
}