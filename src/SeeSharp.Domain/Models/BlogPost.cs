﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeeSharp.Domain.Models;

public class BlogPost : Entity
{
    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Category { get; set; } = string.Empty;

    [ForeignKey(nameof(UserId))]
    public Guid UserId { get; set;}

    public ApplicationUser? Author { get; set; }
    //public string Author { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;
}