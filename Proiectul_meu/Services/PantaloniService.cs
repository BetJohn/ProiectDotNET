using AutoMapper;
using Proiectul_meu.Models;
using Proiectul_meu.Models.DTO;
using Proiectul_meu.Repositories.Interfaces;
using Proiectul_meu.Services.Interfaces;

namespace Proiectul_meu.Services
{
    public class PantaloniService : IPantaloniService
    {
        public IMapper _mapper;
        public IPantaloniRepository _pantaloniRepository;

        public PantaloniService(IMapper mapper, IPantaloniRepository pantaloniRepository)
        {
            _mapper = mapper;
            _pantaloniRepository = pantaloniRepository;
        }

        public async Task CreatePantaloni(PantaloniDTO pantaloni)
        {
            var pantaloniEntity = _mapper.Map<Pantaloni>(pantaloni);
            await _pantaloniRepository.CreateAsync(pantaloniEntity);
            await _pantaloniRepository.SaveAsync();
        }

        public async Task DeletePantaloni(Guid id)
        {
            var pantaloni = await _pantaloniRepository.FindByIdAsync(id);
            _pantaloniRepository.Delete(pantaloni);
            await _pantaloniRepository.SaveAsync();
        }

        public async Task<List<PantaloniDTO>> GetAllPantaloni()
        {
            var pantaloni = await _pantaloniRepository.GetAll();
            List<PantaloniDTO> result = _mapper.Map<List<PantaloniDTO>>(pantaloni);
            return result;
        }

        public async Task<PantaloniDTO> GetPantaloniById(Guid id)
        {
            var pantaloni = await _pantaloniRepository.FindByIdAsync(id);
            var result = _mapper.Map<PantaloniDTO>(pantaloni);
            return result;
        }

        public async Task UpdatePantaloni(PantaloniDTO pantaloniDto)
        {
            var pantaloni = await _pantaloniRepository.FindByIdAsync(pantaloniDto.Id);

            pantaloni.Descriere = pantaloniDto.Descriere;
            pantaloni.Culoare = pantaloniDto.Culoare;
            pantaloni.Marime= pantaloniDto.Marime;
            pantaloni.Material = pantaloniDto.Material;
            pantaloni.Pret = pantaloniDto.Pret;
            pantaloni.scurti = pantaloniDto.scurti;

            _pantaloniRepository.Update(pantaloni);
            await _pantaloniRepository.SaveAsync();
        }
    }
}
