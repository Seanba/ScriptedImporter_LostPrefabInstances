using System.IO;
using UnityEngine;
using UnityEditor.Experimental.AssetImporters;

[ScriptedImporter(1, "xxx")]
public class CustomImporterXXX : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        // Simply create a cube object for this prefab
        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        ctx.AddObjectToAsset("main obj", cube);
        ctx.SetMainObject(cube);
    }

}
