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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.SoundPool.OnLoadCompleteListener.onLoadComplete(android.media.SoundPool arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.OnLoadCompleteListener_.staticClass, "onLoadComplete", "(Landroid/media/SoundPool;II)V", ref global::android.media.SoundPool.OnLoadCompleteListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnLoadCompleteListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.SoundPool.OnLoadCompleteListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/SoundPool$OnLoadCompleteListener"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			public OnLoadCompleteListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper.staticClass, global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnLoadCompleteListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/SoundPool_OnLoadCompleteListenerDelegateWrapper"));
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
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, "finalize", "()V", ref global::android.media.SoundPool._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int load(android.content.Context arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.SoundPool.staticClass, "load", "(Landroid/content/Context;II)I", ref global::android.media.SoundPool._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int load(android.content.res.AssetFileDescriptor arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.SoundPool.staticClass, "load", "(Landroid/content/res/AssetFileDescriptor;I)I", ref global::android.media.SoundPool._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int load(java.io.FileDescriptor arg0, long arg1, long arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.SoundPool.staticClass, "load", "(Ljava/io/FileDescriptor;JJI)I", ref global::android.media.SoundPool._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int load(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.SoundPool.staticClass, "load", "(Ljava/lang/String;I)I", ref global::android.media.SoundPool._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setPriority(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, "setPriority", "(II)V", ref global::android.media.SoundPool._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void stop(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, "stop", "(I)V", ref global::android.media.SoundPool._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void resume(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, "resume", "(I)V", ref global::android.media.SoundPool._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, "release", "()V", ref global::android.media.SoundPool._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool unload(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.SoundPool.staticClass, "unload", "(I)Z", ref global::android.media.SoundPool._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int play(int arg0, float arg1, float arg2, int arg3, int arg4, float arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.SoundPool.staticClass, "play", "(IFFIIF)I", ref global::android.media.SoundPool._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void pause(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, "pause", "(I)V", ref global::android.media.SoundPool._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setVolume(int arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, "setVolume", "(IFF)V", ref global::android.media.SoundPool._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void autoPause()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, "autoPause", "()V", ref global::android.media.SoundPool._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void autoResume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, "autoResume", "()V", ref global::android.media.SoundPool._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setLoop(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, "setLoop", "(II)V", ref global::android.media.SoundPool._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setRate(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, "setRate", "(IF)V", ref global::android.media.SoundPool._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setOnLoadCompleteListener(android.media.SoundPool.OnLoadCompleteListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.SoundPool.staticClass, "setOnLoadCompleteListener", "(Landroid/media/SoundPool$OnLoadCompleteListener;)V", ref global::android.media.SoundPool._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnLoadCompleteListener(global::android.media.SoundPool.OnLoadCompleteListenerDelegate arg0)
		{
			setOnLoadCompleteListener((global::android.media.SoundPool.OnLoadCompleteListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public SoundPool(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.SoundPool._m18.native == global::System.IntPtr.Zero)
				global::android.media.SoundPool._m18 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.SoundPool.staticClass, global::android.media.SoundPool._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static SoundPool()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.SoundPool.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/SoundPool"));
		}
		internal static void InitJNI()
		{
		}
	}
}
