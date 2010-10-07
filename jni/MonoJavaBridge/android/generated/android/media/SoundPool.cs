namespace android.media
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SoundPool : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SoundPool()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.SoundPool), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.media.SoundPool(@__env);
			}
		}
		protected SoundPool(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnLoadCompleteListener 
		{
			void onLoadComplete(android.media.SoundPool arg0, int arg1, int arg2);
		}

		public partial class OnLoadCompleteListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnLoadCompleteListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnLoadCompleteListener : java.lang.Object, OnLoadCompleteListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnLoadCompleteListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.SoundPool.__OnLoadCompleteListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.media.SoundPool.__OnLoadCompleteListener(@__env);
				}
			}
			internal __OnLoadCompleteListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onLoadComplete4856;
			 void android.media.SoundPool.OnLoadCompleteListener.onLoadComplete(android.media.SoundPool arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.SoundPool.__OnLoadCompleteListener._onLoadComplete4856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.__OnLoadCompleteListener.staticClass, global::android.media.SoundPool.__OnLoadCompleteListener._onLoadComplete4856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.SoundPool.__OnLoadCompleteListener.staticClass = @__class;
				global::android.media.SoundPool.__OnLoadCompleteListener._onLoadComplete4856 = @__env.GetMethodID(global::android.media.SoundPool.__OnLoadCompleteListener.staticClass, "android.media.SoundPool.OnLoadCompleteListener.onLoadComplete", "(Landroid/media/SoundPool;II)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _load4857;
		public virtual int load(android.content.Context arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.SoundPool._load4857, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load4857, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _load4858;
		public virtual int load(android.content.res.AssetFileDescriptor arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.SoundPool._load4858, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load4858, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _load4859;
		public virtual int load(java.io.FileDescriptor arg0, long arg1, long arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.SoundPool._load4859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load4859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _load4860;
		public virtual int load(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.SoundPool._load4860, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load4860, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPriority4861;
		public virtual void setPriority(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.SoundPool._setPriority4861, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setPriority4861, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stop4862;
		public virtual void stop(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.SoundPool._stop4862, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._stop4862, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _resume4863;
		public virtual void resume(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.SoundPool._resume4863, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._resume4863, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _release4864;
		public virtual void release() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.SoundPool._release4864);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._release4864);
		}
		internal static global::net.sf.jni4net.jni.MethodId _unload4865;
		public virtual bool unload(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.SoundPool._unload4865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._unload4865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _play4866;
		public virtual int play(int arg0, float arg1, float arg2, int arg3, int arg4, float arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.SoundPool._play4866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._play4866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pause4867;
		public virtual void pause(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.SoundPool._pause4867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._pause4867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVolume4868;
		public virtual void setVolume(int arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.SoundPool._setVolume4868, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setVolume4868, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _autoPause4869;
		public virtual void autoPause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.SoundPool._autoPause4869);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._autoPause4869);
		}
		internal static global::net.sf.jni4net.jni.MethodId _autoResume4870;
		public virtual void autoResume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.SoundPool._autoResume4870);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._autoResume4870);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLoop4871;
		public virtual void setLoop(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.SoundPool._setLoop4871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setLoop4871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRate4872;
		public virtual void setRate(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.SoundPool._setRate4872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setRate4872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnLoadCompleteListener4873;
		public virtual void setOnLoadCompleteListener(android.media.SoundPool.OnLoadCompleteListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.SoundPool._setOnLoadCompleteListener4873, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setOnLoadCompleteListener4873, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SoundPool4874;
		public SoundPool(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.media.SoundPool.staticClass, global::android.media.SoundPool._SoundPool4874, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.media.SoundPool.staticClass = @__class;
			global::android.media.SoundPool._load4857 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "load", "(Landroid/content/Context;II)I");
			global::android.media.SoundPool._load4858 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "load", "(Landroid/content/res/AssetFileDescriptor;I)I");
			global::android.media.SoundPool._load4859 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "load", "(Ljava/io/FileDescriptor;JJI)I");
			global::android.media.SoundPool._load4860 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "load", "(Ljava/lang/String;I)I");
			global::android.media.SoundPool._setPriority4861 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setPriority", "(II)V");
			global::android.media.SoundPool._stop4862 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "stop", "(I)V");
			global::android.media.SoundPool._resume4863 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "resume", "(I)V");
			global::android.media.SoundPool._release4864 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "release", "()V");
			global::android.media.SoundPool._unload4865 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "unload", "(I)Z");
			global::android.media.SoundPool._play4866 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "play", "(IFFIIF)I");
			global::android.media.SoundPool._pause4867 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "pause", "(I)V");
			global::android.media.SoundPool._setVolume4868 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setVolume", "(IFF)V");
			global::android.media.SoundPool._autoPause4869 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "autoPause", "()V");
			global::android.media.SoundPool._autoResume4870 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "autoResume", "()V");
			global::android.media.SoundPool._setLoop4871 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setLoop", "(II)V");
			global::android.media.SoundPool._setRate4872 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setRate", "(IF)V");
			global::android.media.SoundPool._setOnLoadCompleteListener4873 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setOnLoadCompleteListener", "(Landroid/media/SoundPool$OnLoadCompleteListener;)V");
			global::android.media.SoundPool._SoundPool4874 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "<init>", "(III)V");
		}
	}
}
