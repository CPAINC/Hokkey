using UnityEngine;

public class GameData : MonoBehaviour
{
    private int heal = 3;
    private int hits = 0;

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
    /// Узнать кол-во попаданий игрока в ворота
    /// </summary>
    /// <returns></returns>
    public int ViewHits()
    {
        return hits;
    }
}
