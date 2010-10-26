namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.BroadcastReceiver_))]
	public abstract partial class BroadcastReceiver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BroadcastReceiver()
		{
			InitJNI();
		}
		protected BroadcastReceiver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onReceive2590;
		public abstract void onReceive(android.content.Context arg0, android.content.Intent arg1);
		internal static global::MonoJavaBridge.MethodId _peekService2591;
		public virtual global::android.os.IBinder peekService(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver._peekService2591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._peekService2591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _setResultCode2592;
		public virtual void setResultCode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setResultCode2592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultCode2592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultCode2593;
		public virtual int getResultCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getResultCode2593);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultCode2593);
		}
		internal static global::MonoJavaBridge.MethodId _setResultData2594;
		public virtual void setResultData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setResultData2594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultData2594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultData2595;
		public virtual global::java.lang.String getResultData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getResultData2595)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultData2595)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setResultExtras2596;
		public virtual void setResultExtras(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setResultExtras2596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultExtras2596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultExtras2597;
		public virtual global::android.os.Bundle getResultExtras(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getResultExtras2597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultExtras2597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _setResult2598;
		public virtual void setResult(int arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setResult2598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResult2598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAbortBroadcast2599;
		public virtual bool getAbortBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getAbortBroadcast2599);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getAbortBroadcast2599);
		}
		internal static global::MonoJavaBridge.MethodId _abortBroadcast2600;
		public virtual void abortBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._abortBroadcast2600);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._abortBroadcast2600);
		}
		internal static global::MonoJavaBridge.MethodId _clearAbortBroadcast2601;
		public virtual void clearAbortBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._clearAbortBroadcast2601);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._clearAbortBroadcast2601);
		}
		internal static global::MonoJavaBridge.MethodId _isOrderedBroadcast2602;
		public virtual bool isOrderedBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver._isOrderedBroadcast2602);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._isOrderedBroadcast2602);
		}
		internal static global::MonoJavaBridge.MethodId _isInitialStickyBroadcast2603;
		public virtual bool isInitialStickyBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver._isInitialStickyBroadcast2603);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._isInitialStickyBroadcast2603);
		}
		internal static global::MonoJavaBridge.MethodId _setOrderedHint2604;
		public virtual void setOrderedHint(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setOrderedHint2604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setOrderedHint2604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDebugUnregister2605;
		public virtual void setDebugUnregister(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setDebugUnregister2605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setDebugUnregister2605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDebugUnregister2606;
		public virtual bool getDebugUnregister() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getDebugUnregister2606);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getDebugUnregister2606);
		}
		internal static global::MonoJavaBridge.MethodId _BroadcastReceiver2607;
		public BroadcastReceiver()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._BroadcastReceiver2607);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.BroadcastReceiver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/BroadcastReceiver"));
			global::android.content.BroadcastReceiver._onReceive2590 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.content.BroadcastReceiver._peekService2591 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "peekService", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.content.BroadcastReceiver._setResultCode2592 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setResultCode", "(I)V");
			global::android.content.BroadcastReceiver._getResultCode2593 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getResultCode", "()I");
			global::android.content.BroadcastReceiver._setResultData2594 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setResultData", "(Ljava/lang/String;)V");
			global::android.content.BroadcastReceiver._getResultData2595 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getResultData", "()Ljava/lang/String;");
			global::android.content.BroadcastReceiver._setResultExtras2596 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setResultExtras", "(Landroid/os/Bundle;)V");
			global::android.content.BroadcastReceiver._getResultExtras2597 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getResultExtras", "(Z)Landroid/os/Bundle;");
			global::android.content.BroadcastReceiver._setResult2598 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setResult", "(ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.BroadcastReceiver._getAbortBroadcast2599 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getAbortBroadcast", "()Z");
			global::android.content.BroadcastReceiver._abortBroadcast2600 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "abortBroadcast", "()V");
			global::android.content.BroadcastReceiver._clearAbortBroadcast2601 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "clearAbortBroadcast", "()V");
			global::android.content.BroadcastReceiver._isOrderedBroadcast2602 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "isOrderedBroadcast", "()Z");
			global::android.content.BroadcastReceiver._isInitialStickyBroadcast2603 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "isInitialStickyBroadcast", "()Z");
			global::android.content.BroadcastReceiver._setOrderedHint2604 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setOrderedHint", "(Z)V");
			global::android.content.BroadcastReceiver._setDebugUnregister2605 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setDebugUnregister", "(Z)V");
			global::android.content.BroadcastReceiver._getDebugUnregister2606 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getDebugUnregister", "()Z");
			global::android.content.BroadcastReceiver._BroadcastReceiver2607 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.BroadcastReceiver))]
	internal sealed partial class BroadcastReceiver_ : android.content.BroadcastReceiver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BroadcastReceiver_()
		{
			InitJNI();
		}
		internal BroadcastReceiver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onReceive2608;
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver_._onReceive2608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver_.staticClass, global::android.content.BroadcastReceiver_._onReceive2608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.BroadcastReceiver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/BroadcastReceiver"));
			global::android.content.BroadcastReceiver_._onReceive2608 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver_.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
		}
	}
}
