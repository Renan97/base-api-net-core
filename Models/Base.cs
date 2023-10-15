namespace base_api_net_core;

public class Base
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Surname { get; set; }
    public DateOnly? Birthday { get; set; }
    public float Height { get; set; }
}