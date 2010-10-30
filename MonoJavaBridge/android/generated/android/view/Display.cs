namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Display : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Display(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Display.staticClass, "getWidth", "()I", ref global::android.view.Display._m0);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Display.staticClass, "getHeight", "()I", ref global::android.view.Display._m1);
		}
		public new int Orientation
		{
			get
			{
				return getOrientation();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getOrientation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Display.staticClass, "getOrientation", "()I", ref global::android.view.Display._m2);
		}
		public new int DisplayId
		{
			get
			{
				return getDisplayId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getDisplayId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Display.staticClass, "getDisplayId", "()I", ref global::android.view.Display._m3);
		}
		public new int Rotation
		{
			get
			{
				return getRotation();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getRotation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Display.staticClass, "getRotation", "()I", ref global::android.view.Display._m4);
		}
		public new int PixelFormat
		{
			get
			{
				return getPixelFormat();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getPixelFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Display.staticClass, "getPixelFormat", "()I", ref global::android.view.Display._m5);
		}
		public new float RefreshRate
		{
			get
			{
				return getRefreshRate();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual float getRefreshRate()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.Display.staticClass, "getRefreshRate", "()F", ref global::android.view.Display._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void getMetrics(android.util.DisplayMetrics arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Display.staticClass, "getMetrics", "(Landroid/util/DisplayMetrics;)V", ref global::android.view.Display._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int DEFAULT_DISPLAY
		{
			get
			{
				return 0;
			}
		}
		static Display()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Display.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Display"));
		}
		internal static void InitJNI()
		{
		}
	}
}
