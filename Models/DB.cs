namespace Personal_Website.Models;

public class DB
{
    public int ID { get; set; }
    public string CodeName { get; set; } = string.Empty;
    public string Language { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public static string ConnectionString { get; set; } = string.Empty;
}

// public DB()
// {

// }