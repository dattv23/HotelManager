
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RoomBooking
{

    public RoomBooking()
    {
    }

    public string reservationNumber;
    public DateTime startDate;
    public DateTime checkin { get; set; }
    public DateTime checkout { get; set; }
    public int roomNumber { get; set; }
    public int style { get; set; }
    public string phoneNumber { get; set; }

    /// <summary>
    /// @return
    /// </summary>
    public RoomBooking fetchDetails()
    {
        // TODO implement here
        return null;
    }

}