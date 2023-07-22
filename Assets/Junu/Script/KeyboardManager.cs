using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardManager : MonoBehaviour
{
    public List<Button> button = new List<Button>();

    AudioSource audioSource;
    public AudioClip type;

    public Image leftHand;
    public Image rightHand;

    public Sprite[] leftHandImage;
    public Sprite[] rightHandImage;

    int randomIndex = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        KeyboardInput();
        KeyboardSound();
        HandSpriteSwap();
    }

    void KeyboardInput()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            var state = button[0].spriteState;
            var pressedState = state.pressedSprite;
            button[0].image.sprite = pressedState;
            leftHand.rectTransform.position = button[0].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            var state = button[0].spriteState;
            var defaultState = state.highlightedSprite;
            button[0].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            var state = button[1].spriteState;
            var pressedState = state.pressedSprite;
            button[1].image.sprite = pressedState;
            leftHand.rectTransform.position = button[1].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            var state = button[1].spriteState;
            var defaultState = state.highlightedSprite;
            button[1].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            var state = button[2].spriteState;
            var pressedState = state.pressedSprite;
            button[2].image.sprite = pressedState;
            leftHand.rectTransform.position = button[2].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            var state = button[2].spriteState;
            var defaultState = state.highlightedSprite;
            button[2].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            var state = button[3].spriteState;
            var pressedState = state.pressedSprite;
            button[3].image.sprite = pressedState;
            leftHand.rectTransform.position = button[3].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            var state = button[3].spriteState;
            var defaultState = state.highlightedSprite;
            button[3].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            var state = button[4].spriteState;
            var pressedState = state.pressedSprite;
            button[4].image.sprite = pressedState;
            leftHand.rectTransform.position = button[4].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.T))
        {
            var state = button[4].spriteState;
            var defaultState = state.highlightedSprite;
            button[4].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            var state = button[5].spriteState;
            var pressedState = state.pressedSprite;
            button[5].image.sprite = pressedState;
            rightHand.rectTransform.position = button[5].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.Y))
        {
            var state = button[5].spriteState;
            var defaultState = state.highlightedSprite;
            button[5].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            var state = button[6].spriteState;
            var pressedState = state.pressedSprite;
            button[6].image.sprite = pressedState;
            rightHand.rectTransform.position = button[6].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.U))
        {
            var state = button[6].spriteState;
            var defaultState = state.highlightedSprite;
            button[6].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            var state = button[7].spriteState;
            var pressedState = state.pressedSprite;
            button[7].image.sprite = pressedState;
            rightHand.rectTransform.position = button[7].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.I))
        {
            var state = button[7].spriteState;
            var defaultState = state.highlightedSprite;
            button[7].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            var state = button[8].spriteState;
            var pressedState = state.pressedSprite;
            button[8].image.sprite = pressedState;
            rightHand.rectTransform.position = button[8].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.O))
        {
            var state = button[8].spriteState;
            var defaultState = state.highlightedSprite;
            button[8].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            var state = button[9].spriteState;
            var pressedState = state.pressedSprite;
            button[9].image.sprite = pressedState;
            rightHand.rectTransform.position = button[9].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.P))
        {
            var state = button[9].spriteState;
            var defaultState = state.highlightedSprite;
            button[9].image.sprite = defaultState;
        }




        if (Input.GetKeyDown(KeyCode.A))
        {
            var state = button[10].spriteState;
            var pressedState = state.pressedSprite;
            button[10].image.sprite = pressedState;
            leftHand.rectTransform.position = button[10].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            var state = button[10].spriteState;
            var defaultState = state.highlightedSprite;
            button[10].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            var state = button[11].spriteState;
            var pressedState = state.pressedSprite;
            button[11].image.sprite = pressedState;
            leftHand.rectTransform.position = button[11].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            var state = button[11].spriteState;
            var defaultState = state.highlightedSprite;
            button[11].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            var state = button[12].spriteState;
            var pressedState = state.pressedSprite;
            button[12].image.sprite = pressedState;
            leftHand.rectTransform.position = button[12].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            var state = button[12].spriteState;
            var defaultState = state.highlightedSprite;
            button[12].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            var state = button[13].spriteState;
            var pressedState = state.pressedSprite;
            button[13].image.sprite = pressedState;
            leftHand.rectTransform.position = button[13].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.F))
        {
            var state = button[13].spriteState;
            var defaultState = state.highlightedSprite;
            button[13].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            var state = button[14].spriteState;
            var pressedState = state.pressedSprite;
            button[14].image.sprite = pressedState;
            rightHand.rectTransform.position = button[14].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.G))
        {
            var state = button[14].spriteState;
            var defaultState = state.highlightedSprite;
            button[14].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            var state = button[15].spriteState;
            var pressedState = state.pressedSprite;
            button[15].image.sprite = pressedState;
            rightHand.rectTransform.position = button[15].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.H))
        {
            var state = button[15].spriteState;
            var defaultState = state.highlightedSprite;
            button[15].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            var state = button[16].spriteState;
            var pressedState = state.pressedSprite;
            button[16].image.sprite = pressedState;
            rightHand.rectTransform.position = button[16].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.J))
        {
            var state = button[16].spriteState;
            var defaultState = state.highlightedSprite;
            button[16].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            var state = button[17].spriteState;
            var pressedState = state.pressedSprite;
            button[17].image.sprite = pressedState;
            rightHand.rectTransform.position = button[17].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.K))
        {
            var state = button[17].spriteState;
            var defaultState = state.highlightedSprite;
            button[17].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            var state = button[18].spriteState;
            var pressedState = state.pressedSprite;
            button[18].image.sprite = pressedState;
            rightHand.rectTransform.position = button[18].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.L))
        {
            var state = button[18].spriteState;
            var defaultState = state.highlightedSprite;
            button[18].image.sprite = defaultState;
        }



        if (Input.GetKeyDown(KeyCode.Z))
        {
            var state = button[19].spriteState;
            var pressedState = state.pressedSprite;
            button[19].image.sprite = pressedState;
            leftHand.rectTransform.position = button[19].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.Z))
        {
            var state = button[19].spriteState;
            var defaultState = state.highlightedSprite;
            button[19].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            var state = button[20].spriteState;
            var pressedState = state.pressedSprite;
            button[20].image.sprite = pressedState;
            leftHand.rectTransform.position = button[20].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.X))
        {
            var state = button[20].spriteState;
            var defaultState = state.highlightedSprite;
            button[20].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            var state = button[21].spriteState;
            var pressedState = state.pressedSprite;
            button[21].image.sprite = pressedState;
            leftHand.rectTransform.position = button[21].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            var state = button[21].spriteState;
            var defaultState = state.highlightedSprite;
            button[21].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            var state = button[22].spriteState;
            var pressedState = state.pressedSprite;
            button[22].image.sprite = pressedState;
            leftHand.rectTransform.position = button[22].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.V))
        {
            var state = button[22].spriteState;
            var defaultState = state.highlightedSprite;
            button[22].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            var state = button[23].spriteState;
            var pressedState = state.pressedSprite;
            button[23].image.sprite = pressedState;
            rightHand.rectTransform.position = button[23].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.B))
        {
            var state = button[23].spriteState;
            var defaultState = state.highlightedSprite;
            button[23].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            var state = button[24].spriteState;
            var pressedState = state.pressedSprite;
            button[24].image.sprite = pressedState;
            rightHand.rectTransform.position = button[24].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.N))
        {
            var state = button[24].spriteState;
            var defaultState = state.highlightedSprite;
            button[24].image.sprite = defaultState;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            var state = button[25].spriteState;
            var pressedState = state.pressedSprite;
            button[25].image.sprite = pressedState;
            rightHand.rectTransform.position = button[25].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.M))
        {
            var state = button[25].spriteState;
            var defaultState = state.highlightedSprite;
            button[25].image.sprite = defaultState;
        }


        if (Input.GetKeyDown(KeyCode.Return))
        {
            var state = button[26].spriteState;
            var pressedState = state.pressedSprite;
            button[26].image.sprite = pressedState;
            rightHand.rectTransform.position = button[26].image.rectTransform.position;
        }
        else if (Input.GetKeyUp(KeyCode.Return))
        {
            var state = button[26].spriteState;
            var defaultState = state.highlightedSprite;
            button[26].image.sprite = defaultState;
        }
    }
    void KeyboardSound()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.H) || Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.J))
        {
            audioSource.PlayOneShot(type);
        }

        if (Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown(KeyCode.N) || Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.T))
        {
            audioSource.PlayOneShot(type);
        }

        if (Input.GetKeyDown(KeyCode.T) || Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return))
        {
            audioSource.PlayOneShot(type);
        }
    }
    void HandSpriteSwap()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.T) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.V))
        {
            randomIndex = Random.Range(0, leftHandImage.Length);
            leftHand.sprite = leftHandImage[randomIndex];
        }

        if (Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.H) || Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.N) || Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown(KeyCode.Return))
        {
            randomIndex = Random.Range(0, rightHandImage.Length);
            rightHand.sprite = rightHandImage[randomIndex];
        }


    }
}
