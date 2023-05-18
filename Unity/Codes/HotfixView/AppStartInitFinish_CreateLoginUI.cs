
namespace ET
{
    public class AppStartInitFinish_RemoveLoginUI:AEventAsync<EventType.AppStartInitFinish>
    {
        protected override async ETTask Run(EventType.AppStartInitFinish args)
        {
            await ETTask.CompletedTask;
            
            //UIComponent.Instance.showWindow(WindowID.WindowID_Test);
            
            Scene zoneScene = args.ZoneScene;
            zoneScene.GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Test);
        }
    }
}