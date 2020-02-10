using FinTrack.DAL;
using System;
using System.Collections.Generic;
using System.Data;
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
        public string Approved { get; set; }

        public Post()
        {

        }
        public Post(string Id, string Category, string Title, string Content, int Likes, int Dislikes, int Comments, string DatePosted, string AccountId, string Username, string Approved)
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
            this.Approved = Approved;
        }
        public string AutoIncrement()
        {
            PostDAO dao = new PostDAO();
            return dao.Autoincrement();
        }

        public DataTable GetAllPopularPost()
        {
            PostDAO dao = new PostDAO();
            return dao.SelectAllPopular();
        }
        public DataTable GetAllRecentPost()
        {
            PostDAO dao = new PostDAO();
            return dao.SelectAllRecent();
        }
        public DataTable GetAllOldestPost()
        {
            PostDAO dao = new PostDAO();
            return dao.SelectAllOldest();
        }
        public DataTable GetCategoryPopular(string category)
        {
            PostDAO dao = new PostDAO();
            return dao.CategorySortPopular(category);
        }
        public DataTable GetCategoryRecent(string category)
        {
            PostDAO dao = new PostDAO();
            return dao.CategorySortRecent(category);
        }
        public DataTable GetCategoryOldest(string category)
        {
            PostDAO dao = new PostDAO();
            return dao.CategorySortOldest(category);
        }

        public DataTable GetSearchPopular(string search)
        {
            PostDAO dao = new PostDAO();
            return dao.SearchPopular(search);
        }
        public DataTable GetSearchRecent(string search)
        {
            PostDAO dao = new PostDAO();
            return dao.SearchRecent(search);
        }
        public DataTable GetSearchOldest(string search)
        {
            PostDAO dao = new PostDAO();
            return dao.SearchOldest(search);
        }
        public DataTable GetSearchPopularCate(string search, string cate)
        {
            PostDAO dao = new PostDAO();
            return dao.SearchPopularCategory(search, cate);
        }
        public DataTable GetSearchRecentCate(string search, string cate)
        {
            PostDAO dao = new PostDAO();
            return dao.SearchRecentCategory(search, cate);
        }
        public DataTable GetSearchOldestCate(string search, string cate)
        {
            PostDAO dao = new PostDAO();
            return dao.SearchOldestCategory(search, cate);
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
        public int UpdateCommentsById(string id)
        {
            PostDAO dao = new PostDAO();
            return dao.UpdateComments(id);
        }
        public int UpdateLikesById(string id)
        {
            PostDAO dao = new PostDAO();
            return dao.UpdateLikes(id);
        }
        public int UpdateDislikesById(string id)
        {
            PostDAO dao = new PostDAO();
            return dao.UpdateDislikes(id);
        }

        public int DeletePostById(string id)
        {
            PostDAO dao = new PostDAO();
            return dao.DeleteById(id);
        }
    }
}