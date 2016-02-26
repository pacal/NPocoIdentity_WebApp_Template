using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using NPoco;

namespace NPocoIdentityWebAppTemplate.Models
{
    [TableName("AspNetRoles")]
    [PrimaryKey("Id", AutoIncrement = false)]
    public class MyCustomRole : IRole
    {
        public MyCustomRole()
        {
            Id = Guid.NewGuid().ToString();
        }

        public MyCustomRole(string name) : this()
        {
            Name = name;
        }

        public MyCustomRole(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}