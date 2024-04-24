using TaklifUz.Service.Dtos.Heads;

namespace TaklifUz.Service.Interfaces.Heads;

public interface IHeadService
{
    public Task<bool> CreateAsync(HeadCreateDto dto);
}
