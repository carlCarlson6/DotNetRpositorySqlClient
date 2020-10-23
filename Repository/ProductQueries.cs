using System;

namespace Repository
{
    public class ProductQueries
    {
        public static String Read {get => "SELECT * FROM Products";}
        public static String ReadAll {get => "SELECT * FROM Products WHERE Id = @Id";}
        public static String Add {get => "Insert into Products (Id, Name, Description, Price) VALUES (@Id, @Name, @Description, @Price)";}
        public static String Update {get => "UPDATE Products SET Name = @Name, Description = @Description, Price = @Price WHERE Id = @Id";}
        public static String Delete {get => "DELETE FROM Products WHERE Id = @Id";}
        
    }
}
