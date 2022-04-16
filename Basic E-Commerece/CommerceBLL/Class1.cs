using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectsCommon;
using CommerceDAl;

namespace CommerceBLL
{
    public class UserProd
    {
        public bool signUp(User newuser)
        {
            if(newuser.email.Contains('\''))
                return false;

            //now send this to DAL
            DAL dataWrite = new DAL();

            if(dataWrite.userAlreadyExist(newuser) == true)
            {
                return false;
            }

            return dataWrite.signUp(newuser);
        }
    
        public User getUser(string email, string password)
        {
            return new DAL().getUser(email, password);
        }

        public List<User> getAllUsers()
        {
            return new DAL().getAllUsers(); 
        }
        public List<Product> getAllProducts()
        {
            return new DAL().getAllProducts();
        }

        public bool addNewProduct(Product newProduct)
        {
            return new DAL().addNewProduct(newProduct);
        }
    }
}
