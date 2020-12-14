using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        void UpdateOwner(Owner owner);
        void AddOwner(Owner owner);
        Owner GetOwnerByEmail(string email);
        void DeleteOwner(int ownerId);

    }
}