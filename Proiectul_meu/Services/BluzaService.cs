using AutoMapper;
using Proiectul_meu.Models;
using Proiectul_meu.Models.DTO;
using Proiectul_meu.Repositories.Interfaces;
using Proiectul_meu.Services.Interfaces;

namespace Proiectul_meu.Services
{
    public class BluzaService : IBluzaService
    {
        public IMapper _mapper;
        public IBluzaRepository _bluzaRepository;

        public BluzaService(IMapper mapper, IBluzaRepository bluzaRepository)
        {
            _mapper = mapper;
            _bluzaRepository = bluzaRepository;
        }

        public async Task CreateBluza(BluzaDTO bluza)
        {
            var bluzaEntity = _mapper.Map<Bluza>(bluza);
            await _bluzaRepository.CreateAsync(bluzaEntity);
            await _bluzaRepository.SaveAsync();
        }

        public async Task DeleteBluza(Guid id)
        {
            var bluza = await _bluzaRepository.FindByIdAsync(id);
            _bluzaRepository.Delete(bluza);
            await _bluzaRepository.SaveAsync();
        }

        public async Task<List<BluzaDTO>> GetAllBluze()
        {
            var bluze = await _bluzaRepository.GetAll();
            List<BluzaDTO> result = _mapper.Map<List<BluzaDTO>>(bluze);
            return result;
        }

        public async Task<BluzaDTO> GetBluzaById(Guid id)
        {
            var bluza = await _bluzaRepository.FindByIdAsync(id);
            BluzaDTO result = _mapper.Map<BluzaDTO>(bluza);
            return result;
        }

        public async Task UpdateBluza(BluzaDTO bluzaDto)
        {
            var bluza = await _bluzaRepository.FindByIdAsync(bluzaDto.Id);

            bluza.Descriere = bluzaDto.Descriere;
            bluza.Culoare = bluzaDto.Culoare;
            bluza.Marime = bluzaDto.Marime;
            bluza.Material = bluzaDto.Material;
            bluza.Pret = bluzaDto.Pret;
            bluza.Hoodie = bluzaDto.Hoodie;

            await _bluzaRepository.SaveAsync();
        }

        
    }
}
