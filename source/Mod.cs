using System.Reflection;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Utils;

namespace RandomizzatoreMoreCases;

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 2)]
public class Mod(
    WTTServerCommonLib.WTTServerCommonLib wttCommon,
    ISptLogger<Mod> logger
) : IOnLoad
{
    public async Task OnLoad()
    {
        var assembly = Assembly.GetExecutingAssembly();

        await wttCommon.CustomItemServiceExtended.CreateCustomItems(assembly);

        logger.Success(
            "[Randomizzatore-MoreCases-1.1.0] Successfully added all cases and assorts to traders!"
        );
    }
}
