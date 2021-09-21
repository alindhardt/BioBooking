using BioBooking.MauiBlazor.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BioBooking.MauiBlazor.Services
{
    public interface ITheaterSeatRepository
    {
        Task<List<SeatModel>> GetSeatsFromTheater(int theaterId, DateTime startTime);
    }
}