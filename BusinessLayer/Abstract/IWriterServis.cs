using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterServis
    {
        List<Writer> GetList();
        void WriteAdd(Writer writer);
        void WriterDelete(Writer writer);
        void WriterUpdate (Writer writer);
        Writer GetByID(int id);
    }
}
