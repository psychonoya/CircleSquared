using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralSpawnerController : MonoBehaviour
{

    public GameObject smallCircle;
    public GameObject colorChanger;
    public GameObject spawner;
    public LevelController levelController;
    private bool neverDone = true;


    private Vector2 startPos;

    public Vector2 circleAddedPos;

    public Vector2 colorChangerAddedPos;

    public Vector2 nextSpawnerAddedPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(neverDone)
        {
            levelController.AddPoints(15);
            Instantiate(smallCircle, (startPos + circleAddedPos), Quaternion.identity);
            levelController.smallCircle.Add(smallCircle);
            Instantiate(colorChanger, (startPos + colorChangerAddedPos), Quaternion.identity);
            levelController.colorChanger.Add(colorChanger);
            Instantiate(spawner, (startPos + nextSpawnerAddedPos), Quaternion.identity);
            levelController.spawners.Add(spawner);
            neverDone = false;
        }

    }
}