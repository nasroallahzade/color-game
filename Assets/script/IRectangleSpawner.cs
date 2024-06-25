using UnityEngine;

public interface IRectangleSpawner
{
    int health { get; }
    SpriteRenderer spriteRenderer { get; }

    void Deconstruct(out SpriteRenderer spriteRenderer, out int health);
    bool Equals(MonoBehaviour other);
    bool Equals(object obj);
    bool Equals(RectangleSpawner other);
    int GetHashCode();
    string ToString();
}