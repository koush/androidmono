namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Plugin : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Plugin()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.Plugin), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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

		public partial class PreferencesClickHandler_
		{
			public static global::java.lang.Class _class
			{
				get { return __PreferencesClickHandler.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __PreferencesClickHandler : java.lang.Object, PreferencesClickHandler
		{
			internal static global::java.lang.Class staticClass;
			static __PreferencesClickHandler()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.Plugin.__PreferencesClickHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.webkit.Plugin.__PreferencesClickHandler(@__env);
				}
			}
			internal __PreferencesClickHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _handleClickEvent9308;
			 void android.webkit.Plugin.PreferencesClickHandler.handleClickEvent(android.content.Context arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.webkit.Plugin.__PreferencesClickHandler._handleClickEvent9308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.__PreferencesClickHandler.staticClass, global::android.webkit.Plugin.__PreferencesClickHandler._handleClickEvent9308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.Plugin.__PreferencesClickHandler.staticClass = @__class;
				global::android.webkit.Plugin.__PreferencesClickHandler._handleClickEvent9308 = @__env.GetMethodID(global::android.webkit.Plugin.__PreferencesClickHandler.staticClass, "android.webkit.Plugin.PreferencesClickHandler.handleClickEvent", "(Landroid/content/Context;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString9309;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.Plugin._toString9309));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._toString9309));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName9310;
		public virtual global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.Plugin._getName9310));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getName9310));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setName9311;
		public virtual void setName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.Plugin._setName9311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setName9311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFileName9312;
		public virtual global::java.lang.String getFileName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.Plugin._getFileName9312));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getFileName9312));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPath9313;
		public virtual global::java.lang.String getPath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.Plugin._getPath9313));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getPath9313));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPath9314;
		public virtual void setPath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.Plugin._setPath9314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setPath9314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDescription9315;
		public virtual global::java.lang.String getDescription() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.Plugin._getDescription9315));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getDescription9315));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFileName9316;
		public virtual void setFileName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.Plugin._setFileName9316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setFileName9316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDescription9317;
		public virtual void setDescription(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.Plugin._setDescription9317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setDescription9317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setClickHandler9318;
		public virtual void setClickHandler(android.webkit.Plugin.PreferencesClickHandler arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.Plugin._setClickHandler9318, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setClickHandler9318, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchClickEvent9319;
		public virtual void dispatchClickEvent(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.Plugin._dispatchClickEvent9319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._dispatchClickEvent9319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Plugin9320;
		public Plugin(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.webkit.Plugin.staticClass, global::android.webkit.Plugin._Plugin9320, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.Plugin.staticClass = @__class;
			global::android.webkit.Plugin._toString9309 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "toString", "()Ljava/lang/String;");
			global::android.webkit.Plugin._getName9310 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "getName", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setName9311 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setName", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._getFileName9312 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "getFileName", "()Ljava/lang/String;");
			global::android.webkit.Plugin._getPath9313 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setPath9314 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._getDescription9315 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "getDescription", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setFileName9316 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setFileName", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._setDescription9317 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setDescription", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._setClickHandler9318 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setClickHandler", "(Landroid/webkit/Plugin$PreferencesClickHandler;)V");
			global::android.webkit.Plugin._dispatchClickEvent9319 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "dispatchClickEvent", "(Landroid/content/Context;)V");
			global::android.webkit.Plugin._Plugin9320 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
