using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part1B : MonoBehaviour
{   
    int x = 100;
    int y = 100;
    int sum; 

    // Start is called before the first frame update
    void Start()
    {
        sum = x + y;

        print(sum); // 200

        print(-sum); // -200

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
