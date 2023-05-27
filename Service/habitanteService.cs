using System;
using residencial.Models;

namespace residencial.Service
{
public class habitanteService : IhabitanteService
{
    context context;

    public habitanteService(context _context)
    {
        context = _context;
    }

    //CRUD

    public async Task CreateAsync(habitante newhabitante)
    {
        newhabitante.habitantesid = Guid.NewGuid();
        await context.AddAsync<habitante>(newhabitante);
        await context.SaveChangesAsync();
    }

    public IEnumerable<habitante> Get()
    {
        return context.habitante;
    }

    public async Task Update(Guid id, habitante updhabitantes)
    {
        var habitantes = context.habitante.Find(id);
        if (habitantes != null)
        {
            habitantes.habitantesid = updhabitantes.habitantesid;
            context.Update(habitantes);
            await context.SaveChangesAsync();
        }
    }
    
    public async Task Delete(Guid id)
    {
        var habitante = context.habitante.Find(id);
        if (habitante != null)
        {
            context.Remove(habitante);
            await context.SaveChangesAsync();
        }
    }


}
}


public interface IhabitanteService
{
    Task CreateAsync(habitante newhabitante);

    IEnumerable<habitante> Get();

    Task Update(Guid id, habitante updhabitante);

    Task Delete(Guid id);
    
}