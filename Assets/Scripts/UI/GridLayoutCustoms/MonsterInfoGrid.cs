using UnityEngine;
using UnityEngine.UI;

public class MonsterInfoGrid : MonoBehaviour
{
    [SerializeField] private uint _amountOfCells;

    //Private
    private GridLayoutGroup _gridLayout;

    public void InitializeGridLocal(Vector2 cellSize)
    {
        _gridLayout = gameObject.GetComponent<GridLayoutGroup>();

        _gridLayout.cellSize = new Vector2(cellSize.x / (float)(_amountOfCells / 2), cellSize.y / (float)(_amountOfCells / 2));
    }
}
