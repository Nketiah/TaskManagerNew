

using TaskManager.Application.DTOs.Task;

namespace TaskManager.Application.DTOs.Account;

public class UserDTO
{
    public Guid UserId { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; } = null!;
    public string? Token { get; set; }
    public bool IsSuccess { get; set; }
    public List<TaskItemDto> Tasks { get; set; } = new();
}
