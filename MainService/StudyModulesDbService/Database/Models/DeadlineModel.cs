﻿using System.ComponentModel.DataAnnotations;
namespace StudyModulesDbService.Database.Models
{
    public class Deadline
    {
        [Key]
        public Guid uuid { get; set; }

        public Guid parentId { get; set; }

        public Guid userId {  get; set; }

        public DateTime deadline { get; set; }
    }

}