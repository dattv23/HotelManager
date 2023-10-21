
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class InvoiceItem {

    public InvoiceItem() {
    }

    public InvoiceItem(double amount)
    {
        this.amount = amount;
    }

    public double amount;

    /// <summary>
    /// @return
    /// </summary>
    public bool updateAmount() {
        // TODO implement here
        return false;
    }

}