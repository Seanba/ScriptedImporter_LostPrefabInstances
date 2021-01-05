using System.IO;
using UnityEngine;
using UnityEditor.Experimental.AssetImporters;

[ScriptedImporter(1, "xxx")]
public class CustomImporterXXX : ScriptedImporter
{
    private MyComponent m_MyComponent;
    private Grid m_Grid;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        var goParent = new GameObject(Path.GetFileNameWithoutExtension(assetPath));
        m_MyComponent = goParent.AddComponent<MyComponent>();

        ctx.AddObjectToAsset("main obj", goParent);
        ctx.SetMainObject(goParent);

        // Add a 2D grid
        var goGrid = new GameObject("grid");
        goGrid.transform.SetParent(goParent.transform);

        m_Grid = goGrid.AddComponent<Grid>();
    }
}
