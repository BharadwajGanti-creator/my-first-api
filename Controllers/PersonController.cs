using Microsoft.AspNetCore.Mvc;
using System;
using MyFirstAPI.Models;
using MyFirstAPI.Data;
using System.Collections.Generic;

namespace MyFirstAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
private readonly AppDbContext _context;
public PersonController(AppDbContext context)
{
_context = context;
}

[HttpGet]
public ActionResult<Person> GetPersons()
{
var response = _context.Persons.ToList();
return Ok(response);
}

[HttpPost]
public ActionResult<Person> AddPersons([FromBody] Person person)
{
_context.Persons.Add(person);
_context.SaveChanges();
return Ok(person);
}
[HttpPut("{id}")]
public ActionResult<Person> UpdatePerson(int id, [FromBody] Person updatedPerson)
{
var personsFound = _context.Persons.Find(id);
if(personsFound == null)
return NotFound();

personsFound.Name = updatedPerson.Name;
personsFound.Age = updatedPerson.Age;
personsFound.City = updatedPerson.City;
_context.SaveChanges();
return Ok(personsFound);
}
[HttpDelete("{id}")]
public ActionResult<Person> DeletePerson(int id)
{
var personsFound = _context.Persons.Find(id);
if(personsFound == null)
return NotFound();
_context.Persons.Remove(personsFound);
_context.SaveChanges();
return Ok(personsFound);
}
}



