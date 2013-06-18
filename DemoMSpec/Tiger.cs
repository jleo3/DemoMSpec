using Machine.Specifications;

#region ResharperDisable

// ReSharper disable InconsistentNaming 
// ReSharper disable CheckNamespace
// ReSharper disable UnusedMember.Local

#endregion
namespace DemoMSpec
{
    public class Tiger
    {
        public string Poke(IPoker poker)
        {
            if (poker.IsAnnoying())
                return "Growl";
            if (poker.IsInstigating())
                return "Swipe with Claw";
            return "Purrrr";
        }
    }
}
