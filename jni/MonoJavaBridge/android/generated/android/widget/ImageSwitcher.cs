namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ImageSwitcher : android.widget.ViewSwitcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ImageSwitcher()
		{
			InitJNI();
		}
		protected ImageSwitcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setImageResource11983;
		public virtual void setImageResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageSwitcher._setImageResource11983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._setImageResource11983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageURI11984;
		public virtual void setImageURI(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageSwitcher._setImageURI11984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._setImageURI11984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageDrawable11985;
		public virtual void setImageDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageSwitcher._setImageDrawable11985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._setImageDrawable11985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ImageSwitcher11986;
		public ImageSwitcher(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._ImageSwitcher11986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageSwitcher11987;
		public ImageSwitcher(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._ImageSwitcher11987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ImageSwitcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageSwitcher"));
			global::android.widget.ImageSwitcher._setImageResource11983 = @__env.GetMethodIDNoThrow(global::android.widget.ImageSwitcher.staticClass, "setImageResource", "(I)V");
			global::android.widget.ImageSwitcher._setImageURI11984 = @__env.GetMethodIDNoThrow(global::android.widget.ImageSwitcher.staticClass, "setImageURI", "(Landroid/net/Uri;)V");
			global::android.widget.ImageSwitcher._setImageDrawable11985 = @__env.GetMethodIDNoThrow(global::android.widget.ImageSwitcher.staticClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ImageSwitcher._ImageSwitcher11986 = @__env.GetMethodIDNoThrow(global::android.widget.ImageSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ImageSwitcher._ImageSwitcher11987 = @__env.GetMethodIDNoThrow(global::android.widget.ImageSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
