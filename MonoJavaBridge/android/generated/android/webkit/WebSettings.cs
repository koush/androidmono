namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebSettings : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WebSettings(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class LayoutAlgorithm : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal LayoutAlgorithm(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values16169;
			public static global::android.webkit.WebSettings.LayoutAlgorithm[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.LayoutAlgorithm>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._values16169)) as android.webkit.WebSettings.LayoutAlgorithm[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf16170;
			public static global::android.webkit.WebSettings.LayoutAlgorithm valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._valueOf16170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.LayoutAlgorithm;
			}
			internal static global::MonoJavaBridge.FieldId _NARROW_COLUMNS16171;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NARROW_COLUMNS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, _NARROW_COLUMNS16171)) as android.webkit.WebSettings.LayoutAlgorithm;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL16172;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, _NORMAL16172)) as android.webkit.WebSettings.LayoutAlgorithm;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SINGLE_COLUMN16173;
			public static global::android.webkit.WebSettings.LayoutAlgorithm SINGLE_COLUMN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, _SINGLE_COLUMN16173)) as android.webkit.WebSettings.LayoutAlgorithm;
				}
			}
			static LayoutAlgorithm()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.LayoutAlgorithm.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$LayoutAlgorithm"));
				global::android.webkit.WebSettings.LayoutAlgorithm._values16169 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "values", "()[Landroid/webkit/WebSettings/LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._valueOf16170 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._NARROW_COLUMNS16171 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "NARROW_COLUMNS", "Landroid/webkit/WebSettings$LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._NORMAL16172 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "NORMAL", "Landroid/webkit/WebSettings$LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._SINGLE_COLUMN16173 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "SINGLE_COLUMN", "Landroid/webkit/WebSettings$LayoutAlgorithm;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class PluginState : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PluginState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values16174;
			public static global::android.webkit.WebSettings.PluginState[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.PluginState>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.PluginState.staticClass, global::android.webkit.WebSettings.PluginState._values16174)) as android.webkit.WebSettings.PluginState[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf16175;
			public static global::android.webkit.WebSettings.PluginState valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.PluginState.staticClass, global::android.webkit.WebSettings.PluginState._valueOf16175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.PluginState;
			}
			internal static global::MonoJavaBridge.FieldId _OFF16176;
			public static global::android.webkit.WebSettings.PluginState OFF
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.PluginState.staticClass, _OFF16176)) as android.webkit.WebSettings.PluginState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON16177;
			public static global::android.webkit.WebSettings.PluginState ON
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.PluginState.staticClass, _ON16177)) as android.webkit.WebSettings.PluginState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_DEMAND16178;
			public static global::android.webkit.WebSettings.PluginState ON_DEMAND
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.PluginState.staticClass, _ON_DEMAND16178)) as android.webkit.WebSettings.PluginState;
				}
			}
			static PluginState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.PluginState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$PluginState"));
				global::android.webkit.WebSettings.PluginState._values16174 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "values", "()[Landroid/webkit/WebSettings/PluginState;");
				global::android.webkit.WebSettings.PluginState._valueOf16175 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$PluginState;");
				global::android.webkit.WebSettings.PluginState._OFF16176 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "OFF", "Landroid/webkit/WebSettings$PluginState;");
				global::android.webkit.WebSettings.PluginState._ON16177 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "ON", "Landroid/webkit/WebSettings$PluginState;");
				global::android.webkit.WebSettings.PluginState._ON_DEMAND16178 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "ON_DEMAND", "Landroid/webkit/WebSettings$PluginState;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class RenderPriority : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal RenderPriority(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values16179;
			public static global::android.webkit.WebSettings.RenderPriority[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.RenderPriority>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._values16179)) as android.webkit.WebSettings.RenderPriority[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf16180;
			public static global::android.webkit.WebSettings.RenderPriority valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.RenderPriority>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._valueOf16180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.RenderPriority;
			}
			internal static global::MonoJavaBridge.FieldId _HIGH16181;
			public static global::android.webkit.WebSettings.RenderPriority HIGH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.RenderPriority>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.RenderPriority.staticClass, _HIGH16181)) as android.webkit.WebSettings.RenderPriority;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LOW16182;
			public static global::android.webkit.WebSettings.RenderPriority LOW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.RenderPriority>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.RenderPriority.staticClass, _LOW16182)) as android.webkit.WebSettings.RenderPriority;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL16183;
			public static global::android.webkit.WebSettings.RenderPriority NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.RenderPriority>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.RenderPriority.staticClass, _NORMAL16183)) as android.webkit.WebSettings.RenderPriority;
				}
			}
			static RenderPriority()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.RenderPriority.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$RenderPriority"));
				global::android.webkit.WebSettings.RenderPriority._values16179 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "values", "()[Landroid/webkit/WebSettings/RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._valueOf16180 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._HIGH16181 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "HIGH", "Landroid/webkit/WebSettings$RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._LOW16182 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "LOW", "Landroid/webkit/WebSettings$RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._NORMAL16183 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "NORMAL", "Landroid/webkit/WebSettings$RenderPriority;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class TextSize : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal TextSize(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values16184;
			public static global::android.webkit.WebSettings.TextSize[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.TextSize>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._values16184)) as android.webkit.WebSettings.TextSize[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf16185;
			public static global::android.webkit.WebSettings.TextSize valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._valueOf16185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.TextSize;
			}
			internal static global::MonoJavaBridge.FieldId _LARGER16186;
			public static global::android.webkit.WebSettings.TextSize LARGER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _LARGER16186)) as android.webkit.WebSettings.TextSize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LARGEST16187;
			public static global::android.webkit.WebSettings.TextSize LARGEST
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _LARGEST16187)) as android.webkit.WebSettings.TextSize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL16188;
			public static global::android.webkit.WebSettings.TextSize NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _NORMAL16188)) as android.webkit.WebSettings.TextSize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALLER16189;
			public static global::android.webkit.WebSettings.TextSize SMALLER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _SMALLER16189)) as android.webkit.WebSettings.TextSize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALLEST16190;
			public static global::android.webkit.WebSettings.TextSize SMALLEST
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _SMALLEST16190)) as android.webkit.WebSettings.TextSize;
				}
			}
			static TextSize()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.TextSize.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$TextSize"));
				global::android.webkit.WebSettings.TextSize._values16184 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "values", "()[Landroid/webkit/WebSettings/TextSize;");
				global::android.webkit.WebSettings.TextSize._valueOf16185 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._LARGER16186 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "LARGER", "Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._LARGEST16187 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "LARGEST", "Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._NORMAL16188 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "NORMAL", "Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._SMALLER16189 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "SMALLER", "Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._SMALLEST16190 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "SMALLEST", "Landroid/webkit/WebSettings$TextSize;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class ZoomDensity : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ZoomDensity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values16191;
			public static global::android.webkit.WebSettings.ZoomDensity[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.ZoomDensity>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._values16191)) as android.webkit.WebSettings.ZoomDensity[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf16192;
			public static global::android.webkit.WebSettings.ZoomDensity valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._valueOf16192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.ZoomDensity;
			}
			internal static global::MonoJavaBridge.FieldId _CLOSE16193;
			public static global::android.webkit.WebSettings.ZoomDensity CLOSE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.ZoomDensity.staticClass, _CLOSE16193)) as android.webkit.WebSettings.ZoomDensity;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FAR16194;
			public static global::android.webkit.WebSettings.ZoomDensity FAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.ZoomDensity.staticClass, _FAR16194)) as android.webkit.WebSettings.ZoomDensity;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MEDIUM16195;
			public static global::android.webkit.WebSettings.ZoomDensity MEDIUM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.ZoomDensity.staticClass, _MEDIUM16195)) as android.webkit.WebSettings.ZoomDensity;
				}
			}
			static ZoomDensity()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.ZoomDensity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$ZoomDensity"));
				global::android.webkit.WebSettings.ZoomDensity._values16191 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "values", "()[Landroid/webkit/WebSettings/ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._valueOf16192 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._CLOSE16193 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "CLOSE", "Landroid/webkit/WebSettings$ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._FAR16194 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "FAR", "Landroid/webkit/WebSettings$ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._MEDIUM16195 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "MEDIUM", "Landroid/webkit/WebSettings$ZoomDensity;");
			}
			internal static void InitJNI()
			{
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
		internal static global::MonoJavaBridge.MethodId _getDatabasePath16196;
		public virtual global::java.lang.String getDatabasePath()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDatabasePath16196)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTextSize16197;
		public virtual global::android.webkit.WebSettings.TextSize getTextSize()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getTextSize16197)) as android.webkit.WebSettings.TextSize;
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize16198;
		public virtual void setTextSize(android.webkit.WebSettings.TextSize arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setTextSize16198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNavDump16199;
		public virtual void setNavDump(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setNavDump16199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNavDump16200;
		public virtual bool getNavDump()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getNavDump16200);
		}
		internal static global::MonoJavaBridge.MethodId _setSupportZoom16201;
		public virtual void setSupportZoom(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSupportZoom16201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportZoom16202;
		public virtual bool supportZoom()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._supportZoom16202);
		}
		internal static global::MonoJavaBridge.MethodId _setBuiltInZoomControls16203;
		public virtual void setBuiltInZoomControls(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBuiltInZoomControls16203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getBuiltInZoomControls16204;
		public virtual bool getBuiltInZoomControls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBuiltInZoomControls16204);
		}
		internal static global::MonoJavaBridge.MethodId _setAllowFileAccess16205;
		public virtual void setAllowFileAccess(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAllowFileAccess16205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAllowFileAccess16206;
		public virtual bool getAllowFileAccess()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getAllowFileAccess16206);
		}
		internal static global::MonoJavaBridge.MethodId _setLoadWithOverviewMode16207;
		public virtual void setLoadWithOverviewMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLoadWithOverviewMode16207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLoadWithOverviewMode16208;
		public virtual bool getLoadWithOverviewMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLoadWithOverviewMode16208);
		}
		internal static global::MonoJavaBridge.MethodId _setSaveFormData16209;
		public virtual void setSaveFormData(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSaveFormData16209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSaveFormData16210;
		public virtual bool getSaveFormData()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSaveFormData16210);
		}
		internal static global::MonoJavaBridge.MethodId _setSavePassword16211;
		public virtual void setSavePassword(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSavePassword16211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSavePassword16212;
		public virtual bool getSavePassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSavePassword16212);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultZoom16213;
		public virtual void setDefaultZoom(android.webkit.WebSettings.ZoomDensity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultZoom16213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDefaultZoom16214;
		public virtual global::android.webkit.WebSettings.ZoomDensity getDefaultZoom()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultZoom16214)) as android.webkit.WebSettings.ZoomDensity;
		}
		internal static global::MonoJavaBridge.MethodId _setLightTouchEnabled16215;
		public virtual void setLightTouchEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLightTouchEnabled16215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLightTouchEnabled16216;
		public virtual bool getLightTouchEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLightTouchEnabled16216);
		}
		internal static global::MonoJavaBridge.MethodId _setUseDoubleTree16217;
		public virtual void setUseDoubleTree(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUseDoubleTree16217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUseDoubleTree16218;
		public virtual bool getUseDoubleTree()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUseDoubleTree16218);
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgent16219;
		public virtual void setUserAgent(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUserAgent16219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUserAgent16220;
		public virtual int getUserAgent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUserAgent16220);
		}
		internal static global::MonoJavaBridge.MethodId _setUseWideViewPort16221;
		public virtual void setUseWideViewPort(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUseWideViewPort16221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUseWideViewPort16222;
		public virtual bool getUseWideViewPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUseWideViewPort16222);
		}
		internal static global::MonoJavaBridge.MethodId _setSupportMultipleWindows16223;
		public virtual void setSupportMultipleWindows(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSupportMultipleWindows16223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportMultipleWindows16224;
		public virtual bool supportMultipleWindows()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._supportMultipleWindows16224);
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutAlgorithm16225;
		public virtual void setLayoutAlgorithm(android.webkit.WebSettings.LayoutAlgorithm arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLayoutAlgorithm16225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutAlgorithm16226;
		public virtual global::android.webkit.WebSettings.LayoutAlgorithm getLayoutAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLayoutAlgorithm16226)) as android.webkit.WebSettings.LayoutAlgorithm;
		}
		internal static global::MonoJavaBridge.MethodId _setStandardFontFamily16227;
		public virtual void setStandardFontFamily(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setStandardFontFamily16227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getStandardFontFamily16228;
		public virtual global::java.lang.String getStandardFontFamily()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getStandardFontFamily16228)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFixedFontFamily16229;
		public virtual void setFixedFontFamily(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setFixedFontFamily16229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFixedFontFamily16230;
		public virtual global::java.lang.String getFixedFontFamily()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getFixedFontFamily16230)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSansSerifFontFamily16231;
		public virtual void setSansSerifFontFamily(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSansSerifFontFamily16231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSansSerifFontFamily16232;
		public virtual global::java.lang.String getSansSerifFontFamily()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSansSerifFontFamily16232)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSerifFontFamily16233;
		public virtual void setSerifFontFamily(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setSerifFontFamily16233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSerifFontFamily16234;
		public virtual global::java.lang.String getSerifFontFamily()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getSerifFontFamily16234)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setCursiveFontFamily16235;
		public virtual void setCursiveFontFamily(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setCursiveFontFamily16235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCursiveFontFamily16236;
		public virtual global::java.lang.String getCursiveFontFamily()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getCursiveFontFamily16236)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFantasyFontFamily16237;
		public virtual void setFantasyFontFamily(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setFantasyFontFamily16237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFantasyFontFamily16238;
		public virtual global::java.lang.String getFantasyFontFamily()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getFantasyFontFamily16238)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumFontSize16239;
		public virtual void setMinimumFontSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setMinimumFontSize16239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMinimumFontSize16240;
		public virtual int getMinimumFontSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getMinimumFontSize16240);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumLogicalFontSize16241;
		public virtual void setMinimumLogicalFontSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setMinimumLogicalFontSize16241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMinimumLogicalFontSize16242;
		public virtual int getMinimumLogicalFontSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getMinimumLogicalFontSize16242);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultFontSize16243;
		public virtual void setDefaultFontSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultFontSize16243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDefaultFontSize16244;
		public virtual int getDefaultFontSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultFontSize16244);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultFixedFontSize16245;
		public virtual void setDefaultFixedFontSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultFixedFontSize16245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDefaultFixedFontSize16246;
		public virtual int getDefaultFixedFontSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultFixedFontSize16246);
		}
		internal static global::MonoJavaBridge.MethodId _setLoadsImagesAutomatically16247;
		public virtual void setLoadsImagesAutomatically(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setLoadsImagesAutomatically16247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLoadsImagesAutomatically16248;
		public virtual bool getLoadsImagesAutomatically()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getLoadsImagesAutomatically16248);
		}
		internal static global::MonoJavaBridge.MethodId _setBlockNetworkImage16249;
		public virtual void setBlockNetworkImage(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBlockNetworkImage16249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getBlockNetworkImage16250;
		public virtual bool getBlockNetworkImage()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBlockNetworkImage16250);
		}
		internal static global::MonoJavaBridge.MethodId _setBlockNetworkLoads16251;
		public virtual void setBlockNetworkLoads(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setBlockNetworkLoads16251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getBlockNetworkLoads16252;
		public virtual bool getBlockNetworkLoads()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getBlockNetworkLoads16252);
		}
		internal static global::MonoJavaBridge.MethodId _setJavaScriptEnabled16253;
		public virtual void setJavaScriptEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setJavaScriptEnabled16253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPluginsEnabled16254;
		public virtual void setPluginsEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginsEnabled16254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPluginState16255;
		public virtual void setPluginState(android.webkit.WebSettings.PluginState arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginState16255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPluginsPath16256;
		public virtual void setPluginsPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setPluginsPath16256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDatabasePath16257;
		public virtual void setDatabasePath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDatabasePath16257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String GeolocationDatabasePath
		{
			set
			{
				setGeolocationDatabasePath(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGeolocationDatabasePath16258;
		public virtual void setGeolocationDatabasePath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setGeolocationDatabasePath16258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool AppCacheEnabled
		{
			set
			{
				setAppCacheEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAppCacheEnabled16259;
		public virtual void setAppCacheEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCacheEnabled16259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String AppCachePath
		{
			set
			{
				setAppCachePath(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAppCachePath16260;
		public virtual void setAppCachePath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCachePath16260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long AppCacheMaxSize
		{
			set
			{
				setAppCacheMaxSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAppCacheMaxSize16261;
		public virtual void setAppCacheMaxSize(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setAppCacheMaxSize16261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDatabaseEnabled16262;
		public virtual void setDatabaseEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDatabaseEnabled16262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomStorageEnabled16263;
		public virtual void setDomStorageEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDomStorageEnabled16263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDomStorageEnabled16264;
		public virtual bool getDomStorageEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDomStorageEnabled16264);
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
		internal static global::MonoJavaBridge.MethodId _getDatabaseEnabled16265;
		public virtual bool getDatabaseEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDatabaseEnabled16265);
		}
		public new bool GeolocationEnabled
		{
			set
			{
				setGeolocationEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGeolocationEnabled16266;
		public virtual void setGeolocationEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setGeolocationEnabled16266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getJavaScriptEnabled16267;
		public virtual bool getJavaScriptEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getJavaScriptEnabled16267);
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
		internal static global::MonoJavaBridge.MethodId _getPluginsEnabled16268;
		public virtual bool getPluginsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginsEnabled16268);
		}
		internal static global::MonoJavaBridge.MethodId _getPluginState16269;
		public virtual global::android.webkit.WebSettings.PluginState getPluginState()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginState16269)) as android.webkit.WebSettings.PluginState;
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
		internal static global::MonoJavaBridge.MethodId _getPluginsPath16270;
		public virtual global::java.lang.String getPluginsPath()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getPluginsPath16270)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setJavaScriptCanOpenWindowsAutomatically16271;
		public virtual void setJavaScriptCanOpenWindowsAutomatically(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically16271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getJavaScriptCanOpenWindowsAutomatically16272;
		public virtual bool getJavaScriptCanOpenWindowsAutomatically()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically16272);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultTextEncodingName16273;
		public virtual void setDefaultTextEncodingName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setDefaultTextEncodingName16273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDefaultTextEncodingName16274;
		public virtual global::java.lang.String getDefaultTextEncodingName()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getDefaultTextEncodingName16274)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgentString16275;
		public virtual void setUserAgentString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setUserAgentString16275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUserAgentString16276;
		public virtual global::java.lang.String getUserAgentString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getUserAgentString16276)) as java.lang.String;
		}
		public new bool NeedInitialFocus
		{
			set
			{
				setNeedInitialFocus(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setNeedInitialFocus16277;
		public virtual void setNeedInitialFocus(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setNeedInitialFocus16277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRenderPriority16278;
		public virtual void setRenderPriority(android.webkit.WebSettings.RenderPriority arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setRenderPriority16278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCacheMode16279;
		public virtual void setCacheMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._setCacheMode16279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCacheMode16280;
		public virtual int getCacheMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebSettings.staticClass, global::android.webkit.WebSettings._getCacheMode16280);
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
		static WebSettings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebSettings.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings"));
			global::android.webkit.WebSettings._getDatabasePath16196 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDatabasePath", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._getTextSize16197 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getTextSize", "()Landroid/webkit/WebSettings$TextSize;");
			global::android.webkit.WebSettings._setTextSize16198 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setTextSize", "(Landroid/webkit/WebSettings$TextSize;)V");
			global::android.webkit.WebSettings._setNavDump16199 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setNavDump", "(Z)V");
			global::android.webkit.WebSettings._getNavDump16200 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getNavDump", "()Z");
			global::android.webkit.WebSettings._setSupportZoom16201 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSupportZoom", "(Z)V");
			global::android.webkit.WebSettings._supportZoom16202 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "supportZoom", "()Z");
			global::android.webkit.WebSettings._setBuiltInZoomControls16203 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setBuiltInZoomControls", "(Z)V");
			global::android.webkit.WebSettings._getBuiltInZoomControls16204 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getBuiltInZoomControls", "()Z");
			global::android.webkit.WebSettings._setAllowFileAccess16205 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAllowFileAccess", "(Z)V");
			global::android.webkit.WebSettings._getAllowFileAccess16206 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getAllowFileAccess", "()Z");
			global::android.webkit.WebSettings._setLoadWithOverviewMode16207 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLoadWithOverviewMode", "(Z)V");
			global::android.webkit.WebSettings._getLoadWithOverviewMode16208 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLoadWithOverviewMode", "()Z");
			global::android.webkit.WebSettings._setSaveFormData16209 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSaveFormData", "(Z)V");
			global::android.webkit.WebSettings._getSaveFormData16210 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSaveFormData", "()Z");
			global::android.webkit.WebSettings._setSavePassword16211 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSavePassword", "(Z)V");
			global::android.webkit.WebSettings._getSavePassword16212 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSavePassword", "()Z");
			global::android.webkit.WebSettings._setDefaultZoom16213 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultZoom", "(Landroid/webkit/WebSettings$ZoomDensity;)V");
			global::android.webkit.WebSettings._getDefaultZoom16214 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultZoom", "()Landroid/webkit/WebSettings$ZoomDensity;");
			global::android.webkit.WebSettings._setLightTouchEnabled16215 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLightTouchEnabled", "(Z)V");
			global::android.webkit.WebSettings._getLightTouchEnabled16216 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLightTouchEnabled", "()Z");
			global::android.webkit.WebSettings._setUseDoubleTree16217 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUseDoubleTree", "(Z)V");
			global::android.webkit.WebSettings._getUseDoubleTree16218 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUseDoubleTree", "()Z");
			global::android.webkit.WebSettings._setUserAgent16219 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUserAgent", "(I)V");
			global::android.webkit.WebSettings._getUserAgent16220 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUserAgent", "()I");
			global::android.webkit.WebSettings._setUseWideViewPort16221 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUseWideViewPort", "(Z)V");
			global::android.webkit.WebSettings._getUseWideViewPort16222 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUseWideViewPort", "()Z");
			global::android.webkit.WebSettings._setSupportMultipleWindows16223 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSupportMultipleWindows", "(Z)V");
			global::android.webkit.WebSettings._supportMultipleWindows16224 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "supportMultipleWindows", "()Z");
			global::android.webkit.WebSettings._setLayoutAlgorithm16225 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLayoutAlgorithm", "(Landroid/webkit/WebSettings$LayoutAlgorithm;)V");
			global::android.webkit.WebSettings._getLayoutAlgorithm16226 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLayoutAlgorithm", "()Landroid/webkit/WebSettings$LayoutAlgorithm;");
			global::android.webkit.WebSettings._setStandardFontFamily16227 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setStandardFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getStandardFontFamily16228 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getStandardFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setFixedFontFamily16229 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setFixedFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getFixedFontFamily16230 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getFixedFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setSansSerifFontFamily16231 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSansSerifFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getSansSerifFontFamily16232 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSansSerifFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setSerifFontFamily16233 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setSerifFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getSerifFontFamily16234 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getSerifFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setCursiveFontFamily16235 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setCursiveFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getCursiveFontFamily16236 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getCursiveFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setFantasyFontFamily16237 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setFantasyFontFamily", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getFantasyFontFamily16238 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getFantasyFontFamily", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setMinimumFontSize16239 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setMinimumFontSize", "(I)V");
			global::android.webkit.WebSettings._getMinimumFontSize16240 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getMinimumFontSize", "()I");
			global::android.webkit.WebSettings._setMinimumLogicalFontSize16241 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setMinimumLogicalFontSize", "(I)V");
			global::android.webkit.WebSettings._getMinimumLogicalFontSize16242 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getMinimumLogicalFontSize", "()I");
			global::android.webkit.WebSettings._setDefaultFontSize16243 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultFontSize", "(I)V");
			global::android.webkit.WebSettings._getDefaultFontSize16244 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultFontSize", "()I");
			global::android.webkit.WebSettings._setDefaultFixedFontSize16245 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultFixedFontSize", "(I)V");
			global::android.webkit.WebSettings._getDefaultFixedFontSize16246 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultFixedFontSize", "()I");
			global::android.webkit.WebSettings._setLoadsImagesAutomatically16247 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setLoadsImagesAutomatically", "(Z)V");
			global::android.webkit.WebSettings._getLoadsImagesAutomatically16248 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getLoadsImagesAutomatically", "()Z");
			global::android.webkit.WebSettings._setBlockNetworkImage16249 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setBlockNetworkImage", "(Z)V");
			global::android.webkit.WebSettings._getBlockNetworkImage16250 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getBlockNetworkImage", "()Z");
			global::android.webkit.WebSettings._setBlockNetworkLoads16251 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setBlockNetworkLoads", "(Z)V");
			global::android.webkit.WebSettings._getBlockNetworkLoads16252 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getBlockNetworkLoads", "()Z");
			global::android.webkit.WebSettings._setJavaScriptEnabled16253 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setJavaScriptEnabled", "(Z)V");
			global::android.webkit.WebSettings._setPluginsEnabled16254 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setPluginsEnabled", "(Z)V");
			global::android.webkit.WebSettings._setPluginState16255 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setPluginState", "(Landroid/webkit/WebSettings$PluginState;)V");
			global::android.webkit.WebSettings._setPluginsPath16256 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setPluginsPath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setDatabasePath16257 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDatabasePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setGeolocationDatabasePath16258 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setGeolocationDatabasePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setAppCacheEnabled16259 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAppCacheEnabled", "(Z)V");
			global::android.webkit.WebSettings._setAppCachePath16260 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAppCachePath", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._setAppCacheMaxSize16261 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setAppCacheMaxSize", "(J)V");
			global::android.webkit.WebSettings._setDatabaseEnabled16262 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDatabaseEnabled", "(Z)V");
			global::android.webkit.WebSettings._setDomStorageEnabled16263 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDomStorageEnabled", "(Z)V");
			global::android.webkit.WebSettings._getDomStorageEnabled16264 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDomStorageEnabled", "()Z");
			global::android.webkit.WebSettings._getDatabaseEnabled16265 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDatabaseEnabled", "()Z");
			global::android.webkit.WebSettings._setGeolocationEnabled16266 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setGeolocationEnabled", "(Z)V");
			global::android.webkit.WebSettings._getJavaScriptEnabled16267 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getJavaScriptEnabled", "()Z");
			global::android.webkit.WebSettings._getPluginsEnabled16268 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getPluginsEnabled", "()Z");
			global::android.webkit.WebSettings._getPluginState16269 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getPluginState", "()Landroid/webkit/WebSettings$PluginState;");
			global::android.webkit.WebSettings._getPluginsPath16270 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getPluginsPath", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically16271 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setJavaScriptCanOpenWindowsAutomatically", "(Z)V");
			global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically16272 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getJavaScriptCanOpenWindowsAutomatically", "()Z");
			global::android.webkit.WebSettings._setDefaultTextEncodingName16273 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setDefaultTextEncodingName", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getDefaultTextEncodingName16274 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getDefaultTextEncodingName", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setUserAgentString16275 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setUserAgentString", "(Ljava/lang/String;)V");
			global::android.webkit.WebSettings._getUserAgentString16276 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getUserAgentString", "()Ljava/lang/String;");
			global::android.webkit.WebSettings._setNeedInitialFocus16277 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setNeedInitialFocus", "(Z)V");
			global::android.webkit.WebSettings._setRenderPriority16278 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setRenderPriority", "(Landroid/webkit/WebSettings$RenderPriority;)V");
			global::android.webkit.WebSettings._setCacheMode16279 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "setCacheMode", "(I)V");
			global::android.webkit.WebSettings._getCacheMode16280 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSettings.staticClass, "getCacheMode", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
