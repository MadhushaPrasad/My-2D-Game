using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeveManager : MonoBehaviour
{
    public float respwnDelay;
    public PlayerController gamePlayer;
    // Start is called before the first frame update
    void Start()
    {
        gamePlayer = FindObjectOfType<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Respawn()
    {
        StartCoroutine("RespawnCoroutine");
    }

    public IEnumerator RespawnCoroutine()
    {
        gamePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(respwnDelay);
        gamePlayer.transform.position = gamePlayer.respwnPoint;
        gamePlayer.gameObject.SetActive(true);
    }
}
