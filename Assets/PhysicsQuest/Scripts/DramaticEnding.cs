using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DramaticEnding : MonoBehaviour {
  [Header("Initialization")]
  public GameObject theBall;
  public GameObject brilliant;

  void OnTriggerEnter (Collider c) {
    if (c.gameObject == theBall) {
      brilliant.SetActive(true);
      this.gameObject.SetActive(false);
    }
  }
}
