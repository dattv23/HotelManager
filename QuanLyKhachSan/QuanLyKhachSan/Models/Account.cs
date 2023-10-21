
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

public class Account {

    public Account() {
    }

    public Account(string username, string password, int status)
    {
        this.username = username;
        this.password = password;
        this.status = status;
    }

    public string username;

    public string password;

    public int status;

    /// <summary>
    /// @return
    /// </summary>
    public bool resetPassword() {
        // TODO implement here
        return false;
    }

}