using UnityEngine;

public abstract class ISceneController : MonoBehaviour
{
    protected abstract GameState GetGameState();

    protected bool SceneActive() { return GameController.instance.currGameState == GetGameState(); }

    void Update()
    {
        if (SceneActive())
        {
            SceneUpdate();
        }
    }

    protected virtual void SceneUpdate() { }
}
