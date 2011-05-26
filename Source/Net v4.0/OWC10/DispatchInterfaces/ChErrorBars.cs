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
	/// DispatchInterface ChErrorBars SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ChErrorBars : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChErrorBars(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChErrorBars(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChErrorBars(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChErrorBars()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartEndStyleEnum EndStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EndStyle", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartEndStyleEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EndStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartErrorBarDirectionEnum Direction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Direction", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartErrorBarDirectionEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Direction", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.ChLine Line
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Line", paramsArray);
				NetOffice.OWC10Api.ChLine newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.ChLine;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.ChSeries Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.OWC10Api.ChSeries newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.ChSeries;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Double Amount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Amount", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Amount", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartErrorBarIncludeEnum Include
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Include", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartErrorBarIncludeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Include", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartErrorBarTypeEnum Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartErrorBarTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Bottom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Bottom", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Right
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Right", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartSelectionsEnum ObjectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ObjectType", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartSelectionsEnum)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Dimension">NetOffice.OWC10Api.Enums.ChartErrorBarCustomValuesEnum Dimension</param>
		/// <param name="DataSourceIndex">Int32 DataSourceIndex</param>
		/// <param name="DataReference">optional object DataReference</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetData(NetOffice.OWC10Api.Enums.ChartErrorBarCustomValuesEnum dimension, Int32 dataSourceIndex, object dataReference=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dimension, dataSourceIndex, dataReference);
			Invoker.Method(this, "SetData", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Dimension">NetOffice.OWC10Api.Enums.ChartErrorBarCustomValuesEnum Dimension</param>
		/// <param name="DataSourceIndex">Int32 DataSourceIndex</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetData(NetOffice.OWC10Api.Enums.ChartErrorBarCustomValuesEnum dimension, Int32 dataSourceIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dimension, dataSourceIndex);
			Invoker.Method(this, "SetData", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="ErrorBarDirection">NetOffice.OWC10Api.Enums.ChartErrorBarCustomValuesEnum ErrorBarDirection</param>
		[SupportByLibrary("OWC10", 1)]
		public string GetDataReference(NetOffice.OWC10Api.Enums.ChartErrorBarCustomValuesEnum errorBarDirection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(errorBarDirection);
			object returnItem = Invoker.MethodReturn(this, "GetDataReference", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="ErrorBarDirection">NetOffice.OWC10Api.Enums.ChartErrorBarCustomValuesEnum ErrorBarDirection</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 GetDataSourceIndex(NetOffice.OWC10Api.Enums.ChartErrorBarCustomValuesEnum errorBarDirection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(errorBarDirection);
			object returnItem = Invoker.MethodReturn(this, "GetDataSourceIndex", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="ErrorBarDirection">NetOffice.OWC10Api.Enums.ChartErrorBarCustomValuesEnum ErrorBarDirection</param>
		/// <param name="DataSourceIndex">object DataSourceIndex</param>
		/// <param name="DataReference">object DataReference</param>
		[SupportByLibrary("OWC10", 1)]
		public void GetData(NetOffice.OWC10Api.Enums.ChartErrorBarCustomValuesEnum errorBarDirection, object dataSourceIndex, object dataReference)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(errorBarDirection, dataSourceIndex, dataReference);
			Invoker.Method(this, "GetData", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}