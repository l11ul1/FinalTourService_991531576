using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FinalTourService_991531576
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TourService_991531576" in both code and config file together.
    public class TourService_991531576 : DBOperations, AuthenticationUser
    {
        ABCTourDB_991531576Entities context = new ABCTourDB_991531576Entities();
        public string InsertATour(TourInfo tour)
        {
            if (context.TourInfoes.Find(tour.TourId) != null)
            {
                return "Fail to insert";
            }
            else
            {
                context.TourInfoes.Add(tour);
                context.SaveChanges();
                return "Success to insert";
            }

        }

        public List<TourInfo> RetrieveTourInfo()
        {
            return context.TourInfoes.ToList();
        }

        public string Validate(string username, string pass)
        {
            User u = context.Users.Find(username);
            if (u.Password == pass)
            {
                return "Login Success!";
            }
            else
            {
                return "Login Fail!";
            }
        }
    }
}
