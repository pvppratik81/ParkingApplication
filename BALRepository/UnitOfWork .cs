using BALRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALRepository
{
    public class UnitOfWork : IUnitOfWork
    {


        static UnitOfWork()
        {

        }

        public UnitOfWork()
        {

        }

        public void BeginTransaction()
        {

        }

        public void Commit()
        {
        }



        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
