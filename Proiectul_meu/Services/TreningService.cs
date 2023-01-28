using AutoMapper;
using Proiectul_meu.Models;
using Proiectul_meu.Models.DTO;
using Proiectul_meu.Repositories.Interfaces;
using Proiectul_meu.Services.Interfaces;

namespace Proiectul_meu.Services
{
    public class TreningService : ITreningService
    {
        public IMapper _mapper;
        public ITreningRepository _treningRepository;

        public TreningService(IMapper mapper, ITreningRepository treningRepository)
        {
            _mapper = mapper;
            _treningRepository = treningRepository;
        }

        public async Task CreateTrening(TreningDTO trening)
        {
            var treningEntity = _mapper.Map<Trening>(trening);
            await _treningRepository.CreateAsync(treningEntity);
            await _treningRepository.SaveAsync();
        }

        public async Task DeleteTrening(Guid id)
        {
            var trening = await _treningRepository.FindByIdAsync(id);
            _treningRepository.Delete(trening);
            await _treningRepository.SaveAsync();
        }

        public async Task<List<TreningDTO>> GetAllTreninguri()
        {
            var treninguri = await _treningRepository.GetAll();
            return _mapper.Map<List<TreningDTO>>(treninguri);
        }

        public async Task<TreningDTO> GetTreningById(Guid id)
        {
            var trening = await _treningRepository.FindByIdAsync(id);
            return _mapper.Map<TreningDTO>(trening);
        }

        public async Task UpdateTrening(TreningDTO treningDto)
        {
            var trening = await _treningRepository.FindByIdAsync(treningDto.Id);

            if (trening.Bluza.Id != treningDto.Bluza.Id)
                trening.Bluza = _mapper.Map<Bluza>(treningDto.Bluza);

            if (trening.Pantaloni.Id != treningDto.Pantaloni.Id)
                trening.Pantaloni = _mapper.Map<Pantaloni>(treningDto.Pantaloni);

            foreach (var tricouLaTreningDto in treningDto.Tricouri)
            {
                var tricouLaTrening = _mapper.Map<TricouLaTrening>(tricouLaTreningDto);
                if (!trening.Tricouri.Contains(tricouLaTrening))
                    trening.Tricouri.Add(tricouLaTrening);
            }

            _treningRepository.Update(trening);
            await _treningRepository.SaveAsync();
        }
    }
}
