using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53;
    public void Magic()
    {
        if (mp>=5)
        {
            mp -= 5; 
            Debug.Log("���@�U���������B�c��MP��" + mp);
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}
public class kadai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss magicboss = new Boss();
        magicboss.Magic();
        for (int i = 0; i<10;i++)
        {
            magicboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
