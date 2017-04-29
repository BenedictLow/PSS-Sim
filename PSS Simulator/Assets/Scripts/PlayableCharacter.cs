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
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
            Debug.Log("NumPad 1");

        if (Input.GetKeyDown(KeyCode.Keypad2))
            Debug.Log("Num Pad 2");

        if (Input.GetKeyDown(KeyCode.Keypad3))
            Debug.Log("Num Pad 3");

        if (Input.GetKeyDown(KeyCode.Keypad4))
            Debug.Log("Num Pad 4");

        if (Input.GetKeyDown(KeyCode.Keypad5))
            Debug.Log("Num Pad 5");

        if (Input.GetKeyDown(KeyCode.Keypad6))
            Debug.Log("Num Pad 6");

        if (Input.GetKeyDown(KeyCode.Keypad7))
            Debug.Log("Num Pad 7");

        if (Input.GetKeyDown(KeyCode.Keypad8))
            Debug.Log("Num Pad 8");

        if (Input.GetKeyDown(KeyCode.Keypad9))
            Debug.Log("Num Pad 9");
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

    void NumPadInputs()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
            Debug.Log("NumPad 1");

        if (Input.GetKeyDown(KeyCode.Keypad2))
            Debug.Log("Num Pad 2");

        if (Input.GetKeyDown(KeyCode.Keypad3))
            Debug.Log("Num Pad 3");

        if (Input.GetKeyDown(KeyCode.Keypad4))
            Debug.Log("Num Pad 4");

        if (Input.GetKeyDown(KeyCode.Keypad5))
            Debug.Log("Num Pad 5");

        if (Input.GetKeyDown(KeyCode.Keypad6))
            Debug.Log("Num Pad 6");

        if (Input.GetKeyDown(KeyCode.Keypad7))
            Debug.Log("Num Pad 7");

        if (Input.GetKeyDown(KeyCode.Keypad7))
            Debug.Log("Num Pad 8");

        if (Input.GetKeyDown(KeyCode.Keypad9))
            Debug.Log("Num Pad 9");
    }
}
