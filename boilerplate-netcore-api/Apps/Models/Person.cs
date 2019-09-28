﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace boilerplate_netcore_api.Apps.Models
{
    /// <summary>
    /// Person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// This value auto generate
        /// </summary>
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// This value for Name
        /// </summary>
        public string Name { get; set; }
    }
}
