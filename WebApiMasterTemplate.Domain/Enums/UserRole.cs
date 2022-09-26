namespace WebApiMasterTemplate.Domain.Enums
{
  public class UserRole
  {
    [Flags]
    public enum Role
    {
      Admin = 1,
      User = 2
    }
  }
}
