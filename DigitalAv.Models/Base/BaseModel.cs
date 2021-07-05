using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalAv.Models.Base
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
