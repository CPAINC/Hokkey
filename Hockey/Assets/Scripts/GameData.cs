using UnityEngine;

public class GameData : MonoBehaviour
{
    private int heal = 3;
    private int pucks = 8;
    private int hits = 0;

    /// <summary>
    /// Отнять 1 шайбу
    /// </summary>
    public void GetPuck()
    {
        pucks--;
    }
    /// <summary>
    /// Отнять 1 жизнь
    /// </summary>
    public void GetHeal()
    {
        heal--;
    }
    /// <summary>
    /// Добавить 1 очко
    /// </summary>
    public void GiveHits()
    {
        hits++;
    }
    /// <summary>
    /// Получить жизни игрока
    /// </summary>
    /// <returns></returns>
    public int ViewHeal()
    {
        return heal;
    }
    /// <summary>
    /// Получить кол-во шайб
    /// </summary>
    /// <returns></returns>
    public int ViewPucks()
    {
        return pucks;
    }
    /// <summary>
    /// Узнать кол-во попаданий игрока в ворота
    /// </summary>
    /// <returns></returns>
    public int ViewHits()
    {
        return hits;
    }
}
