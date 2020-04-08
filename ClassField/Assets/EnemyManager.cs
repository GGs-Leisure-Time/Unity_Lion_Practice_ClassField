using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Header("怪物一號")]
    public Enemy enemy1;
    [Header("怪物二號")]
    public Enemy enemy2;

    private void Start()
    {
        print("怪物一號的魔力" + enemy1.mana);
        print("怪物二號的裝備名稱" + enemy2.equipment);

        enemy1.health = 100;
        enemy2.health = 300;
        enemy1.defense = 50;
        enemy1.weapon = "木棍";
        enemy2.weapon = "短刀";
        enemy1.key = true;
        enemy2.treasure = true;
    }
}
