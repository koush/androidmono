namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PluginList : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PluginList()
		{
			InitJNI();
		}
		protected PluginList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clear10352;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.PluginList._clear10352);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._clear10352);
		}
		internal static global::MonoJavaBridge.MethodId _getList10353;
		public virtual global::java.util.List getList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.PluginList._getList10353)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._getList10353)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPlugin10354;
		public virtual void addPlugin(android.webkit.Plugin arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.PluginList._addPlugin10354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._addPlugin10354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePlugin10355;
		public virtual void removePlugin(android.webkit.Plugin arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.PluginList._removePlugin10355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._removePlugin10355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pluginClicked10356;
		public virtual void pluginClicked(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.PluginList._pluginClicked10356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._pluginClicked10356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _PluginList10357;
		public PluginList()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.PluginList.staticClass, global::android.webkit.PluginList._PluginList10357);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.PluginList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/PluginList"));
			global::android.webkit.PluginList._clear10352 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "clear", "()V");
			global::android.webkit.PluginList._getList10353 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "getList", "()Ljava/util/List;");
			global::android.webkit.PluginList._addPlugin10354 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "addPlugin", "(Landroid/webkit/Plugin;)V");
			global::android.webkit.PluginList._removePlugin10355 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "removePlugin", "(Landroid/webkit/Plugin;)V");
			global::android.webkit.PluginList._pluginClicked10356 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "pluginClicked", "(Landroid/content/Context;I)V");
			global::android.webkit.PluginList._PluginList10357 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "<init>", "()V");
		}
	}
}
