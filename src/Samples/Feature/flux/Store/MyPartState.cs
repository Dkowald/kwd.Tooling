using Fluxor;

namespace Samples.Feature.flux.Store;

[FeatureState]
public record MyPartState
{
  [ReducerMethod]
  public static MyPartState OnMyClickAction(MyPartState state /*, MyClickAction action*/)
    => state with { };
}