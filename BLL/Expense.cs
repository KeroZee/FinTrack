using FinTrack.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinTrack.BLL
{
    public class Expense
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Cost { get; set; }
        public DateTime Date { get; set; }

        public Expense()
        {
        }

        public Expense(int id, string description, string category, double cost, DateTime date)
        {
            Id = id;
            Description = description;
            Category = category;
            Cost = cost;
            Date = date;
        }
        public List<Expense> GetAllExpense()
        {
            ExpenseDAO dao = new ExpenseDAO();
            return dao.SelectAll();
        }
        public int AddExpense()
        {
            ExpenseDAO dao = new ExpenseDAO();
            int result = dao.Insert(this);
            return result;
        }
    }
}