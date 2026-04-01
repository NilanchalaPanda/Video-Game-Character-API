using Microsoft.EntityFrameworkCore;
using VideoGameCharacterAPI.Data;
using VideoGameCharacterAPI.Dtos;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services
{
    public class VideoGameCharacterService(AppDbContext context) : IVideoGameCharacterService
    {
        // We don't need this anymore after injecting "AppDbContext context"
        //static List<Character> characters = new List<Character>{
        //    new Character { Id = 1, Name = "Mario", Game = "Super Mario Bros.", Role = "Hero" },
        //    new Character { Id = 2, Name = "Link", Game = "The Legend of Zelda", Role = "Hero" },
        //    new Character { Id = 3, Name = "Master Chef", Game = "Halo", Role = "Villian" },
        //    new Character { Id = 3, Name = "Zelda", Game = "The Legend of Zelda", Role = "Princess" },
        //};

        public async Task<CharacterResponseDto> AddCharacterAsync(CreateCharacterRequestDto character)
        {
            var newCharacter = new Character
            {
                Name = character.Name,
                Game = character.Game,
                Role = character.Role,
            };

            context.Characters.Add(newCharacter);
            await context.SaveChangesAsync();

            return new CharacterResponseDto
            {
                Id = newCharacter.Id,
                Name = newCharacter.Name,
                Game = newCharacter.Game,
                Role = newCharacter.Role,
            };
        }

        public async Task<bool> DeleteCharacterAsync(int id)
        {
            var characterToDelete = await context.Characters.FindAsync(id);
            if (characterToDelete is null) return false;

            context.Characters.Remove(characterToDelete);
            await context.SaveChangesAsync();

            return true;
        }

        public async Task<List<CharacterResponseDto>> GetAllCharactersAsync()
            //=> await Task.FromResult(characters);
            //=> await context.Characters.ToListAsync();
            
            // After implementing the DTO, we have make this change in the service.
            => await context.Characters.Select(c => new CharacterResponseDto
            {
                Id = c.Id,
                Name = c.Name,
                Game = c.Game,
                Role = c.Role
            }).ToListAsync();

        public async Task<CharacterResponseDto?> GetCharacterByIdAsync(int id)
        {
            //var result = characters.FirstOrDefault(c => c.Id == id);
            //return await Task.FromResult(result);

            //var result = await context.Characters.FindAsync(id);
            //return result;  

            // After implementing the DTO, we have make this change in the service.
            var result = await context.Characters
                .Where(c => c.Id == id)
                .Select(c => new CharacterResponseDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Game = c.Game,
                    Role = c.Role
                }).FirstOrDefaultAsync();

            return result;
        }

        public async Task<bool> UpdateCharacterAsync(int id, UpdateCharacterRequestDto character)
        {
            var existingCharacter = await context.Characters.FindAsync(id);
            if (existingCharacter is null) return false;

            existingCharacter.Name = character.Name;
            existingCharacter.Game = character.Game;
            existingCharacter.Role = character.Role;

            await context.SaveChangesAsync();

            return true;
        }
    }
}
