using Mario_Vukovic_Seminar.Models.Base;
using Mario_Vukovic_Seminar.Models.Dbo.Base;

namespace Mario_Vukovic_Seminar.Models.Dbo
{
    public class FileStorage : FileStorageBase, IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }
}
