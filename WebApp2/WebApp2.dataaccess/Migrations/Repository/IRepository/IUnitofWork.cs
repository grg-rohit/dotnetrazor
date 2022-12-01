using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp2.dataaccess.Migrations.Repository.IRepository
{
    public interface IUnitofWork : IDisposable
    {
        ICategoryRepository Category { get; }

        void Save();

    }
}
