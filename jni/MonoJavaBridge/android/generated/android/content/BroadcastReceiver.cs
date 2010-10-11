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
		internal static global::MonoJavaBridge.MethodId _onReceive1085;
		public abstract void onReceive(android.content.Context arg0, android.content.Intent arg1);
		internal static global::MonoJavaBridge.MethodId _peekService1086;
		public virtual global::android.os.IBinder peekService(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver._peekService1086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._peekService1086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _setResultCode1087;
		public virtual void setResultCode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setResultCode1087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultCode1087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultCode1088;
		public virtual int getResultCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getResultCode1088);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultCode1088);
		}
		internal static global::MonoJavaBridge.MethodId _setResultData1089;
		public virtual void setResultData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setResultData1089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultData1089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultData1090;
		public virtual global::java.lang.String getResultData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getResultData1090)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultData1090)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setResultExtras1091;
		public virtual void setResultExtras(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setResultExtras1091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultExtras1091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultExtras1092;
		public virtual global::android.os.Bundle getResultExtras(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getResultExtras1092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultExtras1092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _setResult1093;
		public virtual void setResult(int arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setResult1093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResult1093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAbortBroadcast1094;
		public virtual bool getAbortBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getAbortBroadcast1094);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getAbortBroadcast1094);
		}
		internal static global::MonoJavaBridge.MethodId _abortBroadcast1095;
		public virtual void abortBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._abortBroadcast1095);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._abortBroadcast1095);
		}
		internal static global::MonoJavaBridge.MethodId _clearAbortBroadcast1096;
		public virtual void clearAbortBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._clearAbortBroadcast1096);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._clearAbortBroadcast1096);
		}
		internal static global::MonoJavaBridge.MethodId _isOrderedBroadcast1097;
		public virtual bool isOrderedBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver._isOrderedBroadcast1097);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._isOrderedBroadcast1097);
		}
		internal static global::MonoJavaBridge.MethodId _isInitialStickyBroadcast1098;
		public virtual bool isInitialStickyBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver._isInitialStickyBroadcast1098);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._isInitialStickyBroadcast1098);
		}
		internal static global::MonoJavaBridge.MethodId _setOrderedHint1099;
		public virtual void setOrderedHint(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setOrderedHint1099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setOrderedHint1099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDebugUnregister1100;
		public virtual void setDebugUnregister(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setDebugUnregister1100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setDebugUnregister1100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDebugUnregister1101;
		public virtual bool getDebugUnregister() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getDebugUnregister1101);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getDebugUnregister1101);
		}
		internal static global::MonoJavaBridge.MethodId _BroadcastReceiver1102;
		public BroadcastReceiver()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._BroadcastReceiver1102);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.BroadcastReceiver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/BroadcastReceiver"));
			global::android.content.BroadcastReceiver._onReceive1085 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.content.BroadcastReceiver._peekService1086 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "peekService", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.content.BroadcastReceiver._setResultCode1087 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setResultCode", "(I)V");
			global::android.content.BroadcastReceiver._getResultCode1088 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getResultCode", "()I");
			global::android.content.BroadcastReceiver._setResultData1089 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setResultData", "(Ljava/lang/String;)V");
			global::android.content.BroadcastReceiver._getResultData1090 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getResultData", "()Ljava/lang/String;");
			global::android.content.BroadcastReceiver._setResultExtras1091 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setResultExtras", "(Landroid/os/Bundle;)V");
			global::android.content.BroadcastReceiver._getResultExtras1092 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getResultExtras", "(Z)Landroid/os/Bundle;");
			global::android.content.BroadcastReceiver._setResult1093 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setResult", "(ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.BroadcastReceiver._getAbortBroadcast1094 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getAbortBroadcast", "()Z");
			global::android.content.BroadcastReceiver._abortBroadcast1095 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "abortBroadcast", "()V");
			global::android.content.BroadcastReceiver._clearAbortBroadcast1096 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "clearAbortBroadcast", "()V");
			global::android.content.BroadcastReceiver._isOrderedBroadcast1097 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "isOrderedBroadcast", "()Z");
			global::android.content.BroadcastReceiver._isInitialStickyBroadcast1098 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "isInitialStickyBroadcast", "()Z");
			global::android.content.BroadcastReceiver._setOrderedHint1099 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setOrderedHint", "(Z)V");
			global::android.content.BroadcastReceiver._setDebugUnregister1100 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setDebugUnregister", "(Z)V");
			global::android.content.BroadcastReceiver._getDebugUnregister1101 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getDebugUnregister", "()Z");
			global::android.content.BroadcastReceiver._BroadcastReceiver1102 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.BroadcastReceiver))]
	public sealed partial class BroadcastReceiver_ : android.content.BroadcastReceiver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BroadcastReceiver_()
		{
			InitJNI();
		}
		internal BroadcastReceiver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onReceive1103;
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver_._onReceive1103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver_.staticClass, global::android.content.BroadcastReceiver_._onReceive1103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.BroadcastReceiver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/BroadcastReceiver"));
			global::android.content.BroadcastReceiver_._onReceive1103 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver_.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
		}
	}
}
