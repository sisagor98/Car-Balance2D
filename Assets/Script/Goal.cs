using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
      if(other.CompareTag("Car")){
          Debug.Log("Go NextLevel");
      }
    }
}
