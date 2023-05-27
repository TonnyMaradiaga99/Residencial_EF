using System;
using residencial.Models;

namespace residencial.Service
{
public class casaService : IcasaService
{
    context context;

    public casaService(context _context)
    {
        context = _context;
    }

    //CRUD

    public async Task CreateAsync(casa newcasa)
    {
        newcasa.casaid = Guid.NewGuid();
        await context.AddAsync<casa>(newcasa);
        await context.SaveChangesAsync();
    }

    public IEnumerable<casa> Get()
    {
        return context.casa;
    }

    public async Task Update(Guid id, casa updcasa)
    {
        var casa = context.casa.Find(id);
        if (casa != null)
        {
            casa.casaid = updcasa.casaid;
            context.Update(casa);
            await context.SaveChangesAsync();
        }
    }
    
    public async Task Delete(Guid id)
    {
        var casa = context.casa.Find(id);
        if (casa != null)
        {
            context.Remove(casa);
            await context.SaveChangesAsync();
        }
    }


}
}


public interface IcasaService
{
    Task CreateAsync(casa newcasa);

    IEnumerable<casa> Get();

    Task Update(Guid id, casa updcasa);

    Task Delete(Guid id);
    
}