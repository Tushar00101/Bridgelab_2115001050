using System;

class Patient
{
    private static string HospitalName = "City Hospital";
    
    private static int totalPatients = 0;
    
    private readonly int PatientID;
    private string Name;
    
    private int Age;
    private string Ailment;
    

    public Patient(string Name, int PatientID, int Age, string Ailment)
    {
        this.Name = Name;
        this.PatientID = PatientID;
        
        this.Age = Age;
        
        this.Ailment = Ailment;
        
        totalPatients++;
        
    }

    public void Display()
    {
        if (this is Patient)
        {
            Console.WriteLine("Hospital: " + HospitalName);
            
            Console.WriteLine("Name: " + Name);
            
            Console.WriteLine("Patient ID: " + PatientID);
            
            Console.WriteLine("Age: " + Age);
            
            Console.WriteLine("Ailment: " + Ailment);
        }
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + totalPatients);
    }

    static void Main(string[] args)
    {
        
        Patient pat1 = new Patient("Alice", 101, 30, "Flu");
        
        Patient pat2 = new Patient("Bob", 102, 40, "Cough");
        

        pat1.Display();
        
        pat2.Display();
        
        Patient.GetTotalPatients();
    }
}
