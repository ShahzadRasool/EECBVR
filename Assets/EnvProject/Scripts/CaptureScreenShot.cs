using UnityEngine;
using System;
using System.Collections;
public class CaptureScreenShot : MonoBehaviour 
{
	int resWidth = 4000; 
	int resHeight = 2000;
	private bool takeHiResShot = false;
	public static string ScreenShotName(int width, int height) 
	{
		return string.Format("{0}/screen_{1}x{2}_{3}.png","D:/",width, height,System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
	}
	public void TakeHiResShot() 
	{
		takeHiResShot = true;
	}
	void LateUpdate() 
	{
   //    takeHiResShot |= Input.GetKeyDown(KeyCode.Space);
   //    if (takeHiResShot) 
   //    {
   //        RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
   //        GetComponent<Camera>().targetTexture = rt;
   //        Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, true);
   //        GetComponent<Camera>().Render();
   //        RenderTexture.active = rt;
   //        screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
   //        GetComponent<Camera>().targetTexture = null;
   //        RenderTexture.active = null; 
   //        Destroy(rt);
   //        byte[] bytes = screenShot.EncodeToJPG();
   //        string filename = ScreenShotName(resWidth, resHeight);
   //        System.IO.File.WriteAllBytes(filename, bytes);
			//System.IO.File.WriteAllBytes(filename,bytes);
   //        Debug.Log(string.Format("Took screenshot to: {0}", filename));
   //        Application.OpenURL(filename);
   //        takeHiResShot = false;
   //    }
	}

    public void ss()
    {
        RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
        GetComponent<Camera>().targetTexture = rt;
        Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, true);
        GetComponent<Camera>().Render();
        RenderTexture.active = rt;
        screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
        GetComponent<Camera>().targetTexture = null;
        RenderTexture.active = null;
        Destroy(rt);
        byte[] bytes = screenShot.EncodeToJPG();
        string filename = ScreenShotName(resWidth, resHeight);
        System.IO.File.WriteAllBytes(filename, bytes);
        System.IO.File.WriteAllBytes(filename, bytes);
        Debug.Log(string.Format("Took screenshot to: {0}", filename));
        Application.OpenURL(filename);
        takeHiResShot = false;
    }
}