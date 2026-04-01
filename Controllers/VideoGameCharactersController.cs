using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterAPI.Dtos;
using VideoGameCharacterAPI.Services;

namespace VideoGameCharacterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharactersController(IVideoGameCharacterService service) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<CharacterResponseDto>>> GetCharacters()
            => Ok(await service.GetAllCharactersAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<List<CharacterResponseDto>>> GetCharacterById(int id)
        {
            var character = await service.GetCharacterByIdAsync(id);
            return character is null ? NotFound("Character with given ID not found") : Ok(character);

            //if(character == null) {
            //    return NotFound("Character with given ID was not found");
            //}
            //return Ok(character);

        }

        [HttpPost]
        public async Task<ActionResult<CharacterResponseDto>> AddCharacter(CreateCharacterRequestDto character)
        {
            var createCharacter = await service.AddCharacterAsync(character);
            return CreatedAtAction(nameof(GetCharacterById), new { id = createCharacter.Id }, createCharacter);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCharacter(int id, UpdateCharacterRequestDto character)
        {
            var updatedCharacter = await service.UpdateCharacterAsync(id, character);
            return updatedCharacter ? NoContent() : NotFound("Character with given ID was not found");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCharacter(int id)
        {
            var deletedCharacter = await service.DeleteCharacterAsync(id);
            return deletedCharacter ? NoContent() : NotFound("Character with given ID was not found");
        }
    }
};