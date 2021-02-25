using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMFiles.DAL
{
  public  class FileInformation
    {
        int id { get; set; }
        string FileName { get; set; }
        string FileCategory { get; set; }
        string DepartmentBelong { get; set; }
        string CreatePerson { get; set; }
        DateTime CreateDate { get; set; }
    }
}
