// <copyright file="Program.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Demo
{
    using System;
    using Store.DataAccess.Tests;
    using Store.DataAccess;
    using Store.Core;

    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            var product = new Product("Быба", 1000);

            var settings = new Settings();

            // settings.AddDatabaseServer(@"DESKTOP-2AJV31B\SQLEXPRESS");

            settings.AddDatabaseServer(@"DESKTOP-4A7K70F\SQLEXPRESS");
            settings.AddDatabaseName("Store");

            using var sessionFactory = FluentNHibernateConfigurator
                .GetSessionFactory(settings, showSql: true);

            using (var session = sessionFactory.OpenSession())
            {
                session.Save(product);
                session.Flush();
            }

            Console.WriteLine(product);

        }
    }
}
