using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Games.Application.ViewModels
{
    public class GameViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Active { get;  set; }
        public DateTime Created { get;  set; }
        public DateTime? Updated { get;  set; }
    }
}
