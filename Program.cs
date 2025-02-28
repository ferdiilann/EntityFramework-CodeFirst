using System;
using System.Data.Entity;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // Yeni bir öğrenci oluştur
                var student = new Student()
                {
                    FirstName = "Ferdi",
                    LastName = "İlhan",
                    DateOfBirth = new DateTime(1987, 2, 5),
                    StudentNumber = "1145549"
                };

                // Öğrenciyi veritabanına ekle
                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Öğrenci başarıyla eklendi!");
                Console.WriteLine($"Eklenen öğrenci: {student.FirstName} {student.LastName}");
                Console.ReadLine();
            }
        }
    }
} 