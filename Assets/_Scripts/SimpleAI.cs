 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

 public class SimpleAI: MonoBehaviour
 {
 
     private Transform Player;

     [SerializeField]
     private int MoveSpeed = 4;
     int MaxDist = 10;

     [SerializeField]
     private int minimumDistance = 5;
 
     void Start()
     {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
     }
 
     void Update()
     {
         transform.LookAt(Player);
 
         if (Vector3.Distance(transform.position, Player.position) >= minimumDistance)
         {
 
             transform.position += transform.forward * MoveSpeed * Time.deltaTime;
 
 
 
             if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
             {
                 //Here Call any function U want Like Shoot at here or something
             }
 
         }
     }
 }