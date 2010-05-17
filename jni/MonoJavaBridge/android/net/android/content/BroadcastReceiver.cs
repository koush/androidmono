namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class BroadcastReceiver : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static BroadcastReceiver() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.BroadcastReceiver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected BroadcastReceiver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceive925; 
		public abstract void onReceive(android.content.Context arg0, android.content.Intent arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _peekService926; 
		public virtual android.os.IBinder peekService(android.content.Context arg0, android.content.Intent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, _peekService926, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.BroadcastReceiver.staticClass, _peekService926, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setResultCode927; 
		public virtual void setResultCode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				@__env.CallVoidMethod(this, _setResultCode927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.BroadcastReceiver.staticClass, _setResultCode927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResultCode928; 
		public virtual int getResultCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				return @__env.CallIntMethod(this, _getResultCode928); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.BroadcastReceiver.staticClass, _getResultCode928); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setResultData929; 
		public virtual void setResultData(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				@__env.CallVoidMethod(this, _setResultData929, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.BroadcastReceiver.staticClass, _setResultData929, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResultData930; 
		public virtual java.lang.String getResultData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getResultData930)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.BroadcastReceiver.staticClass, _getResultData930)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setResultExtras931; 
		public virtual void setResultExtras(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				@__env.CallVoidMethod(this, _setResultExtras931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.BroadcastReceiver.staticClass, _setResultExtras931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResultExtras932; 
		public virtual android.os.Bundle getResultExtras(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getResultExtras932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.BroadcastReceiver.staticClass, _getResultExtras932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setResult933; 
		public virtual void setResult(int arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				@__env.CallVoidMethod(this, _setResult933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.BroadcastReceiver.staticClass, _setResult933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAbortBroadcast934; 
		public virtual bool getAbortBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				return @__env.CallBooleanMethod(this, _getAbortBroadcast934); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.BroadcastReceiver.staticClass, _getAbortBroadcast934); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _abortBroadcast935; 
		public virtual void abortBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				@__env.CallVoidMethod(this, _abortBroadcast935); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.BroadcastReceiver.staticClass, _abortBroadcast935); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearAbortBroadcast936; 
		public virtual void clearAbortBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				@__env.CallVoidMethod(this, _clearAbortBroadcast936); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.BroadcastReceiver.staticClass, _clearAbortBroadcast936); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOrderedBroadcast937; 
		public virtual bool isOrderedBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				return @__env.CallBooleanMethod(this, _isOrderedBroadcast937); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.BroadcastReceiver.staticClass, _isOrderedBroadcast937); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInitialStickyBroadcast938; 
		public virtual bool isInitialStickyBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				return @__env.CallBooleanMethod(this, _isInitialStickyBroadcast938); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.BroadcastReceiver.staticClass, _isInitialStickyBroadcast938); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrderedHint939; 
		public virtual void setOrderedHint(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				@__env.CallVoidMethod(this, _setOrderedHint939, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.BroadcastReceiver.staticClass, _setOrderedHint939, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDebugUnregister940; 
		public virtual void setDebugUnregister(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				@__env.CallVoidMethod(this, _setDebugUnregister940, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.BroadcastReceiver.staticClass, _setDebugUnregister940, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDebugUnregister941; 
		public virtual bool getDebugUnregister() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.BroadcastReceiver)) 
				return @__env.CallBooleanMethod(this, _getDebugUnregister941); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.BroadcastReceiver.staticClass, _getDebugUnregister941); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BroadcastReceiver942; 
		public BroadcastReceiver()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.BroadcastReceiver.staticClass, _BroadcastReceiver942, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.BroadcastReceiver.staticClass = @__class; 
			global::android.content.BroadcastReceiver._onReceive925 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"); 
			global::android.content.BroadcastReceiver._peekService926 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "peekService", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/os/IBinder;"); 
			global::android.content.BroadcastReceiver._setResultCode927 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setResultCode", "(I)V"); 
			global::android.content.BroadcastReceiver._getResultCode928 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getResultCode", "()I"); 
			global::android.content.BroadcastReceiver._setResultData929 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setResultData", "(Ljava/lang/String;)V"); 
			global::android.content.BroadcastReceiver._getResultData930 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getResultData", "()Ljava/lang/String;"); 
			global::android.content.BroadcastReceiver._setResultExtras931 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setResultExtras", "(Landroid/os/Bundle;)V"); 
			global::android.content.BroadcastReceiver._getResultExtras932 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getResultExtras", "(Z)Landroid/os/Bundle;"); 
			global::android.content.BroadcastReceiver._setResult933 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setResult", "(ILjava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.content.BroadcastReceiver._getAbortBroadcast934 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getAbortBroadcast", "()Z"); 
			global::android.content.BroadcastReceiver._abortBroadcast935 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "abortBroadcast", "()V"); 
			global::android.content.BroadcastReceiver._clearAbortBroadcast936 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "clearAbortBroadcast", "()V"); 
			global::android.content.BroadcastReceiver._isOrderedBroadcast937 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "isOrderedBroadcast", "()Z"); 
			global::android.content.BroadcastReceiver._isInitialStickyBroadcast938 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "isInitialStickyBroadcast", "()Z"); 
			global::android.content.BroadcastReceiver._setOrderedHint939 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setOrderedHint", "(Z)V"); 
			global::android.content.BroadcastReceiver._setDebugUnregister940 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "setDebugUnregister", "(Z)V"); 
			global::android.content.BroadcastReceiver._getDebugUnregister941 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "getDebugUnregister", "()Z"); 
			global::android.content.BroadcastReceiver._BroadcastReceiver942 = @__env.GetMethodID(global::android.content.BroadcastReceiver.staticClass, "<init>", "()V"); 
		} 
	} 
} 
