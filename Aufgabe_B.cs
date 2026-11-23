using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Koch k1 = new Koch(12, "Oliver");
        k1.setVorname("Jamie");
        k1.setSterne(3);
        Koch k2 = new Koch(15, "Mälzer", "Tim");
        k2.setSterne(3);
        Gast g1 = new Gast();
        g1.setName("Bucher");
        g1.setVorname("Roland");
        Gast g2 = new Gast("Brunner", "Peter");
        Restaurant r = new Restaurant("BBZW Kantine");
        r.Hinzufuegen(k1);
        r.Hinzufuegen(k2);
        r.Hinzufuegen(g1);
        r.Hinzufuegen(g2);
        r.Ausgabe();
        Console.ReadLine();
    }
}

// ===== Basisklasse =====
public class Person
{
    // Membervariablen
    private string m_Nachname;
    private string m_Vorname;

    // Methoden
    public void setName(string s)
    {
        m_Nachname = s;
    }

    public void setVorname(string s)
    {
        m_Vorname = s;
    }

    public string GetName()
    {
        return m_Nachname;
    }

    public string GetVorname()
    {
        return m_Vorname;
    }
}

// ===== Koch =====
public class Koch : Person
{
    // Membervariablen
    private int m_Sterne;

    // Konstruktoren
    public Koch(int sterne, string nachname)
    {
        setSterne(sterne);
        setName(nachname);
    }

    public Koch(int sterne, string nachname, string vorname)
    {
        setSterne(sterne);
        setName(nachname);
        setVorname(vorname);
    }

    // Methoden
    public void setSterne(int i)
    {
        m_Sterne = i;
    }

    public int GetSterne()
    {
        return m_Sterne;
    }
}

// ===== Gast =====
public class Gast : Person
{
    // Konstruktoren
    public Gast()
    {
    }

    public Gast(string nachname, string vorname)
    {
        setName(nachname);
        setVorname(vorname);
    }
}

// ===== Restaurant =====
public class Restaurant
{
    // Membervariablen
    private string m_Name;
    private List<Person> m_Personen = new List<Person>();

    // Konstruktor
    public Restaurant(string name)
    {
        m_Name = name;
    }

    // Methoden
    public void Hinzufuegen(Person p)
    {
        m_Personen.Add(p);
    }

    public void Ausgabe()
    {
        Console.WriteLine("Restaurant: " + m_Name);
        foreach (Person p in m_Personen)
        {
            if (p is Koch k)
            {
                Console.WriteLine("Koch:     " + k.GetVorname() + " " + k.GetName()
                                  + " (" + k.GetSterne() + " Sterne)");
            }
            else if (p is Gast g)
            {
                Console.WriteLine("Gast:     " + g.GetVorname() + " " + g.GetName());
            }
        }
    }
}
