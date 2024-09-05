using UnityEngine;
using UnityEngine.UI;

public class GridLayoutScaler : MonoBehaviour
{
    public int rows;
    public int cols;

    [SerializeField] private GameObject MonsterInfoPanel;

    private GridLayoutGroup gridLayout;
    private RectTransform parentRect;

    private void Start()
    {
        InitializeGrid();
    }

    private void InitializeGrid()
    {
        if (MonsterInfoPanel == null) return;

        parentRect = gameObject.GetComponent<RectTransform>();
        gridLayout = gameObject.GetComponent<GridLayoutGroup>();

        if (parentRect == null || gridLayout == null) return;

        float GridCellWidth = (parentRect.rect.width - ((gridLayout.padding.left + gridLayout.padding.right) + ((cols - 1) * gridLayout.spacing.x))) / cols;
        float GridCellHeight = (parentRect.rect.height - ((gridLayout.padding.top + gridLayout.padding.bottom) + ((rows - 1) * gridLayout.spacing.y))) / rows;
        gridLayout.cellSize = new Vector2(GridCellWidth, GridCellHeight);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                GameObject monsterInfoPanel = Instantiate(MonsterInfoPanel);
                monsterInfoPanel.transform.SetParent(gameObject.transform, false);
                monsterInfoPanel.GetComponent<MonsterInfoGrid>().InitializeGridLocal(gridLayout.cellSize);
            }
        }
    }
}