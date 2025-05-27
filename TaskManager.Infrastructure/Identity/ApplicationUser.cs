﻿
using Microsoft.AspNetCore.Identity;
using TaskManager.Domain.Entities;

namespace TaskManager.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FullName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Guid? MemberId { get; set; }
        public Member? Member { get; set; }
    }
}
