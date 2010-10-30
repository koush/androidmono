namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SoundPool : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SoundPool(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.SoundPool.OnLoadCompleteListener_))]
		public partial interface OnLoadCompleteListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onLoadComplete(android.media.SoundPool arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.SoundPool.OnLoadCompleteListener))]
		internal sealed partial class OnLoadCompleteListener_ : java.lang.Object, OnLoadCompleteListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnLoadCompleteListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onLoadComplete7485;
			void android.media.SoundPool.OnLoadCompleteListener.onLoadComplete(android.media.SoundPool arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool.OnLoadCompleteListener_._onLoadComplete7485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnLoadCompleteListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.SoundPool.OnLoadCompleteListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/SoundPool$OnLoadCompleteListener"));
				global::android.media.SoundPool.OnLoadCompleteListener_._onLoadComplete7485 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.OnLoadCompleteListener_.staticClass, "onLoadComplete", "(Landroid/media/SoundPool;II)V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnLoadCompleteListenerDelegate(android.media.SoundPool arg0, int arg1, int arg2);

		internal partial class OnLoadCompleteListenerDelegateWrapper : java.lang.Object, OnLoadCompleteListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnLoadCompleteListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnLoadCompleteListenerDelegateWrapper7486;
			public OnLoadCompleteListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper.staticClass, global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper._OnLoadCompleteListenerDelegateWrapper7486);
				Init(@__env, handle);
			}
			static OnLoadCompleteListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/SoundPool_OnLoadCompleteListenerDelegateWrapper"));
				global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper._OnLoadCompleteListenerDelegateWrapper7486 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnLoadCompleteListenerDelegateWrapper
		{
			private OnLoadCompleteListenerDelegate myDelegate;
			public void onLoadComplete(android.media.SoundPool arg0, int arg1, int arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnLoadCompleteListenerDelegateWrapper(OnLoadCompleteListenerDelegate d)
			{
				global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper ret = new global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize7487;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._finalize7487);
		}
		internal static global::MonoJavaBridge.MethodId _load7488;
		public virtual int load(android.content.Context arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load7488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _load7489;
		public virtual int load(android.content.res.AssetFileDescriptor arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load7489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _load7490;
		public virtual int load(java.io.FileDescriptor arg0, long arg1, long arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load7490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _load7491;
		public virtual int load(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load7491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setPriority7492;
		public virtual void setPriority(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setPriority7492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stop7493;
		public virtual void stop(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._stop7493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resume7494;
		public virtual void resume(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._resume7494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _release7495;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._release7495);
		}
		internal static global::MonoJavaBridge.MethodId _unload7496;
		public virtual bool unload(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._unload7496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _play7497;
		public virtual int play(int arg0, float arg1, float arg2, int arg3, int arg4, float arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._play7497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _pause7498;
		public virtual void pause(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._pause7498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVolume7499;
		public virtual void setVolume(int arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setVolume7499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _autoPause7500;
		public virtual void autoPause()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._autoPause7500);
		}
		internal static global::MonoJavaBridge.MethodId _autoResume7501;
		public virtual void autoResume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._autoResume7501);
		}
		internal static global::MonoJavaBridge.MethodId _setLoop7502;
		public virtual void setLoop(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setLoop7502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setRate7503;
		public virtual void setRate(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setRate7503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setOnLoadCompleteListener7504;
		public virtual void setOnLoadCompleteListener(android.media.SoundPool.OnLoadCompleteListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setOnLoadCompleteListener7504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnLoadCompleteListener(global::android.media.SoundPool.OnLoadCompleteListenerDelegate arg0)
		{
			setOnLoadCompleteListener((global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _SoundPool7505;
		public SoundPool(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.SoundPool.staticClass, global::android.media.SoundPool._SoundPool7505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static SoundPool()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.SoundPool.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/SoundPool"));
			global::android.media.SoundPool._finalize7487 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "finalize", "()V");
			global::android.media.SoundPool._load7488 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "load", "(Landroid/content/Context;II)I");
			global::android.media.SoundPool._load7489 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "load", "(Landroid/content/res/AssetFileDescriptor;I)I");
			global::android.media.SoundPool._load7490 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "load", "(Ljava/io/FileDescriptor;JJI)I");
			global::android.media.SoundPool._load7491 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "load", "(Ljava/lang/String;I)I");
			global::android.media.SoundPool._setPriority7492 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "setPriority", "(II)V");
			global::android.media.SoundPool._stop7493 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "stop", "(I)V");
			global::android.media.SoundPool._resume7494 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "resume", "(I)V");
			global::android.media.SoundPool._release7495 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "release", "()V");
			global::android.media.SoundPool._unload7496 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "unload", "(I)Z");
			global::android.media.SoundPool._play7497 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "play", "(IFFIIF)I");
			global::android.media.SoundPool._pause7498 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "pause", "(I)V");
			global::android.media.SoundPool._setVolume7499 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "setVolume", "(IFF)V");
			global::android.media.SoundPool._autoPause7500 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "autoPause", "()V");
			global::android.media.SoundPool._autoResume7501 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "autoResume", "()V");
			global::android.media.SoundPool._setLoop7502 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "setLoop", "(II)V");
			global::android.media.SoundPool._setRate7503 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "setRate", "(IF)V");
			global::android.media.SoundPool._setOnLoadCompleteListener7504 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "setOnLoadCompleteListener", "(Landroid/media/SoundPool$OnLoadCompleteListener;)V");
			global::android.media.SoundPool._SoundPool7505 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "<init>", "(III)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
