namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.BroadcastReceiver_))]
	public abstract partial class BroadcastReceiver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BroadcastReceiver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void onReceive(android.content.Context arg0, android.content.Intent arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.os.IBinder peekService(android.content.Context arg0, android.content.Intent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.content.BroadcastReceiver.staticClass, "peekService", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/os/IBinder;", ref global::android.content.BroadcastReceiver._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.IBinder;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setResultCode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "setResultCode", "(I)V", ref global::android.content.BroadcastReceiver._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getResultCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.BroadcastReceiver.staticClass, "getResultCode", "()I", ref global::android.content.BroadcastReceiver._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setResultData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "setResultData", "(Ljava/lang/String;)V", ref global::android.content.BroadcastReceiver._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getResultData()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.BroadcastReceiver.staticClass, "getResultData", "()Ljava/lang/String;", ref global::android.content.BroadcastReceiver._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setResultExtras(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "setResultExtras", "(Landroid/os/Bundle;)V", ref global::android.content.BroadcastReceiver._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.os.Bundle getResultExtras(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.content.BroadcastReceiver.staticClass, "getResultExtras", "(Z)Landroid/os/Bundle;", ref global::android.content.BroadcastReceiver._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setResult(int arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "setResult", "(ILjava/lang/String;Landroid/os/Bundle;)V", ref global::android.content.BroadcastReceiver._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool getAbortBroadcast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, "getAbortBroadcast", "()Z", ref global::android.content.BroadcastReceiver._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void abortBroadcast()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "abortBroadcast", "()V", ref global::android.content.BroadcastReceiver._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void clearAbortBroadcast()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "clearAbortBroadcast", "()V", ref global::android.content.BroadcastReceiver._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isOrderedBroadcast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, "isOrderedBroadcast", "()Z", ref global::android.content.BroadcastReceiver._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool isInitialStickyBroadcast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, "isInitialStickyBroadcast", "()Z", ref global::android.content.BroadcastReceiver._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setOrderedHint(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "setOrderedHint", "(Z)V", ref global::android.content.BroadcastReceiver._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setDebugUnregister(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "setDebugUnregister", "(Z)V", ref global::android.content.BroadcastReceiver._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool getDebugUnregister()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, "getDebugUnregister", "()Z", ref global::android.content.BroadcastReceiver._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public BroadcastReceiver() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.BroadcastReceiver._m17.native == global::System.IntPtr.Zero)
				global::android.content.BroadcastReceiver._m17 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._m17);
			Init(@__env, handle);
		}
		static BroadcastReceiver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.BroadcastReceiver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/BroadcastReceiver"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.BroadcastReceiver))]
	internal sealed partial class BroadcastReceiver_ : android.content.BroadcastReceiver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BroadcastReceiver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver_.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", ref global::android.content.BroadcastReceiver_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static BroadcastReceiver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.BroadcastReceiver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/BroadcastReceiver"));
		}
	}
}
