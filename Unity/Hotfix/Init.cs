using System;
using Model;


namespace Hotfix
{
	public static class Init
	{
		public static void Start()
		{
			try
			{
			
				 Log.Debug("Hotfix  Init sgtart");
				Hotfix.Scene.ModelScene = Game.Scene;
				Log.Debug("Hotfix  Init add UIComponent");
				Hotfix.Scene.AddComponent<UIComponent>();
				Log.Debug("Hotfix  Init add EventComponent");
				Hotfix.Scene.GetComponent<EventComponent>().Run(EventIdType.InitSceneStart);
				Log.Debug("Hotfix  Init end");
			}
			catch (Exception e)
			{
				Log.Error(e.ToStr());
			}
		}

		public static void Update()
		{
			try
			{
				ObjectEvents.Instance.Update();
			}
			catch (Exception e)
			{
				Log.Error(e.ToStr());
			}
		}

		public static void LateUpdate()
		{
			try
			{
				ObjectEvents.Instance.LateUpdate();
			}
			catch (Exception e)
			{
				Log.Error(e.ToStr());
			}
		}

		public static void OnApplicationQuit()
		{
			ObjectEvents.Close();
			Hotfix.Close();
		}
	}
}