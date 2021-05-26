using System;

namespace personalAPI.Models
{
    public class Invoice : IModel
    {
        public int Id { get; set; } 
        public double Total { get; set; }
        public DateTime IssueDate { get; set; }
    }
}