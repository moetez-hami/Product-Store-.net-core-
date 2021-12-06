using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain.Entities
{
    public class Provider : Concept
    {
        public int Id { get; set; }
        //public string ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        //public string Password { get; set; }
        private string myPassword;
        public string Password
        {
            get { return myPassword; }
            set
            {
                if (value.Length >= 5 && value.Length <= 20)
                {
                    myPassword = value;
                }
                else
                    Console.WriteLine("invalide password");
            }
        }

        private string myConfirmPassword;

        public string ConfirmPassword
        {
            get { return myConfirmPassword; }
            set
            {
                if (value.Equals(Password))
                {
                    myConfirmPassword = value;
                }
                else
                    Console.WriteLine("invalide ConfirmPassword");
            }
        }


        public string UserName { get; set; }
        public IList<Product> products { get; set; }

        public void SetIsApproved(Provider P)
        {
            if (P.Password.Equals(P.ConfirmPassword))

                IsApproved = true;

        }
        public void SetIsApproved(ref string password, ref string confirmPasword, ref bool isApproved)
        {
            if (Password.Equals(ConfirmPassword))

                isApproved = true;

        }

        public bool Login(string password, string username)
        {
            return (Password.Equals(password) && UserName.Equals(username));
        }

        public bool Login(string password, string username, string email)
        {
            return (Password.Equals(password) && UserName.Equals(username) && Email.Equals(email));
        }

        public bool Login(Provider p, string password, string username, string email = null)
        {
            if (Login(password, username) && (email != null ? p.Email == email : true))
                return true;
            return false;
        }

        public override string GetDetails()
        {
            string Details = "UserName" + UserName + "Date Created" + DateCreated;
            foreach (var prod in products)
            {
                Details += "\nproduct" + prod.GetDetails();
            }
            return Details;
        }

        public void GetProducts(string filterType ,string filterValue)
        {
            switch (filterType.ToLower())
            {
                case "dateprod":
                    {
                        foreach (var prod in products)

                        {
                            if (filterValue.Equals(prod.DateProd))

                            {
                                Console.WriteLine(prod);
                            }
                        }
                    }
                    break;
                case "nom":
                    {
                        foreach (var prod in products)
                        {
                            if (filterValue.Equals(prod.Name))
                            {
                                Console.WriteLine(prod);
                            }

                        }
                    }
                    break;
            }
        }
    }
}
