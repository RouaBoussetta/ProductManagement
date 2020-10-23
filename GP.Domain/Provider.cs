using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Provider
    {

        public int id { get; set; }
        public String UserName { get; set; }
       
     
        public DateTime DateCreation { get; set; }

        public String Email { get; set; }

        public Boolean IsApproved { get; set; }
        public List<Product> Products { get; set; }


        public override string ToString()
        {
            return "username = " + UserName + " \n password = " + Password + "\n Confirme password = " + ConfirmPassword + " \n Email = " + Email + " \n Date = " + DateCreation;
        }


        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 5 && value.Length <= 20)
                    password = value;
                else
                    Console.WriteLine("le mot de passe doit avoir entre 5 et 20 caractéres");
            }
        }

        private String confirmPassword;
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if (value.Equals(Password))
                    confirmPassword = value;
                else
                    Console.WriteLine("le mot de passe est different de confirm password");
            }
        }

        public Boolean Login(String nomUser,String passwordUser)
        {
            return (String.Compare(nomUser, UserName) == 0 && String.Compare(passwordUser, Password) == 0);
            
         
        }

        public Boolean Login(String nomUser, String passwordUser, String emailUser)
        {
            return (String.Compare(nomUser, UserName) == 0 && String.Compare(passwordUser, Password) == 0 && String.Compare(emailUser,Email)==0);


        }


        public static void SetIsApproved(Provider P)
        {
          
            
                P.IsApproved = String.Compare(P.Password, P.ConfirmPassword) == 0;
            
        }

        public static void SetIsApproved(string password, string confirmPassword, bool isApproved)
        {
            isApproved = String.Compare(password, confirmPassword) == 0;
            Console.WriteLine(isApproved);
        }
    }
}
