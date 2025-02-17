﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{
    public GameObject UIScreen;
    public GameObject player;
    public GameObject gameMan;
    public GameObject audioMan;
    public GameObject battleMan;

    public float positionx;
    public float positiony;
    public float positionz;

    // Start is called before the first frame update
    void Start()
    {
        if(UIFade.instance == null)
        {
            UIFade.instance = Instantiate(UIScreen).GetComponent<UIFade>();
        }

        if(PlayerController.instance == null)
        {
            PlayerController clone = Instantiate(player, new Vector3(positionx, positiony, positionz), Quaternion.identity).GetComponent<PlayerController>();
            PlayerController.instance = clone;
        }

        if(GameManager.instance == null)
        {
            Instantiate(gameMan);
        }

        if(AudioManager.instance == null)
        {
            Instantiate(audioMan);
        }

        if(BattleManager.instance == null)
        {
            Instantiate(battleMan);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
