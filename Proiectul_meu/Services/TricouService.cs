using Proiectul_meu.Models;

using AutoMapper;
using Proiectul_meu.Models.DTO;
using Proiectul_meu.Repositories.Interfaces;
using Proiectul_meu.Services.Interfaces;

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


        public async Task CreateTricou(TricouDTO tricou)
        {
            var newTricou = _mapper.Map<Tricou>(tricou);
            await _tricouRepository.CreateAsync(newTricou);
            await _tricouRepository.SaveAsync();
        }

        public async Task DeleteTricou(Guid id)
        {
            var tricou = await _tricouRepository.FindByIdAsync(id);
            _tricouRepository.Delete(tricou);
            await _tricouRepository.SaveAsync();

        }

        public async Task<List<TricouDTO>> GetAllTricouri()
        {
            var tricouri = await _tricouRepository.GetAll();
            List<TricouDTO> result = _mapper.Map<List<TricouDTO>>(tricouri);
            return result;

        }

        public async Task<TricouDTO> GetTricouById(Guid id)
        {
            var tricou = await _tricouRepository.FindByIdAsync(id);
            TricouDTO result = _mapper.Map<TricouDTO>(tricou);
            return result;

        }

        public async Task UpdateTricou(TricouDTO tricouDto)
        {
            var tricou = await _tricouRepository.FindByIdAsync(tricouDto.Id);

            tricou.Descriere = tricouDto.Descriere;
            tricou.Culoare = tricouDto.Culoare;
            tricou.Marime = tricouDto.Marime;
            tricou.Material = tricouDto.Material;
            tricou.Pret = tricouDto.Pret;
            
            _tricouRepository.Update(tricou);
            await _tricouRepository.SaveAsync();
        }
    }
}
