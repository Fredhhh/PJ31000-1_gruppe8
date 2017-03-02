#pragma strict

var baseName = "Page";
private var page = 0;
var lastPage = 100;

function NextPrevPage(nextPage : boolean)
{
    var currPage = page;

    if (nextPage)
    {
        if (page + 1 > lastPage)
            return;
        page++;
    }
    else
    {
        if (page - 1 < 0)
            return;
        page--;
    }

    var newPage : Texture = Resources.Load(baseName + page) as Texture;
    if (newPage != null)
    {
        var lastPage = renderer.material.mainTexture;
        renderer.material.mainTexture = newPage;
        Resources.UnloadAsset(lastPage);
    }
    else
    {
        page = currPage;
    }
}

function OnGUI()
{
    if (GUI.Button(Rect(0, 0, 100, 50), "Next"))
        NextPrevPage(true);
    if (GUI.Button(Rect(0, 75, 100, 50), "Prev"))
        NextPrevPage(false);
}
