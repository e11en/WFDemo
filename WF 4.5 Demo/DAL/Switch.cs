using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Switch
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string EAN { get; set; }
        public byte Status { get; set; }
    }
}
