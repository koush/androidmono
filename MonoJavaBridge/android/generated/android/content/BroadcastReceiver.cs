namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.BroadcastReceiver_))]
	public abstract partial class BroadcastReceiver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BroadcastReceiver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onReceive2590;
		public abstract void onReceive(android.content.Context arg0, android.content.Intent arg1);
		internal static global::MonoJavaBridge.MethodId _peekService2591;
		public virtual global::android.os.IBinder peekService(android.content.Context arg0, android.content.Intent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.content.BroadcastReceiver.staticClass, "peekService", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/os/IBinder;", ref global::android.content.BroadcastReceiver._peekService2591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _setResultCode2592;
		public virtual void setResultCode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "setResultCode", "(I)V", ref global::android.content.BroadcastReceiver._setResultCode2592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultCode2593;
		public virtual int getResultCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.BroadcastReceiver.staticClass, "getResultCode", "()I", ref global::android.content.BroadcastReceiver._getResultCode2593);
		}
		internal static global::MonoJavaBridge.MethodId _setResultData2594;
		public virtual void setResultData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "setResultData", "(Ljava/lang/String;)V", ref global::android.content.BroadcastReceiver._setResultData2594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultData2595;
		public virtual global::java.lang.String getResultData()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.BroadcastReceiver.staticClass, "getResultData", "()Ljava/lang/String;", ref global::android.content.BroadcastReceiver._getResultData2595) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setResultExtras2596;
		public virtual void setResultExtras(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "setResultExtras", "(Landroid/os/Bundle;)V", ref global::android.content.BroadcastReceiver._setResultExtras2596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultExtras2597;
		public virtual global::android.os.Bundle getResultExtras(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.content.BroadcastReceiver.staticClass, "getResultExtras", "(Z)Landroid/os/Bundle;", ref global::android.content.BroadcastReceiver._getResultExtras2597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _setResult2598;
		public virtual void setResult(int arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "setResult", "(ILjava/lang/String;Landroid/os/Bundle;)V", ref global::android.content.BroadcastReceiver._setResult2598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAbortBroadcast2599;
		public virtual bool getAbortBroadcast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, "getAbortBroadcast", "()Z", ref global::android.content.BroadcastReceiver._getAbortBroadcast2599);
		}
		internal static global::MonoJavaBridge.MethodId _abortBroadcast2600;
		public virtual void abortBroadcast()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "abortBroadcast", "()V", ref global::android.content.BroadcastReceiver._abortBroadcast2600);
		}
		internal static global::MonoJavaBridge.MethodId _clearAbortBroadcast2601;
		public virtual void clearAbortBroadcast()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "clearAbortBroadcast", "()V", ref global::android.content.BroadcastReceiver._clearAbortBroadcast2601);
		}
		internal static global::MonoJavaBridge.MethodId _isOrderedBroadcast2602;
		public virtual bool isOrderedBroadcast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, "isOrderedBroadcast", "()Z", ref global::android.content.BroadcastReceiver._isOrderedBroadcast2602);
		}
		internal static global::MonoJavaBridge.MethodId _isInitialStickyBroadcast2603;
		public virtual bool isInitialStickyBroadcast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, "isInitialStickyBroadcast", "()Z", ref global::android.content.BroadcastReceiver._isInitialStickyBroadcast2603);
		}
		internal static global::MonoJavaBridge.MethodId _setOrderedHint2604;
		public virtual void setOrderedHint(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "setOrderedHint", "(Z)V", ref global::android.content.BroadcastReceiver._setOrderedHint2604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDebugUnregister2605;
		public virtual void setDebugUnregister(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, "setDebugUnregister", "(Z)V", ref global::android.content.BroadcastReceiver._setDebugUnregister2605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDebugUnregister2606;
		public virtual bool getDebugUnregister()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, "getDebugUnregister", "()Z", ref global::android.content.BroadcastReceiver._getDebugUnregister2606);
		}
		internal static global::MonoJavaBridge.MethodId _BroadcastReceiver2607;
		public BroadcastReceiver() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.BroadcastReceiver._BroadcastReceiver2607.native == global::System.IntPtr.Zero)
				global::android.content.BroadcastReceiver._BroadcastReceiver2607 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._BroadcastReceiver2607);
			Init(@__env, handle);
		}
		static BroadcastReceiver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.BroadcastReceiver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/BroadcastReceiver"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.BroadcastReceiver))]
	internal sealed partial class BroadcastReceiver_ : android.content.BroadcastReceiver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BroadcastReceiver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onReceive2608;
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.BroadcastReceiver_.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", ref global::android.content.BroadcastReceiver_._onReceive2608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static BroadcastReceiver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.BroadcastReceiver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/BroadcastReceiver"));
		}
		internal static void InitJNI()
		{
		}
	}
}
