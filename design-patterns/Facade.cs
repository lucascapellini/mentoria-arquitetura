// Classes de uma lib ou framework que serão abstraídas, ou um subsistema complexo
namespace Facade
{
    class CPFValidator
    {
        public bool isCpfValid(string docNumber)
        {
            if (docNumber.Length > 0)
            {
                return true;
            }
            else return false;
        }
    }

    class Blacklist
    {
        public List<User> blockedUsers;

        public bool match(User user)
        {
            return blockedUsers.Contains(user);
        }
    }

    class UserDataBase
    {
        public List<User> activeUsers;

        public void insert(User user)
        {
            this.activeUsers.Add(user);
        }
    }

    class User
    {
        private string cpf;

        public string getCpf()
        {
            return this.cpf;
        }
    }

    class CreateAccount
    {
        public void create(User user)
        {
            CPFValidator validator = new CPFValidator();
            Blacklist blacklist = new Blacklist();

            if (validator.isCpfValid(user.getCpf()) && !blacklist.match(user))
            {
                UserDataBase dataBaseUsers = new UserDataBase();
                dataBaseUsers.insert(user);
            }
            else throw new Exception("Error");

        }
    }



}