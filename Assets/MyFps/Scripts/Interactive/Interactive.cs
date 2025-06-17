using TMPro;
using UnityEngine;

namespace MyFps
{
    //인터랙티브 액션의 부모 클래스
    public class Interactive : MonoBehaviour
    {
        #region Variables
        //액션 UI
        public GameObject actionUI;
        public TextMeshProUGUI actionText;

        //크로스헤어
        public GameObject extraCross;

        //인터렉티브 기능 사용 여부
        [SerializeField]
        protected bool unInteractive = false;

        [SerializeField]
        protected string action = "Do Interactive Action";
        #endregion

        #region Unity Event Method
        #endregion

        #region Custom Method        
        public void RayHoverEntered()
        {
            //인터랙티브 기능 끄기
            if (unInteractive)
                return;

            extraCross.SetActive(true);
            ShowActionUI();
        }

        public void RayHoverExit()
        {
            extraCross.SetActive(false);
            HideActionUI();
        }

        public void RaySelected()
        {
            extraCross.SetActive(false);
            HideActionUI();

            //액션
            DoAction();
        }

        //Action UI 보여주기
        protected void ShowActionUI()
        {
            actionUI.SetActive(true);
            actionText.text = action;
        }

        //Action UI 숨기기
        protected void HideActionUI()
        {
            actionUI.SetActive(false);
            actionText.text = "";
        }

        //액션 함수
        protected virtual void DoAction()
        {

        }
        #endregion
    }
}
