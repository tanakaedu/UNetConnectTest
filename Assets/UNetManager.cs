using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class UNetManager : NetworkManager {
    /** 表示*/
    public Text textInfo;
    /** クライアントの接続数*/
    int iClientCount;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        textInfo.text = ""+iClientCount;
	}

    /** サーバ上：クライアントが接続*/
    public override void OnServerConnect(NetworkConnection conn)
    {
        iClientCount++;
        base.OnServerConnect(conn);
    }

    /** サーバ上：クライアントが切断*/
    public override void OnServerDisconnect(NetworkConnection conn)
    {
        iClientCount--;
        base.OnServerDisconnect(conn);
    }
}
