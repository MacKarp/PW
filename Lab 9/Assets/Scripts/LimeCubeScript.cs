using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimeCubeScript : MonoBehaviour
{
    public GameObject[] Obiekty;

    // Start is called before the first frame update
    void Start()
    {
        //Generuje losowo obiekt co 3 sekundy
        InvokeRepeating("GenerujObiekty", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        //Obraca kwadrat wokół własnej osi
        transform.rotation = Quaternion.Euler(45f, Time.timeSinceLevelLoad * 60f, 45f);

        //Po naciśnięciu klawisza Enter zatrzymuje generację obiektów
        if (Input.GetKeyDown(KeyCode.Return))
        {
            CancelInvoke("GenerujObiekty");
        }

        //Po naciśnięciu klawisza Spacje generuje losowo obiekt
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerujObiekty();
        }

        //Po naciśnięciu klawisza 1 generuje obiekt z tablicy Obiekty o indeksie 0
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKey(KeyCode.Keypad1))
        {
            GenerujObiekty(0);
        }
        //Po naciśnięciu klawisza 1 generuje obiekt z tablicy Obiekty o indeksie 1
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKey(KeyCode.Keypad2))
        {
            GenerujObiekty(1);
        }
        //Po naciśnięciu klawisza 1 generuje obiekt z tablicy Obiekty o indeksie 2
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKey(KeyCode.Keypad3))
        {
            GenerujObiekty(2);
        }
        //Po naciśnięciu klawisza 1 generuje obiekt z tablicy Obiekty o indeksie 3
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKey(KeyCode.Keypad4))
        {
            GenerujObiekty(3);
        }
        //Po naciśnięciu klawisza 1 generuje obiekt z tablicy Obiekty o indeksie 4
        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKey(KeyCode.Keypad5))
        {
            GenerujObiekty(4);
        }
    }

    //Generuje obiekt z tablicy Obiekty o losowym indeksie
    void GenerujObiekty()
    {
        Instantiate(Obiekty[Random.Range(0, Obiekty.Length)], transform.position, Quaternion.identity);
    }

    //Generuje obiekt z tablicy Obiekty o indeksie n
    void GenerujObiekty(int n)
    {
        Instantiate(Obiekty[n], transform.position, Quaternion.identity);
    }


}
