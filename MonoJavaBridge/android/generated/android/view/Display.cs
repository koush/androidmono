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
		internal static global::MonoJavaBridge.MethodId _getWidth14014;
		public virtual int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Display.staticClass, "getWidth", "()I", ref global::android.view.Display._getWidth14014);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight14015;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Display.staticClass, "getHeight", "()I", ref global::android.view.Display._getHeight14015);
		}
		public new int Orientation
		{
			get
			{
				return getOrientation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOrientation14016;
		public virtual int getOrientation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Display.staticClass, "getOrientation", "()I", ref global::android.view.Display._getOrientation14016);
		}
		public new int DisplayId
		{
			get
			{
				return getDisplayId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayId14017;
		public virtual int getDisplayId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Display.staticClass, "getDisplayId", "()I", ref global::android.view.Display._getDisplayId14017);
		}
		public new int Rotation
		{
			get
			{
				return getRotation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRotation14018;
		public virtual int getRotation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Display.staticClass, "getRotation", "()I", ref global::android.view.Display._getRotation14018);
		}
		public new int PixelFormat
		{
			get
			{
				return getPixelFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPixelFormat14019;
		public virtual int getPixelFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Display.staticClass, "getPixelFormat", "()I", ref global::android.view.Display._getPixelFormat14019);
		}
		public new float RefreshRate
		{
			get
			{
				return getRefreshRate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRefreshRate14020;
		public virtual float getRefreshRate()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.Display.staticClass, "getRefreshRate", "()F", ref global::android.view.Display._getRefreshRate14020);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics14021;
		public virtual void getMetrics(android.util.DisplayMetrics arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Display.staticClass, "getMetrics", "(Landroid/util/DisplayMetrics;)V", ref global::android.view.Display._getMetrics14021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
