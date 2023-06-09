using Tickets.DAL;

namespace Tickets.BL.ViewModels;

public record TicketEditVM {
    public int Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public Severity Severity { get; init; } 
}