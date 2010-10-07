namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DisplayMetrics : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static DisplayMetrics()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.DisplayMetrics), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _toString8184;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.DisplayMetrics._toString8184));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._toString8184));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTo8185;
		public virtual void setTo(android.util.DisplayMetrics arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.DisplayMetrics._setTo8185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._setTo8185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setToDefaults8186;
		public virtual void setToDefaults() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.DisplayMetrics._setToDefaults8186);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._setToDefaults8186);
		}
		internal static global::net.sf.jni4net.jni.MethodId _DisplayMetrics8187;
		public DisplayMetrics()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.DisplayMetrics.staticClass, global::android.util.DisplayMetrics._DisplayMetrics8187, this);
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
		internal static global::net.sf.jni4net.jni.FieldId _widthPixels8188;
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
		internal static global::net.sf.jni4net.jni.FieldId _heightPixels8189;
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
		internal static global::net.sf.jni4net.jni.FieldId _density8190;
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
		internal static global::net.sf.jni4net.jni.FieldId _densityDpi8191;
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
		internal static global::net.sf.jni4net.jni.FieldId _scaledDensity8192;
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
		internal static global::net.sf.jni4net.jni.FieldId _xdpi8193;
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
		internal static global::net.sf.jni4net.jni.FieldId _ydpi8194;
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
			global::android.util.DisplayMetrics._toString8184 = @__env.GetMethodID(global::android.util.DisplayMetrics.staticClass, "toString", "()Ljava/lang/String;");
			global::android.util.DisplayMetrics._setTo8185 = @__env.GetMethodID(global::android.util.DisplayMetrics.staticClass, "setTo", "(Landroid/util/DisplayMetrics;)V");
			global::android.util.DisplayMetrics._setToDefaults8186 = @__env.GetMethodID(global::android.util.DisplayMetrics.staticClass, "setToDefaults", "()V");
			global::android.util.DisplayMetrics._DisplayMetrics8187 = @__env.GetMethodID(global::android.util.DisplayMetrics.staticClass, "<init>", "()V");
		}
	}
}
