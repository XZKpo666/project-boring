using GifImporter;
using UnityEngine;
using UnityEngine.UI;

namespace GifImporter
{
    [ExecuteAlways]
    public class GifPlayer : MonoBehaviour
    {
        public Gif Gif;
        public Button PlayButton; // 連接你的按鈕
        public GameObject gameObject1;
        public GameObject gameObject2;

        private int   _index;
        private float _flip;
        private Gif   _setGif;
        private bool  _isPlaying;

        private void Start()
        {
            if (PlayButton != null)
            {
                PlayButton.onClick.AddListener(PlayGif); // 按鈕點擊觸發播放
            }
        }

        private void Update()
        {
            if (!_isPlaying || Gif == null) return;
            var frames = Gif.Frames;
            if (frames == null || frames.Count == 0) return;

            int index = _index;

            if (_flip < Time.time)
            {
                index++;
            }

            if (index > frames.Count - 1)
            {
                // 停止播放
                _isPlaying = false;
                gameObject1.SetActive(!gameObject1.activeSelf);
                gameObject2.SetActive(!gameObject2.activeSelf);
                return;
            }

            if (index != _index || _setGif != Gif)
            {
                _index = index;
                var frame = frames[_index];
                Apply(frame);
            }
        }

        private void PlayGif()
        {
            if (Gif == null) return;

            _index = 0;      // 從第一幀開始
            _isPlaying = true; // 設置為播放狀態
        }

        private void Apply(GifFrame frame)
        {
            Image image = null;
            if (TryGetComponent<SpriteRenderer>(out var spriteRenderer) || TryGetComponent(out image))
            {
                _flip = Time.time + frame.DelayInMs * 0.001f;

                if (spriteRenderer != null) spriteRenderer.sprite = frame.Sprite;
                else if (image != null) image.sprite              = frame.Sprite;

                _setGif = Gif;
            }
        }

        private void OnDestroy()
        {
            if (PlayButton != null)
            {
                PlayButton.onClick.RemoveListener(PlayGif);
            }
        }
    }
}
