using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    const int MaxScore = 100;
    int score = 10;
    // Using float to get the correct value of the division
    float percent = ((float)score / MaxScore) * 100;
    print("The value of the division is " + percent + "%");


  }


}
