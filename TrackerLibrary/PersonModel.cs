using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// First name of person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email address of person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Cell phone number of person.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
