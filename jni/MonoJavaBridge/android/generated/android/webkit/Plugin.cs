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
			internal static global::net.sf.jni4net.jni.MethodId _handleClickEvent9987;
			 void android.webkit.Plugin.PreferencesClickHandler.handleClickEvent(android.content.Context arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.webkit.Plugin.__PreferencesClickHandler._handleClickEvent9987, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.__PreferencesClickHandler.staticClass, global::android.webkit.Plugin.__PreferencesClickHandler._handleClickEvent9987, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.Plugin.__PreferencesClickHandler.staticClass = @__class;
				global::android.webkit.Plugin.__PreferencesClickHandler._handleClickEvent9987 = @__env.GetMethodID(global::android.webkit.Plugin.__PreferencesClickHandler.staticClass, "android.webkit.Plugin.PreferencesClickHandler.handleClickEvent", "(Landroid/content/Context;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString9988;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.Plugin._toString9988));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._toString9988));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName9989;
		public virtual global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.Plugin._getName9989));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getName9989));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setName9990;
		public virtual void setName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.Plugin._setName9990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setName9990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFileName9991;
		public virtual global::java.lang.String getFileName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.Plugin._getFileName9991));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getFileName9991));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPath9992;
		public virtual global::java.lang.String getPath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.Plugin._getPath9992));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getPath9992));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPath9993;
		public virtual void setPath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.Plugin._setPath9993, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setPath9993, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDescription9994;
		public virtual global::java.lang.String getDescription() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.Plugin._getDescription9994));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getDescription9994));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFileName9995;
		public virtual void setFileName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.Plugin._setFileName9995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setFileName9995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDescription9996;
		public virtual void setDescription(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.Plugin._setDescription9996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setDescription9996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setClickHandler9997;
		public virtual void setClickHandler(android.webkit.Plugin.PreferencesClickHandler arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.Plugin._setClickHandler9997, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setClickHandler9997, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchClickEvent9998;
		public virtual void dispatchClickEvent(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.Plugin._dispatchClickEvent9998, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._dispatchClickEvent9998, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Plugin9999;
		public Plugin(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.webkit.Plugin.staticClass, global::android.webkit.Plugin._Plugin9999, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.Plugin.staticClass = @__class;
			global::android.webkit.Plugin._toString9988 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "toString", "()Ljava/lang/String;");
			global::android.webkit.Plugin._getName9989 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "getName", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setName9990 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setName", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._getFileName9991 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "getFileName", "()Ljava/lang/String;");
			global::android.webkit.Plugin._getPath9992 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setPath9993 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._getDescription9994 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "getDescription", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setFileName9995 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setFileName", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._setDescription9996 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setDescription", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._setClickHandler9997 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "setClickHandler", "(Landroid/webkit/Plugin$PreferencesClickHandler;)V");
			global::android.webkit.Plugin._dispatchClickEvent9998 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "dispatchClickEvent", "(Landroid/content/Context;)V");
			global::android.webkit.Plugin._Plugin9999 = @__env.GetMethodID(global::android.webkit.Plugin.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
