﻿

/*Итак, мы собираемся добавить поддержку работы с базой данных в наше
приложение чата. Давайте разработаем для нее модель. Создадим новый
проект - это будет серверное приложение. В проекте мы будем использовать
CodeFirst подход. Начнем с двух таблиц - Messages и Users. В Messages должны
храниться сообщения, тогда как в users список пользователей. Разработайте
модель таким образом чтобы учесть что в сообщениях есть не только автор но
и адресат и статус получениям им сообщения.

 * 
 * 
 */


using Microsoft.EntityFrameworkCore;

namespace net5db.Models;

internal class Program
{
    static void Main(string[] args)
    {

        //using var context = new Context();
        //context.Database.EnsureCreated();

         
    }

}
