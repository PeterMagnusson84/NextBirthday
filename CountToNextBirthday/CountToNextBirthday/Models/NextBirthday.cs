using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CountToNextBirthday.Models
{
    public class NextBirthday
    {
        [DisplayName("När är du född? (åååå-mm-dd)")]
        [Required]
        public DateTime Birthdate { get; set; }

        public DateTime NextBirthdayDate
        {
            get 
            {
                var nextBirthday = new DateTime(DateTime.Today.Year, this.Birthdate.Month, this.Birthdate.Day);

                if (nextBirthday < DateTime.Today)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }

                return nextBirthday;
            }
        }

        public int Age
        {
            get
            {
                return this.NextBirthdayDate.Year - this.Birthdate.Year;
            }
        }

        public int DaysUntilNextBirthday
        {
            get 
            {
                return (this.NextBirthdayDate - DateTime.Today).Days;
            }
        }
    }
}