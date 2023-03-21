using Hostlify.Infraestructure;
using Hostlify.Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostlify.Domain;
public interface IFlatDomain
{
    Task<List<Flat>> getAll();
    Task<List<Flat>> getFlatsforManagerId(int managerId);
    Task<Flat> getFlatforGuestId(int guestId);
    Task<bool> postFlat(Flat flat);
    Task<bool> updateFlat(int id, Flat flat);
    Task<bool> deleteFlat(int id);
}
