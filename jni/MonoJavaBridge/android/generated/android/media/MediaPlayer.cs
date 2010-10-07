namespace android.media
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class MediaPlayer : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static MediaPlayer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaPlayer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.media.MediaPlayer(@__env);
			}
		}
		protected MediaPlayer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnBufferingUpdateListener 
		{
			void onBufferingUpdate(android.media.MediaPlayer arg0, int arg1);
		}

		public partial class OnBufferingUpdateListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnBufferingUpdateListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnBufferingUpdateListener : java.lang.Object, OnBufferingUpdateListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnBufferingUpdateListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaPlayer.__OnBufferingUpdateListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.media.MediaPlayer.__OnBufferingUpdateListener(@__env);
				}
			}
			internal __OnBufferingUpdateListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onBufferingUpdate4746;
			 void android.media.MediaPlayer.OnBufferingUpdateListener.onBufferingUpdate(android.media.MediaPlayer arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.MediaPlayer.__OnBufferingUpdateListener._onBufferingUpdate4746, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.__OnBufferingUpdateListener.staticClass, global::android.media.MediaPlayer.__OnBufferingUpdateListener._onBufferingUpdate4746, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.MediaPlayer.__OnBufferingUpdateListener.staticClass = @__class;
				global::android.media.MediaPlayer.__OnBufferingUpdateListener._onBufferingUpdate4746 = @__env.GetMethodID(global::android.media.MediaPlayer.__OnBufferingUpdateListener.staticClass, "android.media.MediaPlayer.OnBufferingUpdateListener.onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnCompletionListener 
		{
			void onCompletion(android.media.MediaPlayer arg0);
		}

		public partial class OnCompletionListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnCompletionListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnCompletionListener : java.lang.Object, OnCompletionListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnCompletionListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaPlayer.__OnCompletionListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.media.MediaPlayer.__OnCompletionListener(@__env);
				}
			}
			internal __OnCompletionListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onCompletion4747;
			 void android.media.MediaPlayer.OnCompletionListener.onCompletion(android.media.MediaPlayer arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.MediaPlayer.__OnCompletionListener._onCompletion4747, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.__OnCompletionListener.staticClass, global::android.media.MediaPlayer.__OnCompletionListener._onCompletion4747, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.MediaPlayer.__OnCompletionListener.staticClass = @__class;
				global::android.media.MediaPlayer.__OnCompletionListener._onCompletion4747 = @__env.GetMethodID(global::android.media.MediaPlayer.__OnCompletionListener.staticClass, "android.media.MediaPlayer.OnCompletionListener.onCompletion", "(Landroid/media/MediaPlayer;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnErrorListener 
		{
			bool onError(android.media.MediaPlayer arg0, int arg1, int arg2);
		}

		public partial class OnErrorListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnErrorListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnErrorListener : java.lang.Object, OnErrorListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnErrorListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaPlayer.__OnErrorListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.media.MediaPlayer.__OnErrorListener(@__env);
				}
			}
			internal __OnErrorListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onError4748;
			 bool android.media.MediaPlayer.OnErrorListener.onError(android.media.MediaPlayer arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.media.MediaPlayer.__OnErrorListener._onError4748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.media.MediaPlayer.__OnErrorListener.staticClass, global::android.media.MediaPlayer.__OnErrorListener._onError4748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.MediaPlayer.__OnErrorListener.staticClass = @__class;
				global::android.media.MediaPlayer.__OnErrorListener._onError4748 = @__env.GetMethodID(global::android.media.MediaPlayer.__OnErrorListener.staticClass, "android.media.MediaPlayer.OnErrorListener.onError", "(Landroid/media/MediaPlayer;II)Z");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnInfoListener 
		{
			bool onInfo(android.media.MediaPlayer arg0, int arg1, int arg2);
		}

		public partial class OnInfoListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnInfoListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnInfoListener : java.lang.Object, OnInfoListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnInfoListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaPlayer.__OnInfoListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.media.MediaPlayer.__OnInfoListener(@__env);
				}
			}
			internal __OnInfoListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onInfo4749;
			 bool android.media.MediaPlayer.OnInfoListener.onInfo(android.media.MediaPlayer arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.media.MediaPlayer.__OnInfoListener._onInfo4749, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.media.MediaPlayer.__OnInfoListener.staticClass, global::android.media.MediaPlayer.__OnInfoListener._onInfo4749, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.MediaPlayer.__OnInfoListener.staticClass = @__class;
				global::android.media.MediaPlayer.__OnInfoListener._onInfo4749 = @__env.GetMethodID(global::android.media.MediaPlayer.__OnInfoListener.staticClass, "android.media.MediaPlayer.OnInfoListener.onInfo", "(Landroid/media/MediaPlayer;II)Z");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnPreparedListener 
		{
			void onPrepared(android.media.MediaPlayer arg0);
		}

		public partial class OnPreparedListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnPreparedListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnPreparedListener : java.lang.Object, OnPreparedListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnPreparedListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaPlayer.__OnPreparedListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.media.MediaPlayer.__OnPreparedListener(@__env);
				}
			}
			internal __OnPreparedListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onPrepared4750;
			 void android.media.MediaPlayer.OnPreparedListener.onPrepared(android.media.MediaPlayer arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.MediaPlayer.__OnPreparedListener._onPrepared4750, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.__OnPreparedListener.staticClass, global::android.media.MediaPlayer.__OnPreparedListener._onPrepared4750, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.MediaPlayer.__OnPreparedListener.staticClass = @__class;
				global::android.media.MediaPlayer.__OnPreparedListener._onPrepared4750 = @__env.GetMethodID(global::android.media.MediaPlayer.__OnPreparedListener.staticClass, "android.media.MediaPlayer.OnPreparedListener.onPrepared", "(Landroid/media/MediaPlayer;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnSeekCompleteListener 
		{
			void onSeekComplete(android.media.MediaPlayer arg0);
		}

		public partial class OnSeekCompleteListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnSeekCompleteListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnSeekCompleteListener : java.lang.Object, OnSeekCompleteListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnSeekCompleteListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaPlayer.__OnSeekCompleteListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.media.MediaPlayer.__OnSeekCompleteListener(@__env);
				}
			}
			internal __OnSeekCompleteListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onSeekComplete4751;
			 void android.media.MediaPlayer.OnSeekCompleteListener.onSeekComplete(android.media.MediaPlayer arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.MediaPlayer.__OnSeekCompleteListener._onSeekComplete4751, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.__OnSeekCompleteListener.staticClass, global::android.media.MediaPlayer.__OnSeekCompleteListener._onSeekComplete4751, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.MediaPlayer.__OnSeekCompleteListener.staticClass = @__class;
				global::android.media.MediaPlayer.__OnSeekCompleteListener._onSeekComplete4751 = @__env.GetMethodID(global::android.media.MediaPlayer.__OnSeekCompleteListener.staticClass, "android.media.MediaPlayer.OnSeekCompleteListener.onSeekComplete", "(Landroid/media/MediaPlayer;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnVideoSizeChangedListener 
		{
			void onVideoSizeChanged(android.media.MediaPlayer arg0, int arg1, int arg2);
		}

		public partial class OnVideoSizeChangedListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnVideoSizeChangedListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnVideoSizeChangedListener : java.lang.Object, OnVideoSizeChangedListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnVideoSizeChangedListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaPlayer.__OnVideoSizeChangedListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.media.MediaPlayer.__OnVideoSizeChangedListener(@__env);
				}
			}
			internal __OnVideoSizeChangedListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onVideoSizeChanged4752;
			 void android.media.MediaPlayer.OnVideoSizeChangedListener.onVideoSizeChanged(android.media.MediaPlayer arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.MediaPlayer.__OnVideoSizeChangedListener._onVideoSizeChanged4752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.__OnVideoSizeChangedListener.staticClass, global::android.media.MediaPlayer.__OnVideoSizeChangedListener._onVideoSizeChanged4752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.MediaPlayer.__OnVideoSizeChangedListener.staticClass = @__class;
				global::android.media.MediaPlayer.__OnVideoSizeChangedListener._onVideoSizeChanged4752 = @__env.GetMethodID(global::android.media.MediaPlayer.__OnVideoSizeChangedListener.staticClass, "android.media.MediaPlayer.OnVideoSizeChangedListener.onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _start4753;
		public virtual void start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._start4753);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._start4753);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stop4754;
		public virtual void stop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._stop4754);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._stop4754);
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset4755;
		public virtual void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._reset4755);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._reset4755);
		}
		internal static global::net.sf.jni4net.jni.MethodId _release4756;
		public virtual void release() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._release4756);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._release4756);
		}
		internal static global::net.sf.jni4net.jni.MethodId _create4757;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, android.net.Uri arg1, android.view.SurfaceHolder arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.MediaPlayer>(@__env, @__env.CallStaticObjectMethodPtr(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._create4757, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _create4758;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, android.net.Uri arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.MediaPlayer>(@__env, @__env.CallStaticObjectMethodPtr(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._create4758, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _create4759;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.MediaPlayer>(@__env, @__env.CallStaticObjectMethodPtr(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._create4759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _prepare4760;
		public virtual void prepare() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._prepare4760);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._prepare4760);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDuration4761;
		public virtual int getDuration() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.MediaPlayer._getDuration4761);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getDuration4761);
		}
		internal static global::net.sf.jni4net.jni.MethodId _pause4762;
		public virtual void pause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._pause4762);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._pause4762);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDisplay4763;
		public virtual void setDisplay(android.view.SurfaceHolder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setDisplay4763, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDisplay4763, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDataSource4764;
		public virtual void setDataSource(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setDataSource4764, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource4764, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDataSource4765;
		public virtual void setDataSource(java.io.FileDescriptor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setDataSource4765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource4765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDataSource4766;
		public virtual void setDataSource(java.io.FileDescriptor arg0, long arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setDataSource4766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource4766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDataSource4767;
		public virtual void setDataSource(android.content.Context arg0, android.net.Uri arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setDataSource4767, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource4767, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _prepareAsync4768;
		public virtual void prepareAsync() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._prepareAsync4768);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._prepareAsync4768);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWakeMode4769;
		public virtual void setWakeMode(android.content.Context arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setWakeMode4769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setWakeMode4769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScreenOnWhilePlaying4770;
		public virtual void setScreenOnWhilePlaying(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setScreenOnWhilePlaying4770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setScreenOnWhilePlaying4770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVideoWidth4771;
		public virtual int getVideoWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.MediaPlayer._getVideoWidth4771);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getVideoWidth4771);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVideoHeight4772;
		public virtual int getVideoHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.MediaPlayer._getVideoHeight4772);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getVideoHeight4772);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPlaying4773;
		public virtual bool isPlaying() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.MediaPlayer._isPlaying4773);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._isPlaying4773);
		}
		internal static global::net.sf.jni4net.jni.MethodId _seekTo4774;
		public virtual void seekTo(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._seekTo4774, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._seekTo4774, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentPosition4775;
		public virtual int getCurrentPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.MediaPlayer._getCurrentPosition4775);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getCurrentPosition4775);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAudioStreamType4776;
		public virtual void setAudioStreamType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setAudioStreamType4776, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setAudioStreamType4776, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLooping4777;
		public virtual void setLooping(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setLooping4777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setLooping4777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLooping4778;
		public virtual bool isLooping() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.MediaPlayer._isLooping4778);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._isLooping4778);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVolume4779;
		public virtual void setVolume(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setVolume4779, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setVolume4779, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnPreparedListener4780;
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setOnPreparedListener4780, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnPreparedListener4780, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnCompletionListener4781;
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setOnCompletionListener4781, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnCompletionListener4781, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnBufferingUpdateListener4782;
		public virtual void setOnBufferingUpdateListener(android.media.MediaPlayer.OnBufferingUpdateListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setOnBufferingUpdateListener4782, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnBufferingUpdateListener4782, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnSeekCompleteListener4783;
		public virtual void setOnSeekCompleteListener(android.media.MediaPlayer.OnSeekCompleteListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setOnSeekCompleteListener4783, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnSeekCompleteListener4783, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnVideoSizeChangedListener4784;
		public virtual void setOnVideoSizeChangedListener(android.media.MediaPlayer.OnVideoSizeChangedListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setOnVideoSizeChangedListener4784, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnVideoSizeChangedListener4784, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnErrorListener4785;
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setOnErrorListener4785, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnErrorListener4785, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnInfoListener4786;
		public virtual void setOnInfoListener(android.media.MediaPlayer.OnInfoListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaPlayer._setOnInfoListener4786, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnInfoListener4786, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MediaPlayer4787;
		public MediaPlayer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._MediaPlayer4787, this);
		}
		public static int MEDIA_ERROR_UNKNOWN
		{
			get
			{
				return 1;
			}
		}
		public static int MEDIA_ERROR_SERVER_DIED
		{
			get
			{
				return 100;
			}
		}
		public static int MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK
		{
			get
			{
				return 200;
			}
		}
		public static int MEDIA_INFO_UNKNOWN
		{
			get
			{
				return 1;
			}
		}
		public static int MEDIA_INFO_VIDEO_TRACK_LAGGING
		{
			get
			{
				return 700;
			}
		}
		public static int MEDIA_INFO_BAD_INTERLEAVING
		{
			get
			{
				return 800;
			}
		}
		public static int MEDIA_INFO_NOT_SEEKABLE
		{
			get
			{
				return 801;
			}
		}
		public static int MEDIA_INFO_METADATA_UPDATE
		{
			get
			{
				return 802;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.media.MediaPlayer.staticClass = @__class;
			global::android.media.MediaPlayer._start4753 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "start", "()V");
			global::android.media.MediaPlayer._stop4754 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "stop", "()V");
			global::android.media.MediaPlayer._reset4755 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "reset", "()V");
			global::android.media.MediaPlayer._release4756 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "release", "()V");
			global::android.media.MediaPlayer._create4757 = @__env.GetStaticMethodID(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;Landroid/net/Uri;Landroid/view/SurfaceHolder;)Landroid/media/MediaPlayer;");
			global::android.media.MediaPlayer._create4758 = @__env.GetStaticMethodID(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/MediaPlayer;");
			global::android.media.MediaPlayer._create4759 = @__env.GetStaticMethodID(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;I)Landroid/media/MediaPlayer;");
			global::android.media.MediaPlayer._prepare4760 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "prepare", "()V");
			global::android.media.MediaPlayer._getDuration4761 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "getDuration", "()I");
			global::android.media.MediaPlayer._pause4762 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "pause", "()V");
			global::android.media.MediaPlayer._setDisplay4763 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setDisplay", "(Landroid/view/SurfaceHolder;)V");
			global::android.media.MediaPlayer._setDataSource4764 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/lang/String;)V");
			global::android.media.MediaPlayer._setDataSource4765 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/io/FileDescriptor;)V");
			global::android.media.MediaPlayer._setDataSource4766 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/io/FileDescriptor;JJ)V");
			global::android.media.MediaPlayer._setDataSource4767 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V");
			global::android.media.MediaPlayer._prepareAsync4768 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "prepareAsync", "()V");
			global::android.media.MediaPlayer._setWakeMode4769 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setWakeMode", "(Landroid/content/Context;I)V");
			global::android.media.MediaPlayer._setScreenOnWhilePlaying4770 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setScreenOnWhilePlaying", "(Z)V");
			global::android.media.MediaPlayer._getVideoWidth4771 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "getVideoWidth", "()I");
			global::android.media.MediaPlayer._getVideoHeight4772 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "getVideoHeight", "()I");
			global::android.media.MediaPlayer._isPlaying4773 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "isPlaying", "()Z");
			global::android.media.MediaPlayer._seekTo4774 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "seekTo", "(I)V");
			global::android.media.MediaPlayer._getCurrentPosition4775 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "getCurrentPosition", "()I");
			global::android.media.MediaPlayer._setAudioStreamType4776 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setAudioStreamType", "(I)V");
			global::android.media.MediaPlayer._setLooping4777 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setLooping", "(Z)V");
			global::android.media.MediaPlayer._isLooping4778 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "isLooping", "()Z");
			global::android.media.MediaPlayer._setVolume4779 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setVolume", "(FF)V");
			global::android.media.MediaPlayer._setOnPreparedListener4780 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V");
			global::android.media.MediaPlayer._setOnCompletionListener4781 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V");
			global::android.media.MediaPlayer._setOnBufferingUpdateListener4782 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnBufferingUpdateListener", "(Landroid/media/MediaPlayer$OnBufferingUpdateListener;)V");
			global::android.media.MediaPlayer._setOnSeekCompleteListener4783 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnSeekCompleteListener", "(Landroid/media/MediaPlayer$OnSeekCompleteListener;)V");
			global::android.media.MediaPlayer._setOnVideoSizeChangedListener4784 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnVideoSizeChangedListener", "(Landroid/media/MediaPlayer$OnVideoSizeChangedListener;)V");
			global::android.media.MediaPlayer._setOnErrorListener4785 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V");
			global::android.media.MediaPlayer._setOnInfoListener4786 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnInfoListener", "(Landroid/media/MediaPlayer$OnInfoListener;)V");
			global::android.media.MediaPlayer._MediaPlayer4787 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "<init>", "()V");
		}
	}
}
