﻿using BugTrackerApp.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerApp.Models.BL
{
    public class TicketCommentBL
    {
        TicketCommentRepo _repo;

        public TicketCommentBL(TicketCommentRepo repo)
        {
            _repo = repo;
        }

        public void CreateTicketComment(Ticket ticket, ApplicationUser user, string comment)
        {
            _repo.Create(ticket, user, comment);
        }

        public TicketComment GetATicketComment(int Id)
        {
            return _repo.Get(Id);
        }

        public IList<TicketComment> GetAListOfComment()
        {
            return _repo.Get();
        }

        public void DeleteAComment(int Id)
        {
            _repo.Delete(Id);
            
        }

        public void Edit(TicketComment ticketComment)
        {
            _repo.Edit(ticketComment);
        }
    }
}