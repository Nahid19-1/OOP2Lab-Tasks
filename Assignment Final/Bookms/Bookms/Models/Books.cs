using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookms.Models
{
    class Books
    {
         SqlConnection conn;
         public Books() { }
         public Books(SqlConnection conn)
         {
             this.conn = conn;
         }
         public bool AddBook(Book book)
         {
             conn.Open();
             string query = String.Format("INSERT INTO Books VALUES('{0}','{1}','{2}')", book.Name, book.Author,book.Edition);
             SqlCommand cmd = new SqlCommand(query, conn);
             int result = cmd.ExecuteNonQuery();
             conn.Close();
             if (result > 0) return true;
             return false;
             

        }


         public ArrayList GetAllBooks()
          {
              ArrayList books = new ArrayList();
              conn.Open();
              string query = "SELECT * FROM Books";
              SqlCommand cmd = new SqlCommand(query, conn);
              SqlDataReader reader = cmd.ExecuteReader();
              while (reader.Read())
              {
                  Book book = new Book();
                  book.Id = reader.GetOrdinal("Id");
                  book.Name = reader.GetString(reader.GetOrdinal("Name"));
                  book.Author = reader.GetString(reader.GetOrdinal("Author"));
                  book.Edition = reader.GetInt32(reader.GetOrdinal("Edition"));

                  books.Add(book);

              }
              conn.Close();
              return books;
          }
          public Book GetBook(string name)
          {
              conn.Open();
              string query = String.Format("SELECT * FROM Books WHERE Name='{0}'", name);
              SqlCommand cmd = new SqlCommand(query, conn);
              SqlDataReader reader = cmd.ExecuteReader();
              Book book = null;
              while (reader.Read())
              {
                  book = new Book();
                  book.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                  book.Name = reader.GetString(reader.GetOrdinal("Name"));
                 
              }
              conn.Close();
              return book;
          }
    }
}
