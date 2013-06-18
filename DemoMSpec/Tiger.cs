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
        public string Poke(Poker poker)
        {
            if (poker.IsAnnoying())
                return "Growl";
            return "Purrrr";
        }
    }

    public class Poker
    {
        public bool IsAnnoying()
        {
            return true;
        }
    }

    [Subject(typeof (Tiger), "Poking the Tiger with different Pokers")]
    class when_poking_the_tiger_with_your_finger
    {
        protected static Tiger Tiger;
        protected static Poker Finger;

        Establish context = () =>
            {
                Tiger = new Tiger();
                Finger = new Poker();
            };

        It will_annoy_him = () => Tiger.Poke(Finger).ShouldEqual("Growl");
    }
}
