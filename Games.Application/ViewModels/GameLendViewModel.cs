using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Games.Application.ViewModels
{
    public class GameLendViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPerson { get; private set; }
        public Guid IdGame { get; private set; }
        public DateTime LendOn { get; private set; }
        public DateTime? ReturnedOn { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime? Updated { get; private set; }
    }
}
