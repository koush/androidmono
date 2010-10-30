namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DisplayMetrics : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DisplayMetrics(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.util.DisplayMetrics.staticClass, "toString", "()Ljava/lang/String;", ref global::android.util.DisplayMetrics._m0) as java.lang.String;
		}
		public new global::android.util.DisplayMetrics To
		{
			set
			{
				setTo(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setTo(android.util.DisplayMetrics arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.DisplayMetrics.staticClass, "setTo", "(Landroid/util/DisplayMetrics;)V", ref global::android.util.DisplayMetrics._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setToDefaults()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.DisplayMetrics.staticClass, "setToDefaults", "()V", ref global::android.util.DisplayMetrics._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public DisplayMetrics() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.DisplayMetrics._m3.native == global::System.IntPtr.Zero)
				global::android.util.DisplayMetrics._m3 = @__env.GetMethodIDNoThrow(global::android.util.DisplayMetrics.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._m3);
			Init(@__env, handle);
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
		internal static global::MonoJavaBridge.FieldId _widthPixels5385;
		public int widthPixels
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _widthPixels5385);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _heightPixels5386;
		public int heightPixels
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _heightPixels5386);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _density5387;
		public float density
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _density5387);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _densityDpi5388;
		public int densityDpi
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _densityDpi5388);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _scaledDensity5389;
		public float scaledDensity
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _scaledDensity5389);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _xdpi5390;
		public float xdpi
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _xdpi5390);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ydpi5391;
		public float ydpi
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _ydpi5391);
			}
			set
			{
			}
		}
		static DisplayMetrics()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.DisplayMetrics.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/DisplayMetrics"));
			global::android.util.DisplayMetrics._widthPixels5385 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "widthPixels", "I");
			global::android.util.DisplayMetrics._heightPixels5386 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "heightPixels", "I");
			global::android.util.DisplayMetrics._density5387 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "density", "F");
			global::android.util.DisplayMetrics._densityDpi5388 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "densityDpi", "I");
			global::android.util.DisplayMetrics._scaledDensity5389 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "scaledDensity", "F");
			global::android.util.DisplayMetrics._xdpi5390 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "xdpi", "F");
			global::android.util.DisplayMetrics._ydpi5391 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "ydpi", "F");
		}
		internal static void InitJNI()
		{
		}
	}
}
