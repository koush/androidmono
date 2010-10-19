namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class QuickContactBadge : android.widget.ImageView, android.view.View.OnClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static QuickContactBadge()
		{
			InitJNI();
		}
		protected QuickContactBadge(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setMode12250;
		public virtual void setMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._setMode12250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._setMode12250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onClick12251;
		public virtual void onClick(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._onClick12251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._onClick12251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assignContactUri12252;
		public virtual void assignContactUri(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._assignContactUri12252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._assignContactUri12252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assignContactFromEmail12253;
		public virtual void assignContactFromEmail(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._assignContactFromEmail12253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._assignContactFromEmail12253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assignContactFromPhone12254;
		public virtual void assignContactFromPhone(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._assignContactFromPhone12254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._assignContactFromPhone12254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setExcludeMimes12255;
		public virtual void setExcludeMimes(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._setExcludeMimes12255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._setExcludeMimes12255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _QuickContactBadge12256;
		public QuickContactBadge(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._QuickContactBadge12256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _QuickContactBadge12257;
		public QuickContactBadge(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._QuickContactBadge12257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _QuickContactBadge12258;
		public QuickContactBadge(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._QuickContactBadge12258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.QuickContactBadge.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/QuickContactBadge"));
			global::android.widget.QuickContactBadge._setMode12250 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "setMode", "(I)V");
			global::android.widget.QuickContactBadge._onClick12251 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.widget.QuickContactBadge._assignContactUri12252 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "assignContactUri", "(Landroid/net/Uri;)V");
			global::android.widget.QuickContactBadge._assignContactFromEmail12253 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "assignContactFromEmail", "(Ljava/lang/String;Z)V");
			global::android.widget.QuickContactBadge._assignContactFromPhone12254 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "assignContactFromPhone", "(Ljava/lang/String;Z)V");
			global::android.widget.QuickContactBadge._setExcludeMimes12255 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "setExcludeMimes", "([Ljava/lang/String;)V");
			global::android.widget.QuickContactBadge._QuickContactBadge12256 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.QuickContactBadge._QuickContactBadge12257 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.QuickContactBadge._QuickContactBadge12258 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
