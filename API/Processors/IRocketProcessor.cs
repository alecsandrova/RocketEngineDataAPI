using API.Models;

namespace API.Processors
{
    public interface IRocketProcessor
    {
        Task Create(RocketModel rocketModel);
        Task<RocketModel> Get(string id);
        Task<List<RocketModel>> GetAll();
      
        Task Update(string id, RocketModel rocketModel);
        Task Delete(string id);
    }
}
