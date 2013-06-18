using Machine.Specifications;

#region ResharperDisable

// ReSharper disable InconsistentNaming 
// ReSharper disable CheckNamespace
// ReSharper disable UnusedMember.Local

#endregion
namespace DemoMSpec
{

    class TigerSpec
    {
        protected static Tiger Tiger;
        protected static Finger Finger;

        Establish context = () => Tiger = new Tiger();
    }

    [Subject(typeof (Tiger), "Poking the Tiger with different Pokers")]
    class when_poking_the_tiger_with_your_finger : TigerSpec
    {
        Establish context = () => Finger = new Finger();

        It will_annoy_him = () => Tiger.Poke(Finger).ShouldEqual("Growl");
    }

    class when_poking_the_tiger_with_a_stick : TigerSpec
    {
        protected static Stick Stick;

        Establish context = () => Stick = new Stick();

        private It will_make_him_attack = () => Tiger.Poke(Stick).ShouldEqual("Swipe with Claw");
    }
}
