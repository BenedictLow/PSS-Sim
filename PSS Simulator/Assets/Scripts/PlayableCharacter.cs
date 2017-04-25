using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayableCharacter : CharacterBase {

    public HeadEquipment _HeadEquip;
    public BodyEquipment _BodyEquip;
    public ArmEquipment _ArmEquip;
    public LegEquipment _LegEquip;

	// Use this for initialization
	void Start ()
    {
        AddAllEquipmentStats();
        Debug.Log(_Health);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void AddToCharaStats(EquipmentBase _Equips)
    {
        if (_Equips)
        {
            _Health = _Health + _Equips._Health;
            _Mana += _Equips._Mana;

            _Defence += _Equips._Defence;
            _MagicDefence += _Equips._MagicDefence;
            _Evasion += _Equips._Evasion;

            _Endurance += _Equips._Endurance;
            _Mentality += _Equips._Mentality;
            _Strength += _Equips._Strength;
            _Speed += _Equips._Speed;
            _Resistance += _Equips._Resistance;
            _Recovery += _Equips._Recovery;
        }
        else
            Debug.Log("NullEquips");

    }

    void AddAllEquipmentStats()
    {
        if (_HeadEquip)
            AddToCharaStats(_HeadEquip);
        else
            Debug.Log("Null Head");

        if (_BodyEquip)
            AddToCharaStats(_BodyEquip);
        else
            Debug.Log("Null Body");

        if (_ArmEquip)
            AddToCharaStats(_ArmEquip);
        else
            Debug.Log("Null Arm");

        if (_LegEquip)
            AddToCharaStats(_LegEquip);
        else
            Debug.Log("Null Leg");
    }
}
