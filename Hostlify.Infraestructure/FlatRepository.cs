

using Hostlify.Infraestructure.Context;
using Hostlify.Infraestructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Hostlify.Infraestructure;
public class FlatRepository : IFlatRepository
{
    private readonly HostlifyDB _hostlifyDb;

    public FlatRepository(HostlifyDB hostlifyDb)
    {
        _hostlifyDb = hostlifyDb;
    }

    public async Task<bool> deleteFlat(int id)
    {
        using (var transacction = await _hostlifyDb.Database.BeginTransactionAsync())
        {
            try
            {
                var existingFlat = await _hostlifyDb.Flats.FindAsync(id);

                existingFlat.IsActive = false;
                existingFlat.DateUpdated = DateTime.Now;

                _hostlifyDb.Flats.Update(existingFlat);
                await _hostlifyDb.SaveChangesAsync();
                _hostlifyDb.Database.CommitTransactionAsync();
            }
            catch (Exception ex)
            {
                await _hostlifyDb.Database.RollbackTransactionAsync();
            }
        }

        return true;
    }

    public async Task<List<Flat>> getAll()
    {
        return await _hostlifyDb.Flats.Where(flat => flat.IsActive == true)
           .ToListAsync();
    }

    public async Task<Flat> getFlatforGuestId(int guestId)
    {
        return await _hostlifyDb.Flats
            .SingleOrDefaultAsync(flat => flat.GuestId == guestId);
    }

    public async Task<List<Flat>> getFlatsforManagerId(int managerId)
    {
        return await _hostlifyDb.Flats.Where(flat => flat.IsActive == true && flat.ManagerId ==managerId)
           .ToListAsync();
    }

    public async Task<bool> postflat(Flat flat)
    {
        using (var transacction = await _hostlifyDb.Database.BeginTransactionAsync())
        {
            try
            {
                await _hostlifyDb.Flats.AddAsync(flat);
                await _hostlifyDb.SaveChangesAsync();
                await transacction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transacction.RollbackAsync();
            }
            finally
            {
                await transacction.DisposeAsync();
            }
        }

        return true;
    }

    public async Task<bool> updateflat(int id, Flat flat)
    {
        using (var transacction = await _hostlifyDb.Database.BeginTransactionAsync())
        {
            try
            {
                var existingFlat = await _hostlifyDb.Flats.FindAsync(id);;

                existingFlat.flatName = flat.flatName;
                existingFlat.GuestId= flat.GuestId;
                existingFlat.Status = flat.Status;
                existingFlat.Price= flat.Price;
                existingFlat.Initialdate= flat.Initialdate;
                existingFlat.EndDate= flat.EndDate;
                existingFlat.DateUpdated = DateTime.Now;

                _hostlifyDb.Flats.Update(existingFlat);
                await _hostlifyDb.SaveChangesAsync();
                _hostlifyDb.Database.CommitTransactionAsync();
            }
            catch (Exception ex)
            {
                await _hostlifyDb.Database.RollbackTransactionAsync();
            }
        }

        return true;
    }
}
