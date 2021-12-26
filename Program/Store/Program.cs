// <copyright file="Program.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Demo
{
    using System;
    using Store.Core;
    using Store.DataAccess;
    using Store.DataAccess.Tests;

    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            var product = new Product("Быба", 1000);
            var order = new Order(1000);
            var customer = new Customer("Виталий", "Пупкин", "6456-2342-6452-5436");
            var settings = new Settings();

            // settings.AddDatabaseServer(@"DESKTOP-2AJV31B\SQLEXPRESS");
            settings.AddDatabaseServer(@"DESKTOP-4A7K70F\SQLEXPRESS");
            settings.AddDatabaseName("Store");

            using var sessionFactory = FluentNHibernateConfigurator
                .GetSessionFactory(settings, showSql: true);

            using (var session = sessionFactory.OpenSession())
            {
                session.Save(product);
                session.Save(order);
                session.Save(customer);
                session.Flush();
            }

            Console.WriteLine(product);
        }
    }
}
