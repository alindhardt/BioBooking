using BioBooking.MauiBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBooking.MauiBlazor.Pages
{
    public partial class SeatPicker
    {
        public int NumberOfSeatsPicked { get; private set; }
        public List<SeatModel> Seats { get; set; } = new List<SeatModel> 
        {
            new SeatModel { RowNumber = 1, SeatNumber = 1 },
            new SeatModel { RowNumber = 1, SeatNumber = 2 },
            new SeatModel { RowNumber = 1, SeatNumber = 3 },
            new SeatModel { RowNumber = 1, SeatNumber = 4 },
            new SeatModel { RowNumber = 1, SeatNumber = 5 },
            new SeatModel { RowNumber = 1, SeatNumber = 6 },
            new SeatModel { RowNumber = 1, SeatNumber = 7 },
            new SeatModel { RowNumber = 1, SeatNumber = 8 },
            new SeatModel { RowNumber = 1, SeatNumber = 9 },
            new SeatModel { RowNumber = 1, SeatNumber = 10 },
            new SeatModel { RowNumber = 2, SeatNumber = 1 },
            new SeatModel { RowNumber = 2, SeatNumber = 2 },
            new SeatModel { RowNumber = 2, SeatNumber = 3 },
            new SeatModel { RowNumber = 2, SeatNumber = 4 },
            new SeatModel { RowNumber = 2, SeatNumber = 5 },
            new SeatModel { RowNumber = 2, SeatNumber = 6 },
            new SeatModel { RowNumber = 2, SeatNumber = 7 },
            new SeatModel { RowNumber = 2, SeatNumber = 8 },
            new SeatModel { RowNumber = 2, SeatNumber = 9 },
            new SeatModel { RowNumber = 2, SeatNumber = 10 }
        };

        void UpdateNumberOfSeatsPicked()
        {
            NumberOfSeatsPicked = Seats.Where(s => s.SeatStatus is SeatStatus.Picked).Count();
        }
    }
}
