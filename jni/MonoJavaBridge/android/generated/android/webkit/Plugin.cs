namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Plugin : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Plugin()
		{
			InitJNI();
		}
		protected Plugin(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.Plugin.PreferencesClickHandler_))]
		public interface PreferencesClickHandler  : global::MonoJavaBridge.IJavaObject 
		{
			void handleClickEvent(android.content.Context arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.Plugin.PreferencesClickHandler))]
		public sealed partial class PreferencesClickHandler_ : java.lang.Object, PreferencesClickHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PreferencesClickHandler_()
			{
				InitJNI();
			}
			internal PreferencesClickHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _handleClickEvent10880;
			 void android.webkit.Plugin.PreferencesClickHandler.handleClickEvent(android.content.Context arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin.PreferencesClickHandler_._handleClickEvent10880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.PreferencesClickHandler_.staticClass, global::android.webkit.Plugin.PreferencesClickHandler_._handleClickEvent10880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.Plugin.PreferencesClickHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/Plugin$PreferencesClickHandler"));
				global::android.webkit.Plugin.PreferencesClickHandler_._handleClickEvent10880 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.PreferencesClickHandler_.staticClass, "handleClickEvent", "(Landroid/content/Context;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString10881;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._toString10881)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._toString10881)) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
			set
			{
				setName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName10882;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._getName10882)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getName10882)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName10883;
		public virtual void setName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setName10883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setName10883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String FileName
		{
			get
			{
				return getFileName();
			}
			set
			{
				setFileName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFileName10884;
		public virtual global::java.lang.String getFileName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._getFileName10884)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getFileName10884)) as java.lang.String;
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
			set
			{
				setPath(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath10885;
		public virtual global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._getPath10885)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getPath10885)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPath10886;
		public virtual void setPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setPath10886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setPath10886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Description
		{
			get
			{
				return getDescription();
			}
			set
			{
				setDescription(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDescription10887;
		public virtual global::java.lang.String getDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._getDescription10887)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getDescription10887)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFileName10888;
		public virtual void setFileName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setFileName10888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setFileName10888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDescription10889;
		public virtual void setDescription(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setDescription10889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setDescription10889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setClickHandler10890;
		public virtual void setClickHandler(android.webkit.Plugin.PreferencesClickHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setClickHandler10890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setClickHandler10890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchClickEvent10891;
		public virtual void dispatchClickEvent(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._dispatchClickEvent10891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._dispatchClickEvent10891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Plugin10892;
		public Plugin(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.Plugin.staticClass, global::android.webkit.Plugin._Plugin10892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.Plugin.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/Plugin"));
			global::android.webkit.Plugin._toString10881 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "toString", "()Ljava/lang/String;");
			global::android.webkit.Plugin._getName10882 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "getName", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setName10883 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setName", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._getFileName10884 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "getFileName", "()Ljava/lang/String;");
			global::android.webkit.Plugin._getPath10885 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setPath10886 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._getDescription10887 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "getDescription", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setFileName10888 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setFileName", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._setDescription10889 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setDescription", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._setClickHandler10890 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setClickHandler", "(Landroid/webkit/Plugin$PreferencesClickHandler;)V");
			global::android.webkit.Plugin._dispatchClickEvent10891 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "dispatchClickEvent", "(Landroid/content/Context;)V");
			global::android.webkit.Plugin._Plugin10892 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
