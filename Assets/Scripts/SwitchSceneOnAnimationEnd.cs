using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneOnAnimationEnd : MonoBehaviour {
    public Animator anim;
    public SceneField targetScene;
    public float delay;
    bool started = false;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.99f && !started) {
            anim.speed = 0;
            started = true;
            StartCoroutine(WaitThenLoad());
        }
    }

    IEnumerator WaitThenLoad() {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadSceneAsync(targetScene, LoadSceneMode.Single);
    }
}
