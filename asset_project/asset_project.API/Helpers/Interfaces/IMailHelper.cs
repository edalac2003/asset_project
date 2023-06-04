using Sales.Shared.Responses;

namespace asset_project.API.Helpers.Interfaces
{
    public interface IMailHelper
    {
        Response SendMail(string toName, string toEmail, string subject, string body);
    }

}
