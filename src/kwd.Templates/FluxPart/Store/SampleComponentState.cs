using Fluxor;

namespace kwd.Templates.FluxPart.Store;

[FeatureState]
public record SampleComponentState
{
  [ReducerMethod]
  public static SampleComponentState OnMyClickAction(SampleComponentState state /*, MyClickAction action*/)
    => state with { };
}