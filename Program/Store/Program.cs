﻿// <copyright file="Program.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Demo
{
    using System;
    using System.Linq;
    using Store.Core;

    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            var commodity = new Product(1, "Ручка", 0);
            Console.WriteLine($"{commodity}");
        }
    }
}
