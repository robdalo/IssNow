using IssNow.Api.Domain.Models;

namespace IssNow.Api.Core.Repos.Interfaces
{
    public interface ILocationRepo
    {
        Location GetCurrent();
    }
}
