using UnityEngine;

public class Zombie: MonoBehaviour
{
    [Header("血量")]
    public float hp = 50;
    [Header("攻擊")]
    public float atk;
    [Header("音源")]
    public AudioSource aud;
    [Header("音效")]
    public AudioClip soundatk;

    [Header("玩家")]
    public Player player;
        

    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            aud.PlayOneShot(soundatk, 2f);
            atk = Random.Range(20f, 60f);
            player.Hurt(atk); //玩家.受到的傷害(殭屍的atk)
        }
    }



    private void Update()
    {
        Attack();
    }



    public void Hurt(float dam) //這邊的dam 等於玩家的攻擊力
    {
        hp = hp - dam;
        print("<color=red>殭屍受到傷害：" + dam + "</color>");
        print("<color=red>殭屍受到傷害：" + hp + "</color>");

        if (hp <= 0)
        {
            Dead();
        }
    }


    private void Dead()
    {
        print("<color=red>殭屍死亡</color>");
    }

}
