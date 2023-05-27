using System;
using residencial.Models;

namespace residencial.Service
{
public class visitanteService : IvisitanteService
{
    context context;

    public visitanteService(context _context)
    {
        context = _context;
    }

    //CRUD

    public async Task CreateAsync(visitante newvisitante)
    {
        newvisitante.visitanteid = Guid.NewGuid();
        await context.AddAsync<visitante>(newvisitante);
        await context.SaveChangesAsync();
    }

    public IEnumerable<visitante> Get()
    {
        return context.visitante;
    }

    public async Task Update(Guid id, visitante updvisitante)
    {
        var visitante = context.visitante.Find(id);
        if (visitante != null)
        {
            visitante.visitanteid = updvisitante.visitanteid;
            context.Update(visitante);
            await context.SaveChangesAsync();
        }
    }
    
    public async Task Delete(Guid id)
    {
        var visitante = context.visitante.Find(id);
        if (visitante != null)
        {
            context.Remove(visitante);
            await context.SaveChangesAsync();
        }
    }


}
}


public interface IvisitanteService
{
    Task CreateAsync(visitante newvisitante);

    IEnumerable<visitante> Get();

    Task Update(Guid id, visitante updvisitante);

    Task Delete(Guid id);
    
}