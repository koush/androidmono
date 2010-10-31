namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PluginList : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PluginList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.PluginList.staticClass, "clear", "()V", ref global::android.webkit.PluginList._m0);
		}
		public new global::java.util.List List
		{
			get
			{
				return getList();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.List getList()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.webkit.PluginList.staticClass, "getList", "()Ljava/util/List;", ref global::android.webkit.PluginList._m1) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void addPlugin(android.webkit.Plugin arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.PluginList.staticClass, "addPlugin", "(Landroid/webkit/Plugin;)V", ref global::android.webkit.PluginList._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void removePlugin(android.webkit.Plugin arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.PluginList.staticClass, "removePlugin", "(Landroid/webkit/Plugin;)V", ref global::android.webkit.PluginList._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void pluginClicked(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.PluginList.staticClass, "pluginClicked", "(Landroid/content/Context;I)V", ref global::android.webkit.PluginList._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public PluginList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.PluginList._m5.native == global::System.IntPtr.Zero)
				global::android.webkit.PluginList._m5 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginList.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.PluginList.staticClass, global::android.webkit.PluginList._m5);
			Init(@__env, handle);
		}
		static PluginList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.PluginList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/PluginList"));
		}
	}
}
