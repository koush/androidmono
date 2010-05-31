namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PluginList : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PluginList() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.PluginList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.PluginList(@__env); 
			} 
		} 
		protected PluginList(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear9326; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.PluginList._clear9326); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._clear9326); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getList9327; 
		public virtual global::java.util.List getList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.PluginList._getList9327)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._getList9327)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPlugin9328; 
		public virtual void addPlugin(android.webkit.Plugin arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.PluginList._addPlugin9328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._addPlugin9328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removePlugin9329; 
		public virtual void removePlugin(android.webkit.Plugin arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.PluginList._removePlugin9329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._removePlugin9329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pluginClicked9330; 
		public virtual void pluginClicked(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.PluginList._pluginClicked9330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.PluginList.staticClass, global::android.webkit.PluginList._pluginClicked9330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PluginList9331; 
		public PluginList()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.PluginList.staticClass, global::android.webkit.PluginList._PluginList9331, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.PluginList.staticClass = @__class; 
			global::android.webkit.PluginList._clear9326 = @__env.GetMethodID(global::android.webkit.PluginList.staticClass, "clear", "()V"); 
			global::android.webkit.PluginList._getList9327 = @__env.GetMethodID(global::android.webkit.PluginList.staticClass, "getList", "()Ljava/util/List;"); 
			global::android.webkit.PluginList._addPlugin9328 = @__env.GetMethodID(global::android.webkit.PluginList.staticClass, "addPlugin", "(Landroid/webkit/Plugin;)V"); 
			global::android.webkit.PluginList._removePlugin9329 = @__env.GetMethodID(global::android.webkit.PluginList.staticClass, "removePlugin", "(Landroid/webkit/Plugin;)V"); 
			global::android.webkit.PluginList._pluginClicked9330 = @__env.GetMethodID(global::android.webkit.PluginList.staticClass, "pluginClicked", "(Landroid/content/Context;I)V"); 
			global::android.webkit.PluginList._PluginList9331 = @__env.GetMethodID(global::android.webkit.PluginList.staticClass, "<init>", "()V"); 
		} 
	} 
} 
