﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcForum.Core.Models.Entities
{
    public partial class SubmittableFile
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubmittableId { get; set; }
        public int MatId { get; set; }
        public DateTime SubDate { get; set; }
        public string Note { get; set; }

    }
}