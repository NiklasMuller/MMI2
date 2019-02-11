using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prototype.NetworkLobby;
using UnityEngine.Networking;

public class NetworkLobbyHook : LobbyHook
{
    public override void OnLobbyServerSceneLoadedForPlayer(NetworkManager manager, GameObject lobbyPlayer, GameObject gamePlayer)
    {
        LobbyPlayer lobby = lobbyPlayer.GetComponent<LobbyPlayer>();

        PlayerAttributes localPlayer = gamePlayer.GetComponent<PlayerAttributes>();

        localPlayer.pname = lobby.playerName;
        localPlayer.playerColor = lobby.playerColor;
        //localPlayer.playerMonster = lobby.playerMonster;
    }
}
