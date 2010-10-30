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
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.webkit.WebSettings.LayoutAlgorithm[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebSettings.LayoutAlgorithm._m0.native == global::System.IntPtr.Zero)
					global::android.webkit.WebSettings.LayoutAlgorithm._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "values", "()[Landroid/webkit/WebSettings/LayoutAlgorithm;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.LayoutAlgorithm>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._m0)) as android.webkit.WebSettings.LayoutAlgorithm[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.webkit.WebSettings.LayoutAlgorithm valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebSettings.LayoutAlgorithm._m1.native == global::System.IntPtr.Zero)
					global::android.webkit.WebSettings.LayoutAlgorithm._m1 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$LayoutAlgorithm;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.LayoutAlgorithm.staticClass, global::android.webkit.WebSettings.LayoutAlgorithm._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.LayoutAlgorithm;
			}
			internal static global::MonoJavaBridge.FieldId _NARROW_COLUMNS5975;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NARROW_COLUMNS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, _NARROW_COLUMNS5975)) as android.webkit.WebSettings.LayoutAlgorithm;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL5976;
			public static global::android.webkit.WebSettings.LayoutAlgorithm NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, _NORMAL5976)) as android.webkit.WebSettings.LayoutAlgorithm;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SINGLE_COLUMN5977;
			public static global::android.webkit.WebSettings.LayoutAlgorithm SINGLE_COLUMN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.LayoutAlgorithm>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, _SINGLE_COLUMN5977)) as android.webkit.WebSettings.LayoutAlgorithm;
				}
			}
			static LayoutAlgorithm()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.LayoutAlgorithm.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$LayoutAlgorithm"));
				global::android.webkit.WebSettings.LayoutAlgorithm._NARROW_COLUMNS5975 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "NARROW_COLUMNS", "Landroid/webkit/WebSettings$LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._NORMAL5976 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "NORMAL", "Landroid/webkit/WebSettings$LayoutAlgorithm;");
				global::android.webkit.WebSettings.LayoutAlgorithm._SINGLE_COLUMN5977 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "SINGLE_COLUMN", "Landroid/webkit/WebSettings$LayoutAlgorithm;");
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
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.webkit.WebSettings.PluginState[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebSettings.PluginState._m0.native == global::System.IntPtr.Zero)
					global::android.webkit.WebSettings.PluginState._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "values", "()[Landroid/webkit/WebSettings/PluginState;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.PluginState>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.PluginState.staticClass, global::android.webkit.WebSettings.PluginState._m0)) as android.webkit.WebSettings.PluginState[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.webkit.WebSettings.PluginState valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebSettings.PluginState._m1.native == global::System.IntPtr.Zero)
					global::android.webkit.WebSettings.PluginState._m1 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$PluginState;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.PluginState.staticClass, global::android.webkit.WebSettings.PluginState._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.PluginState;
			}
			internal static global::MonoJavaBridge.FieldId _OFF5978;
			public static global::android.webkit.WebSettings.PluginState OFF
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.PluginState.staticClass, _OFF5978)) as android.webkit.WebSettings.PluginState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON5979;
			public static global::android.webkit.WebSettings.PluginState ON
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.PluginState.staticClass, _ON5979)) as android.webkit.WebSettings.PluginState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_DEMAND5980;
			public static global::android.webkit.WebSettings.PluginState ON_DEMAND
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.PluginState>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.PluginState.staticClass, _ON_DEMAND5980)) as android.webkit.WebSettings.PluginState;
				}
			}
			static PluginState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.PluginState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$PluginState"));
				global::android.webkit.WebSettings.PluginState._OFF5978 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "OFF", "Landroid/webkit/WebSettings$PluginState;");
				global::android.webkit.WebSettings.PluginState._ON5979 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "ON", "Landroid/webkit/WebSettings$PluginState;");
				global::android.webkit.WebSettings.PluginState._ON_DEMAND5980 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.PluginState.staticClass, "ON_DEMAND", "Landroid/webkit/WebSettings$PluginState;");
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
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.webkit.WebSettings.RenderPriority[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebSettings.RenderPriority._m0.native == global::System.IntPtr.Zero)
					global::android.webkit.WebSettings.RenderPriority._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "values", "()[Landroid/webkit/WebSettings/RenderPriority;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.RenderPriority>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._m0)) as android.webkit.WebSettings.RenderPriority[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.webkit.WebSettings.RenderPriority valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebSettings.RenderPriority._m1.native == global::System.IntPtr.Zero)
					global::android.webkit.WebSettings.RenderPriority._m1 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$RenderPriority;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.RenderPriority>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.RenderPriority.staticClass, global::android.webkit.WebSettings.RenderPriority._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.RenderPriority;
			}
			internal static global::MonoJavaBridge.FieldId _HIGH5981;
			public static global::android.webkit.WebSettings.RenderPriority HIGH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.RenderPriority>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.RenderPriority.staticClass, _HIGH5981)) as android.webkit.WebSettings.RenderPriority;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LOW5982;
			public static global::android.webkit.WebSettings.RenderPriority LOW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.RenderPriority>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.RenderPriority.staticClass, _LOW5982)) as android.webkit.WebSettings.RenderPriority;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL5983;
			public static global::android.webkit.WebSettings.RenderPriority NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.RenderPriority>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.RenderPriority.staticClass, _NORMAL5983)) as android.webkit.WebSettings.RenderPriority;
				}
			}
			static RenderPriority()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.RenderPriority.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$RenderPriority"));
				global::android.webkit.WebSettings.RenderPriority._HIGH5981 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "HIGH", "Landroid/webkit/WebSettings$RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._LOW5982 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "LOW", "Landroid/webkit/WebSettings$RenderPriority;");
				global::android.webkit.WebSettings.RenderPriority._NORMAL5983 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.RenderPriority.staticClass, "NORMAL", "Landroid/webkit/WebSettings$RenderPriority;");
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
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.webkit.WebSettings.TextSize[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebSettings.TextSize._m0.native == global::System.IntPtr.Zero)
					global::android.webkit.WebSettings.TextSize._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "values", "()[Landroid/webkit/WebSettings/TextSize;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.TextSize>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._m0)) as android.webkit.WebSettings.TextSize[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.webkit.WebSettings.TextSize valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebSettings.TextSize._m1.native == global::System.IntPtr.Zero)
					global::android.webkit.WebSettings.TextSize._m1 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$TextSize;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.TextSize.staticClass, global::android.webkit.WebSettings.TextSize._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.TextSize;
			}
			internal static global::MonoJavaBridge.FieldId _LARGER5984;
			public static global::android.webkit.WebSettings.TextSize LARGER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _LARGER5984)) as android.webkit.WebSettings.TextSize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LARGEST5985;
			public static global::android.webkit.WebSettings.TextSize LARGEST
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _LARGEST5985)) as android.webkit.WebSettings.TextSize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL5986;
			public static global::android.webkit.WebSettings.TextSize NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _NORMAL5986)) as android.webkit.WebSettings.TextSize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALLER5987;
			public static global::android.webkit.WebSettings.TextSize SMALLER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _SMALLER5987)) as android.webkit.WebSettings.TextSize;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALLEST5988;
			public static global::android.webkit.WebSettings.TextSize SMALLEST
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.TextSize>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.TextSize.staticClass, _SMALLEST5988)) as android.webkit.WebSettings.TextSize;
				}
			}
			static TextSize()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.TextSize.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$TextSize"));
				global::android.webkit.WebSettings.TextSize._LARGER5984 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "LARGER", "Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._LARGEST5985 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "LARGEST", "Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._NORMAL5986 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "NORMAL", "Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._SMALLER5987 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "SMALLER", "Landroid/webkit/WebSettings$TextSize;");
				global::android.webkit.WebSettings.TextSize._SMALLEST5988 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.TextSize.staticClass, "SMALLEST", "Landroid/webkit/WebSettings$TextSize;");
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
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.webkit.WebSettings.ZoomDensity[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebSettings.ZoomDensity._m0.native == global::System.IntPtr.Zero)
					global::android.webkit.WebSettings.ZoomDensity._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "values", "()[Landroid/webkit/WebSettings/ZoomDensity;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.WebSettings.ZoomDensity>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._m0)) as android.webkit.WebSettings.ZoomDensity[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.webkit.WebSettings.ZoomDensity valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebSettings.ZoomDensity._m1.native == global::System.IntPtr.Zero)
					global::android.webkit.WebSettings.ZoomDensity._m1 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$ZoomDensity;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.CallStaticObjectMethod(android.webkit.WebSettings.ZoomDensity.staticClass, global::android.webkit.WebSettings.ZoomDensity._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebSettings.ZoomDensity;
			}
			internal static global::MonoJavaBridge.FieldId _CLOSE5989;
			public static global::android.webkit.WebSettings.ZoomDensity CLOSE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.ZoomDensity.staticClass, _CLOSE5989)) as android.webkit.WebSettings.ZoomDensity;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FAR5990;
			public static global::android.webkit.WebSettings.ZoomDensity FAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.ZoomDensity.staticClass, _FAR5990)) as android.webkit.WebSettings.ZoomDensity;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MEDIUM5991;
			public static global::android.webkit.WebSettings.ZoomDensity MEDIUM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebSettings.ZoomDensity>(@__env.GetStaticObjectField(global::android.webkit.WebSettings.ZoomDensity.staticClass, _MEDIUM5991)) as android.webkit.WebSettings.ZoomDensity;
				}
			}
			static ZoomDensity()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebSettings.ZoomDensity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSettings$ZoomDensity"));
				global::android.webkit.WebSettings.ZoomDensity._CLOSE5989 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "CLOSE", "Landroid/webkit/WebSettings$ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._FAR5990 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "FAR", "Landroid/webkit/WebSettings$ZoomDensity;");
				global::android.webkit.WebSettings.ZoomDensity._MEDIUM5991 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.WebSettings.ZoomDensity.staticClass, "MEDIUM", "Landroid/webkit/WebSettings$ZoomDensity;");
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getDatabasePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebSettings.staticClass, "getDatabasePath", "()Ljava/lang/String;", ref global::android.webkit.WebSettings._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.webkit.WebSettings.TextSize getTextSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.webkit.WebSettings.TextSize>(this, global::android.webkit.WebSettings.staticClass, "getTextSize", "()Landroid/webkit/WebSettings$TextSize;", ref global::android.webkit.WebSettings._m1) as android.webkit.WebSettings.TextSize;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setTextSize(android.webkit.WebSettings.TextSize arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setTextSize", "(Landroid/webkit/WebSettings$TextSize;)V", ref global::android.webkit.WebSettings._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setNavDump(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setNavDump", "(Z)V", ref global::android.webkit.WebSettings._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool getNavDump()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getNavDump", "()Z", ref global::android.webkit.WebSettings._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setSupportZoom(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setSupportZoom", "(Z)V", ref global::android.webkit.WebSettings._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool supportZoom()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "supportZoom", "()Z", ref global::android.webkit.WebSettings._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setBuiltInZoomControls(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setBuiltInZoomControls", "(Z)V", ref global::android.webkit.WebSettings._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool getBuiltInZoomControls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getBuiltInZoomControls", "()Z", ref global::android.webkit.WebSettings._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setAllowFileAccess(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setAllowFileAccess", "(Z)V", ref global::android.webkit.WebSettings._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool getAllowFileAccess()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getAllowFileAccess", "()Z", ref global::android.webkit.WebSettings._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setLoadWithOverviewMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setLoadWithOverviewMode", "(Z)V", ref global::android.webkit.WebSettings._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool getLoadWithOverviewMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getLoadWithOverviewMode", "()Z", ref global::android.webkit.WebSettings._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setSaveFormData(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setSaveFormData", "(Z)V", ref global::android.webkit.WebSettings._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool getSaveFormData()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getSaveFormData", "()Z", ref global::android.webkit.WebSettings._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setSavePassword(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setSavePassword", "(Z)V", ref global::android.webkit.WebSettings._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool getSavePassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getSavePassword", "()Z", ref global::android.webkit.WebSettings._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setDefaultZoom(android.webkit.WebSettings.ZoomDensity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setDefaultZoom", "(Landroid/webkit/WebSettings$ZoomDensity;)V", ref global::android.webkit.WebSettings._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::android.webkit.WebSettings.ZoomDensity getDefaultZoom()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.webkit.WebSettings.ZoomDensity>(this, global::android.webkit.WebSettings.staticClass, "getDefaultZoom", "()Landroid/webkit/WebSettings$ZoomDensity;", ref global::android.webkit.WebSettings._m18) as android.webkit.WebSettings.ZoomDensity;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setLightTouchEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setLightTouchEnabled", "(Z)V", ref global::android.webkit.WebSettings._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool getLightTouchEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getLightTouchEnabled", "()Z", ref global::android.webkit.WebSettings._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setUseDoubleTree(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setUseDoubleTree", "(Z)V", ref global::android.webkit.WebSettings._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool getUseDoubleTree()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getUseDoubleTree", "()Z", ref global::android.webkit.WebSettings._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setUserAgent(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setUserAgent", "(I)V", ref global::android.webkit.WebSettings._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int getUserAgent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebSettings.staticClass, "getUserAgent", "()I", ref global::android.webkit.WebSettings._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setUseWideViewPort(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setUseWideViewPort", "(Z)V", ref global::android.webkit.WebSettings._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool getUseWideViewPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getUseWideViewPort", "()Z", ref global::android.webkit.WebSettings._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void setSupportMultipleWindows(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setSupportMultipleWindows", "(Z)V", ref global::android.webkit.WebSettings._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool supportMultipleWindows()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "supportMultipleWindows", "()Z", ref global::android.webkit.WebSettings._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void setLayoutAlgorithm(android.webkit.WebSettings.LayoutAlgorithm arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setLayoutAlgorithm", "(Landroid/webkit/WebSettings$LayoutAlgorithm;)V", ref global::android.webkit.WebSettings._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual global::android.webkit.WebSettings.LayoutAlgorithm getLayoutAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.webkit.WebSettings.LayoutAlgorithm>(this, global::android.webkit.WebSettings.staticClass, "getLayoutAlgorithm", "()Landroid/webkit/WebSettings$LayoutAlgorithm;", ref global::android.webkit.WebSettings._m30) as android.webkit.WebSettings.LayoutAlgorithm;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void setStandardFontFamily(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setStandardFontFamily", "(Ljava/lang/String;)V", ref global::android.webkit.WebSettings._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual global::java.lang.String getStandardFontFamily()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebSettings.staticClass, "getStandardFontFamily", "()Ljava/lang/String;", ref global::android.webkit.WebSettings._m32) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void setFixedFontFamily(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setFixedFontFamily", "(Ljava/lang/String;)V", ref global::android.webkit.WebSettings._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual global::java.lang.String getFixedFontFamily()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebSettings.staticClass, "getFixedFontFamily", "()Ljava/lang/String;", ref global::android.webkit.WebSettings._m34) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void setSansSerifFontFamily(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setSansSerifFontFamily", "(Ljava/lang/String;)V", ref global::android.webkit.WebSettings._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual global::java.lang.String getSansSerifFontFamily()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebSettings.staticClass, "getSansSerifFontFamily", "()Ljava/lang/String;", ref global::android.webkit.WebSettings._m36) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void setSerifFontFamily(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setSerifFontFamily", "(Ljava/lang/String;)V", ref global::android.webkit.WebSettings._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual global::java.lang.String getSerifFontFamily()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebSettings.staticClass, "getSerifFontFamily", "()Ljava/lang/String;", ref global::android.webkit.WebSettings._m38) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void setCursiveFontFamily(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setCursiveFontFamily", "(Ljava/lang/String;)V", ref global::android.webkit.WebSettings._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::java.lang.String getCursiveFontFamily()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebSettings.staticClass, "getCursiveFontFamily", "()Ljava/lang/String;", ref global::android.webkit.WebSettings._m40) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void setFantasyFontFamily(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setFantasyFontFamily", "(Ljava/lang/String;)V", ref global::android.webkit.WebSettings._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual global::java.lang.String getFantasyFontFamily()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebSettings.staticClass, "getFantasyFontFamily", "()Ljava/lang/String;", ref global::android.webkit.WebSettings._m42) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void setMinimumFontSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setMinimumFontSize", "(I)V", ref global::android.webkit.WebSettings._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual int getMinimumFontSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebSettings.staticClass, "getMinimumFontSize", "()I", ref global::android.webkit.WebSettings._m44);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual void setMinimumLogicalFontSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setMinimumLogicalFontSize", "(I)V", ref global::android.webkit.WebSettings._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual int getMinimumLogicalFontSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebSettings.staticClass, "getMinimumLogicalFontSize", "()I", ref global::android.webkit.WebSettings._m46);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual void setDefaultFontSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setDefaultFontSize", "(I)V", ref global::android.webkit.WebSettings._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual int getDefaultFontSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebSettings.staticClass, "getDefaultFontSize", "()I", ref global::android.webkit.WebSettings._m48);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual void setDefaultFixedFontSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setDefaultFixedFontSize", "(I)V", ref global::android.webkit.WebSettings._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual int getDefaultFixedFontSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebSettings.staticClass, "getDefaultFixedFontSize", "()I", ref global::android.webkit.WebSettings._m50);
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual void setLoadsImagesAutomatically(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setLoadsImagesAutomatically", "(Z)V", ref global::android.webkit.WebSettings._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m52;
		public virtual bool getLoadsImagesAutomatically()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getLoadsImagesAutomatically", "()Z", ref global::android.webkit.WebSettings._m52);
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public virtual void setBlockNetworkImage(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setBlockNetworkImage", "(Z)V", ref global::android.webkit.WebSettings._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual bool getBlockNetworkImage()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getBlockNetworkImage", "()Z", ref global::android.webkit.WebSettings._m54);
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual void setBlockNetworkLoads(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setBlockNetworkLoads", "(Z)V", ref global::android.webkit.WebSettings._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual bool getBlockNetworkLoads()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getBlockNetworkLoads", "()Z", ref global::android.webkit.WebSettings._m56);
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public virtual void setJavaScriptEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setJavaScriptEnabled", "(Z)V", ref global::android.webkit.WebSettings._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual void setPluginsEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setPluginsEnabled", "(Z)V", ref global::android.webkit.WebSettings._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public virtual void setPluginState(android.webkit.WebSettings.PluginState arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setPluginState", "(Landroid/webkit/WebSettings$PluginState;)V", ref global::android.webkit.WebSettings._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual void setPluginsPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setPluginsPath", "(Ljava/lang/String;)V", ref global::android.webkit.WebSettings._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public virtual void setDatabasePath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setDatabasePath", "(Ljava/lang/String;)V", ref global::android.webkit.WebSettings._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String GeolocationDatabasePath
		{
			set
			{
				setGeolocationDatabasePath(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public virtual void setGeolocationDatabasePath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setGeolocationDatabasePath", "(Ljava/lang/String;)V", ref global::android.webkit.WebSettings._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool AppCacheEnabled
		{
			set
			{
				setAppCacheEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public virtual void setAppCacheEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setAppCacheEnabled", "(Z)V", ref global::android.webkit.WebSettings._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String AppCachePath
		{
			set
			{
				setAppCachePath(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public virtual void setAppCachePath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setAppCachePath", "(Ljava/lang/String;)V", ref global::android.webkit.WebSettings._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long AppCacheMaxSize
		{
			set
			{
				setAppCacheMaxSize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public virtual void setAppCacheMaxSize(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setAppCacheMaxSize", "(J)V", ref global::android.webkit.WebSettings._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public virtual void setDatabaseEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setDatabaseEnabled", "(Z)V", ref global::android.webkit.WebSettings._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public virtual void setDomStorageEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setDomStorageEnabled", "(Z)V", ref global::android.webkit.WebSettings._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m68;
		public virtual bool getDomStorageEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getDomStorageEnabled", "()Z", ref global::android.webkit.WebSettings._m68);
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
		private static global::MonoJavaBridge.MethodId _m69;
		public virtual bool getDatabaseEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getDatabaseEnabled", "()Z", ref global::android.webkit.WebSettings._m69);
		}
		public new bool GeolocationEnabled
		{
			set
			{
				setGeolocationEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public virtual void setGeolocationEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setGeolocationEnabled", "(Z)V", ref global::android.webkit.WebSettings._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m71;
		public virtual bool getJavaScriptEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getJavaScriptEnabled", "()Z", ref global::android.webkit.WebSettings._m71);
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
		private static global::MonoJavaBridge.MethodId _m72;
		public virtual bool getPluginsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getPluginsEnabled", "()Z", ref global::android.webkit.WebSettings._m72);
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public virtual global::android.webkit.WebSettings.PluginState getPluginState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.webkit.WebSettings.PluginState>(this, global::android.webkit.WebSettings.staticClass, "getPluginState", "()Landroid/webkit/WebSettings$PluginState;", ref global::android.webkit.WebSettings._m73) as android.webkit.WebSettings.PluginState;
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
		private static global::MonoJavaBridge.MethodId _m74;
		public virtual global::java.lang.String getPluginsPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebSettings.staticClass, "getPluginsPath", "()Ljava/lang/String;", ref global::android.webkit.WebSettings._m74) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public virtual void setJavaScriptCanOpenWindowsAutomatically(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setJavaScriptCanOpenWindowsAutomatically", "(Z)V", ref global::android.webkit.WebSettings._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m76;
		public virtual bool getJavaScriptCanOpenWindowsAutomatically()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebSettings.staticClass, "getJavaScriptCanOpenWindowsAutomatically", "()Z", ref global::android.webkit.WebSettings._m76);
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public virtual void setDefaultTextEncodingName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setDefaultTextEncodingName", "(Ljava/lang/String;)V", ref global::android.webkit.WebSettings._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m78;
		public virtual global::java.lang.String getDefaultTextEncodingName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebSettings.staticClass, "getDefaultTextEncodingName", "()Ljava/lang/String;", ref global::android.webkit.WebSettings._m78) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public virtual void setUserAgentString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setUserAgentString", "(Ljava/lang/String;)V", ref global::android.webkit.WebSettings._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m80;
		public virtual global::java.lang.String getUserAgentString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebSettings.staticClass, "getUserAgentString", "()Ljava/lang/String;", ref global::android.webkit.WebSettings._m80) as java.lang.String;
		}
		public new bool NeedInitialFocus
		{
			set
			{
				setNeedInitialFocus(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public virtual void setNeedInitialFocus(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setNeedInitialFocus", "(Z)V", ref global::android.webkit.WebSettings._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public virtual void setRenderPriority(android.webkit.WebSettings.RenderPriority arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setRenderPriority", "(Landroid/webkit/WebSettings$RenderPriority;)V", ref global::android.webkit.WebSettings._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public virtual void setCacheMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSettings.staticClass, "setCacheMode", "(I)V", ref global::android.webkit.WebSettings._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m84;
		public virtual int getCacheMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebSettings.staticClass, "getCacheMode", "()I", ref global::android.webkit.WebSettings._m84);
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
		}
		internal static void InitJNI()
		{
		}
	}
}
