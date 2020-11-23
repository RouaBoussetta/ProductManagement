using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain
{
    public  class Provider 
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        //public string Password { get; set; }

        private string password;
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Required]
        public string Password
        {
            get { return password;  }
            set
            {
                if (value.Length >= 5 && value.Length <= 20)
                    password = value;
                else
                    Console.WriteLine("le mot de passe doit avoir entre 5 et 20 caractéres");
            }
        }
        //public string ConfirmPassword { get; set; }
        private string confirmPassword;
        [DataType(DataType.Password)]
        [NotMapped]
        [Required]
        [Compare("Password")]
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if (value.Equals(Password))
                    confirmPassword = value;
                else
                    Console.WriteLine("le mot de passe est différent du confirmPassword");
            }
        }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsApproved { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public override string ToString()
        {
            return "id= "+Id+", UserName= "+UserName+", Password= "+Password+", ConfirmPassword= "+ConfirmPassword+" Email= "+Email+", DateCreated= "+DateCreated+
                ", IsProvided= "+IsApproved;
        }

        public Boolean Login(string nomUser, string passwordUser)
        {
                return (string.Compare(nomUser, UserName) == 0 && string.Compare(passwordUser, Password) == 0);
        
        }

        public Boolean Login(string nomUser, string passwordUser, string emailUser)
        {
            return (string.Compare(nomUser, UserName) == 0 && string.Compare(passwordUser, Password) == 0
                && string.Compare(emailUser, Email)==0 );

        }

        public static void SetIsApproved(Provider p)
        {
            p.IsApproved = string.Compare(p.password, p.confirmPassword)==0;
        }

        public static void SetIsApproved(string password, string confirmPassworf, bool isApproved)
        {
            isApproved = string.Compare(password, confirmPassworf) == 0;
        }

       
        public void GetProducts(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Name": 
                    foreach(Product p in Products)
                    {
                        if(p.Name.Equals(filterValue))
                        Console.WriteLine(p);
                    }
                    break;
                      case "DateProd":
                          foreach (Product p in Products)
                          {
                              if (p.DateProd== (DateTime.Parse(filterValue)))
                                  Console.WriteLine(p);
                          }
                          break;
            }

        }


    }
}
