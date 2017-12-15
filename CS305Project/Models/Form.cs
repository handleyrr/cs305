using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS305Project.Models
{
    public class Form
    {
        public int Id { get; set; }
        public FormType FormType { get; set; }
        public VolunteerSelect VolunteerSelect { get; set; }
        public string ApplicantFullName { get; set; }
        public string Email { get; set; }
        public string ApplicantAddress { get; set; }
        public string ApplicantCity { get; set; }
        public State ApplicantState { get; set; }
        public int ApplicantZip { get; set; }
        public long ApplicantPhone { get; set; }
        public PhoneType ApplicantPhoneType { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Church { get; set; }
        public string Occupation { get; set; }
        public string Skills { get; set; }
        public string Qualifications { get; set; }
        public string Preferences { get; set; }
        public string Time { get; set; }
        public string SendEmail { get; set; }
        public string EmailSubject { get; set; }
    }

    public enum PhoneType
    {
        Home = 1,
        Work,
        Cell
    }

    public enum FormType
    {
       Volunteer = 1,
       Job,
        Event
    }

    public enum VolunteerSelect
    {
        Individual = 1,
        Group,
        Volunteer ,
        Community
    }
    public enum State
    {
        AL = 1, AK, AZ, AR, CA, CO, CT, DE, FL, GO, HI, ID,
        IL, IN, IA, KS, KY, LA, ME, MD, MA, MI, MN, MS, MO,
        MT, NE, NV, NH, NJ, NM, NY, NC, ND, OH, OK, OR, PA, RI, SC,
        SD, TN, TX, UT, VT, VA, WA, WV, WI, WY
    }
    public enum Gender
    {
        Male = 1,
        Female
    }

}
