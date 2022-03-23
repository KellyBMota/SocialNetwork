using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetworkGoogle
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string EducationLevel { get; set; }
        public List<User> Friends { get; set; }
        
        public User(int id, string name, int age, string educationLevel, List<User> friends)
        {
            Id = id;
            Name = name;
            Age = age;
            EducationLevel = educationLevel;
            Friends = friends;
        }

        //Get a user that has most friends in common with.
        public static User GetRecommendation(User user)
        {
            User recommendedFriend = null;
            var possibleRecommendedFriends = new Dictionary<int, int>();
            foreach(var friend in user.Friends)
            {
                foreach(var friendOfFriend in friend.Friends)
                {
                    if (friendOfFriend == user) continue;
                    if (!user.Friends.Contains(friendOfFriend) && !possibleRecommendedFriends.ContainsKey(friendOfFriend.Id))
                    {
                        var countNumberOfFriendsInCommon = friendOfFriend.Friends.Where(f => user.Friends.Contains(f)).Count();
                        possibleRecommendedFriends.Add(friendOfFriend.Id, countNumberOfFriendsInCommon);
                        if(recommendedFriend == null || possibleRecommendedFriends[recommendedFriend.Id] > countNumberOfFriendsInCommon)
                        {
                            recommendedFriend = friendOfFriend;
                        }
                    }
                }
            }

            return recommendedFriend;
        }
    }
}
