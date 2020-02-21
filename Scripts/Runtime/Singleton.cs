using UnityEngine;

namespace DaltonLima.Core
{
    public class Singleton<T> : MonoBehaviour
        where T : Component
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    var objects = FindObjectsOfType(typeof(T)) as T[];
                    if (objects.Length > 0)
                        _instance = objects[0];
                    if (objects.Length > 1)
                    {
                        Debug.LogError($"[Singleton] There is more than one {typeof(T).Name} in the scene.");
                    }
                    if (_instance == null)
                    {
                        Debug.LogWarning($"[Singleton] There is no instance of {typeof(T).Name} in the scene. Creating one now");
                        GameObject obj = new GameObject();
                        obj.name = string.Format("_{typeof(T).Name}");
                        _instance = obj.AddComponent<T>();
                    }
                }
                return _instance;
            }
        }
    }
}