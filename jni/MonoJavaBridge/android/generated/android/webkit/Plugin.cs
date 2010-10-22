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
			internal static global::MonoJavaBridge.MethodId _handleClickEvent15980;
			 void android.webkit.Plugin.PreferencesClickHandler.handleClickEvent(android.content.Context arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin.PreferencesClickHandler_._handleClickEvent15980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.PreferencesClickHandler_.staticClass, global::android.webkit.Plugin.PreferencesClickHandler_._handleClickEvent15980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.Plugin.PreferencesClickHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/Plugin$PreferencesClickHandler"));
				global::android.webkit.Plugin.PreferencesClickHandler_._handleClickEvent15980 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.PreferencesClickHandler_.staticClass, "handleClickEvent", "(Landroid/content/Context;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString15981;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._toString15981)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._toString15981)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getName15982;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._getName15982)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getName15982)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName15983;
		public virtual void setName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setName15983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setName15983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFileName15984;
		public virtual global::java.lang.String getFileName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._getFileName15984)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getFileName15984)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getPath15985;
		public virtual global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._getPath15985)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getPath15985)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPath15986;
		public virtual void setPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setPath15986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setPath15986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDescription15987;
		public virtual global::java.lang.String getDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._getDescription15987)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getDescription15987)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFileName15988;
		public virtual void setFileName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setFileName15988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setFileName15988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDescription15989;
		public virtual void setDescription(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setDescription15989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setDescription15989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setClickHandler15990;
		public virtual void setClickHandler(android.webkit.Plugin.PreferencesClickHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setClickHandler15990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setClickHandler15990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchClickEvent15991;
		public virtual void dispatchClickEvent(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._dispatchClickEvent15991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._dispatchClickEvent15991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Plugin15992;
		public Plugin(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.Plugin.staticClass, global::android.webkit.Plugin._Plugin15992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.Plugin.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/Plugin"));
			global::android.webkit.Plugin._toString15981 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "toString", "()Ljava/lang/String;");
			global::android.webkit.Plugin._getName15982 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "getName", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setName15983 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setName", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._getFileName15984 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "getFileName", "()Ljava/lang/String;");
			global::android.webkit.Plugin._getPath15985 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setPath15986 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._getDescription15987 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "getDescription", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setFileName15988 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setFileName", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._setDescription15989 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setDescription", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._setClickHandler15990 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setClickHandler", "(Landroid/webkit/Plugin$PreferencesClickHandler;)V");
			global::android.webkit.Plugin._dispatchClickEvent15991 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "dispatchClickEvent", "(Landroid/content/Context;)V");
			global::android.webkit.Plugin._Plugin15992 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
