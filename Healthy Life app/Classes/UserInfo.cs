using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Healthy_Life_app.Classes
{   
    public enum UserType : byte
    {
        User = 0,
        Doctor = 1
    }
    class UserInfo
    {
        public static UserInfo instance = null;
        public string Email { get; set; }
      //  public string Password { get; set; }
        public UserType Type { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
      

        // for doctors
        public string DocSpecialization { get; set; }
        public string clinic_location { get; set; }
        public string hrworks { get; set; }
    }
}
