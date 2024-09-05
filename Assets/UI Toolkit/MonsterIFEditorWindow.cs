using UnityEngine;
using UnityEngine.UIElements;

public class MonsterIFEditorWindow : MonoBehaviour
{
    private VisualElement root;

    void OnEnable()
    {
        var uiDocument = GetComponent<UIDocument>();
        root = uiDocument.rootVisualElement; // Get the root element directly from UIDocument

        // Clear any existing content
        root.Clear();

        // Create a container for the grid
        var gridContainer = new VisualElement();
        gridContainer.style.flexDirection = FlexDirection.Row;
        gridContainer.style.flexWrap = Wrap.Wrap;
        gridContainer.style.justifyContent = Justify.SpaceAround;
        gridContainer.style.alignItems = Align.Center;

        // Set a fixed size for the grid container if needed
        gridContainer.style.width = Length.Percent(100);
        gridContainer.style.height = Length.Percent(100);

        // Add multiple panels with different monsters' stats in a grid format
        for (int i = 0; i < 6; i++)
        {
            var monsterPanel = new VisualElement();
            monsterPanel.style.flexDirection = FlexDirection.Column;
            monsterPanel.style.width = 100;  // Width for each panel
            monsterPanel.style.height = 100; // Height for each panel
            monsterPanel.style.marginBottom = 10;
            monsterPanel.style.marginRight = 10;
            monsterPanel.style.paddingTop = 10;
            monsterPanel.style.paddingBottom = 10;
            monsterPanel.style.paddingLeft = 10;
            monsterPanel.style.paddingRight = 10;
            monsterPanel.style.backgroundColor = new StyleColor(Color.gray); // Background color for visibility
            monsterPanel.style.borderTopWidth = 1;
            monsterPanel.style.borderBottomWidth = 1;
            monsterPanel.style.borderLeftWidth = 1;
            monsterPanel.style.borderRightWidth = 1;
            monsterPanel.style.borderTopColor = new StyleColor(Color.black);
            monsterPanel.style.borderBottomColor = new StyleColor(Color.black);
            monsterPanel.style.borderLeftColor = new StyleColor(Color.black);
            monsterPanel.style.borderRightColor = new StyleColor(Color.black);

            // Monster name label
            var monsterNameLabel = new Label($"Monster {i + 1}");
            monsterNameLabel.style.unityFontStyleAndWeight = FontStyle.Bold;
            monsterNameLabel.style.unityTextAlign = TextAnchor.MiddleCenter; // Center align text
            monsterPanel.Add(monsterNameLabel);

            // Add the monster panel to the grid container
            gridContainer.Add(monsterPanel);
        }

        // Add the grid container to the root
        root.Add(gridContainer);
    }
}