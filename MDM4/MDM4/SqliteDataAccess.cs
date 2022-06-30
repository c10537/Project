using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDM4
{
    public class SqliteDataAccess
    {
        public static List<MovieModel> LoadMovies()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<MovieModel>("select * from Movies", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<MovieModel> LoadMovie(int a)
        {
            a = a + 1;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<MovieModel>("select * from Movies where Id ='"+ a +"'");
                return output.ToList();
            }
        }
        public static void SaveMovie(MovieModel movie, int a)
        {;
            movie.Id = Convert.ToString(a + 1);
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Movies (Id, MovieName, ReleaseYear) values (@Id, @MovieName, @ReleaseYear)", movie);
            }
        }
        public static void RemoveMovie(int i, int c)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                i = i + 1;
                cnn.Execute("delete from Movies where Id ='" + i + "'");
                if(c > i)
                {
                    for(int j = i; j <= c; j++)
                    {
                        int k = j + 1;
                        cnn.Execute("update Movies set Id ='" + j + "' where Id ='" + k + "'");
                    }
                }
            }
        }

        public static void EditMovie(int a, MovieModel movie)
        {
            a = a + 1;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Movies set MovieName ='"+ movie.MovieName +"', ReleaseYear ='"+ movie.ReleaseYear +"' where Id ='" + a + "'");
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
