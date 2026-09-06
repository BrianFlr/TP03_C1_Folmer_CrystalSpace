//using UnityEditor;
//using UnityEngine;
//using UnityEngine.UI;

//public class UiBack : MonoBehaviour
//{
//    [Header("Buttons")]
//    [SerializeField] private Button btnBack;
//    private Canvas activeCanvas;

//    private void Awake()
//    {
//        activeCanvas = GetComponent<Canvas>();
//        btnBack.onClick.AddListener(OnBackClicked);
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }

//    private void OnDestroy()
//    {
//        btnBack.onClick.RemoveAllListeners();
//    }
    
//    private void OnBackClicked()
//    {
//        activeCanvas.;

//        if (pauseState.isPause)
//        {
//            pauseCanvas.SetActive(true);
//        }
//        else
//        {
//            mainMenuCanvas.SetActive(true);
//        }
//    }
//}
