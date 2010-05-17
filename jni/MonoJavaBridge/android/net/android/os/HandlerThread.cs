namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class HandlerThread : java.lang.Thread
	{ 
		internal new static global::java.lang.Class staticClass; 
		static HandlerThread() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.HandlerThread), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.HandlerThread(@__env); 
			} 
		} 
		protected HandlerThread(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _run5352; 
		public override void run() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.HandlerThread)) 
				@__env.CallVoidMethod(this, _run5352); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.HandlerThread.staticClass, _run5352); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quit5353; 
		public virtual bool quit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.HandlerThread)) 
				return @__env.CallBooleanMethod(this, _quit5353); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.HandlerThread.staticClass, _quit5353); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLooper5354; 
		public virtual android.os.Looper getLooper() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.HandlerThread)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallObjectMethodPtr(this, _getLooper5354)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.HandlerThread.staticClass, _getLooper5354)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLooperPrepared5355; 
		protected virtual void onLooperPrepared() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.HandlerThread)) 
				@__env.CallVoidMethod(this, _onLooperPrepared5355); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.HandlerThread.staticClass, _onLooperPrepared5355); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadId5356; 
		public virtual int getThreadId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.HandlerThread)) 
				return @__env.CallIntMethod(this, _getThreadId5356); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.HandlerThread.staticClass, _getThreadId5356); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HandlerThread5357; 
		public HandlerThread(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.HandlerThread.staticClass, _HandlerThread5357, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HandlerThread5358; 
		public HandlerThread(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.HandlerThread.staticClass, _HandlerThread5358, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.HandlerThread.staticClass = @__class; 
			global::android.os.HandlerThread._run5352 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "run", "()V"); 
			global::android.os.HandlerThread._quit5353 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "quit", "()Z"); 
			global::android.os.HandlerThread._getLooper5354 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "getLooper", "()Landroid/os/Looper;"); 
			global::android.os.HandlerThread._onLooperPrepared5355 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "onLooperPrepared", "()V"); 
			global::android.os.HandlerThread._getThreadId5356 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "getThreadId", "()I"); 
			global::android.os.HandlerThread._HandlerThread5357 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.os.HandlerThread._HandlerThread5358 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "<init>", "(Ljava/lang/String;I)V"); 
		} 
	} 
} 
