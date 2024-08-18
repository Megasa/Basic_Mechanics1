using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        First();
        Battle();
    }
    private void First()
    {
        int a = 1;
        float b = 2.1f;
        bool c = a > 0;

        if (c)
        {
            Debug.LogError(c);
        }

        Debug.LogError(a);
        Debug.LogWarning(b);
    }

    public void Battle()
    {
        float health = 100f;
        float baseDamage = 1.5f;
        int multiplier = 3;

        Debug.LogWarning($"Player {health-(baseDamage*multiplier)} hp");
    }
     
}

    
       


    

