using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
/*
 * Текст завдання:

Розробити базу даних, що складається з двох таблиць. Автомобіль, з унікальним ідентифікатором (наприклад номер) та декілька полів опису (наприклад марка, модель, колір, рік випуску…) та Власник, з унікальним ідентифікатором та  полями (прізвище, ім’я, по батькові, дата народження). Зв’язок між таблицями "багато-до-багатьох". Заповнити ці таблиці тестовими даними (10-15 записів в кожній таблиці).

По роботі з створеною БД потрібно створити АРІ (платформа asp.net) з двома методами:

1.	За власником отримати всі його автомобілі (POST запит). Структура та формат запиту довільна. (GetAllAuto) (By using owner table)(and auto table)
2.	(JOIN LEFT OR RIGHT)
3.	(GetAutomobilesByOwnerID)
4.	За ідентифікатором автомобіля отримати власників (GET запит).
5.	( select * from  JOIN LEFT OR RIGHT Owners or AutosAndOwners on  .auto.id = owner.id  owner. id = owner.id )
Результати запиту мають бути в форматі json.


В проекті має бути не менше двох unit тестів.


 * 
 * 
 */




namespace KukharAutoInfotechProject.Models
{
    public class Owners
    {
       [Key]
       public int PK_OwnerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public DateTime BirthDate { get; set; }

       //public int? AutosAndOwnersID { get; set; }
        public virtual ICollection<AutosAndOwners> FKOwnersForAutos { get; set; }
    }
}
