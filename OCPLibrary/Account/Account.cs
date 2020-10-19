﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    public class Account : IAccount
    {
        public EmployeeModel Create(IPersonModel person)
        {
            var output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAdress = $"{output.FirstName}.{output.LastName}@office.com";
            return output;
        }
    }
}
