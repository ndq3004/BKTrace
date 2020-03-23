using BKTrace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKTrace.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<User> withoutPasswords(this IEnumerable<User> users)
        {
            return users.Select(x => x.WithoutPassword());
        }
        
        public static User WithoutPassword(this User user)
        {
            user.password = null;
            return user;
        }
    }
}
