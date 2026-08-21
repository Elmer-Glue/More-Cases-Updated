using SPTarkov.Server.Core.Models.Spt.Mod;
using Range = SemanticVersioning.Range;

namespace RandomizzatoreMoreCases;

public record ModMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.randomizzatore.morecases";
    public override string Name { get; init; } = "MoreCases";
    public override string Author { get; init; } = "Randomizzatore";
    public override List<string>? Contributors { get; init; } = null;
    public override SemanticVersioning.Version Version { get; init; } = new("2.0.0");

    public override Range SptVersion { get; init; } = new("~4.0.0");

    public override List<string>? Incompatibilities { get; init; } = null;

    public override bool? IsBundleMod { get; init; } = true;

    public override string License { get; init; } = "MIT";
    public override string? Url { get; init; } = null;

    public override Dictionary<string, Range>? ModDependencies { get; init; } = new()
    {
        { "com.wtt.commonlib", new Range("~2.0.0") }
    };
}
