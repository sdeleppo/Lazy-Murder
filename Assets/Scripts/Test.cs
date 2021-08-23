using UnityEngine;

public class Test : MonoBehaviour
{
    public static Rect m_screenRect = new Rect(0, 0, 640, 960);

    public Texture2D m_textureInvisible = null;
    public Texture2D m_textureNaked = null;
    public Texture2D m_textureBadge = null;
    public Texture2D m_textureWarning = null;

    public GUIStyle m_styleButton = null;

    //public Rect m_giftizButton;

    //public static Rect UpdateDimension(Rect position, float dy = 0.0f)
    //{
    //    position.y += dy;
    //    return (
    //        new Rect(
    //            (position.x / m_screenRect.width) * Screen.width,
    //            (position.y / m_screenRect.height) * Screen.height,
    //            (position.width / m_screenRect.width) * Screen.width,
    //            (position.height / m_screenRect.height) * Screen.height
    //        ));
    //}

    public void Press()
    { // update Giftiz Button

        m_styleButton.active.background = GetGiftizButtonTexture(); // get correct texture

        m_styleButton.normal.background = m_styleButton.active.background;

       

            GiftizBinding.buttonClicked(); // Giftiz Button has been clicked

        

    }

    public Texture2D GetGiftizButtonTexture()
    {

        Texture2D inter = null;

        // depending on button state, select the right image texture

        switch (GiftizBinding.giftizButtonState)
        {

            case GiftizBinding.GiftizButtonState.Invisible: inter = m_textureInvisible; break;

            case GiftizBinding.GiftizButtonState.Naked: inter = m_textureNaked; break;

            case GiftizBinding.GiftizButtonState.Badge: inter = m_textureBadge; break;

            case GiftizBinding.GiftizButtonState.Warning: inter = m_textureWarning; break;

        }

        return inter;

    }
}
