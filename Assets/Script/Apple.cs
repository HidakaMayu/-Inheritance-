using UnityEngine;

public class Apple : KteiBase
{
    /// <summary>取った時に加点する値</summary>
    int m_score = 100;

    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddScore(m_score);
    }
}