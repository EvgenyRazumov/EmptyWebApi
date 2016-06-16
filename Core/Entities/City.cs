﻿namespace Core.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        public virtual Country Country { get; set; }
    }
}
