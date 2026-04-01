using VideoGameCharacterAPI.Dtos;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services
{
    public interface IVideoGameCharacterService
    {
        Task<List<CharacterResponseDto>> GetAllCharactersAsync();

        Task<CharacterResponseDto?> GetCharacterByIdAsync(int id);

        Task<CharacterResponseDto> AddCharacterAsync(CreateCharacterRequestDto character);

        Task<bool> UpdateCharacterAsync(int id, UpdateCharacterRequestDto character);
        Task<bool> DeleteCharacterAsync(int id);

    }
}
