using System.Linq;

namespace TrgovanjeDionicama
{
    internal static class UserService
    {
        /// <summary>
        /// Create new user and save the user and user's wallet to database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public static User CreateUser(string username, string email, string password, string firstName, string lastName)
        {
            bool exists = false;
            User user = new User(username, email, firstName, lastName, password);
            using (var context = new StockExchangeDbContext())
            {
                exists = context.Users.Any(x => x.Username == username);
                if (exists)
                    return null;
                context.Users.Add(user);
                context.SaveChanges();
                Wallet wallet = new Wallet(user.UserId);
                context.Wallets.Add(wallet);
                context.SaveChanges();
            }
            return user;
        }

        /// <summary>
        /// Check if user exists and password check
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Unique user with the given username</returns>
        public static User LogIn(string username, string password)
        {
            using (var context = new StockExchangeDbContext())
            {
                var user = context.Users.FirstOrDefault(x => x.Username == username);
                if(PasswordManager.VerifyPasswordHash(password, user?.PasswordHash))
                    return user;
                else return null;
            }
        }
    }
}
