namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ImageSwitcher : android.widget.ViewSwitcher
	{
		internal new static global::java.lang.Class staticClass;
		static ImageSwitcher()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ImageSwitcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ImageSwitcher(@__env);
			}
		}
		protected ImageSwitcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageResource11058;
		public virtual void setImageResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageSwitcher._setImageResource11058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._setImageResource11058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageURI11059;
		public virtual void setImageURI(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageSwitcher._setImageURI11059, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._setImageURI11059, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageDrawable11060;
		public virtual void setImageDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageSwitcher._setImageDrawable11060, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._setImageDrawable11060, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ImageSwitcher11061;
		public ImageSwitcher(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._ImageSwitcher11061, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ImageSwitcher11062;
		public ImageSwitcher(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ImageSwitcher.staticClass, global::android.widget.ImageSwitcher._ImageSwitcher11062, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ImageSwitcher.staticClass = @__class;
			global::android.widget.ImageSwitcher._setImageResource11058 = @__env.GetMethodID(global::android.widget.ImageSwitcher.staticClass, "setImageResource", "(I)V");
			global::android.widget.ImageSwitcher._setImageURI11059 = @__env.GetMethodID(global::android.widget.ImageSwitcher.staticClass, "setImageURI", "(Landroid/net/Uri;)V");
			global::android.widget.ImageSwitcher._setImageDrawable11060 = @__env.GetMethodID(global::android.widget.ImageSwitcher.staticClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ImageSwitcher._ImageSwitcher11061 = @__env.GetMethodID(global::android.widget.ImageSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ImageSwitcher._ImageSwitcher11062 = @__env.GetMethodID(global::android.widget.ImageSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
