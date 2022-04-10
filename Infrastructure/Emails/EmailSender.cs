using Apollo.BuildingBlocks.Application.Data;
using Apollo.BuildingBlocks.Application.Emails;
using Serilog;

namespace Apollo.BuildingBlocks.Infrastructure.Emails;

public class EmailSender : IEmailSender
{
    private readonly ILogger _logger;
    private readonly EmailsConfiguration _configuration;
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public EmailSender(ILogger logger, EmailsConfiguration configuration, ISqlConnectionFactory sqlConnectionFactory)
    {
        _logger = logger;
        _configuration = configuration;
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public void SendEmail(EmailMessage message)
    {
        throw new NotImplementedException();
    }
}
