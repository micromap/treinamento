namespace Exercicios.Domain
{
    public static class PetExtensions
    {
        public static string GetTipo(this IPet pet)
        {
            return pet.GetType().Name;
        }
    }
}
