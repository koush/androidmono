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
		internal static global::MonoJavaBridge.MethodId _setMode17418;
		public virtual void setMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._setMode17418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._setMode17418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onClick17419;
		public virtual void onClick(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._onClick17419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._onClick17419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assignContactUri17420;
		public virtual void assignContactUri(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._assignContactUri17420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._assignContactUri17420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assignContactFromEmail17421;
		public virtual void assignContactFromEmail(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._assignContactFromEmail17421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._assignContactFromEmail17421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assignContactFromPhone17422;
		public virtual void assignContactFromPhone(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._assignContactFromPhone17422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._assignContactFromPhone17422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setExcludeMimes17423;
		public virtual void setExcludeMimes(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._setExcludeMimes17423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._setExcludeMimes17423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _QuickContactBadge17424;
		public QuickContactBadge(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._QuickContactBadge17424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _QuickContactBadge17425;
		public QuickContactBadge(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._QuickContactBadge17425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _QuickContactBadge17426;
		public QuickContactBadge(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._QuickContactBadge17426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.QuickContactBadge.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/QuickContactBadge"));
			global::android.widget.QuickContactBadge._setMode17418 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "setMode", "(I)V");
			global::android.widget.QuickContactBadge._onClick17419 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.widget.QuickContactBadge._assignContactUri17420 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "assignContactUri", "(Landroid/net/Uri;)V");
			global::android.widget.QuickContactBadge._assignContactFromEmail17421 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "assignContactFromEmail", "(Ljava/lang/String;Z)V");
			global::android.widget.QuickContactBadge._assignContactFromPhone17422 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "assignContactFromPhone", "(Ljava/lang/String;Z)V");
			global::android.widget.QuickContactBadge._setExcludeMimes17423 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "setExcludeMimes", "([Ljava/lang/String;)V");
			global::android.widget.QuickContactBadge._QuickContactBadge17424 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.QuickContactBadge._QuickContactBadge17425 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.QuickContactBadge._QuickContactBadge17426 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
