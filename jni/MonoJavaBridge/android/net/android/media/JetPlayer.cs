namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class JetPlayer : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static JetPlayer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.JetPlayer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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

		public partial class OnJetEventListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnJetEventListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnJetEventListener : java.lang.Object, OnJetEventListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnJetEventListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.JetPlayer.__OnJetEventListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.media.JetPlayer.__OnJetEventListener(@__env); 
				} 
			} 
			internal __OnJetEventListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onJetEvent4468; 
			 void android.media.JetPlayer.OnJetEventListener.onJetEvent(android.media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener._onJetEvent4468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener.staticClass, global::android.media.JetPlayer.__OnJetEventListener._onJetEvent4468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onJetUserIdUpdate4469; 
			 void android.media.JetPlayer.OnJetEventListener.onJetUserIdUpdate(android.media.JetPlayer arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener._onJetUserIdUpdate4469, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener.staticClass, global::android.media.JetPlayer.__OnJetEventListener._onJetUserIdUpdate4469, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onJetNumQueuedSegmentUpdate4470; 
			 void android.media.JetPlayer.OnJetEventListener.onJetNumQueuedSegmentUpdate(android.media.JetPlayer arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener._onJetNumQueuedSegmentUpdate4470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener.staticClass, global::android.media.JetPlayer.__OnJetEventListener._onJetNumQueuedSegmentUpdate4470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onJetPauseUpdate4471; 
			 void android.media.JetPlayer.OnJetEventListener.onJetPauseUpdate(android.media.JetPlayer arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener._onJetPauseUpdate4471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener.staticClass, global::android.media.JetPlayer.__OnJetEventListener._onJetPauseUpdate4471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.media.JetPlayer.__OnJetEventListener.staticClass = @__class; 
				global::android.media.JetPlayer.__OnJetEventListener._onJetEvent4468 = @__env.GetMethodID(global::android.media.JetPlayer.__OnJetEventListener.staticClass, "android.media.JetPlayer.OnJetEventListener.onJetEvent", "(Landroid/media/JetPlayer;SBBBB)V"); 
				global::android.media.JetPlayer.__OnJetEventListener._onJetUserIdUpdate4469 = @__env.GetMethodID(global::android.media.JetPlayer.__OnJetEventListener.staticClass, "android.media.JetPlayer.OnJetEventListener.onJetUserIdUpdate", "(Landroid/media/JetPlayer;II)V"); 
				global::android.media.JetPlayer.__OnJetEventListener._onJetNumQueuedSegmentUpdate4470 = @__env.GetMethodID(global::android.media.JetPlayer.__OnJetEventListener.staticClass, "android.media.JetPlayer.OnJetEventListener.onJetNumQueuedSegmentUpdate", "(Landroid/media/JetPlayer;I)V"); 
				global::android.media.JetPlayer.__OnJetEventListener._onJetPauseUpdate4471 = @__env.GetMethodID(global::android.media.JetPlayer.__OnJetEventListener.staticClass, "android.media.JetPlayer.OnJetEventListener.onJetPauseUpdate", "(Landroid/media/JetPlayer;I)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone4472; 
		public virtual global::java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.media.JetPlayer._clone4472)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._clone4472)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release4473; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.JetPlayer._release4473); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._release4473); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _play4474; 
		public virtual bool play() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._play4474); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._play4474); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pause4475; 
		public virtual bool pause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._pause4475); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._pause4475); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getJetPlayer4476; 
		public static global::android.media.JetPlayer getJetPlayer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.JetPlayer>(@__env, @__env.CallStaticObjectMethodPtr(android.media.JetPlayer.staticClass, global::android.media.JetPlayer._getJetPlayer4476)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxTracks4477; 
		public static int getMaxTracks() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.media.JetPlayer.staticClass, global::android.media.JetPlayer._getMaxTracks4477); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadJetFile4478; 
		public virtual bool loadJetFile(android.content.res.AssetFileDescriptor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._loadJetFile4478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._loadJetFile4478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadJetFile4479; 
		public virtual bool loadJetFile(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._loadJetFile4479, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._loadJetFile4479, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _closeJetFile4480; 
		public virtual bool closeJetFile() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._closeJetFile4480); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._closeJetFile4480); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _queueJetSegment4481; 
		public virtual bool queueJetSegment(int arg0, int arg1, int arg2, int arg3, int arg4, byte arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._queueJetSegment4481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._queueJetSegment4481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _queueJetSegmentMuteArray4482; 
		public virtual bool queueJetSegmentMuteArray(int arg0, int arg1, int arg2, int arg3, bool[] arg4, byte arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._queueJetSegmentMuteArray4482, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._queueJetSegmentMuteArray4482, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMuteFlags4483; 
		public virtual bool setMuteFlags(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._setMuteFlags4483, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setMuteFlags4483, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMuteArray4484; 
		public virtual bool setMuteArray(bool[] arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._setMuteArray4484, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setMuteArray4484, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMuteFlag4485; 
		public virtual bool setMuteFlag(int arg0, bool arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._setMuteFlag4485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setMuteFlag4485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _triggerClip4486; 
		public virtual bool triggerClip(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._triggerClip4486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._triggerClip4486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearQueue4487; 
		public virtual bool clearQueue() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._clearQueue4487); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._clearQueue4487); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEventListener4488; 
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.JetPlayer._setEventListener4488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setEventListener4488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEventListener4489; 
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0, android.os.Handler arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.JetPlayer._setEventListener4489, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setEventListener4489, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.JetPlayer.staticClass = @__class; 
			global::android.media.JetPlayer._clone4472 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::android.media.JetPlayer._release4473 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "release", "()V"); 
			global::android.media.JetPlayer._play4474 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "play", "()Z"); 
			global::android.media.JetPlayer._pause4475 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "pause", "()Z"); 
			global::android.media.JetPlayer._getJetPlayer4476 = @__env.GetStaticMethodID(global::android.media.JetPlayer.staticClass, "getJetPlayer", "()Landroid/media/JetPlayer;"); 
			global::android.media.JetPlayer._getMaxTracks4477 = @__env.GetStaticMethodID(global::android.media.JetPlayer.staticClass, "getMaxTracks", "()I"); 
			global::android.media.JetPlayer._loadJetFile4478 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "loadJetFile", "(Landroid/content/res/AssetFileDescriptor;)Z"); 
			global::android.media.JetPlayer._loadJetFile4479 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "loadJetFile", "(Ljava/lang/String;)Z"); 
			global::android.media.JetPlayer._closeJetFile4480 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "closeJetFile", "()Z"); 
			global::android.media.JetPlayer._queueJetSegment4481 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "queueJetSegment", "(IIIIIB)Z"); 
			global::android.media.JetPlayer._queueJetSegmentMuteArray4482 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "queueJetSegmentMuteArray", "(IIII[ZB)Z"); 
			global::android.media.JetPlayer._setMuteFlags4483 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setMuteFlags", "(IZ)Z"); 
			global::android.media.JetPlayer._setMuteArray4484 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setMuteArray", "([ZZ)Z"); 
			global::android.media.JetPlayer._setMuteFlag4485 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setMuteFlag", "(IZZ)Z"); 
			global::android.media.JetPlayer._triggerClip4486 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "triggerClip", "(I)Z"); 
			global::android.media.JetPlayer._clearQueue4487 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "clearQueue", "()Z"); 
			global::android.media.JetPlayer._setEventListener4488 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;)V"); 
			global::android.media.JetPlayer._setEventListener4489 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;Landroid/os/Handler;)V"); 
		} 
	} 
} 
