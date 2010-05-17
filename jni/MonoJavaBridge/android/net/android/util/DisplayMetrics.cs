namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DisplayMetrics : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static DisplayMetrics() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.DisplayMetrics), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.DisplayMetrics(@__env); 
			} 
		} 
		protected DisplayMetrics(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString7132; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.DisplayMetrics)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString7132)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.util.DisplayMetrics.staticClass, _toString7132)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setToDefaults7133; 
		public virtual void setToDefaults() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.DisplayMetrics)) 
				@__env.CallVoidMethod(this, _setToDefaults7133); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.DisplayMetrics.staticClass, _setToDefaults7133); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTo7134; 
		public virtual void setTo(android.util.DisplayMetrics arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.DisplayMetrics)) 
				@__env.CallVoidMethod(this, _setTo7134, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.DisplayMetrics.staticClass, _setTo7134, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DisplayMetrics7135; 
		public DisplayMetrics()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.DisplayMetrics.staticClass, _DisplayMetrics7135, this); 
		} 
		public static int DENSITY_LOW
		{ 
			get 
			{ 
				return 120; 
			} 
		} 
		public static int DENSITY_MEDIUM
		{ 
			get 
			{ 
				return 160; 
			} 
		} 
		public static int DENSITY_HIGH
		{ 
			get 
			{ 
				return 240; 
			} 
		} 
		public static int DENSITY_DEFAULT
		{ 
			get 
			{ 
				return 160; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _widthPixels7136; 
		public int widthPixels
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _heightPixels7137; 
		public int heightPixels
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _density7138; 
		public float density
		{ 
			get 
			{ 
				return default(float); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _densityDpi7139; 
		public int densityDpi
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _scaledDensity7140; 
		public float scaledDensity
		{ 
			get 
			{ 
				return default(float); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _xdpi7141; 
		public float xdpi
		{ 
			get 
			{ 
				return default(float); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ydpi7142; 
		public float ydpi
		{ 
			get 
			{ 
				return default(float); 
			} 
			set 
			{ 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.DisplayMetrics.staticClass = @__class; 
			global::android.util.DisplayMetrics._toString7132 = @__env.GetMethodID(global::android.util.DisplayMetrics.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.util.DisplayMetrics._setToDefaults7133 = @__env.GetMethodID(global::android.util.DisplayMetrics.staticClass, "setToDefaults", "()V"); 
			global::android.util.DisplayMetrics._setTo7134 = @__env.GetMethodID(global::android.util.DisplayMetrics.staticClass, "setTo", "(Landroid/util/DisplayMetrics;)V"); 
			global::android.util.DisplayMetrics._DisplayMetrics7135 = @__env.GetMethodID(global::android.util.DisplayMetrics.staticClass, "<init>", "()V"); 
		} 
	} 
} 
