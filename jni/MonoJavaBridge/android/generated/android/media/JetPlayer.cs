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
			internal static global::net.sf.jni4net.jni.MethodId _onJetEvent4724;
			 void android.media.JetPlayer.OnJetEventListener.onJetEvent(android.media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener._onJetEvent4724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener.staticClass, global::android.media.JetPlayer.__OnJetEventListener._onJetEvent4724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onJetUserIdUpdate4725;
			 void android.media.JetPlayer.OnJetEventListener.onJetUserIdUpdate(android.media.JetPlayer arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener._onJetUserIdUpdate4725, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener.staticClass, global::android.media.JetPlayer.__OnJetEventListener._onJetUserIdUpdate4725, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onJetNumQueuedSegmentUpdate4726;
			 void android.media.JetPlayer.OnJetEventListener.onJetNumQueuedSegmentUpdate(android.media.JetPlayer arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener._onJetNumQueuedSegmentUpdate4726, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener.staticClass, global::android.media.JetPlayer.__OnJetEventListener._onJetNumQueuedSegmentUpdate4726, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onJetPauseUpdate4727;
			 void android.media.JetPlayer.OnJetEventListener.onJetPauseUpdate(android.media.JetPlayer arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener._onJetPauseUpdate4727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.__OnJetEventListener.staticClass, global::android.media.JetPlayer.__OnJetEventListener._onJetPauseUpdate4727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.JetPlayer.__OnJetEventListener.staticClass = @__class;
				global::android.media.JetPlayer.__OnJetEventListener._onJetEvent4724 = @__env.GetMethodID(global::android.media.JetPlayer.__OnJetEventListener.staticClass, "android.media.JetPlayer.OnJetEventListener.onJetEvent", "(Landroid/media/JetPlayer;SBBBB)V");
				global::android.media.JetPlayer.__OnJetEventListener._onJetUserIdUpdate4725 = @__env.GetMethodID(global::android.media.JetPlayer.__OnJetEventListener.staticClass, "android.media.JetPlayer.OnJetEventListener.onJetUserIdUpdate", "(Landroid/media/JetPlayer;II)V");
				global::android.media.JetPlayer.__OnJetEventListener._onJetNumQueuedSegmentUpdate4726 = @__env.GetMethodID(global::android.media.JetPlayer.__OnJetEventListener.staticClass, "android.media.JetPlayer.OnJetEventListener.onJetNumQueuedSegmentUpdate", "(Landroid/media/JetPlayer;I)V");
				global::android.media.JetPlayer.__OnJetEventListener._onJetPauseUpdate4727 = @__env.GetMethodID(global::android.media.JetPlayer.__OnJetEventListener.staticClass, "android.media.JetPlayer.OnJetEventListener.onJetPauseUpdate", "(Landroid/media/JetPlayer;I)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone4728;
		public virtual global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.media.JetPlayer._clone4728));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._clone4728));
		}
		internal static global::net.sf.jni4net.jni.MethodId _release4729;
		public virtual void release() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.JetPlayer._release4729);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._release4729);
		}
		internal static global::net.sf.jni4net.jni.MethodId _play4730;
		public virtual bool play() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._play4730);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._play4730);
		}
		internal static global::net.sf.jni4net.jni.MethodId _pause4731;
		public virtual bool pause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._pause4731);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._pause4731);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getJetPlayer4732;
		public static global::android.media.JetPlayer getJetPlayer() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.JetPlayer>(@__env, @__env.CallStaticObjectMethodPtr(android.media.JetPlayer.staticClass, global::android.media.JetPlayer._getJetPlayer4732));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxTracks4733;
		public static int getMaxTracks() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.JetPlayer.staticClass, global::android.media.JetPlayer._getMaxTracks4733);
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadJetFile4734;
		public virtual bool loadJetFile(android.content.res.AssetFileDescriptor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._loadJetFile4734, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._loadJetFile4734, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadJetFile4735;
		public virtual bool loadJetFile(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._loadJetFile4735, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._loadJetFile4735, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _closeJetFile4736;
		public virtual bool closeJetFile() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._closeJetFile4736);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._closeJetFile4736);
		}
		internal static global::net.sf.jni4net.jni.MethodId _queueJetSegment4737;
		public virtual bool queueJetSegment(int arg0, int arg1, int arg2, int arg3, int arg4, byte arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._queueJetSegment4737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._queueJetSegment4737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _queueJetSegmentMuteArray4738;
		public virtual bool queueJetSegmentMuteArray(int arg0, int arg1, int arg2, int arg3, bool[] arg4, byte arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._queueJetSegmentMuteArray4738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._queueJetSegmentMuteArray4738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMuteFlags4739;
		public virtual bool setMuteFlags(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._setMuteFlags4739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setMuteFlags4739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMuteArray4740;
		public virtual bool setMuteArray(bool[] arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._setMuteArray4740, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setMuteArray4740, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMuteFlag4741;
		public virtual bool setMuteFlag(int arg0, bool arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._setMuteFlag4741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setMuteFlag4741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _triggerClip4742;
		public virtual bool triggerClip(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._triggerClip4742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._triggerClip4742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearQueue4743;
		public virtual bool clearQueue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.JetPlayer._clearQueue4743);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._clearQueue4743);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEventListener4744;
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.JetPlayer._setEventListener4744, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setEventListener4744, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEventListener4745;
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0, android.os.Handler arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.JetPlayer._setEventListener4745, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setEventListener4745, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.media.JetPlayer.staticClass = @__class;
			global::android.media.JetPlayer._clone4728 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.media.JetPlayer._release4729 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "release", "()V");
			global::android.media.JetPlayer._play4730 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "play", "()Z");
			global::android.media.JetPlayer._pause4731 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "pause", "()Z");
			global::android.media.JetPlayer._getJetPlayer4732 = @__env.GetStaticMethodID(global::android.media.JetPlayer.staticClass, "getJetPlayer", "()Landroid/media/JetPlayer;");
			global::android.media.JetPlayer._getMaxTracks4733 = @__env.GetStaticMethodID(global::android.media.JetPlayer.staticClass, "getMaxTracks", "()I");
			global::android.media.JetPlayer._loadJetFile4734 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "loadJetFile", "(Landroid/content/res/AssetFileDescriptor;)Z");
			global::android.media.JetPlayer._loadJetFile4735 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "loadJetFile", "(Ljava/lang/String;)Z");
			global::android.media.JetPlayer._closeJetFile4736 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "closeJetFile", "()Z");
			global::android.media.JetPlayer._queueJetSegment4737 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "queueJetSegment", "(IIIIIB)Z");
			global::android.media.JetPlayer._queueJetSegmentMuteArray4738 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "queueJetSegmentMuteArray", "(IIII[ZB)Z");
			global::android.media.JetPlayer._setMuteFlags4739 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setMuteFlags", "(IZ)Z");
			global::android.media.JetPlayer._setMuteArray4740 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setMuteArray", "([ZZ)Z");
			global::android.media.JetPlayer._setMuteFlag4741 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setMuteFlag", "(IZZ)Z");
			global::android.media.JetPlayer._triggerClip4742 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "triggerClip", "(I)Z");
			global::android.media.JetPlayer._clearQueue4743 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "clearQueue", "()Z");
			global::android.media.JetPlayer._setEventListener4744 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;)V");
			global::android.media.JetPlayer._setEventListener4745 = @__env.GetMethodID(global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;Landroid/os/Handler;)V");
		}
	}
}
