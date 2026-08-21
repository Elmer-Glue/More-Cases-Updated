using SPTarkov.Server.Core.Models.Spt.Mod;
using Range = SemanticVersioning.Range;

namespace RandomizzatoreMoreCases;

public record ModMetadata : IModMetadata
{
    public string ModGuid { get; init; } = "com.randomizzatore.morecases";
    public string Name { get; init; } = "MoreCases";
    public string Author { get; init; } = "Randomizzatore";
    public List<string>? Contributors { get; init; } = null;
    public SemanticVersioning.Version Version { get; init; } = new("3.0.0");

    public Range SptVersion { get; init; } = new("~4.1.0");

    public List<string>? Incompatibilities { get; init; } = null;

    public string License { get; init; } = "MIT";
    public string? Url { get; init; } = null;
    public bool HasPrepatcher { get; init; } = false;

    public Dictionary<string, Range>? ModDependencies { get; init; } = new()
    {
        { "com.wtt.commonlib", new Range("~3.0.0") }
    };
}
