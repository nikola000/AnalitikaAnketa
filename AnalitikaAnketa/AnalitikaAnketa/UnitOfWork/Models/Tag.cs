﻿using UnitOfWorkExample.UnitOfWork.Models;
namespace AnalitikaAnketa.UnitOfWork.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}