using System;

namespace Repository
{
    public class ProductQueries
    {
        public static String Read {get {return "SELECT * FROM Products";}}
        public static String ReadAll {get {return "SELECT * FROM Products WHERE Id = @Id";}}
        public static String Add {get {return "Insert into Products (Id, Name, Description, Price) VALUES (@Id, @Name, @Description, @Price)";}}
        public static String Update {get {return "UPDATE Products SET Name = @Name, Description = @Description, Price = @Price WHERE Id = @Id";}}
        public static String Delete {get {return "DELETE FROM Products WHERE Id = @Id";}}
        
    }
}
