using System.ComponentModel.DataAnnotations;

namespace ToDoAppLib;

public class User
{
    [Key]
    public int Id { get; set; }

    [Length(2, 50)]
    public string Name { get; set; } = "User";
}

public class Category
{
    [Key]
    public int Id { get; set; }

    [Length(2, 50)]
    public string Name { get; set; } = "Category";

    [Length(7, 7)]
    public string ColorHex { get; set; } = "#000000";
}

public class ToDo
{
    [Key]
    public int Id { get; set; }

    [Length(2, 50)]
    public string Name { get; set; } = "Todo";

    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Deadline { get; set; } = DateTime.Now;

    public int Importance { get; set; }

    public User Creator { get; set; } = null!;
    public List<User>? Assignees { get; set; }
}