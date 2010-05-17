namespace android.appwidget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AppWidgetHost : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AppWidgetHost() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.appwidget.AppWidgetHost), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onCreateView798; 
		protected virtual android.appwidget.AppWidgetHostView onCreateView(android.content.Context arg0, int arg1, android.appwidget.AppWidgetProviderInfo arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetHostView>(@__env, @__env.CallObjectMethodPtr(this, _onCreateView798, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetHostView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.appwidget.AppWidgetHost.staticClass, _onCreateView798, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createView799; 
		public virtual android.appwidget.AppWidgetHostView createView(android.content.Context arg0, int arg1, android.appwidget.AppWidgetProviderInfo arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetHostView>(@__env, @__env.CallObjectMethodPtr(this, _createView799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetHostView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.appwidget.AppWidgetHost.staticClass, _createView799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startListening800; 
		public virtual void startListening() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHost)) 
				@__env.CallVoidMethod(this, _startListening800); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetHost.staticClass, _startListening800); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopListening801; 
		public virtual void stopListening() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHost)) 
				@__env.CallVoidMethod(this, _stopListening801); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetHost.staticClass, _stopListening801); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocateAppWidgetId802; 
		public virtual int allocateAppWidgetId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHost)) 
				return @__env.CallIntMethod(this, _allocateAppWidgetId802); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.appwidget.AppWidgetHost.staticClass, _allocateAppWidgetId802); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteAppWidgetId803; 
		public virtual void deleteAppWidgetId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHost)) 
				@__env.CallVoidMethod(this, _deleteAppWidgetId803, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetHost.staticClass, _deleteAppWidgetId803, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteHost804; 
		public virtual void deleteHost() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHost)) 
				@__env.CallVoidMethod(this, _deleteHost804); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetHost.staticClass, _deleteHost804); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteAllHosts805; 
		public static void deleteAllHosts() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.appwidget.AppWidgetHost.staticClass, _deleteAllHosts805); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onProviderChanged806; 
		protected virtual void onProviderChanged(int arg0, android.appwidget.AppWidgetProviderInfo arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetHost)) 
				@__env.CallVoidMethod(this, _onProviderChanged806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetHost.staticClass, _onProviderChanged806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetHost807; 
		public AppWidgetHost(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.appwidget.AppWidgetHost.staticClass, _AppWidgetHost807, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.appwidget.AppWidgetHost.staticClass = @__class; 
			global::android.appwidget.AppWidgetHost._onCreateView798 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "onCreateView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/appwidget/AppWidgetHostView;"); 
			global::android.appwidget.AppWidgetHost._createView799 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "createView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/appwidget/AppWidgetHostView;"); 
			global::android.appwidget.AppWidgetHost._startListening800 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "startListening", "()V"); 
			global::android.appwidget.AppWidgetHost._stopListening801 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "stopListening", "()V"); 
			global::android.appwidget.AppWidgetHost._allocateAppWidgetId802 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "allocateAppWidgetId", "()I"); 
			global::android.appwidget.AppWidgetHost._deleteAppWidgetId803 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "deleteAppWidgetId", "(I)V"); 
			global::android.appwidget.AppWidgetHost._deleteHost804 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "deleteHost", "()V"); 
			global::android.appwidget.AppWidgetHost._deleteAllHosts805 = @__env.GetStaticMethodID(global::android.appwidget.AppWidgetHost.staticClass, "deleteAllHosts", "()V"); 
			global::android.appwidget.AppWidgetHost._onProviderChanged806 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "onProviderChanged", "(ILandroid/appwidget/AppWidgetProviderInfo;)V"); 
			global::android.appwidget.AppWidgetHost._AppWidgetHost807 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
		} 
	} 
} 
