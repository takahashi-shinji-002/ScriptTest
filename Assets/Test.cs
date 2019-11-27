using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gundalf
{
    int mp = 53;

    public void Magic()
    {

        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else 
        { 
            Debug.Log("MPが足りないため魔法が使えない。");
        }
            
    }
}

public class Test : MonoBehaviour
{

    int[] array1 = { 10, 20, 30, 40, 50 };
 

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i <= 4; i++)
        {
            Debug.Log(array1[i]);
        }

        int[] array2 = { 10, 20, 30, 40, 50 };

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array2[i]);
        }

        Gundalf firstmagic = new Gundalf();

        for (int i = 0; i <= 10; i++)
        {
            firstmagic.Magic();
        }

    }

	// Update is called once per frame
	void Update ()
    {
		
	}
}
 
