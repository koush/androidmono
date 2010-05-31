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
		internal static global::net.sf.jni4net.jni.MethodId _onReceive938; 
		public abstract void onReceive(android.content.Context arg0, android.content.Intent arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _peekService939; 
		public virtual global::android.os.IBinder peekService(android.content.Context arg0, android.content.Intent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.BroadcastReceiver._peekService939, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._peekService939, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setResultCode940; 
		public virtual void setResultCode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._setResultCode940, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultCode940, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResultCode941; 
		public virtual int getResultCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.BroadcastReceiver._getResultCode941); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultCode941); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setResultData942; 
		public virtual void setResultData(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._setResultData942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultData942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResultData943; 
		public virtual global::java.lang.String getResultData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.BroadcastReceiver._getResultData943)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultData943)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setResultExtras944; 
		public virtual void setResultExtras(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._setResultExtras944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultExtras944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResultExtras945; 
		public virtual global::android.os.Bundle getResultExtras(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.BroadcastReceiver._getResultExtras945, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultExtras945, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setResult946; 
		public virtual void setResult(int arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._setResult946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResult946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAbortBroadcast947; 
		public virtual bool getAbortBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.content.BroadcastReceiver._getAbortBroadcast947); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getAbortBroadcast947); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _abortBroadcast948; 
		public virtual void abortBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._abortBroadcast948); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._abortBroadcast948); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearAbortBroadcast949; 
		public virtual void clearAbortBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._clearAbortBroadcast949); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._clearAbortBroadcast949); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOrderedBroadcast950; 
		public virtual bool isOrderedBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.content.BroadcastReceiver._isOrderedBroadcast950); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._isOrderedBroadcast950); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInitialStickyBroadcast951; 
		public virtual bool isInitialStickyBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.content.BroadcastReceiver._isInitialStickyBroadcast951); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._isInitialStickyBroadcast951); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrderedHint952; 
		public virtual void setOrderedHint(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._setOrderedHint952, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setOrderedHint952, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDebugUnregister953; 
		public virtual void setDebugUnregister(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.BroadcastReceiver._setDebugUnregister953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setDebugUnregister953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDebugUnregister954; 
		public virtual bool getDebugUnregister() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.content.BroadcastReceiver._getDebugUnregister954); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getDebugUnregister954); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BroadcastReceiver955; 
		public BroadcastReceiver()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._BroadcastReceiver955, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.BroadcastReceiver.staticClass = @__class; 
			global::android.content.BroadcastReceiver._onReceive938 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"); 
			global::android.content.BroadcastReceiver._peekService939 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "peekService", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/os/IBinder;"); 
			global::android.content.BroadcastReceiver._setResultCode940 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setResultCode", "(I)V"); 
			global::android.content.BroadcastReceiver._getResultCode941 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getResultCode", "()I"); 
			global::android.content.BroadcastReceiver._setResultData942 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setResultData", "(Ljava/lang/String;)V"); 
			global::android.content.BroadcastReceiver._getResultData943 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getResultData", "()Ljava/lang/String;"); 
			global::android.content.BroadcastReceiver._setResultExtras944 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setResultExtras", "(Landroid/os/Bundle;)V"); 
			global::android.content.BroadcastReceiver._getResultExtras945 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getResultExtras", "(Z)Landroid/os/Bundle;"); 
			global::android.content.BroadcastReceiver._setResult946 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setResult", "(ILjava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.content.BroadcastReceiver._getAbortBroadcast947 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getAbortBroadcast", "()Z"); 
			global::android.content.BroadcastReceiver._abortBroadcast948 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "abortBroadcast", "()V"); 
			global::android.content.BroadcastReceiver._clearAbortBroadcast949 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "clearAbortBroadcast", "()V"); 
			global::android.content.BroadcastReceiver._isOrderedBroadcast950 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "isOrderedBroadcast", "()Z"); 
			global::android.content.BroadcastReceiver._isInitialStickyBroadcast951 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "isInitialStickyBroadcast", "()Z"); 
			global::android.content.BroadcastReceiver._setOrderedHint952 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setOrderedHint", "(Z)V"); 
			global::android.content.BroadcastReceiver._setDebugUnregister953 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setDebugUnregister", "(Z)V"); 
			global::android.content.BroadcastReceiver._getDebugUnregister954 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getDebugUnregister", "()Z"); 
			global::android.content.BroadcastReceiver._BroadcastReceiver955 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "<init>", "()V"); 
		} 
	} 
} 
