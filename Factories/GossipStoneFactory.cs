using PathTrainingOoTRandomizer.Builders;
using PathTrainingOoTRandomizer.Helpers;
using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Factories
{
    public class GossipStoneFactory
    {
    }
    public interface IProduct
    {
        GossipStone Operation();
    }

    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public GossipStone FOperation()
        {
            var gossipStone = FactoryMethod();

            return (GossipStone)gossipStone;
        }
    }
    /*
    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new GossipStone();
        }
    }
    */
}
