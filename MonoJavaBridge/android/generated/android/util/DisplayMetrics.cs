namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DisplayMetrics : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DisplayMetrics(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString13734;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.util.DisplayMetrics.staticClass, "toString", "()Ljava/lang/String;", ref global::android.util.DisplayMetrics._toString13734) as java.lang.String;
		}
		public new global::android.util.DisplayMetrics To
		{
			set
			{
				setTo(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTo13735;
		public virtual void setTo(android.util.DisplayMetrics arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.DisplayMetrics.staticClass, "setTo", "(Landroid/util/DisplayMetrics;)V", ref global::android.util.DisplayMetrics._setTo13735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setToDefaults13736;
		public virtual void setToDefaults()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.DisplayMetrics.staticClass, "setToDefaults", "()V", ref global::android.util.DisplayMetrics._setToDefaults13736);
		}
		internal static global::MonoJavaBridge.MethodId _DisplayMetrics13737;
		public DisplayMetrics() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.DisplayMetrics._DisplayMetrics13737.native == global::System.IntPtr.Zero)
				global::android.util.DisplayMetrics._DisplayMetrics13737 = @__env.GetMethodIDNoThrow(global::android.util.DisplayMetrics.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._DisplayMetrics13737);
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
		internal static global::MonoJavaBridge.FieldId _widthPixels13742;
		public int widthPixels
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _widthPixels13742);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _heightPixels13743;
		public int heightPixels
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _heightPixels13743);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _density13744;
		public float density
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _density13744);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _densityDpi13745;
		public int densityDpi
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _densityDpi13745);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _scaledDensity13746;
		public float scaledDensity
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _scaledDensity13746);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _xdpi13747;
		public float xdpi
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _xdpi13747);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ydpi13748;
		public float ydpi
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _ydpi13748);
			}
			set
			{
			}
		}
		static DisplayMetrics()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.DisplayMetrics.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/DisplayMetrics"));
			global::android.util.DisplayMetrics._widthPixels13742 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "widthPixels", "I");
			global::android.util.DisplayMetrics._heightPixels13743 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "heightPixels", "I");
			global::android.util.DisplayMetrics._density13744 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "density", "F");
			global::android.util.DisplayMetrics._densityDpi13745 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "densityDpi", "I");
			global::android.util.DisplayMetrics._scaledDensity13746 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "scaledDensity", "F");
			global::android.util.DisplayMetrics._xdpi13747 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "xdpi", "F");
			global::android.util.DisplayMetrics._ydpi13748 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "ydpi", "F");
		}
		internal static void InitJNI()
		{
		}
	}
}
