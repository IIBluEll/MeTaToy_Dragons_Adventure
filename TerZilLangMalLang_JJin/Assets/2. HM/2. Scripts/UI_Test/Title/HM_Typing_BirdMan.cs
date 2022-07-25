using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HM_Typing_BirdMan : MonoBehaviour
{
    public TextMeshProUGUI txt_1;

    public GameObject txt1;

    AudioSource typingaudio;

    string message;
    string temp_message;
    public float speed = 0.2f;

    //public GameObject anyKey;

    // Start is called before the first frame update
    void Start()
    {
        typingaudio = GetComponent<AudioSource>();

        txt_1.text = "";
        message = "������,\n������� ����ƿ� ��Ÿ���� �巡�� �߿��� �װ� ������.\n�״� ������� ������� �峭�� ������ ����� ��� �Ӹ� �ƴ϶� �ٸ� �峭�� ���� ������ ������ �ȴ�.\n�Ƹ� �հ��� ������ ��ġ�� ��� ���� �˰� �ְ���.\n�״� APE�̶�� ���ڿ� ������ �ִ� ������ �ľǵƴ�.\n�������� APE�� ���õ� ��Ÿ���̵巡���� ���� ��ƿ�����.\n���� �ϳ��� Ȯ���ϵ��� ����.\n\n�� ������ ������ �Բ��ϴ� �ڴ� ���¿� ���� ���� �翡�� ������ ������ ������ �� ���̴�. ";

        StartCoroutine(TypingAction());
    }

    IEnumerator TypingAction()
    {
        typingaudio.Play();
        for (int i = 0; i < message.Length; i++)
        {
            yield return new WaitForSeconds(0.05f);

            temp_message += message.Substring(0, i);
            txt_1.text = temp_message;
            temp_message = "";
        }
        typingaudio.Stop();
        yield return new WaitForSeconds(1f);
 
    }
}
