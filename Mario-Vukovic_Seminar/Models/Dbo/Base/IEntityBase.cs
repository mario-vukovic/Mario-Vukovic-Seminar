﻿namespace Mario_Vukovic_Seminar.Models.Dbo.Base
{
    public interface IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }
}
