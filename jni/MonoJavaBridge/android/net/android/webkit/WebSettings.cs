namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WebSettings : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebSettings() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebSettings), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebSettings.LayoutAlgorithm), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf8715; 
			public static android.webkit.WebSettings.LayoutAlgorithm valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.LayoutAlgorithm>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.LayoutAlgorithm.staticClass, _valueOf8715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values8716; 
			public static android.webkit.WebSettings.LayoutAlgorithm[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.LayoutAlgorithm.staticClass, _values8716)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _NARROW_COLUMNS8717; 
			public static android.webkit.WebSettings.LayoutAlgorithm NARROW_COLUMNS
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.LayoutAlgorithm); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL8718; 
			public static android.webkit.WebSettings.LayoutAlgorithm NORMAL
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.LayoutAlgorithm); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SINGLE_COLUMN8719; 
			public static android.webkit.WebSettings.LayoutAlgorithm SINGLE_COLUMN
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.LayoutAlgorithm); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.webkit.WebSettings.LayoutAlgorithm.staticClass = @__class; 
				global::android.webkit.WebSettings.LayoutAlgorithm._valueOf8715 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$LayoutAlgorithm;"); 
				global::android.webkit.WebSettings.LayoutAlgorithm._values8716 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.LayoutAlgorithm.staticClass, "values", "()[Landroid/webkit/WebSettings/LayoutAlgorithm;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class RenderPriority : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static RenderPriority() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebSettings.RenderPriority), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf8720; 
			public static android.webkit.WebSettings.RenderPriority valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.RenderPriority>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.RenderPriority.staticClass, _valueOf8720, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values8721; 
			public static android.webkit.WebSettings.RenderPriority[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.RenderPriority.staticClass, _values8721)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _HIGH8722; 
			public static android.webkit.WebSettings.RenderPriority HIGH
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.RenderPriority); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _LOW8723; 
			public static android.webkit.WebSettings.RenderPriority LOW
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.RenderPriority); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL8724; 
			public static android.webkit.WebSettings.RenderPriority NORMAL
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.RenderPriority); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.webkit.WebSettings.RenderPriority.staticClass = @__class; 
				global::android.webkit.WebSettings.RenderPriority._valueOf8720 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.RenderPriority.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$RenderPriority;"); 
				global::android.webkit.WebSettings.RenderPriority._values8721 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.RenderPriority.staticClass, "values", "()[Landroid/webkit/WebSettings/RenderPriority;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class TextSize : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static TextSize() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebSettings.TextSize), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf8725; 
			public static android.webkit.WebSettings.TextSize valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.TextSize>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.TextSize.staticClass, _valueOf8725, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values8726; 
			public static android.webkit.WebSettings.TextSize[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.TextSize.staticClass, _values8726)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _LARGER8727; 
			public static android.webkit.WebSettings.TextSize LARGER
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.TextSize); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _LARGEST8728; 
			public static android.webkit.WebSettings.TextSize LARGEST
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.TextSize); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL8729; 
			public static android.webkit.WebSettings.TextSize NORMAL
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.TextSize); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SMALLER8730; 
			public static android.webkit.WebSettings.TextSize SMALLER
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.TextSize); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SMALLEST8731; 
			public static android.webkit.WebSettings.TextSize SMALLEST
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.TextSize); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.webkit.WebSettings.TextSize.staticClass = @__class; 
				global::android.webkit.WebSettings.TextSize._valueOf8725 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.TextSize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$TextSize;"); 
				global::android.webkit.WebSettings.TextSize._values8726 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.TextSize.staticClass, "values", "()[Landroid/webkit/WebSettings/TextSize;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class ZoomDensity : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static ZoomDensity() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebSettings.ZoomDensity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf8732; 
			public static android.webkit.WebSettings.ZoomDensity valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.ZoomDensity>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.ZoomDensity.staticClass, _valueOf8732, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values8733; 
			public static android.webkit.WebSettings.ZoomDensity[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebSettings.ZoomDensity.staticClass, _values8733)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLOSE8734; 
			public static android.webkit.WebSettings.ZoomDensity CLOSE
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.ZoomDensity); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FAR8735; 
			public static android.webkit.WebSettings.ZoomDensity FAR
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.ZoomDensity); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MEDIUM8736; 
			public static android.webkit.WebSettings.ZoomDensity MEDIUM
			{ 
				get 
				{ 
					return default(android.webkit.WebSettings.ZoomDensity); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.webkit.WebSettings.ZoomDensity.staticClass = @__class; 
				global::android.webkit.WebSettings.ZoomDensity._valueOf8732 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.ZoomDensity.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$ZoomDensity;"); 
				global::android.webkit.WebSettings.ZoomDensity._values8733 = @__env.GetStaticMethodID(global::android.webkit.WebSettings.ZoomDensity.staticClass, "values", "()[Landroid/webkit/WebSettings/ZoomDensity;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDatabasePath8737; 
		public virtual java.lang.String getDatabasePath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDatabasePath8737)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getDatabasePath8737)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextSize8738; 
		public virtual android.webkit.WebSettings.TextSize getTextSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.TextSize>(@__env, @__env.CallObjectMethodPtr(this, _getTextSize8738)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.TextSize>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getTextSize8738)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextSize8739; 
		public virtual void setTextSize(android.webkit.WebSettings.TextSize arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setTextSize8739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setTextSize8739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNavDump8740; 
		public virtual void setNavDump(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setNavDump8740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setNavDump8740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNavDump8741; 
		public virtual bool getNavDump() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getNavDump8741); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getNavDump8741); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSupportZoom8742; 
		public virtual void setSupportZoom(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setSupportZoom8742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setSupportZoom8742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _supportZoom8743; 
		public virtual bool supportZoom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _supportZoom8743); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _supportZoom8743); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBuiltInZoomControls8744; 
		public virtual void setBuiltInZoomControls(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setBuiltInZoomControls8744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setBuiltInZoomControls8744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBuiltInZoomControls8745; 
		public virtual bool getBuiltInZoomControls() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getBuiltInZoomControls8745); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getBuiltInZoomControls8745); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAllowFileAccess8746; 
		public virtual void setAllowFileAccess(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setAllowFileAccess8746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setAllowFileAccess8746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllowFileAccess8747; 
		public virtual bool getAllowFileAccess() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getAllowFileAccess8747); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getAllowFileAccess8747); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLoadWithOverviewMode8748; 
		public virtual void setLoadWithOverviewMode(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setLoadWithOverviewMode8748, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setLoadWithOverviewMode8748, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLoadWithOverviewMode8749; 
		public virtual bool getLoadWithOverviewMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getLoadWithOverviewMode8749); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getLoadWithOverviewMode8749); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSaveFormData8750; 
		public virtual void setSaveFormData(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setSaveFormData8750, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setSaveFormData8750, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSaveFormData8751; 
		public virtual bool getSaveFormData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getSaveFormData8751); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getSaveFormData8751); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSavePassword8752; 
		public virtual void setSavePassword(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setSavePassword8752, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setSavePassword8752, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSavePassword8753; 
		public virtual bool getSavePassword() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getSavePassword8753); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getSavePassword8753); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultZoom8754; 
		public virtual void setDefaultZoom(android.webkit.WebSettings.ZoomDensity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setDefaultZoom8754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setDefaultZoom8754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultZoom8755; 
		public virtual android.webkit.WebSettings.ZoomDensity getDefaultZoom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.ZoomDensity>(@__env, @__env.CallObjectMethodPtr(this, _getDefaultZoom8755)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.ZoomDensity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getDefaultZoom8755)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLightTouchEnabled8756; 
		public virtual void setLightTouchEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setLightTouchEnabled8756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setLightTouchEnabled8756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLightTouchEnabled8757; 
		public virtual bool getLightTouchEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getLightTouchEnabled8757); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getLightTouchEnabled8757); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUseDoubleTree8758; 
		public virtual void setUseDoubleTree(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setUseDoubleTree8758, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setUseDoubleTree8758, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUseDoubleTree8759; 
		public virtual bool getUseDoubleTree() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getUseDoubleTree8759); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getUseDoubleTree8759); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUserAgent8760; 
		public virtual void setUserAgent(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setUserAgent8760, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setUserAgent8760, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUserAgent8761; 
		public virtual int getUserAgent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallIntMethod(this, _getUserAgent8761); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebSettings.staticClass, _getUserAgent8761); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUseWideViewPort8762; 
		public virtual void setUseWideViewPort(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setUseWideViewPort8762, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setUseWideViewPort8762, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUseWideViewPort8763; 
		public virtual bool getUseWideViewPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getUseWideViewPort8763); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getUseWideViewPort8763); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSupportMultipleWindows8764; 
		public virtual void setSupportMultipleWindows(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setSupportMultipleWindows8764, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setSupportMultipleWindows8764, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _supportMultipleWindows8765; 
		public virtual bool supportMultipleWindows() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _supportMultipleWindows8765); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _supportMultipleWindows8765); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutAlgorithm8766; 
		public virtual void setLayoutAlgorithm(android.webkit.WebSettings.LayoutAlgorithm arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setLayoutAlgorithm8766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setLayoutAlgorithm8766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutAlgorithm8767; 
		public virtual android.webkit.WebSettings.LayoutAlgorithm getLayoutAlgorithm() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.LayoutAlgorithm>(@__env, @__env.CallObjectMethodPtr(this, _getLayoutAlgorithm8767)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings.LayoutAlgorithm>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getLayoutAlgorithm8767)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStandardFontFamily8768; 
		public virtual void setStandardFontFamily(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setStandardFontFamily8768, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setStandardFontFamily8768, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStandardFontFamily8769; 
		public virtual java.lang.String getStandardFontFamily() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getStandardFontFamily8769)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getStandardFontFamily8769)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFixedFontFamily8770; 
		public virtual void setFixedFontFamily(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setFixedFontFamily8770, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setFixedFontFamily8770, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFixedFontFamily8771; 
		public virtual java.lang.String getFixedFontFamily() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getFixedFontFamily8771)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getFixedFontFamily8771)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSansSerifFontFamily8772; 
		public virtual void setSansSerifFontFamily(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setSansSerifFontFamily8772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setSansSerifFontFamily8772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSansSerifFontFamily8773; 
		public virtual java.lang.String getSansSerifFontFamily() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSansSerifFontFamily8773)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getSansSerifFontFamily8773)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSerifFontFamily8774; 
		public virtual void setSerifFontFamily(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setSerifFontFamily8774, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setSerifFontFamily8774, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSerifFontFamily8775; 
		public virtual java.lang.String getSerifFontFamily() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSerifFontFamily8775)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getSerifFontFamily8775)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCursiveFontFamily8776; 
		public virtual void setCursiveFontFamily(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setCursiveFontFamily8776, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setCursiveFontFamily8776, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCursiveFontFamily8777; 
		public virtual java.lang.String getCursiveFontFamily() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCursiveFontFamily8777)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getCursiveFontFamily8777)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFantasyFontFamily8778; 
		public virtual void setFantasyFontFamily(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setFantasyFontFamily8778, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setFantasyFontFamily8778, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFantasyFontFamily8779; 
		public virtual java.lang.String getFantasyFontFamily() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getFantasyFontFamily8779)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getFantasyFontFamily8779)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumFontSize8780; 
		public virtual void setMinimumFontSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setMinimumFontSize8780, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setMinimumFontSize8780, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumFontSize8781; 
		public virtual int getMinimumFontSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallIntMethod(this, _getMinimumFontSize8781); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebSettings.staticClass, _getMinimumFontSize8781); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumLogicalFontSize8782; 
		public virtual void setMinimumLogicalFontSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setMinimumLogicalFontSize8782, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setMinimumLogicalFontSize8782, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumLogicalFontSize8783; 
		public virtual int getMinimumLogicalFontSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallIntMethod(this, _getMinimumLogicalFontSize8783); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebSettings.staticClass, _getMinimumLogicalFontSize8783); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultFontSize8784; 
		public virtual void setDefaultFontSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setDefaultFontSize8784, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setDefaultFontSize8784, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultFontSize8785; 
		public virtual int getDefaultFontSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallIntMethod(this, _getDefaultFontSize8785); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebSettings.staticClass, _getDefaultFontSize8785); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultFixedFontSize8786; 
		public virtual void setDefaultFixedFontSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setDefaultFixedFontSize8786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setDefaultFixedFontSize8786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultFixedFontSize8787; 
		public virtual int getDefaultFixedFontSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallIntMethod(this, _getDefaultFixedFontSize8787); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebSettings.staticClass, _getDefaultFixedFontSize8787); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLoadsImagesAutomatically8788; 
		public virtual void setLoadsImagesAutomatically(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setLoadsImagesAutomatically8788, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setLoadsImagesAutomatically8788, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLoadsImagesAutomatically8789; 
		public virtual bool getLoadsImagesAutomatically() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getLoadsImagesAutomatically8789); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getLoadsImagesAutomatically8789); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBlockNetworkImage8790; 
		public virtual void setBlockNetworkImage(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setBlockNetworkImage8790, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setBlockNetworkImage8790, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlockNetworkImage8791; 
		public virtual bool getBlockNetworkImage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getBlockNetworkImage8791); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getBlockNetworkImage8791); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setJavaScriptEnabled8792; 
		public virtual void setJavaScriptEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setJavaScriptEnabled8792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setJavaScriptEnabled8792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPluginsEnabled8793; 
		public virtual void setPluginsEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setPluginsEnabled8793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setPluginsEnabled8793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPluginsPath8794; 
		public virtual void setPluginsPath(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setPluginsPath8794, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setPluginsPath8794, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDatabasePath8795; 
		public virtual void setDatabasePath(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setDatabasePath8795, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setDatabasePath8795, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGeolocationDatabasePath8796; 
		public virtual void setGeolocationDatabasePath(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setGeolocationDatabasePath8796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setGeolocationDatabasePath8796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAppCacheEnabled8797; 
		public virtual void setAppCacheEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setAppCacheEnabled8797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setAppCacheEnabled8797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAppCachePath8798; 
		public virtual void setAppCachePath(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setAppCachePath8798, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setAppCachePath8798, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAppCacheMaxSize8799; 
		public virtual void setAppCacheMaxSize(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setAppCacheMaxSize8799, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setAppCacheMaxSize8799, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDatabaseEnabled8800; 
		public virtual void setDatabaseEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setDatabaseEnabled8800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setDatabaseEnabled8800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDomStorageEnabled8801; 
		public virtual void setDomStorageEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setDomStorageEnabled8801, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setDomStorageEnabled8801, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDomStorageEnabled8802; 
		public virtual bool getDomStorageEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getDomStorageEnabled8802); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getDomStorageEnabled8802); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDatabaseEnabled8803; 
		public virtual bool getDatabaseEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getDatabaseEnabled8803); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getDatabaseEnabled8803); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGeolocationEnabled8804; 
		public virtual void setGeolocationEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setGeolocationEnabled8804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setGeolocationEnabled8804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getJavaScriptEnabled8805; 
		public virtual bool getJavaScriptEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getJavaScriptEnabled8805); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getJavaScriptEnabled8805); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPluginsEnabled8806; 
		public virtual bool getPluginsEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getPluginsEnabled8806); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getPluginsEnabled8806); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPluginsPath8807; 
		public virtual java.lang.String getPluginsPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPluginsPath8807)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getPluginsPath8807)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setJavaScriptCanOpenWindowsAutomatically8808; 
		public virtual void setJavaScriptCanOpenWindowsAutomatically(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setJavaScriptCanOpenWindowsAutomatically8808, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setJavaScriptCanOpenWindowsAutomatically8808, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getJavaScriptCanOpenWindowsAutomatically8809; 
		public virtual bool getJavaScriptCanOpenWindowsAutomatically() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallBooleanMethod(this, _getJavaScriptCanOpenWindowsAutomatically8809); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebSettings.staticClass, _getJavaScriptCanOpenWindowsAutomatically8809); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultTextEncodingName8810; 
		public virtual void setDefaultTextEncodingName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setDefaultTextEncodingName8810, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setDefaultTextEncodingName8810, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultTextEncodingName8811; 
		public virtual java.lang.String getDefaultTextEncodingName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDefaultTextEncodingName8811)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getDefaultTextEncodingName8811)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUserAgentString8812; 
		public virtual void setUserAgentString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setUserAgentString8812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setUserAgentString8812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUserAgentString8813; 
		public virtual java.lang.String getUserAgentString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getUserAgentString8813)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebSettings.staticClass, _getUserAgentString8813)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNeedInitialFocus8814; 
		public virtual void setNeedInitialFocus(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setNeedInitialFocus8814, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setNeedInitialFocus8814, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRenderPriority8815; 
		public virtual void setRenderPriority(android.webkit.WebSettings.RenderPriority arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setRenderPriority8815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setRenderPriority8815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCacheMode8816; 
		public virtual void setCacheMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				@__env.CallVoidMethod(this, _setCacheMode8816, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSettings.staticClass, _setCacheMode8816, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCacheMode8817; 
		public virtual int getCacheMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSettings)) 
				return @__env.CallIntMethod(this, _getCacheMode8817); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebSettings.staticClass, _getCacheMode8817); 
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
			global::android.webkit.WebSettings._getDatabasePath8737 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDatabasePath", "()Ljava/lang/String;"); 
			global::android.webkit.WebSettings._getTextSize8738 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getTextSize", "()Landroid/webkit/WebSettings$TextSize;"); 
			global::android.webkit.WebSettings._setTextSize8739 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setTextSize", "(Landroid/webkit/WebSettings$TextSize;)V"); 
			global::android.webkit.WebSettings._setNavDump8740 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setNavDump", "(Z)V"); 
			global::android.webkit.WebSettings._getNavDump8741 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getNavDump", "()Z"); 
			global::android.webkit.WebSettings._setSupportZoom8742 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSupportZoom", "(Z)V"); 
			global::android.webkit.WebSettings._supportZoom8743 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "supportZoom", "()Z"); 
			global::android.webkit.WebSettings._setBuiltInZoomControls8744 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setBuiltInZoomControls", "(Z)V"); 
			global::android.webkit.WebSettings._getBuiltInZoomControls8745 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getBuiltInZoomControls", "()Z"); 
			global::android.webkit.WebSettings._setAllowFileAccess8746 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setAllowFileAccess", "(Z)V"); 
			global::android.webkit.WebSettings._getAllowFileAccess8747 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getAllowFileAccess", "()Z"); 
			global::android.webkit.WebSettings._setLoadWithOverviewMode8748 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setLoadWithOverviewMode", "(Z)V"); 
			global::android.webkit.WebSettings._getLoadWithOverviewMode8749 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getLoadWithOverviewMode", "()Z"); 
			global::android.webkit.WebSettings._setSaveFormData8750 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSaveFormData", "(Z)V"); 
			global::android.webkit.WebSettings._getSaveFormData8751 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getSaveFormData", "()Z"); 
			global::android.webkit.WebSettings._setSavePassword8752 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSavePassword", "(Z)V"); 
			global::android.webkit.WebSettings._getSavePassword8753 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getSavePassword", "()Z"); 
			global::android.webkit.WebSettings._setDefaultZoom8754 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDefaultZoom", "(Landroid/webkit/WebSettings$ZoomDensity;)V"); 
			global::android.webkit.WebSettings._getDefaultZoom8755 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDefaultZoom", "()Landroid/webkit/WebSettings$ZoomDensity;"); 
			global::android.webkit.WebSettings._setLightTouchEnabled8756 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setLightTouchEnabled", "(Z)V"); 
			global::android.webkit.WebSettings._getLightTouchEnabled8757 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getLightTouchEnabled", "()Z"); 
			global::android.webkit.WebSettings._setUseDoubleTree8758 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setUseDoubleTree", "(Z)V"); 
			global::android.webkit.WebSettings._getUseDoubleTree8759 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getUseDoubleTree", "()Z"); 
			global::android.webkit.WebSettings._setUserAgent8760 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setUserAgent", "(I)V"); 
			global::android.webkit.WebSettings._getUserAgent8761 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getUserAgent", "()I"); 
			global::android.webkit.WebSettings._setUseWideViewPort8762 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setUseWideViewPort", "(Z)V"); 
			global::android.webkit.WebSettings._getUseWideViewPort8763 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getUseWideViewPort", "()Z"); 
			global::android.webkit.WebSettings._setSupportMultipleWindows8764 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSupportMultipleWindows", "(Z)V"); 
			global::android.webkit.WebSettings._supportMultipleWindows8765 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "supportMultipleWindows", "()Z"); 
			global::android.webkit.WebSettings._setLayoutAlgorithm8766 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setLayoutAlgorithm", "(Landroid/webkit/WebSettings$LayoutAlgorithm;)V"); 
			global::android.webkit.WebSettings._getLayoutAlgorithm8767 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getLayoutAlgorithm", "()Landroid/webkit/WebSettings$LayoutAlgorithm;"); 
			global::android.webkit.WebSettings._setStandardFontFamily8768 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setStandardFontFamily", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebSettings._getStandardFontFamily8769 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getStandardFontFamily", "()Ljava/lang/String;"); 
			global::android.webkit.WebSettings._setFixedFontFamily8770 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setFixedFontFamily", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebSettings._getFixedFontFamily8771 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getFixedFontFamily", "()Ljava/lang/String;"); 
			global::android.webkit.WebSettings._setSansSerifFontFamily8772 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSansSerifFontFamily", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebSettings._getSansSerifFontFamily8773 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getSansSerifFontFamily", "()Ljava/lang/String;"); 
			global::android.webkit.WebSettings._setSerifFontFamily8774 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setSerifFontFamily", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebSettings._getSerifFontFamily8775 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getSerifFontFamily", "()Ljava/lang/String;"); 
			global::android.webkit.WebSettings._setCursiveFontFamily8776 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setCursiveFontFamily", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebSettings._getCursiveFontFamily8777 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getCursiveFontFamily", "()Ljava/lang/String;"); 
			global::android.webkit.WebSettings._setFantasyFontFamily8778 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setFantasyFontFamily", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebSettings._getFantasyFontFamily8779 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getFantasyFontFamily", "()Ljava/lang/String;"); 
			global::android.webkit.WebSettings._setMinimumFontSize8780 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setMinimumFontSize", "(I)V"); 
			global::android.webkit.WebSettings._getMinimumFontSize8781 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getMinimumFontSize", "()I"); 
			global::android.webkit.WebSettings._setMinimumLogicalFontSize8782 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setMinimumLogicalFontSize", "(I)V"); 
			global::android.webkit.WebSettings._getMinimumLogicalFontSize8783 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getMinimumLogicalFontSize", "()I"); 
			global::android.webkit.WebSettings._setDefaultFontSize8784 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDefaultFontSize", "(I)V"); 
			global::android.webkit.WebSettings._getDefaultFontSize8785 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDefaultFontSize", "()I"); 
			global::android.webkit.WebSettings._setDefaultFixedFontSize8786 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDefaultFixedFontSize", "(I)V"); 
			global::android.webkit.WebSettings._getDefaultFixedFontSize8787 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDefaultFixedFontSize", "()I"); 
			global::android.webkit.WebSettings._setLoadsImagesAutomatically8788 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setLoadsImagesAutomatically", "(Z)V"); 
			global::android.webkit.WebSettings._getLoadsImagesAutomatically8789 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getLoadsImagesAutomatically", "()Z"); 
			global::android.webkit.WebSettings._setBlockNetworkImage8790 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setBlockNetworkImage", "(Z)V"); 
			global::android.webkit.WebSettings._getBlockNetworkImage8791 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getBlockNetworkImage", "()Z"); 
			global::android.webkit.WebSettings._setJavaScriptEnabled8792 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setJavaScriptEnabled", "(Z)V"); 
			global::android.webkit.WebSettings._setPluginsEnabled8793 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setPluginsEnabled", "(Z)V"); 
			global::android.webkit.WebSettings._setPluginsPath8794 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setPluginsPath", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebSettings._setDatabasePath8795 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDatabasePath", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebSettings._setGeolocationDatabasePath8796 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setGeolocationDatabasePath", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebSettings._setAppCacheEnabled8797 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setAppCacheEnabled", "(Z)V"); 
			global::android.webkit.WebSettings._setAppCachePath8798 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setAppCachePath", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebSettings._setAppCacheMaxSize8799 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setAppCacheMaxSize", "(J)V"); 
			global::android.webkit.WebSettings._setDatabaseEnabled8800 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDatabaseEnabled", "(Z)V"); 
			global::android.webkit.WebSettings._setDomStorageEnabled8801 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDomStorageEnabled", "(Z)V"); 
			global::android.webkit.WebSettings._getDomStorageEnabled8802 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDomStorageEnabled", "()Z"); 
			global::android.webkit.WebSettings._getDatabaseEnabled8803 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDatabaseEnabled", "()Z"); 
			global::android.webkit.WebSettings._setGeolocationEnabled8804 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setGeolocationEnabled", "(Z)V"); 
			global::android.webkit.WebSettings._getJavaScriptEnabled8805 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getJavaScriptEnabled", "()Z"); 
			global::android.webkit.WebSettings._getPluginsEnabled8806 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getPluginsEnabled", "()Z"); 
			global::android.webkit.WebSettings._getPluginsPath8807 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getPluginsPath", "()Ljava/lang/String;"); 
			global::android.webkit.WebSettings._setJavaScriptCanOpenWindowsAutomatically8808 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setJavaScriptCanOpenWindowsAutomatically", "(Z)V"); 
			global::android.webkit.WebSettings._getJavaScriptCanOpenWindowsAutomatically8809 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getJavaScriptCanOpenWindowsAutomatically", "()Z"); 
			global::android.webkit.WebSettings._setDefaultTextEncodingName8810 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setDefaultTextEncodingName", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebSettings._getDefaultTextEncodingName8811 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getDefaultTextEncodingName", "()Ljava/lang/String;"); 
			global::android.webkit.WebSettings._setUserAgentString8812 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setUserAgentString", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebSettings._getUserAgentString8813 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getUserAgentString", "()Ljava/lang/String;"); 
			global::android.webkit.WebSettings._setNeedInitialFocus8814 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setNeedInitialFocus", "(Z)V"); 
			global::android.webkit.WebSettings._setRenderPriority8815 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setRenderPriority", "(Landroid/webkit/WebSettings$RenderPriority;)V"); 
			global::android.webkit.WebSettings._setCacheMode8816 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "setCacheMode", "(I)V"); 
			global::android.webkit.WebSettings._getCacheMode8817 = @__env.GetMethodID(global::android.webkit.WebSettings.staticClass, "getCacheMode", "()I"); 
		} 
	} 
} 
