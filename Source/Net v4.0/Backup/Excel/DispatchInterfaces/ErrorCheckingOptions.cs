//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface ErrorCheckingOptions SupportByLibrary Excel, 10,11,12,14
	///</summary>
	[SupportByLibrary("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ErrorCheckingOptions : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ErrorCheckingOptions(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ErrorCheckingOptions(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ErrorCheckingOptions(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ErrorCheckingOptions()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public bool BackgroundChecking
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackgroundChecking", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackgroundChecking", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlColorIndex IndicatorColorIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IndicatorColorIndex", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlColorIndex)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IndicatorColorIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public bool EvaluateToError
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EvaluateToError", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EvaluateToError", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public bool TextDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextDate", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TextDate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public bool NumberAsText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberAsText", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumberAsText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public bool InconsistentFormula
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InconsistentFormula", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InconsistentFormula", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public bool OmittedCells
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OmittedCells", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OmittedCells", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public bool UnlockedFormulaCells
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UnlockedFormulaCells", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UnlockedFormulaCells", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public bool EmptyCellReferences
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EmptyCellReferences", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EmptyCellReferences", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public bool ListDataValidation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListDataValidation", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ListDataValidation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public bool InconsistentTableFormula
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InconsistentTableFormula", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InconsistentTableFormula", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}