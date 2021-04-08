using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Models
{
    public class Todo
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Title of Todo
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public int TodoCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TodoCategory TodoCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime FinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsDeleted { get; set; }


        public Todo()
        {
            CreatedAt = DateTime.Now;
            IsDeleted = false;
        }
    }
}
