using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSirketDal : EfEntityRepositoryDal<Sirket>, ISirketDal
    {
        public EfSirketDal(KolayIkContext context):base(context)
        {
        }


    }
}
