using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float velocity = 4f;

    private Vector3 gravity = new Vector3(0f, -9.81f, 0f);

    private CharacterController characterController;
    private Animator anim;

    [Header("Audios")]
    [SerializeField] private AudioSource audioSourcePassos;
    [SerializeField] private AudioClip[] audioClipsPassos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 moviment = new Vector3 (moveHorizontal, 0f, moveVertical);

        characterController.Move(moviment * Time.deltaTime * velocity);
        characterController.Move(gravity * Time.deltaTime);

        if (moviment != Vector3.zero)
        {
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
        }
    }


    private void OnPassos()
    {
        int index = Random.Range(0, audioClipsPassos.Length);
        audioSourcePassos.PlayOneShot(audioClipsPassos[index]);
    }
}
