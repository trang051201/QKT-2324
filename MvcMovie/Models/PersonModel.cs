namespace MvcMovie.Models;

public class PersonModel
{
    public string? Name { get; set; }
    public int? Id { get; set; }
    public Char? KeyName { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}