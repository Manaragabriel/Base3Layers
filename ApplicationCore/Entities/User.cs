using ApplicationCore.Entities.shared;

namespace ApplicationCore.Entities;

public class User: BaseEntity
{
    public string UserName { get; set; }
    public string UserEmail { get; set; }
    public string Password { get; set; }

}