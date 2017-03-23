using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PGTodoApi.Model
{
    public class TodoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Key { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }

        public DateTime CompletionDate { get; set; }
    }
}
