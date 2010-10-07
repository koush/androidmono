namespace android.appwidget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AppWidgetProvider : android.content.BroadcastReceiver
	{
		internal new static global::java.lang.Class staticClass;
		static AppWidgetProvider()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.appwidget.AppWidgetProvider), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _onReceive972;
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetProvider._onReceive972, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._onReceive972, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onEnabled973;
		public virtual void onEnabled(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetProvider._onEnabled973, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._onEnabled973, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDisabled974;
		public virtual void onDisabled(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetProvider._onDisabled974, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._onDisabled974, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUpdate975;
		public virtual void onUpdate(android.content.Context arg0, android.appwidget.AppWidgetManager arg1, int[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetProvider._onUpdate975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._onUpdate975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDeleted976;
		public virtual void onDeleted(android.content.Context arg0, int[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetProvider._onDeleted976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._onDeleted976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetProvider977;
		public AppWidgetProvider()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.appwidget.AppWidgetProvider.staticClass, global::android.appwidget.AppWidgetProvider._AppWidgetProvider977, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.appwidget.AppWidgetProvider.staticClass = @__class;
			global::android.appwidget.AppWidgetProvider._onReceive972 = @__env.GetMethodID(global::android.appwidget.AppWidgetProvider.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.appwidget.AppWidgetProvider._onEnabled973 = @__env.GetMethodID(global::android.appwidget.AppWidgetProvider.staticClass, "onEnabled", "(Landroid/content/Context;)V");
			global::android.appwidget.AppWidgetProvider._onDisabled974 = @__env.GetMethodID(global::android.appwidget.AppWidgetProvider.staticClass, "onDisabled", "(Landroid/content/Context;)V");
			global::android.appwidget.AppWidgetProvider._onUpdate975 = @__env.GetMethodID(global::android.appwidget.AppWidgetProvider.staticClass, "onUpdate", "(Landroid/content/Context;Landroid/appwidget/AppWidgetManager;[I)V");
			global::android.appwidget.AppWidgetProvider._onDeleted976 = @__env.GetMethodID(global::android.appwidget.AppWidgetProvider.staticClass, "onDeleted", "(Landroid/content/Context;[I)V");
			global::android.appwidget.AppWidgetProvider._AppWidgetProvider977 = @__env.GetMethodID(global::android.appwidget.AppWidgetProvider.staticClass, "<init>", "()V");
		}
	}
}
