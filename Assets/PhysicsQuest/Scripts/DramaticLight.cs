using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
public class DramaticLight : MonoBehaviour {
  [Header("Initialization")]
  public Transform target;

  void Update () {
    transform.forward = target.position - transform.position;
  }
}
