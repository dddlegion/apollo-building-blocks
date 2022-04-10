namespace Apollo.BuildingBlocks.Infrastructure.Inbox;

public class InboxMessage
{
    public Guid Id { get; set; }
    public DateTime OccuredOn { get; set; }
    public string Type { get; set; }
    public string Data { get; set; }
    public DateTime? ProcessedDate { get; set; }

    public InboxMessage(Guid id, DateTime occuredOn, string type, string data)
    {
        Id = id;
        OccuredOn = occuredOn;
        Type = type;
        Data = data;
    }

    private InboxMessage() {}
}
