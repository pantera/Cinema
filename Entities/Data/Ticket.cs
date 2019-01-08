//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinema.Entities.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public Ticket()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int TicketId { get; set; }
        public System.DateTime Time { get; set; }
        public decimal SeatNr { get; set; }
        public int TimeTableId { get; set; }
    
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual TimeTable TimeTable { get; set; }
    }
}
