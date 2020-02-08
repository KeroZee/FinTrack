using FinTrack.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinTrack.BLL
{
    public class PostComment
    {
        public string Id { get; set; }
        public string PostId { get; set; }
        public string Content { get; set; }
        public string Username { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string DatePosted { get; set; }
        public string AccountId { get; set; }

        public PostComment()
        {

        }
        public PostComment(string Id, string PostId, string Content, string Username, int Likes, int Dislikes, string DatePosted, string AccountId)
        {
            this.Id = Id;
            this.PostId = PostId;
            this.Content = Content;
            this.Username = Username;
            this.Likes = Likes;
            this.Dislikes = Dislikes;
            this.DatePosted = DatePosted;
            this.AccountId = AccountId;

        }

        public string AutoIncrement()
        {
            PostCommentDAO dao = new PostCommentDAO();
            return dao.Autoincrement();
        }

        public List<PostComment> GetAllCommentsById(string id)
        {
            PostCommentDAO dao = new PostCommentDAO();
            return dao.SelectAllComments(id);
        }
        public int CreateNewComment()
        {
            PostCommentDAO dao = new PostCommentDAO();
            return (dao.InsertComment(this));
        }
        public int DeleteCommentsById(string id)
        {
            PostCommentDAO dao = new PostCommentDAO();
            return dao.DeletePostComments(id);
        }
    }
}
