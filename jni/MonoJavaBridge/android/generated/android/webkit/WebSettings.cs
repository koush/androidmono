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
			internal static global::MonoJavaBridge.MethodId _values10980;
			public static global::android.webkit.WebSettings.LayoutAlgorithm[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.LayoutAlgorithm>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._values10980)) as android.webkit.WebSettings.LayoutAlgorithm[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf10981;
			public static global::android.webkit.WebSettings.LayoutAlgorithm valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._valueOf10981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.LayoutAlgorithm;
			}
			internal static global::MonoJavaBridge.FieldId _NARROW_COLUMNS10982;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NARROW_COLUMNS
			{
				get
				{
					return default(global::android.webkit.WebSettings.LayoutAlgorithm);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL10983;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NORMAL
			{
				get
				{
					return default(global::android.webkit.WebSettings.LayoutAlgorithm);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SINGLE_COLUMN10984;
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
				global::android.webkit.WebSettings.LayoutAlgorithm._values10980 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "values", "()[Landroid/webkit/WebSettings/LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._valueOf10981 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$LayoutAlgorithm;");
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
			internal static global::MonoJavaBridge.MethodId _values10985;
			public static global::android.webkit.WebSettings.PluginState[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.PluginState>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.PluginState.staticClass, global::android.webkit.WebSettings.PluginState._values10985)) as android.webkit.WebSettings.PluginState[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf10986;
			public static global::android.webkit.WebSettings.PluginState valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebSettings.PluginState.staticClass, global::android.webkit.WebSettings.PluginState._valueOf10986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.PluginState;
			}
			internal static global::MonoJavaBridge.FieldId _OFF10987;
			public static global::android.webkit.WebSettings.PluginState OFF
			{
				get
				{
					return default(global::android.webkit.WebSettings.PluginState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON10988;
			public static global::android.webkit.WebSettings.PluginState ON
			{
				get
				{
					return default(global::android.webkit.WebSettings.PluginState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_DEMAND10989;
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
				global::android.webkit.WebSettings.PluginState._values10985 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "values", "()[Landroid/webkit/WebSettings/PluginState;");
				global::android.webkit.WebSettings.PluginState._valueOf10986 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$PluginState;");
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
			internal static global::MonoJavaBridge.MethodId _values10990;
			public static global::android.webkit.WebSettings.RenderPriority[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.RenderPriority>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._values10990)) as android.webkit.WebSettings.RenderPriority[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf10991;
			public static global::android.webkit.WebSettings.RenderPriority valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._valueOf10991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.RenderPriority;
			}
			internal static global::MonoJavaBridge.FieldId _HIGH10992;
			public static global::android.webkit.WebSettings.RenderPriority HIGH
			{
				get
				{
					return default(global::android.webkit.WebSettings.RenderPriority);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LOW10993;
			public static global::android.webkit.WebSettings.RenderPriority LOW
			{
				get
				{
					return default(global::android.webkit.WebSettings.RenderPriority);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL10994;
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
				global::android.webkit.WebSettings.RenderPriority._values10990 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "values", "()[Landroid/webkit/WebSettings/RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._valueOf10991 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$RenderPriority;");
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
			internal static global::MonoJavaBridge.MethodId _values10995;
			public static global::android.webkit.WebSettings.TextSize[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.TextSize>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._values10995)) as android.webkit.WebSettings.TextSize[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf10996;
			public static global::android.webkit.WebSettings.TextSize valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._valueOf10996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.TextSize;
			}
			internal static global::MonoJavaBridge.FieldId _LARGER10997;
			public static global::android.webkit.WebSettings.TextSize LARGER
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LARGEST10998;
			public static global::android.webkit.WebSettings.TextSize LARGEST
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL10999;
			public static global::android.webkit.WebSettings.TextSize NORMAL
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALLER11000;
			public static global::android.webkit.WebSettings.TextSize SMALLER
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALLEST11001;
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
				global::android.webkit.WebSettings.TextSize._values10995 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "values", "()[Landroid/webkit/WebSettings/TextSize;");
				global::android.webkit.WebSettings.TextSize._valueOf10996 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$TextSize;");
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
			internal static global::MonoJavaBridge.MethodId _values11002;
			public static global::android.webkit.WebSettings.ZoomDensity[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.ZoomDensity>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._values11002)) as android.webkit.WebSettings.ZoomDensity[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf11003;
			public static global::android.webkit.WebSettings.ZoomDensity valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._valueOf11003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.ZoomDensity;
			}
			internal static global::MonoJavaBridge.FieldId _CLOSE11004;
			public static global::android.webkit.WebSettings.ZoomDensity CLOSE
			{
				get
				{
					return default(global::android.webkit.WebSettings.ZoomDensity);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FAR11005;
			public static global::android.webkit.WebSettings.ZoomDensity FAR
			{
				get
				{
					return default(global::android.webkit.WebSettings.ZoomDensity);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MEDIUM11006;
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
				global::android.webkit.WebSettings.ZoomDensity._values11002 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "values", "()[Landroid/webkit/WebSettings/ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._valueOf11003 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$ZoomDensity;");
			}
		}
		public new global::java.lang.String DatabasePath
		{
			get
			{
				return getDatabasePath();
			}
			set
			{
				setDatabasePath(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDatabasePath11007;
		public virtual global::java.lang.String getDatabasePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getDatabasePath11007)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDatabasePath11007)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTextSize11008;
		public virtual global::android.webkit.WebSettings.TextSize getTextSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getTextSize11008)) as android.webkit.WebSettings.TextSize;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getTextSize11008)) as android.webkit.WebSettings.TextSize;
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize11009;
		public virtual void setTextSize(android.webkit.WebSettings.TextSize arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setTextSize11009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setTextSize11009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNavDump11010;
		public virtual void setNavDump(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setNavDump11010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setNavDump11010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool NavDump
		{
			get
			{
				return getNavDump();
			}
			set
			{
				setNavDump(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNavDump11011;
		public virtual bool getNavDump() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getNavDump11011);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getNavDump11011);
		}
		internal static global::MonoJavaBridge.MethodId _setSupportZoom11012;
		public virtual void setSupportZoom(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSupportZoom11012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSupportZoom11012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportZoom11013;
		public virtual bool supportZoom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._supportZoom11013);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._supportZoom11013);
		}
		internal static global::MonoJavaBridge.MethodId _setBuiltInZoomControls11014;
		public virtual void setBuiltInZoomControls(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setBuiltInZoomControls11014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBuiltInZoomControls11014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool BuiltInZoomControls
		{
			get
			{
				return getBuiltInZoomControls();
			}
			set
			{
				setBuiltInZoomControls(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBuiltInZoomControls11015;
		public virtual bool getBuiltInZoomControls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getBuiltInZoomControls11015);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBuiltInZoomControls11015);
		}
		internal static global::MonoJavaBridge.MethodId _setAllowFileAccess11016;
		public virtual void setAllowFileAccess(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setAllowFileAccess11016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAllowFileAccess11016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool AllowFileAccess
		{
			get
			{
				return getAllowFileAccess();
			}
			set
			{
				setAllowFileAccess(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllowFileAccess11017;
		public virtual bool getAllowFileAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getAllowFileAccess11017);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getAllowFileAccess11017);
		}
		internal static global::MonoJavaBridge.MethodId _setLoadWithOverviewMode11018;
		public virtual void setLoadWithOverviewMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setLoadWithOverviewMode11018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLoadWithOverviewMode11018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool LoadWithOverviewMode
		{
			get
			{
				return getLoadWithOverviewMode();
			}
			set
			{
				setLoadWithOverviewMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoadWithOverviewMode11019;
		public virtual bool getLoadWithOverviewMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getLoadWithOverviewMode11019);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLoadWithOverviewMode11019);
		}
		internal static global::MonoJavaBridge.MethodId _setSaveFormData11020;
		public virtual void setSaveFormData(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSaveFormData11020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSaveFormData11020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool SaveFormData
		{
			get
			{
				return getSaveFormData();
			}
			set
			{
				setSaveFormData(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSaveFormData11021;
		public virtual bool getSaveFormData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getSaveFormData11021);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSaveFormData11021);
		}
		internal static global::MonoJavaBridge.MethodId _setSavePassword11022;
		public virtual void setSavePassword(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSavePassword11022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSavePassword11022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool SavePassword
		{
			get
			{
				return getSavePassword();
			}
			set
			{
				setSavePassword(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSavePassword11023;
		public virtual bool getSavePassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getSavePassword11023);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSavePassword11023);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultZoom11024;
		public virtual void setDefaultZoom(android.webkit.WebSettings.ZoomDensity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDefaultZoom11024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultZoom11024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.webkit.WebSettings.ZoomDensity DefaultZoom
		{
			get
			{
				return getDefaultZoom();
			}
			set
			{
				setDefaultZoom(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultZoom11025;
		public virtual global::android.webkit.WebSettings.ZoomDensity getDefaultZoom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getDefaultZoom11025)) as android.webkit.WebSettings.ZoomDensity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultZoom11025)) as android.webkit.WebSettings.ZoomDensity;
		}
		internal static global::MonoJavaBridge.MethodId _setLightTouchEnabled11026;
		public virtual void setLightTouchEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setLightTouchEnabled11026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLightTouchEnabled11026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool LightTouchEnabled
		{
			get
			{
				return getLightTouchEnabled();
			}
			set
			{
				setLightTouchEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLightTouchEnabled11027;
		public virtual bool getLightTouchEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getLightTouchEnabled11027);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLightTouchEnabled11027);
		}
		internal static global::MonoJavaBridge.MethodId _setUseDoubleTree11028;
		public virtual void setUseDoubleTree(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setUseDoubleTree11028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUseDoubleTree11028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool UseDoubleTree
		{
			get
			{
				return getUseDoubleTree();
			}
			set
			{
				setUseDoubleTree(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUseDoubleTree11029;
		public virtual bool getUseDoubleTree() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getUseDoubleTree11029);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUseDoubleTree11029);
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgent11030;
		public virtual void setUserAgent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setUserAgent11030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUserAgent11030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int UserAgent
		{
			get
			{
				return getUserAgent();
			}
			set
			{
				setUserAgent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserAgent11031;
		public virtual int getUserAgent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getUserAgent11031);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUserAgent11031);
		}
		internal static global::MonoJavaBridge.MethodId _setUseWideViewPort11032;
		public virtual void setUseWideViewPort(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setUseWideViewPort11032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUseWideViewPort11032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool UseWideViewPort
		{
			get
			{
				return getUseWideViewPort();
			}
			set
			{
				setUseWideViewPort(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUseWideViewPort11033;
		public virtual bool getUseWideViewPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getUseWideViewPort11033);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUseWideViewPort11033);
		}
		internal static global::MonoJavaBridge.MethodId _setSupportMultipleWindows11034;
		public virtual void setSupportMultipleWindows(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSupportMultipleWindows11034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSupportMultipleWindows11034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportMultipleWindows11035;
		public virtual bool supportMultipleWindows() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._supportMultipleWindows11035);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._supportMultipleWindows11035);
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutAlgorithm11036;
		public virtual void setLayoutAlgorithm(android.webkit.WebSettings.LayoutAlgorithm arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setLayoutAlgorithm11036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLayoutAlgorithm11036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutAlgorithm11037;
		public virtual global::android.webkit.WebSettings.LayoutAlgorithm getLayoutAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getLayoutAlgorithm11037)) as android.webkit.WebSettings.LayoutAlgorithm;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLayoutAlgorithm11037)) as android.webkit.WebSettings.LayoutAlgorithm;
		}
		internal static global::MonoJavaBridge.MethodId _setStandardFontFamily11038;
		public virtual void setStandardFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setStandardFontFamily11038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setStandardFontFamily11038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String StandardFontFamily
		{
			get
			{
				return getStandardFontFamily();
			}
			set
			{
				setStandardFontFamily(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStandardFontFamily11039;
		public virtual global::java.lang.String getStandardFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getStandardFontFamily11039)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getStandardFontFamily11039)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFixedFontFamily11040;
		public virtual void setFixedFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setFixedFontFamily11040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setFixedFontFamily11040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String FixedFontFamily
		{
			get
			{
				return getFixedFontFamily();
			}
			set
			{
				setFixedFontFamily(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFixedFontFamily11041;
		public virtual global::java.lang.String getFixedFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getFixedFontFamily11041)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getFixedFontFamily11041)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSansSerifFontFamily11042;
		public virtual void setSansSerifFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSansSerifFontFamily11042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSansSerifFontFamily11042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SansSerifFontFamily
		{
			get
			{
				return getSansSerifFontFamily();
			}
			set
			{
				setSansSerifFontFamily(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSansSerifFontFamily11043;
		public virtual global::java.lang.String getSansSerifFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getSansSerifFontFamily11043)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSansSerifFontFamily11043)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSerifFontFamily11044;
		public virtual void setSerifFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSerifFontFamily11044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSerifFontFamily11044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SerifFontFamily
		{
			get
			{
				return getSerifFontFamily();
			}
			set
			{
				setSerifFontFamily(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSerifFontFamily11045;
		public virtual global::java.lang.String getSerifFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getSerifFontFamily11045)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSerifFontFamily11045)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setCursiveFontFamily11046;
		public virtual void setCursiveFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setCursiveFontFamily11046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setCursiveFontFamily11046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CursiveFontFamily
		{
			get
			{
				return getCursiveFontFamily();
			}
			set
			{
				setCursiveFontFamily(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCursiveFontFamily11047;
		public virtual global::java.lang.String getCursiveFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getCursiveFontFamily11047)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getCursiveFontFamily11047)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFantasyFontFamily11048;
		public virtual void setFantasyFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setFantasyFontFamily11048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setFantasyFontFamily11048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String FantasyFontFamily
		{
			get
			{
				return getFantasyFontFamily();
			}
			set
			{
				setFantasyFontFamily(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFantasyFontFamily11049;
		public virtual global::java.lang.String getFantasyFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getFantasyFontFamily11049)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getFantasyFontFamily11049)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumFontSize11050;
		public virtual void setMinimumFontSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setMinimumFontSize11050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setMinimumFontSize11050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinimumFontSize
		{
			get
			{
				return getMinimumFontSize();
			}
			set
			{
				setMinimumFontSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumFontSize11051;
		public virtual int getMinimumFontSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getMinimumFontSize11051);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getMinimumFontSize11051);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumLogicalFontSize11052;
		public virtual void setMinimumLogicalFontSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setMinimumLogicalFontSize11052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setMinimumLogicalFontSize11052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinimumLogicalFontSize
		{
			get
			{
				return getMinimumLogicalFontSize();
			}
			set
			{
				setMinimumLogicalFontSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumLogicalFontSize11053;
		public virtual int getMinimumLogicalFontSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getMinimumLogicalFontSize11053);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getMinimumLogicalFontSize11053);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultFontSize11054;
		public virtual void setDefaultFontSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDefaultFontSize11054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultFontSize11054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DefaultFontSize
		{
			get
			{
				return getDefaultFontSize();
			}
			set
			{
				setDefaultFontSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultFontSize11055;
		public virtual int getDefaultFontSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getDefaultFontSize11055);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultFontSize11055);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultFixedFontSize11056;
		public virtual void setDefaultFixedFontSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDefaultFixedFontSize11056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultFixedFontSize11056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DefaultFixedFontSize
		{
			get
			{
				return getDefaultFixedFontSize();
			}
			set
			{
				setDefaultFixedFontSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultFixedFontSize11057;
		public virtual int getDefaultFixedFontSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getDefaultFixedFontSize11057);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultFixedFontSize11057);
		}
		internal static global::MonoJavaBridge.MethodId _setLoadsImagesAutomatically11058;
		public virtual void setLoadsImagesAutomatically(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setLoadsImagesAutomatically11058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLoadsImagesAutomatically11058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool LoadsImagesAutomatically
		{
			get
			{
				return getLoadsImagesAutomatically();
			}
			set
			{
				setLoadsImagesAutomatically(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoadsImagesAutomatically11059;
		public virtual bool getLoadsImagesAutomatically() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getLoadsImagesAutomatically11059);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLoadsImagesAutomatically11059);
		}
		internal static global::MonoJavaBridge.MethodId _setBlockNetworkImage11060;
		public virtual void setBlockNetworkImage(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setBlockNetworkImage11060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBlockNetworkImage11060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool BlockNetworkImage
		{
			get
			{
				return getBlockNetworkImage();
			}
			set
			{
				setBlockNetworkImage(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBlockNetworkImage11061;
		public virtual bool getBlockNetworkImage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getBlockNetworkImage11061);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBlockNetworkImage11061);
		}
		internal static global::MonoJavaBridge.MethodId _setBlockNetworkLoads11062;
		public virtual void setBlockNetworkLoads(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setBlockNetworkLoads11062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBlockNetworkLoads11062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool BlockNetworkLoads
		{
			get
			{
				return getBlockNetworkLoads();
			}
			set
			{
				setBlockNetworkLoads(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBlockNetworkLoads11063;
		public virtual bool getBlockNetworkLoads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getBlockNetworkLoads11063);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBlockNetworkLoads11063);
		}
		internal static global::MonoJavaBridge.MethodId _setJavaScriptEnabled11064;
		public virtual void setJavaScriptEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setJavaScriptEnabled11064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setJavaScriptEnabled11064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPluginsEnabled11065;
		public virtual void setPluginsEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setPluginsEnabled11065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginsEnabled11065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPluginState11066;
		public virtual void setPluginState(android.webkit.WebSettings.PluginState arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setPluginState11066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginState11066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPluginsPath11067;
		public virtual void setPluginsPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setPluginsPath11067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginsPath11067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDatabasePath11068;
		public virtual void setDatabasePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDatabasePath11068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDatabasePath11068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGeolocationDatabasePath11069;
		public virtual void setGeolocationDatabasePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setGeolocationDatabasePath11069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setGeolocationDatabasePath11069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAppCacheEnabled11070;
		public virtual void setAppCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setAppCacheEnabled11070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCacheEnabled11070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAppCachePath11071;
		public virtual void setAppCachePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setAppCachePath11071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCachePath11071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAppCacheMaxSize11072;
		public virtual void setAppCacheMaxSize(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setAppCacheMaxSize11072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCacheMaxSize11072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDatabaseEnabled11073;
		public virtual void setDatabaseEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDatabaseEnabled11073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDatabaseEnabled11073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomStorageEnabled11074;
		public virtual void setDomStorageEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDomStorageEnabled11074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDomStorageEnabled11074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool DomStorageEnabled
		{
			get
			{
				return getDomStorageEnabled();
			}
			set
			{
				setDomStorageEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDomStorageEnabled11075;
		public virtual bool getDomStorageEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getDomStorageEnabled11075);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDomStorageEnabled11075);
		}
		public new bool DatabaseEnabled
		{
			get
			{
				return getDatabaseEnabled();
			}
			set
			{
				setDatabaseEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseEnabled11076;
		public virtual bool getDatabaseEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getDatabaseEnabled11076);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDatabaseEnabled11076);
		}
		internal static global::MonoJavaBridge.MethodId _setGeolocationEnabled11077;
		public virtual void setGeolocationEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setGeolocationEnabled11077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setGeolocationEnabled11077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool JavaScriptEnabled
		{
			get
			{
				return getJavaScriptEnabled();
			}
			set
			{
				setJavaScriptEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getJavaScriptEnabled11078;
		public virtual bool getJavaScriptEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getJavaScriptEnabled11078);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getJavaScriptEnabled11078);
		}
		public new bool PluginsEnabled
		{
			get
			{
				return getPluginsEnabled();
			}
			set
			{
				setPluginsEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPluginsEnabled11079;
		public virtual bool getPluginsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getPluginsEnabled11079);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginsEnabled11079);
		}
		internal static global::MonoJavaBridge.MethodId _getPluginState11080;
		public virtual global::android.webkit.WebSettings.PluginState getPluginState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getPluginState11080)) as android.webkit.WebSettings.PluginState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginState11080)) as android.webkit.WebSettings.PluginState;
		}
		public new global::java.lang.String PluginsPath
		{
			get
			{
				return getPluginsPath();
			}
			set
			{
				setPluginsPath(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPluginsPath11081;
		public virtual global::java.lang.String getPluginsPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getPluginsPath11081)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginsPath11081)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setJavaScriptCanOpenWindowsAutomatically11082;
		public virtual void setJavaScriptCanOpenWindowsAutomatically(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically11082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically11082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool JavaScriptCanOpenWindowsAutomatically
		{
			get
			{
				return getJavaScriptCanOpenWindowsAutomatically();
			}
			set
			{
				setJavaScriptCanOpenWindowsAutomatically(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getJavaScriptCanOpenWindowsAutomatically11083;
		public virtual bool getJavaScriptCanOpenWindowsAutomatically() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically11083);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically11083);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultTextEncodingName11084;
		public virtual void setDefaultTextEncodingName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDefaultTextEncodingName11084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultTextEncodingName11084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String DefaultTextEncodingName
		{
			get
			{
				return getDefaultTextEncodingName();
			}
			set
			{
				setDefaultTextEncodingName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultTextEncodingName11085;
		public virtual global::java.lang.String getDefaultTextEncodingName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getDefaultTextEncodingName11085)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultTextEncodingName11085)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgentString11086;
		public virtual void setUserAgentString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setUserAgentString11086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUserAgentString11086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String UserAgentString
		{
			get
			{
				return getUserAgentString();
			}
			set
			{
				setUserAgentString(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserAgentString11087;
		public virtual global::java.lang.String getUserAgentString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getUserAgentString11087)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUserAgentString11087)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNeedInitialFocus11088;
		public virtual void setNeedInitialFocus(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setNeedInitialFocus11088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setNeedInitialFocus11088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRenderPriority11089;
		public virtual void setRenderPriority(android.webkit.WebSettings.RenderPriority arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setRenderPriority11089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setRenderPriority11089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCacheMode11090;
		public virtual void setCacheMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setCacheMode11090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setCacheMode11090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CacheMode
		{
			get
			{
				return getCacheMode();
			}
			set
			{
				setCacheMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCacheMode11091;
		public virtual int getCacheMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getCacheMode11091);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getCacheMode11091);
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
			global::android.webkit.WebSettings._getDatabasePath11007 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDatabasePath", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._getTextSize11008 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getTextSize", "()Landroid/webkit/WebSettings$TextSize;");
			global::android.webkit.WebSettings._setTextSize11009 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setTextSize", "(Landroid/webkit/WebSettings$TextSize;)V");
			global::android.webkit.WebSettings._setNavDump11010 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setNavDump", "(Z)V");
			global::android.webkit.WebSettings._getNavDump11011 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getNavDump", "()Z");
			global::android.webkit.WebSettings._setSupportZoom11012 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSupportZoom", "(Z)V");
			global::android.webkit.WebSettings._supportZoom11013 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "supportZoom", "()Z");
			global::android.webkit.WebSettings._setBuiltInZoomControls11014 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setBuiltInZoomControls", "(Z)V");
			global::android.webkit.WebSettings._getBuiltInZoomControls11015 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getBuiltInZoomControls", "()Z");
			global::android.webkit.WebSettings._setAllowFileAccess11016 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAllowFileAccess", "(Z)V");
			global::android.webkit.WebSettings._getAllowFileAccess11017 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getAllowFileAccess", "()Z");
			global::android.webkit.WebSettings._setLoadWithOverviewMode11018 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLoadWithOverviewMode", "(Z)V");
			global::android.webkit.WebSettings._getLoadWithOverviewMode11019 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLoadWithOverviewMode", "()Z");
			global::android.webkit.WebSettings._setSaveFormData11020 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSaveFormData", "(Z)V");
			global::android.webkit.WebSettings._getSaveFormData11021 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSaveFormData", "()Z");
			global::android.webkit.WebSettings._setSavePassword11022 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSavePassword", "(Z)V");
			global::android.webkit.WebSettings._getSavePassword11023 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSavePassword", "()Z");
			global::android.webkit.WebSettings._setDefaultZoom11024 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultZoom", "(Landroid/webkit/WebSettings$ZoomDensity;)V");
			global::android.webkit.WebSettings._getDefaultZoom11025 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultZoom", "()Landroid/webkit/WebSettings$ZoomDensity;");
			global::android.webkit.WebSettings._setLightTouchEnabled11026 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLightTouchEnabled", "(Z)V");
			global::android.webkit.WebSettings._getLightTouchEnabled11027 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLightTouchEnabled", "()Z");
			global::android.webkit.WebSettings._setUseDoubleTree11028 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUseDoubleTree", "(Z)V");
			global::android.webkit.WebSettings._getUseDoubleTree11029 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUseDoubleTree", "()Z");
			global::android.webkit.WebSettings._setUserAgent11030 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUserAgent", "(I)V");
			global::android.webkit.WebSettings._getUserAgent11031 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUserAgent", "()I");
			global::android.webkit.WebSettings._setUseWideViewPort11032 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUseWideViewPort", "(Z)V");
			global::android.webkit.WebSettings._getUseWideViewPort11033 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUseWideViewPort", "()Z");
			global::android.webkit.WebSettings._setSupportMultipleWindows11034 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSupportMultipleWindows", "(Z)V");
			global::android.webkit.WebSettings._supportMultipleWindows11035 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "supportMultipleWindows", "()Z");
			global::android.webkit.WebSettings._setLayoutAlgorithm11036 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLayoutAlgorithm", "(Landroid/webkit/WebSettings$LayoutAlgorithm;)V");
			global::android.webkit.WebSettings._getLayoutAlgorithm11037 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLayoutAlgorithm", "()Landroid/webkit/WebSettings$LayoutAlgorithm;");
			global::android.webkit.WebSettings._setStandardFontFamily11038 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setStandardFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getStandardFontFamily11039 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getStandardFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setFixedFontFamily11040 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setFixedFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getFixedFontFamily11041 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getFixedFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setSansSerifFontFamily11042 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSansSerifFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getSansSerifFontFamily11043 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSansSerifFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setSerifFontFamily11044 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSerifFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getSerifFontFamily11045 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSerifFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setCursiveFontFamily11046 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setCursiveFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getCursiveFontFamily11047 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getCursiveFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setFantasyFontFamily11048 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setFantasyFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getFantasyFontFamily11049 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getFantasyFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setMinimumFontSize11050 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setMinimumFontSize", "(I)V");
			global::android.webkit.WebSettings._getMinimumFontSize11051 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getMinimumFontSize", "()I");
			global::android.webkit.WebSettings._setMinimumLogicalFontSize11052 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setMinimumLogicalFontSize", "(I)V");
			global::android.webkit.WebSettings._getMinimumLogicalFontSize11053 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getMinimumLogicalFontSize", "()I");
			global::android.webkit.WebSettings._setDefaultFontSize11054 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultFontSize", "(I)V");
			global::android.webkit.WebSettings._getDefaultFontSize11055 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultFontSize", "()I");
			global::android.webkit.WebSettings._setDefaultFixedFontSize11056 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultFixedFontSize", "(I)V");
			global::android.webkit.WebSettings._getDefaultFixedFontSize11057 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultFixedFontSize", "()I");
			global::android.webkit.WebSettings._setLoadsImagesAutomatically11058 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLoadsImagesAutomatically", "(Z)V");
			global::android.webkit.WebSettings._getLoadsImagesAutomatically11059 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLoadsImagesAutomatically", "()Z");
			global::android.webkit.WebSettings._setBlockNetworkImage11060 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setBlockNetworkImage", "(Z)V");
			global::android.webkit.WebSettings._getBlockNetworkImage11061 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getBlockNetworkImage", "()Z");
			global::android.webkit.WebSettings._setBlockNetworkLoads11062 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setBlockNetworkLoads", "(Z)V");
			global::android.webkit.WebSettings._getBlockNetworkLoads11063 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getBlockNetworkLoads", "()Z");
			global::android.webkit.WebSettings._setJavaScriptEnabled11064 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setJavaScriptEnabled", "(Z)V");
			global::android.webkit.WebSettings._setPluginsEnabled11065 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setPluginsEnabled", "(Z)V");
			global::android.webkit.WebSettings._setPluginState11066 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setPluginState", "(Landroid/webkit/WebSettings$PluginState;)V");
			global::android.webkit.WebSettings._setPluginsPath11067 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setPluginsPath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setDatabasePath11068 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDatabasePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setGeolocationDatabasePath11069 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setGeolocationDatabasePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setAppCacheEnabled11070 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAppCacheEnabled", "(Z)V");
			global::android.webkit.WebSettings._setAppCachePath11071 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAppCachePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setAppCacheMaxSize11072 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAppCacheMaxSize", "(J)V");
			global::android.webkit.WebSettings._setDatabaseEnabled11073 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDatabaseEnabled", "(Z)V");
			global::android.webkit.WebSettings._setDomStorageEnabled11074 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDomStorageEnabled", "(Z)V");
			global::android.webkit.WebSettings._getDomStorageEnabled11075 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDomStorageEnabled", "()Z");
			global::android.webkit.WebSettings._getDatabaseEnabled11076 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDatabaseEnabled", "()Z");
			global::android.webkit.WebSettings._setGeolocationEnabled11077 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setGeolocationEnabled", "(Z)V");
			global::android.webkit.WebSettings._getJavaScriptEnabled11078 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getJavaScriptEnabled", "()Z");
			global::android.webkit.WebSettings._getPluginsEnabled11079 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getPluginsEnabled", "()Z");
			global::android.webkit.WebSettings._getPluginState11080 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getPluginState", "()Landroid/webkit/WebSettings$PluginState;");
			global::android.webkit.WebSettings._getPluginsPath11081 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getPluginsPath", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically11082 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setJavaScriptCanOpenWindowsAutomatically", "(Z)V");
			global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically11083 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getJavaScriptCanOpenWindowsAutomatically", "()Z");
			global::android.webkit.WebSettings._setDefaultTextEncodingName11084 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultTextEncodingName", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getDefaultTextEncodingName11085 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultTextEncodingName", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setUserAgentString11086 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUserAgentString", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getUserAgentString11087 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUserAgentString", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setNeedInitialFocus11088 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setNeedInitialFocus", "(Z)V");
			global::android.webkit.WebSettings._setRenderPriority11089 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setRenderPriority", "(Landroid/webkit/WebSettings$RenderPriority;)V");
			global::android.webkit.WebSettings._setCacheMode11090 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setCacheMode", "(I)V");
			global::android.webkit.WebSettings._getCacheMode11091 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getCacheMode", "()I");
		}
	}
}
