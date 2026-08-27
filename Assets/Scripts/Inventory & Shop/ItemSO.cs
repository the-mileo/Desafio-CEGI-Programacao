using UnityEngine;

[CreateAssetMenu(fileName = "New Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public string itemDesc;
    public Sprite icon;

    public bool isGold;
    public int stackSize;
    
    [Header("Stats")]
    public int currentHealth;
    public int maxHealth;
    public int speed;
    public int damage;

    [Header("Temp Items")]
    public float duration;
    

}
