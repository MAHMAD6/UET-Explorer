using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UET_Explorer.Models
{
    public class Student
    {
        public string Name { get; set; }         // Name of the student
        public string CGPA { get; set; }        // CGPA of the student
        public string RollNumber { get; set; }  // Roll Number
        public string Gender { get; set; }      // Gender of the student
        public string FatherName { get; set; }  // Father's Name
        public string Email { get; set; }       // Email Address
        public string Contact { get; set; }     // Combined Contact (Phone and Alternate Contact)
        public string CNIC { get; set; }        // CNIC of the student

        // Constructor to initialize all properties
        public Student(string name, string cgpa, string rollNumber, string gender,
                       string fatherName, string email, string contact, string cnic)
        {
            Name = name;
            CGPA = cgpa;
            RollNumber = rollNumber;
            Gender = gender;
            FatherName = fatherName;
            Email = email;
            Contact = contact;
            CNIC = cnic;
        }

        // Override ToString method for better representation (Optional)
        public override string ToString()
        {
            return $"Name: {Name}, Roll No: {RollNumber}, CGPA: {CGPA}, Gender: {Gender}, " +
                   $"Father Name: {FatherName}, Email: {Email}, Contact: {Contact}, CNIC: {CNIC}";
        }
    }

}
