using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Image _image;

    private float _offset = 0;

    // Start is called before the first frame update
    void Awake()
    {
        _image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        _offset += _speed * Time.deltaTime;
        _image.material.mainTextureOffset = new Vector2(_offset, 0);
    }
}
