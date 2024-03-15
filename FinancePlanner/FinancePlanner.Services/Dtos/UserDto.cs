using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancePlanner.Services.Dtos
{
    public class UserDto
    {
        public Guid? Id { get; set; }

        public string Username { get; set; }

        public string EmailAddress { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
