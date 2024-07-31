using Alura.Adopet.Console.Modelos;
using FluentResults;

namespace Alura.Adopet.Console.Util
{
    public class SucessWithPets:Success
    {
        public IEnumerable<Pet> Data { get; }
        public SucessWithPets(IEnumerable<Pet> data)
        {
            Data = data;
        }

    }
}
