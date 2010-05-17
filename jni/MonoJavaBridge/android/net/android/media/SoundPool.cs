namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SoundPool : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SoundPool() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.SoundPool), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _load4344; 
		public virtual int load(android.content.Context arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				return @__env.CallIntMethod(this, _load4344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.SoundPool.staticClass, _load4344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _load4345; 
		public virtual int load(android.content.res.AssetFileDescriptor arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				return @__env.CallIntMethod(this, _load4345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.SoundPool.staticClass, _load4345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _load4346; 
		public virtual int load(java.io.FileDescriptor arg0, long arg1, long arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				return @__env.CallIntMethod(this, _load4346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.SoundPool.staticClass, _load4346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _load4347; 
		public virtual int load(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				return @__env.CallIntMethod(this, _load4347, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.SoundPool.staticClass, _load4347, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPriority4348; 
		public virtual void setPriority(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, _setPriority4348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.SoundPool.staticClass, _setPriority4348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop4349; 
		public virtual void stop(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, _stop4349, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.SoundPool.staticClass, _stop4349, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resume4350; 
		public virtual void resume(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, _resume4350, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.SoundPool.staticClass, _resume4350, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release4351; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, _release4351); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.SoundPool.staticClass, _release4351); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unload4352; 
		public virtual bool unload(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				return @__env.CallBooleanMethod(this, _unload4352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.SoundPool.staticClass, _unload4352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _play4353; 
		public virtual int play(int arg0, float arg1, float arg2, int arg3, int arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				return @__env.CallIntMethod(this, _play4353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.SoundPool.staticClass, _play4353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pause4354; 
		public virtual void pause(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, _pause4354, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.SoundPool.staticClass, _pause4354, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVolume4355; 
		public virtual void setVolume(int arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, _setVolume4355, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.SoundPool.staticClass, _setVolume4355, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLoop4356; 
		public virtual void setLoop(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, _setLoop4356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.SoundPool.staticClass, _setLoop4356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRate4357; 
		public virtual void setRate(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.SoundPool)) 
				@__env.CallVoidMethod(this, _setRate4357, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.SoundPool.staticClass, _setRate4357, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SoundPool4358; 
		public SoundPool(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.SoundPool.staticClass, _SoundPool4358, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.SoundPool.staticClass = @__class; 
			global::android.media.SoundPool._load4344 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "load", "(Landroid/content/Context;II)I"); 
			global::android.media.SoundPool._load4345 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "load", "(Landroid/content/res/AssetFileDescriptor;I)I"); 
			global::android.media.SoundPool._load4346 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "load", "(Ljava/io/FileDescriptor;JJI)I"); 
			global::android.media.SoundPool._load4347 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "load", "(Ljava/lang/String;I)I"); 
			global::android.media.SoundPool._setPriority4348 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setPriority", "(II)V"); 
			global::android.media.SoundPool._stop4349 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "stop", "(I)V"); 
			global::android.media.SoundPool._resume4350 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "resume", "(I)V"); 
			global::android.media.SoundPool._release4351 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "release", "()V"); 
			global::android.media.SoundPool._unload4352 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "unload", "(I)Z"); 
			global::android.media.SoundPool._play4353 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "play", "(IFFIIF)I"); 
			global::android.media.SoundPool._pause4354 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "pause", "(I)V"); 
			global::android.media.SoundPool._setVolume4355 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setVolume", "(IFF)V"); 
			global::android.media.SoundPool._setLoop4356 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setLoop", "(II)V"); 
			global::android.media.SoundPool._setRate4357 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "setRate", "(IF)V"); 
			global::android.media.SoundPool._SoundPool4358 = @__env.GetMethodID(global::android.media.SoundPool.staticClass, "<init>", "(III)V"); 
		} 
	} 
} 
