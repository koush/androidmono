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
		internal static global::MonoJavaBridge.MethodId _clear15998;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.PluginList._clear15998);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._clear15998);
		}
		public new global::java.util.List List
		{
			get
			{
				return getList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getList15999;
		public virtual global::java.util.List getList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.PluginList._getList15999)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._getList15999)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPlugin16000;
		public virtual void addPlugin(android.webkit.Plugin arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.PluginList._addPlugin16000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._addPlugin16000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePlugin16001;
		public virtual void removePlugin(android.webkit.Plugin arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.PluginList._removePlugin16001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._removePlugin16001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pluginClicked16002;
		public virtual void pluginClicked(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.PluginList._pluginClicked16002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._pluginClicked16002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _PluginList16003;
		public PluginList()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.PluginList.staticClass, global::android.webkit.PluginList._PluginList16003);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.PluginList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/PluginList"));
			global::android.webkit.PluginList._clear15998 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "clear", "()V");
			global::android.webkit.PluginList._getList15999 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "getList", "()Ljava/util/List;");
			global::android.webkit.PluginList._addPlugin16000 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "addPlugin", "(Landroid/webkit/Plugin;)V");
			global::android.webkit.PluginList._removePlugin16001 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "removePlugin", "(Landroid/webkit/Plugin;)V");
			global::android.webkit.PluginList._pluginClicked16002 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "pluginClicked", "(Landroid/content/Context;I)V");
			global::android.webkit.PluginList._PluginList16003 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "<init>", "()V");
		}
	}
}
