using Interface;
using UnityEngine;
using UnityEngine.UI;

namespace UISystem
{
    public class View : MonoBehaviour
    {
        [SerializeField] private Text text;
        [SerializeField] private Image image;

        private Model _model;
        public Controller Controller;

        void Awake()
        {
            _model = new Model();
            Controller = new Controller(this, _model);
        }

        public void ChangePoint()
        {
            text.text = _model.Point.ToString();
        }

        public void ChangeCountBullet()
        {
            image.fillAmount = (float)_model.CountBullet / _model.MaxCountBullet;
        }
    }
}
