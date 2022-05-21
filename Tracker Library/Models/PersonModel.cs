using System;
using System.Collections.Generic;
using System.Text;

namespace Tracker_Library.Models
{
    public class PersonModel
    {

        /// <summary>
        /// The unique identifier for the person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// First Name of the Person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last Name of the Person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email Address of the Person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Cellphone Number of the Person
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
