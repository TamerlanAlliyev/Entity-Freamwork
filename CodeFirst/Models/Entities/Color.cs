﻿namespace CodeFirst.Models.Entities
{
    public class Color
    {
#nullable disable
        public int Id { get; set; }
        public string HexCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public int DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
#nullable enable
    }
}

