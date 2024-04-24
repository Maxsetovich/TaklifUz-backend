using TaklifUz.DataAccess.Interfaces;
using TaklifUz.Service.Dtos.Heads;
using TaklifUz.Service.Interfaces.Heads;

namespace TaklifUz.Service.Services.Heads;

public class HeadService : IHeadService
{
    private readonly IUnitOfWork _repository;

    public HeadService(IUnitOfWork unitOfWork)
    {
        this._repository = unitOfWork;
    }
    public Task<bool> CreateAsync(HeadCreateDto dto)
    {
        throw new NotImplementedException();
    }
}
