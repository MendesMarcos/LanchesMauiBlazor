using LanchesLibrary.Data;

namespace LanchesMauiBlazor.Data
{
   public class LancheService : ILancheService
   {
      public async Task<IEnumerable<Lanche>>? LoadLanchesAsync()
      {
         await Task.Delay(1000);

         var lanches = new[]
         {
         new Lanche("Pão de batata", "Pão de batata com batata"),
         new Lanche("Pizza de mussarela", "mussarela com tomate"),
         new Lanche("Pizza de calabresa", "calabresa e cebola"),
         new Lanche("Misto Quente", "Pão de forma, presunto e queijo"),
         };
         return lanches;
      }
   }
}
