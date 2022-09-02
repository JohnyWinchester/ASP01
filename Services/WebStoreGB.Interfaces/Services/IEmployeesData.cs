﻿using System.Collections.Generic;
using WebStoreGB.Domain.Models;

namespace WebStoreGB.Interfaces.Services
{
    public interface IEmployeesData
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        int Add(Employee employee);
        void Update(Employee employee);
        bool Delete(int id);

    }
}
