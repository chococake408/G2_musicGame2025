using UnityEngine;

public class DestroyNotesLine : MonoBehaviour
{
    // �g���K�[�ɉ������N�������Ƃ��ɌĂ΂��
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"�g���K�[�ɐG��܂���: {other.gameObject.name}");

        NoteObject note = other.GetComponent<NoteObject>();
        if (note != null)
        {
            Destroy(other.gameObject);
        }
    }
}