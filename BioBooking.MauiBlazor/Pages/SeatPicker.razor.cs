using BioBooking.MauiBlazor.Data;
using BioBooking.MauiBlazor.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBooking.MauiBlazor.Pages
{
    public partial class SeatPicker
    {
        [Inject]
        public ITheaterSeatRepository TheaterSeatRepository { get; set; }

        public int NumberOfSeatsPicked { get; private set; }
        public List<SeatModel> Seats { get; set; } = new List<SeatModel>();

        protected override async Task OnInitializedAsync()
        {
            Seats = await TheaterSeatRepository.GetSeatsFromTheater(1, DateTime.Now);
        }

        void UpdateNumberOfSeatsPicked()
        {
            NumberOfSeatsPicked = Seats.Where(s => s.SeatStatus is SeatStatus.Picked).Count();
        }
    }
}
