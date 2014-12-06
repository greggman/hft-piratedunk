using UnityEngine;
using System.Collections;
using HappyFunTimes;

public class LevelManager : MonoBehaviour {

    public int numLocalPlayers = 0;

    private LocalNetPlayer[] m_localPlayers;

    void Start () {
        numLocalPlayers = System.Math.Max(System.Math.Min(numLocalPlayers, 2000), 0);
        m_localPlayers = new LocalNetPlayer[numLocalPlayers];

        PlayerSpawner spawner = GetComponent<PlayerSpawner>();
        for (int ii = 0; ii < numLocalPlayers; ++ii) {
            LocalNetPlayer localPlayer = new LocalNetPlayer(spawner.GameServer);
            m_localPlayers[ii] = localPlayer; //
            spawner.StartLocalPlayer(localPlayer);
        }
    }
}
