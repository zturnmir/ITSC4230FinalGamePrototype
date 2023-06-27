using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    private float Health;

    private float Damage;

    private bool Ultimate;

    private Animator anim;

    void Awake(){
        anim = GetComponent<Animator>();
    }
    public User(float Health, float Damage, bool Ultimate){
        this.Health = Health;
        this.Damage = Damage;
        this.Ultimate = Ultimate;
    }

    /*public void sAnimation(){
        anim.SetBool("SAnimation", true);
    }
    public void rAnimation(){
        anim.SetBool("RAnimation", true);
    }
    public void pAnimation(){
        anim.SetBool("PAnimation" , true);
    }
    */
    public void setHealth(float Health){
        this.Health = Health;
    }
    
    public float getHealth(){
        return Health;
    }

    public void setDamage(float Damage){
        this.Damage = Damage;
    }
    
    public float getDamage(){
        return Damage;
    }

    public void setUltimate(){
        this.Ultimate = Ultimate;
    }

    public bool getUltimate(bool Ultimate){
        return Ultimate;
    }
}
