using System.ComponentModel.DataAnnotations;

public class GameModel
{
    [Required]
    [StringLength(50, ErrorMessage = "Title is too long")]
    public string? Title {get;set;}
}