using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
public class Spiderweb : MonoBehaviour {
  [Header("Initialization")]
  public Transform spider;
  public Transform stickTo;
  public LineRenderer line;

  void Reset () {
    line = GetComponent<LineRenderer>();
  }

  void Update () {
    line.SetPosition(0, stickTo.position);
    line.SetPosition(1, spider.position);
  }
}
