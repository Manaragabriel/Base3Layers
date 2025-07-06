using ApplicationCore.Entities.shared;

namespace ApplicationCore.Entities;

public class Role: BaseEntity
{
    public string RoleName { get; set; }
    public string Slug { get; set; }

}