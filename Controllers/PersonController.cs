using JSanchez_GH_Api.Data;
using JSanchez_GH_Api.Models;
using JSanchez_GH_Api.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JSanchez_GH_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext _dbcontext;
        private readonly ILogger<PersonController> _logger;
        public PersonController(ILogger<PersonController> logger, ApplicationDbContext dbcontext)
        {
            _logger = logger;
            _dbcontext = dbcontext;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PersonDto>>> GetHomes()
        {
            _logger.LogInformation("Obtener las personas");


            return Ok(await _dbcontext.Persons.ToListAsync());

        }


        [HttpGet("id:int", Name = "GetNPerson")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PersonDto>> GetNPerson(int id)
        {
            if (id == 0)
            {
                _logger.LogError("Error al obtener la persona con el Id" + id);
                return BadRequest();
            }

            var home = await _dbcontext.Persons.FirstOrDefaultAsync(h => h.Id == id);

            if (home == null)
            {
                return NotFound();
            }
            return Ok(home);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PersonDto>> CrearHome([FromBody] PersonCreateDto personsCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //valdidacion personalizada
            if (_dbcontext.Persons.FirstOrDefault(v => v.Identification.ToLower() == personsCreateDto.Identification.ToLower()) != null)
            {
                ModelState.AddModelError("NameExists", "La personas con ese identificacion ya existe");
                return BadRequest(ModelState);
            }
            if (personsCreateDto == null)
            {
                return BadRequest(personsCreateDto);
            }

           
            Person modelHome = new()
            {

                Identification = personsCreateDto.Identification,
                First_Name = personsCreateDto.First_Name,
                Second_Name = personsCreateDto.Second_Name,
                First_Last_Name = personsCreateDto.First_Last_Name,
                Second_Last_Name = personsCreateDto.Second_Last_Name,
                Place_Of_Birth = personsCreateDto.Place_Of_Birth,
                Date_Of_Birth = personsCreateDto.Date_Of_Birth,
                Nationality = personsCreateDto.Nationality,
                Sexo = personsCreateDto.Sexo,
                Marital_Status = personsCreateDto.Marital_Status,
                Photo = personsCreateDto.Photo,
                CreatedDate = DateTime.Now
            };

            await _dbcontext.Persons.AddAsync(modelHome);
            await _dbcontext.SaveChangesAsync();

            return CreatedAtRoute("GetNPerson", new { id = modelHome.Id }, personsCreateDto);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeletePerson(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var home = await _dbcontext.Persons.FirstOrDefaultAsync(v => v.Id == id);

            if (home == null)
            {
                return NotFound();
            }


            _dbcontext.Persons.Remove(home);
            await _dbcontext.SaveChangesAsync();

            return NoContent();
        }


        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdatePerson(int id, [FromBody] PersonUpdateDto personUpdate)
        {
            if (personUpdate == null || id != personUpdate.Id)
            {
                return BadRequest();
            }


            Person personModel = new()
            {
                Id = personUpdate.Id,
                Identification = personUpdate.Identification,
                First_Name = personUpdate.First_Name,
                Second_Name = personUpdate.Second_Name,
                First_Last_Name = personUpdate.First_Last_Name,
                Second_Last_Name = personUpdate.Second_Last_Name,
                Place_Of_Birth = personUpdate.Place_Of_Birth,
                Date_Of_Birth = personUpdate.Date_Of_Birth,
                Nationality = personUpdate.Nationality,
                Sexo = personUpdate.Sexo,
                Marital_Status = personUpdate.Marital_Status,
                Photo = personUpdate.Photo,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now

            };

            _dbcontext.Update(personModel);
            await _dbcontext.SaveChangesAsync();

            return NoContent();
        }

    }
}
