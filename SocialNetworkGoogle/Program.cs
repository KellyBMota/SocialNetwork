using System;
using System.Collections.Generic;

namespace SocialNetworkGoogle
{
    class Program
    {
        static void Main(string[] args)
        {
            var kelly = new User(1, "kelly", 23, "CE", null);
            var dan = new User(2, "dan", 23, "CE", null);
            var lily = new User(3, "lily", 23, "CE", null);
            var paul = new User(4, "paul", 23, "CE", null);
            var carl = new User(5, "carl", 23, "CE", null);
            var ron = new User(6, "ron", 23, "CE", null);
            var anna = new User(7, "anna", 23, "CE", null);
            var gale = new User(8, "gale", 23, "CE", null);
            var jorge = new User(9, "jorge", 23, "CE", null);

            kelly.Friends = new List<User>() { dan, lily, paul, carl, ron }; //kelly is not friends with anna and has more friends in common with her
            dan.Friends = new List<User>() { kelly, paul, carl, ron, lily }; //dan is not friends with anna and has more friends in common with her
            lily.Friends = new List<User>() { dan, kelly, paul, carl, ron, anna }; //lily is not friends with gale and has more friends in common with him
            paul.Friends = new List<User>() { kelly, dan, lily };
            carl.Friends = new List<User>() { kelly, dan, lily };
            ron.Friends = new List<User>() { kelly, dan, lily };
            anna.Friends = new List<User>() { lily, gale, jorge };
            gale.Friends = new List<User>() { anna };
            jorge.Friends = new List<User>() { anna };

            Console.WriteLine(User.GetRecommendation(dan).Name);
        }
    }
}
