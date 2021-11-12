// <copyright file="Courier6.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Napas
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class List
    {
        private Commodity[] com;
        public List(int j)
        {
            com = new Commodity[j];
            com[0] = new Commodity();
        }
    }
}
