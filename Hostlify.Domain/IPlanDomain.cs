using Hostlify.Infraestructure;

namespace Hostlify.Domain;

public interface IPlanDomain
{
    Task<List<Plan>> getAll();

    Task<bool> update(int id, Plan plan);

    Task<bool> post(Plan plan);

    Task<bool> delete(int id);
}