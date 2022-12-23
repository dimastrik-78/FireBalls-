using GunSystem;
using Interface;
using System;
using StateSystem;

namespace UISystem
{
    public class Controller : IObserver
    {
        public static event Action<int> Point;
        public static event Action<Type> ChangeStateGame;

        private View _view;
        private Model _model;
        
        public Controller(View view, Model model)
        {
            _view = view;
            _model = model;
            
            OnEnable();
        }
        
        private void OnEnable()
        {
            ListenerInput.CountBullet += ChangeCountBullet;
        }

        private void ChangeCountBullet(int countBullet)
        {
            if (_model.MaxCountBullet == 0)
            {
                _model.MaxCountBullet = countBullet;
                _model.CountBullet = countBullet;
            }
            else
            {
                _model.CountBullet = countBullet;
            }
            
            _view.ChangeCountBullet();
        }

        public void OnNotify(int point)
        {
            _model.Point += point;
            
            _view.ChangePoint();
            
            Point?.Invoke(_model.Point);
        }

        public void ChangeState()
        {
            ChangeStateGame?.Invoke(typeof(Play));
        }
    }
}
