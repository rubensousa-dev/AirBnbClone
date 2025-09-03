using DevBnbStart.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBnbStart.Application.Models
{
    public class AddPropertyInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public Guid IdHost { get; set; }
        public string CancellationPolicy { get; set; }
    }
}
