namespace WebApiMasterTemplate.Web.DtoModels
{
  public class ResultDto
  {
    public bool IsSuccess { get; set; }
    public string Information { get; set; } = string.Empty;

    public ResultDto(bool isSuccess, string information)
    {
      IsSuccess = isSuccess;
      Information = information;
    }
  }
}
