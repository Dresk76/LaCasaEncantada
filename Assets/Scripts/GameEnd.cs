using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private CanvasGroup backgroundWin;
    [SerializeField] private float fadeDuration;
    private bool isPlayer;
    private float timer;



    private void Update()
    {
        if (isPlayer)
        {
            EndLevel();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            isPlayer = true;
        }
    }



    private void EndLevel()
    {
        timer += Time.deltaTime;
        backgroundWin.alpha = timer / fadeDuration;

        if (timer > fadeDuration)
        {
            Console.WriteLine("Salir");
            Application.Quit();
        }
    }
}
