﻿namespace MvcForum.Core.Models.Entities
{
    using System;
    using Interfaces;
    using Utilities;

    public partial class Student : IBaseEntity
    {
        public Student()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string AdminNo { get; set; }
        public string StudentCourse { get; set; }
        public string StudentSchool { get; set; }
        public string StudentModule { get; set; }
        public string AltEmail { get; set; }

    }
}