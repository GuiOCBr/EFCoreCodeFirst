using EFCoreCodeFirst.DAL;
using EFCoreCodeFirst.DTO;
using System;

namespace EFCoreCodeFirst
{
    class Program
    {
        static void Main(String[] args)
        {
            //SALVANDO DADOS NO BANCO SCHOOLDB

            var context = new ApplicationDbContext();

            var std = new Student()
            {
                Name = "João"
            };

            context.Student.Add(std);
            context.SaveChanges();

        }
    }
}