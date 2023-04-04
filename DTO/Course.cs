using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.DTO
{
    public class Course
    {
        // CRIADO A CLASSE DE ENTIDADE QUE FAZ UM ESPELHO PARA BANCO DE DADOS

        public int CourseId { get; set; }

        public string Name { get; set; }



    }
}
