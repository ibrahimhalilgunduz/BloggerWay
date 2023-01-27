using BloggerWay.Entities.Dtos;
using BloggerWay.Shared.Utilities.Results.Abstract;

namespace BloggerWay.Services.Abstract
{
    public interface IMailService
    {
        IResult Send(EmailSendDto emailSendDto); // ali@veli.dev
        IResult SendContactEmail(EmailSendDto emailSendDto); // ali@veli.dev info@BloggerWay.com iletisim@BloggerWay.com
    }
}
