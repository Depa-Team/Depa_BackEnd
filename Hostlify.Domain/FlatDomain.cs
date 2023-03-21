using Hostlify.Infraestructure;
using Hostlify.Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostlify.Domain;
public class FlatDomain : IFlatDomain
{
    private IFlatRepository _FlatRepository;

    public FlatDomain(IFlatRepository flatRepository)
    {
        _FlatRepository = flatRepository;
    }

    public async Task<bool> deleteFlat(int id)
    {
        return await _FlatRepository.deleteFlat(id);
    }

    public async Task<List<Flat>> getAll()
    {
        return await _FlatRepository.getAll();
    }

    public async Task<Flat> getFlatforGuestId(int guestId)
    {
        return await _FlatRepository.getFlatforGuestId(guestId);
    }

    public async Task<List<Flat>> getFlatsforManagerId(int managerId)
    {
        return await _FlatRepository.getFlatsforManagerId(managerId);
    }

    public async Task<bool> postFlat(Flat flat)
    {
        return await _FlatRepository.postflat(flat);
    }

    public async Task<bool> updateFlat(int id, Flat flat)
    {
        return await _FlatRepository.updateflat(id, flat);
    }
}
