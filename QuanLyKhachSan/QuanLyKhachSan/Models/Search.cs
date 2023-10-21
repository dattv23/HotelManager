
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface Search
{
    //@param RoomStyle 
    //@param StartDate 
    //@param Duration

    void SearchRoom(Enum RoomStyle, DateTime StartDate, int Duration);

}