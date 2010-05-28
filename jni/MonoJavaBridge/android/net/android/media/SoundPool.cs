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
		internal static global::net.sf.jni4net.jni.MethodId _load4592; 
		public virtual int load(android.content.Context arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				return @__env.CallIntMethod(this, global::android.media.SoundPool._load4592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load4592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _load4593; 
		public virtual int load(android.content.res.AssetFileDescriptor arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				return @__env.CallIntMethod(this, global::android.media.SoundPool._load4593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load4593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _load4594; 
		public virtual int load(java.io.FileDescriptor arg0, long arg1, long arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				return @__env.CallIntMethod(this, global::android.media.SoundPool._load4594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load4594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _load4595; 
		public virtual int load(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				return @__env.CallIntMethod(this, global::android.media.SoundPool._load4595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load4595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPriority4596; 
		public virtual void setPriority(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, global::android.media.SoundPool._setPriority4596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setPriority4596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop4597; 
		public virtual void stop(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, global::android.media.SoundPool._stop4597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._stop4597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resume4598; 
		public virtual void resume(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, global::android.media.SoundPool._resume4598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._resume4598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release4599; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, global::android.media.SoundPool._release4599); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._release4599); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unload4600; 
		public virtual bool unload(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				return @__env.CallBooleanMethod(this, global::android.media.SoundPool._unload4600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._unload4600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _play4601; 
		public virtual int play(int arg0, float arg1, float arg2, int arg3, int arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				return @__env.CallIntMethod(this, global::android.media.SoundPool._play4601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._play4601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pause4602; 
		public virtual void pause(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, global::android.media.SoundPool._pause4602, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._pause4602, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVolume4603; 
		public virtual void setVolume(int arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, global::android.media.SoundPool._setVolume4603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setVolume4603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLoop4604; 
		public virtual void setLoop(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, global::android.media.SoundPool._setLoop4604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setLoop4604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRate4605; 
		public virtual void setRate(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, global::android.media.SoundPool._setRate4605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setRate4605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SoundPool4606; 
		public SoundPool(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.SoundPool.staticClass, global::android.media.SoundPool._SoundPool4606, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.SoundPool.staticClass = @__class; 
			global::android.media.SoundPool._load4592 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "load", "(Landroid/content/Context;II)I"); 
			global::android.media.SoundPool._load4593 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "load", "(Landroid/content/res/AssetFileDescriptor;I)I"); 
			global::android.media.SoundPool._load4594 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "load", "(Ljava/io/FileDescriptor;JJI)I"); 
			global::android.media.SoundPool._load4595 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "load", "(Ljava/lang/String;I)I"); 
			global::android.media.SoundPool._setPriority4596 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setPriority", "(II)V"); 
			global::android.media.SoundPool._stop4597 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "stop", "(I)V"); 
			global::android.media.SoundPool._resume4598 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "resume", "(I)V"); 
			global::android.media.SoundPool._release4599 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "release", "()V"); 
			global::android.media.SoundPool._unload4600 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "unload", "(I)Z"); 
			global::android.media.SoundPool._play4601 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "play", "(IFFIIF)I"); 
			global::android.media.SoundPool._pause4602 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "pause", "(I)V"); 
			global::android.media.SoundPool._setVolume4603 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setVolume", "(IFF)V"); 
			global::android.media.SoundPool._setLoop4604 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setLoop", "(II)V"); 
			global::android.media.SoundPool._setRate4605 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setRate", "(IF)V"); 
			global::android.media.SoundPool._SoundPool4606 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "<init>", "(III)V"); 
		} 
	} 
} 
