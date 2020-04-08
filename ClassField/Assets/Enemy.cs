using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("血量"), Tooltip("怪物的血量"), Range(50,500)]
    public int health;
    [Header("魔力"), Tooltip("怪物的魔力"), Range(10, 100)]
    public int mana = 100;
    [Header("能力值"), Tooltip("怪物的能力值"), Range(1,50.5f)]
    public float speed = 10.5f;
    [Header("攻擊力"), Tooltip("怪物的攻擊力"), Range(20, 200)]
    public float attack = 50;
    [Header("防禦力"), Tooltip("怪物的防禦力"), Range(0, 100)]
    public float defense;
    [Header("裝備")]
    public string weapon;
    public string equipment = "皮衣";
    [Header("其他資料"), Tooltip("怪物是否帶有鑰匙")]
    public bool key;
    [Tooltip("怪物是否帶有寶物")]
    public bool treasure;


}
