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
		internal static global::MonoJavaBridge.MethodId _getWidth8716;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Display._getWidth8716);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getWidth8716);
		}
		internal static global::MonoJavaBridge.MethodId _getHeight8717;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Display._getHeight8717);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getHeight8717);
		}
		internal static global::MonoJavaBridge.MethodId _getOrientation8718;
		public virtual int getOrientation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Display._getOrientation8718);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getOrientation8718);
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayId8719;
		public virtual int getDisplayId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Display._getDisplayId8719);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getDisplayId8719);
		}
		internal static global::MonoJavaBridge.MethodId _getRotation8720;
		public virtual int getRotation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Display._getRotation8720);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getRotation8720);
		}
		internal static global::MonoJavaBridge.MethodId _getPixelFormat8721;
		public virtual int getPixelFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Display._getPixelFormat8721);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getPixelFormat8721);
		}
		internal static global::MonoJavaBridge.MethodId _getRefreshRate8722;
		public virtual float getRefreshRate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.Display._getRefreshRate8722);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getRefreshRate8722);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics8723;
		public virtual void getMetrics(android.util.DisplayMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Display._getMetrics8723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Display.staticClass, global::android.view.Display._getMetrics8723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.view.Display._getWidth8716 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getWidth", "()I");
			global::android.view.Display._getHeight8717 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getHeight", "()I");
			global::android.view.Display._getOrientation8718 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getOrientation", "()I");
			global::android.view.Display._getDisplayId8719 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getDisplayId", "()I");
			global::android.view.Display._getRotation8720 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getRotation", "()I");
			global::android.view.Display._getPixelFormat8721 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getPixelFormat", "()I");
			global::android.view.Display._getRefreshRate8722 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getRefreshRate", "()F");
			global::android.view.Display._getMetrics8723 = @__env.GetMethodIDNoThrow(global::android.view.Display.staticClass, "getMetrics", "(Landroid/util/DisplayMetrics;)V");
		}
	}
}
