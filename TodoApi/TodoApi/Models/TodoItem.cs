//Models==Classes which represent data that the app manages
namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public string? Secret { get; set; }//needs to be hidden from outside word using data transfer object
}
