using UnityEngine;

public class Banana : KteiBase
{
    /// <summary>取った時に加点する値</summary>
    int m_score = 50;

    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddScore(m_score);
    }
}