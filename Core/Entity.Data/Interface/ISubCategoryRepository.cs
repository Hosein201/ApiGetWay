﻿using Entity.Models;
using Infrastructure;

namespace Entity.Data.Interface
{
    public interface ISubCategoryRepository : IRepository<SubCategory>, IScopedDependency
    {
    }
}
