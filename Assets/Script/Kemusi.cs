using UnityEngine;

public class Kemusi : KteiBase
{
    [SerializeField] int m_DeathLife = 20;

    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddLife(m_DeathLife);
    }
}
