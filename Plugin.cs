using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using BepInEx.Logging;
using EFT.InventoryLogic;
using EFT.UI;
using HarmonyLib;
using UnityEngine;

namespace ContextMenuWhileSearching;

[BepInPlugin("com.zzzNIKOzzz.contextmenuwhilesearching", "ContextMenuWhileSearching", "1.0.0")]
public class Plugin : BasePlugin
{
    public static ConfigEntry<bool> Enabled = null!;
    public static ManualLogSource Logger = null!;

    public override void Load()
    {
        Logger = Log;
        Logger.LogInfo("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
        Logger.LogInfo("ContextMenuWhileSearching by zzzNIKOzzz is loading... ... ... ... ... ... ... ...");
        Logger.LogInfo("zzzNIKOzzz: Невозможно открыть контекстное меню во время поиска? Ой, да не пизди)");
        Logger.LogInfo("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");

        Enabled = Config.Bind("General", "Enable", true, "Allow context menu while searching containers");
        new Harmony("com.zzzNIKOzzz.contextmenuwhilesearching").PatchAll();
    }
}

[HarmonyPatch(typeof(ItemUiContext), nameof(ItemUiContext.ShowContextMenu))]
public class ShowContextMenuPatch
{
    public static bool Prefix(ItemUiContext __instance, ItemContext itemContext, Vector2 position)
    {
        if (!Plugin.Enabled.Value)
            return true;

        var interactions = __instance.GetItemContextInteractions(itemContext);
        __instance.ContextMenu.Show(position, interactions, null, itemContext.Item);
        return false;
    }
}
