namespace android.appwidget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AppWidgetProvider : android.content.BroadcastReceiver
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AppWidgetProvider() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.appwidget.AppWidgetProvider), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.appwidget.AppWidgetProvider(@__env); 
			} 
		} 
		protected AppWidgetProvider(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceive829; 
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetProvider)) 
				@__env.CallVoidMethod(this, _onReceive829, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetProvider.staticClass, _onReceive829, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpdate830; 
		public virtual void onUpdate(android.content.Context arg0, android.appwidget.AppWidgetManager arg1, int[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetProvider)) 
				@__env.CallVoidMethod(this, _onUpdate830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetProvider.staticClass, _onUpdate830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDeleted831; 
		public virtual void onDeleted(android.content.Context arg0, int[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetProvider)) 
				@__env.CallVoidMethod(this, _onDeleted831, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetProvider.staticClass, _onDeleted831, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onEnabled832; 
		public virtual void onEnabled(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetProvider)) 
				@__env.CallVoidMethod(this, _onEnabled832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetProvider.staticClass, _onEnabled832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDisabled833; 
		public virtual void onDisabled(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetProvider)) 
				@__env.CallVoidMethod(this, _onDisabled833, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetProvider.staticClass, _onDisabled833, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetProvider834; 
		public AppWidgetProvider()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.appwidget.AppWidgetProvider.staticClass, _AppWidgetProvider834, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.appwidget.AppWidgetProvider.staticClass = @__class; 
			global::android.appwidget.AppWidgetProvider._onReceive829 = @__env.GetMethodID(global::android.appwidget.AppWidgetProvider.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"); 
			global::android.appwidget.AppWidgetProvider._onUpdate830 = @__env.GetMethodID(global::android.appwidget.AppWidgetProvider.staticClass, "onUpdate", "(Landroid/content/Context;Landroid/appwidget/AppWidgetManager;[I)V"); 
			global::android.appwidget.AppWidgetProvider._onDeleted831 = @__env.GetMethodID(global::android.appwidget.AppWidgetProvider.staticClass, "onDeleted", "(Landroid/content/Context;[I)V"); 
			global::android.appwidget.AppWidgetProvider._onEnabled832 = @__env.GetMethodID(global::android.appwidget.AppWidgetProvider.staticClass, "onEnabled", "(Landroid/content/Context;)V"); 
			global::android.appwidget.AppWidgetProvider._onDisabled833 = @__env.GetMethodID(global::android.appwidget.AppWidgetProvider.staticClass, "onDisabled", "(Landroid/content/Context;)V"); 
			global::android.appwidget.AppWidgetProvider._AppWidgetProvider834 = @__env.GetMethodID(global::android.appwidget.AppWidgetProvider.staticClass, "<init>", "()V"); 
		} 
	} 
} 
