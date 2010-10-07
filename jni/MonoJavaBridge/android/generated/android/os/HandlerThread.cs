namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class HandlerThread : java.lang.Thread
	{
		internal new static global::java.lang.Class staticClass;
		static HandlerThread()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.HandlerThread), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _run6184;
		public override void run() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.HandlerThread._run6184);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._run6184);
		}
		internal static global::net.sf.jni4net.jni.MethodId _quit6185;
		public virtual bool quit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.HandlerThread._quit6185);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._quit6185);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLooper6186;
		public virtual global::android.os.Looper getLooper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.HandlerThread._getLooper6186));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._getLooper6186));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLooperPrepared6187;
		protected virtual void onLooperPrepared() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.HandlerThread._onLooperPrepared6187);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._onLooperPrepared6187);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThreadId6188;
		public virtual int getThreadId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.HandlerThread._getThreadId6188);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._getThreadId6188);
		}
		internal static global::net.sf.jni4net.jni.MethodId _HandlerThread6189;
		public HandlerThread(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.HandlerThread.staticClass, global::android.os.HandlerThread._HandlerThread6189, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HandlerThread6190;
		public HandlerThread(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.HandlerThread.staticClass, global::android.os.HandlerThread._HandlerThread6190, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.HandlerThread.staticClass = @__class;
			global::android.os.HandlerThread._run6184 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "run", "()V");
			global::android.os.HandlerThread._quit6185 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "quit", "()Z");
			global::android.os.HandlerThread._getLooper6186 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "getLooper", "()Landroid/os/Looper;");
			global::android.os.HandlerThread._onLooperPrepared6187 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "onLooperPrepared", "()V");
			global::android.os.HandlerThread._getThreadId6188 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "getThreadId", "()I");
			global::android.os.HandlerThread._HandlerThread6189 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.os.HandlerThread._HandlerThread6190 = @__env.GetMethodID(global::android.os.HandlerThread.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
