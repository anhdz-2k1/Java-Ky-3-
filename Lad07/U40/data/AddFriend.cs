using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U40.data
{
    class AddFriend
    {
        public static List<Friend> GetFriends()
        {
            var friends = new List<Friend>();

            friends.Add(new Friend { FriendId = 1 , Name="Dat Mien", Address="Phú Xuyên, Hà Nội", ImageFriend="Assets/datmien.jpg" });
            friends.Add(new Friend { FriendId = 2 , Name="Tung treo", Address="Thanh Oai, hà Nội", ImageFriend="Assets/tungtreo.jpg" });
            friends.Add(new Friend { FriendId = 3 , Name="Son lan", Address="Thường Tín, Hà Nội", ImageFriend="Assets/Sonlan.jpg" });
            friends.Add(new Friend { FriendId = 4 , Name="Trung Tuan", Address="Phú Xuyên, Hà Nội", ImageFriend="Assets/trungtuan.jpg" });
            
            return friends;


        }
    }
}
