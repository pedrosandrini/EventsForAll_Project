using EventDomain = EventsForAll.Events.Domain.Entities.Event;

namespace EventsForAll.Events.UnitTests.Domain.Event;

public class EventTest
{
    [Fact(DisplayName = "Should create event when data is valid")]
    [Trait("Event", "Unit")]
    public void CreateEvent_ShouldCreateEvent_WhenDataIsValid()
    {
        var validData = new EventDomain.CreateEventCommand
        {
            Title = "Sample Event",
            Description = "This is a sample event description.",
            StartDate = DateTime.UtcNow.AddDays(1),
            EndDate = DateTime.UtcNow.AddDays(2),
            Location = "Sample Location"
        };

        var newEvent = EventDomain.Event.Create(validData);

        Assert.NotNull(newEvent);
        Assert.Equal(validData.Title, newEvent.Title);
        Assert.Equal(validData.Description, newEvent.Description);
        Assert.Equal(validData.StartDate, newEvent.StartDate);
        Assert.Equal(validData.EndDate, newEvent.EndDate);
        Assert.Equal(validData.Location, newEvent.Location);
    }
}
