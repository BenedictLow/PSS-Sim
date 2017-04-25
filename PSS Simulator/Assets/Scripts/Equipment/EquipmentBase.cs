using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentBase : MonoBehaviour {

    public string _Name = "Base";
    public int _Health = 0;
    public int _Mana = 0;

    //Damage reduction/nullification stats
    public float _Defence = 0.0f;
    public float _MagicDefence = 0.0f;
    public float _Evasion = 0.0f;

    //Physcal and Non-Physical stats
    public float _Endurance = 0.0f; //Affects Health
    public float _Mentality = 0.0f; //Affects Mana
    public float _Strength = 0.0f; //Affects physical based damage
    public float _Speed = 0.0f; //Affects evasion and might affect turn order
    public float _Resistance = 0.0f; //Affects debuff resistance rate
    public float _Recovery = 0.0f; //Affects healing and debuff success rate

    private CharacterBase _Character;

    // Use this for initialization
    void Start ()
    {
        _Character = this.gameObject.GetComponent<CharacterBase>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddToCharaStats()
    {
        _Character._Health += _Health;
        _Character._Mana += _Mana;

        _Character._Defence += _Defence;
        _Character._MagicDefence += _MagicDefence;
        _Character._Evasion += _Evasion;

        _Character._Endurance += _Endurance;
        _Character._Mentality += _Mentality;
        _Character._Strength += _Strength;
        _Character._Speed += _Speed;
        _Character._Resistance += _Resistance;
        _Character._Recovery += _Recovery;

    }
}
