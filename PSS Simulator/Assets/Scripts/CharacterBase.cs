using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour {
    //Basic Stats all characters will have
    public string _Name;
    public int _Health;
    public int _Mana;

    //Damage reduction/nullification stats
    public float _Defence;
    public float _MagicDefence;
    public float _Evasion;

    //Physcal and Non-Physical stats
    public float _Endurance; //Affects Health
    public float _Mentality; //Affects Mana
    public float _Strength; //Affects physical based damage
    public float _Speed; //Affects evasion and might affect turn order
    public float _Resistance; //Affects debuff resistance rate
    public float _Recovery; //Affects healing and debuff success rate

    //Extra stats
    public float _StateOfMind;//Will be the deciding factor to toggle Normal/Rage/Break mode

    private float _Attack;
    
    private float _MAttack;    

    //In short, the target and power of the spell are determined by the Magician's mind whereas the nature of the spell is determined by the Activation Sequence.

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Death()
    {
        Debug.Log(_Name + " has died.");
    }

    void AddToAttack(float _AddAttack)
    {
        _Attack += _AddAttack;
    }

    void AddToMAttack(float _AddMAttack)
    {
        _MAttack += _AddMAttack;
    }
}
