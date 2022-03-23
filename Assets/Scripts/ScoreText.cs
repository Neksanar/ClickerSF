using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private int _score = 0;


    private void Start()
    {
        GlobalEventManager.OnDamageHit += EnemyDamage;
    }



    void EnemyDamage()
    {
        _score++;
        GetComponent<Text>().text = "Score: "+_score;
    }
}
