namespace Apollo.BuildingBlocks.Application.Emails;

public interface IEmailSender
{
    void SendEmail(EmailMessage message);
}
