﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii011119
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor profesor = new Professor()

            {
                Name = "Creanga Ciprian",
                Faculty = "Facultatea de Istorie",
                Specialization = "Arheologie"
            };

            Student student = new Student()
            {
                Name = "Constantin Alina",
                Faculty = "Facultatea de Istorie",
                Year = 2
            };
            Student student1 = new Student()
            {
                Name = "Mihaila Alexandru",
                Faculty = "Facultatea de Istorie",
                Year = 2
            };
            Student student2 = new Student()
            {
                Name = "Pricop Narcis",
                Faculty = "Facultatea de Istorie",
                Year = 2
            };

            Course curs = new Course()
            {
                Name = "Paleolitic timpuriu",
                Year = 2,
                Professor = profesor,
                
            };
            curs.Students.Add(student);
            curs.Students.Add(student1);
            curs.Students.Add(student2);

            foreach (var item in curs.Students)
            {
                student.PrintStudenti();
                student1.PrintStudenti();
                student2.PrintStudenti();
            }
               
            

            //Students.Add(student.Name,student1.Name,student2.Name);
            //curs.Students.Add(Student.Name);
            //profesor.AfisareDetalii();  
            //student.AfisareDetalii();
            //curs.AfisareDetalii();
            Console.ReadLine();
        }
    }
}
