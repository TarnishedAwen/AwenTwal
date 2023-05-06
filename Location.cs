﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inventory;

public class Location
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool HasThang { get; set; }
    public bool HasCannedTuna { get; set; }

    public Location(string name, string description)
    {
        Name = name;
        Description = description;
    }
}