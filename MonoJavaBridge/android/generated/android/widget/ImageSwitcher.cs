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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setImageResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageSwitcher.staticClass, "setImageResource", "(I)V", ref global::android.widget.ImageSwitcher._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.net.Uri ImageURI
		{
			set
			{
				setImageURI(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setImageURI(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageSwitcher.staticClass, "setImageURI", "(Landroid/net/Uri;)V", ref global::android.widget.ImageSwitcher._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable ImageDrawable
		{
			set
			{
				setImageDrawable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setImageDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageSwitcher.staticClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.ImageSwitcher._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ImageSwitcher(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageSwitcher._m3.native == global::System.IntPtr.Zero)
				global::android.widget.ImageSwitcher._m3 = @__env.GetMethodIDNoThrow(global::android.widget.ImageSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ImageSwitcher(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageSwitcher._m4.native == global::System.IntPtr.Zero)
				global::android.widget.ImageSwitcher._m4 = @__env.GetMethodIDNoThrow(global::android.widget.ImageSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
