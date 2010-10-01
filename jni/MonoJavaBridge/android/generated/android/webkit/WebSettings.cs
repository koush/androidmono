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
			internal static global::net.sf.jni4net.jni.MethodId _values9407;
			public static global::android.webkit.WebSettings.LayoutAlgorithm[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._values9407));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf9408;
			public static global::android.webkit.WebSettings.LayoutAlgorithm valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.LayoutAlgorithm>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._valueOf9408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _NARROW_COLUMNS9409;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NARROW_COLUMNS
			{
				get
				{
					return default(global::android.webkit.WebSettings.LayoutAlgorithm);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL9410;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NORMAL
			{
				get
				{
					return default(global::android.webkit.WebSettings.LayoutAlgorithm);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SINGLE_COLUMN9411;
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
				global::android.webkit.WebSettings.LayoutAlgorithm._values9407 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "values", "()[Landroid/webkit/WebSettings/LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._valueOf9408 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$LayoutAlgorithm;");
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
			internal static global::net.sf.jni4net.jni.MethodId _values9412;
			public static global::android.webkit.WebSettings.RenderPriority[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._values9412));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf9413;
			public static global::android.webkit.WebSettings.RenderPriority valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.RenderPriority>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._valueOf9413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _HIGH9414;
			public static global::android.webkit.WebSettings.RenderPriority HIGH
			{
				get
				{
					return default(global::android.webkit.WebSettings.RenderPriority);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _LOW9415;
			public static global::android.webkit.WebSettings.RenderPriority LOW
			{
				get
				{
					return default(global::android.webkit.WebSettings.RenderPriority);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL9416;
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
				global::android.webkit.WebSettings.RenderPriority._values9412 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.RenderPriority.staticClass, "values", "()[Landroid/webkit/WebSettings/RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._valueOf9413 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.RenderPriority.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$RenderPriority;");
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
			internal static global::net.sf.jni4net.jni.MethodId _values9417;
			public static global::android.webkit.WebSettings.TextSize[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._values9417));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf9418;
			public static global::android.webkit.WebSettings.TextSize valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.TextSize>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._valueOf9418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _LARGER9419;
			public static global::android.webkit.WebSettings.TextSize LARGER
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _LARGEST9420;
			public static global::android.webkit.WebSettings.TextSize LARGEST
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL9421;
			public static global::android.webkit.WebSettings.TextSize NORMAL
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SMALLER9422;
			public static global::android.webkit.WebSettings.TextSize SMALLER
			{
				get
				{
					return default(global::android.webkit.WebSettings.TextSize);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SMALLEST9423;
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
				global::android.webkit.WebSettings.TextSize._values9417 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.TextSize.staticClass, "values", "()[Landroid/webkit/WebSettings/TextSize;");
				global::android.webkit.WebSettings.TextSize._valueOf9418 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.TextSize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$TextSize;");
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
			internal static global::net.sf.jni4net.jni.MethodId _values9424;
			public static global::android.webkit.WebSettings.ZoomDensity[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._values9424));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf9425;
			public static global::android.webkit.WebSettings.ZoomDensity valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.ZoomDensity>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._valueOf9425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLOSE9426;
			public static global::android.webkit.WebSettings.ZoomDensity CLOSE
			{
				get
				{
					return default(global::android.webkit.WebSettings.ZoomDensity);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _FAR9427;
			public static global::android.webkit.WebSettings.ZoomDensity FAR
			{
				get
				{
					return default(global::android.webkit.WebSettings.ZoomDensity);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _MEDIUM9428;
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
				global::android.webkit.WebSettings.ZoomDensity._values9424 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.ZoomDensity.staticClass, "values", "()[Landroid/webkit/WebSettings/ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._valueOf9425 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.ZoomDensity.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$ZoomDensity;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDatabasePath9429;
		public virtual global::java.lang.String getDatabasePath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getDatabasePath9429));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDatabasePath9429));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextSize9430;
		public virtual global::android.webkit.WebSettings.TextSize getTextSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.TextSize>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getTextSize9430));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.TextSize>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getTextSize9430));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextSize9431;
		public virtual void setTextSize(android.webkit.WebSettings.TextSize arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setTextSize9431, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setTextSize9431, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNavDump9432;
		public virtual void setNavDump(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setNavDump9432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setNavDump9432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNavDump9433;
		public virtual bool getNavDump() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getNavDump9433);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getNavDump9433);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSupportZoom9434;
		public virtual void setSupportZoom(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setSupportZoom9434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSupportZoom9434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _supportZoom9435;
		public virtual bool supportZoom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._supportZoom9435);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._supportZoom9435);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBuiltInZoomControls9436;
		public virtual void setBuiltInZoomControls(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setBuiltInZoomControls9436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBuiltInZoomControls9436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBuiltInZoomControls9437;
		public virtual bool getBuiltInZoomControls() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getBuiltInZoomControls9437);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBuiltInZoomControls9437);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAllowFileAccess9438;
		public virtual void setAllowFileAccess(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setAllowFileAccess9438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAllowFileAccess9438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllowFileAccess9439;
		public virtual bool getAllowFileAccess() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getAllowFileAccess9439);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getAllowFileAccess9439);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLoadWithOverviewMode9440;
		public virtual void setLoadWithOverviewMode(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setLoadWithOverviewMode9440, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLoadWithOverviewMode9440, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLoadWithOverviewMode9441;
		public virtual bool getLoadWithOverviewMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getLoadWithOverviewMode9441);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLoadWithOverviewMode9441);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSaveFormData9442;
		public virtual void setSaveFormData(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setSaveFormData9442, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSaveFormData9442, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSaveFormData9443;
		public virtual bool getSaveFormData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getSaveFormData9443);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSaveFormData9443);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSavePassword9444;
		public virtual void setSavePassword(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setSavePassword9444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSavePassword9444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSavePassword9445;
		public virtual bool getSavePassword() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getSavePassword9445);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSavePassword9445);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultZoom9446;
		public virtual void setDefaultZoom(android.webkit.WebSettings.ZoomDensity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDefaultZoom9446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultZoom9446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultZoom9447;
		public virtual global::android.webkit.WebSettings.ZoomDensity getDefaultZoom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.ZoomDensity>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getDefaultZoom9447));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.ZoomDensity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultZoom9447));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLightTouchEnabled9448;
		public virtual void setLightTouchEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setLightTouchEnabled9448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLightTouchEnabled9448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLightTouchEnabled9449;
		public virtual bool getLightTouchEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getLightTouchEnabled9449);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLightTouchEnabled9449);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUseDoubleTree9450;
		public virtual void setUseDoubleTree(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setUseDoubleTree9450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUseDoubleTree9450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUseDoubleTree9451;
		public virtual bool getUseDoubleTree() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getUseDoubleTree9451);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUseDoubleTree9451);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUserAgent9452;
		public virtual void setUserAgent(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setUserAgent9452, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUserAgent9452, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUserAgent9453;
		public virtual int getUserAgent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebSettings._getUserAgent9453);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUserAgent9453);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUseWideViewPort9454;
		public virtual void setUseWideViewPort(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setUseWideViewPort9454, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUseWideViewPort9454, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUseWideViewPort9455;
		public virtual bool getUseWideViewPort() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getUseWideViewPort9455);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUseWideViewPort9455);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSupportMultipleWindows9456;
		public virtual void setSupportMultipleWindows(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setSupportMultipleWindows9456, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSupportMultipleWindows9456, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _supportMultipleWindows9457;
		public virtual bool supportMultipleWindows() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._supportMultipleWindows9457);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._supportMultipleWindows9457);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutAlgorithm9458;
		public virtual void setLayoutAlgorithm(android.webkit.WebSettings.LayoutAlgorithm arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setLayoutAlgorithm9458, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLayoutAlgorithm9458, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutAlgorithm9459;
		public virtual global::android.webkit.WebSettings.LayoutAlgorithm getLayoutAlgorithm() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.LayoutAlgorithm>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getLayoutAlgorithm9459));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.LayoutAlgorithm>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLayoutAlgorithm9459));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStandardFontFamily9460;
		public virtual void setStandardFontFamily(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setStandardFontFamily9460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setStandardFontFamily9460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStandardFontFamily9461;
		public virtual global::java.lang.String getStandardFontFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getStandardFontFamily9461));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getStandardFontFamily9461));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFixedFontFamily9462;
		public virtual void setFixedFontFamily(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setFixedFontFamily9462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setFixedFontFamily9462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFixedFontFamily9463;
		public virtual global::java.lang.String getFixedFontFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getFixedFontFamily9463));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getFixedFontFamily9463));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSansSerifFontFamily9464;
		public virtual void setSansSerifFontFamily(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setSansSerifFontFamily9464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSansSerifFontFamily9464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSansSerifFontFamily9465;
		public virtual global::java.lang.String getSansSerifFontFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getSansSerifFontFamily9465));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSansSerifFontFamily9465));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSerifFontFamily9466;
		public virtual void setSerifFontFamily(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setSerifFontFamily9466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSerifFontFamily9466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSerifFontFamily9467;
		public virtual global::java.lang.String getSerifFontFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getSerifFontFamily9467));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSerifFontFamily9467));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCursiveFontFamily9468;
		public virtual void setCursiveFontFamily(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setCursiveFontFamily9468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setCursiveFontFamily9468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCursiveFontFamily9469;
		public virtual global::java.lang.String getCursiveFontFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getCursiveFontFamily9469));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getCursiveFontFamily9469));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFantasyFontFamily9470;
		public virtual void setFantasyFontFamily(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setFantasyFontFamily9470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setFantasyFontFamily9470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFantasyFontFamily9471;
		public virtual global::java.lang.String getFantasyFontFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getFantasyFontFamily9471));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getFantasyFontFamily9471));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumFontSize9472;
		public virtual void setMinimumFontSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setMinimumFontSize9472, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setMinimumFontSize9472, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumFontSize9473;
		public virtual int getMinimumFontSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebSettings._getMinimumFontSize9473);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getMinimumFontSize9473);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumLogicalFontSize9474;
		public virtual void setMinimumLogicalFontSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setMinimumLogicalFontSize9474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setMinimumLogicalFontSize9474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumLogicalFontSize9475;
		public virtual int getMinimumLogicalFontSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebSettings._getMinimumLogicalFontSize9475);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getMinimumLogicalFontSize9475);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultFontSize9476;
		public virtual void setDefaultFontSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDefaultFontSize9476, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultFontSize9476, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultFontSize9477;
		public virtual int getDefaultFontSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebSettings._getDefaultFontSize9477);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultFontSize9477);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultFixedFontSize9478;
		public virtual void setDefaultFixedFontSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDefaultFixedFontSize9478, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultFixedFontSize9478, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultFixedFontSize9479;
		public virtual int getDefaultFixedFontSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebSettings._getDefaultFixedFontSize9479);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultFixedFontSize9479);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLoadsImagesAutomatically9480;
		public virtual void setLoadsImagesAutomatically(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setLoadsImagesAutomatically9480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLoadsImagesAutomatically9480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLoadsImagesAutomatically9481;
		public virtual bool getLoadsImagesAutomatically() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getLoadsImagesAutomatically9481);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLoadsImagesAutomatically9481);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBlockNetworkImage9482;
		public virtual void setBlockNetworkImage(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setBlockNetworkImage9482, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBlockNetworkImage9482, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBlockNetworkImage9483;
		public virtual bool getBlockNetworkImage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getBlockNetworkImage9483);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBlockNetworkImage9483);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setJavaScriptEnabled9484;
		public virtual void setJavaScriptEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setJavaScriptEnabled9484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setJavaScriptEnabled9484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPluginsEnabled9485;
		public virtual void setPluginsEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setPluginsEnabled9485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginsEnabled9485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPluginsPath9486;
		public virtual void setPluginsPath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setPluginsPath9486, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginsPath9486, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDatabasePath9487;
		public virtual void setDatabasePath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDatabasePath9487, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDatabasePath9487, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGeolocationDatabasePath9488;
		public virtual void setGeolocationDatabasePath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setGeolocationDatabasePath9488, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setGeolocationDatabasePath9488, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAppCacheEnabled9489;
		public virtual void setAppCacheEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setAppCacheEnabled9489, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCacheEnabled9489, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAppCachePath9490;
		public virtual void setAppCachePath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setAppCachePath9490, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCachePath9490, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAppCacheMaxSize9491;
		public virtual void setAppCacheMaxSize(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setAppCacheMaxSize9491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCacheMaxSize9491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDatabaseEnabled9492;
		public virtual void setDatabaseEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDatabaseEnabled9492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDatabaseEnabled9492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDomStorageEnabled9493;
		public virtual void setDomStorageEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDomStorageEnabled9493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDomStorageEnabled9493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDomStorageEnabled9494;
		public virtual bool getDomStorageEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getDomStorageEnabled9494);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDomStorageEnabled9494);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDatabaseEnabled9495;
		public virtual bool getDatabaseEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getDatabaseEnabled9495);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDatabaseEnabled9495);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGeolocationEnabled9496;
		public virtual void setGeolocationEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setGeolocationEnabled9496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setGeolocationEnabled9496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getJavaScriptEnabled9497;
		public virtual bool getJavaScriptEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getJavaScriptEnabled9497);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getJavaScriptEnabled9497);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPluginsEnabled9498;
		public virtual bool getPluginsEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getPluginsEnabled9498);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginsEnabled9498);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPluginsPath9499;
		public virtual global::java.lang.String getPluginsPath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getPluginsPath9499));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginsPath9499));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setJavaScriptCanOpenWindowsAutomatically9500;
		public virtual void setJavaScriptCanOpenWindowsAutomatically(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically9500, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically9500, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getJavaScriptCanOpenWindowsAutomatically9501;
		public virtual bool getJavaScriptCanOpenWindowsAutomatically() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically9501);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically9501);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultTextEncodingName9502;
		public virtual void setDefaultTextEncodingName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setDefaultTextEncodingName9502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultTextEncodingName9502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultTextEncodingName9503;
		public virtual global::java.lang.String getDefaultTextEncodingName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getDefaultTextEncodingName9503));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultTextEncodingName9503));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUserAgentString9504;
		public virtual void setUserAgentString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setUserAgentString9504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUserAgentString9504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUserAgentString9505;
		public virtual global::java.lang.String getUserAgentString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebSettings._getUserAgentString9505));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUserAgentString9505));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNeedInitialFocus9506;
		public virtual void setNeedInitialFocus(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setNeedInitialFocus9506, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setNeedInitialFocus9506, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRenderPriority9507;
		public virtual void setRenderPriority(android.webkit.WebSettings.RenderPriority arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setRenderPriority9507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setRenderPriority9507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCacheMode9508;
		public virtual void setCacheMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSettings._setCacheMode9508, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setCacheMode9508, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCacheMode9509;
		public virtual int getCacheMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebSettings._getCacheMode9509);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getCacheMode9509);
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
			global::android.webkit.WebSettings._getDatabasePath9429 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDatabasePath", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._getTextSize9430 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getTextSize", "()Landroid/webkit/WebSettings$TextSize;");
			global::android.webkit.WebSettings._setTextSize9431 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setTextSize", "(Landroid/webkit/WebSettings$TextSize;)V");
			global::android.webkit.WebSettings._setNavDump9432 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setNavDump", "(Z)V");
			global::android.webkit.WebSettings._getNavDump9433 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getNavDump", "()Z");
			global::android.webkit.WebSettings._setSupportZoom9434 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSupportZoom", "(Z)V");
			global::android.webkit.WebSettings._supportZoom9435 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "supportZoom", "()Z");
			global::android.webkit.WebSettings._setBuiltInZoomControls9436 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setBuiltInZoomControls", "(Z)V");
			global::android.webkit.WebSettings._getBuiltInZoomControls9437 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getBuiltInZoomControls", "()Z");
			global::android.webkit.WebSettings._setAllowFileAccess9438 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setAllowFileAccess", "(Z)V");
			global::android.webkit.WebSettings._getAllowFileAccess9439 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getAllowFileAccess", "()Z");
			global::android.webkit.WebSettings._setLoadWithOverviewMode9440 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setLoadWithOverviewMode", "(Z)V");
			global::android.webkit.WebSettings._getLoadWithOverviewMode9441 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getLoadWithOverviewMode", "()Z");
			global::android.webkit.WebSettings._setSaveFormData9442 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSaveFormData", "(Z)V");
			global::android.webkit.WebSettings._getSaveFormData9443 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getSaveFormData", "()Z");
			global::android.webkit.WebSettings._setSavePassword9444 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSavePassword", "(Z)V");
			global::android.webkit.WebSettings._getSavePassword9445 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getSavePassword", "()Z");
			global::android.webkit.WebSettings._setDefaultZoom9446 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDefaultZoom", "(Landroid/webkit/WebSettings$ZoomDensity;)V");
			global::android.webkit.WebSettings._getDefaultZoom9447 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDefaultZoom", "()Landroid/webkit/WebSettings$ZoomDensity;");
			global::android.webkit.WebSettings._setLightTouchEnabled9448 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setLightTouchEnabled", "(Z)V");
			global::android.webkit.WebSettings._getLightTouchEnabled9449 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getLightTouchEnabled", "()Z");
			global::android.webkit.WebSettings._setUseDoubleTree9450 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setUseDoubleTree", "(Z)V");
			global::android.webkit.WebSettings._getUseDoubleTree9451 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getUseDoubleTree", "()Z");
			global::android.webkit.WebSettings._setUserAgent9452 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setUserAgent", "(I)V");
			global::android.webkit.WebSettings._getUserAgent9453 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getUserAgent", "()I");
			global::android.webkit.WebSettings._setUseWideViewPort9454 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setUseWideViewPort", "(Z)V");
			global::android.webkit.WebSettings._getUseWideViewPort9455 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getUseWideViewPort", "()Z");
			global::android.webkit.WebSettings._setSupportMultipleWindows9456 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSupportMultipleWindows", "(Z)V");
			global::android.webkit.WebSettings._supportMultipleWindows9457 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "supportMultipleWindows", "()Z");
			global::android.webkit.WebSettings._setLayoutAlgorithm9458 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setLayoutAlgorithm", "(Landroid/webkit/WebSettings$LayoutAlgorithm;)V");
			global::android.webkit.WebSettings._getLayoutAlgorithm9459 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getLayoutAlgorithm", "()Landroid/webkit/WebSettings$LayoutAlgorithm;");
			global::android.webkit.WebSettings._setStandardFontFamily9460 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setStandardFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getStandardFontFamily9461 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getStandardFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setFixedFontFamily9462 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setFixedFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getFixedFontFamily9463 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getFixedFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setSansSerifFontFamily9464 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSansSerifFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getSansSerifFontFamily9465 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getSansSerifFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setSerifFontFamily9466 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSerifFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getSerifFontFamily9467 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getSerifFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setCursiveFontFamily9468 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setCursiveFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getCursiveFontFamily9469 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getCursiveFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setFantasyFontFamily9470 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setFantasyFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getFantasyFontFamily9471 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getFantasyFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setMinimumFontSize9472 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setMinimumFontSize", "(I)V");
			global::android.webkit.WebSettings._getMinimumFontSize9473 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getMinimumFontSize", "()I");
			global::android.webkit.WebSettings._setMinimumLogicalFontSize9474 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setMinimumLogicalFontSize", "(I)V");
			global::android.webkit.WebSettings._getMinimumLogicalFontSize9475 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getMinimumLogicalFontSize", "()I");
			global::android.webkit.WebSettings._setDefaultFontSize9476 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDefaultFontSize", "(I)V");
			global::android.webkit.WebSettings._getDefaultFontSize9477 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDefaultFontSize", "()I");
			global::android.webkit.WebSettings._setDefaultFixedFontSize9478 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDefaultFixedFontSize", "(I)V");
			global::android.webkit.WebSettings._getDefaultFixedFontSize9479 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDefaultFixedFontSize", "()I");
			global::android.webkit.WebSettings._setLoadsImagesAutomatically9480 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setLoadsImagesAutomatically", "(Z)V");
			global::android.webkit.WebSettings._getLoadsImagesAutomatically9481 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getLoadsImagesAutomatically", "()Z");
			global::android.webkit.WebSettings._setBlockNetworkImage9482 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setBlockNetworkImage", "(Z)V");
			global::android.webkit.WebSettings._getBlockNetworkImage9483 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getBlockNetworkImage", "()Z");
			global::android.webkit.WebSettings._setJavaScriptEnabled9484 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setJavaScriptEnabled", "(Z)V");
			global::android.webkit.WebSettings._setPluginsEnabled9485 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setPluginsEnabled", "(Z)V");
			global::android.webkit.WebSettings._setPluginsPath9486 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setPluginsPath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setDatabasePath9487 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDatabasePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setGeolocationDatabasePath9488 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setGeolocationDatabasePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setAppCacheEnabled9489 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setAppCacheEnabled", "(Z)V");
			global::android.webkit.WebSettings._setAppCachePath9490 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setAppCachePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setAppCacheMaxSize9491 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setAppCacheMaxSize", "(J)V");
			global::android.webkit.WebSettings._setDatabaseEnabled9492 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDatabaseEnabled", "(Z)V");
			global::android.webkit.WebSettings._setDomStorageEnabled9493 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDomStorageEnabled", "(Z)V");
			global::android.webkit.WebSettings._getDomStorageEnabled9494 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDomStorageEnabled", "()Z");
			global::android.webkit.WebSettings._getDatabaseEnabled9495 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDatabaseEnabled", "()Z");
			global::android.webkit.WebSettings._setGeolocationEnabled9496 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setGeolocationEnabled", "(Z)V");
			global::android.webkit.WebSettings._getJavaScriptEnabled9497 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getJavaScriptEnabled", "()Z");
			global::android.webkit.WebSettings._getPluginsEnabled9498 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getPluginsEnabled", "()Z");
			global::android.webkit.WebSettings._getPluginsPath9499 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getPluginsPath", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically9500 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setJavaScriptCanOpenWindowsAutomatically", "(Z)V");
			global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically9501 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getJavaScriptCanOpenWindowsAutomatically", "()Z");
			global::android.webkit.WebSettings._setDefaultTextEncodingName9502 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDefaultTextEncodingName", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getDefaultTextEncodingName9503 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDefaultTextEncodingName", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setUserAgentString9504 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setUserAgentString", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getUserAgentString9505 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getUserAgentString", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setNeedInitialFocus9506 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setNeedInitialFocus", "(Z)V");
			global::android.webkit.WebSettings._setRenderPriority9507 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setRenderPriority", "(Landroid/webkit/WebSettings$RenderPriority;)V");
			global::android.webkit.WebSettings._setCacheMode9508 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setCacheMode", "(I)V");
			global::android.webkit.WebSettings._getCacheMode9509 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getCacheMode", "()I");
		}
	}
}
