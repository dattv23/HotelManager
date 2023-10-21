
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Notification {

    public Notification() {
    }

    public Notification(int notificationld, DateTime createdOn, string content)
    {
        this.notificationld = notificationld;
        this.createdOn = createdOn;
        this.content = content;
    }

    public int notificationld;

    public DateTime createdOn;

    public string content;

    /// <summary>
    /// @return
    /// </summary>
    public bool send() {
        // TODO implement here
        return false;
    }

}