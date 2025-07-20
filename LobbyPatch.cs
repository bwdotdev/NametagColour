using HarmonyLib;

[HarmonyPatch(typeof(MenuPageLobby), "Update")]
public class LobbyPatch
{
  static void Postfix(MenuPageLobby __instance)
  {
    foreach (MenuPlayerListed playerListItem in __instance.menuPlayerListedList)
    {
      var player = playerListItem.playerAvatar;

      playerListItem.playerName.color = player.playerAvatarVisuals.color;
      playerListItem.playerName.alpha = player.voiceChat.isTalking ? 1f : 0.5f;
    }
  }
}