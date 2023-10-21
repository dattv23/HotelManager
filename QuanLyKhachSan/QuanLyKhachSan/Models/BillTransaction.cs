
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BillTransaction {

    public BillTransaction() {
    }

    public DateTime creationDate;

    public double amount;

    public int status;

    public int method;

    public string reservationNumber;

    /// <summary>
    /// @return
    /// </summary>
    public bool initiateTransaction() {
        // TODO implement here
        return false;
    }

}