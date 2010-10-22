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
			internal static global::MonoJavaBridge.MethodId _values16080;
			public static global::android.webkit.WebSettings.LayoutAlgorithm[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.LayoutAlgorithm>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._values16080)) as android.webkit.WebSettings.LayoutAlgorithm[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf16081;
			public static global::android.webkit.WebSettings.LayoutAlgorithm valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._valueOf16081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.LayoutAlgorithm;
			}
			internal static global::MonoJavaBridge.FieldId _NARROW_COLUMNS16082;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NARROW_COLUMNS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, _NARROW_COLUMNS16082)) as android.webkit.WebSettings.LayoutAlgorithm;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL16083;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, _NORMAL16083)) as android.webkit.WebSettings.LayoutAlgorithm;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SINGLE_COLUMN16084;
			public static global::android.webkit.WebSettings.LayoutAlgorithm SINGLE_COLUMN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, _SINGLE_COLUMN16084)) as android.webkit.WebSettings.LayoutAlgorithm;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.LayoutAlgorithm.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$LayoutAlgorithm"));
				global::android.webkit.WebSettings.LayoutAlgorithm._values16080 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "values", "()[Landroid/webkit/WebSettings/LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._valueOf16081 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._NARROW_COLUMNS16082 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "NARROW_COLUMNS", "Landroid/webkit/WebSettings$LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._NORMAL16083 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "NORMAL", "Landroid/webkit/WebSettings$LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._SINGLE_COLUMN16084 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "SINGLE_COLUMN", "Landroid/webkit/WebSettings$LayoutAlgorithm;");
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
			internal static global::MonoJavaBridge.MethodId _values16085;
			public static global::android.webkit.WebSettings.PluginState[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.PluginState>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.PluginState.staticClass, global::android.webkit.WebSettings.PluginState._values16085)) as android.webkit.WebSettings.PluginState[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf16086;
			public static global::android.webkit.WebSettings.PluginState valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.PluginState.staticClass, global::android.webkit.WebSettings.PluginState._valueOf16086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.PluginState;
			}
			internal static global::MonoJavaBridge.FieldId _OFF16087;
			public static global::android.webkit.WebSettings.PluginState OFF
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.PluginState.staticClass, _OFF16087)) as android.webkit.WebSettings.PluginState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON16088;
			public static global::android.webkit.WebSettings.PluginState ON
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.PluginState.staticClass, _ON16088)) as android.webkit.WebSettings.PluginState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_DEMAND16089;
			public static global::android.webkit.WebSettings.PluginState ON_DEMAND
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.PluginState.staticClass, _ON_DEMAND16089)) as android.webkit.WebSettings.PluginState;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.PluginState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$PluginState"));
				global::android.webkit.WebSettings.PluginState._values16085 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "values", "()[Landroid/webkit/WebSettings/PluginState;");
				global::android.webkit.WebSettings.PluginState._valueOf16086 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$PluginState;");
				global::android.webkit.WebSettings.PluginState._OFF16087 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "OFF", "Landroid/webkit/WebSettings$PluginState;");
				global::android.webkit.WebSettings.PluginState._ON16088 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "ON", "Landroid/webkit/WebSettings$PluginState;");
				global::android.webkit.WebSettings.PluginState._ON_DEMAND16089 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "ON_DEMAND", "Landroid/webkit/WebSettings$PluginState;");
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
			internal static global::MonoJavaBridge.MethodId _values16090;
			public static global::android.webkit.WebSettings.RenderPriority[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.RenderPriority>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._values16090)) as android.webkit.WebSettings.RenderPriority[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf16091;
			public static global::android.webkit.WebSettings.RenderPriority valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.RenderPriority>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._valueOf16091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.RenderPriority;
			}
			internal static global::MonoJavaBridge.FieldId _HIGH16092;
			public static global::android.webkit.WebSettings.RenderPriority HIGH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.RenderPriority>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.RenderPriority.staticClass, _HIGH16092)) as android.webkit.WebSettings.RenderPriority;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LOW16093;
			public static global::android.webkit.WebSettings.RenderPriority LOW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.RenderPriority>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.RenderPriority.staticClass, _LOW16093)) as android.webkit.WebSettings.RenderPriority;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL16094;
			public static global::android.webkit.WebSettings.RenderPriority NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.RenderPriority>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.RenderPriority.staticClass, _NORMAL16094)) as android.webkit.WebSettings.RenderPriority;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.RenderPriority.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$RenderPriority"));
				global::android.webkit.WebSettings.RenderPriority._values16090 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "values", "()[Landroid/webkit/WebSettings/RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._valueOf16091 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._HIGH16092 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "HIGH", "Landroid/webkit/WebSettings$RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._LOW16093 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "LOW", "Landroid/webkit/WebSettings$RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._NORMAL16094 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "NORMAL", "Landroid/webkit/WebSettings$RenderPriority;");
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
			internal static global::MonoJavaBridge.MethodId _values16095;
			public static global::android.webkit.WebSettings.TextSize[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.TextSize>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._values16095)) as android.webkit.WebSettings.TextSize[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf16096;
			public static global::android.webkit.WebSettings.TextSize valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._valueOf16096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.TextSize;
			}
			internal static global::MonoJavaBridge.FieldId _LARGER16097;
			public static global::android.webkit.WebSettings.TextSize LARGER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _LARGER16097)) as android.webkit.WebSettings.TextSize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LARGEST16098;
			public static global::android.webkit.WebSettings.TextSize LARGEST
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _LARGEST16098)) as android.webkit.WebSettings.TextSize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL16099;
			public static global::android.webkit.WebSettings.TextSize NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _NORMAL16099)) as android.webkit.WebSettings.TextSize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALLER16100;
			public static global::android.webkit.WebSettings.TextSize SMALLER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _SMALLER16100)) as android.webkit.WebSettings.TextSize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALLEST16101;
			public static global::android.webkit.WebSettings.TextSize SMALLEST
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _SMALLEST16101)) as android.webkit.WebSettings.TextSize;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.TextSize.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$TextSize"));
				global::android.webkit.WebSettings.TextSize._values16095 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "values", "()[Landroid/webkit/WebSettings/TextSize;");
				global::android.webkit.WebSettings.TextSize._valueOf16096 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._LARGER16097 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "LARGER", "Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._LARGEST16098 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "LARGEST", "Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._NORMAL16099 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "NORMAL", "Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._SMALLER16100 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "SMALLER", "Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._SMALLEST16101 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "SMALLEST", "Landroid/webkit/WebSettings$TextSize;");
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
			internal static global::MonoJavaBridge.MethodId _values16102;
			public static global::android.webkit.WebSettings.ZoomDensity[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.ZoomDensity>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._values16102)) as android.webkit.WebSettings.ZoomDensity[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf16103;
			public static global::android.webkit.WebSettings.ZoomDensity valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._valueOf16103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.ZoomDensity;
			}
			internal static global::MonoJavaBridge.FieldId _CLOSE16104;
			public static global::android.webkit.WebSettings.ZoomDensity CLOSE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.ZoomDensity.staticClass, _CLOSE16104)) as android.webkit.WebSettings.ZoomDensity;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FAR16105;
			public static global::android.webkit.WebSettings.ZoomDensity FAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.ZoomDensity.staticClass, _FAR16105)) as android.webkit.WebSettings.ZoomDensity;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MEDIUM16106;
			public static global::android.webkit.WebSettings.ZoomDensity MEDIUM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.ZoomDensity.staticClass, _MEDIUM16106)) as android.webkit.WebSettings.ZoomDensity;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.ZoomDensity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$ZoomDensity"));
				global::android.webkit.WebSettings.ZoomDensity._values16102 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "values", "()[Landroid/webkit/WebSettings/ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._valueOf16103 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._CLOSE16104 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "CLOSE", "Landroid/webkit/WebSettings$ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._FAR16105 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "FAR", "Landroid/webkit/WebSettings$ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._MEDIUM16106 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "MEDIUM", "Landroid/webkit/WebSettings$ZoomDensity;");
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
		internal static global::MonoJavaBridge.MethodId _getDatabasePath16107;
		public virtual global::java.lang.String getDatabasePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getDatabasePath16107)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDatabasePath16107)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTextSize16108;
		public virtual global::android.webkit.WebSettings.TextSize getTextSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getTextSize16108)) as android.webkit.WebSettings.TextSize;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getTextSize16108)) as android.webkit.WebSettings.TextSize;
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize16109;
		public virtual void setTextSize(android.webkit.WebSettings.TextSize arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setTextSize16109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setTextSize16109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNavDump16110;
		public virtual void setNavDump(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setNavDump16110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setNavDump16110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNavDump16111;
		public virtual bool getNavDump() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getNavDump16111);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getNavDump16111);
		}
		internal static global::MonoJavaBridge.MethodId _setSupportZoom16112;
		public virtual void setSupportZoom(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSupportZoom16112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSupportZoom16112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportZoom16113;
		public virtual bool supportZoom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._supportZoom16113);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._supportZoom16113);
		}
		internal static global::MonoJavaBridge.MethodId _setBuiltInZoomControls16114;
		public virtual void setBuiltInZoomControls(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setBuiltInZoomControls16114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBuiltInZoomControls16114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getBuiltInZoomControls16115;
		public virtual bool getBuiltInZoomControls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getBuiltInZoomControls16115);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBuiltInZoomControls16115);
		}
		internal static global::MonoJavaBridge.MethodId _setAllowFileAccess16116;
		public virtual void setAllowFileAccess(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setAllowFileAccess16116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAllowFileAccess16116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAllowFileAccess16117;
		public virtual bool getAllowFileAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getAllowFileAccess16117);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getAllowFileAccess16117);
		}
		internal static global::MonoJavaBridge.MethodId _setLoadWithOverviewMode16118;
		public virtual void setLoadWithOverviewMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setLoadWithOverviewMode16118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLoadWithOverviewMode16118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLoadWithOverviewMode16119;
		public virtual bool getLoadWithOverviewMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getLoadWithOverviewMode16119);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLoadWithOverviewMode16119);
		}
		internal static global::MonoJavaBridge.MethodId _setSaveFormData16120;
		public virtual void setSaveFormData(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSaveFormData16120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSaveFormData16120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSaveFormData16121;
		public virtual bool getSaveFormData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getSaveFormData16121);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSaveFormData16121);
		}
		internal static global::MonoJavaBridge.MethodId _setSavePassword16122;
		public virtual void setSavePassword(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSavePassword16122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSavePassword16122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSavePassword16123;
		public virtual bool getSavePassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getSavePassword16123);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSavePassword16123);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultZoom16124;
		public virtual void setDefaultZoom(android.webkit.WebSettings.ZoomDensity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDefaultZoom16124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultZoom16124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDefaultZoom16125;
		public virtual global::android.webkit.WebSettings.ZoomDensity getDefaultZoom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getDefaultZoom16125)) as android.webkit.WebSettings.ZoomDensity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultZoom16125)) as android.webkit.WebSettings.ZoomDensity;
		}
		internal static global::MonoJavaBridge.MethodId _setLightTouchEnabled16126;
		public virtual void setLightTouchEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setLightTouchEnabled16126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLightTouchEnabled16126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLightTouchEnabled16127;
		public virtual bool getLightTouchEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getLightTouchEnabled16127);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLightTouchEnabled16127);
		}
		internal static global::MonoJavaBridge.MethodId _setUseDoubleTree16128;
		public virtual void setUseDoubleTree(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setUseDoubleTree16128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUseDoubleTree16128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUseDoubleTree16129;
		public virtual bool getUseDoubleTree() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getUseDoubleTree16129);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUseDoubleTree16129);
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgent16130;
		public virtual void setUserAgent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setUserAgent16130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUserAgent16130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUserAgent16131;
		public virtual int getUserAgent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getUserAgent16131);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUserAgent16131);
		}
		internal static global::MonoJavaBridge.MethodId _setUseWideViewPort16132;
		public virtual void setUseWideViewPort(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setUseWideViewPort16132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUseWideViewPort16132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUseWideViewPort16133;
		public virtual bool getUseWideViewPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getUseWideViewPort16133);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUseWideViewPort16133);
		}
		internal static global::MonoJavaBridge.MethodId _setSupportMultipleWindows16134;
		public virtual void setSupportMultipleWindows(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSupportMultipleWindows16134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSupportMultipleWindows16134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportMultipleWindows16135;
		public virtual bool supportMultipleWindows() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._supportMultipleWindows16135);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._supportMultipleWindows16135);
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutAlgorithm16136;
		public virtual void setLayoutAlgorithm(android.webkit.WebSettings.LayoutAlgorithm arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setLayoutAlgorithm16136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLayoutAlgorithm16136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutAlgorithm16137;
		public virtual global::android.webkit.WebSettings.LayoutAlgorithm getLayoutAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getLayoutAlgorithm16137)) as android.webkit.WebSettings.LayoutAlgorithm;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLayoutAlgorithm16137)) as android.webkit.WebSettings.LayoutAlgorithm;
		}
		internal static global::MonoJavaBridge.MethodId _setStandardFontFamily16138;
		public virtual void setStandardFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setStandardFontFamily16138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setStandardFontFamily16138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getStandardFontFamily16139;
		public virtual global::java.lang.String getStandardFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getStandardFontFamily16139)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getStandardFontFamily16139)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFixedFontFamily16140;
		public virtual void setFixedFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setFixedFontFamily16140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setFixedFontFamily16140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFixedFontFamily16141;
		public virtual global::java.lang.String getFixedFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getFixedFontFamily16141)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getFixedFontFamily16141)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSansSerifFontFamily16142;
		public virtual void setSansSerifFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSansSerifFontFamily16142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSansSerifFontFamily16142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSansSerifFontFamily16143;
		public virtual global::java.lang.String getSansSerifFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getSansSerifFontFamily16143)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSansSerifFontFamily16143)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSerifFontFamily16144;
		public virtual void setSerifFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setSerifFontFamily16144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSerifFontFamily16144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSerifFontFamily16145;
		public virtual global::java.lang.String getSerifFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getSerifFontFamily16145)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSerifFontFamily16145)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setCursiveFontFamily16146;
		public virtual void setCursiveFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setCursiveFontFamily16146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setCursiveFontFamily16146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCursiveFontFamily16147;
		public virtual global::java.lang.String getCursiveFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getCursiveFontFamily16147)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getCursiveFontFamily16147)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFantasyFontFamily16148;
		public virtual void setFantasyFontFamily(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setFantasyFontFamily16148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setFantasyFontFamily16148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFantasyFontFamily16149;
		public virtual global::java.lang.String getFantasyFontFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getFantasyFontFamily16149)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getFantasyFontFamily16149)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumFontSize16150;
		public virtual void setMinimumFontSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setMinimumFontSize16150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setMinimumFontSize16150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMinimumFontSize16151;
		public virtual int getMinimumFontSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getMinimumFontSize16151);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getMinimumFontSize16151);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumLogicalFontSize16152;
		public virtual void setMinimumLogicalFontSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setMinimumLogicalFontSize16152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setMinimumLogicalFontSize16152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMinimumLogicalFontSize16153;
		public virtual int getMinimumLogicalFontSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getMinimumLogicalFontSize16153);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getMinimumLogicalFontSize16153);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultFontSize16154;
		public virtual void setDefaultFontSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDefaultFontSize16154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultFontSize16154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDefaultFontSize16155;
		public virtual int getDefaultFontSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getDefaultFontSize16155);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultFontSize16155);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultFixedFontSize16156;
		public virtual void setDefaultFixedFontSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDefaultFixedFontSize16156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultFixedFontSize16156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDefaultFixedFontSize16157;
		public virtual int getDefaultFixedFontSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getDefaultFixedFontSize16157);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultFixedFontSize16157);
		}
		internal static global::MonoJavaBridge.MethodId _setLoadsImagesAutomatically16158;
		public virtual void setLoadsImagesAutomatically(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setLoadsImagesAutomatically16158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLoadsImagesAutomatically16158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLoadsImagesAutomatically16159;
		public virtual bool getLoadsImagesAutomatically() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getLoadsImagesAutomatically16159);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLoadsImagesAutomatically16159);
		}
		internal static global::MonoJavaBridge.MethodId _setBlockNetworkImage16160;
		public virtual void setBlockNetworkImage(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setBlockNetworkImage16160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBlockNetworkImage16160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getBlockNetworkImage16161;
		public virtual bool getBlockNetworkImage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getBlockNetworkImage16161);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBlockNetworkImage16161);
		}
		internal static global::MonoJavaBridge.MethodId _setBlockNetworkLoads16162;
		public virtual void setBlockNetworkLoads(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setBlockNetworkLoads16162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBlockNetworkLoads16162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getBlockNetworkLoads16163;
		public virtual bool getBlockNetworkLoads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getBlockNetworkLoads16163);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBlockNetworkLoads16163);
		}
		internal static global::MonoJavaBridge.MethodId _setJavaScriptEnabled16164;
		public virtual void setJavaScriptEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setJavaScriptEnabled16164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setJavaScriptEnabled16164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPluginsEnabled16165;
		public virtual void setPluginsEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setPluginsEnabled16165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginsEnabled16165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPluginState16166;
		public virtual void setPluginState(android.webkit.WebSettings.PluginState arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setPluginState16166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginState16166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPluginsPath16167;
		public virtual void setPluginsPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setPluginsPath16167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginsPath16167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDatabasePath16168;
		public virtual void setDatabasePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDatabasePath16168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDatabasePath16168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGeolocationDatabasePath16169;
		public virtual void setGeolocationDatabasePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setGeolocationDatabasePath16169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setGeolocationDatabasePath16169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAppCacheEnabled16170;
		public virtual void setAppCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setAppCacheEnabled16170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCacheEnabled16170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAppCachePath16171;
		public virtual void setAppCachePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setAppCachePath16171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCachePath16171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAppCacheMaxSize16172;
		public virtual void setAppCacheMaxSize(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setAppCacheMaxSize16172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCacheMaxSize16172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDatabaseEnabled16173;
		public virtual void setDatabaseEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDatabaseEnabled16173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDatabaseEnabled16173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomStorageEnabled16174;
		public virtual void setDomStorageEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDomStorageEnabled16174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDomStorageEnabled16174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDomStorageEnabled16175;
		public virtual bool getDomStorageEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getDomStorageEnabled16175);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDomStorageEnabled16175);
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
		internal static global::MonoJavaBridge.MethodId _getDatabaseEnabled16176;
		public virtual bool getDatabaseEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getDatabaseEnabled16176);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDatabaseEnabled16176);
		}
		internal static global::MonoJavaBridge.MethodId _setGeolocationEnabled16177;
		public virtual void setGeolocationEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setGeolocationEnabled16177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setGeolocationEnabled16177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getJavaScriptEnabled16178;
		public virtual bool getJavaScriptEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getJavaScriptEnabled16178);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getJavaScriptEnabled16178);
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
		internal static global::MonoJavaBridge.MethodId _getPluginsEnabled16179;
		public virtual bool getPluginsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getPluginsEnabled16179);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginsEnabled16179);
		}
		internal static global::MonoJavaBridge.MethodId _getPluginState16180;
		public virtual global::android.webkit.WebSettings.PluginState getPluginState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getPluginState16180)) as android.webkit.WebSettings.PluginState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginState16180)) as android.webkit.WebSettings.PluginState;
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
		internal static global::MonoJavaBridge.MethodId _getPluginsPath16181;
		public virtual global::java.lang.String getPluginsPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getPluginsPath16181)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginsPath16181)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setJavaScriptCanOpenWindowsAutomatically16182;
		public virtual void setJavaScriptCanOpenWindowsAutomatically(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically16182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically16182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getJavaScriptCanOpenWindowsAutomatically16183;
		public virtual bool getJavaScriptCanOpenWindowsAutomatically() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically16183);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically16183);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultTextEncodingName16184;
		public virtual void setDefaultTextEncodingName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setDefaultTextEncodingName16184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultTextEncodingName16184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDefaultTextEncodingName16185;
		public virtual global::java.lang.String getDefaultTextEncodingName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getDefaultTextEncodingName16185)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultTextEncodingName16185)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgentString16186;
		public virtual void setUserAgentString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setUserAgentString16186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUserAgentString16186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUserAgentString16187;
		public virtual global::java.lang.String getUserAgentString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSettings._getUserAgentString16187)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUserAgentString16187)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNeedInitialFocus16188;
		public virtual void setNeedInitialFocus(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setNeedInitialFocus16188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setNeedInitialFocus16188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRenderPriority16189;
		public virtual void setRenderPriority(android.webkit.WebSettings.RenderPriority arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setRenderPriority16189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setRenderPriority16189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCacheMode16190;
		public virtual void setCacheMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSettings._setCacheMode16190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setCacheMode16190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCacheMode16191;
		public virtual int getCacheMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebSettings._getCacheMode16191);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getCacheMode16191);
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
			global::android.webkit.WebSettings._getDatabasePath16107 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDatabasePath", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._getTextSize16108 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getTextSize", "()Landroid/webkit/WebSettings$TextSize;");
			global::android.webkit.WebSettings._setTextSize16109 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setTextSize", "(Landroid/webkit/WebSettings$TextSize;)V");
			global::android.webkit.WebSettings._setNavDump16110 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setNavDump", "(Z)V");
			global::android.webkit.WebSettings._getNavDump16111 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getNavDump", "()Z");
			global::android.webkit.WebSettings._setSupportZoom16112 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSupportZoom", "(Z)V");
			global::android.webkit.WebSettings._supportZoom16113 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "supportZoom", "()Z");
			global::android.webkit.WebSettings._setBuiltInZoomControls16114 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setBuiltInZoomControls", "(Z)V");
			global::android.webkit.WebSettings._getBuiltInZoomControls16115 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getBuiltInZoomControls", "()Z");
			global::android.webkit.WebSettings._setAllowFileAccess16116 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAllowFileAccess", "(Z)V");
			global::android.webkit.WebSettings._getAllowFileAccess16117 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getAllowFileAccess", "()Z");
			global::android.webkit.WebSettings._setLoadWithOverviewMode16118 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLoadWithOverviewMode", "(Z)V");
			global::android.webkit.WebSettings._getLoadWithOverviewMode16119 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLoadWithOverviewMode", "()Z");
			global::android.webkit.WebSettings._setSaveFormData16120 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSaveFormData", "(Z)V");
			global::android.webkit.WebSettings._getSaveFormData16121 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSaveFormData", "()Z");
			global::android.webkit.WebSettings._setSavePassword16122 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSavePassword", "(Z)V");
			global::android.webkit.WebSettings._getSavePassword16123 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSavePassword", "()Z");
			global::android.webkit.WebSettings._setDefaultZoom16124 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultZoom", "(Landroid/webkit/WebSettings$ZoomDensity;)V");
			global::android.webkit.WebSettings._getDefaultZoom16125 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultZoom", "()Landroid/webkit/WebSettings$ZoomDensity;");
			global::android.webkit.WebSettings._setLightTouchEnabled16126 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLightTouchEnabled", "(Z)V");
			global::android.webkit.WebSettings._getLightTouchEnabled16127 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLightTouchEnabled", "()Z");
			global::android.webkit.WebSettings._setUseDoubleTree16128 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUseDoubleTree", "(Z)V");
			global::android.webkit.WebSettings._getUseDoubleTree16129 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUseDoubleTree", "()Z");
			global::android.webkit.WebSettings._setUserAgent16130 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUserAgent", "(I)V");
			global::android.webkit.WebSettings._getUserAgent16131 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUserAgent", "()I");
			global::android.webkit.WebSettings._setUseWideViewPort16132 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUseWideViewPort", "(Z)V");
			global::android.webkit.WebSettings._getUseWideViewPort16133 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUseWideViewPort", "()Z");
			global::android.webkit.WebSettings._setSupportMultipleWindows16134 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSupportMultipleWindows", "(Z)V");
			global::android.webkit.WebSettings._supportMultipleWindows16135 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "supportMultipleWindows", "()Z");
			global::android.webkit.WebSettings._setLayoutAlgorithm16136 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLayoutAlgorithm", "(Landroid/webkit/WebSettings$LayoutAlgorithm;)V");
			global::android.webkit.WebSettings._getLayoutAlgorithm16137 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLayoutAlgorithm", "()Landroid/webkit/WebSettings$LayoutAlgorithm;");
			global::android.webkit.WebSettings._setStandardFontFamily16138 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setStandardFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getStandardFontFamily16139 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getStandardFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setFixedFontFamily16140 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setFixedFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getFixedFontFamily16141 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getFixedFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setSansSerifFontFamily16142 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSansSerifFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getSansSerifFontFamily16143 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSansSerifFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setSerifFontFamily16144 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSerifFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getSerifFontFamily16145 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSerifFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setCursiveFontFamily16146 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setCursiveFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getCursiveFontFamily16147 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getCursiveFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setFantasyFontFamily16148 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setFantasyFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getFantasyFontFamily16149 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getFantasyFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setMinimumFontSize16150 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setMinimumFontSize", "(I)V");
			global::android.webkit.WebSettings._getMinimumFontSize16151 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getMinimumFontSize", "()I");
			global::android.webkit.WebSettings._setMinimumLogicalFontSize16152 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setMinimumLogicalFontSize", "(I)V");
			global::android.webkit.WebSettings._getMinimumLogicalFontSize16153 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getMinimumLogicalFontSize", "()I");
			global::android.webkit.WebSettings._setDefaultFontSize16154 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultFontSize", "(I)V");
			global::android.webkit.WebSettings._getDefaultFontSize16155 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultFontSize", "()I");
			global::android.webkit.WebSettings._setDefaultFixedFontSize16156 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultFixedFontSize", "(I)V");
			global::android.webkit.WebSettings._getDefaultFixedFontSize16157 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultFixedFontSize", "()I");
			global::android.webkit.WebSettings._setLoadsImagesAutomatically16158 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLoadsImagesAutomatically", "(Z)V");
			global::android.webkit.WebSettings._getLoadsImagesAutomatically16159 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLoadsImagesAutomatically", "()Z");
			global::android.webkit.WebSettings._setBlockNetworkImage16160 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setBlockNetworkImage", "(Z)V");
			global::android.webkit.WebSettings._getBlockNetworkImage16161 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getBlockNetworkImage", "()Z");
			global::android.webkit.WebSettings._setBlockNetworkLoads16162 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setBlockNetworkLoads", "(Z)V");
			global::android.webkit.WebSettings._getBlockNetworkLoads16163 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getBlockNetworkLoads", "()Z");
			global::android.webkit.WebSettings._setJavaScriptEnabled16164 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setJavaScriptEnabled", "(Z)V");
			global::android.webkit.WebSettings._setPluginsEnabled16165 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setPluginsEnabled", "(Z)V");
			global::android.webkit.WebSettings._setPluginState16166 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setPluginState", "(Landroid/webkit/WebSettings$PluginState;)V");
			global::android.webkit.WebSettings._setPluginsPath16167 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setPluginsPath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setDatabasePath16168 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDatabasePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setGeolocationDatabasePath16169 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setGeolocationDatabasePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setAppCacheEnabled16170 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAppCacheEnabled", "(Z)V");
			global::android.webkit.WebSettings._setAppCachePath16171 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAppCachePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setAppCacheMaxSize16172 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAppCacheMaxSize", "(J)V");
			global::android.webkit.WebSettings._setDatabaseEnabled16173 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDatabaseEnabled", "(Z)V");
			global::android.webkit.WebSettings._setDomStorageEnabled16174 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDomStorageEnabled", "(Z)V");
			global::android.webkit.WebSettings._getDomStorageEnabled16175 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDomStorageEnabled", "()Z");
			global::android.webkit.WebSettings._getDatabaseEnabled16176 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDatabaseEnabled", "()Z");
			global::android.webkit.WebSettings._setGeolocationEnabled16177 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setGeolocationEnabled", "(Z)V");
			global::android.webkit.WebSettings._getJavaScriptEnabled16178 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getJavaScriptEnabled", "()Z");
			global::android.webkit.WebSettings._getPluginsEnabled16179 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getPluginsEnabled", "()Z");
			global::android.webkit.WebSettings._getPluginState16180 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getPluginState", "()Landroid/webkit/WebSettings$PluginState;");
			global::android.webkit.WebSettings._getPluginsPath16181 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getPluginsPath", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically16182 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setJavaScriptCanOpenWindowsAutomatically", "(Z)V");
			global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically16183 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getJavaScriptCanOpenWindowsAutomatically", "()Z");
			global::android.webkit.WebSettings._setDefaultTextEncodingName16184 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultTextEncodingName", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getDefaultTextEncodingName16185 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultTextEncodingName", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setUserAgentString16186 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUserAgentString", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getUserAgentString16187 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUserAgentString", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setNeedInitialFocus16188 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setNeedInitialFocus", "(Z)V");
			global::android.webkit.WebSettings._setRenderPriority16189 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setRenderPriority", "(Landroid/webkit/WebSettings$RenderPriority;)V");
			global::android.webkit.WebSettings._setCacheMode16190 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setCacheMode", "(I)V");
			global::android.webkit.WebSettings._getCacheMode16191 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getCacheMode", "()I");
		}
	}
}
