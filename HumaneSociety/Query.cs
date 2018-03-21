using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query
    {
        internal static object GetPendingAdoptions()
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();

            throw new NotImplementedException();
        }

        public static void RunEmployeeQueries(Employee employee, string v)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var employeeResult = new Employee();

            employeeResult = (from e in context.Employees where e.employeeNumber == employee.employeeNumber select e).FirstOrDefault();
            if (employeeResult == null && v == "create")
            {
                employeeResult = employee;
                context.Employees.InsertOnSubmit(employeeResult);
                context.SubmitChanges();
            }
            else if (employeeResult.employeeNumber == employee.employeeNumber && v == "read")
            {

                string str = ($"Employee Data : { employeeResult.firsttName.ToString()} {employeeResult.lastName.ToString()} email: {employeeResult.lastName.ToString()}");
                UserInterface.DisplayUserOptions(str);


            }
            else if (v == "update")
            {
                // update employee 
            }
            else if (v == "delete")
            {

            }

           
            
               // delete employee from database
            

        }

        internal static Client GetClient(string userName, string password)
        {
            throw new NotImplementedException();
        }

        internal static object GetUserAdoptionStatus(Client client)
        {
            throw new NotImplementedException();
        }

        internal static object GetAnimalByID(int iD)
        {
            throw new NotImplementedException();
        }

        internal static void Adopt(object animal, Client client)
        {
            throw new NotImplementedException();
        }

        internal static object RetrieveClients()
        {
            throw new NotImplementedException();
        }

        internal static void UpdateAdoption(bool v, ClientAnimalJunction clientAnimalJunction)
        {
            throw new NotImplementedException();
        }

        public static bool CheckEmployeeUserNameExist(string username)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var employeeResult = new Employee();

            employeeResult = (from e in context.Employees where e.userName == username select e).FirstOrDefault();
            if(employeeResult != null)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        internal static void AddUsernameAndPassword(Employee employee)
        {
            try
            {
                HumaneSocietyDataContext context = new HumaneSocietyDataContext();
                var employeeResult = new Employee();

                employeeResult = (from e in context.Employees where e.employeeNumber == employee.employeeNumber select e).FirstOrDefault();



                employeeResult.pass = employee.pass;
                employeeResult.userName = employee.userName;

                context.SubmitChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            
        }

        internal static object GetShots(Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateShot(string v, Animal animal)
        {
            throw new NotImplementedException();
        }

        public static Employee RetrieveEmployeeUser(string email, int employeeNumber)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var employeeResult = new Employee();

            employeeResult = (from e in context.Employees where e.employeeNumber == employeeNumber && e.email == email select e).FirstOrDefault();

            return employeeResult;
                
        }

        internal static void EnterUpdate(Animal animal, Dictionary<int, string> updates)
        {
            throw new NotImplementedException();
        }

        internal static void RemoveAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        public static int? GetBreed()
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            Breed breedcontext = new Breed();
            Catagory catagorycontext = new Catagory();
            breedcontext.breed1 = UserInterface.GetStringData("the animal", "the breed of  ");
            breedcontext.pattern = UserInterface.GetStringData("the animal", "the pattern of  ");
            breedcontext = (from b in context.Breeds where b.ID == breedcontext.ID select b).FirstOrDefault();
            context.SubmitChanges();

           // catagorycontext.catagory1 = UserInterface.GetStringData("the animal", "the type of  ");

          //  context.SubmitChanges();

           // breed = (from b in context.Breeds where b.ID == breedcontext.ID select b).FirstOrDefault();


            return breedcontext.ID;


        }

            internal static int? GetDiet()
        {
            throw new NotImplementedException();
        }

        internal static int? GetLocation()
        {
            throw new NotImplementedException();
        }

        internal static void AddAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        public static Employee EmployeeLogin(string userName, string password)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var employeeResult = new Employee();

            employeeResult = (from e in context.Employees where e.userName == userName && e.pass == password select e).FirstOrDefault();

            return employeeResult;
        }

        internal static object GetStates()
        {
            throw new NotImplementedException();
        }

        internal static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            throw new NotImplementedException();
        }

        internal static void updateClient(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateUsername(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateEmail(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateAddress(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateFirstName(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateLastName(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
