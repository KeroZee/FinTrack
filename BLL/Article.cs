using FinTrack.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinTrack.BLL
{
    public class Article
    {
        //public string Id { get; set; }
        public string Title { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string DatePosted { get; set; }
        public string Author { get; set; }
        public string Link { get; set; }
        public string LastUpdated { get; set; }
        public Boolean Deleted { get; set; }


        public Article()
        {

        }

        public Article(string title, int views, int likes, int comments, string description, string image, string dateposted, string author, string link, string lastupdated, Boolean deleted )
        {
            //this.Id = id;
            this.Title = title;
            this.Views = views;
            this.Likes = likes;
            this.Comments = comments;
            this.Description = description;
            this.Image = image;
            this.DatePosted = dateposted;
            this.Author = author;
            this.Link = link;
            this.LastUpdated = lastupdated;
            this.Deleted = deleted;
        }

        public Article GetArticleById(string articleId)
        {
            ArticleDAO dao = new ArticleDAO();
            return dao.SelectById(articleId);
        }

        public List<Article> GetAllArticle()
        {
            ArticleDAO dao = new ArticleDAO();
            return dao.SelectAll();
        }

        public int AddArticle()
        {
            ArticleDAO dao = new ArticleDAO();
            return (dao.Insert(this));
        }

        public int UpdateArticle(string id, string title, string description, string author, string link, string lastupdated)
        {
            ArticleDAO dao = new ArticleDAO();
            return dao.UpdateById(id, title, description, author, link, lastupdated);
        }

        public int DeleteArticle(string id, Boolean deleted)
        {
            ArticleDAO dao = new ArticleDAO();
            return dao.DeleteById(id, deleted);
        }
    }
}