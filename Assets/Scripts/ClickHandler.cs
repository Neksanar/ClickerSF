using UnityEngine;
using UnityEngine.UI;


public class ClickHandler : MonoBehaviour
{   
    public Transform ParticlePoint; //точка создания частиц
    
    public Text TextScore;
    public ParticleManager ParticleManager;
    [SerializeField] private Enemy _enemy;
    private TargetClick Gesture; //компонент на объекте клика (неочевидно, надо переименовать)
    private int _pointsPerClick = 10;
    private int _score = 0;
    
    void Start()
    {
        Gesture = _enemy.Gesture;
        Gesture.OnClick += (pos, rot) =>
        {
            Debug.Log(pos);
            Debug.Log(rot);

            ParticlePoint.position = pos;

            _score+= _pointsPerClick;
            TextScore.text = _score.ToString();
            
            ParticleManager.CreateParticles(pos, rot);
        };
    }
}
