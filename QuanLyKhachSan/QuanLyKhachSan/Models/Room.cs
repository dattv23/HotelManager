
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Room {

    public Room() {
    }

    public Room(int roomNumber, int style, int status, double bookingPrice, bool isSmoking)
    {
        this.roomNumber = roomNumber;
        this.style = style;
        this.status = status;
        this.bookingPrice = bookingPrice;
        this.isSmoking = isSmoking;
    }

    public int roomNumber;

    public int style;

    public int status;

    public double bookingPrice;

    public bool isSmoking;

    /// <summary>
    /// @return
    /// </summary>
    public bool isRoomAvailable() {
        // TODO implement here
        return false;
    }

    /// <summary>
    /// @return
    /// </summary>
    public bool checkIn() {
        // TODO implement here
        return false;
    }

    /// <summary>
    /// @return
    /// </summary>
    public bool checkOut() {
        // TODO implement here
        return false;
    }

}