
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Invoice {

    public Invoice() {
    }

    public Invoice(double amount)
    {
        this.amount = amount;
    }

    public double amount;

    /// <summary>
    /// @return
    /// </summary>
    public bool createBill() {
        // TODO implement here
        return false;
    }

}