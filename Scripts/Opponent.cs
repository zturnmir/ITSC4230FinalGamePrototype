using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour
{
    
    private float oppHealth = 100f;

    
    private float oppDamage = 0f;

    private bool oppUltimate = false;

    private Animator oppAnim;

    
    public Opponent(float oppHealth, float oppDamage, bool oppUltimate){
        this.oppHealth = oppHealth;
        this.oppDamage = oppDamage;
        this.oppUltimate = oppUltimate;
    }


    public void setOppHealth(float oppHealth){
        this.oppHealth = oppHealth;
    }
    
    public float getOppHealth(){
        return oppHealth;
    }

    public void setOppDamage(float oppDamage){
        this.oppDamage = oppDamage;
    }
    
    public float getOppDamage(){
        return oppDamage;
    }

    public void setOppUltimate(){
        this.oppUltimate = oppUltimate;
    }

    public bool getOppUltimate(bool oppUltimate){
        return oppUltimate;
    }
}
