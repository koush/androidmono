namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class WebSettings : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static WebSettings()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebSettings), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.WebSettings(@__env);
			}
		}
		protected WebSettings(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class LayoutAlgorithm : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static LayoutAlgorithm()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebSettings.LayoutAlgorithm), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.webkit.WebSettings.LayoutAlgorithm(@__env);
				}
			}
			internal LayoutAlgorithm(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values10087;
			public static global::android.webkit.WebSettings.LayoutAlgorithm[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._values10087));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf10088;
			public static global::android.webkit.WebSettings.LayoutAlgorithm valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.LayoutAlgorithm>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._valueOf10088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _NARROW_COLUMNS10089;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NARROW_COLUMNS
			{
				get
				{
					return default(global::android.webkit.WebSettings.LayoutAlgorithm);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL10090;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NORMAL
			{
				get
				{
					return default(global::android.webkit.WebSettings.LayoutAlgorithm);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SINGLE_COLUMN10091;
			public static global::android.webkit.WebSettings.LayoutAlgorithm SINGLE_COLUMN
			{
				get
				{
					return default(global::android.webkit.WebSettings.LayoutAlgorithm);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.WebSettings.LayoutAlgorithm.staticClass = @__class;
				global::android.webkit.WebSettings.LayoutAlgorithm._values10087 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "values", "()[Landroid/webkit/WebSettings/LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._valueOf10088 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$LayoutAlgorithm;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class PluginState : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static PluginState()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebSettings.PluginState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.webkit.WebSettings.PluginState(@__env);
				}
			}
			internal PluginState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values10092;
			public static global::android.webkit.WebSettings.PluginState[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.PluginState.staticClass, global::android.webkit.WebSettings.PluginState._values10092));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf10093;
			public static global::android.webkit.WebSettings.PluginState valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.PluginState>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.PluginState.staticClass, global::android.webkit.WebSettings.PluginState._valueOf10093, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _OFF10094;
			public static global::android.webkit.WebSettings.PluginState OFF
			{
				get
				{
					return default(global::android.webkit.WebSettings.PluginState);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ON10095;
			public static global::android.webkit.WebSettings.PluginState ON
			{
				get
				{
					return default(global::android.webkit.WebSettings.PluginState);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ON_DEMAND10096;
			public static global::android.webkit.WebSettings.PluginState ON_DEMAND
			{
				get
				{
					return default(global::android.webkit.WebSettings.PluginState);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.WebSettings.PluginState.staticClass = @__class;
				global::android.webkit.WebSettings.PluginState._values10092 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.PluginState.staticClass, "values", "()[Landroid/webkit/WebSettings/PluginState;");
				global::android.webkit.WebSettings.PluginState._valueOf10093 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.PluginState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$PluginState;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class RenderPriority : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static RenderPriority()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebSettings.RenderPriority), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.webkit.WebSettings.RenderPriority(@__env);
				}
			}
			internal RenderPriority(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values10097;
			public static global::android.webkit.WebSettings.RenderPriority[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._values10097));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf10098;
			public static global::android.webkit.WebSettings.RenderPriority valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.RenderPriority>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._valueOf10098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _HIGH10099;
			public static global::android.webkit.WebSettings.RenderPriority HIGH
			{
				get
				{
					return default(global::android.webkit.WebSettings.RenderPriority);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _LOW10100;
			public static global::android.webkit.WebSettings.RenderPriority LOW
			{
				get
				{
					return default(global::android.webkit.WebSettings.RenderPriority);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL10101;
			public static global::android.webkit.WebSettings.RenderPriority NORMAL
			{
				get
				{
					return default(global::android.webkit.WebSettings.RenderPriority);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.WebSettings.RenderPriority.staticClass = @__class;
				global::android.webkit.WebSettings.RenderPriority._values10097 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.RenderPriority.staticClass, "values", "()[Landroid/webkit/WebSettings/RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._valueOf10098 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.RenderPriority.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$RenderPriority;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class TextSize : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static TextSize()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebSettings.TextSize), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.webkit.WebSettings.TextSize(@__env);
				}
			}
			internal TextSize(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values10102;
			public static global::android.webkit.WebSettings.TextSize[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._values10102));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf10103;
			public static global::android.webkit.WebSettings.TextSize valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.TextSize>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._valueOf10103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _LARGER10104;
			public static global::android.webkit.WebSettings.TextSize LARGER
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _LARGEST10105;
			public static global::android.webkit.WebSettings.TextSize LARGEST
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL10106;
			public static global::android.webkit.WebSettings.TextSize NORMAL
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SMALLER10107;
			public static global::android.webkit.WebSettings.TextSize SMALLER
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SMALLEST10108;
			public static global::android.webkit.WebSettings.TextSize SMALLEST
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.WebSettings.TextSize.staticClass = @__class;
				global::android.webkit.WebSettings.TextSize._values10102 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.TextSize.staticClass, "values", "()[Landroid/webkit/WebSettings/TextSize;");
				global::android.webkit.WebSettings.TextSize._valueOf10103 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.TextSize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$TextSize;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class ZoomDensity : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static ZoomDensity()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebSettings.ZoomDensity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.webkit.WebSettings.ZoomDensity(@__env);
				}
			}
			internal ZoomDensity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values10109;
			public static global::android.webkit.WebSettings.ZoomDensity[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._values10109));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf10110;
			public static global::android.webkit.WebSettings.ZoomDensity valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.ZoomDensity>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._valueOf10110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLOSE10111;
			public static global::android.webkit.WebSettings.ZoomDensity CLOSE
			{
				get
				{
					return default(global::android.webkit.WebSettings.ZoomDensity);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _FAR10112;
			public static global::android.webkit.WebSettings.ZoomDensity FAR
			{
				get
				{
					return default(global::android.webkit.WebSettings.ZoomDensity);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _MEDIUM10113;
			public static global::android.webkit.WebSettings.ZoomDensity MEDIUM
			{
				get
				{
					return default(global::android.webkit.WebSettings.ZoomDensity);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.WebSettings.ZoomDensity.staticClass = @__class;
				global::android.webkit.WebSettings.ZoomDensity._values10109 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.ZoomDensity.staticClass, "values", "()[Landroid/webkit/WebSettings/ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._valueOf10110 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.ZoomDensity.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$ZoomDensity;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDatabasePath10114;
		public virtual global::java.lang.String getDatabasePath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getDatabasePath10114));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDatabasePath10114));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextSize10115;
		public virtual global::android.webkit.WebSettings.TextSize getTextSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.TextSize>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getTextSize10115));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.TextSize>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getTextSize10115));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextSize10116;
		public virtual void setTextSize(android.webkit.WebSettings.TextSize arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setTextSize10116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setTextSize10116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNavDump10117;
		public virtual void setNavDump(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setNavDump10117, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setNavDump10117, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNavDump10118;
		public virtual bool getNavDump() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getNavDump10118);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getNavDump10118);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSupportZoom10119;
		public virtual void setSupportZoom(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setSupportZoom10119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSupportZoom10119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _supportZoom10120;
		public virtual bool supportZoom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._supportZoom10120);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._supportZoom10120);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBuiltInZoomControls10121;
		public virtual void setBuiltInZoomControls(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setBuiltInZoomControls10121, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBuiltInZoomControls10121, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBuiltInZoomControls10122;
		public virtual bool getBuiltInZoomControls() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getBuiltInZoomControls10122);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBuiltInZoomControls10122);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAllowFileAccess10123;
		public virtual void setAllowFileAccess(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setAllowFileAccess10123, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAllowFileAccess10123, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllowFileAccess10124;
		public virtual bool getAllowFileAccess() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getAllowFileAccess10124);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getAllowFileAccess10124);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLoadWithOverviewMode10125;
		public virtual void setLoadWithOverviewMode(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setLoadWithOverviewMode10125, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLoadWithOverviewMode10125, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLoadWithOverviewMode10126;
		public virtual bool getLoadWithOverviewMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getLoadWithOverviewMode10126);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLoadWithOverviewMode10126);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSaveFormData10127;
		public virtual void setSaveFormData(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setSaveFormData10127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSaveFormData10127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSaveFormData10128;
		public virtual bool getSaveFormData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getSaveFormData10128);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSaveFormData10128);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSavePassword10129;
		public virtual void setSavePassword(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setSavePassword10129, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSavePassword10129, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSavePassword10130;
		public virtual bool getSavePassword() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getSavePassword10130);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSavePassword10130);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultZoom10131;
		public virtual void setDefaultZoom(android.webkit.WebSettings.ZoomDensity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDefaultZoom10131, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultZoom10131, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultZoom10132;
		public virtual global::android.webkit.WebSettings.ZoomDensity getDefaultZoom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.ZoomDensity>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getDefaultZoom10132));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.ZoomDensity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultZoom10132));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLightTouchEnabled10133;
		public virtual void setLightTouchEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setLightTouchEnabled10133, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLightTouchEnabled10133, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLightTouchEnabled10134;
		public virtual bool getLightTouchEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getLightTouchEnabled10134);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLightTouchEnabled10134);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUseDoubleTree10135;
		public virtual void setUseDoubleTree(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setUseDoubleTree10135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUseDoubleTree10135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUseDoubleTree10136;
		public virtual bool getUseDoubleTree() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getUseDoubleTree10136);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUseDoubleTree10136);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUserAgent10137;
		public virtual void setUserAgent(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setUserAgent10137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUserAgent10137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUserAgent10138;
		public virtual int getUserAgent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebSettings._getUserAgent10138);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUserAgent10138);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUseWideViewPort10139;
		public virtual void setUseWideViewPort(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setUseWideViewPort10139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUseWideViewPort10139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUseWideViewPort10140;
		public virtual bool getUseWideViewPort() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getUseWideViewPort10140);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUseWideViewPort10140);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSupportMultipleWindows10141;
		public virtual void setSupportMultipleWindows(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setSupportMultipleWindows10141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSupportMultipleWindows10141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _supportMultipleWindows10142;
		public virtual bool supportMultipleWindows() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._supportMultipleWindows10142);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._supportMultipleWindows10142);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutAlgorithm10143;
		public virtual void setLayoutAlgorithm(android.webkit.WebSettings.LayoutAlgorithm arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setLayoutAlgorithm10143, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLayoutAlgorithm10143, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutAlgorithm10144;
		public virtual global::android.webkit.WebSettings.LayoutAlgorithm getLayoutAlgorithm() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.LayoutAlgorithm>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getLayoutAlgorithm10144));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.LayoutAlgorithm>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLayoutAlgorithm10144));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStandardFontFamily10145;
		public virtual void setStandardFontFamily(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setStandardFontFamily10145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setStandardFontFamily10145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStandardFontFamily10146;
		public virtual global::java.lang.String getStandardFontFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getStandardFontFamily10146));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getStandardFontFamily10146));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFixedFontFamily10147;
		public virtual void setFixedFontFamily(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setFixedFontFamily10147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setFixedFontFamily10147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFixedFontFamily10148;
		public virtual global::java.lang.String getFixedFontFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getFixedFontFamily10148));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getFixedFontFamily10148));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSansSerifFontFamily10149;
		public virtual void setSansSerifFontFamily(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setSansSerifFontFamily10149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSansSerifFontFamily10149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSansSerifFontFamily10150;
		public virtual global::java.lang.String getSansSerifFontFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getSansSerifFontFamily10150));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSansSerifFontFamily10150));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSerifFontFamily10151;
		public virtual void setSerifFontFamily(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setSerifFontFamily10151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSerifFontFamily10151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSerifFontFamily10152;
		public virtual global::java.lang.String getSerifFontFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getSerifFontFamily10152));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSerifFontFamily10152));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCursiveFontFamily10153;
		public virtual void setCursiveFontFamily(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setCursiveFontFamily10153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setCursiveFontFamily10153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCursiveFontFamily10154;
		public virtual global::java.lang.String getCursiveFontFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getCursiveFontFamily10154));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getCursiveFontFamily10154));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFantasyFontFamily10155;
		public virtual void setFantasyFontFamily(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setFantasyFontFamily10155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setFantasyFontFamily10155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFantasyFontFamily10156;
		public virtual global::java.lang.String getFantasyFontFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getFantasyFontFamily10156));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getFantasyFontFamily10156));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumFontSize10157;
		public virtual void setMinimumFontSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setMinimumFontSize10157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setMinimumFontSize10157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumFontSize10158;
		public virtual int getMinimumFontSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebSettings._getMinimumFontSize10158);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getMinimumFontSize10158);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumLogicalFontSize10159;
		public virtual void setMinimumLogicalFontSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setMinimumLogicalFontSize10159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setMinimumLogicalFontSize10159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumLogicalFontSize10160;
		public virtual int getMinimumLogicalFontSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebSettings._getMinimumLogicalFontSize10160);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getMinimumLogicalFontSize10160);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultFontSize10161;
		public virtual void setDefaultFontSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDefaultFontSize10161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultFontSize10161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultFontSize10162;
		public virtual int getDefaultFontSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebSettings._getDefaultFontSize10162);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultFontSize10162);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultFixedFontSize10163;
		public virtual void setDefaultFixedFontSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDefaultFixedFontSize10163, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultFixedFontSize10163, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultFixedFontSize10164;
		public virtual int getDefaultFixedFontSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebSettings._getDefaultFixedFontSize10164);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultFixedFontSize10164);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLoadsImagesAutomatically10165;
		public virtual void setLoadsImagesAutomatically(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setLoadsImagesAutomatically10165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLoadsImagesAutomatically10165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLoadsImagesAutomatically10166;
		public virtual bool getLoadsImagesAutomatically() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getLoadsImagesAutomatically10166);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLoadsImagesAutomatically10166);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBlockNetworkImage10167;
		public virtual void setBlockNetworkImage(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setBlockNetworkImage10167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBlockNetworkImage10167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBlockNetworkImage10168;
		public virtual bool getBlockNetworkImage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getBlockNetworkImage10168);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBlockNetworkImage10168);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBlockNetworkLoads10169;
		public virtual void setBlockNetworkLoads(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setBlockNetworkLoads10169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBlockNetworkLoads10169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBlockNetworkLoads10170;
		public virtual bool getBlockNetworkLoads() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getBlockNetworkLoads10170);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBlockNetworkLoads10170);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setJavaScriptEnabled10171;
		public virtual void setJavaScriptEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setJavaScriptEnabled10171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setJavaScriptEnabled10171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPluginsEnabled10172;
		public virtual void setPluginsEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setPluginsEnabled10172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginsEnabled10172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPluginState10173;
		public virtual void setPluginState(android.webkit.WebSettings.PluginState arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setPluginState10173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginState10173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPluginsPath10174;
		public virtual void setPluginsPath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setPluginsPath10174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginsPath10174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDatabasePath10175;
		public virtual void setDatabasePath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDatabasePath10175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDatabasePath10175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGeolocationDatabasePath10176;
		public virtual void setGeolocationDatabasePath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setGeolocationDatabasePath10176, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setGeolocationDatabasePath10176, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAppCacheEnabled10177;
		public virtual void setAppCacheEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setAppCacheEnabled10177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCacheEnabled10177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAppCachePath10178;
		public virtual void setAppCachePath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setAppCachePath10178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCachePath10178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAppCacheMaxSize10179;
		public virtual void setAppCacheMaxSize(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setAppCacheMaxSize10179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCacheMaxSize10179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDatabaseEnabled10180;
		public virtual void setDatabaseEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDatabaseEnabled10180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDatabaseEnabled10180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDomStorageEnabled10181;
		public virtual void setDomStorageEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDomStorageEnabled10181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDomStorageEnabled10181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDomStorageEnabled10182;
		public virtual bool getDomStorageEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getDomStorageEnabled10182);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDomStorageEnabled10182);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDatabaseEnabled10183;
		public virtual bool getDatabaseEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getDatabaseEnabled10183);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDatabaseEnabled10183);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGeolocationEnabled10184;
		public virtual void setGeolocationEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setGeolocationEnabled10184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setGeolocationEnabled10184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getJavaScriptEnabled10185;
		public virtual bool getJavaScriptEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getJavaScriptEnabled10185);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getJavaScriptEnabled10185);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPluginsEnabled10186;
		public virtual bool getPluginsEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getPluginsEnabled10186);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginsEnabled10186);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPluginState10187;
		public virtual global::android.webkit.WebSettings.PluginState getPluginState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.PluginState>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getPluginState10187));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.PluginState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginState10187));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPluginsPath10188;
		public virtual global::java.lang.String getPluginsPath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getPluginsPath10188));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginsPath10188));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setJavaScriptCanOpenWindowsAutomatically10189;
		public virtual void setJavaScriptCanOpenWindowsAutomatically(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically10189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically10189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getJavaScriptCanOpenWindowsAutomatically10190;
		public virtual bool getJavaScriptCanOpenWindowsAutomatically() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically10190);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically10190);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultTextEncodingName10191;
		public virtual void setDefaultTextEncodingName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDefaultTextEncodingName10191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultTextEncodingName10191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultTextEncodingName10192;
		public virtual global::java.lang.String getDefaultTextEncodingName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getDefaultTextEncodingName10192));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultTextEncodingName10192));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUserAgentString10193;
		public virtual void setUserAgentString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setUserAgentString10193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUserAgentString10193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUserAgentString10194;
		public virtual global::java.lang.String getUserAgentString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getUserAgentString10194));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUserAgentString10194));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNeedInitialFocus10195;
		public virtual void setNeedInitialFocus(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setNeedInitialFocus10195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setNeedInitialFocus10195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRenderPriority10196;
		public virtual void setRenderPriority(android.webkit.WebSettings.RenderPriority arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setRenderPriority10196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setRenderPriority10196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCacheMode10197;
		public virtual void setCacheMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setCacheMode10197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setCacheMode10197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCacheMode10198;
		public virtual int getCacheMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebSettings._getCacheMode10198);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getCacheMode10198);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.WebSettings.staticClass = @__class;
			global::android.webkit.WebSettings._getDatabasePath10114 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDatabasePath", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._getTextSize10115 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getTextSize", "()Landroid/webkit/WebSettings$TextSize;");
			global::android.webkit.WebSettings._setTextSize10116 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setTextSize", "(Landroid/webkit/WebSettings$TextSize;)V");
			global::android.webkit.WebSettings._setNavDump10117 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setNavDump", "(Z)V");
			global::android.webkit.WebSettings._getNavDump10118 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getNavDump", "()Z");
			global::android.webkit.WebSettings._setSupportZoom10119 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSupportZoom", "(Z)V");
			global::android.webkit.WebSettings._supportZoom10120 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "supportZoom", "()Z");
			global::android.webkit.WebSettings._setBuiltInZoomControls10121 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setBuiltInZoomControls", "(Z)V");
			global::android.webkit.WebSettings._getBuiltInZoomControls10122 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getBuiltInZoomControls", "()Z");
			global::android.webkit.WebSettings._setAllowFileAccess10123 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setAllowFileAccess", "(Z)V");
			global::android.webkit.WebSettings._getAllowFileAccess10124 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getAllowFileAccess", "()Z");
			global::android.webkit.WebSettings._setLoadWithOverviewMode10125 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setLoadWithOverviewMode", "(Z)V");
			global::android.webkit.WebSettings._getLoadWithOverviewMode10126 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getLoadWithOverviewMode", "()Z");
			global::android.webkit.WebSettings._setSaveFormData10127 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSaveFormData", "(Z)V");
			global::android.webkit.WebSettings._getSaveFormData10128 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getSaveFormData", "()Z");
			global::android.webkit.WebSettings._setSavePassword10129 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSavePassword", "(Z)V");
			global::android.webkit.WebSettings._getSavePassword10130 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getSavePassword", "()Z");
			global::android.webkit.WebSettings._setDefaultZoom10131 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDefaultZoom", "(Landroid/webkit/WebSettings$ZoomDensity;)V");
			global::android.webkit.WebSettings._getDefaultZoom10132 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDefaultZoom", "()Landroid/webkit/WebSettings$ZoomDensity;");
			global::android.webkit.WebSettings._setLightTouchEnabled10133 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setLightTouchEnabled", "(Z)V");
			global::android.webkit.WebSettings._getLightTouchEnabled10134 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getLightTouchEnabled", "()Z");
			global::android.webkit.WebSettings._setUseDoubleTree10135 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setUseDoubleTree", "(Z)V");
			global::android.webkit.WebSettings._getUseDoubleTree10136 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getUseDoubleTree", "()Z");
			global::android.webkit.WebSettings._setUserAgent10137 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setUserAgent", "(I)V");
			global::android.webkit.WebSettings._getUserAgent10138 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getUserAgent", "()I");
			global::android.webkit.WebSettings._setUseWideViewPort10139 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setUseWideViewPort", "(Z)V");
			global::android.webkit.WebSettings._getUseWideViewPort10140 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getUseWideViewPort", "()Z");
			global::android.webkit.WebSettings._setSupportMultipleWindows10141 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSupportMultipleWindows", "(Z)V");
			global::android.webkit.WebSettings._supportMultipleWindows10142 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "supportMultipleWindows", "()Z");
			global::android.webkit.WebSettings._setLayoutAlgorithm10143 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setLayoutAlgorithm", "(Landroid/webkit/WebSettings$LayoutAlgorithm;)V");
			global::android.webkit.WebSettings._getLayoutAlgorithm10144 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getLayoutAlgorithm", "()Landroid/webkit/WebSettings$LayoutAlgorithm;");
			global::android.webkit.WebSettings._setStandardFontFamily10145 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setStandardFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getStandardFontFamily10146 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getStandardFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setFixedFontFamily10147 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setFixedFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getFixedFontFamily10148 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getFixedFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setSansSerifFontFamily10149 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSansSerifFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getSansSerifFontFamily10150 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getSansSerifFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setSerifFontFamily10151 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSerifFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getSerifFontFamily10152 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getSerifFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setCursiveFontFamily10153 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setCursiveFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getCursiveFontFamily10154 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getCursiveFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setFantasyFontFamily10155 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setFantasyFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getFantasyFontFamily10156 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getFantasyFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setMinimumFontSize10157 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setMinimumFontSize", "(I)V");
			global::android.webkit.WebSettings._getMinimumFontSize10158 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getMinimumFontSize", "()I");
			global::android.webkit.WebSettings._setMinimumLogicalFontSize10159 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setMinimumLogicalFontSize", "(I)V");
			global::android.webkit.WebSettings._getMinimumLogicalFontSize10160 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getMinimumLogicalFontSize", "()I");
			global::android.webkit.WebSettings._setDefaultFontSize10161 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDefaultFontSize", "(I)V");
			global::android.webkit.WebSettings._getDefaultFontSize10162 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDefaultFontSize", "()I");
			global::android.webkit.WebSettings._setDefaultFixedFontSize10163 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDefaultFixedFontSize", "(I)V");
			global::android.webkit.WebSettings._getDefaultFixedFontSize10164 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDefaultFixedFontSize", "()I");
			global::android.webkit.WebSettings._setLoadsImagesAutomatically10165 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setLoadsImagesAutomatically", "(Z)V");
			global::android.webkit.WebSettings._getLoadsImagesAutomatically10166 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getLoadsImagesAutomatically", "()Z");
			global::android.webkit.WebSettings._setBlockNetworkImage10167 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setBlockNetworkImage", "(Z)V");
			global::android.webkit.WebSettings._getBlockNetworkImage10168 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getBlockNetworkImage", "()Z");
			global::android.webkit.WebSettings._setBlockNetworkLoads10169 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setBlockNetworkLoads", "(Z)V");
			global::android.webkit.WebSettings._getBlockNetworkLoads10170 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getBlockNetworkLoads", "()Z");
			global::android.webkit.WebSettings._setJavaScriptEnabled10171 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setJavaScriptEnabled", "(Z)V");
			global::android.webkit.WebSettings._setPluginsEnabled10172 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setPluginsEnabled", "(Z)V");
			global::android.webkit.WebSettings._setPluginState10173 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setPluginState", "(Landroid/webkit/WebSettings$PluginState;)V");
			global::android.webkit.WebSettings._setPluginsPath10174 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setPluginsPath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setDatabasePath10175 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDatabasePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setGeolocationDatabasePath10176 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setGeolocationDatabasePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setAppCacheEnabled10177 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setAppCacheEnabled", "(Z)V");
			global::android.webkit.WebSettings._setAppCachePath10178 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setAppCachePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setAppCacheMaxSize10179 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setAppCacheMaxSize", "(J)V");
			global::android.webkit.WebSettings._setDatabaseEnabled10180 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDatabaseEnabled", "(Z)V");
			global::android.webkit.WebSettings._setDomStorageEnabled10181 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDomStorageEnabled", "(Z)V");
			global::android.webkit.WebSettings._getDomStorageEnabled10182 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDomStorageEnabled", "()Z");
			global::android.webkit.WebSettings._getDatabaseEnabled10183 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDatabaseEnabled", "()Z");
			global::android.webkit.WebSettings._setGeolocationEnabled10184 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setGeolocationEnabled", "(Z)V");
			global::android.webkit.WebSettings._getJavaScriptEnabled10185 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getJavaScriptEnabled", "()Z");
			global::android.webkit.WebSettings._getPluginsEnabled10186 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getPluginsEnabled", "()Z");
			global::android.webkit.WebSettings._getPluginState10187 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getPluginState", "()Landroid/webkit/WebSettings$PluginState;");
			global::android.webkit.WebSettings._getPluginsPath10188 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getPluginsPath", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically10189 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setJavaScriptCanOpenWindowsAutomatically", "(Z)V");
			global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically10190 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getJavaScriptCanOpenWindowsAutomatically", "()Z");
			global::android.webkit.WebSettings._setDefaultTextEncodingName10191 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDefaultTextEncodingName", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getDefaultTextEncodingName10192 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDefaultTextEncodingName", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setUserAgentString10193 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setUserAgentString", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getUserAgentString10194 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getUserAgentString", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setNeedInitialFocus10195 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setNeedInitialFocus", "(Z)V");
			global::android.webkit.WebSettings._setRenderPriority10196 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setRenderPriority", "(Landroid/webkit/WebSettings$RenderPriority;)V");
			global::android.webkit.WebSettings._setCacheMode10197 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setCacheMode", "(I)V");
			global::android.webkit.WebSettings._getCacheMode10198 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getCacheMode", "()I");
		}
	}
}
