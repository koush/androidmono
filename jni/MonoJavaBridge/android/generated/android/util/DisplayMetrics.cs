namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DisplayMetrics : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DisplayMetrics()
		{
			InitJNI();
		}
		protected DisplayMetrics(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString8488;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.DisplayMetrics._toString8488)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._toString8488)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTo8489;
		public virtual void setTo(android.util.DisplayMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.DisplayMetrics._setTo8489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._setTo8489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setToDefaults8490;
		public virtual void setToDefaults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.DisplayMetrics._setToDefaults8490);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._setToDefaults8490);
		}
		internal static global::MonoJavaBridge.MethodId _DisplayMetrics8491;
		public DisplayMetrics()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._DisplayMetrics8491);
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
		internal static global::MonoJavaBridge.FieldId _widthPixels8492;
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
		internal static global::MonoJavaBridge.FieldId _heightPixels8493;
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
		internal static global::MonoJavaBridge.FieldId _density8494;
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
		internal static global::MonoJavaBridge.FieldId _densityDpi8495;
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
		internal static global::MonoJavaBridge.FieldId _scaledDensity8496;
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
		internal static global::MonoJavaBridge.FieldId _xdpi8497;
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
		internal static global::MonoJavaBridge.FieldId _ydpi8498;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.DisplayMetrics.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/DisplayMetrics"));
			global::android.util.DisplayMetrics._toString8488 = @__env.GetMethodIDNoThrow(global::android.util.DisplayMetrics.staticClass, "toString", "()Ljava/lang/String;");
			global::android.util.DisplayMetrics._setTo8489 = @__env.GetMethodIDNoThrow(global::android.util.DisplayMetrics.staticClass, "setTo", "(Landroid/util/DisplayMetrics;)V");
			global::android.util.DisplayMetrics._setToDefaults8490 = @__env.GetMethodIDNoThrow(global::android.util.DisplayMetrics.staticClass, "setToDefaults", "()V");
			global::android.util.DisplayMetrics._DisplayMetrics8491 = @__env.GetMethodIDNoThrow(global::android.util.DisplayMetrics.staticClass, "<init>", "()V");
		}
	}
}
