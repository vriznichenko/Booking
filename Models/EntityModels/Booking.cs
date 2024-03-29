﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Booking
{
    public partial class booking
    {
        public booking(int id, int? idofroom, int? idofhotel, 
            DateTime begindate, DateTime enddate, int? userid, Room idofroomNavigation, User user)
        {
            Id = id;
            Idofroom = idofroom;
            Idofhotel = idofhotel;
            Begindate = begindate;
            Enddate = enddate;
            Userid = userid;
            IdofroomNavigation = idofroomNavigation;
            User = user;
        }

        public booking()
        {

        }

        public int Id { get; set; }
        public int? Idofroom { get; set; }
        public int? Idofhotel { get; set; }
        public DateTime Begindate { get; set; }
        public DateTime Enddate { get; set; }
        public int? Userid { get; set; }

        public virtual Room IdofroomNavigation { get; set; }
        public virtual User User { get; set; }

    }
}
