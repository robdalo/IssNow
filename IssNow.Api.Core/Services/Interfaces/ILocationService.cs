using IssNow.Api.Domain.Models;

namespace IssNow.Api.Core.Services.Interfaces
{
    public interface ILocationService
    {
        Location GetCurrent();
    }
}
