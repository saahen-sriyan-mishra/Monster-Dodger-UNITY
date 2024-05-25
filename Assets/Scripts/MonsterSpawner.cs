//using System; //else random function will not work doe to conflict with unity
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    //Adding all monster objects
    [SerializeField]
    private GameObject[] monsterReff;

    //
    private GameObject SpawnedMonsters;

    [SerializeField]
    private Transform leftpos, rightpos;


    //to spawn at
    private int randomMonsterSelector, randomSide;

    // Start is called before the first frame update
    void Start()
    {
        //call function repetedly else  so spawning
        StartCoroutine(SpawnMonster());
    }

    //repeatation code written so ienum. used
    IEnumerator SpawnMonster()
    {
        //run forever else only 1 monster 
        while (true)
        {
            //randomly after every 1-5 seconds spawn the badboys
            yield return new WaitForSeconds(Random.Range(1, 5));

            randomMonsterSelector = Random.Range(0, monsterReff.Length);
            randomSide = Random.Range(0, 2);

            // Instantiate the monster
            SpawnedMonsters = Instantiate(monsterReff[randomMonsterSelector]);

            //Left
            if (randomMonsterSelector == 0)
            {
                SpawnedMonsters.transform.position = leftpos.position; //not .transform.position else null error since "LEFTPOS VARIABLE IS A TRNANSFORM OBJECT"
                SpawnedMonsters.GetComponent<Monster>().MonsterMoveForce = Random.Range(4, 10);
            }

            //Right
            else
            {
                SpawnedMonsters.transform.position = rightpos.position;
                SpawnedMonsters.GetComponent<Monster>().MonsterMoveForce = -Random.Range(4, 10); // - since we need monster to go from right to left
                                                                                                 //Flipping it while walk to face correct direction
                SpawnedMonsters.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
    }



   

}
