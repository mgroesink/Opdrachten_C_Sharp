using System;
using System.ComponentModel.DataAnnotations;

namespace Opdrachten_C_Sharp.Models
{
    public class Student
    {
        [Key]
        private readonly string _studentnummer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="studentnummer">The studentnumber.</param>
        public Student(string studentnummer)
        {
            _studentnummer = studentnummer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="studentnummer">The studentnumber.</param>
        /// <param name="voornaam">The firstname.</param>
        /// <param name="achternaam">The lastname.</param>
        public Student(string studentnummer, string voornaam, string achternaam)
        {
            _studentnummer = studentnummer;
            Voornaam = voornaam;
            Achternaam = achternaam;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="studentnummer">The studentnumber.</param>
        /// <param name="voornaam">The firstname.</param>
        /// <param name="achternaam">The lastname.</param>
        /// <param name="klas">The class.</param>
        /// <param name="geboortedatum">The birthdate.</param>
        public Student(string studentnummer, string voornaam, string achternaam, string klas, DateTime geboortedatum)
        {
            _studentnummer = studentnummer;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Klas = klas;
            Geboortedatum = geboortedatum;
        }

        /// <summary>
        /// Gets the studentnumber.
        /// </summary>
        /// <value>
        /// The studentnumber.
        /// </value>
        public string Studentnummer
        {
            get { return _studentnummer; }
        }

        /// <summary>
        /// Gets the fullname.
        /// </summary>
        /// <value>
        /// The fullname.
        /// </value>
        public string Naam
        {
            get { return Voornaam + " " + Achternaam; }
        }

        /// <summary>
        /// Gets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int Leeftijd
        {
            get
            {
                int age = DateTime.Now.Year - Geboortedatum.Year;
                if (DateTime.Now.Month > Geboortedatum.Month) age--;
                else if (DateTime.Now.Month == Geboortedatum.Month &&
                    DateTime.Now.Day > Geboortedatum.Day) age--;
                return age;
            }
        }

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Klas { get; set; }
        public DateTime Geboortedatum { get; set; }
    }
}
