namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetHost : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AppWidgetHost()
		{
			InitJNI();
		}
		protected AppWidgetHost(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreateView956;
		protected virtual global::android.appwidget.AppWidgetHostView onCreateView(android.content.Context arg0, int arg1, android.appwidget.AppWidgetProviderInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._onCreateView956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.appwidget.AppWidgetHostView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._onCreateView956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.appwidget.AppWidgetHostView;
		}
		internal static global::MonoJavaBridge.MethodId _createView957;
		public virtual global::android.appwidget.AppWidgetHostView createView(android.content.Context arg0, int arg1, android.appwidget.AppWidgetProviderInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._createView957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.appwidget.AppWidgetHostView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._createView957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.appwidget.AppWidgetHostView;
		}
		internal static global::MonoJavaBridge.MethodId _startListening958;
		public virtual void startListening() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._startListening958);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._startListening958);
		}
		internal static global::MonoJavaBridge.MethodId _stopListening959;
		public virtual void stopListening() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._stopListening959);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._stopListening959);
		}
		internal static global::MonoJavaBridge.MethodId _allocateAppWidgetId960;
		public virtual int allocateAppWidgetId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._allocateAppWidgetId960);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._allocateAppWidgetId960);
		}
		internal static global::MonoJavaBridge.MethodId _deleteAppWidgetId961;
		public virtual void deleteAppWidgetId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._deleteAppWidgetId961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._deleteAppWidgetId961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteHost962;
		public virtual void deleteHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._deleteHost962);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._deleteHost962);
		}
		internal static global::MonoJavaBridge.MethodId _deleteAllHosts963;
		public static void deleteAllHosts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._deleteAllHosts963);
		}
		internal static global::MonoJavaBridge.MethodId _onProviderChanged964;
		protected virtual void onProviderChanged(int arg0, android.appwidget.AppWidgetProviderInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._onProviderChanged964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._onProviderChanged964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetHost965;
		public AppWidgetHost(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._AppWidgetHost965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.appwidget.AppWidgetHost.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/appwidget/AppWidgetHost"));
			global::android.appwidget.AppWidgetHost._onCreateView956 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "onCreateView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/appwidget/AppWidgetHostView;");
			global::android.appwidget.AppWidgetHost._createView957 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "createView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/appwidget/AppWidgetHostView;");
			global::android.appwidget.AppWidgetHost._startListening958 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "startListening", "()V");
			global::android.appwidget.AppWidgetHost._stopListening959 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "stopListening", "()V");
			global::android.appwidget.AppWidgetHost._allocateAppWidgetId960 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "allocateAppWidgetId", "()I");
			global::android.appwidget.AppWidgetHost._deleteAppWidgetId961 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "deleteAppWidgetId", "(I)V");
			global::android.appwidget.AppWidgetHost._deleteHost962 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "deleteHost", "()V");
			global::android.appwidget.AppWidgetHost._deleteAllHosts963 = @__env.GetStaticMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "deleteAllHosts", "()V");
			global::android.appwidget.AppWidgetHost._onProviderChanged964 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "onProviderChanged", "(ILandroid/appwidget/AppWidgetProviderInfo;)V");
			global::android.appwidget.AppWidgetHost._AppWidgetHost965 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
	}
}
