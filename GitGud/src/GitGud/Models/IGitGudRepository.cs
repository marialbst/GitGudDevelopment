﻿using System.Collections.Generic;

namespace GitGud.Models
{
    public interface IGitGudRepository
    {
        IEnumerable<Song> GetAllSongs();
        void DeleteSong(int songId);
        IEnumerable<string> GetTopTags();
        IEnumerable<Song> GetSongsByTagName(string tagName);
        Song GetSongById(int songId);
        bool SongExists(int sondId);
        void AddComment(string userName, string content, int songId);
        IEnumerable<User> GetAllUsers();
        void DeleteUser(string userId);
        IEnumerable<Category> GetAllCategories();
        void AddCategory(string categoryName);
        IEnumerable<Song> SearchSongsByCategory(int categoryId);
        Category SearchCategoryById(int categoryId);
        void DeleteCategory(int categoryId);
        void EditCategory(string newCategoryName, Category category);
        IEnumerable<Song> GetSongByArtist(string artistName);
        void AddLike(int commentId, string userName);
        bool UserLikeExists(int commentId, string userName);
        void RemoveLike(int commentId, string userName);
        User GetUserById(string userId);
        IEnumerable<User> GetAllAdmins();
        void DeleteCommentById(int? id);
        bool CommentExists(int? id);
    }
}