﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoLibrary.Models
{
    public class PersonModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{ FirstName } { LastName }";
        }
    }
}
