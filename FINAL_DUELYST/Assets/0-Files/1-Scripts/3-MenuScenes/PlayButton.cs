using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private Text nicknameText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log(PhotonNetwork.LocalPlayer.NickName);
        }
    }

    public void OnPlayButtonPressed()
    {
        PhotonNetwork.LocalPlayer.NickName = nicknameText.text;

        if (string.IsNullOrEmpty(nicknameText.text.ToString()))
        {
            string tempName = "Player: " + Random.Range(0, 99999);
            PhotonNetwork.LocalPlayer.NickName = tempName;
        }

        SceneManager.LoadScene("Connect");
    }
}
