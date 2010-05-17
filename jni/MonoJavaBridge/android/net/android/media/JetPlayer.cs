namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class JetPlayer : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static JetPlayer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.JetPlayer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.JetPlayer(@__env); 
			} 
		} 
		protected JetPlayer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnJetEventListener 
		{ 
			void onJetEvent(android.media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5); 
			void onJetUserIdUpdate(android.media.JetPlayer arg0, int arg1, int arg2); 
			void onJetNumQueuedSegmentUpdate(android.media.JetPlayer arg0, int arg1); 
			void onJetPauseUpdate(android.media.JetPlayer arg0, int arg1); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone4235; 
		public virtual java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone4235)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.media.JetPlayer.staticClass, _clone4235)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release4236; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				@__env.CallVoidMethod(this, _release4236); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.JetPlayer.staticClass, _release4236); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _play4237; 
		public virtual bool play() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return @__env.CallBooleanMethod(this, _play4237); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.JetPlayer.staticClass, _play4237); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pause4238; 
		public virtual bool pause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return @__env.CallBooleanMethod(this, _pause4238); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.JetPlayer.staticClass, _pause4238); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getJetPlayer4239; 
		public static android.media.JetPlayer getJetPlayer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.JetPlayer>(@__env, @__env.CallStaticObjectMethodPtr(android.media.JetPlayer.staticClass, _getJetPlayer4239)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxTracks4240; 
		public static int getMaxTracks() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.media.JetPlayer.staticClass, _getMaxTracks4240); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadJetFile4241; 
		public virtual bool loadJetFile(android.content.res.AssetFileDescriptor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return @__env.CallBooleanMethod(this, _loadJetFile4241, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.JetPlayer.staticClass, _loadJetFile4241, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadJetFile4242; 
		public virtual bool loadJetFile(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return @__env.CallBooleanMethod(this, _loadJetFile4242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.JetPlayer.staticClass, _loadJetFile4242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _closeJetFile4243; 
		public virtual bool closeJetFile() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return @__env.CallBooleanMethod(this, _closeJetFile4243); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.JetPlayer.staticClass, _closeJetFile4243); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _queueJetSegment4244; 
		public virtual bool queueJetSegment(int arg0, int arg1, int arg2, int arg3, int arg4, byte arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return @__env.CallBooleanMethod(this, _queueJetSegment4244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.JetPlayer.staticClass, _queueJetSegment4244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _queueJetSegmentMuteArray4245; 
		public virtual bool queueJetSegmentMuteArray(int arg0, int arg1, int arg2, int arg3, bool[] arg4, byte arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return @__env.CallBooleanMethod(this, _queueJetSegmentMuteArray4245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.JetPlayer.staticClass, _queueJetSegmentMuteArray4245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMuteFlags4246; 
		public virtual bool setMuteFlags(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return @__env.CallBooleanMethod(this, _setMuteFlags4246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.JetPlayer.staticClass, _setMuteFlags4246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMuteArray4247; 
		public virtual bool setMuteArray(bool[] arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return @__env.CallBooleanMethod(this, _setMuteArray4247, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.JetPlayer.staticClass, _setMuteArray4247, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMuteFlag4248; 
		public virtual bool setMuteFlag(int arg0, bool arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return @__env.CallBooleanMethod(this, _setMuteFlag4248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.JetPlayer.staticClass, _setMuteFlag4248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _triggerClip4249; 
		public virtual bool triggerClip(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return @__env.CallBooleanMethod(this, _triggerClip4249, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.JetPlayer.staticClass, _triggerClip4249, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearQueue4250; 
		public virtual bool clearQueue() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				return @__env.CallBooleanMethod(this, _clearQueue4250); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.JetPlayer.staticClass, _clearQueue4250); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEventListener4251; 
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				@__env.CallVoidMethod(this, _setEventListener4251, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.JetPlayer.staticClass, _setEventListener4251, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEventListener4252; 
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0, android.os.Handler arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.JetPlayer)) 
				@__env.CallVoidMethod(this, _setEventListener4252, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.JetPlayer.staticClass, _setEventListener4252, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.JetPlayer.staticClass = @__class; 
			global::android.media.JetPlayer._clone4235 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::android.media.JetPlayer._release4236 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "release", "()V"); 
			global::android.media.JetPlayer._play4237 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "play", "()Z"); 
			global::android.media.JetPlayer._pause4238 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "pause", "()Z"); 
			global::android.media.JetPlayer._getJetPlayer4239 = @__env.GetStaticMethodID(global::android.media.JetPlayer.staticClass, "getJetPlayer", "()Landroid/media/JetPlayer;"); 
			global::android.media.JetPlayer._getMaxTracks4240 = @__env.GetStaticMethodID(global::android.media.JetPlayer.staticClass, "getMaxTracks", "()I"); 
			global::android.media.JetPlayer._loadJetFile4241 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "loadJetFile", "(Landroid/content/res/AssetFileDescriptor;)Z"); 
			global::android.media.JetPlayer._loadJetFile4242 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "loadJetFile", "(Ljava/lang/String;)Z"); 
			global::android.media.JetPlayer._closeJetFile4243 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "closeJetFile", "()Z"); 
			global::android.media.JetPlayer._queueJetSegment4244 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "queueJetSegment", "(IIIIIB)Z"); 
			global::android.media.JetPlayer._queueJetSegmentMuteArray4245 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "queueJetSegmentMuteArray", "(IIII[ZB)Z"); 
			global::android.media.JetPlayer._setMuteFlags4246 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setMuteFlags", "(IZ)Z"); 
			global::android.media.JetPlayer._setMuteArray4247 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setMuteArray", "([ZZ)Z"); 
			global::android.media.JetPlayer._setMuteFlag4248 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setMuteFlag", "(IZZ)Z"); 
			global::android.media.JetPlayer._triggerClip4249 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "triggerClip", "(I)Z"); 
			global::android.media.JetPlayer._clearQueue4250 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "clearQueue", "()Z"); 
			global::android.media.JetPlayer._setEventListener4251 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;)V"); 
			global::android.media.JetPlayer._setEventListener4252 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;Landroid/os/Handler;)V"); 
		} 
	} 
} 
