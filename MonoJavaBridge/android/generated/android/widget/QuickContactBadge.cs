namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class QuickContactBadge : android.widget.ImageView, android.view.View.OnClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected QuickContactBadge(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Mode
		{
			set
			{
				setMode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.QuickContactBadge.staticClass, "setMode", "(I)V", ref global::android.widget.QuickContactBadge._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onClick(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.QuickContactBadge.staticClass, "onClick", "(Landroid/view/View;)V", ref global::android.widget.QuickContactBadge._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void assignContactUri(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.QuickContactBadge.staticClass, "assignContactUri", "(Landroid/net/Uri;)V", ref global::android.widget.QuickContactBadge._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void assignContactFromEmail(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.QuickContactBadge.staticClass, "assignContactFromEmail", "(Ljava/lang/String;Z)V", ref global::android.widget.QuickContactBadge._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void assignContactFromPhone(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.QuickContactBadge.staticClass, "assignContactFromPhone", "(Ljava/lang/String;Z)V", ref global::android.widget.QuickContactBadge._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String[] ExcludeMimes
		{
			set
			{
				setExcludeMimes(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setExcludeMimes(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.QuickContactBadge.staticClass, "setExcludeMimes", "([Ljava/lang/String;)V", ref global::android.widget.QuickContactBadge._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public QuickContactBadge(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.QuickContactBadge._m6.native == global::System.IntPtr.Zero)
				global::android.widget.QuickContactBadge._m6 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public QuickContactBadge(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.QuickContactBadge._m7.native == global::System.IntPtr.Zero)
				global::android.widget.QuickContactBadge._m7 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public QuickContactBadge(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.QuickContactBadge._m8.native == global::System.IntPtr.Zero)
				global::android.widget.QuickContactBadge._m8 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static QuickContactBadge()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.QuickContactBadge.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/QuickContactBadge"));
		}
	}
}
