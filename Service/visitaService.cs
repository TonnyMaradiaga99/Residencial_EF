using System;
using residencial.Models;

namespace residencial.Service
{
public class visitaService : IvisitaService
{
    context context;

    public visitaService(context _context)
    {
        context = _context;
    }

    //CRUD

    public async Task CreateAsync(visita newvisita)
    {
        newvisita.visitaid = Guid.NewGuid();
        await context.AddAsync<visita>(newvisita);
        await context.SaveChangesAsync();
    }

    public IEnumerable<visita> Get()
    {
        return context.visita;
    }

    public async Task Update(Guid id, visita updvisita)
    {
        var visita = context.visita.Find(id);
        if (visita != null)
        {
            visita.visitaid = updvisita.visitaid;
            context.Update(visita);
            await context.SaveChangesAsync();
        }
    }
    
    public async Task Delete(Guid id)
    {
        var visita = context.visita.Find(id);
        if (visita != null)
        {
            context.Remove(visita);
            await context.SaveChangesAsync();
        }
    }


}
}


public interface IvisitaService
{
    Task CreateAsync(visita newvisita);

    IEnumerable<visita> Get();

    Task Update(Guid id, visita updvisita);

    Task Delete(Guid id);
    
}