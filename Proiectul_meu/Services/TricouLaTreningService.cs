using AutoMapper;
using Proiectul_meu.Models;
using Proiectul_meu.Models.DTO;
using Proiectul_meu.Repositories.Interfaces;
using Proiectul_meu.Services.Interfaces;

namespace Proiectul_meu.Services
{
    public class TricouLaTreningService : ITricouLaTreningService
    {
        public IMapper _mapper;
        public ITricouLaTreningRepository _tricouLaTreningRepository;

        public TricouLaTreningService(IMapper mapper, ITricouLaTreningRepository tricouLaTreningRepository)
        {
            _mapper = mapper;
            _tricouLaTreningRepository = tricouLaTreningRepository;
        }

        public async Task CreateTricouLaTrening(TricouLaTreningDTO tricouLaTrening)
        {
            var tricouLaTreningEntity = _mapper.Map<TricouLaTrening>(tricouLaTrening);
            await _tricouLaTreningRepository.CreateAsync(tricouLaTreningEntity);
            await _tricouLaTreningRepository.SaveAsync();
        }

        public async Task DeleteTricouLaTrening(Guid id)
        {
            var tricouLaTrening = await _tricouLaTreningRepository.FindByIdAsync(id);
            _tricouLaTreningRepository.Delete(tricouLaTrening);
            await _tricouLaTreningRepository.SaveAsync();
        }

        public async Task<List<TricouLaTreningDTO>> GetAllTricouLaTrening()
        {
            var tricouriLaTrening = await _tricouLaTreningRepository.GetAll();
            var result = _mapper.Map<List<TricouLaTreningDTO>>(tricouriLaTrening);
            return result;
        }

        public async Task<TricouLaTreningDTO> GetTricouLaTreningById(Guid id)
        {
            var tricouLaTrening = await _tricouLaTreningRepository.FindByIdAsync(id);
            var result = _mapper.Map<TricouLaTreningDTO>(tricouLaTrening);
            return result;
        }

        public async Task UpdateTricouLaTrening(TricouLaTreningDTO tricouLaTreningDto)
        {
            var tricouLaTrening = await _tricouLaTreningRepository.FindByIdAsync(tricouLaTreningDto.Id);

            if (tricouLaTrening.Trening.Id != tricouLaTreningDto.Trening.Id)
                tricouLaTrening.Trening = _mapper.Map<Trening>(tricouLaTreningDto.Trening);

            if (tricouLaTrening.Tricou.Id != tricouLaTreningDto.Tricou.Id)
                tricouLaTrening.Tricou = _mapper.Map<Tricou>(tricouLaTreningDto.Tricou);

            _tricouLaTreningRepository.Update(tricouLaTrening);
            await _tricouLaTreningRepository.SaveAsync();
        }
    }
}
