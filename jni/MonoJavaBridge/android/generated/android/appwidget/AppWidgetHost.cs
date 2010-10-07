namespace android.appwidget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AppWidgetHost : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static AppWidgetHost()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.appwidget.AppWidgetHost), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.appwidget.AppWidgetHost(@__env);
			}
		}
		protected AppWidgetHost(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateView941;
		protected virtual global::android.appwidget.AppWidgetHostView onCreateView(android.content.Context arg0, int arg1, android.appwidget.AppWidgetProviderInfo arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetHostView>(@__env, @__env.CallObjectMethodPtr(this, global::android.appwidget.AppWidgetHost._onCreateView941, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetHostView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._onCreateView941, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createView942;
		public virtual global::android.appwidget.AppWidgetHostView createView(android.content.Context arg0, int arg1, android.appwidget.AppWidgetProviderInfo arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetHostView>(@__env, @__env.CallObjectMethodPtr(this, global::android.appwidget.AppWidgetHost._createView942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetHostView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._createView942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startListening943;
		public virtual void startListening() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHost._startListening943);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._startListening943);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopListening944;
		public virtual void stopListening() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHost._stopListening944);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._stopListening944);
		}
		internal static global::net.sf.jni4net.jni.MethodId _allocateAppWidgetId945;
		public virtual int allocateAppWidgetId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.appwidget.AppWidgetHost._allocateAppWidgetId945);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._allocateAppWidgetId945);
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteAppWidgetId946;
		public virtual void deleteAppWidgetId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHost._deleteAppWidgetId946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._deleteAppWidgetId946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteHost947;
		public virtual void deleteHost() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHost._deleteHost947);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._deleteHost947);
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteAllHosts948;
		public static void deleteAllHosts() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._deleteAllHosts948);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onProviderChanged949;
		protected virtual void onProviderChanged(int arg0, android.appwidget.AppWidgetProviderInfo arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHost._onProviderChanged949, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._onProviderChanged949, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetHost950;
		public AppWidgetHost(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._AppWidgetHost950, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.appwidget.AppWidgetHost.staticClass = @__class;
			global::android.appwidget.AppWidgetHost._onCreateView941 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "onCreateView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/appwidget/AppWidgetHostView;");
			global::android.appwidget.AppWidgetHost._createView942 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "createView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/appwidget/AppWidgetHostView;");
			global::android.appwidget.AppWidgetHost._startListening943 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "startListening", "()V");
			global::android.appwidget.AppWidgetHost._stopListening944 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "stopListening", "()V");
			global::android.appwidget.AppWidgetHost._allocateAppWidgetId945 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "allocateAppWidgetId", "()I");
			global::android.appwidget.AppWidgetHost._deleteAppWidgetId946 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "deleteAppWidgetId", "(I)V");
			global::android.appwidget.AppWidgetHost._deleteHost947 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "deleteHost", "()V");
			global::android.appwidget.AppWidgetHost._deleteAllHosts948 = @__env.GetStaticMethodID(global::android.appwidget.AppWidgetHost.staticClass, "deleteAllHosts", "()V");
			global::android.appwidget.AppWidgetHost._onProviderChanged949 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "onProviderChanged", "(ILandroid/appwidget/AppWidgetProviderInfo;)V");
			global::android.appwidget.AppWidgetHost._AppWidgetHost950 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
	}
}
