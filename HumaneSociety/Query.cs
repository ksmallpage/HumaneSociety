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
            Employee employeeResult = new Employee();

            employeeResult = (from x in context.Employees where x.ID == employee.ID select x).FirstOrDefault();
            if (employeeResult == null && v == "create")
            {
                employeeResult = employee;
                //  employeeResult.firsttName = employee.firsttName;
                // employeeResult.lastName = employee.lastName;
                //  employeeResult.ID = employee.ID;
                //  employeeResult.email = employee.email;
                context.Employees.InsertOnSubmit(employeeResult);
                context.SubmitChanges(); //does this also submit 
            }
            else if (v == "read")
            {
                //read employee database
            }
            else if (v == "update")
            {
                // update employee 
            }
            else  (v == "delete")
            {
                // delete employee from database
            }

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

        internal static bool CheckEmployeeUserNameExist(string username)
        {
            throw new NotImplementedException();
        }

        internal static void AddUsernameAndPassword(Employee employee)
        {
            throw new NotImplementedException();
        }

        internal static object GetShots(Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateShot(string v, Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static Employee RetrieveEmployeeUser(string email, int employeeNumber)
        {
            throw new NotImplementedException();
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
            Breed breed = new Breed();
            Catagory cat = new Catagory();

            var breeds = from b in context.Breeds
                         select b.catagory;
            return breeds;

      
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

        internal static Employee EmployeeLogin(string userName, string password)
        {
            throw new NotImplementedException();
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
