using System;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStats : ScriptableObject
{
    //General
    public string _name;
    public string _description;
    public List<string> _type = new List<string>();//Aberration,articficiel,etc.
    public string _size;

    //Misc
    public int _initiative;
    public List<string> _specialSens;//Vision nocturne, etc.
    public List<SBaseMovement> _movement;

    //Defense
    public int _maxHealth;
    public int _vigilance;
    public List<SSavingThrow> _savingThrows;
    public int _lifeRegen;
    public List<SArmorClass> _armorClass;
    public List<SDamageReduction> _damageReduction;
    public List<EResistanceType> _immunity;
    public List<EResistanceType> _resistance;
    public List<EResistanceType> _weakness;
    public List<EResistanceType> _vulnerability;

    //Attack
    public List<SAttack> _attacks;

    //Resources
    public int _stamina;
    public int _mana;

    [Serializable]
    public struct SBaseMovement
    {
        public EMovementType movementType;
        public int speed;
        public enum EMovementType { Ground, Water, Fly, Underground }
    }
    [Serializable]
    public struct SSavingThrow
    {
        public ESavingThrow savingThrow;
        public int savingThrowValue;
        public enum ESavingThrow { Reflex, Vigor, Will }
    }
    [Serializable]
    public struct SArmorClass
    {
        public EArmorClassType armorClassType;
        public int armorClassValue;
        public enum EArmorClassType { Defense, Contact, Depourvue }
    }
    [Serializable]
    public struct SDamageReduction
    {
        public EDamageReductionType damageType;
        public int reductionValue;
        public enum EDamageReductionType { Adamantium, Viridium, Argent, Mythril }
    }
    [Serializable]
    public struct SAttack
    {
        public string attackName;
        public string attackType;
        public int attackValue;
        public string damageDices;
        public int attackBonusDamage;
    }
    public enum EResistanceType { Fire, Cold, Lightning, Acid, Sound, Weakness, Sleep, Poison, Sickness, Physical, Light, Darkness }
}
