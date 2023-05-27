using System;
using residencial.Models;

namespace residencial.Service
{
    public class residenteService : IresidenteService
    {
    context context;

    public residenteService(context _context)
    {
        context = _context;
    }

    //CRUD

    public async Task CreateAsync(residente newresidente)
    {
        newresidente.residenteid = Guid.NewGuid();
        await context.AddAsync<residente>(newresidente);
        await context.SaveChangesAsync();
    }

    public IEnumerable<residente> Get()
    {
        return context.residente;
    }

    public async Task Update(Guid id, residente updresidente)
    {
        var residente = context.residente.Find(id);
        if (residente != null)
        {
            residente.residenteid = updresidente.residenteid;
            context.Update(residente);
            await context.SaveChangesAsync();
        }
    }
    
    public async Task Delete(Guid id)
    {
        var residente = context.residente.Find(id);
        if (residente != null)
        {
            context.Remove(residente);
            await context.SaveChangesAsync();
        }
    }


    }
}


public interface IresidenteService
{
    Task CreateAsync(residente newresidente);

    IEnumerable<residente> Get();

    Task Update(Guid id, residente updresidente);

    Task Delete(Guid id);
    
}