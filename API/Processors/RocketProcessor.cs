using API.Common;
using API.Models;
using API.Services;
using API.Settings;
using MongoDB.Driver;

namespace API.Processors
{
    public class RocketProcessor : IRocketProcessor
    {

        private readonly IRocketService _rocketService;

        /// <summary>
        /// MongoDB connection
        /// </summary>
        /// <param name="databaseSettings"></param>
        public RocketProcessor(IRocketService rocketService)
        {
            _rocketService = rocketService ?? throw new ArgumentNullException(nameof(rocketService));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="rocketModel"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task Create(RocketModel rocketModel)
        {
            try
            {
                await _rocketService.Create(rocketModel);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task Delete(string id)
        {
            try
            {
                await _rocketService.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<RocketModel> Get(string id)
        {
            try
            {
               RocketModel rocket =  await _rocketService.Get(id);

                //Aici vei implementa partea de parsare smartass 
                //daca ai intrebari sau nu te descurci
                //cauti pe google
                //pana rezolvi, ca eu nu te pot ajuta ca sunt proasta ¯\_(๑❛ᴗ❛๑)_/¯

                return rocket;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<List<RocketModel>> GetAll()
        {
            try
            {
                List<RocketModel> rockets = await _rocketService.GetAll();

                //si aici

                return rockets;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="rocketModel"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task Update(string id, RocketModel rocketModel)
        {

            try
            {
                await _rocketService.Update(id, rocketModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
