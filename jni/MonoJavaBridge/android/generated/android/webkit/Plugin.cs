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
		public partial interface PreferencesClickHandler  : global::MonoJavaBridge.IJavaObject 
		{
			void handleClickEvent(android.content.Context arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.Plugin.PreferencesClickHandler))]
		internal sealed partial class PreferencesClickHandler_ : java.lang.Object, PreferencesClickHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PreferencesClickHandler_()
			{
				InitJNI();
			}
			internal PreferencesClickHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _handleClickEvent16065;
			void android.webkit.Plugin.PreferencesClickHandler.handleClickEvent(android.content.Context arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin.PreferencesClickHandler_._handleClickEvent16065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.PreferencesClickHandler_.staticClass, global::android.webkit.Plugin.PreferencesClickHandler_._handleClickEvent16065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.Plugin.PreferencesClickHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/Plugin$PreferencesClickHandler"));
				global::android.webkit.Plugin.PreferencesClickHandler_._handleClickEvent16065 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.PreferencesClickHandler_.staticClass, "handleClickEvent", "(Landroid/content/Context;)V");
			}
		}

		public delegate void PreferencesClickHandlerDelegate(android.content.Context arg0);

		internal partial class PreferencesClickHandlerDelegateWrapper : java.lang.Object, PreferencesClickHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PreferencesClickHandlerDelegateWrapper()
			{
				InitJNI();
			}
			protected PreferencesClickHandlerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _PreferencesClickHandlerDelegateWrapper16066;
			public PreferencesClickHandlerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper.staticClass, global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper._PreferencesClickHandlerDelegateWrapper16066);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/Plugin_PreferencesClickHandlerDelegateWrapper"));
				global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper._PreferencesClickHandlerDelegateWrapper16066 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class PreferencesClickHandlerDelegateWrapper
		{
			private PreferencesClickHandlerDelegate myDelegate;
			public void handleClickEvent(android.content.Context arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator PreferencesClickHandlerDelegateWrapper(PreferencesClickHandlerDelegate d)
			{
				global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper ret = new global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString16067;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._toString16067)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._toString16067)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getName16068;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._getName16068)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getName16068)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName16069;
		public virtual void setName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setName16069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setName16069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFileName16070;
		public virtual global::java.lang.String getFileName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._getFileName16070)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getFileName16070)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getPath16071;
		public virtual global::java.lang.String getPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._getPath16071)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getPath16071)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPath16072;
		public virtual void setPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setPath16072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setPath16072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDescription16073;
		public virtual global::java.lang.String getDescription()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.Plugin._getDescription16073)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._getDescription16073)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFileName16074;
		public virtual void setFileName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setFileName16074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setFileName16074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDescription16075;
		public virtual void setDescription(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setDescription16075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setDescription16075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.webkit.Plugin.PreferencesClickHandler ClickHandler
		{
			set
			{
				setClickHandler(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setClickHandler16076;
		public virtual void setClickHandler(android.webkit.Plugin.PreferencesClickHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._setClickHandler16076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._setClickHandler16076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setClickHandler(global::android.webkit.Plugin.PreferencesClickHandlerDelegate arg0)
		{
			setClickHandler((global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchClickEvent16077;
		public virtual void dispatchClickEvent(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.Plugin._dispatchClickEvent16077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.Plugin.staticClass, global::android.webkit.Plugin._dispatchClickEvent16077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Plugin16078;
		public Plugin(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.Plugin.staticClass, global::android.webkit.Plugin._Plugin16078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.Plugin.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/Plugin"));
			global::android.webkit.Plugin._toString16067 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "toString", "()Ljava/lang/String;");
			global::android.webkit.Plugin._getName16068 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "getName", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setName16069 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setName", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._getFileName16070 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "getFileName", "()Ljava/lang/String;");
			global::android.webkit.Plugin._getPath16071 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setPath16072 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._getDescription16073 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "getDescription", "()Ljava/lang/String;");
			global::android.webkit.Plugin._setFileName16074 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setFileName", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._setDescription16075 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setDescription", "(Ljava/lang/String;)V");
			global::android.webkit.Plugin._setClickHandler16076 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "setClickHandler", "(Landroid/webkit/Plugin$PreferencesClickHandler;)V");
			global::android.webkit.Plugin._dispatchClickEvent16077 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "dispatchClickEvent", "(Landroid/content/Context;)V");
			global::android.webkit.Plugin._Plugin16078 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
