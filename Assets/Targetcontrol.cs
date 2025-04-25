using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Targetcontrol : MonoBehaviour
{
    GameObject HP;
    int fullhp = 10;
    float time = 0;
    int rnd = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.HP = GameObject.Find("HP");
    }

    // Update is called once per frame
    void Update()
    {
        //1foward 2back 3left 4right 5=1+3 6=1+4 7=2+3 8=2+4 9stop
        this.time += Time.deltaTime;
        if(this.time > 0.3f)
        {
            this.time = 0.0f;
            this.rnd =Random.Range(1,10);    
        }
        switch(rnd)
        {
            case 1:
            transform.Translate(0,0,-0.1f);
            break;
            case 2:
            transform.Translate(0,0,0.1f);
            break;
            case 3:
            transform.Translate(-0.1f,0,0);
            break;
            case 4:
            transform.Translate(0.1f,0,0);
            break;
            case 5:
            transform.Translate(-0.1f,0,-0.1f);
            break;
            case 6:
            transform.Translate(0.1f,0,-0.1f);
            break;
            case 7:
            transform.Translate(-0.1f,0,0.1f);
            break;
            case 8:
            transform.Translate(0.1f,0,0.1f);
            break;
            case 9:
            transform.Translate(0,0,0);
            break;
        }    
        
    }

    void OnCollisionEnter(Collision other)
    {
        this.fullhp = this.fullhp - 1;
        if(this.fullhp > 0)
        {
            this.HP.GetComponent<Text>().text = "TargetHp:" + fullhp + "/10";
        }else
        {
            this.HP.GetComponent<Text>().text = "YouWin";
        }
        this.rnd = 9;
        this.time = 0.1f;
    }  
}
