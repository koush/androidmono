namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class QuickContactBadge : android.widget.ImageView, android.view.View.OnClickListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static QuickContactBadge() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.QuickContactBadge), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _setMode9844; 
		public virtual void setMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.QuickContactBadge)) 
				@__env.CallVoidMethod(this, _setMode9844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.QuickContactBadge.staticClass, _setMode9844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick9845; 
		public virtual void onClick(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.QuickContactBadge)) 
				@__env.CallVoidMethod(this, _onClick9845, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.QuickContactBadge.staticClass, _onClick9845, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _assignContactUri9846; 
		public virtual void assignContactUri(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.QuickContactBadge)) 
				@__env.CallVoidMethod(this, _assignContactUri9846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.QuickContactBadge.staticClass, _assignContactUri9846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _assignContactFromEmail9847; 
		public virtual void assignContactFromEmail(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.QuickContactBadge)) 
				@__env.CallVoidMethod(this, _assignContactFromEmail9847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.QuickContactBadge.staticClass, _assignContactFromEmail9847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _assignContactFromPhone9848; 
		public virtual void assignContactFromPhone(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.QuickContactBadge)) 
				@__env.CallVoidMethod(this, _assignContactFromPhone9848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.QuickContactBadge.staticClass, _assignContactFromPhone9848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExcludeMimes9849; 
		public virtual void setExcludeMimes(java.lang.String[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.QuickContactBadge)) 
				@__env.CallVoidMethod(this, _setExcludeMimes9849, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.QuickContactBadge.staticClass, _setExcludeMimes9849, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _QuickContactBadge9850; 
		public QuickContactBadge(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.QuickContactBadge.staticClass, _QuickContactBadge9850, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _QuickContactBadge9851; 
		public QuickContactBadge(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.QuickContactBadge.staticClass, _QuickContactBadge9851, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _QuickContactBadge9852; 
		public QuickContactBadge(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.QuickContactBadge.staticClass, _QuickContactBadge9852, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.QuickContactBadge.staticClass = @__class; 
			global::android.widget.QuickContactBadge._setMode9844 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "setMode", "(I)V"); 
			global::android.widget.QuickContactBadge._onClick9845 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "onClick", "(Landroid/view/View;)V"); 
			global::android.widget.QuickContactBadge._assignContactUri9846 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "assignContactUri", "(Landroid/net/Uri;)V"); 
			global::android.widget.QuickContactBadge._assignContactFromEmail9847 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "assignContactFromEmail", "(Ljava/lang/String;Z)V"); 
			global::android.widget.QuickContactBadge._assignContactFromPhone9848 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "assignContactFromPhone", "(Ljava/lang/String;Z)V"); 
			global::android.widget.QuickContactBadge._setExcludeMimes9849 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "setExcludeMimes", "([Ljava/lang/String;)V"); 
			global::android.widget.QuickContactBadge._QuickContactBadge9850 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.QuickContactBadge._QuickContactBadge9851 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.QuickContactBadge._QuickContactBadge9852 = @__env.GetMethodID(global::android.widget.QuickContactBadge.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
