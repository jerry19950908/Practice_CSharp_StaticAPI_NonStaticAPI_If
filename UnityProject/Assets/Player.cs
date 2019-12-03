using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("血量")]
    public float hp = 100;
    [Header("攻擊")]
    public float atk;
    [Header("音源")]
    public AudioSource aud ;
    [Header("音效")]
    public AudioClip soundatk;

    [Header("殭屍")]
    public Zombie zombie;

    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            aud.PlayOneShot(soundatk, 2f);
            atk = Random.Range(10f, 30f);
            zombie.Hurt(atk); //殭屍.受到傷害 (玩家的atk)
        }
    }


    private void Update()
    {
        Attack();
    }


    public void Hurt(float dam)  //這邊的dam等於僵屍的攻擊力
    {
        hp = hp - dam;
        print("<color=blue>玩家受到傷害：" + dam + "</color>");
        print("<color=blue>玩家剩下血量：" + hp + "</color>");

        if (hp <= 0)
        {
            Dead();
        }
    }


    private void Dead()
    {
        print("<color=blue>玩家死亡</color>");
        

    }


}
