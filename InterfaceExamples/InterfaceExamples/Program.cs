namespace InterfaceExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Interface Examples!");
            IPhysics physics = new Science();
            physics.PhysicCalci();
            IChemistry chemistry= new Science();
            chemistry.ChemistryCalci();
            IBiology biology=new Science();
            biology.BiologyCalci();
            IScience science=new Science();
            
        }
    }
}