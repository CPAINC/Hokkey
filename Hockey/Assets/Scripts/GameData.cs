using UnityEngine;

public class GameData : MonoBehaviour
{
    private int heal = 3;
    private int hits = 0;

    /// <summary>
    /// ������ 1 �����
    /// </summary>
    public void GetHeal()
    {
        heal--;
    }
    /// <summary>
    /// �������� 1 ����
    /// </summary>
    public void GiveHits()
    {
        hits++;
    }
    /// <summary>
    /// �������� ����� ������
    /// </summary>
    /// <returns></returns>
    public int ViewHeal()
    {
        return heal;
    }
    /// <summary>
    /// ������ ���-�� ��������� ������ � ������
    /// </summary>
    /// <returns></returns>
    public int ViewHits()
    {
        return hits;
    }
}
