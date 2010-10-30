namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JetPlayer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JetPlayer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.JetPlayer.OnJetEventListener_))]
		public partial interface OnJetEventListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onJetEvent(android.media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5);
			void onJetUserIdUpdate(android.media.JetPlayer arg0, int arg1, int arg2);
			void onJetNumQueuedSegmentUpdate(android.media.JetPlayer arg0, int arg1);
			void onJetPauseUpdate(android.media.JetPlayer arg0, int arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.JetPlayer.OnJetEventListener))]
		internal sealed partial class OnJetEventListener_ : java.lang.Object, OnJetEventListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnJetEventListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.JetPlayer.OnJetEventListener.onJetEvent(android.media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetEvent", "(Landroid/media/JetPlayer;SBBBB)V", ref global::android.media.JetPlayer.OnJetEventListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.media.JetPlayer.OnJetEventListener.onJetUserIdUpdate(android.media.JetPlayer arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetUserIdUpdate", "(Landroid/media/JetPlayer;II)V", ref global::android.media.JetPlayer.OnJetEventListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void android.media.JetPlayer.OnJetEventListener.onJetNumQueuedSegmentUpdate(android.media.JetPlayer arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetNumQueuedSegmentUpdate", "(Landroid/media/JetPlayer;I)V", ref global::android.media.JetPlayer.OnJetEventListener_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			void android.media.JetPlayer.OnJetEventListener.onJetPauseUpdate(android.media.JetPlayer arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetPauseUpdate", "(Landroid/media/JetPlayer;I)V", ref global::android.media.JetPlayer.OnJetEventListener_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnJetEventListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.JetPlayer.OnJetEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/JetPlayer$OnJetEventListener"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.staticClass, "finalize", "()V", ref global::android.media.JetPlayer._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.media.JetPlayer.staticClass, "clone", "()Ljava/lang/Object;", ref global::android.media.JetPlayer._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.staticClass, "release", "()V", ref global::android.media.JetPlayer._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool play()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "play", "()Z", ref global::android.media.JetPlayer._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool pause()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "pause", "()Z", ref global::android.media.JetPlayer._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.media.JetPlayer getJetPlayer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.JetPlayer._m5.native == global::System.IntPtr.Zero)
				global::android.media.JetPlayer._m5 = @__env.GetStaticMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "getJetPlayer", "()Landroid/media/JetPlayer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.JetPlayer.staticClass, global::android.media.JetPlayer._m5)) as android.media.JetPlayer;
		}
		public static int MaxTracks
		{
			get
			{
				return getMaxTracks();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static int getMaxTracks()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.JetPlayer._m6.native == global::System.IntPtr.Zero)
				global::android.media.JetPlayer._m6 = @__env.GetStaticMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "getMaxTracks", "()I");
			return @__env.CallStaticIntMethod(android.media.JetPlayer.staticClass, global::android.media.JetPlayer._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool loadJetFile(android.content.res.AssetFileDescriptor arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "loadJetFile", "(Landroid/content/res/AssetFileDescriptor;)Z", ref global::android.media.JetPlayer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool loadJetFile(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "loadJetFile", "(Ljava/lang/String;)Z", ref global::android.media.JetPlayer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool closeJetFile()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "closeJetFile", "()Z", ref global::android.media.JetPlayer._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool queueJetSegment(int arg0, int arg1, int arg2, int arg3, int arg4, byte arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "queueJetSegment", "(IIIIIB)Z", ref global::android.media.JetPlayer._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool queueJetSegmentMuteArray(int arg0, int arg1, int arg2, int arg3, bool[] arg4, byte arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "queueJetSegmentMuteArray", "(IIII[ZB)Z", ref global::android.media.JetPlayer._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool setMuteFlags(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "setMuteFlags", "(IZ)Z", ref global::android.media.JetPlayer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool setMuteArray(bool[] arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "setMuteArray", "([ZZ)Z", ref global::android.media.JetPlayer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool setMuteFlag(int arg0, bool arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "setMuteFlag", "(IZZ)Z", ref global::android.media.JetPlayer._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool triggerClip(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "triggerClip", "(I)Z", ref global::android.media.JetPlayer._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool clearQueue()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "clearQueue", "()Z", ref global::android.media.JetPlayer._m16);
		}
		public new global::android.media.JetPlayer.OnJetEventListener EventListener
		{
			set
			{
				setEventListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;)V", ref global::android.media.JetPlayer._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0, android.os.Handler arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;Landroid/os/Handler;)V", ref global::android.media.JetPlayer._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static JetPlayer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.JetPlayer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/JetPlayer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
