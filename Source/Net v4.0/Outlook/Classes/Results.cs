//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Results_ItemAddEventHandler(COMObject Item);
	public delegate void Results_ItemChangeEventHandler(COMObject Item);
	public delegate void Results_ItemRemoveEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Results SupportByLibrary Outlook, 10,11,12,14
	///</summary>
	[SupportByLibrary("Outlook", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Results : _Results, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ResultsEvents_SinkHelper _resultsEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Results(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Results(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Results(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public Results()
		{
			CreateFromProgId("Outlook.Results");
		}
		
		/// <param name="progId">progId</param>
		public Results(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ResultsEvents_SinkHelper.Id);


			if(ResultsEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_resultsEvents_SinkHelper = new ResultsEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Outlook, 10,11,12,14
		/// </summary>
		private event Results_ItemAddEventHandler _ItemAddEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Results_ItemAddEventHandler ItemAddEvent
		{
			add
			{
				CreateEventBridge();
				_ItemAddEvent += value;
			}
			remove
			{
				_ItemAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10,11,12,14
		/// </summary>
		private event Results_ItemChangeEventHandler _ItemChangeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Results_ItemChangeEventHandler ItemChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ItemChangeEvent += value;
			}
			remove
			{
				_ItemChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10,11,12,14
		/// </summary>
		private event Results_ItemRemoveEventHandler _ItemRemoveEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Results_ItemRemoveEventHandler ItemRemoveEvent
		{
			add
			{
				CreateEventBridge();
				_ItemRemoveEvent += value;
			}
			remove
			{
				_ItemRemoveEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _resultsEvents_SinkHelper)
			{
				_resultsEvents_SinkHelper.Dispose();
				_resultsEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}