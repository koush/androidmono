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
		internal static global::MonoJavaBridge.MethodId _toString13670;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.util.DisplayMetrics._toString13670)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._toString13670)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTo13671;
		public virtual void setTo(android.util.DisplayMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.DisplayMetrics._setTo13671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._setTo13671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setToDefaults13672;
		public virtual void setToDefaults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.DisplayMetrics._setToDefaults13672);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._setToDefaults13672);
		}
		internal static global::MonoJavaBridge.MethodId _DisplayMetrics13673;
		public DisplayMetrics()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._DisplayMetrics13673);
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
		internal static global::MonoJavaBridge.FieldId _widthPixels13678;
		public int widthPixels
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _widthPixels13678);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _heightPixels13679;
		public int heightPixels
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _heightPixels13679);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _density13680;
		public float density
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _density13680);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _densityDpi13681;
		public int densityDpi
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _densityDpi13681);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _scaledDensity13682;
		public float scaledDensity
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _scaledDensity13682);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _xdpi13683;
		public float xdpi
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _xdpi13683);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ydpi13684;
		public float ydpi
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _ydpi13684);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.DisplayMetrics.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/DisplayMetrics"));
			global::android.util.DisplayMetrics._toString13670 = @__env.GetMethodIDNoThrow(global::android.util.DisplayMetrics.staticClass, "toString", "()Ljava/lang/String;");
			global::android.util.DisplayMetrics._setTo13671 = @__env.GetMethodIDNoThrow(global::android.util.DisplayMetrics.staticClass, "setTo", "(Landroid/util/DisplayMetrics;)V");
			global::android.util.DisplayMetrics._setToDefaults13672 = @__env.GetMethodIDNoThrow(global::android.util.DisplayMetrics.staticClass, "setToDefaults", "()V");
			global::android.util.DisplayMetrics._DisplayMetrics13673 = @__env.GetMethodIDNoThrow(global::android.util.DisplayMetrics.staticClass, "<init>", "()V");
			global::android.util.DisplayMetrics._widthPixels13678 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "widthPixels", "I");
			global::android.util.DisplayMetrics._heightPixels13679 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "heightPixels", "I");
			global::android.util.DisplayMetrics._density13680 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "density", "F");
			global::android.util.DisplayMetrics._densityDpi13681 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "densityDpi", "I");
			global::android.util.DisplayMetrics._scaledDensity13682 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "scaledDensity", "F");
			global::android.util.DisplayMetrics._xdpi13683 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "xdpi", "F");
			global::android.util.DisplayMetrics._ydpi13684 = @__env.GetFieldIDNoThrow(global::android.util.DisplayMetrics.staticClass, "ydpi", "F");
		}
	}
}
