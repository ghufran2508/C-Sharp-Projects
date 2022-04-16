using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectsCommon;
using System.IO;

namespace CommerceDAl
{
    public class DAL
    {
        public bool signUp(User newUser)
        {
            try
            {
                string dir = Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location);
                string file = dir + @"\UsersData.txt";

                StreamWriter sr = new StreamWriter(file, true);

                string toWrite = newUser.Id + " | " + newUser.Name + " | " + newUser.email + " | " + newUser.password;

                toWrite += newUser.is_admin == true ? " | " + "Admin" : "";

                sr.WriteLine(toWrite);

                sr.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool userAlreadyExist(User user)
        {
            string dir = Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\UsersData.txt";
            try
            {
                StreamReader sr = new StreamReader(file);

                string str = sr.ReadLine();

                while(str != null)
                {
                    string[] tempArray = str.Split('|');

                    if(tempArray[2].Trim() == user.email)
                    {
                        sr.Close();
                        return true;
                    }

                    str = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                return false;
            }

            return false;
        }

        public User getUser(string email, string password)
        {
            string dir = Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\UsersData.txt";
            try
            {
                StreamReader sr = new StreamReader (file);

                string str = sr.ReadLine();

                while (str != null)
                {
                    string[] tempArray = str.Split('|');

                    if (tempArray[2].Trim() == email && tempArray[3].Trim() == password)
                    {
                        sr.Close();

                        User matchUser = new User();
                        matchUser.Id = tempArray[0].Trim();
                        matchUser.Name = tempArray[1].Trim();
                        matchUser.email = tempArray[2].Trim();
                        matchUser.password = tempArray[3].Trim();
                        if(tempArray[tempArray.Length-1].Trim() == "Admin")
                        {
                            matchUser.is_admin = true;
                        }
                        return matchUser;
                    }

                    str = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                return null;
            }
            return null;
        }

        public List<User> getAllUsers()
        {
            List<User> users = new List<User>();

            string dir = Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\UsersData.txt";
            try
            {
                StreamReader sr = new StreamReader(file);

                string str = sr.ReadLine();

                while (str != null)
                {
                    string[] tempArray = str.Split('|');

                    
                    if (tempArray[tempArray.Length - 1].Trim() != "Admin")
                    {
                        User matchUser = new User();
                        matchUser.Id = tempArray[0].Trim();
                        matchUser.Name = tempArray[1].Trim();
                        matchUser.email = tempArray[2].Trim();
                        matchUser.password = tempArray[3].Trim();
                        matchUser.is_admin = false;
                        users.Add(matchUser);
                    }

                    str = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                return null;
            }
            return users;
        }

        public List<Product> getAllProducts()
        {
            List<Product> products = new List<Product>();

            string dir = Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\ProductsData.txt";

            try
            {
                StreamReader sr = new StreamReader(file);

                string str = sr.ReadLine();

                while (str != null)
                {
                    string[] tempArray = str.Split('|');


                    if (tempArray[tempArray.Length - 1].Trim() != "Admin")
                    {
                        Product prdct = new Product();
                        prdct.Id = Convert.ToInt16(tempArray[0].Trim());
                        prdct.Name = tempArray[1].Trim();
                        prdct.category = tempArray[2].Trim();
                        prdct.price = Convert.ToInt16(tempArray[3].Trim());
                        prdct.quantity = Convert.ToInt16(tempArray[4].Trim());
                        products.Add(prdct);
                    }

                    str = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                return null;
            }

            return products;
        }

        public bool addNewProduct(Product newProduct)
        {
            try
            {
                string dir = Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location);
                string file = dir + @"\ProductsData.txt";

                StreamWriter sr = new StreamWriter(file, true);

                string toWrite = newProduct.Id + " | " + newProduct.Name + " | " + newProduct.category + " | " + newProduct.price + " | " + newProduct.quantity;

                sr.WriteLine(toWrite);

                sr.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
