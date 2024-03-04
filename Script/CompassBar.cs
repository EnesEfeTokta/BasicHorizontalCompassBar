using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompassBar : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private RawImage compassBar;
    [SerializeField] private Text compassText;

    void Update()
    {
        //Texture yatayda kaydırma yapılıyor.
        compassBar.uvRect = new Rect(player.localEulerAngles.y / 360, 0, 1, 1);

        //Oyuncunun Y ekseni üzerinde açısı kontrol ediliyor.
        float playerRotation = player.rotation.eulerAngles.y;

        //Float açısal değeri Int türüne çevriliyor.
        playerRotation = Mathf.RoundToInt(playerRotation);

        if (playerRotation < 0) { playerRotation += 360; }

        //Oyuncunun Y ekseni üzerindeki açısı yazılıyor.
        compassText.text = playerRotation.ToString();
    }
}
