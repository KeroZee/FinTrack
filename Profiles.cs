using FinTrack.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinTrack.BLL
{
    public class Profiles
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }   
       // public DateTime DOB { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Bio { get; set; }
        public string Avatar { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Language { get; set; }
        public string Nickname { get; set; }
        public string Acc_type { get; set; }
        //public DateTime Date_join { get; set; }
        public int Question { get; set; }
        


        public Profiles()
        {

        }

        public Profiles(int id, string email, string password,  string fname, string lname, string bio,  string avatar, string country, string phone, string language, string nickname, string acc_type, int question)
        {
            ID = id;
            Email = email;
            Password = password;
            Fname = fname;
            Lname = lname;
            Bio = bio;
            //DOB = dob;
            Avatar = avatar;
            Country = country;
            Phone = phone;
            Language = language;
            Nickname = nickname;
            Acc_type = acc_type;
            //Date_join = date_join;
            Question = question;

        }
        public Profiles GetProfileById(string ID)
        {
            ProfileDAO DAO = new ProfileDAO();
            return DAO.SelectById(ID);
        }
        public int AddProfile()
        {
            ProfileDAO DAO = new ProfileDAO();
            return (DAO.Insert(this));
        }
        //public int LoginByID(string Email)
        //{
        //    ProfileDAO DAO = new ProfileDAO();
        //    return (DAO.LoginCheck(Email));
        //}
    }
   

    
}