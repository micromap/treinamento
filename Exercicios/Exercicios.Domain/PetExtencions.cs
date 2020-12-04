namespace Exercicios.Domain
{
    public static class PetExtencions
    {
        public static string GetTipo(this IPet pet)
        {
            return pet.GetType().Name;
        }
    }
}
