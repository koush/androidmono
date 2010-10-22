namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JetPlayer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JetPlayer()
		{
			InitJNI();
		}
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
		public sealed partial class OnJetEventListener_ : java.lang.Object, OnJetEventListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnJetEventListener_()
			{
				InitJNI();
			}
			internal OnJetEventListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onJetEvent7265;
			 void android.media.JetPlayer.OnJetEventListener.onJetEvent(android.media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_._onJetEvent7265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_.staticClass, global::android.media.JetPlayer.OnJetEventListener_._onJetEvent7265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			internal static global::MonoJavaBridge.MethodId _onJetUserIdUpdate7266;
			 void android.media.JetPlayer.OnJetEventListener.onJetUserIdUpdate(android.media.JetPlayer arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_._onJetUserIdUpdate7266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_.staticClass, global::android.media.JetPlayer.OnJetEventListener_._onJetUserIdUpdate7266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _onJetNumQueuedSegmentUpdate7267;
			 void android.media.JetPlayer.OnJetEventListener.onJetNumQueuedSegmentUpdate(android.media.JetPlayer arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_._onJetNumQueuedSegmentUpdate7267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_.staticClass, global::android.media.JetPlayer.OnJetEventListener_._onJetNumQueuedSegmentUpdate7267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onJetPauseUpdate7268;
			 void android.media.JetPlayer.OnJetEventListener.onJetPauseUpdate(android.media.JetPlayer arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_._onJetPauseUpdate7268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_.staticClass, global::android.media.JetPlayer.OnJetEventListener_._onJetPauseUpdate7268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.JetPlayer.OnJetEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/JetPlayer$OnJetEventListener"));
				global::android.media.JetPlayer.OnJetEventListener_._onJetEvent7265 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetEvent", "(Landroid/media/JetPlayer;SBBBB)V");
				global::android.media.JetPlayer.OnJetEventListener_._onJetUserIdUpdate7266 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetUserIdUpdate", "(Landroid/media/JetPlayer;II)V");
				global::android.media.JetPlayer.OnJetEventListener_._onJetNumQueuedSegmentUpdate7267 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetNumQueuedSegmentUpdate", "(Landroid/media/JetPlayer;I)V");
				global::android.media.JetPlayer.OnJetEventListener_._onJetPauseUpdate7268 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetPauseUpdate", "(Landroid/media/JetPlayer;I)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize7269;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer._finalize7269);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._finalize7269);
		}
		internal static global::MonoJavaBridge.MethodId _clone7270;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.media.JetPlayer._clone7270)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._clone7270)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _release7271;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer._release7271);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._release7271);
		}
		internal static global::MonoJavaBridge.MethodId _play7272;
		public virtual bool play() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._play7272);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._play7272);
		}
		internal static global::MonoJavaBridge.MethodId _pause7273;
		public virtual bool pause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._pause7273);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._pause7273);
		}
		internal static global::MonoJavaBridge.MethodId _getJetPlayer7274;
		public static global::android.media.JetPlayer getJetPlayer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.JetPlayer.staticClass, global::android.media.JetPlayer._getJetPlayer7274)) as android.media.JetPlayer;
		}
		public static int MaxTracks
		{
			get
			{
				return getMaxTracks();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTracks7275;
		public static int getMaxTracks() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.JetPlayer.staticClass, global::android.media.JetPlayer._getMaxTracks7275);
		}
		internal static global::MonoJavaBridge.MethodId _loadJetFile7276;
		public virtual bool loadJetFile(android.content.res.AssetFileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._loadJetFile7276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._loadJetFile7276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadJetFile7277;
		public virtual bool loadJetFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._loadJetFile7277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._loadJetFile7277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _closeJetFile7278;
		public virtual bool closeJetFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._closeJetFile7278);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._closeJetFile7278);
		}
		internal static global::MonoJavaBridge.MethodId _queueJetSegment7279;
		public virtual bool queueJetSegment(int arg0, int arg1, int arg2, int arg3, int arg4, byte arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._queueJetSegment7279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._queueJetSegment7279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _queueJetSegmentMuteArray7280;
		public virtual bool queueJetSegmentMuteArray(int arg0, int arg1, int arg2, int arg3, bool[] arg4, byte arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._queueJetSegmentMuteArray7280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._queueJetSegmentMuteArray7280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _setMuteFlags7281;
		public virtual bool setMuteFlags(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._setMuteFlags7281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setMuteFlags7281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMuteArray7282;
		public virtual bool setMuteArray(bool[] arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._setMuteArray7282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setMuteArray7282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMuteFlag7283;
		public virtual bool setMuteFlag(int arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._setMuteFlag7283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setMuteFlag7283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _triggerClip7284;
		public virtual bool triggerClip(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._triggerClip7284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._triggerClip7284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearQueue7285;
		public virtual bool clearQueue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._clearQueue7285);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._clearQueue7285);
		}
		internal static global::MonoJavaBridge.MethodId _setEventListener7286;
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer._setEventListener7286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setEventListener7286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEventListener7287;
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0, android.os.Handler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer._setEventListener7287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setEventListener7287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.JetPlayer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/JetPlayer"));
			global::android.media.JetPlayer._finalize7269 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "finalize", "()V");
			global::android.media.JetPlayer._clone7270 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.media.JetPlayer._release7271 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "release", "()V");
			global::android.media.JetPlayer._play7272 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "play", "()Z");
			global::android.media.JetPlayer._pause7273 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "pause", "()Z");
			global::android.media.JetPlayer._getJetPlayer7274 = @__env.GetStaticMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "getJetPlayer", "()Landroid/media/JetPlayer;");
			global::android.media.JetPlayer._getMaxTracks7275 = @__env.GetStaticMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "getMaxTracks", "()I");
			global::android.media.JetPlayer._loadJetFile7276 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "loadJetFile", "(Landroid/content/res/AssetFileDescriptor;)Z");
			global::android.media.JetPlayer._loadJetFile7277 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "loadJetFile", "(Ljava/lang/String;)Z");
			global::android.media.JetPlayer._closeJetFile7278 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "closeJetFile", "()Z");
			global::android.media.JetPlayer._queueJetSegment7279 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "queueJetSegment", "(IIIIIB)Z");
			global::android.media.JetPlayer._queueJetSegmentMuteArray7280 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "queueJetSegmentMuteArray", "(IIII[ZB)Z");
			global::android.media.JetPlayer._setMuteFlags7281 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "setMuteFlags", "(IZ)Z");
			global::android.media.JetPlayer._setMuteArray7282 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "setMuteArray", "([ZZ)Z");
			global::android.media.JetPlayer._setMuteFlag7283 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "setMuteFlag", "(IZZ)Z");
			global::android.media.JetPlayer._triggerClip7284 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "triggerClip", "(I)Z");
			global::android.media.JetPlayer._clearQueue7285 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "clearQueue", "()Z");
			global::android.media.JetPlayer._setEventListener7286 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;)V");
			global::android.media.JetPlayer._setEventListener7287 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;Landroid/os/Handler;)V");
		}
	}
}
