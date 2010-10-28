namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PluginList : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PluginList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clear16084;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.PluginList._clear16084);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._clear16084);
		}
		public new global::java.util.List List
		{
			get
			{
				return getList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getList16085;
		public virtual global::java.util.List getList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.PluginList._getList16085)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._getList16085)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPlugin16086;
		public virtual void addPlugin(android.webkit.Plugin arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.PluginList._addPlugin16086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._addPlugin16086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePlugin16087;
		public virtual void removePlugin(android.webkit.Plugin arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.PluginList._removePlugin16087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._removePlugin16087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pluginClicked16088;
		public virtual void pluginClicked(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.PluginList._pluginClicked16088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._pluginClicked16088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _PluginList16089;
		public PluginList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.PluginList.staticClass, global::android.webkit.PluginList._PluginList16089);
			Init(@__env, handle);
		}
		static PluginList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.PluginList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/PluginList"));
			global::android.webkit.PluginList._clear16084 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "clear", "()V");
			global::android.webkit.PluginList._getList16085 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "getList", "()Ljava/util/List;");
			global::android.webkit.PluginList._addPlugin16086 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "addPlugin", "(Landroid/webkit/Plugin;)V");
			global::android.webkit.PluginList._removePlugin16087 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "removePlugin", "(Landroid/webkit/Plugin;)V");
			global::android.webkit.PluginList._pluginClicked16088 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "pluginClicked", "(Landroid/content/Context;I)V");
			global::android.webkit.PluginList._PluginList16089 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
