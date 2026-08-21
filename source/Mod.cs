using System.Reflection;
using SPTarkov.Common.Models.Logging;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;

namespace RandomizzatoreMoreCases;

[Injectable(TypePriority = OnLoadOrder.Preload + 2)]
public class Mod(
    WTTServerCommonLib.WTTServerCommonLib wttCommon,
    ISptLogger<Mod> logger
) : IOnLoad
{
    public async Task OnLoadAsync(CancellationToken cancellationToken)
    {
        var assembly = Assembly.GetExecutingAssembly();

        await wttCommon.CustomItemServiceExtended.CreateCustomItems(assembly);

        logger.Success(
            "[Randomizzatore-MoreCases-3.0.0] Successfully added all cases and assorts to traders!"
        );
    }
}
