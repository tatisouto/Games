using System;
using System.ComponentModel.DataAnnotations;

namespace Games.Application.ViewModels
{
    public class PersonViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get;  set; }
        public string Email { get;  set; }
        public DateTime Created { get;  set; }
        public DateTime? Updated { get;  set; }


    }
}
