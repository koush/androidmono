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
		internal static global::MonoJavaBridge.MethodId _setMode17523;
		public virtual void setMode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._setMode17523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._setMode17523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onClick17524;
		public virtual void onClick(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._onClick17524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._onClick17524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assignContactUri17525;
		public virtual void assignContactUri(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._assignContactUri17525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._assignContactUri17525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assignContactFromEmail17526;
		public virtual void assignContactFromEmail(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._assignContactFromEmail17526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._assignContactFromEmail17526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assignContactFromPhone17527;
		public virtual void assignContactFromPhone(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._assignContactFromPhone17527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._assignContactFromPhone17527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String[] ExcludeMimes
		{
			set
			{
				setExcludeMimes(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setExcludeMimes17528;
		public virtual void setExcludeMimes(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge._setExcludeMimes17528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._setExcludeMimes17528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _QuickContactBadge17529;
		public QuickContactBadge(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._QuickContactBadge17529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _QuickContactBadge17530;
		public QuickContactBadge(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._QuickContactBadge17530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _QuickContactBadge17531;
		public QuickContactBadge(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._QuickContactBadge17531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static QuickContactBadge()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.QuickContactBadge.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/QuickContactBadge"));
			global::android.widget.QuickContactBadge._setMode17523 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "setMode", "(I)V");
			global::android.widget.QuickContactBadge._onClick17524 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.widget.QuickContactBadge._assignContactUri17525 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "assignContactUri", "(Landroid/net/Uri;)V");
			global::android.widget.QuickContactBadge._assignContactFromEmail17526 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "assignContactFromEmail", "(Ljava/lang/String;Z)V");
			global::android.widget.QuickContactBadge._assignContactFromPhone17527 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "assignContactFromPhone", "(Ljava/lang/String;Z)V");
			global::android.widget.QuickContactBadge._setExcludeMimes17528 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "setExcludeMimes", "([Ljava/lang/String;)V");
			global::android.widget.QuickContactBadge._QuickContactBadge17529 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.QuickContactBadge._QuickContactBadge17530 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.QuickContactBadge._QuickContactBadge17531 = @__env.GetMethodIDNoThrow(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
