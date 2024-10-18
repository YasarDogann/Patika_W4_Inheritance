# Patika+ Week4 Inheritance Uygulaması
Merhaba,
Bu proje C# ile Patika+ 4.hafta Inheritance için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Method kullanımı ve yapısını anlamak.
- Class yapısını anlamak
- Encapsulation yapısını öğrenmek
- Inheritance Method yapısını öğrenmek

## İstenilen Görev
Bu örnekte sizlerden bir Base Sınıf oluşturmanız isteniyor. İsmi -> BaseKisi
BaseKisi için propertyler -> Ad, Soyad
BaseKisi için metotlar -> Konsol ekranına ad ve soyad yazdıran bir metot.
Ardından BaseKisi'den miras alacak Ogrenci ve Ogretmen sınıfları oluşturmanız gerekiyor.
Ogrenci için ilave propertyler -> Öğrenci Numarası
Ogrenci için ilave metotlar -> Konsol ekranına öğrenci numarası, ad ve soyad yazdıran bir meto
Ogretmen için ilave propertyler -> Maaş Bilgisi
Ogretmen için ilave metotlar -> Konsol ekranına Maaş bilgisi, ad ve soyad yazdıran bir metot.
Dikkat ->  Bir metot içerisinde başka bir metodu çağırabileceğinizi unutmayınız.
Örnek birer öğretmen ve öğrenci nesneleri tanımlayarak bunlara değerler atayınız. Ardından değerleri konsol ekranına yazdırınız.


## Kod
```csharp
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
```
BasePeople sınıfı oluşturduk abstract olarak tanımlandı. Daha sonra içine her insanın ortak özelliği olarak isim soyisim değişkenleri bir method ile yazdırıldı.
Method virtual olarak tanımlandı miras alan sınıflardan bu method override edilerek içindeki bilgiler değiştirilebilsin diye.
Daha sonra Teacher ve Student class'ları oluşturuldu fakat BasePeople classından miras alarak. 1 adet properties eklendi ve miras alınan class içindeki method override edildi.

```csharp
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
```
Main method içinde sınıftan nesneler oluşturuldu. 2 adet nesne oluşturuldu ve ekrana yazdırıldı



