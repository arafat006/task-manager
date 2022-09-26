namespace WebApiMasterTemplate.Web.DtoModels
{
  public class UserDto
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public string TokenExpiredDate { get; set; }
  }
}
