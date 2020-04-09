using UnityEngine;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 怪物的血量
    /// </summary>
    [Header("血量"), Tooltip("怪物的血量"), Range(50,500)]
    public int health;
    /// <summary>
    /// 怪物的魔力
    /// </summary>
    [Header("魔力"), Tooltip("怪物的魔力"), Range(10, 100)]
    public int mana = 100;
    /// <summary>
    /// 怪物的速度
    /// </summary>
    [Header("能力值"), Tooltip("怪物的速度"), Range(1,50.5f)]
    public float speed = 10.5f;
    /// <summary>
    /// 怪物的攻擊力
    /// </summary>
    [ Tooltip("怪物的攻擊力"), Range(20, 200)]
    public int attack = 50;
    /// <summary>
    /// 怪物的防禦力
    /// </summary>
    [Tooltip("怪物的防禦力"), Range(0, 100)]
    public int defense;
    /// <summary>
    /// 武器
    /// </summary>
    [Header("裝備")]
    public string weapon;
    /// <summary>
    /// 裝備
    /// </summary>
    public string equipment = "皮衣";
    /// <summary>
    /// 怪物是否帶有鑰匙
    /// </summary>
    [Header("其他資料"), Tooltip("怪物是否帶有鑰匙")]
    public bool key;
    /// <summary>
    /// 怪物是否帶有寶物
    /// </summary>
    [Tooltip("怪物是否帶有寶物")]
    public bool treasure;

}
