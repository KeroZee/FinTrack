using FinTrack.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinTrack.BLL
{
    public class Post
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public string Title {get;set;}
        public string Content {get;set;}   
        public int Likes {get;set;}    
        public int Dislikes {get;set;}
        public int Comments {get;set;}
        public string DatePosted {get;set;}
        public string AccountId {get;set;}
        public string Username { get; set; }

        public Post()
        {

        }
        public Post(string Id, string Category, string Title, string Content, int Likes, int Dislikes, int Comments, string DatePosted, string AccountId, string Username)
        {
            this.Id = Id;
            this.Category = Category;
            this.Title = Title;
            this.Likes = Likes;
            this.Content = Content;
            this.Dislikes = Dislikes;
            this.Comments = Comments;
            this.DatePosted = DatePosted;
            this.AccountId = AccountId;
            this.Username = Username;
        }

        public List<Post> GetAllPost()
        {
            PostDAO dao = new PostDAO();
            return dao.SelectAll();
        }


        public Post GetPostById(string id)
        {
            PostDAO dao = new PostDAO();
            return dao.SelectById(id);
        }

        public int CreateNewPost()
        {
            PostDAO dao = new PostDAO();
            return (dao.Insert(this));
        }

        public int UpdatePostById(string id, string category, string title, string content)
        {
            PostDAO dao = new PostDAO();
            return dao.UpdateById(id, category, title, content);
        }

        public int DeletePostById(string id)
        {
            PostDAO dao = new PostDAO();
            return dao.DeleteById(id);
        }
    }
}