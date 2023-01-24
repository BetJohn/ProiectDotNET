using Proiectul_meu.Models;
using Proiectul_meu.Repositories;

using AutoMapper;
namespace Proiectul_meu.Services
{
    public class TricouService : ITricouService
    {
        public ITricouRepository _tricouRepository;
        public IMapper _mapper;
        public TricouService(ITricouRepository tricouRepository, IMapper mapper)
        {
            _tricouRepository = tricouRepository;
            _mapper = mapper;
        }


        public async Task CreateTricou(Tricou tricou)
        {
             await _tricouRepository.CreateAsync(tricou);
        }

        public async Task<Tricou> DeleteTricou(int id)
        {
            var tricou = await _tricouRepository.FindByIdAsync(id);
            _tricouRepository.Delete(tricou);
            await _tricouRepository.SaveAsync();
            return tricou;
            
        }

        public async Task<List<Tricou>> GetAllTricouri()
        {
            var tricouri = await _tricouRepository.GetAll();
            List<Tricou> result = _mapper.Map<List<Tricou>>(tricouri);
            return result;
           
        }

        public async Task<Tricou> GetTricouById(int id)
        {
            var tricou = await _tricouRepository.FindByIdAsync(id);
            Tricou result = _mapper.Map<Tricou>(tricou);
            return result;
            
        }

        public async Task<Tricou> UpdateTricou(Tricou tricou)
        {
            _tricouRepository.Update(tricou);
            await _tricouRepository.SaveAsync();
            return tricou;
            
        }

        Task ITricouService.DeleteTricou(int id)
        {
            throw new NotImplementedException();
        }

        Task ITricouService.UpdateTricou(Tricou tricou)
        {
            throw new NotImplementedException();
        }
    }
}
