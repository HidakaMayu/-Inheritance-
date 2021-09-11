using UnityEngine;

public class Fruits : KteiBase
{
    /// <summary>取った時に加点する値</summary>
    public int m_score;

    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddScore(m_score);
    }
}