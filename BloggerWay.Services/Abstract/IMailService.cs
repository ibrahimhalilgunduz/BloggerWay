using BloggerWay.Entities.Dtos;
using BloggerWay.Shared.Utilities.Results.Abstract;
using System.Threading.Tasks;

public interface IMailService
{
    IResult Send(EmailSendDto emailSendDto);
    IResult SendContactEmail(EmailSendDto emailSendDto);
    Task<IResult> SendAsync(EmailSendDto emailSendDto);
    Task<IResult> SendContactEmailAsync(EmailSendDto emailSendDto);
}
