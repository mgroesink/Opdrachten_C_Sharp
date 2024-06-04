using System;

namespace Opdrachten_C_Sharp.Models.Block1
{
    public class Me
    {
        #region Properties
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the middle name.
        /// </summary>
        /// <value>
        /// The middle name.
        /// </value>
        public string MiddleName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int Age { get; set; }
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        public string PostalCode { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// Gets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(MiddleName))
                    return $"{FirstName} {LastName}";
                else
                    return $"{FirstName} {MiddleName} {LastName}";
            }

        }
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Me"/> class.
        /// </summary>
        public Me()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Me"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="middleName">The middle name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        /// <param name="address">The address.</param>
        /// <param name="postalCode">The postal code.</param>
        /// <param name="city">The city.</param>
        public Me(string firstName, string middleName, string lastName, int age, string address, string postalCode, string city)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
            Address = address;
            PostalCode = postalCode;
            City = city;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Me"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        /// <param name="address">The address.</param>
        /// <param name="postalCode">The postal code.</param>
        /// <param name="city">The city.</param>
        public Me(string firstName, string lastName, int age, string address, string postalCode, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
            PostalCode = postalCode;
            City = city;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Me"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="birthdate">The birthdate.</param>
        public Me(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Me"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="middleName">The middle name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        public Me(string firstName, string middleName, string lastName, int age)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Me"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public Me(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Me"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="middleName">The middle name.</param>
        /// <param name="lastName">The last name.</param>
        public Me(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        #endregion

    }
}
