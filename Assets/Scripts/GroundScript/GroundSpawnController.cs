using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{

    public GameObject lastGroundObject;
    [SerializeField] private GameObject groundPrefab;
    private GameObject newGroundObject;

/*
    private static GroundSpawnController instance;

    public static GroundSpawnController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<GroundSpawnController>();

            }
            return GroundSpawnController.instance;
        }

    }
*/
    private int groundDirection;



    void Start()
    {
        GenerateRandomNewGrounds();

    }

    // Update is called once per frame
    private void GenerateRandomNewGrounds()
    {
        for (int i = 0; i < 60; i++)
        {
            CreateNewGround();
        }
    }

    public void CreateNewGround()
    {
        groundDirection = Random.Range(0, 2);

        if (groundDirection == 0)
        {
            newGroundObject = (GameObject)Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x - 1f, lastGroundObject.transform.position.y, lastGroundObject.transform.position.z), Quaternion.identity);
            lastGroundObject = newGroundObject;
        }
        else
        {
            newGroundObject = (GameObject)Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x, lastGroundObject.transform.position.y, lastGroundObject.transform.position.z + 1f), Quaternion.identity);
            lastGroundObject = newGroundObject;
        }

        int spawnPickup = Random.Range(0, 15);
        
        if (spawnPickup == 0)
        {
            lastGroundObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
   
}
