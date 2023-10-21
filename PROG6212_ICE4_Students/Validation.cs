using System.Text.RegularExpressions;

namespace PROG6212_ICE4_Students
{
    internal class Validation
    {
        public bool Validate(string firstname, string surname, DateOnly dob, string? email, string? contact)
        {
            if (email == null && contact != null)
            {
                return Firstname(firstname) && Surname(surname) && DOB(dob) && Contact(contact);
            }
            else
            {
                return Firstname(firstname) && Surname(surname) && DOB(dob) && Email(email);
            }
        }
        private bool Firstname(string firstname)
        {
            return firstname.Length <= 50;
        }
        private bool Surname(string surname)
        {
            return surname.Length <= 50;
        }
        private bool DOB(DateOnly dob)
        {
            return dob < DateOnly.FromDateTime(DateTime.Now);
        }
        private bool Email(string? email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        private bool Contact(string? contact)
        {
            foreach (var num in contact.Replace(" ", ""))
            {
                if (!int.TryParse(num + "", out int result))
                {
                    return false;
                }
            }
            return contact.Replace(" ", "").Length == 10;
        }
    }
}
