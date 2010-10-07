namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class QuickContactBadge : android.widget.ImageView, android.view.View.OnClickListener
	{
		internal new static global::java.lang.Class staticClass;
		static QuickContactBadge()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.QuickContactBadge), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.QuickContactBadge(@__env);
			}
		}
		protected QuickContactBadge(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMode11325;
		public virtual void setMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.QuickContactBadge._setMode11325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._setMode11325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onClick11326;
		public virtual void onClick(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.QuickContactBadge._onClick11326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._onClick11326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _assignContactUri11327;
		public virtual void assignContactUri(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.QuickContactBadge._assignContactUri11327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._assignContactUri11327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _assignContactFromEmail11328;
		public virtual void assignContactFromEmail(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.QuickContactBadge._assignContactFromEmail11328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._assignContactFromEmail11328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _assignContactFromPhone11329;
		public virtual void assignContactFromPhone(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.QuickContactBadge._assignContactFromPhone11329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._assignContactFromPhone11329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setExcludeMimes11330;
		public virtual void setExcludeMimes(java.lang.String[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.QuickContactBadge._setExcludeMimes11330, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._setExcludeMimes11330, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _QuickContactBadge11331;
		public QuickContactBadge(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._QuickContactBadge11331, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _QuickContactBadge11332;
		public QuickContactBadge(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._QuickContactBadge11332, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _QuickContactBadge11333;
		public QuickContactBadge(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.QuickContactBadge.staticClass, global::android.widget.QuickContactBadge._QuickContactBadge11333, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.QuickContactBadge.staticClass = @__class;
			global::android.widget.QuickContactBadge._setMode11325 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "setMode", "(I)V");
			global::android.widget.QuickContactBadge._onClick11326 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.widget.QuickContactBadge._assignContactUri11327 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "assignContactUri", "(Landroid/net/Uri;)V");
			global::android.widget.QuickContactBadge._assignContactFromEmail11328 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "assignContactFromEmail", "(Ljava/lang/String;Z)V");
			global::android.widget.QuickContactBadge._assignContactFromPhone11329 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "assignContactFromPhone", "(Ljava/lang/String;Z)V");
			global::android.widget.QuickContactBadge._setExcludeMimes11330 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "setExcludeMimes", "([Ljava/lang/String;)V");
			global::android.widget.QuickContactBadge._QuickContactBadge11331 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.QuickContactBadge._QuickContactBadge11332 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.QuickContactBadge._QuickContactBadge11333 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
