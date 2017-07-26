using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoListRedo.Models
{
    public class List
    {
        [Key]
        public int ListID { get; set; }
        [Display(Name = "Task Name")]
        public string ListTitle { get; set; }
        [Display(Name = "List Created Date")]
        DateTime ListCreateDate { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}