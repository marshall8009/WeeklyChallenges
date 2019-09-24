using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToDo.Models
{
    public class ToDoModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string ToDoText { get; set; }
        public bool IsComplete { get; set; }
    }
}
