
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Person {

    public Person() {
    }

    public Person(string name, string address, string email, string phone, AccountType accountType)
    {
        this.name = name;
        this.address = address;
        this.email = email;
        this.phone = phone;
        this.accountType = accountType;
    }

    public string name;

    public string address;

    public string email;

    public string phone;

    public AccountType accountType;

}