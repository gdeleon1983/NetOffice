//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface FieldList SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class FieldList : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FieldList(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FieldList(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FieldList(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FieldList()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 ClipboardFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ClipboardFormat", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public string InstanceID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InstanceID", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public stdole.IFont Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				stdole.IFont newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.IFont;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Font", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public bool MultiSelect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MultiSelect", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MultiSelect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.FieldListSelectRestriction SelectRestriction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelectRestriction", paramsArray);
				return (NetOffice.OWC10Api.Enums.FieldListSelectRestriction)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelectRestriction", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="bVisible">bool bVisible</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.FieldListHierarchy CreateHierarchy(bool bVisible)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bVisible);
			object returnItem = Invoker.MethodReturn(this, "CreateHierarchy", paramsArray);
			NetOffice.OWC10Api.FieldListHierarchy newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OWC10Api.FieldListHierarchy;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="iWidth">Int32 iWidth</param>
		/// <param name="iHeight">Int32 iHeight</param>
		/// <param name="pip">stdole.IPicture pip</param>
		/// <param name="crMask">Int32 crMask</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 AddBitmap(Int32 iWidth, Int32 iHeight, stdole.IPicture pip, Int32 crMask)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(iWidth, iHeight, pip, crMask);
			object returnItem = Invoker.MethodReturn(this, "AddBitmap", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pfln">NetOffice.OWC10Api.FieldListNode pfln</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.FieldListNode GetNextSelected(NetOffice.OWC10Api.FieldListNode pfln)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pfln);
			object returnItem = Invoker.MethodReturn(this, "GetNextSelected", paramsArray);
			NetOffice.OWC10Api.FieldListNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OWC10Api.FieldListNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public void ClearSelection()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearSelection", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="iImage">Int32 iImage</param>
		/// <param name="iOverlay">Int32 iOverlay</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetOverlayImage(Int32 iImage, Int32 iOverlay)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(iImage, iOverlay);
			Invoker.Method(this, "SetOverlayImage", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}