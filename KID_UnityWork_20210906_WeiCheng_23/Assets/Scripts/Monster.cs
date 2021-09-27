using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("┣膀セ把计")]
    [Range(0, 10)]
    public float speed = 3.5f;
    [Range(0,500)]
    public float attack = 100f;
    [Range(0, 5000)]
    public float hp = 350f;
    [Range(0, 50)]
    public float trackRange = 30f;
    public Vector3 offsetTrack;

    [Header("奔辅笵ㄣ把计")]
    public GameObject item;
    [Range(0, 1)]
    public float dropRate = 1f;

    [Header("把计")]
    public AudioClip dropItemSound;
    public AudioClip hurtSound;
    public AudioClip attackSound;

    private AudioSource aud;
    private Rigidbody2D rig2D;
    private Animator anim;
}
