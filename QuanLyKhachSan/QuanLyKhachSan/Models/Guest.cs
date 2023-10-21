
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Guest : Person {

    public Guest() {
    }

    public Guest(int totalRoomCheckedln, bool createBooking)
    {
        this.totalRoomCheckedln = totalRoomCheckedln;
        this.createBooking = createBooking;
    }

    public int totalRoomCheckedln;

    public bool createBooking;

}