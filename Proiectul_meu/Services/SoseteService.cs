using AutoMapper;
using Proiectul_meu.Models;
using Proiectul_meu.Models.DTO;
using Proiectul_meu.Repositories.Interfaces;
using Proiectul_meu.Services.Interfaces;

namespace Proiectul_meu.Services
{
    public class SoseteService : ISoseteService
    {
        public IMapper _mapper;
        public ISoseteRepository _soseteRepository;

        public SoseteService(IMapper mapper, ISoseteRepository soseteRepository)
        {
            _mapper = mapper;
            _soseteRepository= soseteRepository;
        }

        public async Task CreateSosete(SoseteDTO sosete)
        {
            var soseteEntity = _mapper.Map<Sosete>(sosete);
            await _soseteRepository.CreateAsync(soseteEntity);
            await _soseteRepository.SaveAsync();
        }

        public async Task DeleteSosete(Guid id)
        {
            var sosete = await _soseteRepository.FindByIdAsync(id);
            _soseteRepository.Delete(sosete);
            await _soseteRepository.SaveAsync();
        }

        public async Task<List<SoseteDTO>> GetAllSosete()
        {
            var sosete = await _soseteRepository.GetAll();
            var result = _mapper.Map<List<SoseteDTO>>(sosete);
            return result;
        }

        public async Task<SoseteDTO> GetSoseteById(Guid id)
        {
            var sosete = await _soseteRepository.FindByIdAsync(id);
            var result = _mapper.Map<SoseteDTO>(sosete);
            return result;
        }

        public async Task UpdateSosete(SoseteDTO soseteDto)
        {
            var sosete = await _soseteRepository.FindByIdAsync(soseteDto.Id);

            sosete.Descriere = soseteDto.Descriere;
            sosete.Culoare = soseteDto.Culoare;
            sosete.Marime = soseteDto.Marime;
            sosete.Material = soseteDto.Material;
            sosete.Pret = soseteDto.Pret;
            sosete.Scurte = soseteDto.Scurte;
            sosete.Diferite = soseteDto.Diferite;
            if (sosete.Trening.Id != soseteDto.Trening?.Id)
                sosete.Trening = _mapper.Map<Trening>(soseteDto.Trening);

            _soseteRepository.Update(sosete);
            await _soseteRepository.SaveAsync();
        }
    }
}
