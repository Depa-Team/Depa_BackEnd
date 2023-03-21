﻿namespace Hostlify.Infraestructure;

public class User: BaseModel
{
    public int Id { get; set; }
    public string Name {get; set; }
    public string Password {get; set; }
    public string Email { get; set; }
    public string Type { get; set; }
    public string? Plan { get; set; }
    public int? phoneNumber { get; set; }
}