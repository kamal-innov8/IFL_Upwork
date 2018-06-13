using Firebase.Database;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        new Get("games", Got);
    }

    private void Got(object sender, ChildChangedEventArgs e)
    {
        print(e.Snapshot.GetRawJsonValue());
    }
}
