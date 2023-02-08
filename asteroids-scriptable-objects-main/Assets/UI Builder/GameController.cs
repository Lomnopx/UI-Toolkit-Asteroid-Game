using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameControllerScriptableObject", menuName = "ScriptableObjects/GameController")]
public class GameController : ScriptableObject
{
    //player stats
    public int playerHealth=100;
    public int playerMaxHealth=100;
    public float playerSpeed=0;
    public bool godmode=false;
    

    //Asteroid stats
    public float asteroidSpeedMin=0;
    public float asteroidSpeedMax=0;
    public int asteroidDmg=1;
    public float asteroidRotationMin=0;
    public float asteroidRotationMax=0;
}

