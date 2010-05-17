namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Plugin : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Plugin() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.Plugin), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.Plugin(@__env); 
			} 
		} 
		protected Plugin(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface PreferencesClickHandler 
		{ 
			void handleClickEvent(android.content.Context arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString8624; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.Plugin)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString8624)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.Plugin.staticClass, _toString8624)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName8625; 
		public virtual java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.Plugin)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName8625)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.Plugin.staticClass, _getName8625)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setName8626; 
		public virtual void setName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.Plugin)) 
				@__env.CallVoidMethod(this, _setName8626, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.Plugin.staticClass, _setName8626, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFileName8627; 
		public virtual java.lang.String getFileName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.Plugin)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getFileName8627)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.Plugin.staticClass, _getFileName8627)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPath8628; 
		public virtual java.lang.String getPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.Plugin)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPath8628)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.Plugin.staticClass, _getPath8628)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPath8629; 
		public virtual void setPath(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.Plugin)) 
				@__env.CallVoidMethod(this, _setPath8629, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.Plugin.staticClass, _setPath8629, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDescription8630; 
		public virtual java.lang.String getDescription() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.Plugin)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDescription8630)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.Plugin.staticClass, _getDescription8630)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFileName8631; 
		public virtual void setFileName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.Plugin)) 
				@__env.CallVoidMethod(this, _setFileName8631, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.Plugin.staticClass, _setFileName8631, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDescription8632; 
		public virtual void setDescription(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.Plugin)) 
				@__env.CallVoidMethod(this, _setDescription8632, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.Plugin.staticClass, _setDescription8632, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClickHandler8633; 
		public virtual void setClickHandler(android.webkit.Plugin.PreferencesClickHandler arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.Plugin)) 
				@__env.CallVoidMethod(this, _setClickHandler8633, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.Plugin.staticClass, _setClickHandler8633, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchClickEvent8634; 
		public virtual void dispatchClickEvent(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.Plugin)) 
				@__env.CallVoidMethod(this, _dispatchClickEvent8634, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.Plugin.staticClass, _dispatchClickEvent8634, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Plugin8635; 
		public Plugin(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.Plugin.staticClass, _Plugin8635, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.Plugin.staticClass = @__class; 
			global::android.webkit.Plugin._toString8624 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.webkit.Plugin._getName8625 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "getName", "()Ljava/lang/String;"); 
			global::android.webkit.Plugin._setName8626 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setName", "(Ljava/lang/String;)V"); 
			global::android.webkit.Plugin._getFileName8627 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "getFileName", "()Ljava/lang/String;"); 
			global::android.webkit.Plugin._getPath8628 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "getPath", "()Ljava/lang/String;"); 
			global::android.webkit.Plugin._setPath8629 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setPath", "(Ljava/lang/String;)V"); 
			global::android.webkit.Plugin._getDescription8630 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "getDescription", "()Ljava/lang/String;"); 
			global::android.webkit.Plugin._setFileName8631 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setFileName", "(Ljava/lang/String;)V"); 
			global::android.webkit.Plugin._setDescription8632 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setDescription", "(Ljava/lang/String;)V"); 
			global::android.webkit.Plugin._setClickHandler8633 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setClickHandler", "(Landroid/webkit/Plugin$PreferencesClickHandler;)V"); 
			global::android.webkit.Plugin._dispatchClickEvent8634 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "dispatchClickEvent", "(Landroid/content/Context;)V"); 
			global::android.webkit.Plugin._Plugin8635 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
		} 
	} 
} 
