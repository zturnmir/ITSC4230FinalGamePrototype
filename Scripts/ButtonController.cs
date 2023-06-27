using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonController : MainMenuController
{

    private Animator anim;
    public Opponent opp;
    public User user;
    public int setChoice;
    public int oppChoice;
    public float temp;
    public float temp2;
    public float dmg;
    public Image userHealthBar;
    public float healthAmountUser = 100f;
    public Image oppHealthBar;
    public float healthAmountOpp = 100f;
    public Button UltimateButton;
    public Button rockB;
    public Button scissorB;
    public Button paperB;
    public bool ultimateUsed = false;
    public bool ultimateActivated = false;
    public bool ultimateUsedOpp = false;
    public bool ultimateActivatedOpp = false;
    public int oppRand;


    void Awake(){
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        float input = getInput();
        opp = new Opponent(100f, input, false);
        user = new User(100f, 10f, false);
        Debug.Log("Damage is: " + opp.getOppDamage());
    }

    void Update(){
        if(user.getHealth() <=50f && ultimateUsed != true){
            UltimateButton.enabled = true;
        }
        else{
            UltimateButton.enabled = false;
        }

        if(opp.getOppHealth() <= 50f && ultimateUsedOpp != true){
            ultimateActivatedOpp = true;
            ultimateUsedOpp = true;
        }
        if(user.getHealth() <= 0){
            SceneManager.LoadScene("Death Screen");
        }
        else if(opp.getOppHealth() <= 0){
            SceneManager.LoadScene("Victory Screen");
        }
    }

    public void Restart(){
        SceneManager.LoadScene("Gameplay");
    }
    
    public void Exit(){
        SceneManager.LoadScene("Main Menu");
        
    }

    public void Paper(){
        
        setChoice = 1;
        oppChoice = Random.Range(0, 3);
        oppRand = oppChoice;
        Debug.Log("User: Paper");
        if(oppRand == 0){
            Debug.Log("Opponent: Rock");
        }
        else if (oppRand == 1){
            Debug.Log("Opponent: Paper");
        }
        else {
            Debug.Log("Opponent: Scissors");
        }
        result(); 
        Debug.Log("User Health: " + user.getHealth());
        Debug.Log("Opponent Health " + opp.getOppHealth());
        anim.SetBool("PAnimation", true);
        // user.pAnimation();
    }

    public void Rock(){
        setChoice = 0;
        oppChoice = Random.Range(0, 3);
        oppRand = oppChoice;
        Debug.Log("User: Rock");
        if(oppRand == 0){
            Debug.Log("Opponent: Rock");
        }
        else if (oppRand == 1){
            Debug.Log("Opponent: Paper");
        }
        else {
            Debug.Log("Opponent: Scissors");
        }
        result();
        Debug.Log("User Health: " + user.getHealth());
        Debug.Log("Opponent Health " + opp.getOppHealth());
        anim.SetBool("RAnimation", true);
        // user.rAnimation();
    }

    public void Scissors(){
        setChoice = 2;
        oppChoice = Random.Range(0, 3);
        oppRand = oppChoice;
        Debug.Log("User: Scissors");
        if(oppRand == 0){
            Debug.Log("Opponent: Rock");
        }
        else if (oppRand == 1){
            Debug.Log("Opponent: Paper");
        }
        else {
            Debug.Log("Opponent: Scissors");
        }
        result();
        Debug.Log("User Health: " + user.getHealth());
        Debug.Log("Opponent Health " + opp.getOppHealth());
        anim.SetBool("SAnimation", true);
        // user.sAnimation();
    }

    public void Ultimate(){
        ultimateActivated = true;
        ultimateUsed = true;
    }

    public void result(){
        if(setChoice == oppChoice){
            if(ultimateActivated != false){
                temp = opp.getOppHealth();
                takeDamageOpp(temp);
                opp.setOppHealth(0);
                ultimateActivated = false;
            }
            else if(ultimateActivatedOpp!= false){
                temp = user.getHealth();
                takeDamageUser(temp);
                user.setHealth(0);
                ultimateActivatedOpp = false;
            }
            else{
                temp = opp.getOppDamage();
                temp2 = user.getDamage();
                opp.setOppDamage(temp*2);
                user.setDamage(temp2*2);
            }
        }
        else if (setChoice == 1 && oppChoice == 0){
            temp = opp.getOppHealth();
            temp2 = user.getDamage();
            takeDamageOpp(temp2);
            opp.setOppHealth(temp-temp2);
            opp.setOppDamage(input);
            user.setDamage(10f);
            ultimateActivated = false;
            ultimateActivatedOpp = false;
        }
        else if (setChoice == 0 && oppChoice == 2){
            temp = opp.getOppHealth();
            temp2 = user.getDamage();
            takeDamageOpp(temp2);
            opp.setOppHealth(temp-temp2);
            opp.setOppDamage(input);
            user.setDamage(10f);
            ultimateActivated = false;
            ultimateActivatedOpp = false;
        }
        else if (setChoice == 2 && oppChoice == 1){
            temp = opp.getOppHealth();
            temp2 = user.getDamage();
            takeDamageOpp(temp2);
            opp.setOppHealth(temp-temp2);
            opp.setOppDamage(input);
            user.setDamage(10f);
            ultimateActivated = false;
            ultimateActivatedOpp = false;
        }
        else if (setChoice == 0 && oppChoice == 1){
            temp = user.getHealth();
            temp2 = opp.getOppDamage();
            takeDamageUser(temp2);
            user.setHealth(temp-temp2);
            opp.setOppDamage(input);
            user.setDamage(10f);
            ultimateActivated = false;
            ultimateActivatedOpp = false;
        }
        else if (setChoice == 1 && oppChoice == 2){
            temp = user.getHealth();
            temp2 = opp.getOppDamage();
            takeDamageUser(temp2);
            user.setHealth(temp-temp2);
            opp.setOppDamage(input);
            user.setDamage(10f);
            ultimateActivated = false;
            ultimateActivatedOpp = false;
        }
        else if(setChoice == 2 && oppChoice == 0){
            temp = user.getHealth();
            temp2 = opp.getOppDamage();
            takeDamageUser(temp2);
            user.setHealth(temp-temp2);
            opp.setOppDamage(input);
            user.setDamage(10f);
            ultimateActivated = false;
            ultimateActivatedOpp = false;
        }
        else{
            Debug.Log("error");
        }
    }

    public void takeDamageUser(float damage){
        healthAmountUser -= damage;
        userHealthBar.fillAmount = healthAmountUser / 100f;
    }

    public void takeDamageOpp(float damage){
        healthAmountOpp -= damage;
        oppHealthBar.fillAmount = healthAmountOpp / 100f;
    }

    
}
