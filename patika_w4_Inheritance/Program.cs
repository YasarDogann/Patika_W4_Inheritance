namespace patika_w4_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(); //Student class'ından bir nesne oluşturduk.
            s.Name = "Abuzer";
            s.LastName = "Kömürcü";
            s.Number = 1296;
            s.PeopleInfo(); //Abstract class içindeki PeopleInfo methodunu değişritebilmek için virtual yaptık ve student classında override ederk kullandık

            Console.WriteLine("\r\n**********************\r\n");

            Teacher teacher = new Teacher();  //Teacher classından bir nesne oluşturduk  ve bilgileri atadık
            teacher.Name = "Muratgilin";
            teacher.LastName = "Damı";
            teacher.Salary = 1500;
            teacher.PeopleInfo();
         
        }
    }
}
