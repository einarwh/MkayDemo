using System;
using System.ComponentModel.DataAnnotations;

using Mkay;

namespace MkayDemo.Models
{
    public class Person
    {
        [Mkay("< (len .) 5", ErrorMessage = "That's too long, my friend.")]
        public string Name { get; set; }

        [Mkay(">= \"31.01.1900\"")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Mkay("<= (now)")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeathDate { get; set; }

        [Mkay("and (>= BirthDate) (<= DeathDate)")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime LastSeen { get; set; }
    }
}