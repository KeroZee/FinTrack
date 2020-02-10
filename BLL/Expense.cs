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
        public string Email { get; set; }

        public Expense()
        {
        }

        public Expense(int id, string description, string category, double cost, DateTime date, string email)
        {
            Id = id;
            Description = description;
            Category = category;
            Cost = cost;
            Date = date;
            Email = email;
        }
        public List<Expense> GetAllExpense(string email)
        {
            ExpenseDAO dao = new ExpenseDAO();
            return dao.SelectAll(email);
        }
        public int AddExpense(string email)
        {
            ExpenseDAO dao = new ExpenseDAO();
            int result = dao.Insert(this, email);
            return result;
        }
        public int UpdateExpense()
        {
            ExpenseDAO dao = new ExpenseDAO();
            int result = dao.Update(this);
            return result;
        }
        public List<Expense> FilterDate(string startDate, string endDate)
        {
            //DateTime startDate = 
            ExpenseDAO dao = new ExpenseDAO();
            List<Expense> result = dao.FilterByDate(startDate, endDate);
            return result;
        }
        public int DeleteByRow(long sid)
        {
            ExpenseDAO dao = new ExpenseDAO();
            int result = dao.DeletebyRow(sid);
            return result;
        }
        public List<Expense> selectGraphData(string date, string price)
        {
            ExpenseDAO dao = new ExpenseDAO();
            List<Expense> result = dao.SelectGraphData(date, price);
            return result;
        }
        public List<Expense> RetrieveDataByEmail(string email)
        {
            ExpenseDAO dao = new ExpenseDAO();
            List<Expense> result = dao.SearchByEmail(email);
            return result;
        }
    }
}