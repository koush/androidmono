namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Plugin : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			internal PreferencesClickHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.webkit.Plugin.PreferencesClickHandler.handleClickEvent(android.content.Context arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.Plugin.PreferencesClickHandler_.staticClass, "handleClickEvent", "(Landroid/content/Context;)V", ref global::android.webkit.Plugin.PreferencesClickHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static PreferencesClickHandler_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.Plugin.PreferencesClickHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/Plugin$PreferencesClickHandler"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void PreferencesClickHandlerDelegate(android.content.Context arg0);

		internal partial class PreferencesClickHandlerDelegateWrapper : java.lang.Object, PreferencesClickHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PreferencesClickHandlerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public PreferencesClickHandlerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper.staticClass, global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static PreferencesClickHandlerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/Plugin_PreferencesClickHandlerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.Plugin.staticClass, "toString", "()Ljava/lang/String;", ref global::android.webkit.Plugin._m0) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.Plugin.staticClass, "getName", "()Ljava/lang/String;", ref global::android.webkit.Plugin._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.Plugin.staticClass, "setName", "(Ljava/lang/String;)V", ref global::android.webkit.Plugin._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getFileName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.Plugin.staticClass, "getFileName", "()Ljava/lang/String;", ref global::android.webkit.Plugin._m3) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.Plugin.staticClass, "getPath", "()Ljava/lang/String;", ref global::android.webkit.Plugin._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.Plugin.staticClass, "setPath", "(Ljava/lang/String;)V", ref global::android.webkit.Plugin._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String getDescription()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.Plugin.staticClass, "getDescription", "()Ljava/lang/String;", ref global::android.webkit.Plugin._m6) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setFileName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.Plugin.staticClass, "setFileName", "(Ljava/lang/String;)V", ref global::android.webkit.Plugin._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setDescription(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.Plugin.staticClass, "setDescription", "(Ljava/lang/String;)V", ref global::android.webkit.Plugin._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.webkit.Plugin.PreferencesClickHandler ClickHandler
		{
			set
			{
				setClickHandler(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setClickHandler(android.webkit.Plugin.PreferencesClickHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.Plugin.staticClass, "setClickHandler", "(Landroid/webkit/Plugin$PreferencesClickHandler;)V", ref global::android.webkit.Plugin._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setClickHandler(global::android.webkit.Plugin.PreferencesClickHandlerDelegate arg0)
		{
			setClickHandler((global::android.webkit.Plugin.PreferencesClickHandlerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void dispatchClickEvent(android.content.Context arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.Plugin.staticClass, "dispatchClickEvent", "(Landroid/content/Context;)V", ref global::android.webkit.Plugin._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Plugin(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.Plugin._m11.native == global::System.IntPtr.Zero)
				global::android.webkit.Plugin._m11 = @__env.GetMethodIDNoThrow(global::android.webkit.Plugin.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.Plugin.staticClass, global::android.webkit.Plugin._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static Plugin()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.Plugin.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/Plugin"));
		}
		internal static void InitJNI()
		{
		}
	}
}
