using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class KteiBase : MonoBehaviour
{

    /// <summary>アイテムを取った時に鳴る効果音</summary>
    [Tooltip("アイテムを取った時に鳴らす効果音")]
    [SerializeField] AudioClip m_sound = default;

    public abstract void Activate();

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -5.5f)
         {
             Destroy(gameObject);
         }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (m_sound)
        {
            AudioSource.PlayClipAtPoint(m_sound, Camera.main.transform.position);
        }

        if (collision.gameObject.tag.Equals("Player"))
        {
            Activate();
            Destroy(gameObject);
        }
    }

}
