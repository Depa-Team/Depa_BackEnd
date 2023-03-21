
using Hostlify.Infraestructure.Models;

namespace Hostlify.Infraestructure;
public interface IFlatRepository
{
    Task<List<Flat>> getAll();
    Task<List<Flat>> getFlatsforManagerId(int managerId);
    Task<Flat> getFlatforGuestId(int guestId);
    Task<bool> postflat(Flat flat);
    Task<bool> updateflat(int id, Flat flat);
    Task<bool> deleteFlat(int id);
}
