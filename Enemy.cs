using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public Weapon Weapon { get; set; }

    public Enemy(string name, int health, string weaponName, int weaponDamage)
    {
        Name = name;
        Health = health;
        
    }

    public int Attack()
    {
        return Weapon.Damage;
    }
}

public class Salmonid : Enemy
{
    public Salmonid() : base("Salmonid", 100, "Salmonid Slap", 6)
    {
    }
}

public class Octarian : Enemy
{
    public Octarian() : base("Octarian", 150, "Octarian Ink", 8)
    {
    }
}


