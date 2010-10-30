namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ImageSwitcher : android.widget.ViewSwitcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ImageSwitcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int ImageResource
		{
			set
			{
				setImageResource(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setImageResource17247;
		public virtual void setImageResource(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageSwitcher._setImageResource17247.native == global::System.IntPtr.Zero)
				global::android.widget.ImageSwitcher._setImageResource17247 = @__env.GetMethodIDNoThrow(global::android.widget.ImageSwitcher.staticClass, "setImageResource", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._setImageResource17247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.net.Uri ImageURI
		{
			set
			{
				setImageURI(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setImageURI17248;
		public virtual void setImageURI(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageSwitcher._setImageURI17248.native == global::System.IntPtr.Zero)
				global::android.widget.ImageSwitcher._setImageURI17248 = @__env.GetMethodIDNoThrow(global::android.widget.ImageSwitcher.staticClass, "setImageURI", "(Landroid/net/Uri;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._setImageURI17248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable ImageDrawable
		{
			set
			{
				setImageDrawable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setImageDrawable17249;
		public virtual void setImageDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageSwitcher._setImageDrawable17249.native == global::System.IntPtr.Zero)
				global::android.widget.ImageSwitcher._setImageDrawable17249 = @__env.GetMethodIDNoThrow(global::android.widget.ImageSwitcher.staticClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._setImageDrawable17249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ImageSwitcher17250;
		public ImageSwitcher(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageSwitcher._ImageSwitcher17250.native == global::System.IntPtr.Zero)
				global::android.widget.ImageSwitcher._ImageSwitcher17250 = @__env.GetMethodIDNoThrow(global::android.widget.ImageSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._ImageSwitcher17250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSwitcher17251;
		public ImageSwitcher(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageSwitcher._ImageSwitcher17251.native == global::System.IntPtr.Zero)
				global::android.widget.ImageSwitcher._ImageSwitcher17251 = @__env.GetMethodIDNoThrow(global::android.widget.ImageSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._ImageSwitcher17251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ImageSwitcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ImageSwitcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageSwitcher"));
		}
		internal static void InitJNI()
		{
		}
	}
}
