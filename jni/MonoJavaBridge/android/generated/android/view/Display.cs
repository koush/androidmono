namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Display : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Display()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getWidth13949;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Display._getWidth13949);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getWidth13949);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight13950;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Display._getHeight13950);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getHeight13950);
		}
		public new int Orientation
		{
			get
			{
				return getOrientation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOrientation13951;
		public virtual int getOrientation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Display._getOrientation13951);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getOrientation13951);
		}
		public new int DisplayId
		{
			get
			{
				return getDisplayId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayId13952;
		public virtual int getDisplayId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Display._getDisplayId13952);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getDisplayId13952);
		}
		public new int Rotation
		{
			get
			{
				return getRotation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRotation13953;
		public virtual int getRotation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Display._getRotation13953);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getRotation13953);
		}
		public new int PixelFormat
		{
			get
			{
				return getPixelFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPixelFormat13954;
		public virtual int getPixelFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Display._getPixelFormat13954);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getPixelFormat13954);
		}
		public new float RefreshRate
		{
			get
			{
				return getRefreshRate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRefreshRate13955;
		public virtual float getRefreshRate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.Display._getRefreshRate13955);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getRefreshRate13955);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics13956;
		public virtual void getMetrics(android.util.DisplayMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Display._getMetrics13956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getMetrics13956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int DEFAULT_DISPLAY
		{
			get
			{
				return 0;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Display.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Display"));
			global::android.view.Display._getWidth13949 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getWidth", "()I");
			global::android.view.Display._getHeight13950 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getHeight", "()I");
			global::android.view.Display._getOrientation13951 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getOrientation", "()I");
			global::android.view.Display._getDisplayId13952 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getDisplayId", "()I");
			global::android.view.Display._getRotation13953 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getRotation", "()I");
			global::android.view.Display._getPixelFormat13954 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getPixelFormat", "()I");
			global::android.view.Display._getRefreshRate13955 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getRefreshRate", "()F");
			global::android.view.Display._getMetrics13956 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getMetrics", "(Landroid/util/DisplayMetrics;)V");
		}
	}
}
