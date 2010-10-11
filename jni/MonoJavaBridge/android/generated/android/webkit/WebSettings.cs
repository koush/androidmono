namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebSettings : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WebSettings()
		{
			InitJNI();
		}
		protected WebSettings(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class LayoutAlgorithm : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static LayoutAlgorithm()
			{
				InitJNI();
			}
			internal LayoutAlgorithm(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values10434;
			public static global::android.webkit.WebSettings.LayoutAlgorithm[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.LayoutAlgorithm>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._values10434)) as android.webkit.WebSettings.LayoutAlgorithm[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf10435;
			public static global::android.webkit.WebSettings.LayoutAlgorithm valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._valueOf10435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.LayoutAlgorithm;
			}
			internal static global::MonoJavaBridge.FieldId _NARROW_COLUMNS10436;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NARROW_COLUMNS
			{
				get
				{
					return default(global::android.webkit.WebSettings.LayoutAlgorithm);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL10437;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NORMAL
			{
				get
				{
					return default(global::android.webkit.WebSettings.LayoutAlgorithm);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SINGLE_COLUMN10438;
			public static global::android.webkit.WebSettings.LayoutAlgorithm SINGLE_COLUMN
			{
				get
				{
					return default(global::android.webkit.WebSettings.LayoutAlgorithm);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.LayoutAlgorithm.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$LayoutAlgorithm"));
				global::android.webkit.WebSettings.LayoutAlgorithm._values10434 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "values", "()[Landroid/webkit/WebSettings/LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._valueOf10435 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$LayoutAlgorithm;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class PluginState : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PluginState()
			{
				InitJNI();
			}
			internal PluginState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values10439;
			public static global::android.webkit.WebSettings.PluginState[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.PluginState>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.PluginState.staticClass, global::android.webkit.WebSettings.PluginState._values10439)) as android.webkit.WebSettings.PluginState[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf10440;
			public static global::android.webkit.WebSettings.PluginState valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebSettings.PluginState.staticClass, global::android.webkit.WebSettings.PluginState._valueOf10440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.PluginState;
			}
			internal static global::MonoJavaBridge.FieldId _OFF10441;
			public static global::android.webkit.WebSettings.PluginState OFF
			{
				get
				{
					return default(global::android.webkit.WebSettings.PluginState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON10442;
			public static global::android.webkit.WebSettings.PluginState ON
			{
				get
				{
					return default(global::android.webkit.WebSettings.PluginState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_DEMAND10443;
			public static global::android.webkit.WebSettings.PluginState ON_DEMAND
			{
				get
				{
					return default(global::android.webkit.WebSettings.PluginState);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.PluginState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$PluginState"));
				global::android.webkit.WebSettings.PluginState._values10439 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "values", "()[Landroid/webkit/WebSettings/PluginState;");
				global::android.webkit.WebSettings.PluginState._valueOf10440 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$PluginState;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class RenderPriority : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RenderPriority()
			{
				InitJNI();
			}
			internal RenderPriority(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values10444;
			public static global::android.webkit.WebSettings.RenderPriority[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.RenderPriority>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._values10444)) as android.webkit.WebSettings.RenderPriority[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf10445;
			public static global::android.webkit.WebSettings.RenderPriority valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._valueOf10445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.RenderPriority;
			}
			internal static global::MonoJavaBridge.FieldId _HIGH10446;
			public static global::android.webkit.WebSettings.RenderPriority HIGH
			{
				get
				{
					return default(global::android.webkit.WebSettings.RenderPriority);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LOW10447;
			public static global::android.webkit.WebSettings.RenderPriority LOW
			{
				get
				{
					return default(global::android.webkit.WebSettings.RenderPriority);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL10448;
			public static global::android.webkit.WebSettings.RenderPriority NORMAL
			{
				get
				{
					return default(global::android.webkit.WebSettings.RenderPriority);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.RenderPriority.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$RenderPriority"));
				global::android.webkit.WebSettings.RenderPriority._values10444 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "values", "()[Landroid/webkit/WebSettings/RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._valueOf10445 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$RenderPriority;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class TextSize : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static TextSize()
			{
				InitJNI();
			}
			internal TextSize(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values10449;
			public static global::android.webkit.WebSettings.TextSize[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.TextSize>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._values10449)) as android.webkit.WebSettings.TextSize[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf10450;
			public static global::android.webkit.WebSettings.TextSize valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._valueOf10450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.TextSize;
			}
			internal static global::MonoJavaBridge.FieldId _LARGER10451;
			public static global::android.webkit.WebSettings.TextSize LARGER
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LARGEST10452;
			public static global::android.webkit.WebSettings.TextSize LARGEST
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL10453;
			public static global::android.webkit.WebSettings.TextSize NORMAL
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALLER10454;
			public static global::android.webkit.WebSettings.TextSize SMALLER
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALLEST10455;
			public static global::android.webkit.WebSettings.TextSize SMALLEST
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.TextSize.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$TextSize"));
				global::android.webkit.WebSettings.TextSize._values10449 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "values", "()[Landroid/webkit/WebSettings/TextSize;");
				global::android.webkit.WebSettings.TextSize._valueOf10450 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$TextSize;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class ZoomDensity : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ZoomDensity()
			{
				InitJNI();
			}
			internal ZoomDensity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values10456;
			public static global::android.webkit.WebSettings.ZoomDensity[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.ZoomDensity>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._values10456)) as android.webkit.WebSettings.ZoomDensity[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf10457;
			public static global::android.webkit.WebSettings.ZoomDensity valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._valueOf10457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.ZoomDensity;
			}
			internal static global::MonoJavaBridge.FieldId _CLOSE10458;
			public static global::android.webkit.WebSettings.ZoomDensity CLOSE
			{
				get
				{
					return default(global::android.webkit.WebSettings.ZoomDensity);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FAR10459;
			public static global::android.webkit.WebSettings.ZoomDensity FAR
			{
				get
				{
					return default(global::android.webkit.WebSettings.ZoomDensity);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MEDIUM10460;
			public static global::android.webkit.WebSettings.ZoomDensity MEDIUM
			{
				get
				{
					return default(global::android.webkit.WebSettings.ZoomDensity);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.ZoomDensity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$ZoomDensity"));
				global::android.webkit.WebSettings.ZoomDensity._values10456 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "values", "()[Landroid/webkit/WebSettings/ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._valueOf10457 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$ZoomDensity;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDatabasePath10461;
		public virtual global::java.lang.String getDatabasePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getDatabasePath10461)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDatabasePath10461)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTextSize10462;
		public virtual global::android.webkit.WebSettings.TextSize getTextSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getTextSize10462)) as android.webkit.WebSettings.TextSize;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getTextSize10462)) as android.webkit.WebSettings.TextSize;
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize10463;
		public virtual void setTextSize(android.webkit.WebSettings.TextSize arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setTextSize10463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setTextSize10463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNavDump10464;
		public virtual void setNavDump(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setNavDump10464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setNavDump10464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNavDump10465;
		public virtual bool getNavDump() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getNavDump10465);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getNavDump10465);
		}
		internal static global::MonoJavaBridge.MethodId _setSupportZoom10466;
		public virtual void setSupportZoom(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSupportZoom10466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSupportZoom10466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportZoom10467;
		public virtual bool supportZoom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._supportZoom10467);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._supportZoom10467);
		}
		internal static global::MonoJavaBridge.MethodId _setBuiltInZoomControls10468;
		public virtual void setBuiltInZoomControls(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setBuiltInZoomControls10468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBuiltInZoomControls10468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBuiltInZoomControls10469;
		public virtual bool getBuiltInZoomControls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getBuiltInZoomControls10469);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBuiltInZoomControls10469);
		}
		internal static global::MonoJavaBridge.MethodId _setAllowFileAccess10470;
		public virtual void setAllowFileAccess(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setAllowFileAccess10470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAllowFileAccess10470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAllowFileAccess10471;
		public virtual bool getAllowFileAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getAllowFileAccess10471);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getAllowFileAccess10471);
		}
		internal static global::MonoJavaBridge.MethodId _setLoadWithOverviewMode10472;
		public virtual void setLoadWithOverviewMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setLoadWithOverviewMode10472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLoadWithOverviewMode10472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLoadWithOverviewMode10473;
		public virtual bool getLoadWithOverviewMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getLoadWithOverviewMode10473);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLoadWithOverviewMode10473);
		}
		internal static global::MonoJavaBridge.MethodId _setSaveFormData10474;
		public virtual void setSaveFormData(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSaveFormData10474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSaveFormData10474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSaveFormData10475;
		public virtual bool getSaveFormData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getSaveFormData10475);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSaveFormData10475);
		}
		internal static global::MonoJavaBridge.MethodId _setSavePassword10476;
		public virtual void setSavePassword(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSavePassword10476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSavePassword10476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSavePassword10477;
		public virtual bool getSavePassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getSavePassword10477);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSavePassword10477);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultZoom10478;
		public virtual void setDefaultZoom(android.webkit.WebSettings.ZoomDensity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDefaultZoom10478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultZoom10478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultZoom10479;
		public virtual global::android.webkit.WebSettings.ZoomDensity getDefaultZoom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getDefaultZoom10479)) as android.webkit.WebSettings.ZoomDensity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultZoom10479)) as android.webkit.WebSettings.ZoomDensity;
		}
		internal static global::MonoJavaBridge.MethodId _setLightTouchEnabled10480;
		public virtual void setLightTouchEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setLightTouchEnabled10480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLightTouchEnabled10480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLightTouchEnabled10481;
		public virtual bool getLightTouchEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getLightTouchEnabled10481);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLightTouchEnabled10481);
		}
		internal static global::MonoJavaBridge.MethodId _setUseDoubleTree10482;
		public virtual void setUseDoubleTree(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setUseDoubleTree10482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUseDoubleTree10482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseDoubleTree10483;
		public virtual bool getUseDoubleTree() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getUseDoubleTree10483);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUseDoubleTree10483);
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgent10484;
		public virtual void setUserAgent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setUserAgent10484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUserAgent10484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUserAgent10485;
		public virtual int getUserAgent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getUserAgent10485);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUserAgent10485);
		}
		internal static global::MonoJavaBridge.MethodId _setUseWideViewPort10486;
		public virtual void setUseWideViewPort(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setUseWideViewPort10486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUseWideViewPort10486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseWideViewPort10487;
		public virtual bool getUseWideViewPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getUseWideViewPort10487);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUseWideViewPort10487);
		}
		internal static global::MonoJavaBridge.MethodId _setSupportMultipleWindows10488;
		public virtual void setSupportMultipleWindows(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSupportMultipleWindows10488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSupportMultipleWindows10488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportMultipleWindows10489;
		public virtual bool supportMultipleWindows() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._supportMultipleWindows10489);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._supportMultipleWindows10489);
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutAlgorithm10490;
		public virtual void setLayoutAlgorithm(android.webkit.WebSettings.LayoutAlgorithm arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setLayoutAlgorithm10490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLayoutAlgorithm10490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutAlgorithm10491;
		public virtual global::android.webkit.WebSettings.LayoutAlgorithm getLayoutAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getLayoutAlgorithm10491)) as android.webkit.WebSettings.LayoutAlgorithm;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLayoutAlgorithm10491)) as android.webkit.WebSettings.LayoutAlgorithm;
		}
		internal static global::MonoJavaBridge.MethodId _setStandardFontFamily10492;
		public virtual void setStandardFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setStandardFontFamily10492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setStandardFontFamily10492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStandardFontFamily10493;
		public virtual global::java.lang.String getStandardFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getStandardFontFamily10493)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getStandardFontFamily10493)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFixedFontFamily10494;
		public virtual void setFixedFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setFixedFontFamily10494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setFixedFontFamily10494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFixedFontFamily10495;
		public virtual global::java.lang.String getFixedFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getFixedFontFamily10495)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getFixedFontFamily10495)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSansSerifFontFamily10496;
		public virtual void setSansSerifFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSansSerifFontFamily10496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSansSerifFontFamily10496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSansSerifFontFamily10497;
		public virtual global::java.lang.String getSansSerifFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getSansSerifFontFamily10497)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSansSerifFontFamily10497)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSerifFontFamily10498;
		public virtual void setSerifFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSerifFontFamily10498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSerifFontFamily10498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSerifFontFamily10499;
		public virtual global::java.lang.String getSerifFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getSerifFontFamily10499)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSerifFontFamily10499)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setCursiveFontFamily10500;
		public virtual void setCursiveFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setCursiveFontFamily10500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setCursiveFontFamily10500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCursiveFontFamily10501;
		public virtual global::java.lang.String getCursiveFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getCursiveFontFamily10501)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getCursiveFontFamily10501)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFantasyFontFamily10502;
		public virtual void setFantasyFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setFantasyFontFamily10502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setFantasyFontFamily10502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFantasyFontFamily10503;
		public virtual global::java.lang.String getFantasyFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getFantasyFontFamily10503)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getFantasyFontFamily10503)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumFontSize10504;
		public virtual void setMinimumFontSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setMinimumFontSize10504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setMinimumFontSize10504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumFontSize10505;
		public virtual int getMinimumFontSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getMinimumFontSize10505);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getMinimumFontSize10505);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumLogicalFontSize10506;
		public virtual void setMinimumLogicalFontSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setMinimumLogicalFontSize10506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setMinimumLogicalFontSize10506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumLogicalFontSize10507;
		public virtual int getMinimumLogicalFontSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getMinimumLogicalFontSize10507);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getMinimumLogicalFontSize10507);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultFontSize10508;
		public virtual void setDefaultFontSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDefaultFontSize10508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultFontSize10508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultFontSize10509;
		public virtual int getDefaultFontSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getDefaultFontSize10509);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultFontSize10509);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultFixedFontSize10510;
		public virtual void setDefaultFixedFontSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDefaultFixedFontSize10510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultFixedFontSize10510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultFixedFontSize10511;
		public virtual int getDefaultFixedFontSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getDefaultFixedFontSize10511);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultFixedFontSize10511);
		}
		internal static global::MonoJavaBridge.MethodId _setLoadsImagesAutomatically10512;
		public virtual void setLoadsImagesAutomatically(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setLoadsImagesAutomatically10512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLoadsImagesAutomatically10512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLoadsImagesAutomatically10513;
		public virtual bool getLoadsImagesAutomatically() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getLoadsImagesAutomatically10513);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLoadsImagesAutomatically10513);
		}
		internal static global::MonoJavaBridge.MethodId _setBlockNetworkImage10514;
		public virtual void setBlockNetworkImage(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setBlockNetworkImage10514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBlockNetworkImage10514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBlockNetworkImage10515;
		public virtual bool getBlockNetworkImage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getBlockNetworkImage10515);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBlockNetworkImage10515);
		}
		internal static global::MonoJavaBridge.MethodId _setBlockNetworkLoads10516;
		public virtual void setBlockNetworkLoads(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setBlockNetworkLoads10516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBlockNetworkLoads10516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBlockNetworkLoads10517;
		public virtual bool getBlockNetworkLoads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getBlockNetworkLoads10517);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBlockNetworkLoads10517);
		}
		internal static global::MonoJavaBridge.MethodId _setJavaScriptEnabled10518;
		public virtual void setJavaScriptEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setJavaScriptEnabled10518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setJavaScriptEnabled10518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPluginsEnabled10519;
		public virtual void setPluginsEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setPluginsEnabled10519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginsEnabled10519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPluginState10520;
		public virtual void setPluginState(android.webkit.WebSettings.PluginState arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setPluginState10520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginState10520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPluginsPath10521;
		public virtual void setPluginsPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setPluginsPath10521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginsPath10521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDatabasePath10522;
		public virtual void setDatabasePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDatabasePath10522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDatabasePath10522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGeolocationDatabasePath10523;
		public virtual void setGeolocationDatabasePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setGeolocationDatabasePath10523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setGeolocationDatabasePath10523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAppCacheEnabled10524;
		public virtual void setAppCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setAppCacheEnabled10524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCacheEnabled10524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAppCachePath10525;
		public virtual void setAppCachePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setAppCachePath10525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCachePath10525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAppCacheMaxSize10526;
		public virtual void setAppCacheMaxSize(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setAppCacheMaxSize10526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCacheMaxSize10526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDatabaseEnabled10527;
		public virtual void setDatabaseEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDatabaseEnabled10527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDatabaseEnabled10527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomStorageEnabled10528;
		public virtual void setDomStorageEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDomStorageEnabled10528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDomStorageEnabled10528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDomStorageEnabled10529;
		public virtual bool getDomStorageEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getDomStorageEnabled10529);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDomStorageEnabled10529);
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseEnabled10530;
		public virtual bool getDatabaseEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getDatabaseEnabled10530);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDatabaseEnabled10530);
		}
		internal static global::MonoJavaBridge.MethodId _setGeolocationEnabled10531;
		public virtual void setGeolocationEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setGeolocationEnabled10531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setGeolocationEnabled10531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getJavaScriptEnabled10532;
		public virtual bool getJavaScriptEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getJavaScriptEnabled10532);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getJavaScriptEnabled10532);
		}
		internal static global::MonoJavaBridge.MethodId _getPluginsEnabled10533;
		public virtual bool getPluginsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getPluginsEnabled10533);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginsEnabled10533);
		}
		internal static global::MonoJavaBridge.MethodId _getPluginState10534;
		public virtual global::android.webkit.WebSettings.PluginState getPluginState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getPluginState10534)) as android.webkit.WebSettings.PluginState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginState10534)) as android.webkit.WebSettings.PluginState;
		}
		internal static global::MonoJavaBridge.MethodId _getPluginsPath10535;
		public virtual global::java.lang.String getPluginsPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getPluginsPath10535)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginsPath10535)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setJavaScriptCanOpenWindowsAutomatically10536;
		public virtual void setJavaScriptCanOpenWindowsAutomatically(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically10536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically10536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getJavaScriptCanOpenWindowsAutomatically10537;
		public virtual bool getJavaScriptCanOpenWindowsAutomatically() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically10537);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically10537);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultTextEncodingName10538;
		public virtual void setDefaultTextEncodingName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDefaultTextEncodingName10538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultTextEncodingName10538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultTextEncodingName10539;
		public virtual global::java.lang.String getDefaultTextEncodingName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getDefaultTextEncodingName10539)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultTextEncodingName10539)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgentString10540;
		public virtual void setUserAgentString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setUserAgentString10540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUserAgentString10540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUserAgentString10541;
		public virtual global::java.lang.String getUserAgentString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getUserAgentString10541)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUserAgentString10541)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNeedInitialFocus10542;
		public virtual void setNeedInitialFocus(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setNeedInitialFocus10542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setNeedInitialFocus10542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRenderPriority10543;
		public virtual void setRenderPriority(android.webkit.WebSettings.RenderPriority arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setRenderPriority10543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setRenderPriority10543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCacheMode10544;
		public virtual void setCacheMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setCacheMode10544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setCacheMode10544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCacheMode10545;
		public virtual int getCacheMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getCacheMode10545);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getCacheMode10545);
		}
		public static int LOAD_DEFAULT
		{
			get
			{
				return -1;
			}
		}
		public static int LOAD_NORMAL
		{
			get
			{
				return 0;
			}
		}
		public static int LOAD_CACHE_ELSE_NETWORK
		{
			get
			{
				return 1;
			}
		}
		public static int LOAD_NO_CACHE
		{
			get
			{
				return 2;
			}
		}
		public static int LOAD_CACHE_ONLY
		{
			get
			{
				return 3;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebSettings.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings"));
			global::android.webkit.WebSettings._getDatabasePath10461 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDatabasePath", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._getTextSize10462 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getTextSize", "()Landroid/webkit/WebSettings$TextSize;");
			global::android.webkit.WebSettings._setTextSize10463 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setTextSize", "(Landroid/webkit/WebSettings$TextSize;)V");
			global::android.webkit.WebSettings._setNavDump10464 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setNavDump", "(Z)V");
			global::android.webkit.WebSettings._getNavDump10465 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getNavDump", "()Z");
			global::android.webkit.WebSettings._setSupportZoom10466 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSupportZoom", "(Z)V");
			global::android.webkit.WebSettings._supportZoom10467 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "supportZoom", "()Z");
			global::android.webkit.WebSettings._setBuiltInZoomControls10468 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setBuiltInZoomControls", "(Z)V");
			global::android.webkit.WebSettings._getBuiltInZoomControls10469 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getBuiltInZoomControls", "()Z");
			global::android.webkit.WebSettings._setAllowFileAccess10470 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAllowFileAccess", "(Z)V");
			global::android.webkit.WebSettings._getAllowFileAccess10471 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getAllowFileAccess", "()Z");
			global::android.webkit.WebSettings._setLoadWithOverviewMode10472 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLoadWithOverviewMode", "(Z)V");
			global::android.webkit.WebSettings._getLoadWithOverviewMode10473 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLoadWithOverviewMode", "()Z");
			global::android.webkit.WebSettings._setSaveFormData10474 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSaveFormData", "(Z)V");
			global::android.webkit.WebSettings._getSaveFormData10475 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSaveFormData", "()Z");
			global::android.webkit.WebSettings._setSavePassword10476 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSavePassword", "(Z)V");
			global::android.webkit.WebSettings._getSavePassword10477 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSavePassword", "()Z");
			global::android.webkit.WebSettings._setDefaultZoom10478 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultZoom", "(Landroid/webkit/WebSettings$ZoomDensity;)V");
			global::android.webkit.WebSettings._getDefaultZoom10479 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultZoom", "()Landroid/webkit/WebSettings$ZoomDensity;");
			global::android.webkit.WebSettings._setLightTouchEnabled10480 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLightTouchEnabled", "(Z)V");
			global::android.webkit.WebSettings._getLightTouchEnabled10481 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLightTouchEnabled", "()Z");
			global::android.webkit.WebSettings._setUseDoubleTree10482 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUseDoubleTree", "(Z)V");
			global::android.webkit.WebSettings._getUseDoubleTree10483 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUseDoubleTree", "()Z");
			global::android.webkit.WebSettings._setUserAgent10484 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUserAgent", "(I)V");
			global::android.webkit.WebSettings._getUserAgent10485 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUserAgent", "()I");
			global::android.webkit.WebSettings._setUseWideViewPort10486 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUseWideViewPort", "(Z)V");
			global::android.webkit.WebSettings._getUseWideViewPort10487 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUseWideViewPort", "()Z");
			global::android.webkit.WebSettings._setSupportMultipleWindows10488 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSupportMultipleWindows", "(Z)V");
			global::android.webkit.WebSettings._supportMultipleWindows10489 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "supportMultipleWindows", "()Z");
			global::android.webkit.WebSettings._setLayoutAlgorithm10490 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLayoutAlgorithm", "(Landroid/webkit/WebSettings$LayoutAlgorithm;)V");
			global::android.webkit.WebSettings._getLayoutAlgorithm10491 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLayoutAlgorithm", "()Landroid/webkit/WebSettings$LayoutAlgorithm;");
			global::android.webkit.WebSettings._setStandardFontFamily10492 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setStandardFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getStandardFontFamily10493 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getStandardFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setFixedFontFamily10494 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setFixedFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getFixedFontFamily10495 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getFixedFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setSansSerifFontFamily10496 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSansSerifFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getSansSerifFontFamily10497 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSansSerifFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setSerifFontFamily10498 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSerifFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getSerifFontFamily10499 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSerifFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setCursiveFontFamily10500 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setCursiveFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getCursiveFontFamily10501 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getCursiveFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setFantasyFontFamily10502 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setFantasyFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getFantasyFontFamily10503 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getFantasyFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setMinimumFontSize10504 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setMinimumFontSize", "(I)V");
			global::android.webkit.WebSettings._getMinimumFontSize10505 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getMinimumFontSize", "()I");
			global::android.webkit.WebSettings._setMinimumLogicalFontSize10506 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setMinimumLogicalFontSize", "(I)V");
			global::android.webkit.WebSettings._getMinimumLogicalFontSize10507 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getMinimumLogicalFontSize", "()I");
			global::android.webkit.WebSettings._setDefaultFontSize10508 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultFontSize", "(I)V");
			global::android.webkit.WebSettings._getDefaultFontSize10509 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultFontSize", "()I");
			global::android.webkit.WebSettings._setDefaultFixedFontSize10510 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultFixedFontSize", "(I)V");
			global::android.webkit.WebSettings._getDefaultFixedFontSize10511 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultFixedFontSize", "()I");
			global::android.webkit.WebSettings._setLoadsImagesAutomatically10512 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLoadsImagesAutomatically", "(Z)V");
			global::android.webkit.WebSettings._getLoadsImagesAutomatically10513 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLoadsImagesAutomatically", "()Z");
			global::android.webkit.WebSettings._setBlockNetworkImage10514 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setBlockNetworkImage", "(Z)V");
			global::android.webkit.WebSettings._getBlockNetworkImage10515 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getBlockNetworkImage", "()Z");
			global::android.webkit.WebSettings._setBlockNetworkLoads10516 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setBlockNetworkLoads", "(Z)V");
			global::android.webkit.WebSettings._getBlockNetworkLoads10517 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getBlockNetworkLoads", "()Z");
			global::android.webkit.WebSettings._setJavaScriptEnabled10518 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setJavaScriptEnabled", "(Z)V");
			global::android.webkit.WebSettings._setPluginsEnabled10519 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setPluginsEnabled", "(Z)V");
			global::android.webkit.WebSettings._setPluginState10520 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setPluginState", "(Landroid/webkit/WebSettings$PluginState;)V");
			global::android.webkit.WebSettings._setPluginsPath10521 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setPluginsPath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setDatabasePath10522 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDatabasePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setGeolocationDatabasePath10523 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setGeolocationDatabasePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setAppCacheEnabled10524 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAppCacheEnabled", "(Z)V");
			global::android.webkit.WebSettings._setAppCachePath10525 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAppCachePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setAppCacheMaxSize10526 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAppCacheMaxSize", "(J)V");
			global::android.webkit.WebSettings._setDatabaseEnabled10527 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDatabaseEnabled", "(Z)V");
			global::android.webkit.WebSettings._setDomStorageEnabled10528 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDomStorageEnabled", "(Z)V");
			global::android.webkit.WebSettings._getDomStorageEnabled10529 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDomStorageEnabled", "()Z");
			global::android.webkit.WebSettings._getDatabaseEnabled10530 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDatabaseEnabled", "()Z");
			global::android.webkit.WebSettings._setGeolocationEnabled10531 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setGeolocationEnabled", "(Z)V");
			global::android.webkit.WebSettings._getJavaScriptEnabled10532 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getJavaScriptEnabled", "()Z");
			global::android.webkit.WebSettings._getPluginsEnabled10533 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getPluginsEnabled", "()Z");
			global::android.webkit.WebSettings._getPluginState10534 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getPluginState", "()Landroid/webkit/WebSettings$PluginState;");
			global::android.webkit.WebSettings._getPluginsPath10535 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getPluginsPath", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically10536 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setJavaScriptCanOpenWindowsAutomatically", "(Z)V");
			global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically10537 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getJavaScriptCanOpenWindowsAutomatically", "()Z");
			global::android.webkit.WebSettings._setDefaultTextEncodingName10538 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultTextEncodingName", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getDefaultTextEncodingName10539 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultTextEncodingName", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setUserAgentString10540 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUserAgentString", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getUserAgentString10541 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUserAgentString", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setNeedInitialFocus10542 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setNeedInitialFocus", "(Z)V");
			global::android.webkit.WebSettings._setRenderPriority10543 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setRenderPriority", "(Landroid/webkit/WebSettings$RenderPriority;)V");
			global::android.webkit.WebSettings._setCacheMode10544 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setCacheMode", "(I)V");
			global::android.webkit.WebSettings._getCacheMode10545 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getCacheMode", "()I");
		}
	}
}
