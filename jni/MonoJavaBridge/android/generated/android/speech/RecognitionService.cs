namespace android.speech
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.speech.RecognitionService_))]
	public abstract partial class RecognitionService : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RecognitionService()
		{
			InitJNI();
		}
		protected RecognitionService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Callback : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Callback()
			{
				InitJNI();
			}
			protected Callback(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _error7291;
			public virtual void error(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._error7291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._error7291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _results7292;
			public virtual void results(android.os.Bundle arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._results7292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._results7292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _beginningOfSpeech7293;
			public virtual void beginningOfSpeech() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._beginningOfSpeech7293);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._beginningOfSpeech7293);
			}
			internal static global::MonoJavaBridge.MethodId _bufferReceived7294;
			public virtual void bufferReceived(byte[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._bufferReceived7294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._bufferReceived7294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _endOfSpeech7295;
			public virtual void endOfSpeech() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._endOfSpeech7295);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._endOfSpeech7295);
			}
			internal static global::MonoJavaBridge.MethodId _partialResults7296;
			public virtual void partialResults(android.os.Bundle arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._partialResults7296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._partialResults7296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _readyForSpeech7297;
			public virtual void readyForSpeech(android.os.Bundle arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._readyForSpeech7297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._readyForSpeech7297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _rmsChanged7298;
			public virtual void rmsChanged(float arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._rmsChanged7298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._rmsChanged7298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.speech.RecognitionService.Callback.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/RecognitionService$Callback"));
				global::android.speech.RecognitionService.Callback._error7291 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "error", "(I)V");
				global::android.speech.RecognitionService.Callback._results7292 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "results", "(Landroid/os/Bundle;)V");
				global::android.speech.RecognitionService.Callback._beginningOfSpeech7293 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "beginningOfSpeech", "()V");
				global::android.speech.RecognitionService.Callback._bufferReceived7294 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "bufferReceived", "([B)V");
				global::android.speech.RecognitionService.Callback._endOfSpeech7295 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "endOfSpeech", "()V");
				global::android.speech.RecognitionService.Callback._partialResults7296 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "partialResults", "(Landroid/os/Bundle;)V");
				global::android.speech.RecognitionService.Callback._readyForSpeech7297 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "readyForSpeech", "(Landroid/os/Bundle;)V");
				global::android.speech.RecognitionService.Callback._rmsChanged7298 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "rmsChanged", "(F)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onBind7299;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.speech.RecognitionService._onBind7299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.speech.RecognitionService.staticClass, global::android.speech.RecognitionService._onBind7299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy7300;
		public override void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService._onDestroy7300);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.staticClass, global::android.speech.RecognitionService._onDestroy7300);
		}
		internal static global::MonoJavaBridge.MethodId _onCancel7301;
		protected abstract void onCancel(android.speech.RecognitionService.Callback arg0);
		internal static global::MonoJavaBridge.MethodId _onStartListening7302;
		protected abstract void onStartListening(android.content.Intent arg0, android.speech.RecognitionService.Callback arg1);
		internal static global::MonoJavaBridge.MethodId _onStopListening7303;
		protected abstract void onStopListening(android.speech.RecognitionService.Callback arg0);
		internal static global::MonoJavaBridge.MethodId _RecognitionService7304;
		public RecognitionService()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.speech.RecognitionService.staticClass, global::android.speech.RecognitionService._RecognitionService7304);
			Init(@__env, handle);
		}
		public static global::java.lang.String SERVICE_INTERFACE
		{
			get
			{
				return "android.speech.RecognitionService";
			}
		}
		public static global::java.lang.String SERVICE_META_DATA
		{
			get
			{
				return "android.speech";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.RecognitionService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/RecognitionService"));
			global::android.speech.RecognitionService._onBind7299 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.speech.RecognitionService._onDestroy7300 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "onDestroy", "()V");
			global::android.speech.RecognitionService._onCancel7301 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "onCancel", "(Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService._onStartListening7302 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "onStartListening", "(Landroid/content/Intent;Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService._onStopListening7303 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "onStopListening", "(Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService._RecognitionService7304 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.speech.RecognitionService))]
	public sealed partial class RecognitionService_ : android.speech.RecognitionService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RecognitionService_()
		{
			InitJNI();
		}
		internal RecognitionService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCancel7305;
		protected override void onCancel(android.speech.RecognitionService.Callback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService_._onCancel7305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService_.staticClass, global::android.speech.RecognitionService_._onCancel7305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStartListening7306;
		protected override void onStartListening(android.content.Intent arg0, android.speech.RecognitionService.Callback arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService_._onStartListening7306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService_.staticClass, global::android.speech.RecognitionService_._onStartListening7306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onStopListening7307;
		protected override void onStopListening(android.speech.RecognitionService.Callback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService_._onStopListening7307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService_.staticClass, global::android.speech.RecognitionService_._onStopListening7307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.RecognitionService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/RecognitionService"));
			global::android.speech.RecognitionService_._onCancel7305 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService_.staticClass, "onCancel", "(Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService_._onStartListening7306 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService_.staticClass, "onStartListening", "(Landroid/content/Intent;Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService_._onStopListening7307 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService_.staticClass, "onStopListening", "(Landroid/speech/RecognitionService$Callback;)V");
		}
	}
}
