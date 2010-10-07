namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class BroadcastReceiver : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static BroadcastReceiver()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.BroadcastReceiver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected BroadcastReceiver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onReceive1069;
		public abstract void onReceive(android.content.Context arg0, android.content.Intent arg1);
		internal static global::net.sf.jni4net.jni.MethodId _peekService1070;
		public virtual global::android.os.IBinder peekService(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.BroadcastReceiver._peekService1070, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._peekService1070, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setResultCode1071;
		public virtual void setResultCode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._setResultCode1071, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultCode1071, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResultCode1072;
		public virtual int getResultCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.BroadcastReceiver._getResultCode1072);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultCode1072);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setResultData1073;
		public virtual void setResultData(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._setResultData1073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultData1073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResultData1074;
		public virtual global::java.lang.String getResultData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.BroadcastReceiver._getResultData1074));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultData1074));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setResultExtras1075;
		public virtual void setResultExtras(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._setResultExtras1075, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultExtras1075, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResultExtras1076;
		public virtual global::android.os.Bundle getResultExtras(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.BroadcastReceiver._getResultExtras1076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultExtras1076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setResult1077;
		public virtual void setResult(int arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._setResult1077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResult1077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAbortBroadcast1078;
		public virtual bool getAbortBroadcast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.BroadcastReceiver._getAbortBroadcast1078);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getAbortBroadcast1078);
		}
		internal static global::net.sf.jni4net.jni.MethodId _abortBroadcast1079;
		public virtual void abortBroadcast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._abortBroadcast1079);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._abortBroadcast1079);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearAbortBroadcast1080;
		public virtual void clearAbortBroadcast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._clearAbortBroadcast1080);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._clearAbortBroadcast1080);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOrderedBroadcast1081;
		public virtual bool isOrderedBroadcast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.BroadcastReceiver._isOrderedBroadcast1081);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._isOrderedBroadcast1081);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInitialStickyBroadcast1082;
		public virtual bool isInitialStickyBroadcast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.BroadcastReceiver._isInitialStickyBroadcast1082);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._isInitialStickyBroadcast1082);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOrderedHint1083;
		public virtual void setOrderedHint(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._setOrderedHint1083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setOrderedHint1083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDebugUnregister1084;
		public virtual void setDebugUnregister(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._setDebugUnregister1084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setDebugUnregister1084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDebugUnregister1085;
		public virtual bool getDebugUnregister() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.BroadcastReceiver._getDebugUnregister1085);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getDebugUnregister1085);
		}
		internal static global::net.sf.jni4net.jni.MethodId _BroadcastReceiver1086;
		public BroadcastReceiver()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._BroadcastReceiver1086, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.BroadcastReceiver.staticClass = @__class;
			global::android.content.BroadcastReceiver._onReceive1069 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.content.BroadcastReceiver._peekService1070 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "peekService", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.content.BroadcastReceiver._setResultCode1071 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setResultCode", "(I)V");
			global::android.content.BroadcastReceiver._getResultCode1072 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getResultCode", "()I");
			global::android.content.BroadcastReceiver._setResultData1073 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setResultData", "(Ljava/lang/String;)V");
			global::android.content.BroadcastReceiver._getResultData1074 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getResultData", "()Ljava/lang/String;");
			global::android.content.BroadcastReceiver._setResultExtras1075 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setResultExtras", "(Landroid/os/Bundle;)V");
			global::android.content.BroadcastReceiver._getResultExtras1076 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getResultExtras", "(Z)Landroid/os/Bundle;");
			global::android.content.BroadcastReceiver._setResult1077 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setResult", "(ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.BroadcastReceiver._getAbortBroadcast1078 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getAbortBroadcast", "()Z");
			global::android.content.BroadcastReceiver._abortBroadcast1079 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "abortBroadcast", "()V");
			global::android.content.BroadcastReceiver._clearAbortBroadcast1080 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "clearAbortBroadcast", "()V");
			global::android.content.BroadcastReceiver._isOrderedBroadcast1081 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "isOrderedBroadcast", "()Z");
			global::android.content.BroadcastReceiver._isInitialStickyBroadcast1082 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "isInitialStickyBroadcast", "()Z");
			global::android.content.BroadcastReceiver._setOrderedHint1083 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setOrderedHint", "(Z)V");
			global::android.content.BroadcastReceiver._setDebugUnregister1084 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setDebugUnregister", "(Z)V");
			global::android.content.BroadcastReceiver._getDebugUnregister1085 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getDebugUnregister", "()Z");
			global::android.content.BroadcastReceiver._BroadcastReceiver1086 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "<init>", "()V");
		}
	}
}
