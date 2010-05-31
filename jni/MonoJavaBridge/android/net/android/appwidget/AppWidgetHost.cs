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
		internal static global::net.sf.jni4net.jni.MethodId _onCreateView811; 
		protected virtual global::android.appwidget.AppWidgetHostView onCreateView(android.content.Context arg0, int arg1, android.appwidget.AppWidgetProviderInfo arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetHostView>(@__env, @__env.CallObjectMethodPtr(this, global::android.appwidget.AppWidgetHost._onCreateView811, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetHostView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._onCreateView811, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createView812; 
		public virtual global::android.appwidget.AppWidgetHostView createView(android.content.Context arg0, int arg1, android.appwidget.AppWidgetProviderInfo arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetHostView>(@__env, @__env.CallObjectMethodPtr(this, global::android.appwidget.AppWidgetHost._createView812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetHostView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._createView812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startListening813; 
		public virtual void startListening() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHost._startListening813); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._startListening813); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopListening814; 
		public virtual void stopListening() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHost._stopListening814); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._stopListening814); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocateAppWidgetId815; 
		public virtual int allocateAppWidgetId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.appwidget.AppWidgetHost._allocateAppWidgetId815); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._allocateAppWidgetId815); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteAppWidgetId816; 
		public virtual void deleteAppWidgetId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHost._deleteAppWidgetId816, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._deleteAppWidgetId816, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteHost817; 
		public virtual void deleteHost() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHost._deleteHost817); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._deleteHost817); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteAllHosts818; 
		public static void deleteAllHosts() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._deleteAllHosts818); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onProviderChanged819; 
		protected virtual void onProviderChanged(int arg0, android.appwidget.AppWidgetProviderInfo arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetHost._onProviderChanged819, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._onProviderChanged819, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetHost820; 
		public AppWidgetHost(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._AppWidgetHost820, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.appwidget.AppWidgetHost.staticClass = @__class; 
			global::android.appwidget.AppWidgetHost._onCreateView811 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "onCreateView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/appwidget/AppWidgetHostView;"); 
			global::android.appwidget.AppWidgetHost._createView812 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "createView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/appwidget/AppWidgetHostView;"); 
			global::android.appwidget.AppWidgetHost._startListening813 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "startListening", "()V"); 
			global::android.appwidget.AppWidgetHost._stopListening814 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "stopListening", "()V"); 
			global::android.appwidget.AppWidgetHost._allocateAppWidgetId815 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "allocateAppWidgetId", "()I"); 
			global::android.appwidget.AppWidgetHost._deleteAppWidgetId816 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "deleteAppWidgetId", "(I)V"); 
			global::android.appwidget.AppWidgetHost._deleteHost817 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "deleteHost", "()V"); 
			global::android.appwidget.AppWidgetHost._deleteAllHosts818 = @__env.GetStaticMethodID(global::android.appwidget.AppWidgetHost.staticClass, "deleteAllHosts", "()V"); 
			global::android.appwidget.AppWidgetHost._onProviderChanged819 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "onProviderChanged", "(ILandroid/appwidget/AppWidgetProviderInfo;)V"); 
			global::android.appwidget.AppWidgetHost._AppWidgetHost820 = @__env.GetMethodID(global::android.appwidget.AppWidgetHost.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
		} 
	} 
} 
