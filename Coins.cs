using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Coins : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
 
        Player player = other.GetComponent<Player>();
 
        //The number of coins is updated
        player.CollectCoins();
 
        //The coin that was collected is destroyed
        Destroy(gameObject);
    }
 
}
