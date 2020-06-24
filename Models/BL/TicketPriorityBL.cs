﻿using BugTrackerApp.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerApp.Models.BL
{
    public class TicketPriorityBL
    {
        TicketPriorityRepo _repo;

        public TicketPriorityBL(TicketPriorityRepo repo)
        {
            _repo = repo;
        }

        public void CreatePriority(string name)
        {
            var ticketPriority = new TicketPriority();
            ticketPriority.Name = name;
            _repo.Add(ticketPriority);
        }

        public void EditPriorityName(int Id)
        {
            _repo.Edit(Id);
        }

        public void EditPriority(TicketPriority ticketPriority)
        {
            _repo.Edit(ticketPriority);
        }

        public IList<TicketPriority> GetTicketPriorities()
        {
            return _repo.Get();
        }


        public void DeleteTicketPriorityLabel(int Id)
        {
            _repo.Delete(Id);
        }


    }
}