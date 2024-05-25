using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    //Diff Monster to go at diff. speed not global // used in monster spawner  so, public
    [HideInInspector]
    public float MonsterMoveForce;

    private Rigidbody2D MonsterBody;
    //Loaded
    void Awake()
    {
        MonsterBody = GetComponent<Rigidbody2D>();
    }

    // Update is called every fixed frame rate
    void FixedUpdate()
    {
        MonsterBody.velocity = new Vector2 (MonsterMoveForce, MonsterBody.velocity.y);
    }
}
