using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _48_GenericTypes_4
{
    internal class Muhasebe : Personel, IPersonel<Muhasebe>
    {
        public void Delete(Muhasebe entity)
        {
            throw new NotImplementedException();
        }

        public Muhasebe Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Muhasebe entity)
        {
            throw new NotImplementedException();
        }

        public List<Muhasebe> List()
        {
            throw new NotImplementedException();
        }

        public List<Muhasebe> List(Expression<Func<Muhasebe, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Muhasebe entity)
        {
            throw new NotImplementedException();
        }
    }
}
