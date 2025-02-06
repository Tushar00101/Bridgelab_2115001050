using System;
using System.Collections.Generic;

class Patient
{
    public string Name { get; }
    private List<Doctor> doctors;


    public Patient(string name)
    {
        Name = name;

        doctors = new List<Doctor>();
    }

    public void AddDoctor(Doctor doc)
    {
        doctors.Add(doc);
    }

    public void Show()
    {
        Console.WriteLine("Patient: " + Name);

        foreach (var doc in doctors)
        {
            Console.WriteLine("  Consulted: " + doc.Name);
        }
    }
}

class Doctor
{
    public string Name { get; }
    private List<Patient> patients;

    public Doctor(string name)
    {
        Name = name;

        patients = new List<Patient>();
    }

    public void Consult(Patient pat)
    {
        patients.Add(pat);

        pat.AddDoctor(this);

        Console.WriteLine("Dr. " + Name + " consulted " + pat.Name);
    }

    public void Show()
    {
        Console.WriteLine("Doctor: " + Name);

        foreach (var pat in patients)
        {
            Console.WriteLine("  Treated: " + pat.Name);
        }
    }
}

class Hospital
{
    public string Name { get; }
    private List<Doctor> doctors;

    public Hospital(string name)
    {
        Name = name;
        doctors = new List<Doctor>();
    }

    public void Add(Doctor doc)
    {
        doctors.Add(doc);
    }

    public void Show()
    {
        Console.WriteLine("Hospital: " + Name);

        foreach (var doc in doctors)
        {
            doc.Show();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hospital h1 = new Hospital("Apollo Hospital");

        Doctor d1 = new Doctor("Rahul Mehta");

        Doctor d2 = new Doctor("Sneha Kapoor");

        Patient p1 = new Patient("Amit Sharma");

        Patient p2 = new Patient("Priya Verma");

        d1.Consult(p1);

        d1.Consult(p2);

        d2.Consult(p1);

        h1.Add(d1);

        h1.Add(d2);

        Console.WriteLine();

        h1.Show();

        Console.WriteLine();

        p1.Show();

        Console.WriteLine();

        p2.Show();
    }
}