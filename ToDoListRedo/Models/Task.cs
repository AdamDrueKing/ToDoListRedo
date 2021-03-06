﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoListRedo.Models
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }
        public string TaskDescription { get; set; }
        public bool IsDone { get; set; }
        public DateTime DueDate { get; set; } //make public to show on screen

        [ForeignKey("List")]
        public int ListID { get; set; }
        public virtual List List { get; set; }
    }
}