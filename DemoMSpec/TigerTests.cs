using Machine.Fakes;
using Machine.Specifications;

#region ResharperDisable

// ReSharper disable InconsistentNaming 
// ReSharper disable CheckNamespace
// ReSharper disable UnusedMember.Local

#endregion
namespace DemoMSpec
{

    class TigerSpec : WithFakes
    {
        protected static Tiger Tiger;
        protected static IPoker IPoker;

        Establish context = () =>
            {
                IPoker = An<IPoker>();
                Tiger = new Tiger();
            };
    }

    [Subject(typeof (Tiger), "Poking the tiger")]
    class when_poking_the_tiger_with_your_finger : TigerSpec
    {
        Establish context = () => IPoker.WhenToldTo(x => x.IsAnnoying()).Return(true);

        It will_annoy_him = () => Tiger.Poke(IPoker).ShouldEqual("Growl");
    }

    class when_poking_the_tiger_with_a_stick : TigerSpec
    {
        Establish context = () => IPoker.WhenToldTo(x => x.IsInstigating()).Return(true);

        It will_make_him_swipe = () => Tiger.Poke(IPoker).ShouldEqual("Swipe with Claw");
    }

    class when_poking_the_tiger_with_a_stake : TigerSpec
    {
        Establish context = () => IPoker.WhenToldTo(x => x.IsDangerous()).Return(true);

        It will_make_him_attack = () => Tiger.Poke(IPoker).ShouldEqual("Maul");
    }
}
