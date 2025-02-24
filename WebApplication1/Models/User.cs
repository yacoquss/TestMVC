﻿namespace WebApplication1.Models;

public class User
{
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty;
    
    public string Birthday { get; set; } = string.Empty;
    
    public string Phone { get; set; } = string.Empty;
}