﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public interface IOrderHandler
    {
        void Handle(Order order);

        string Name { get; }
    }
}
