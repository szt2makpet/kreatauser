using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Enums;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
            };

            // Teacher
            modelBuilder.Entity<Student>().HasData(students);

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Péter",
                    LastName="Makán",
                    BirthsDay=new DateTime(2022,10,10),

                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Bab",
                    BirthsDay=new DateTime(2021,4,4),
                }
            };

            // Teacher
            modelBuilder.Entity<Teacher>().HasData(teachers);

            // Flyhigh User
            modelBuilder.Entity<Flyhigh>().HasData(students);

            List<Flyhigh> flyhighs = new List<Flyhigh>
            {
                new Flyhigh
                {
                    Id=Guid.NewGuid(),
                    FirstName="Lakatos",
                    LastName="Ferenc",
                    BirthsDay=new DateTime(2022,10,10),

                },
                new Flyhigh
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Bab",
                    BirthsDay=new DateTime(2021,4,4),
                }
            };

            // Flyhigh User
            modelBuilder.Entity<Flyhigh>().HasData(flyhighs);
        }
    }
}
