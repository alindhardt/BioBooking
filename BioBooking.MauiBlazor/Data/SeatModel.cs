using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBooking.MauiBlazor.Data
{
    public class SeatModel
    {
        public SeatStatus SeatStatus { get; set; }
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }
    }
}
