﻿using CQRS.Framework.ReadModel;
using CQRS.Web.ReadModels;
using System.Linq;
using System.Web.Mvc;

namespace CQRS.Web.Controllers
{
    public class EmployeeQueryController : Controller
    {
        private readonly IReadRepository<Employee> _readRepository;

        public EmployeeQueryController(IReadRepository<Employee> readRepository)
        {
            _readRepository = readRepository;
        }

        public IQueryable<Employee> Get()
        {
            return _readRepository.Get();
        }
    }
}