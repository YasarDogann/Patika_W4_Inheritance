using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_Inheritance
{
    public abstract class BasePeople  // Abstract class oluşturduk kendi başına kullanılmayacak bir class
    {
        public string Name { get; set; } // properties olarak direkt set get olarak tanımladık arka planda fields olarak tanımladı.
        public string LastName { get; set; }

        public virtual void PeopleInfo()  // Virtual bir method oluşturduk burada miras alan classlardan override ederek kullanılmasını değişiklik yapılabilr
        {
            Console.WriteLine($"{Name}" + " " + "{LastName}"); //bütün insanlarda isim soyisim olacağı için burada tanımladık
        }
    }

    public class Teacher : BasePeople  //Teacher classı oluşturduk ve BasePeople classından miras aldı
    {
        public int Salary {  get; set; }  //properties oluşturduk
        public override void PeopleInfo()  // BasePeople classından miras aldığımız için methoduna eriştik ve değişiklik eklemek için override yaptık
        {
            Console.WriteLine($"Öğretmen Adı : {Name}\r\nSoyadı : {LastName}\r\nMaaşı : {Salary}");

        }
    }

    public class Student : BasePeople
    {
        public int Number { get; set; }
        public override void PeopleInfo() // BasePeople classından miras aldığımız için methoduna eriştik ve değişiklik eklemek için override yaptık
        {
            Console.WriteLine($"Öğrenci Adı : {Name}\r\nSoyadı : {LastName}\r\nNumarası : {Number}");
        }
    }
}
