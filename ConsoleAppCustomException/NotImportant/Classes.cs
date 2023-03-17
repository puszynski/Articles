using ConsoleAppCustomException.CustomExceptions;

namespace ConsoleAppCustomException.NotImportant
{
    internal class UserNameGenerator
    {
        internal void VerifyUser(User user) 
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            else if (string.IsNullOrEmpty(user.Name))
                throw new ArgumentNullException(nameof(user.Name));

            if (CheckIfFirstLetterInUpperCase(user.Name))
                throw new FirstLetterOfNameNotUpperCaseException($"Incorrect name of user {user.Name}");

            

            user.IsVerified = true;
        }

        bool CheckIfFirstLetterInUpperCase(string name) 
            => !char.IsUpper(name, 0);
    }    

    internal class User
    {
        public string Name { get; set; }
        public bool IsVerified { get; set; } = false;
    }

    //todo option with inner exception => https://stackoverflow.com/questions/22826067/what-is-inner-exception
}
